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

namespace QLInternetDAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLInternet")]
	public partial class QLInternetDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDichVu(DichVu instance);
    partial void UpdateDichVu(DichVu instance);
    partial void DeleteDichVu(DichVu instance);
    partial void InsertLichSu(LichSu instance);
    partial void UpdateLichSu(LichSu instance);
    partial void DeleteLichSu(LichSu instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    partial void InsertThongTinTK(ThongTinTK instance);
    partial void UpdateThongTinTK(ThongTinTK instance);
    partial void DeleteThongTinTK(ThongTinTK instance);
    #endregion
		
		public QLInternetDataContext() : 
				base(global::QLInternetDAL.Properties.Settings.Default.QLInternetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLInternetDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLInternetDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLInternetDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLInternetDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DichVu> DichVus
		{
			get
			{
				return this.GetTable<DichVu>();
			}
		}
		
		public System.Data.Linq.Table<LichSu> LichSus
		{
			get
			{
				return this.GetTable<LichSu>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<ThongTinTK> ThongTinTKs
		{
			get
			{
				return this.GetTable<ThongTinTK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DichVu")]
	public partial class DichVu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenDV;
		
		private System.Nullable<double> _GiaDV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenDVChanging(string value);
    partial void OnTenDVChanged();
    partial void OnGiaDVChanging(System.Nullable<double> value);
    partial void OnGiaDVChanged();
    #endregion
		
		public DichVu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDV", DbType="Char(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenDV
		{
			get
			{
				return this._TenDV;
			}
			set
			{
				if ((this._TenDV != value))
				{
					this.OnTenDVChanging(value);
					this.SendPropertyChanging();
					this._TenDV = value;
					this.SendPropertyChanged("TenDV");
					this.OnTenDVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaDV", DbType="Float")]
		public System.Nullable<double> GiaDV
		{
			get
			{
				return this._GiaDV;
			}
			set
			{
				if ((this._GiaDV != value))
				{
					this.OnGiaDVChanging(value);
					this.SendPropertyChanging();
					this._GiaDV = value;
					this.SendPropertyChanged("GiaDV");
					this.OnGiaDVChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichSu")]
	public partial class LichSu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _NgayGD;
		
		private string _TenTK;
		
		private System.Nullable<double> _TienThem;
		
		private System.Nullable<double> _TGThem;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNgayGDChanging(System.DateTime value);
    partial void OnNgayGDChanged();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnTienThemChanging(System.Nullable<double> value);
    partial void OnTienThemChanged();
    partial void OnTGThemChanging(System.Nullable<double> value);
    partial void OnTGThemChanged();
    #endregion
		
		public LichSu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGD", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime NgayGD
		{
			get
			{
				return this._NgayGD;
			}
			set
			{
				if ((this._NgayGD != value))
				{
					this.OnNgayGDChanging(value);
					this.SendPropertyChanging();
					this._NgayGD = value;
					this.SendPropertyChanged("NgayGD");
					this.OnNgayGDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="Char(200)")]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienThem", DbType="Float")]
		public System.Nullable<double> TienThem
		{
			get
			{
				return this._TienThem;
			}
			set
			{
				if ((this._TienThem != value))
				{
					this.OnTienThemChanging(value);
					this.SendPropertyChanging();
					this._TienThem = value;
					this.SendPropertyChanged("TienThem");
					this.OnTienThemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TGThem", DbType="Float")]
		public System.Nullable<double> TGThem
		{
			get
			{
				return this._TGThem;
			}
			set
			{
				if ((this._TGThem != value))
				{
					this.OnTGThemChanging(value);
					this.SendPropertyChanging();
					this._TGThem = value;
					this.SendPropertyChanged("TGThem");
					this.OnTGThemChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenTK;
		
		private string _MatKhau;
		
		private System.Nullable<bool> _TrangThai;
		
		private System.Nullable<double> _TongTG;
		
		private System.Nullable<double> _TGconLai;
		
		private EntityRef<ThongTinTK> _ThongTinTK;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnTrangThaiChanging(System.Nullable<bool> value);
    partial void OnTrangThaiChanged();
    partial void OnTongTGChanging(System.Nullable<double> value);
    partial void OnTongTGChanged();
    partial void OnTGconLaiChanging(System.Nullable<double> value);
    partial void OnTGconLaiChanged();
    #endregion
		
		public TaiKhoan()
		{
			this._ThongTinTK = default(EntityRef<ThongTinTK>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="Char(200) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="Bit")]
		public System.Nullable<bool> TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTG", DbType="Float")]
		public System.Nullable<double> TongTG
		{
			get
			{
				return this._TongTG;
			}
			set
			{
				if ((this._TongTG != value))
				{
					this.OnTongTGChanging(value);
					this.SendPropertyChanging();
					this._TongTG = value;
					this.SendPropertyChanged("TongTG");
					this.OnTongTGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TGconLai", DbType="Float")]
		public System.Nullable<double> TGconLai
		{
			get
			{
				return this._TGconLai;
			}
			set
			{
				if ((this._TGconLai != value))
				{
					this.OnTGconLaiChanging(value);
					this.SendPropertyChanging();
					this._TGconLai = value;
					this.SendPropertyChanged("TGconLai");
					this.OnTGconLaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_ThongTinTK", Storage="_ThongTinTK", ThisKey="TenTK", OtherKey="TenTK", IsUnique=true, IsForeignKey=false)]
		public ThongTinTK ThongTinTK
		{
			get
			{
				return this._ThongTinTK.Entity;
			}
			set
			{
				ThongTinTK previousValue = this._ThongTinTK.Entity;
				if (((previousValue != value) 
							|| (this._ThongTinTK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ThongTinTK.Entity = null;
						previousValue.TaiKhoan = null;
					}
					this._ThongTinTK.Entity = value;
					if ((value != null))
					{
						value.TaiKhoan = this;
					}
					this.SendPropertyChanged("ThongTinTK");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ThongTinTK")]
	public partial class ThongTinTK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenTK;
		
		private string _SDT;
		
		private string _Email;
		
		private EntityRef<TaiKhoan> _TaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public ThongTinTK()
		{
			this._TaiKhoan = default(EntityRef<TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="Char(200) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					if (this._TaiKhoan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="Char(200)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_ThongTinTK", Storage="_TaiKhoan", ThisKey="TenTK", OtherKey="TenTK", IsForeignKey=true)]
		public TaiKhoan TaiKhoan
		{
			get
			{
				return this._TaiKhoan.Entity;
			}
			set
			{
				TaiKhoan previousValue = this._TaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._TaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TaiKhoan.Entity = null;
						previousValue.ThongTinTK = null;
					}
					this._TaiKhoan.Entity = value;
					if ((value != null))
					{
						value.ThongTinTK = this;
						this._TenTK = value.TenTK;
					}
					else
					{
						this._TenTK = default(string);
					}
					this.SendPropertyChanged("TaiKhoan");
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
