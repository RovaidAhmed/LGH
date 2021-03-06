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

namespace LGH
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LGH")]
	public partial class DataclassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBio_Data_Form(Bio_Data_Form instance);
    partial void UpdateBio_Data_Form(Bio_Data_Form instance);
    partial void DeleteBio_Data_Form(Bio_Data_Form instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataclassDataContext() : 
				base(global::LGH.Properties.Settings.Default.LGHConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataclassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataclassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataclassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataclassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bio_Data_Form> Bio_Data_Forms
		{
			get
			{
				return this.GetTable<Bio_Data_Form>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bio_Data_Form")]
	public partial class Bio_Data_Form : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BDF_ID;
		
		private string _Name;
		
		private string _SDW_O;
		
		private System.DateTime _DOB;
		
		private string _Date_of_Superannuation;
		
		private string _Sex;
		
		private string _Martial_Status;
		
		private string _Next_Of_Kin;
		
		private string _Permanent_Address;
		
		private string _Cnic_No;
		
		private string _Cell_No;
		
		private string _Emergency_ContactNo;
		
		private string _Landline_PTCL_No;
		
		private string _Passport_No;
		
		private string _Email;
		
		private string _Domicile;
		
		private string _PRC;
		
		private string _Personal_No;
		
		private string _Service_Book_No;
		
		private System.DateTime _Date_Of_Joinning;
		
		private string _Joinning_at_LGHK;
		
		private string _Posted_at_LGHK_On;
		
		private string _Status_Before_Joinning_LGHK;
		
		private string _Posted_at_LGHK_In;
		
		private string _Designation;
		
		private string _Cadre;
		
		private int _BPS;
		
		private string _Service_Type;
		
		private System.DateTime _Service_Type_Datetime;
		
		private string _PM_DC_;
		
		private string _Qualification;
		
		private string _Any_Other_Qualification;
		
		private string _Last_Institute;
		
		private System.DateTime _Date_Last_Promotion;
		
		private int _Promoted_BPS;
		
		private System.Nullable<System.DateTime> _DOL_Ex_Pak_Leave;
		
		private System.DateTime _Dated;
		
		private string _Remarks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBDF_IDChanging(int value);
    partial void OnBDF_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSDW_OChanging(string value);
    partial void OnSDW_OChanged();
    partial void OnDOBChanging(System.DateTime value);
    partial void OnDOBChanged();
    partial void OnDate_of_SuperannuationChanging(string value);
    partial void OnDate_of_SuperannuationChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnMartial_StatusChanging(string value);
    partial void OnMartial_StatusChanged();
    partial void OnNext_Of_KinChanging(string value);
    partial void OnNext_Of_KinChanged();
    partial void OnPermanent_AddressChanging(string value);
    partial void OnPermanent_AddressChanged();
    partial void OnCnic_NoChanging(string value);
    partial void OnCnic_NoChanged();
    partial void OnCell_NoChanging(string value);
    partial void OnCell_NoChanged();
    partial void OnEmergency_ContactNoChanging(string value);
    partial void OnEmergency_ContactNoChanged();
    partial void OnLandline_PTCL_NoChanging(string value);
    partial void OnLandline_PTCL_NoChanged();
    partial void OnPassport_NoChanging(string value);
    partial void OnPassport_NoChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDomicileChanging(string value);
    partial void OnDomicileChanged();
    partial void OnPRCChanging(string value);
    partial void OnPRCChanged();
    partial void OnPersonal_NoChanging(string value);
    partial void OnPersonal_NoChanged();
    partial void OnService_Book_NoChanging(string value);
    partial void OnService_Book_NoChanged();
    partial void OnDate_Of_JoinningChanging(System.DateTime value);
    partial void OnDate_Of_JoinningChanged();
    partial void OnJoinning_at_LGHKChanging(string value);
    partial void OnJoinning_at_LGHKChanged();
    partial void OnPosted_at_LGHK_OnChanging(string value);
    partial void OnPosted_at_LGHK_OnChanged();
    partial void OnStatus_Before_Joinning_LGHKChanging(string value);
    partial void OnStatus_Before_Joinning_LGHKChanged();
    partial void OnPosted_at_LGHK_InChanging(string value);
    partial void OnPosted_at_LGHK_InChanged();
    partial void OnDesignationChanging(string value);
    partial void OnDesignationChanged();
    partial void OnCadreChanging(string value);
    partial void OnCadreChanged();
    partial void OnBPSChanging(int value);
    partial void OnBPSChanged();
    partial void OnService_TypeChanging(string value);
    partial void OnService_TypeChanged();
    partial void OnService_Type_DatetimeChanging(System.DateTime value);
    partial void OnService_Type_DatetimeChanged();
    partial void OnPM_DC_Changing(string value);
    partial void OnPM_DC_Changed();
    partial void OnQualificationChanging(string value);
    partial void OnQualificationChanged();
    partial void OnAny_Other_QualificationChanging(string value);
    partial void OnAny_Other_QualificationChanged();
    partial void OnLast_InstituteChanging(string value);
    partial void OnLast_InstituteChanged();
    partial void OnDate_Last_PromotionChanging(System.DateTime value);
    partial void OnDate_Last_PromotionChanged();
    partial void OnPromoted_BPSChanging(int value);
    partial void OnPromoted_BPSChanged();
    partial void OnDOL_Ex_Pak_LeaveChanging(System.Nullable<System.DateTime> value);
    partial void OnDOL_Ex_Pak_LeaveChanged();
    partial void OnDatedChanging(System.DateTime value);
    partial void OnDatedChanged();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    #endregion
		
		public Bio_Data_Form()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BDF_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BDF_ID
		{
			get
			{
				return this._BDF_ID;
			}
			set
			{
				if ((this._BDF_ID != value))
				{
					this.OnBDF_IDChanging(value);
					this.SendPropertyChanging();
					this._BDF_ID = value;
					this.SendPropertyChanged("BDF_ID");
					this.OnBDF_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDW_O", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string SDW_O
		{
			get
			{
				return this._SDW_O;
			}
			set
			{
				if ((this._SDW_O != value))
				{
					this.OnSDW_OChanging(value);
					this.SendPropertyChanging();
					this._SDW_O = value;
					this.SendPropertyChanged("SDW_O");
					this.OnSDW_OChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date NOT NULL")]
		public System.DateTime DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_of_Superannuation", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Date_of_Superannuation
		{
			get
			{
				return this._Date_of_Superannuation;
			}
			set
			{
				if ((this._Date_of_Superannuation != value))
				{
					this.OnDate_of_SuperannuationChanging(value);
					this.SendPropertyChanging();
					this._Date_of_Superannuation = value;
					this.SendPropertyChanged("Date_of_Superannuation");
					this.OnDate_of_SuperannuationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Martial_Status", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Martial_Status
		{
			get
			{
				return this._Martial_Status;
			}
			set
			{
				if ((this._Martial_Status != value))
				{
					this.OnMartial_StatusChanging(value);
					this.SendPropertyChanging();
					this._Martial_Status = value;
					this.SendPropertyChanged("Martial_Status");
					this.OnMartial_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Next_Of_Kin", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string Next_Of_Kin
		{
			get
			{
				return this._Next_Of_Kin;
			}
			set
			{
				if ((this._Next_Of_Kin != value))
				{
					this.OnNext_Of_KinChanging(value);
					this.SendPropertyChanging();
					this._Next_Of_Kin = value;
					this.SendPropertyChanged("Next_Of_Kin");
					this.OnNext_Of_KinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Permanent_Address", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Permanent_Address
		{
			get
			{
				return this._Permanent_Address;
			}
			set
			{
				if ((this._Permanent_Address != value))
				{
					this.OnPermanent_AddressChanging(value);
					this.SendPropertyChanging();
					this._Permanent_Address = value;
					this.SendPropertyChanged("Permanent_Address");
					this.OnPermanent_AddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cnic_No", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Cnic_No
		{
			get
			{
				return this._Cnic_No;
			}
			set
			{
				if ((this._Cnic_No != value))
				{
					this.OnCnic_NoChanging(value);
					this.SendPropertyChanging();
					this._Cnic_No = value;
					this.SendPropertyChanged("Cnic_No");
					this.OnCnic_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cell_No", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Cell_No
		{
			get
			{
				return this._Cell_No;
			}
			set
			{
				if ((this._Cell_No != value))
				{
					this.OnCell_NoChanging(value);
					this.SendPropertyChanging();
					this._Cell_No = value;
					this.SendPropertyChanged("Cell_No");
					this.OnCell_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Emergency_ContactNo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Emergency_ContactNo
		{
			get
			{
				return this._Emergency_ContactNo;
			}
			set
			{
				if ((this._Emergency_ContactNo != value))
				{
					this.OnEmergency_ContactNoChanging(value);
					this.SendPropertyChanging();
					this._Emergency_ContactNo = value;
					this.SendPropertyChanged("Emergency_ContactNo");
					this.OnEmergency_ContactNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Landline_PTCL_No", DbType="NVarChar(50)")]
		public string Landline_PTCL_No
		{
			get
			{
				return this._Landline_PTCL_No;
			}
			set
			{
				if ((this._Landline_PTCL_No != value))
				{
					this.OnLandline_PTCL_NoChanging(value);
					this.SendPropertyChanging();
					this._Landline_PTCL_No = value;
					this.SendPropertyChanged("Landline_PTCL_No");
					this.OnLandline_PTCL_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passport_No", DbType="NVarChar(100)")]
		public string Passport_No
		{
			get
			{
				return this._Passport_No;
			}
			set
			{
				if ((this._Passport_No != value))
				{
					this.OnPassport_NoChanging(value);
					this.SendPropertyChanging();
					this._Passport_No = value;
					this.SendPropertyChanged("Passport_No");
					this.OnPassport_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Domicile", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Domicile
		{
			get
			{
				return this._Domicile;
			}
			set
			{
				if ((this._Domicile != value))
				{
					this.OnDomicileChanging(value);
					this.SendPropertyChanging();
					this._Domicile = value;
					this.SendPropertyChanged("Domicile");
					this.OnDomicileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRC", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PRC
		{
			get
			{
				return this._PRC;
			}
			set
			{
				if ((this._PRC != value))
				{
					this.OnPRCChanging(value);
					this.SendPropertyChanging();
					this._PRC = value;
					this.SendPropertyChanged("PRC");
					this.OnPRCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Personal_No", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Personal_No
		{
			get
			{
				return this._Personal_No;
			}
			set
			{
				if ((this._Personal_No != value))
				{
					this.OnPersonal_NoChanging(value);
					this.SendPropertyChanging();
					this._Personal_No = value;
					this.SendPropertyChanged("Personal_No");
					this.OnPersonal_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Service_Book_No", DbType="NVarChar(70)")]
		public string Service_Book_No
		{
			get
			{
				return this._Service_Book_No;
			}
			set
			{
				if ((this._Service_Book_No != value))
				{
					this.OnService_Book_NoChanging(value);
					this.SendPropertyChanging();
					this._Service_Book_No = value;
					this.SendPropertyChanged("Service_Book_No");
					this.OnService_Book_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Of_Joinning", DbType="DateTime NOT NULL")]
		public System.DateTime Date_Of_Joinning
		{
			get
			{
				return this._Date_Of_Joinning;
			}
			set
			{
				if ((this._Date_Of_Joinning != value))
				{
					this.OnDate_Of_JoinningChanging(value);
					this.SendPropertyChanging();
					this._Date_Of_Joinning = value;
					this.SendPropertyChanged("Date_Of_Joinning");
					this.OnDate_Of_JoinningChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Joinning_at_LGHK", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Joinning_at_LGHK
		{
			get
			{
				return this._Joinning_at_LGHK;
			}
			set
			{
				if ((this._Joinning_at_LGHK != value))
				{
					this.OnJoinning_at_LGHKChanging(value);
					this.SendPropertyChanging();
					this._Joinning_at_LGHK = value;
					this.SendPropertyChanged("Joinning_at_LGHK");
					this.OnJoinning_at_LGHKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Posted_at_LGHK_On", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Posted_at_LGHK_On
		{
			get
			{
				return this._Posted_at_LGHK_On;
			}
			set
			{
				if ((this._Posted_at_LGHK_On != value))
				{
					this.OnPosted_at_LGHK_OnChanging(value);
					this.SendPropertyChanging();
					this._Posted_at_LGHK_On = value;
					this.SendPropertyChanged("Posted_at_LGHK_On");
					this.OnPosted_at_LGHK_OnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status_Before_Joinning_LGHK", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Status_Before_Joinning_LGHK
		{
			get
			{
				return this._Status_Before_Joinning_LGHK;
			}
			set
			{
				if ((this._Status_Before_Joinning_LGHK != value))
				{
					this.OnStatus_Before_Joinning_LGHKChanging(value);
					this.SendPropertyChanging();
					this._Status_Before_Joinning_LGHK = value;
					this.SendPropertyChanged("Status_Before_Joinning_LGHK");
					this.OnStatus_Before_Joinning_LGHKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Posted_at_LGHK_In", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Posted_at_LGHK_In
		{
			get
			{
				return this._Posted_at_LGHK_In;
			}
			set
			{
				if ((this._Posted_at_LGHK_In != value))
				{
					this.OnPosted_at_LGHK_InChanging(value);
					this.SendPropertyChanging();
					this._Posted_at_LGHK_In = value;
					this.SendPropertyChanged("Posted_at_LGHK_In");
					this.OnPosted_at_LGHK_InChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
		public string Designation
		{
			get
			{
				return this._Designation;
			}
			set
			{
				if ((this._Designation != value))
				{
					this.OnDesignationChanging(value);
					this.SendPropertyChanging();
					this._Designation = value;
					this.SendPropertyChanged("Designation");
					this.OnDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cadre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Cadre
		{
			get
			{
				return this._Cadre;
			}
			set
			{
				if ((this._Cadre != value))
				{
					this.OnCadreChanging(value);
					this.SendPropertyChanging();
					this._Cadre = value;
					this.SendPropertyChanged("Cadre");
					this.OnCadreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BPS", DbType="Int NOT NULL")]
		public int BPS
		{
			get
			{
				return this._BPS;
			}
			set
			{
				if ((this._BPS != value))
				{
					this.OnBPSChanging(value);
					this.SendPropertyChanging();
					this._BPS = value;
					this.SendPropertyChanged("BPS");
					this.OnBPSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Service_Type", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Service_Type
		{
			get
			{
				return this._Service_Type;
			}
			set
			{
				if ((this._Service_Type != value))
				{
					this.OnService_TypeChanging(value);
					this.SendPropertyChanging();
					this._Service_Type = value;
					this.SendPropertyChanged("Service_Type");
					this.OnService_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Service_Type_Datetime", DbType="DateTime NOT NULL")]
		public System.DateTime Service_Type_Datetime
		{
			get
			{
				return this._Service_Type_Datetime;
			}
			set
			{
				if ((this._Service_Type_Datetime != value))
				{
					this.OnService_Type_DatetimeChanging(value);
					this.SendPropertyChanging();
					this._Service_Type_Datetime = value;
					this.SendPropertyChanged("Service_Type_Datetime");
					this.OnService_Type_DatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="PM_DC#", Storage="_PM_DC_", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PM_DC_
		{
			get
			{
				return this._PM_DC_;
			}
			set
			{
				if ((this._PM_DC_ != value))
				{
					this.OnPM_DC_Changing(value);
					this.SendPropertyChanging();
					this._PM_DC_ = value;
					this.SendPropertyChanged("PM_DC_");
					this.OnPM_DC_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qualification", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Qualification
		{
			get
			{
				return this._Qualification;
			}
			set
			{
				if ((this._Qualification != value))
				{
					this.OnQualificationChanging(value);
					this.SendPropertyChanging();
					this._Qualification = value;
					this.SendPropertyChanged("Qualification");
					this.OnQualificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Any_Other_Qualification", DbType="NVarChar(50)")]
		public string Any_Other_Qualification
		{
			get
			{
				return this._Any_Other_Qualification;
			}
			set
			{
				if ((this._Any_Other_Qualification != value))
				{
					this.OnAny_Other_QualificationChanging(value);
					this.SendPropertyChanging();
					this._Any_Other_Qualification = value;
					this.SendPropertyChanged("Any_Other_Qualification");
					this.OnAny_Other_QualificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Institute", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Last_Institute
		{
			get
			{
				return this._Last_Institute;
			}
			set
			{
				if ((this._Last_Institute != value))
				{
					this.OnLast_InstituteChanging(value);
					this.SendPropertyChanging();
					this._Last_Institute = value;
					this.SendPropertyChanged("Last_Institute");
					this.OnLast_InstituteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Last_Promotion", DbType="DateTime NOT NULL")]
		public System.DateTime Date_Last_Promotion
		{
			get
			{
				return this._Date_Last_Promotion;
			}
			set
			{
				if ((this._Date_Last_Promotion != value))
				{
					this.OnDate_Last_PromotionChanging(value);
					this.SendPropertyChanging();
					this._Date_Last_Promotion = value;
					this.SendPropertyChanged("Date_Last_Promotion");
					this.OnDate_Last_PromotionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Promoted_BPS", DbType="Int NOT NULL")]
		public int Promoted_BPS
		{
			get
			{
				return this._Promoted_BPS;
			}
			set
			{
				if ((this._Promoted_BPS != value))
				{
					this.OnPromoted_BPSChanging(value);
					this.SendPropertyChanging();
					this._Promoted_BPS = value;
					this.SendPropertyChanged("Promoted_BPS");
					this.OnPromoted_BPSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOL_Ex_Pak_Leave", DbType="Date")]
		public System.Nullable<System.DateTime> DOL_Ex_Pak_Leave
		{
			get
			{
				return this._DOL_Ex_Pak_Leave;
			}
			set
			{
				if ((this._DOL_Ex_Pak_Leave != value))
				{
					this.OnDOL_Ex_Pak_LeaveChanging(value);
					this.SendPropertyChanging();
					this._DOL_Ex_Pak_Leave = value;
					this.SendPropertyChanged("DOL_Ex_Pak_Leave");
					this.OnDOL_Ex_Pak_LeaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dated", DbType="DateTime NOT NULL")]
		public System.DateTime Dated
		{
			get
			{
				return this._Dated;
			}
			set
			{
				if ((this._Dated != value))
				{
					this.OnDatedChanging(value);
					this.SendPropertyChanging();
					this._Dated = value;
					this.SendPropertyChanged("Dated");
					this.OnDatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="NVarChar(MAX)")]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Name;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
