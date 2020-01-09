using Lib_ws17_service.dal;
using Lib_ws17_service.WsiEksport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_ws17_service.services
{
    public class Unic_ws17_service
    {
        private string wsBrugerid;
        private string wsPassword;
        private string lora_constr;
        public Unic_ws17_service(string wsBrugerid, string wsPassword, string lora_constr)
        {
            this.wsBrugerid = wsBrugerid;
            this.wsPassword = wsPassword;
            this.lora_constr = lora_constr;
        }

        public string signed_helloworld()
        {
            WsiEksportPortTypeClient s = new WsiEksportPortTypeClient();
            helloWorldRequest req = new helloWorldRequest();
            NoArgs noargs = new NoArgs();
            Credentials creds = new Credentials();
            creds.wsBrugerid = wsBrugerid;
            creds.wsPassword = wsPassword;
            var test = s.helloWorldWithCredentials(creds);
            return test.helloWorldResult;
        }

        private Dictionary<string, unic_username> Get_employees_from_UnicWS17()
        {
            Institutions_repo repo = new Institutions_repo(lora_constr);
            List<string> institution_nrs = repo.Query.Select(i => i.institution_nr).ToList<string>();
            Position_repo pos_repo = new Position_repo(lora_constr);
            Unic_usernames_repo unic_repo = new Unic_usernames_repo(lora_constr);
            List<string> employee_cprs = pos_repo.Cprs;

            WsiEksportPortTypeClient s = new WsiEksportPortTypeClient();
            Dictionary<string, unic_username> res = new Dictionary<string, unic_username>();

            foreach (string institution_nr in institution_nrs)
            {
                EksporterXml eksporterXml = new EksporterXml();
                eksporterXml.wsBrugerid = wsBrugerid;
                eksporterXml.wsPassword = wsPassword;
                eksporterXml.instnr = institution_nr;
                var test = s.eksporterXmlMellem(eksporterXml);
                uniLoginExportMedium exm = test.xml.UNILoginExport;

                if (exm.Institution != null)
                {
                    if (exm.Institution.InstitutionPerson != null)
                    {
                        foreach (institutionPersonMedium p in test.xml.UNILoginExport.Institution.InstitutionPerson)
                        {
                            var name = p.UNILogin.Name;
                            var uniclogin = p.UNILogin.UserId;
                            var cpr = p.UNILogin.CivilRegistrationNumber;
                            //var email = p.Person.EmailAddress;

                            if (employee_cprs.Contains(cpr))
                            {
                                unic_username item = new unic_username() { cpr = cpr, unic_userid = uniclogin, institution_nr = institution_nr };
                                res[uniclogin] = item;
                                unic_repo.Add(item);
                            }
                        }
                    }
                }
            }
            return res;
        }

        public void Save_and_update_UNICEmployees()
        {
            Unic_usernames_repo repo = new Unic_usernames_repo(lora_constr);
            Dictionary<string, unic_username> unic_employees = Get_employees_from_UnicWS17();
            List<string> sofd_unic_users = repo.Query.Select(u => u.unic_userid).ToList<string>();

            foreach(KeyValuePair<string, unic_username> kvp in unic_employees)
            {
                if (!sofd_unic_users.Contains(kvp.Key))
                {
                    repo.Add(kvp.Value);
                }
            }

            foreach(string unic_id in sofd_unic_users)
            {
                if (!unic_employees.ContainsKey(unic_id))
                {
                    unic_username to_del = repo.Query.Where(u => u.unic_userid == unic_id).First();
                    repo.Delete(to_del);
                }
            }
        }
    }
}
