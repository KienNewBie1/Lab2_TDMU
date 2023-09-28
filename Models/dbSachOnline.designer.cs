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

namespace SachOnline.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SachOnline")]
	public partial class dbSachOnlineDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPublisher(Publisher instance);
    partial void UpdatePublisher(Publisher instance);
    partial void DeletePublisher(Publisher instance);
    partial void InsertChuDe(ChuDe instance);
    partial void UpdateChuDe(ChuDe instance);
    partial void DeleteChuDe(ChuDe instance);
    partial void InsertBook_author(Book_author instance);
    partial void UpdateBook_author(Book_author instance);
    partial void DeleteBook_author(Book_author instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertSachBanNhieu(SachBanNhieu instance);
    partial void UpdateSachBanNhieu(SachBanNhieu instance);
    partial void DeleteSachBanNhieu(SachBanNhieu instance);
    #endregion
		
		public dbSachOnlineDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SachOnlineConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbSachOnlineDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbSachOnlineDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbSachOnlineDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbSachOnlineDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Publisher> Publishers
		{
			get
			{
				return this.GetTable<Publisher>();
			}
		}
		
		public System.Data.Linq.Table<ChuDe> ChuDes
		{
			get
			{
				return this.GetTable<ChuDe>();
			}
		}
		
		public System.Data.Linq.Table<Book_author> Book_authors
		{
			get
			{
				return this.GetTable<Book_author>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<SachBanNhieu> SachBanNhieus
		{
			get
			{
				return this.GetTable<SachBanNhieu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Publisher")]
	public partial class Publisher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Publisher_id;
		
		private string _Publisher_name;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPublisher_idChanging(int value);
    partial void OnPublisher_idChanged();
    partial void OnPublisher_nameChanging(string value);
    partial void OnPublisher_nameChanged();
    #endregion
		
		public Publisher()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Publisher_id
		{
			get
			{
				return this._Publisher_id;
			}
			set
			{
				if ((this._Publisher_id != value))
				{
					this.OnPublisher_idChanging(value);
					this.SendPropertyChanging();
					this._Publisher_id = value;
					this.SendPropertyChanged("Publisher_id");
					this.OnPublisher_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher_name", DbType="VarChar(50)")]
		public string Publisher_name
		{
			get
			{
				return this._Publisher_name;
			}
			set
			{
				if ((this._Publisher_name != value))
				{
					this.OnPublisher_nameChanging(value);
					this.SendPropertyChanging();
					this._Publisher_name = value;
					this.SendPropertyChanged("Publisher_name");
					this.OnPublisher_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publisher_Book", Storage="_Books", ThisKey="Publisher_id", OtherKey="Publisher_id")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Publisher = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Publisher = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChuDe")]
	public partial class ChuDe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChuDe;
		
		private string _TenChuDe;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChuDeChanging(int value);
    partial void OnMaChuDeChanged();
    partial void OnTenChuDeChanging(string value);
    partial void OnTenChuDeChanged();
    #endregion
		
		public ChuDe()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChuDe", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaChuDe
		{
			get
			{
				return this._MaChuDe;
			}
			set
			{
				if ((this._MaChuDe != value))
				{
					this.OnMaChuDeChanging(value);
					this.SendPropertyChanging();
					this._MaChuDe = value;
					this.SendPropertyChanged("MaChuDe");
					this.OnMaChuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChuDe", DbType="VarChar(20)")]
		public string TenChuDe
		{
			get
			{
				return this._TenChuDe;
			}
			set
			{
				if ((this._TenChuDe != value))
				{
					this.OnTenChuDeChanging(value);
					this.SendPropertyChanging();
					this._TenChuDe = value;
					this.SendPropertyChanged("TenChuDe");
					this.OnTenChuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChuDe_Book", Storage="_Books", ThisKey="MaChuDe", OtherKey="MaChuDe")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.ChuDe = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.ChuDe = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book_author")]
	public partial class Book_author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookID;
		
		private System.Nullable<int> _AuthorID;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<Author> _Author;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    partial void OnAuthorIDChanging(System.Nullable<int> value);
    partial void OnAuthorIDChanged();
    #endregion
		
		public Book_author()
		{
			this._Book = default(EntityRef<Book>);
			this._Author = default(EntityRef<Author>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int")]
		public System.Nullable<int> AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Book_author", Storage="_Book", ThisKey="BookID", OtherKey="BookID", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Book_author = null;
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Book_author = this;
						this._BookID = value.BookID;
					}
					else
					{
						this._BookID = default(int);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book_author", Storage="_Author", ThisKey="AuthorID", OtherKey="Author_id", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.Book_authors.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.Book_authors.Add(this);
						this._AuthorID = value.Author_id;
					}
					else
					{
						this._AuthorID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Author");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookID;
		
		private string _NameBook;
		
		private System.Nullable<System.DateTime> _Publication_date;
		
		private System.Nullable<int> _Publisher_id;
		
		private string _AnhBia;
		
		private System.Nullable<int> _MaChuDe;
		
		private EntityRef<Book_author> _Book_author;
		
		private EntityRef<ChuDe> _ChuDe;
		
		private EntityRef<Publisher> _Publisher;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    partial void OnNameBookChanging(string value);
    partial void OnNameBookChanged();
    partial void OnPublication_dateChanging(System.Nullable<System.DateTime> value);
    partial void OnPublication_dateChanged();
    partial void OnPublisher_idChanging(System.Nullable<int> value);
    partial void OnPublisher_idChanged();
    partial void OnAnhBiaChanging(string value);
    partial void OnAnhBiaChanged();
    partial void OnMaChuDeChanging(System.Nullable<int> value);
    partial void OnMaChuDeChanged();
    #endregion
		
		public Book()
		{
			this._Book_author = default(EntityRef<Book_author>);
			this._ChuDe = default(EntityRef<ChuDe>);
			this._Publisher = default(EntityRef<Publisher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameBook", DbType="VarChar(50)")]
		public string NameBook
		{
			get
			{
				return this._NameBook;
			}
			set
			{
				if ((this._NameBook != value))
				{
					this.OnNameBookChanging(value);
					this.SendPropertyChanging();
					this._NameBook = value;
					this.SendPropertyChanged("NameBook");
					this.OnNameBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publication_date", DbType="Date")]
		public System.Nullable<System.DateTime> Publication_date
		{
			get
			{
				return this._Publication_date;
			}
			set
			{
				if ((this._Publication_date != value))
				{
					this.OnPublication_dateChanging(value);
					this.SendPropertyChanging();
					this._Publication_date = value;
					this.SendPropertyChanged("Publication_date");
					this.OnPublication_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher_id", DbType="Int")]
		public System.Nullable<int> Publisher_id
		{
			get
			{
				return this._Publisher_id;
			}
			set
			{
				if ((this._Publisher_id != value))
				{
					if (this._Publisher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPublisher_idChanging(value);
					this.SendPropertyChanging();
					this._Publisher_id = value;
					this.SendPropertyChanged("Publisher_id");
					this.OnPublisher_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhBia", DbType="VarChar(20)")]
		public string AnhBia
		{
			get
			{
				return this._AnhBia;
			}
			set
			{
				if ((this._AnhBia != value))
				{
					this.OnAnhBiaChanging(value);
					this.SendPropertyChanging();
					this._AnhBia = value;
					this.SendPropertyChanged("AnhBia");
					this.OnAnhBiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChuDe", DbType="Int")]
		public System.Nullable<int> MaChuDe
		{
			get
			{
				return this._MaChuDe;
			}
			set
			{
				if ((this._MaChuDe != value))
				{
					if (this._ChuDe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaChuDeChanging(value);
					this.SendPropertyChanging();
					this._MaChuDe = value;
					this.SendPropertyChanged("MaChuDe");
					this.OnMaChuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Book_author", Storage="_Book_author", ThisKey="BookID", OtherKey="BookID", IsUnique=true, IsForeignKey=false)]
		public Book_author Book_author
		{
			get
			{
				return this._Book_author.Entity;
			}
			set
			{
				Book_author previousValue = this._Book_author.Entity;
				if (((previousValue != value) 
							|| (this._Book_author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book_author.Entity = null;
						previousValue.Book = null;
					}
					this._Book_author.Entity = value;
					if ((value != null))
					{
						value.Book = this;
					}
					this.SendPropertyChanged("Book_author");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ChuDe_Book", Storage="_ChuDe", ThisKey="MaChuDe", OtherKey="MaChuDe", IsForeignKey=true)]
		public ChuDe ChuDe
		{
			get
			{
				return this._ChuDe.Entity;
			}
			set
			{
				ChuDe previousValue = this._ChuDe.Entity;
				if (((previousValue != value) 
							|| (this._ChuDe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ChuDe.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._ChuDe.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._MaChuDe = value.MaChuDe;
					}
					else
					{
						this._MaChuDe = default(Nullable<int>);
					}
					this.SendPropertyChanged("ChuDe");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publisher_Book", Storage="_Publisher", ThisKey="Publisher_id", OtherKey="Publisher_id", IsForeignKey=true)]
		public Publisher Publisher
		{
			get
			{
				return this._Publisher.Entity;
			}
			set
			{
				Publisher previousValue = this._Publisher.Entity;
				if (((previousValue != value) 
							|| (this._Publisher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Publisher.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Publisher.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._Publisher_id = value.Publisher_id;
					}
					else
					{
						this._Publisher_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Publisher");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Author")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Author_id;
		
		private string _Author_name;
		
		private EntitySet<Book_author> _Book_authors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthor_idChanging(int value);
    partial void OnAuthor_idChanged();
    partial void OnAuthor_nameChanging(string value);
    partial void OnAuthor_nameChanged();
    #endregion
		
		public Author()
		{
			this._Book_authors = new EntitySet<Book_author>(new Action<Book_author>(this.attach_Book_authors), new Action<Book_author>(this.detach_Book_authors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Author_id
		{
			get
			{
				return this._Author_id;
			}
			set
			{
				if ((this._Author_id != value))
				{
					this.OnAuthor_idChanging(value);
					this.SendPropertyChanging();
					this._Author_id = value;
					this.SendPropertyChanged("Author_id");
					this.OnAuthor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author_name", DbType="VarChar(50)")]
		public string Author_name
		{
			get
			{
				return this._Author_name;
			}
			set
			{
				if ((this._Author_name != value))
				{
					this.OnAuthor_nameChanging(value);
					this.SendPropertyChanging();
					this._Author_name = value;
					this.SendPropertyChanged("Author_name");
					this.OnAuthor_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book_author", Storage="_Book_authors", ThisKey="Author_id", OtherKey="AuthorID")]
		public EntitySet<Book_author> Book_authors
		{
			get
			{
				return this._Book_authors;
			}
			set
			{
				this._Book_authors.Assign(value);
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
		
		private void attach_Book_authors(Book_author entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_Book_authors(Book_author entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SachBanNhieu")]
	public partial class SachBanNhieu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSach;
		
		private string _TenSach;
		
		private System.Nullable<int> _SoLuongSachDaBan;
		
		private string _AnhSach;
		
		private System.Nullable<System.DateTime> _NgayXuatBan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(int value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnSoLuongSachDaBanChanging(System.Nullable<int> value);
    partial void OnSoLuongSachDaBanChanged();
    partial void OnAnhSachChanging(string value);
    partial void OnAnhSachChanged();
    partial void OnNgayXuatBanChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayXuatBanChanged();
    #endregion
		
		public SachBanNhieu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(20)")]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongSachDaBan", DbType="Int")]
		public System.Nullable<int> SoLuongSachDaBan
		{
			get
			{
				return this._SoLuongSachDaBan;
			}
			set
			{
				if ((this._SoLuongSachDaBan != value))
				{
					this.OnSoLuongSachDaBanChanging(value);
					this.SendPropertyChanging();
					this._SoLuongSachDaBan = value;
					this.SendPropertyChanged("SoLuongSachDaBan");
					this.OnSoLuongSachDaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhSach", DbType="VarChar(12)")]
		public string AnhSach
		{
			get
			{
				return this._AnhSach;
			}
			set
			{
				if ((this._AnhSach != value))
				{
					this.OnAnhSachChanging(value);
					this.SendPropertyChanging();
					this._AnhSach = value;
					this.SendPropertyChanged("AnhSach");
					this.OnAnhSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXuatBan", DbType="Date")]
		public System.Nullable<System.DateTime> NgayXuatBan
		{
			get
			{
				return this._NgayXuatBan;
			}
			set
			{
				if ((this._NgayXuatBan != value))
				{
					this.OnNgayXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NgayXuatBan = value;
					this.SendPropertyChanged("NgayXuatBan");
					this.OnNgayXuatBanChanged();
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
