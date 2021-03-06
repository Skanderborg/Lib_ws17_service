﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lib_ws17_service.dal
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LORA_SOFD")]
	public partial class lora_sofdDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertinstitution(institution instance);
    partial void Updateinstitution(institution instance);
    partial void Deleteinstitution(institution instance);
    partial void Insertunic_username(unic_username instance);
    partial void Updateunic_username(unic_username instance);
    partial void Deleteunic_username(unic_username instance);
    partial void Insertposition(position instance);
    partial void Updateposition(position instance);
    partial void Deleteposition(position instance);
    #endregion
		
		public lora_sofdDataContext() : 
				base(global::Lib_ws17_service.Properties.Settings.Default.LORA_SOFDConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public lora_sofdDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lora_sofdDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lora_sofdDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public lora_sofdDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<institution> institutions
		{
			get
			{
				return this.GetTable<institution>();
			}
		}
		
		public System.Data.Linq.Table<unic_username> unic_usernames
		{
			get
			{
				return this.GetTable<unic_username>();
			}
		}
		
		public System.Data.Linq.Table<position> positions
		{
			get
			{
				return this.GetTable<position>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="unic.institutions")]
	public partial class institution : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _system_id;
		
		private string _institution_nr;
		
		private string _institution_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsystem_idChanging(int value);
    partial void Onsystem_idChanged();
    partial void Oninstitution_nrChanging(string value);
    partial void Oninstitution_nrChanged();
    partial void Oninstitution_nameChanging(string value);
    partial void Oninstitution_nameChanged();
    #endregion
		
		public institution()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_system_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int system_id
		{
			get
			{
				return this._system_id;
			}
			set
			{
				if ((this._system_id != value))
				{
					this.Onsystem_idChanging(value);
					this.SendPropertyChanging();
					this._system_id = value;
					this.SendPropertyChanged("system_id");
					this.Onsystem_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_institution_nr", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string institution_nr
		{
			get
			{
				return this._institution_nr;
			}
			set
			{
				if ((this._institution_nr != value))
				{
					this.Oninstitution_nrChanging(value);
					this.SendPropertyChanging();
					this._institution_nr = value;
					this.SendPropertyChanged("institution_nr");
					this.Oninstitution_nrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_institution_name", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string institution_name
		{
			get
			{
				return this._institution_name;
			}
			set
			{
				if ((this._institution_name != value))
				{
					this.Oninstitution_nameChanging(value);
					this.SendPropertyChanging();
					this._institution_name = value;
					this.SendPropertyChanged("institution_name");
					this.Oninstitution_nameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="unic.unic_usernames")]
	public partial class unic_username : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _system_id;
		
		private string _cpr;
		
		private string _unic_userid;
		
		private string _institution_nr;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsystem_idChanging(long value);
    partial void Onsystem_idChanged();
    partial void OncprChanging(string value);
    partial void OncprChanged();
    partial void Onunic_useridChanging(string value);
    partial void Onunic_useridChanged();
    partial void Oninstitution_nrChanging(string value);
    partial void Oninstitution_nrChanged();
    #endregion
		
		public unic_username()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_system_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long system_id
		{
			get
			{
				return this._system_id;
			}
			set
			{
				if ((this._system_id != value))
				{
					this.Onsystem_idChanging(value);
					this.SendPropertyChanging();
					this._system_id = value;
					this.SendPropertyChanged("system_id");
					this.Onsystem_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpr", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string cpr
		{
			get
			{
				return this._cpr;
			}
			set
			{
				if ((this._cpr != value))
				{
					this.OncprChanging(value);
					this.SendPropertyChanging();
					this._cpr = value;
					this.SendPropertyChanged("cpr");
					this.OncprChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unic_userid", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string unic_userid
		{
			get
			{
				return this._unic_userid;
			}
			set
			{
				if ((this._unic_userid != value))
				{
					this.Onunic_useridChanging(value);
					this.SendPropertyChanging();
					this._unic_userid = value;
					this.SendPropertyChanged("unic_userid");
					this.Onunic_useridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_institution_nr", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string institution_nr
		{
			get
			{
				return this._institution_nr;
			}
			set
			{
				if ((this._institution_nr != value))
				{
					this.Oninstitution_nrChanging(value);
					this.SendPropertyChanging();
					this._institution_nr = value;
					this.SendPropertyChanged("institution_nr");
					this.Oninstitution_nrChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="pyt.positions")]
	public partial class position : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _system_id;
		
		private int _opus_id;
		
		private string _uuid_userref;
		
		private int _los_id;
		
		private string _person_ref;
		
		private int _kmd_suppid;
		
		private string _title;
		
		private int _position_id;
		
		private string _title_short;
		
		private string _paygrade_title;
		
		private bool _is_manager;
		
		private string _payment_method;
		
		private string _payment_method_text;
		
		private decimal _weekly_hours_numerator;
		
		private decimal _weekly_hours_denominator;
		
		private bool _invoice_recipient;
		
		private string _pos_pnr;
		
		private string _dsuser;
		
		private System.DateTime _start_date;
		
		private System.Nullable<System.DateTime> _leave_date;
		
		private System.Nullable<int> _manager_opus_id;
		
		private string _manager_uuid_userref;
		
		private bool _updated;
		
		private bool _deleted;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsystem_idChanging(long value);
    partial void Onsystem_idChanged();
    partial void Onopus_idChanging(int value);
    partial void Onopus_idChanged();
    partial void Onuuid_userrefChanging(string value);
    partial void Onuuid_userrefChanged();
    partial void Onlos_idChanging(int value);
    partial void Onlos_idChanged();
    partial void Onperson_refChanging(string value);
    partial void Onperson_refChanged();
    partial void Onkmd_suppidChanging(int value);
    partial void Onkmd_suppidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void Onposition_idChanging(int value);
    partial void Onposition_idChanged();
    partial void Ontitle_shortChanging(string value);
    partial void Ontitle_shortChanged();
    partial void Onpaygrade_titleChanging(string value);
    partial void Onpaygrade_titleChanged();
    partial void Onis_managerChanging(bool value);
    partial void Onis_managerChanged();
    partial void Onpayment_methodChanging(string value);
    partial void Onpayment_methodChanged();
    partial void Onpayment_method_textChanging(string value);
    partial void Onpayment_method_textChanged();
    partial void Onweekly_hours_numeratorChanging(decimal value);
    partial void Onweekly_hours_numeratorChanged();
    partial void Onweekly_hours_denominatorChanging(decimal value);
    partial void Onweekly_hours_denominatorChanged();
    partial void Oninvoice_recipientChanging(bool value);
    partial void Oninvoice_recipientChanged();
    partial void Onpos_pnrChanging(string value);
    partial void Onpos_pnrChanged();
    partial void OndsuserChanging(string value);
    partial void OndsuserChanged();
    partial void Onstart_dateChanging(System.DateTime value);
    partial void Onstart_dateChanged();
    partial void Onleave_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onleave_dateChanged();
    partial void Onmanager_opus_idChanging(System.Nullable<int> value);
    partial void Onmanager_opus_idChanged();
    partial void Onmanager_uuid_userrefChanging(string value);
    partial void Onmanager_uuid_userrefChanged();
    partial void OnupdatedChanging(bool value);
    partial void OnupdatedChanged();
    partial void OndeletedChanging(bool value);
    partial void OndeletedChanged();
    #endregion
		
		public position()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_system_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long system_id
		{
			get
			{
				return this._system_id;
			}
			set
			{
				if ((this._system_id != value))
				{
					this.Onsystem_idChanging(value);
					this.SendPropertyChanging();
					this._system_id = value;
					this.SendPropertyChanged("system_id");
					this.Onsystem_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opus_id", DbType="Int NOT NULL")]
		public int opus_id
		{
			get
			{
				return this._opus_id;
			}
			set
			{
				if ((this._opus_id != value))
				{
					this.Onopus_idChanging(value);
					this.SendPropertyChanging();
					this._opus_id = value;
					this.SendPropertyChanged("opus_id");
					this.Onopus_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uuid_userref", DbType="NVarChar(200)")]
		public string uuid_userref
		{
			get
			{
				return this._uuid_userref;
			}
			set
			{
				if ((this._uuid_userref != value))
				{
					this.Onuuid_userrefChanging(value);
					this.SendPropertyChanging();
					this._uuid_userref = value;
					this.SendPropertyChanged("uuid_userref");
					this.Onuuid_userrefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_los_id", DbType="Int NOT NULL")]
		public int los_id
		{
			get
			{
				return this._los_id;
			}
			set
			{
				if ((this._los_id != value))
				{
					this.Onlos_idChanging(value);
					this.SendPropertyChanging();
					this._los_id = value;
					this.SendPropertyChanged("los_id");
					this.Onlos_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_person_ref", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string person_ref
		{
			get
			{
				return this._person_ref;
			}
			set
			{
				if ((this._person_ref != value))
				{
					this.Onperson_refChanging(value);
					this.SendPropertyChanging();
					this._person_ref = value;
					this.SendPropertyChanged("person_ref");
					this.Onperson_refChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kmd_suppid", DbType="Int NOT NULL")]
		public int kmd_suppid
		{
			get
			{
				return this._kmd_suppid;
			}
			set
			{
				if ((this._kmd_suppid != value))
				{
					this.Onkmd_suppidChanging(value);
					this.SendPropertyChanging();
					this._kmd_suppid = value;
					this.SendPropertyChanged("kmd_suppid");
					this.Onkmd_suppidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position_id", DbType="Int NOT NULL")]
		public int position_id
		{
			get
			{
				return this._position_id;
			}
			set
			{
				if ((this._position_id != value))
				{
					this.Onposition_idChanging(value);
					this.SendPropertyChanging();
					this._position_id = value;
					this.SendPropertyChanged("position_id");
					this.Onposition_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title_short", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string title_short
		{
			get
			{
				return this._title_short;
			}
			set
			{
				if ((this._title_short != value))
				{
					this.Ontitle_shortChanging(value);
					this.SendPropertyChanging();
					this._title_short = value;
					this.SendPropertyChanged("title_short");
					this.Ontitle_shortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paygrade_title", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string paygrade_title
		{
			get
			{
				return this._paygrade_title;
			}
			set
			{
				if ((this._paygrade_title != value))
				{
					this.Onpaygrade_titleChanging(value);
					this.SendPropertyChanging();
					this._paygrade_title = value;
					this.SendPropertyChanged("paygrade_title");
					this.Onpaygrade_titleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_manager", DbType="Bit NOT NULL")]
		public bool is_manager
		{
			get
			{
				return this._is_manager;
			}
			set
			{
				if ((this._is_manager != value))
				{
					this.Onis_managerChanging(value);
					this.SendPropertyChanging();
					this._is_manager = value;
					this.SendPropertyChanged("is_manager");
					this.Onis_managerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payment_method", DbType="NVarChar(4) NOT NULL", CanBeNull=false)]
		public string payment_method
		{
			get
			{
				return this._payment_method;
			}
			set
			{
				if ((this._payment_method != value))
				{
					this.Onpayment_methodChanging(value);
					this.SendPropertyChanging();
					this._payment_method = value;
					this.SendPropertyChanged("payment_method");
					this.Onpayment_methodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_payment_method_text", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string payment_method_text
		{
			get
			{
				return this._payment_method_text;
			}
			set
			{
				if ((this._payment_method_text != value))
				{
					this.Onpayment_method_textChanging(value);
					this.SendPropertyChanging();
					this._payment_method_text = value;
					this.SendPropertyChanged("payment_method_text");
					this.Onpayment_method_textChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weekly_hours_numerator", DbType="Decimal(20,3) NOT NULL")]
		public decimal weekly_hours_numerator
		{
			get
			{
				return this._weekly_hours_numerator;
			}
			set
			{
				if ((this._weekly_hours_numerator != value))
				{
					this.Onweekly_hours_numeratorChanging(value);
					this.SendPropertyChanging();
					this._weekly_hours_numerator = value;
					this.SendPropertyChanged("weekly_hours_numerator");
					this.Onweekly_hours_numeratorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weekly_hours_denominator", DbType="Decimal(20,3) NOT NULL")]
		public decimal weekly_hours_denominator
		{
			get
			{
				return this._weekly_hours_denominator;
			}
			set
			{
				if ((this._weekly_hours_denominator != value))
				{
					this.Onweekly_hours_denominatorChanging(value);
					this.SendPropertyChanging();
					this._weekly_hours_denominator = value;
					this.SendPropertyChanged("weekly_hours_denominator");
					this.Onweekly_hours_denominatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invoice_recipient", DbType="Bit NOT NULL")]
		public bool invoice_recipient
		{
			get
			{
				return this._invoice_recipient;
			}
			set
			{
				if ((this._invoice_recipient != value))
				{
					this.Oninvoice_recipientChanging(value);
					this.SendPropertyChanging();
					this._invoice_recipient = value;
					this.SendPropertyChanged("invoice_recipient");
					this.Oninvoice_recipientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pos_pnr", DbType="NVarChar(250)")]
		public string pos_pnr
		{
			get
			{
				return this._pos_pnr;
			}
			set
			{
				if ((this._pos_pnr != value))
				{
					this.Onpos_pnrChanging(value);
					this.SendPropertyChanging();
					this._pos_pnr = value;
					this.SendPropertyChanged("pos_pnr");
					this.Onpos_pnrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dsuser", DbType="NVarChar(50)")]
		public string dsuser
		{
			get
			{
				return this._dsuser;
			}
			set
			{
				if ((this._dsuser != value))
				{
					this.OndsuserChanging(value);
					this.SendPropertyChanging();
					this._dsuser = value;
					this.SendPropertyChanged("dsuser");
					this.OndsuserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="Date NOT NULL")]
		public System.DateTime start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_leave_date", DbType="Date")]
		public System.Nullable<System.DateTime> leave_date
		{
			get
			{
				return this._leave_date;
			}
			set
			{
				if ((this._leave_date != value))
				{
					this.Onleave_dateChanging(value);
					this.SendPropertyChanging();
					this._leave_date = value;
					this.SendPropertyChanged("leave_date");
					this.Onleave_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manager_opus_id", DbType="Int")]
		public System.Nullable<int> manager_opus_id
		{
			get
			{
				return this._manager_opus_id;
			}
			set
			{
				if ((this._manager_opus_id != value))
				{
					this.Onmanager_opus_idChanging(value);
					this.SendPropertyChanging();
					this._manager_opus_id = value;
					this.SendPropertyChanged("manager_opus_id");
					this.Onmanager_opus_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manager_uuid_userref", DbType="NVarChar(200)")]
		public string manager_uuid_userref
		{
			get
			{
				return this._manager_uuid_userref;
			}
			set
			{
				if ((this._manager_uuid_userref != value))
				{
					this.Onmanager_uuid_userrefChanging(value);
					this.SendPropertyChanging();
					this._manager_uuid_userref = value;
					this.SendPropertyChanged("manager_uuid_userref");
					this.Onmanager_uuid_userrefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated", DbType="Bit NOT NULL")]
		public bool updated
		{
			get
			{
				return this._updated;
			}
			set
			{
				if ((this._updated != value))
				{
					this.OnupdatedChanging(value);
					this.SendPropertyChanging();
					this._updated = value;
					this.SendPropertyChanged("updated");
					this.OnupdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deleted", DbType="Bit NOT NULL")]
		public bool deleted
		{
			get
			{
				return this._deleted;
			}
			set
			{
				if ((this._deleted != value))
				{
					this.OndeletedChanging(value);
					this.SendPropertyChanging();
					this._deleted = value;
					this.SendPropertyChanged("deleted");
					this.OndeletedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
