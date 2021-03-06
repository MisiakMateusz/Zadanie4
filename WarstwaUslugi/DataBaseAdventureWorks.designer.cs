﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarstwaUslugi
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks2014")]
	public partial class DataBaseAdventureWorksDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public DataBaseAdventureWorksDataContext() : 
				base(global::WarstwaUslugi.Properties.Settings.Default.AdventureWorks2014ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseAdventureWorksDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseAdventureWorksDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseAdventureWorksDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseAdventureWorksDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Person> Person
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customer
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Person.Person")]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BusinessEntityID;
		
		private string _PersonType;
		
		private bool _NameStyle;
		
		private string _Title;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _Suffix;
		
		private int _EmailPromotion;
		
		private System.Xml.Linq.XElement _AdditionalContactInfo;
		
		private System.Xml.Linq.XElement _Demographics;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
		private EntitySet<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBusinessEntityIDChanging(int value);
    partial void OnBusinessEntityIDChanged();
    partial void OnPersonTypeChanging(string value);
    partial void OnPersonTypeChanged();
    partial void OnNameStyleChanging(bool value);
    partial void OnNameStyleChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnSuffixChanging(string value);
    partial void OnSuffixChanged();
    partial void OnEmailPromotionChanging(int value);
    partial void OnEmailPromotionChanged();
    partial void OnAdditionalContactInfoChanging(System.Xml.Linq.XElement value);
    partial void OnAdditionalContactInfoChanged();
    partial void OnDemographicsChanging(System.Xml.Linq.XElement value);
    partial void OnDemographicsChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Person()
		{
			this._Customer = new EntitySet<Customer>(new Action<Customer>(this.attach_Customer), new Action<Customer>(this.detach_Customer));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessEntityID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BusinessEntityID
		{
			get
			{
				return this._BusinessEntityID;
			}
			set
			{
				if ((this._BusinessEntityID != value))
				{
					this.OnBusinessEntityIDChanging(value);
					this.SendPropertyChanging();
					this._BusinessEntityID = value;
					this.SendPropertyChanged("BusinessEntityID");
					this.OnBusinessEntityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonType", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string PersonType
		{
			get
			{
				return this._PersonType;
			}
			set
			{
				if ((this._PersonType != value))
				{
					this.OnPersonTypeChanging(value);
					this.SendPropertyChanging();
					this._PersonType = value;
					this.SendPropertyChanged("PersonType");
					this.OnPersonTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameStyle", DbType="Bit NOT NULL")]
		public bool NameStyle
		{
			get
			{
				return this._NameStyle;
			}
			set
			{
				if ((this._NameStyle != value))
				{
					this.OnNameStyleChanging(value);
					this.SendPropertyChanging();
					this._NameStyle = value;
					this.SendPropertyChanged("NameStyle");
					this.OnNameStyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(8)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="NVarChar(50)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Suffix", DbType="NVarChar(10)")]
		public string Suffix
		{
			get
			{
				return this._Suffix;
			}
			set
			{
				if ((this._Suffix != value))
				{
					this.OnSuffixChanging(value);
					this.SendPropertyChanging();
					this._Suffix = value;
					this.SendPropertyChanged("Suffix");
					this.OnSuffixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailPromotion", DbType="Int NOT NULL")]
		public int EmailPromotion
		{
			get
			{
				return this._EmailPromotion;
			}
			set
			{
				if ((this._EmailPromotion != value))
				{
					this.OnEmailPromotionChanging(value);
					this.SendPropertyChanging();
					this._EmailPromotion = value;
					this.SendPropertyChanged("EmailPromotion");
					this.OnEmailPromotionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdditionalContactInfo", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement AdditionalContactInfo
		{
			get
			{
				return this._AdditionalContactInfo;
			}
			set
			{
				if ((this._AdditionalContactInfo != value))
				{
					this.OnAdditionalContactInfoChanging(value);
					this.SendPropertyChanging();
					this._AdditionalContactInfo = value;
					this.SendPropertyChanged("AdditionalContactInfo");
					this.OnAdditionalContactInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Demographics", DbType="Xml", UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement Demographics
		{
			get
			{
				return this._Demographics;
			}
			set
			{
				if ((this._Demographics != value))
				{
					this.OnDemographicsChanging(value);
					this.SendPropertyChanging();
					this._Demographics = value;
					this.SendPropertyChanged("Demographics");
					this.OnDemographicsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_Customer", Storage="_Customer", ThisKey="BusinessEntityID", OtherKey="PersonID")]
		public EntitySet<Customer> Customer
		{
			get
			{
				return this._Customer;
			}
			set
			{
				this._Customer.Assign(value);
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
		
		private void attach_Customer(Customer entity)
		{
			this.SendPropertyChanging();
			entity.Person = this;
		}
		
		private void detach_Customer(Customer entity)
		{
			this.SendPropertyChanging();
			entity.Person = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Sales.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private System.Nullable<int> _PersonID;
		
		private System.Nullable<int> _StoreID;
		
		private System.Nullable<int> _TerritoryID;
		
		private string _AccountNumber;
		
		private System.Guid _rowguid;
		
		private System.DateTime _ModifiedDate;
		
		private EntityRef<Person> _Person;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnPersonIDChanging(System.Nullable<int> value);
    partial void OnPersonIDChanged();
    partial void OnStoreIDChanging(System.Nullable<int> value);
    partial void OnStoreIDChanged();
    partial void OnTerritoryIDChanging(System.Nullable<int> value);
    partial void OnTerritoryIDChanged();
    partial void OnAccountNumberChanging(string value);
    partial void OnAccountNumberChanged();
    partial void OnrowguidChanging(System.Guid value);
    partial void OnrowguidChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
		
		public Customer()
		{
			this._Person = default(EntityRef<Person>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonID", DbType="Int")]
		public System.Nullable<int> PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					if (this._Person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPersonIDChanging(value);
					this.SendPropertyChanging();
					this._PersonID = value;
					this.SendPropertyChanged("PersonID");
					this.OnPersonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StoreID", DbType="Int")]
		public System.Nullable<int> StoreID
		{
			get
			{
				return this._StoreID;
			}
			set
			{
				if ((this._StoreID != value))
				{
					this.OnStoreIDChanging(value);
					this.SendPropertyChanging();
					this._StoreID = value;
					this.SendPropertyChanged("StoreID");
					this.OnStoreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TerritoryID", DbType="Int")]
		public System.Nullable<int> TerritoryID
		{
			get
			{
				return this._TerritoryID;
			}
			set
			{
				if ((this._TerritoryID != value))
				{
					this.OnTerritoryIDChanging(value);
					this.SendPropertyChanging();
					this._TerritoryID = value;
					this.SendPropertyChanged("TerritoryID");
					this.OnTerritoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountNumber", AutoSync=AutoSync.Always, DbType="VarChar(10) NOT NULL", CanBeNull=false, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public string AccountNumber
		{
			get
			{
				return this._AccountNumber;
			}
			set
			{
				if ((this._AccountNumber != value))
				{
					this.OnAccountNumberChanging(value);
					this.SendPropertyChanging();
					this._AccountNumber = value;
					this.SendPropertyChanged("AccountNumber");
					this.OnAccountNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rowguid", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid rowguid
		{
			get
			{
				return this._rowguid;
			}
			set
			{
				if ((this._rowguid != value))
				{
					this.OnrowguidChanging(value);
					this.SendPropertyChanging();
					this._rowguid = value;
					this.SendPropertyChanged("rowguid");
					this.OnrowguidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_Customer", Storage="_Person", ThisKey="PersonID", OtherKey="BusinessEntityID", IsForeignKey=true)]
		public Person Person
		{
			get
			{
				return this._Person.Entity;
			}
			set
			{
				Person previousValue = this._Person.Entity;
				if (((previousValue != value) 
							|| (this._Person.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Person.Entity = null;
						previousValue.Customer.Remove(this);
					}
					this._Person.Entity = value;
					if ((value != null))
					{
						value.Customer.Add(this);
						this._PersonID = value.BusinessEntityID;
					}
					else
					{
						this._PersonID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Person");
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
