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

namespace AWT_Practial_Three
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="customer_info ")]
	public partial class emp_infoLINQDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemp_info1(emp_info1 instance);
    partial void Updateemp_info1(emp_info1 instance);
    partial void Deleteemp_info1(emp_info1 instance);
    #endregion
		
		public emp_infoLINQDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emp_infoLINQDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emp_infoLINQDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public emp_infoLINQDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<emp_info1> emp_info1s
		{
			get
			{
				return this.GetTable<emp_info1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.emp_info")]
	public partial class emp_info1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _eid;
		
		private string _ename;
		
		private string _designation;
		
		private string _salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OneidChanging(int value);
    partial void OneidChanged();
    partial void OnenameChanging(string value);
    partial void OnenameChanged();
    partial void OndesignationChanging(string value);
    partial void OndesignationChanged();
    partial void OnsalaryChanging(string value);
    partial void OnsalaryChanged();
    #endregion
		
		public emp_info1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int eid
		{
			get
			{
				return this._eid;
			}
			set
			{
				if ((this._eid != value))
				{
					this.OneidChanging(value);
					this.SendPropertyChanging();
					this._eid = value;
					this.SendPropertyChanged("eid");
					this.OneidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ename", DbType="NVarChar(50)")]
		public string ename
		{
			get
			{
				return this._ename;
			}
			set
			{
				if ((this._ename != value))
				{
					this.OnenameChanging(value);
					this.SendPropertyChanging();
					this._ename = value;
					this.SendPropertyChanged("ename");
					this.OnenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_designation", DbType="NVarChar(50)")]
		public string designation
		{
			get
			{
				return this._designation;
			}
			set
			{
				if ((this._designation != value))
				{
					this.OndesignationChanging(value);
					this.SendPropertyChanging();
					this._designation = value;
					this.SendPropertyChanged("designation");
					this.OndesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="NVarChar(50)")]
		public string salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
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