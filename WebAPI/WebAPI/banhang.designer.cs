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

namespace WebAPI
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="banhang")]
	public partial class banhangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertloaihang(loaihang instance);
    partial void Updateloaihang(loaihang instance);
    partial void Deleteloaihang(loaihang instance);
    partial void Insertchitietdonhang(chitietdonhang instance);
    partial void Updatechitietdonhang(chitietdonhang instance);
    partial void Deletechitietdonhang(chitietdonhang instance);
    partial void Insertnoibac(noibac instance);
    partial void Updatenoibac(noibac instance);
    partial void Deletenoibac(noibac instance);
    partial void Insertnhomhang(nhomhang instance);
    partial void Updatenhomhang(nhomhang instance);
    partial void Deletenhomhang(nhomhang instance);
    partial void Insertdonhang(donhang instance);
    partial void Updatedonhang(donhang instance);
    partial void Deletedonhang(donhang instance);
    partial void Insertgiohang(giohang instance);
    partial void Updategiohang(giohang instance);
    partial void Deletegiohang(giohang instance);
    partial void Insertnhavien(nhavien instance);
    partial void Updatenhavien(nhavien instance);
    partial void Deletenhavien(nhavien instance);
    partial void Inserthanghoa(hanghoa instance);
    partial void Updatehanghoa(hanghoa instance);
    partial void Deletehanghoa(hanghoa instance);
    partial void Insertkhachhang(khachhang instance);
    partial void Updatekhachhang(khachhang instance);
    partial void Deletekhachhang(khachhang instance);
    #endregion
		
		public banhangDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["banhangConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public banhangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public banhangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public banhangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public banhangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<loaihang> loaihangs
		{
			get
			{
				return this.GetTable<loaihang>();
			}
		}
		
		public System.Data.Linq.Table<chitietdonhang> chitietdonhangs
		{
			get
			{
				return this.GetTable<chitietdonhang>();
			}
		}
		
		public System.Data.Linq.Table<noibac> noibacs
		{
			get
			{
				return this.GetTable<noibac>();
			}
		}
		
		public System.Data.Linq.Table<nhomhang> nhomhangs
		{
			get
			{
				return this.GetTable<nhomhang>();
			}
		}
		
		public System.Data.Linq.Table<donhang> donhangs
		{
			get
			{
				return this.GetTable<donhang>();
			}
		}
		
		public System.Data.Linq.Table<giohang> giohangs
		{
			get
			{
				return this.GetTable<giohang>();
			}
		}
		
		public System.Data.Linq.Table<nhavien> nhaviens
		{
			get
			{
				return this.GetTable<nhavien>();
			}
		}
		
		public System.Data.Linq.Table<hanghoa> hanghoas
		{
			get
			{
				return this.GetTable<hanghoa>();
			}
		}
		
		public System.Data.Linq.Table<khachhang> khachhangs
		{
			get
			{
				return this.GetTable<khachhang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.loaihang")]
	public partial class loaihang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maloai;
		
		private string _tenloai;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(string value);
    partial void OnmaloaiChanged();
    partial void OntenloaiChanging(string value);
    partial void OntenloaiChanged();
    #endregion
		
		public loaihang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenloai", DbType="VarChar(10)")]
		public string tenloai
		{
			get
			{
				return this._tenloai;
			}
			set
			{
				if ((this._tenloai != value))
				{
					this.OntenloaiChanging(value);
					this.SendPropertyChanging();
					this._tenloai = value;
					this.SendPropertyChanged("tenloai");
					this.OntenloaiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.chitietdonhang")]
	public partial class chitietdonhang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _masodh;
		
		private int _mahang;
		
		private int _soluong;
		
		private int _giadathang1sp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasodhChanging(int value);
    partial void OnmasodhChanged();
    partial void OnmahangChanging(int value);
    partial void OnmahangChanged();
    partial void OnsoluongChanging(int value);
    partial void OnsoluongChanged();
    partial void Ongiadathang1spChanging(int value);
    partial void Ongiadathang1spChanged();
    #endregion
		
		public chitietdonhang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masodh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int masodh
		{
			get
			{
				return this._masodh;
			}
			set
			{
				if ((this._masodh != value))
				{
					this.OnmasodhChanging(value);
					this.SendPropertyChanging();
					this._masodh = value;
					this.SendPropertyChanged("masodh");
					this.OnmasodhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mahang
		{
			get
			{
				return this._mahang;
			}
			set
			{
				if ((this._mahang != value))
				{
					this.OnmahangChanging(value);
					this.SendPropertyChanging();
					this._mahang = value;
					this.SendPropertyChanged("mahang");
					this.OnmahangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int NOT NULL")]
		public int soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giadathang1sp", DbType="Int NOT NULL")]
		public int giadathang1sp
		{
			get
			{
				return this._giadathang1sp;
			}
			set
			{
				if ((this._giadathang1sp != value))
				{
					this.Ongiadathang1spChanging(value);
					this.SendPropertyChanging();
					this._giadathang1sp = value;
					this.SendPropertyChanged("giadathang1sp");
					this.Ongiadathang1spChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.noibac")]
	public partial class noibac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _thutu;
		
		private int _mahang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnthutuChanging(int value);
    partial void OnthutuChanged();
    partial void OnmahangChanging(int value);
    partial void OnmahangChanged();
    #endregion
		
		public noibac()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thutu", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int thutu
		{
			get
			{
				return this._thutu;
			}
			set
			{
				if ((this._thutu != value))
				{
					this.OnthutuChanging(value);
					this.SendPropertyChanging();
					this._thutu = value;
					this.SendPropertyChanged("thutu");
					this.OnthutuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahang", DbType="Int NOT NULL")]
		public int mahang
		{
			get
			{
				return this._mahang;
			}
			set
			{
				if ((this._mahang != value))
				{
					this.OnmahangChanging(value);
					this.SendPropertyChanging();
					this._mahang = value;
					this.SendPropertyChanged("mahang");
					this.OnmahangChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.nhomhang")]
	public partial class nhomhang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _maloai;
		
		private int _manhom;
		
		private string _tennhom;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaloaiChanging(string value);
    partial void OnmaloaiChanged();
    partial void OnmanhomChanging(int value);
    partial void OnmanhomChanged();
    partial void OntennhomChanging(string value);
    partial void OntennhomChanged();
    #endregion
		
		public nhomhang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="VarChar(10)")]
		public string maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manhom", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int manhom
		{
			get
			{
				return this._manhom;
			}
			set
			{
				if ((this._manhom != value))
				{
					this.OnmanhomChanging(value);
					this.SendPropertyChanging();
					this._manhom = value;
					this.SendPropertyChanged("manhom");
					this.OnmanhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tennhom", DbType="VarChar(30)")]
		public string tennhom
		{
			get
			{
				return this._tennhom;
			}
			set
			{
				if ((this._tennhom != value))
				{
					this.OntennhomChanging(value);
					this.SendPropertyChanging();
					this._tennhom = value;
					this.SendPropertyChanged("tennhom");
					this.OntennhomChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.donhang")]
	public partial class donhang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _masodh;
		
		private string _tkkh;
		
		private string _tknv1;
		
		private string _tknv2;
		
		private System.Nullable<System.DateTime> _ngaydathang;
		
		private string _diachinhanhang;
		
		private string _tinhtrang;
		
		private string _ghichu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmasodhChanging(int value);
    partial void OnmasodhChanged();
    partial void OntkkhChanging(string value);
    partial void OntkkhChanged();
    partial void Ontknv1Changing(string value);
    partial void Ontknv1Changed();
    partial void Ontknv2Changing(string value);
    partial void Ontknv2Changed();
    partial void OnngaydathangChanging(System.Nullable<System.DateTime> value);
    partial void OnngaydathangChanged();
    partial void OndiachinhanhangChanging(string value);
    partial void OndiachinhanhangChanged();
    partial void OntinhtrangChanging(string value);
    partial void OntinhtrangChanged();
    partial void OnghichuChanging(string value);
    partial void OnghichuChanged();
    #endregion
		
		public donhang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_masodh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int masodh
		{
			get
			{
				return this._masodh;
			}
			set
			{
				if ((this._masodh != value))
				{
					this.OnmasodhChanging(value);
					this.SendPropertyChanging();
					this._masodh = value;
					this.SendPropertyChanged("masodh");
					this.OnmasodhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tkkh", DbType="VarChar(32)")]
		public string tkkh
		{
			get
			{
				return this._tkkh;
			}
			set
			{
				if ((this._tkkh != value))
				{
					this.OntkkhChanging(value);
					this.SendPropertyChanging();
					this._tkkh = value;
					this.SendPropertyChanged("tkkh");
					this.OntkkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tknv1", DbType="VarChar(32)")]
		public string tknv1
		{
			get
			{
				return this._tknv1;
			}
			set
			{
				if ((this._tknv1 != value))
				{
					this.Ontknv1Changing(value);
					this.SendPropertyChanging();
					this._tknv1 = value;
					this.SendPropertyChanged("tknv1");
					this.Ontknv1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tknv2", DbType="VarChar(32)")]
		public string tknv2
		{
			get
			{
				return this._tknv2;
			}
			set
			{
				if ((this._tknv2 != value))
				{
					this.Ontknv2Changing(value);
					this.SendPropertyChanging();
					this._tknv2 = value;
					this.SendPropertyChanged("tknv2");
					this.Ontknv2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaydathang", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngaydathang
		{
			get
			{
				return this._ngaydathang;
			}
			set
			{
				if ((this._ngaydathang != value))
				{
					this.OnngaydathangChanging(value);
					this.SendPropertyChanging();
					this._ngaydathang = value;
					this.SendPropertyChanged("ngaydathang");
					this.OnngaydathangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachinhanhang", DbType="NVarChar(100)")]
		public string diachinhanhang
		{
			get
			{
				return this._diachinhanhang;
			}
			set
			{
				if ((this._diachinhanhang != value))
				{
					this.OndiachinhanhangChanging(value);
					this.SendPropertyChanging();
					this._diachinhanhang = value;
					this.SendPropertyChanged("diachinhanhang");
					this.OndiachinhanhangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tinhtrang", DbType="VarChar(15)")]
		public string tinhtrang
		{
			get
			{
				return this._tinhtrang;
			}
			set
			{
				if ((this._tinhtrang != value))
				{
					this.OntinhtrangChanging(value);
					this.SendPropertyChanging();
					this._tinhtrang = value;
					this.SendPropertyChanged("tinhtrang");
					this.OntinhtrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ghichu", DbType="NVarChar(500)")]
		public string ghichu
		{
			get
			{
				return this._ghichu;
			}
			set
			{
				if ((this._ghichu != value))
				{
					this.OnghichuChanging(value);
					this.SendPropertyChanging();
					this._ghichu = value;
					this.SendPropertyChanged("ghichu");
					this.OnghichuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.giohang")]
	public partial class giohang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tkkh;
		
		private int _mahang;
		
		private int _soluong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntkkhChanging(string value);
    partial void OntkkhChanged();
    partial void OnmahangChanging(int value);
    partial void OnmahangChanged();
    partial void OnsoluongChanging(int value);
    partial void OnsoluongChanged();
    #endregion
		
		public giohang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tkkh", DbType="VarChar(32) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tkkh
		{
			get
			{
				return this._tkkh;
			}
			set
			{
				if ((this._tkkh != value))
				{
					this.OntkkhChanging(value);
					this.SendPropertyChanging();
					this._tkkh = value;
					this.SendPropertyChanged("tkkh");
					this.OntkkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mahang
		{
			get
			{
				return this._mahang;
			}
			set
			{
				if ((this._mahang != value))
				{
					this.OnmahangChanging(value);
					this.SendPropertyChanging();
					this._mahang = value;
					this.SendPropertyChanged("mahang");
					this.OnmahangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int NOT NULL")]
		public int soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.nhavien")]
	public partial class nhavien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tknv;
		
		private string _mknv;
		
		private string _hotennv;
		
		private string _gioitinhnv;
		
		private string _diachinv;
		
		private System.Nullable<int> _sdtnv;
		
		private System.Nullable<int> _cmndnv;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntknvChanging(string value);
    partial void OntknvChanged();
    partial void OnmknvChanging(string value);
    partial void OnmknvChanged();
    partial void OnhotennvChanging(string value);
    partial void OnhotennvChanged();
    partial void OngioitinhnvChanging(string value);
    partial void OngioitinhnvChanged();
    partial void OndiachinvChanging(string value);
    partial void OndiachinvChanged();
    partial void OnsdtnvChanging(System.Nullable<int> value);
    partial void OnsdtnvChanged();
    partial void OncmndnvChanging(System.Nullable<int> value);
    partial void OncmndnvChanged();
    #endregion
		
		public nhavien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tknv", DbType="VarChar(32) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tknv
		{
			get
			{
				return this._tknv;
			}
			set
			{
				if ((this._tknv != value))
				{
					this.OntknvChanging(value);
					this.SendPropertyChanging();
					this._tknv = value;
					this.SendPropertyChanged("tknv");
					this.OntknvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mknv", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string mknv
		{
			get
			{
				return this._mknv;
			}
			set
			{
				if ((this._mknv != value))
				{
					this.OnmknvChanging(value);
					this.SendPropertyChanging();
					this._mknv = value;
					this.SendPropertyChanged("mknv");
					this.OnmknvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotennv", DbType="NVarChar(100)")]
		public string hotennv
		{
			get
			{
				return this._hotennv;
			}
			set
			{
				if ((this._hotennv != value))
				{
					this.OnhotennvChanging(value);
					this.SendPropertyChanging();
					this._hotennv = value;
					this.SendPropertyChanged("hotennv");
					this.OnhotennvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinhnv", DbType="NVarChar(50)")]
		public string gioitinhnv
		{
			get
			{
				return this._gioitinhnv;
			}
			set
			{
				if ((this._gioitinhnv != value))
				{
					this.OngioitinhnvChanging(value);
					this.SendPropertyChanging();
					this._gioitinhnv = value;
					this.SendPropertyChanged("gioitinhnv");
					this.OngioitinhnvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachinv", DbType="NVarChar(100)")]
		public string diachinv
		{
			get
			{
				return this._diachinv;
			}
			set
			{
				if ((this._diachinv != value))
				{
					this.OndiachinvChanging(value);
					this.SendPropertyChanging();
					this._diachinv = value;
					this.SendPropertyChanged("diachinv");
					this.OndiachinvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdtnv", DbType="Int")]
		public System.Nullable<int> sdtnv
		{
			get
			{
				return this._sdtnv;
			}
			set
			{
				if ((this._sdtnv != value))
				{
					this.OnsdtnvChanging(value);
					this.SendPropertyChanging();
					this._sdtnv = value;
					this.SendPropertyChanged("sdtnv");
					this.OnsdtnvChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmndnv", DbType="Int")]
		public System.Nullable<int> cmndnv
		{
			get
			{
				return this._cmndnv;
			}
			set
			{
				if ((this._cmndnv != value))
				{
					this.OncmndnvChanging(value);
					this.SendPropertyChanging();
					this._cmndnv = value;
					this.SendPropertyChanged("cmndnv");
					this.OncmndnvChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.hanghoa")]
	public partial class hanghoa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mahang;
		
		private string _maloai;
		
		private int _manhom;
		
		private string _tenhang;
		
		private int _gia;
		
		private string _hinh;
		
		private string _mota;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmahangChanging(int value);
    partial void OnmahangChanged();
    partial void OnmaloaiChanging(string value);
    partial void OnmaloaiChanged();
    partial void OnmanhomChanging(int value);
    partial void OnmanhomChanged();
    partial void OntenhangChanging(string value);
    partial void OntenhangChanged();
    partial void OngiaChanging(int value);
    partial void OngiaChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OnmotaChanging(string value);
    partial void OnmotaChanged();
    #endregion
		
		public hanghoa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int mahang
		{
			get
			{
				return this._mahang;
			}
			set
			{
				if ((this._mahang != value))
				{
					this.OnmahangChanging(value);
					this.SendPropertyChanging();
					this._mahang = value;
					this.SendPropertyChanged("mahang");
					this.OnmahangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maloai", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string maloai
		{
			get
			{
				return this._maloai;
			}
			set
			{
				if ((this._maloai != value))
				{
					this.OnmaloaiChanging(value);
					this.SendPropertyChanging();
					this._maloai = value;
					this.SendPropertyChanged("maloai");
					this.OnmaloaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_manhom", DbType="Int NOT NULL")]
		public int manhom
		{
			get
			{
				return this._manhom;
			}
			set
			{
				if ((this._manhom != value))
				{
					this.OnmanhomChanging(value);
					this.SendPropertyChanging();
					this._manhom = value;
					this.SendPropertyChanged("manhom");
					this.OnmanhomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenhang", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string tenhang
		{
			get
			{
				return this._tenhang;
			}
			set
			{
				if ((this._tenhang != value))
				{
					this.OntenhangChanging(value);
					this.SendPropertyChanging();
					this._tenhang = value;
					this.SendPropertyChanged("tenhang");
					this.OntenhangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Int NOT NULL")]
		public int gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mota", DbType="NVarChar(4000)")]
		public string mota
		{
			get
			{
				return this._mota;
			}
			set
			{
				if ((this._mota != value))
				{
					this.OnmotaChanging(value);
					this.SendPropertyChanging();
					this._mota = value;
					this.SendPropertyChanged("mota");
					this.OnmotaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.khachhang")]
	public partial class khachhang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tkkh;
		
		private string _mkkh;
		
		private string _hotenkh;
		
		private string _gioitinhkh;
		
		private string _diachikh;
		
		private int _sdtkh;
		
		private int _cmndkh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntkkhChanging(string value);
    partial void OntkkhChanged();
    partial void OnmkkhChanging(string value);
    partial void OnmkkhChanged();
    partial void OnhotenkhChanging(string value);
    partial void OnhotenkhChanged();
    partial void OngioitinhkhChanging(string value);
    partial void OngioitinhkhChanged();
    partial void OndiachikhChanging(string value);
    partial void OndiachikhChanged();
    partial void OnsdtkhChanging(int value);
    partial void OnsdtkhChanged();
    partial void OncmndkhChanging(int value);
    partial void OncmndkhChanged();
    #endregion
		
		public khachhang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tkkh", DbType="VarChar(32) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tkkh
		{
			get
			{
				return this._tkkh;
			}
			set
			{
				if ((this._tkkh != value))
				{
					this.OntkkhChanging(value);
					this.SendPropertyChanging();
					this._tkkh = value;
					this.SendPropertyChanged("tkkh");
					this.OntkkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mkkh", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string mkkh
		{
			get
			{
				return this._mkkh;
			}
			set
			{
				if ((this._mkkh != value))
				{
					this.OnmkkhChanging(value);
					this.SendPropertyChanging();
					this._mkkh = value;
					this.SendPropertyChanged("mkkh");
					this.OnmkkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hotenkh", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string hotenkh
		{
			get
			{
				return this._hotenkh;
			}
			set
			{
				if ((this._hotenkh != value))
				{
					this.OnhotenkhChanging(value);
					this.SendPropertyChanging();
					this._hotenkh = value;
					this.SendPropertyChanged("hotenkh");
					this.OnhotenkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gioitinhkh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string gioitinhkh
		{
			get
			{
				return this._gioitinhkh;
			}
			set
			{
				if ((this._gioitinhkh != value))
				{
					this.OngioitinhkhChanging(value);
					this.SendPropertyChanging();
					this._gioitinhkh = value;
					this.SendPropertyChanged("gioitinhkh");
					this.OngioitinhkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachikh", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string diachikh
		{
			get
			{
				return this._diachikh;
			}
			set
			{
				if ((this._diachikh != value))
				{
					this.OndiachikhChanging(value);
					this.SendPropertyChanging();
					this._diachikh = value;
					this.SendPropertyChanged("diachikh");
					this.OndiachikhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdtkh", DbType="Int NOT NULL")]
		public int sdtkh
		{
			get
			{
				return this._sdtkh;
			}
			set
			{
				if ((this._sdtkh != value))
				{
					this.OnsdtkhChanging(value);
					this.SendPropertyChanging();
					this._sdtkh = value;
					this.SendPropertyChanged("sdtkh");
					this.OnsdtkhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cmndkh", DbType="Int NOT NULL")]
		public int cmndkh
		{
			get
			{
				return this._cmndkh;
			}
			set
			{
				if ((this._cmndkh != value))
				{
					this.OncmndkhChanging(value);
					this.SendPropertyChanging();
					this._cmndkh = value;
					this.SendPropertyChanged("cmndkh");
					this.OncmndkhChanged();
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
