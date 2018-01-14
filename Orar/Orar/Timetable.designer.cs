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

namespace Orar
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Timetable")]
	public partial class TimetableDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAttend(Attend instance);
    partial void UpdateAttend(Attend instance);
    partial void DeleteAttend(Attend instance);
    partial void InsertClass(Class instance);
    partial void UpdateClass(Class instance);
    partial void DeleteClass(Class instance);
    partial void InsertClassRoom(ClassRoom instance);
    partial void UpdateClassRoom(ClassRoom instance);
    partial void DeleteClassRoom(ClassRoom instance);
    partial void InsertGroup(Group instance);
    partial void UpdateGroup(Group instance);
    partial void DeleteGroup(Group instance);
    partial void InsertProfessor(Professor instance);
    partial void UpdateProfessor(Professor instance);
    partial void DeleteProfessor(Professor instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public TimetableDataContext() : 
				base(global::Orar.Properties.Settings.Default.TimetableConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TimetableDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimetableDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimetableDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimetableDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Attend> Attends
		{
			get
			{
				return this.GetTable<Attend>();
			}
		}
		
		public System.Data.Linq.Table<Class> Classes
		{
			get
			{
				return this.GetTable<Class>();
			}
		}
		
		public System.Data.Linq.Table<ClassRoom> ClassRooms
		{
			get
			{
				return this.GetTable<ClassRoom>();
			}
		}
		
		public System.Data.Linq.Table<Group> Groups
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<Professor> Professors
		{
			get
			{
				return this.GetTable<Professor>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Attends")]
	public partial class Attend : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _Group_ID;
		
		private int _Classes_ID;
		
		private EntityRef<Class> _Class;
		
		private EntityRef<Group> _Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnGroup_IDChanging(int value);
    partial void OnGroup_IDChanged();
    partial void OnClasses_IDChanging(int value);
    partial void OnClasses_IDChanged();
    #endregion
		
		public Attend()
		{
			this._Class = default(EntityRef<Class>);
			this._Group = default(EntityRef<Group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_ID", DbType="Int NOT NULL")]
		public int Group_ID
		{
			get
			{
				return this._Group_ID;
			}
			set
			{
				if ((this._Group_ID != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroup_IDChanging(value);
					this.SendPropertyChanging();
					this._Group_ID = value;
					this.SendPropertyChanged("Group_ID");
					this.OnGroup_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classes_ID", DbType="Int NOT NULL")]
		public int Classes_ID
		{
			get
			{
				return this._Classes_ID;
			}
			set
			{
				if ((this._Classes_ID != value))
				{
					if (this._Class.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClasses_IDChanging(value);
					this.SendPropertyChanging();
					this._Classes_ID = value;
					this.SendPropertyChanged("Classes_ID");
					this.OnClasses_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_Attend", Storage="_Class", ThisKey="Classes_ID", OtherKey="ID", IsForeignKey=true)]
		public Class Class
		{
			get
			{
				return this._Class.Entity;
			}
			set
			{
				Class previousValue = this._Class.Entity;
				if (((previousValue != value) 
							|| (this._Class.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Class.Entity = null;
						previousValue.Attends.Remove(this);
					}
					this._Class.Entity = value;
					if ((value != null))
					{
						value.Attends.Add(this);
						this._Classes_ID = value.ID;
					}
					else
					{
						this._Classes_ID = default(int);
					}
					this.SendPropertyChanged("Class");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Attend", Storage="_Group", ThisKey="Group_ID", OtherKey="ID", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Attends.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Attends.Add(this);
						this._Group_ID = value.ID;
					}
					else
					{
						this._Group_ID = default(int);
					}
					this.SendPropertyChanged("Group");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Classes")]
	public partial class Class : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Professor_ID;
		
		private int _Credits;
		
		private EntitySet<Attend> _Attends;
		
		private EntityRef<Professor> _Professor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnProfessor_IDChanging(int value);
    partial void OnProfessor_IDChanged();
    partial void OnCreditsChanging(int value);
    partial void OnCreditsChanged();
    #endregion
		
		public Class()
		{
			this._Attends = new EntitySet<Attend>(new Action<Attend>(this.attach_Attends), new Action<Attend>(this.detach_Attends));
			this._Professor = default(EntityRef<Professor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Professor_ID", DbType="Int NOT NULL")]
		public int Professor_ID
		{
			get
			{
				return this._Professor_ID;
			}
			set
			{
				if ((this._Professor_ID != value))
				{
					if (this._Professor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProfessor_IDChanging(value);
					this.SendPropertyChanging();
					this._Professor_ID = value;
					this.SendPropertyChanged("Professor_ID");
					this.OnProfessor_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credits", DbType="Int NOT NULL")]
		public int Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Class_Attend", Storage="_Attends", ThisKey="ID", OtherKey="Classes_ID")]
		public EntitySet<Attend> Attends
		{
			get
			{
				return this._Attends;
			}
			set
			{
				this._Attends.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professor_Class", Storage="_Professor", ThisKey="Professor_ID", OtherKey="ID", IsForeignKey=true)]
		public Professor Professor
		{
			get
			{
				return this._Professor.Entity;
			}
			set
			{
				Professor previousValue = this._Professor.Entity;
				if (((previousValue != value) 
							|| (this._Professor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Professor.Entity = null;
						previousValue.Classes.Remove(this);
					}
					this._Professor.Entity = value;
					if ((value != null))
					{
						value.Classes.Add(this);
						this._Professor_ID = value.ID;
					}
					else
					{
						this._Professor_ID = default(int);
					}
					this.SendPropertyChanged("Professor");
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
		
		private void attach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Class = this;
		}
		
		private void detach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Class = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClassRooms")]
	public partial class ClassRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public ClassRoom()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Groups")]
	public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Description;
		
		private string _Faculty;
		
		private int _Year;
		
		private int _GuideProfessor_ID;
		
		private EntitySet<Attend> _Attends;
		
		private EntitySet<Student> _Students;
		
		private EntityRef<Professor> _Professor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnFacultyChanging(string value);
    partial void OnFacultyChanged();
    partial void OnYearChanging(int value);
    partial void OnYearChanged();
    partial void OnGuideProfessor_IDChanging(int value);
    partial void OnGuideProfessor_IDChanged();
    #endregion
		
		public Group()
		{
			this._Attends = new EntitySet<Attend>(new Action<Attend>(this.attach_Attends), new Action<Attend>(this.detach_Attends));
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			this._Professor = default(EntityRef<Professor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Faculty", DbType="NVarChar(50)")]
		public string Faculty
		{
			get
			{
				return this._Faculty;
			}
			set
			{
				if ((this._Faculty != value))
				{
					this.OnFacultyChanging(value);
					this.SendPropertyChanging();
					this._Faculty = value;
					this.SendPropertyChanged("Faculty");
					this.OnFacultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int NOT NULL")]
		public int Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuideProfessor_ID", DbType="Int NOT NULL")]
		public int GuideProfessor_ID
		{
			get
			{
				return this._GuideProfessor_ID;
			}
			set
			{
				if ((this._GuideProfessor_ID != value))
				{
					if (this._Professor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGuideProfessor_IDChanging(value);
					this.SendPropertyChanging();
					this._GuideProfessor_ID = value;
					this.SendPropertyChanged("GuideProfessor_ID");
					this.OnGuideProfessor_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Attend", Storage="_Attends", ThisKey="ID", OtherKey="Group_ID")]
		public EntitySet<Attend> Attends
		{
			get
			{
				return this._Attends;
			}
			set
			{
				this._Attends.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Student", Storage="_Students", ThisKey="ID", OtherKey="Group_ID")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professor_Group", Storage="_Professor", ThisKey="GuideProfessor_ID", OtherKey="ID", IsForeignKey=true)]
		public Professor Professor
		{
			get
			{
				return this._Professor.Entity;
			}
			set
			{
				Professor previousValue = this._Professor.Entity;
				if (((previousValue != value) 
							|| (this._Professor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Professor.Entity = null;
						previousValue.Groups.Remove(this);
					}
					this._Professor.Entity = value;
					if ((value != null))
					{
						value.Groups.Add(this);
						this._GuideProfessor_ID = value.ID;
					}
					else
					{
						this._GuideProfessor_ID = default(int);
					}
					this.SendPropertyChanged("Professor");
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
		
		private void attach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Professors")]
	public partial class Professor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Title;
		
		private string _Details;
		
		private string _Phone;
		
		private string _Mail;
		
		private System.Nullable<int> _Salary;
		
		private EntitySet<Class> _Classes;
		
		private EntitySet<Group> _Groups;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDetailsChanging(string value);
    partial void OnDetailsChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnSalaryChanging(System.Nullable<int> value);
    partial void OnSalaryChanged();
    #endregion
		
		public Professor()
		{
			this._Classes = new EntitySet<Class>(new Action<Class>(this.attach_Classes), new Action<Class>(this.detach_Classes));
			this._Groups = new EntitySet<Group>(new Action<Group>(this.attach_Groups), new Action<Group>(this.detach_Groups));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Details", DbType="NVarChar(50)")]
		public string Details
		{
			get
			{
				return this._Details;
			}
			set
			{
				if ((this._Details != value))
				{
					this.OnDetailsChanging(value);
					this.SendPropertyChanging();
					this._Details = value;
					this.SendPropertyChanged("Details");
					this.OnDetailsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="NVarChar(50)")]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int")]
		public System.Nullable<int> Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professor_Class", Storage="_Classes", ThisKey="ID", OtherKey="Professor_ID")]
		public EntitySet<Class> Classes
		{
			get
			{
				return this._Classes;
			}
			set
			{
				this._Classes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Professor_Group", Storage="_Groups", ThisKey="ID", OtherKey="GuideProfessor_ID")]
		public EntitySet<Group> Groups
		{
			get
			{
				return this._Groups;
			}
			set
			{
				this._Groups.Assign(value);
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
		
		private void attach_Classes(Class entity)
		{
			this.SendPropertyChanging();
			entity.Professor = this;
		}
		
		private void detach_Classes(Class entity)
		{
			this.SendPropertyChanging();
			entity.Professor = null;
		}
		
		private void attach_Groups(Group entity)
		{
			this.SendPropertyChanging();
			entity.Professor = this;
		}
		
		private void detach_Groups(Group entity)
		{
			this.SendPropertyChanging();
			entity.Professor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Group_ID;
		
		private string _Mail;
		
		private string _Phone;
		
		private EntityRef<Group> _Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGroup_IDChanging(int value);
    partial void OnGroup_IDChanged();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Student()
		{
			this._Group = default(EntityRef<Group>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_ID", DbType="Int NOT NULL")]
		public int Group_ID
		{
			get
			{
				return this._Group_ID;
			}
			set
			{
				if ((this._Group_ID != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroup_IDChanging(value);
					this.SendPropertyChanging();
					this._Group_ID = value;
					this.SendPropertyChanged("Group_ID");
					this.OnGroup_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="NVarChar(50)")]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Student", Storage="_Group", ThisKey="Group_ID", OtherKey="ID", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._Group_ID = value.ID;
					}
					else
					{
						this._Group_ID = default(int);
					}
					this.SendPropertyChanged("Group");
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
		
		private int _ID;
		
		private string _Username;
		
		private string _PasswordHash;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
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
