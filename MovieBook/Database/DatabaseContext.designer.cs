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

namespace MovieBook.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Rekrutacja2")]
	public partial class DatabaseContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DatabaseContextDataContext() : 
				base(global::MovieBook.Properties.Settings.Default.Rekrutacja2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Film> Film
		{
			get
			{
				return this.GetTable<Film>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Film")]
	public partial class Film
	{
		
		private string _imagePath;
		
		private string _title;
		
		private string _productionYear;
		
		private string _director;
		
		private string _descrption;
		
		public Film()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagePath", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string imagePath
		{
			get
			{
				return this._imagePath;
			}
			set
			{
				if ((this._imagePath != value))
				{
					this._imagePath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this._title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productionYear", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string productionYear
		{
			get
			{
				return this._productionYear;
			}
			set
			{
				if ((this._productionYear != value))
				{
					this._productionYear = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_director", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string director
		{
			get
			{
				return this._director;
			}
			set
			{
				if ((this._director != value))
				{
					this._director = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descrption", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string descrption
		{
			get
			{
				return this._descrption;
			}
			set
			{
				if ((this._descrption != value))
				{
					this._descrption = value;
				}
			}
		}
	}
}
#pragma warning restore 1591