﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HELADERIA_CA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Heladeria_CA")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTbl_factura(Tbl_factura instance);
    partial void UpdateTbl_factura(Tbl_factura instance);
    partial void DeleteTbl_factura(Tbl_factura instance);
    partial void InsertTbl_producto(Tbl_producto instance);
    partial void UpdateTbl_producto(Tbl_producto instance);
    partial void DeleteTbl_producto(Tbl_producto instance);
    partial void InsertTbl_rol(Tbl_rol instance);
    partial void UpdateTbl_rol(Tbl_rol instance);
    partial void DeleteTbl_rol(Tbl_rol instance);
    partial void InsertTbl_usuario(Tbl_usuario instance);
    partial void UpdateTbl_usuario(Tbl_usuario instance);
    partial void DeleteTbl_usuario(Tbl_usuario instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HELADERIA_CA.Properties.Settings.Default.Heladeria_CAConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_factura> Tbl_factura
		{
			get
			{
				return this.GetTable<Tbl_factura>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_producto> Tbl_producto
		{
			get
			{
				return this.GetTable<Tbl_producto>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_rol> Tbl_rol
		{
			get
			{
				return this.GetTable<Tbl_rol>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_usuario> Tbl_usuario
		{
			get
			{
				return this.GetTable<Tbl_usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_factura")]
	public partial class Tbl_factura : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _fac_id;
		
		private string _fac_cedula;
		
		private string _fac_nombres;
		
		private string _fac_correo;
		
		private string _fac_numero;
		
		private string _fac_direccion;
		
		private string _fac_prod1;
		
		private string _fac_saborp1;
		
		private string _fac_prod2;
		
		private string _fac_saborp2;
		
		private string _fac_prod3;
		
		private string _fac_saborp3;
		
		private string _fac_prod4;
		
		private string _fac_prod5;
		
		private string _fac_prod6;
		
		private string _fac_prod7;
		
		private string _fac_prod8;
		
		private string _fac_prod9;
		
		private double _fac_subtotal;
		
		private double _fac_iva;
		
		private double _fac_total;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfac_idChanging(int value);
    partial void Onfac_idChanged();
    partial void Onfac_cedulaChanging(string value);
    partial void Onfac_cedulaChanged();
    partial void Onfac_nombresChanging(string value);
    partial void Onfac_nombresChanged();
    partial void Onfac_correoChanging(string value);
    partial void Onfac_correoChanged();
    partial void Onfac_numeroChanging(string value);
    partial void Onfac_numeroChanged();
    partial void Onfac_direccionChanging(string value);
    partial void Onfac_direccionChanged();
    partial void Onfac_prod1Changing(string value);
    partial void Onfac_prod1Changed();
    partial void Onfac_saborp1Changing(string value);
    partial void Onfac_saborp1Changed();
    partial void Onfac_prod2Changing(string value);
    partial void Onfac_prod2Changed();
    partial void Onfac_saborp2Changing(string value);
    partial void Onfac_saborp2Changed();
    partial void Onfac_prod3Changing(string value);
    partial void Onfac_prod3Changed();
    partial void Onfac_saborp3Changing(string value);
    partial void Onfac_saborp3Changed();
    partial void Onfac_prod4Changing(string value);
    partial void Onfac_prod4Changed();
    partial void Onfac_prod5Changing(string value);
    partial void Onfac_prod5Changed();
    partial void Onfac_prod6Changing(string value);
    partial void Onfac_prod6Changed();
    partial void Onfac_prod7Changing(string value);
    partial void Onfac_prod7Changed();
    partial void Onfac_prod8Changing(string value);
    partial void Onfac_prod8Changed();
    partial void Onfac_prod9Changing(string value);
    partial void Onfac_prod9Changed();
    partial void Onfac_subtotalChanging(double value);
    partial void Onfac_subtotalChanged();
    partial void Onfac_ivaChanging(double value);
    partial void Onfac_ivaChanged();
    partial void Onfac_totalChanging(double value);
    partial void Onfac_totalChanged();
    #endregion
		
		public Tbl_factura()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int fac_id
		{
			get
			{
				return this._fac_id;
			}
			set
			{
				if ((this._fac_id != value))
				{
					this.Onfac_idChanging(value);
					this.SendPropertyChanging();
					this._fac_id = value;
					this.SendPropertyChanged("fac_id");
					this.Onfac_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_cedula", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string fac_cedula
		{
			get
			{
				return this._fac_cedula;
			}
			set
			{
				if ((this._fac_cedula != value))
				{
					this.Onfac_cedulaChanging(value);
					this.SendPropertyChanging();
					this._fac_cedula = value;
					this.SendPropertyChanged("fac_cedula");
					this.Onfac_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_nombres", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string fac_nombres
		{
			get
			{
				return this._fac_nombres;
			}
			set
			{
				if ((this._fac_nombres != value))
				{
					this.Onfac_nombresChanging(value);
					this.SendPropertyChanging();
					this._fac_nombres = value;
					this.SendPropertyChanged("fac_nombres");
					this.Onfac_nombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_correo", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string fac_correo
		{
			get
			{
				return this._fac_correo;
			}
			set
			{
				if ((this._fac_correo != value))
				{
					this.Onfac_correoChanging(value);
					this.SendPropertyChanging();
					this._fac_correo = value;
					this.SendPropertyChanged("fac_correo");
					this.Onfac_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_numero", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string fac_numero
		{
			get
			{
				return this._fac_numero;
			}
			set
			{
				if ((this._fac_numero != value))
				{
					this.Onfac_numeroChanging(value);
					this.SendPropertyChanging();
					this._fac_numero = value;
					this.SendPropertyChanged("fac_numero");
					this.Onfac_numeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_direccion", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string fac_direccion
		{
			get
			{
				return this._fac_direccion;
			}
			set
			{
				if ((this._fac_direccion != value))
				{
					this.Onfac_direccionChanging(value);
					this.SendPropertyChanging();
					this._fac_direccion = value;
					this.SendPropertyChanged("fac_direccion");
					this.Onfac_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod1
		{
			get
			{
				return this._fac_prod1;
			}
			set
			{
				if ((this._fac_prod1 != value))
				{
					this.Onfac_prod1Changing(value);
					this.SendPropertyChanging();
					this._fac_prod1 = value;
					this.SendPropertyChanged("fac_prod1");
					this.Onfac_prod1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_saborp1", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string fac_saborp1
		{
			get
			{
				return this._fac_saborp1;
			}
			set
			{
				if ((this._fac_saborp1 != value))
				{
					this.Onfac_saborp1Changing(value);
					this.SendPropertyChanging();
					this._fac_saborp1 = value;
					this.SendPropertyChanged("fac_saborp1");
					this.Onfac_saborp1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod2", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod2
		{
			get
			{
				return this._fac_prod2;
			}
			set
			{
				if ((this._fac_prod2 != value))
				{
					this.Onfac_prod2Changing(value);
					this.SendPropertyChanging();
					this._fac_prod2 = value;
					this.SendPropertyChanged("fac_prod2");
					this.Onfac_prod2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_saborp2", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string fac_saborp2
		{
			get
			{
				return this._fac_saborp2;
			}
			set
			{
				if ((this._fac_saborp2 != value))
				{
					this.Onfac_saborp2Changing(value);
					this.SendPropertyChanging();
					this._fac_saborp2 = value;
					this.SendPropertyChanged("fac_saborp2");
					this.Onfac_saborp2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod3", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod3
		{
			get
			{
				return this._fac_prod3;
			}
			set
			{
				if ((this._fac_prod3 != value))
				{
					this.Onfac_prod3Changing(value);
					this.SendPropertyChanging();
					this._fac_prod3 = value;
					this.SendPropertyChanged("fac_prod3");
					this.Onfac_prod3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_saborp3", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string fac_saborp3
		{
			get
			{
				return this._fac_saborp3;
			}
			set
			{
				if ((this._fac_saborp3 != value))
				{
					this.Onfac_saborp3Changing(value);
					this.SendPropertyChanging();
					this._fac_saborp3 = value;
					this.SendPropertyChanged("fac_saborp3");
					this.Onfac_saborp3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod4", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod4
		{
			get
			{
				return this._fac_prod4;
			}
			set
			{
				if ((this._fac_prod4 != value))
				{
					this.Onfac_prod4Changing(value);
					this.SendPropertyChanging();
					this._fac_prod4 = value;
					this.SendPropertyChanged("fac_prod4");
					this.Onfac_prod4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod5", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod5
		{
			get
			{
				return this._fac_prod5;
			}
			set
			{
				if ((this._fac_prod5 != value))
				{
					this.Onfac_prod5Changing(value);
					this.SendPropertyChanging();
					this._fac_prod5 = value;
					this.SendPropertyChanged("fac_prod5");
					this.Onfac_prod5Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod6", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod6
		{
			get
			{
				return this._fac_prod6;
			}
			set
			{
				if ((this._fac_prod6 != value))
				{
					this.Onfac_prod6Changing(value);
					this.SendPropertyChanging();
					this._fac_prod6 = value;
					this.SendPropertyChanged("fac_prod6");
					this.Onfac_prod6Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod7", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod7
		{
			get
			{
				return this._fac_prod7;
			}
			set
			{
				if ((this._fac_prod7 != value))
				{
					this.Onfac_prod7Changing(value);
					this.SendPropertyChanging();
					this._fac_prod7 = value;
					this.SendPropertyChanged("fac_prod7");
					this.Onfac_prod7Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod8", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod8
		{
			get
			{
				return this._fac_prod8;
			}
			set
			{
				if ((this._fac_prod8 != value))
				{
					this.Onfac_prod8Changing(value);
					this.SendPropertyChanging();
					this._fac_prod8 = value;
					this.SendPropertyChanged("fac_prod8");
					this.Onfac_prod8Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_prod9", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fac_prod9
		{
			get
			{
				return this._fac_prod9;
			}
			set
			{
				if ((this._fac_prod9 != value))
				{
					this.Onfac_prod9Changing(value);
					this.SendPropertyChanging();
					this._fac_prod9 = value;
					this.SendPropertyChanged("fac_prod9");
					this.Onfac_prod9Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_subtotal", DbType="Float NOT NULL")]
		public double fac_subtotal
		{
			get
			{
				return this._fac_subtotal;
			}
			set
			{
				if ((this._fac_subtotal != value))
				{
					this.Onfac_subtotalChanging(value);
					this.SendPropertyChanging();
					this._fac_subtotal = value;
					this.SendPropertyChanged("fac_subtotal");
					this.Onfac_subtotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_iva", DbType="Float NOT NULL")]
		public double fac_iva
		{
			get
			{
				return this._fac_iva;
			}
			set
			{
				if ((this._fac_iva != value))
				{
					this.Onfac_ivaChanging(value);
					this.SendPropertyChanging();
					this._fac_iva = value;
					this.SendPropertyChanged("fac_iva");
					this.Onfac_ivaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fac_total", DbType="Float NOT NULL")]
		public double fac_total
		{
			get
			{
				return this._fac_total;
			}
			set
			{
				if ((this._fac_total != value))
				{
					this.Onfac_totalChanging(value);
					this.SendPropertyChanging();
					this._fac_total = value;
					this.SendPropertyChanged("fac_total");
					this.Onfac_totalChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_producto")]
	public partial class Tbl_producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _prod_id;
		
		private string _prod_codigo;
		
		private string _prod_nombre;
		
		private double _prod_precio;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onprod_idChanging(int value);
    partial void Onprod_idChanged();
    partial void Onprod_codigoChanging(string value);
    partial void Onprod_codigoChanged();
    partial void Onprod_nombreChanging(string value);
    partial void Onprod_nombreChanged();
    partial void Onprod_precioChanging(double value);
    partial void Onprod_precioChanged();
    #endregion
		
		public Tbl_producto()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prod_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int prod_id
		{
			get
			{
				return this._prod_id;
			}
			set
			{
				if ((this._prod_id != value))
				{
					this.Onprod_idChanging(value);
					this.SendPropertyChanging();
					this._prod_id = value;
					this.SendPropertyChanged("prod_id");
					this.Onprod_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prod_codigo", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string prod_codigo
		{
			get
			{
				return this._prod_codigo;
			}
			set
			{
				if ((this._prod_codigo != value))
				{
					this.Onprod_codigoChanging(value);
					this.SendPropertyChanging();
					this._prod_codigo = value;
					this.SendPropertyChanged("prod_codigo");
					this.Onprod_codigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prod_nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string prod_nombre
		{
			get
			{
				return this._prod_nombre;
			}
			set
			{
				if ((this._prod_nombre != value))
				{
					this.Onprod_nombreChanging(value);
					this.SendPropertyChanging();
					this._prod_nombre = value;
					this.SendPropertyChanged("prod_nombre");
					this.Onprod_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prod_precio", DbType="Float NOT NULL")]
		public double prod_precio
		{
			get
			{
				return this._prod_precio;
			}
			set
			{
				if ((this._prod_precio != value))
				{
					this.Onprod_precioChanging(value);
					this.SendPropertyChanging();
					this._prod_precio = value;
					this.SendPropertyChanged("prod_precio");
					this.Onprod_precioChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_rol")]
	public partial class Tbl_rol : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _rol_id;
		
		private string _rol_tipo;
		
		private EntitySet<Tbl_usuario> _Tbl_usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onrol_idChanging(int value);
    partial void Onrol_idChanged();
    partial void Onrol_tipoChanging(string value);
    partial void Onrol_tipoChanged();
    #endregion
		
		public Tbl_rol()
		{
			this._Tbl_usuario = new EntitySet<Tbl_usuario>(new Action<Tbl_usuario>(this.attach_Tbl_usuario), new Action<Tbl_usuario>(this.detach_Tbl_usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int rol_id
		{
			get
			{
				return this._rol_id;
			}
			set
			{
				if ((this._rol_id != value))
				{
					this.Onrol_idChanging(value);
					this.SendPropertyChanging();
					this._rol_id = value;
					this.SendPropertyChanged("rol_id");
					this.Onrol_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rol_tipo", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string rol_tipo
		{
			get
			{
				return this._rol_tipo;
			}
			set
			{
				if ((this._rol_tipo != value))
				{
					this.Onrol_tipoChanging(value);
					this.SendPropertyChanging();
					this._rol_tipo = value;
					this.SendPropertyChanged("rol_tipo");
					this.Onrol_tipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_rol_Tbl_usuario", Storage="_Tbl_usuario", ThisKey="rol_id", OtherKey="roles_id")]
		public EntitySet<Tbl_usuario> Tbl_usuario
		{
			get
			{
				return this._Tbl_usuario;
			}
			set
			{
				this._Tbl_usuario.Assign(value);
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
		
		private void attach_Tbl_usuario(Tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_rol = this;
		}
		
		private void detach_Tbl_usuario(Tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_rol = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_usuario")]
	public partial class Tbl_usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usu_id;
		
		private string _usu_usu;
		
		private string _usu_nombre;
		
		private string _usu_apellido;
		
		private string _usu_pass;
		
		private string _usu_cedula;
		
		private string _usu_correo;
		
		private string _usu_dire;
		
		private string _usu_celular;
		
		private string _usu_estado;
		
		private int _roles_id;
		
		private EntityRef<Tbl_rol> _Tbl_rol;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusu_idChanging(int value);
    partial void Onusu_idChanged();
    partial void Onusu_usuChanging(string value);
    partial void Onusu_usuChanged();
    partial void Onusu_nombreChanging(string value);
    partial void Onusu_nombreChanged();
    partial void Onusu_apellidoChanging(string value);
    partial void Onusu_apellidoChanged();
    partial void Onusu_passChanging(string value);
    partial void Onusu_passChanged();
    partial void Onusu_cedulaChanging(string value);
    partial void Onusu_cedulaChanged();
    partial void Onusu_correoChanging(string value);
    partial void Onusu_correoChanged();
    partial void Onusu_direChanging(string value);
    partial void Onusu_direChanged();
    partial void Onusu_celularChanging(string value);
    partial void Onusu_celularChanged();
    partial void Onusu_estadoChanging(string value);
    partial void Onusu_estadoChanged();
    partial void Onroles_idChanging(int value);
    partial void Onroles_idChanged();
    #endregion
		
		public Tbl_usuario()
		{
			this._Tbl_rol = default(EntityRef<Tbl_rol>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_usu", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string usu_usu
		{
			get
			{
				return this._usu_usu;
			}
			set
			{
				if ((this._usu_usu != value))
				{
					this.Onusu_usuChanging(value);
					this.SendPropertyChanging();
					this._usu_usu = value;
					this.SendPropertyChanged("usu_usu");
					this.Onusu_usuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this.Onusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._usu_nombre = value;
					this.SendPropertyChanged("usu_nombre");
					this.Onusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_apellido", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string usu_apellido
		{
			get
			{
				return this._usu_apellido;
			}
			set
			{
				if ((this._usu_apellido != value))
				{
					this.Onusu_apellidoChanging(value);
					this.SendPropertyChanging();
					this._usu_apellido = value;
					this.SendPropertyChanged("usu_apellido");
					this.Onusu_apellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_pass", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string usu_pass
		{
			get
			{
				return this._usu_pass;
			}
			set
			{
				if ((this._usu_pass != value))
				{
					this.Onusu_passChanging(value);
					this.SendPropertyChanging();
					this._usu_pass = value;
					this.SendPropertyChanged("usu_pass");
					this.Onusu_passChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_cedula", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string usu_cedula
		{
			get
			{
				return this._usu_cedula;
			}
			set
			{
				if ((this._usu_cedula != value))
				{
					this.Onusu_cedulaChanging(value);
					this.SendPropertyChanging();
					this._usu_cedula = value;
					this.SendPropertyChanged("usu_cedula");
					this.Onusu_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_correo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string usu_correo
		{
			get
			{
				return this._usu_correo;
			}
			set
			{
				if ((this._usu_correo != value))
				{
					this.Onusu_correoChanging(value);
					this.SendPropertyChanging();
					this._usu_correo = value;
					this.SendPropertyChanged("usu_correo");
					this.Onusu_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_dire", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string usu_dire
		{
			get
			{
				return this._usu_dire;
			}
			set
			{
				if ((this._usu_dire != value))
				{
					this.Onusu_direChanging(value);
					this.SendPropertyChanging();
					this._usu_dire = value;
					this.SendPropertyChanged("usu_dire");
					this.Onusu_direChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_celular", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string usu_celular
		{
			get
			{
				return this._usu_celular;
			}
			set
			{
				if ((this._usu_celular != value))
				{
					this.Onusu_celularChanging(value);
					this.SendPropertyChanging();
					this._usu_celular = value;
					this.SendPropertyChanged("usu_celular");
					this.Onusu_celularChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_estado", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string usu_estado
		{
			get
			{
				return this._usu_estado;
			}
			set
			{
				if ((this._usu_estado != value))
				{
					this.Onusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._usu_estado = value;
					this.SendPropertyChanged("usu_estado");
					this.Onusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roles_id", DbType="Int NOT NULL")]
		public int roles_id
		{
			get
			{
				return this._roles_id;
			}
			set
			{
				if ((this._roles_id != value))
				{
					if (this._Tbl_rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onroles_idChanging(value);
					this.SendPropertyChanging();
					this._roles_id = value;
					this.SendPropertyChanged("roles_id");
					this.Onroles_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_rol_Tbl_usuario", Storage="_Tbl_rol", ThisKey="roles_id", OtherKey="rol_id", IsForeignKey=true)]
		public Tbl_rol Tbl_rol
		{
			get
			{
				return this._Tbl_rol.Entity;
			}
			set
			{
				Tbl_rol previousValue = this._Tbl_rol.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_rol.Entity = null;
						previousValue.Tbl_usuario.Remove(this);
					}
					this._Tbl_rol.Entity = value;
					if ((value != null))
					{
						value.Tbl_usuario.Add(this);
						this._roles_id = value.rol_id;
					}
					else
					{
						this._roles_id = default(int);
					}
					this.SendPropertyChanged("Tbl_rol");
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
