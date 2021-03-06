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

namespace AppLibarary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ManageLibrary")]
	public partial class dbLibraryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBookShelf(BookShelf instance);
    partial void UpdateBookShelf(BookShelf instance);
    partial void DeleteBookShelf(BookShelf instance);
    #endregion
		
		public dbLibraryDataContext() : 
				base(global::AppLibarary.Properties.Settings.Default.ManageLibraryConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public dbLibraryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbLibraryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbLibraryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbLibraryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BookShelf> BookShelfs
		{
			get
			{
				return this.GetTable<BookShelf>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _bookID;
		
		private string _bookName;
		
		private string _kind;
		
		private string _publisherID;
		
		private string _bookShelfID;
		
		private System.Nullable<System.DateTime> _timeInput;
		
		private string _fettle;
		
		private EntityRef<BookShelf> _BookShelf;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookIDChanging(string value);
    partial void OnbookIDChanged();
    partial void OnbookNameChanging(string value);
    partial void OnbookNameChanged();
    partial void OnkindChanging(string value);
    partial void OnkindChanged();
    partial void OnpublisherIDChanging(string value);
    partial void OnpublisherIDChanged();
    partial void OnbookShelfIDChanging(string value);
    partial void OnbookShelfIDChanged();
    partial void OntimeInputChanging(System.Nullable<System.DateTime> value);
    partial void OntimeInputChanged();
    partial void OnfettleChanging(string value);
    partial void OnfettleChanged();
    #endregion
		
		public Book()
		{
			this._BookShelf = default(EntityRef<BookShelf>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookID", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string bookID
		{
			get
			{
				return this._bookID;
			}
			set
			{
				if ((this._bookID != value))
				{
					this.OnbookIDChanging(value);
					this.SendPropertyChanging();
					this._bookID = value;
					this.SendPropertyChanged("bookID");
					this.OnbookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string bookName
		{
			get
			{
				return this._bookName;
			}
			set
			{
				if ((this._bookName != value))
				{
					this.OnbookNameChanging(value);
					this.SendPropertyChanging();
					this._bookName = value;
					this.SendPropertyChanged("bookName");
					this.OnbookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kind", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string kind
		{
			get
			{
				return this._kind;
			}
			set
			{
				if ((this._kind != value))
				{
					this.OnkindChanging(value);
					this.SendPropertyChanging();
					this._kind = value;
					this.SendPropertyChanged("kind");
					this.OnkindChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publisherID", DbType="VarChar(10)")]
		public string publisherID
		{
			get
			{
				return this._publisherID;
			}
			set
			{
				if ((this._publisherID != value))
				{
					this.OnpublisherIDChanging(value);
					this.SendPropertyChanging();
					this._publisherID = value;
					this.SendPropertyChanged("publisherID");
					this.OnpublisherIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookShelfID", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string bookShelfID
		{
			get
			{
				return this._bookShelfID;
			}
			set
			{
				if ((this._bookShelfID != value))
				{
					if (this._BookShelf.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbookShelfIDChanging(value);
					this.SendPropertyChanging();
					this._bookShelfID = value;
					this.SendPropertyChanged("bookShelfID");
					this.OnbookShelfIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeInput", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeInput
		{
			get
			{
				return this._timeInput;
			}
			set
			{
				if ((this._timeInput != value))
				{
					this.OntimeInputChanging(value);
					this.SendPropertyChanging();
					this._timeInput = value;
					this.SendPropertyChanged("timeInput");
					this.OntimeInputChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fettle", DbType="VarChar(50)")]
		public string fettle
		{
			get
			{
				return this._fettle;
			}
			set
			{
				if ((this._fettle != value))
				{
					this.OnfettleChanging(value);
					this.SendPropertyChanging();
					this._fettle = value;
					this.SendPropertyChanged("fettle");
					this.OnfettleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookShelf_Book", Storage="_BookShelf", ThisKey="bookShelfID", OtherKey="bookShelfID", IsForeignKey=true)]
		public BookShelf BookShelf
		{
			get
			{
				return this._BookShelf.Entity;
			}
			set
			{
				BookShelf previousValue = this._BookShelf.Entity;
				if (((previousValue != value) 
							|| (this._BookShelf.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BookShelf.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._BookShelf.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._bookShelfID = value.bookShelfID;
					}
					else
					{
						this._bookShelfID = default(string);
					}
					this.SendPropertyChanged("BookShelf");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookShelf")]
	public partial class BookShelf : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _bookShelfID;
		
		private string _bookShelfName;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookShelfIDChanging(string value);
    partial void OnbookShelfIDChanged();
    partial void OnbookShelfNameChanging(string value);
    partial void OnbookShelfNameChanged();
    #endregion
		
		public BookShelf()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookShelfID", DbType="VarChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string bookShelfID
		{
			get
			{
				return this._bookShelfID;
			}
			set
			{
				if ((this._bookShelfID != value))
				{
					this.OnbookShelfIDChanging(value);
					this.SendPropertyChanging();
					this._bookShelfID = value;
					this.SendPropertyChanged("bookShelfID");
					this.OnbookShelfIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookShelfName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string bookShelfName
		{
			get
			{
				return this._bookShelfName;
			}
			set
			{
				if ((this._bookShelfName != value))
				{
					this.OnbookShelfNameChanging(value);
					this.SendPropertyChanging();
					this._bookShelfName = value;
					this.SendPropertyChanged("bookShelfName");
					this.OnbookShelfNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BookShelf_Book", Storage="_Books", ThisKey="bookShelfID", OtherKey="bookShelfID")]
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
			entity.BookShelf = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BookShelf = null;
		}
	}
}
#pragma warning restore 1591
