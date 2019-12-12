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
        public string signed_helloworld(string wsBrugerid, string wsPassword)
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

        public void SaveEmployeesFromInstitution(string wsBrugerid, string wsPassword, string institution_nr)
        {
            List<string> employee_cprs = new List<string>();
            WsiEksportPortTypeClient s = new WsiEksportPortTypeClient();
            EksporterXml eksporterXml = new EksporterXml();
            eksporterXml.wsBrugerid = wsBrugerid;
            eksporterXml.wsPassword = wsPassword;
            eksporterXml.instnr = institution_nr;
            var test = s.eksporterXmlMellem(eksporterXml);

            foreach (institutionPersonMedium p in test.xml.UNILoginExport.Institution.InstitutionPerson)
            {
                var name = p.UNILogin.Name;
                var uniclogin = p.UNILogin.UserId;
                var cpr = p.UNILogin.CivilRegistrationNumber;
                var email = p.Person.EmailAddress;

                if (employee_cprs.Contains(cpr))
                {
                    // DO STUFF
                }
            }


        }
    }
}
