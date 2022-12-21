///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:40
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using dhmi.HelperClasses;
using dhmi.DaoClasses;
using dhmi.EntityClasses;
using dhmi.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace dhmi.TypedListClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Typed datatable for the list 'ListLog'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListLogTypedList : TypedListBase<ListLogRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnFkLogIslemId;
		private DataColumn _columnLogAciklama;
		private DataColumn _columnLogId;
		private DataColumn _columnLogIpsi;
		private DataColumn _columnLogTarih;
		private DataColumn _columnLogIslemAd;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 9;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListLogTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListLogTypedList():base("ListLog")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListLogTypedList(bool obeyWeakRelations):base("ListLog")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListLogTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListLogTypedList cloneToReturn = ((ListLogTypedList)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new TypedList dao instance</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateTypedListDAO();
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new ListLogRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(LogEntity.Relations.KullaniciEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
			toReturn.Add(LogIslemEntity.Relations.LogEntityUsingFkLogIslemId, "", "", JoinHint.Inner);
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalRelations
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnRelationSetBuilt(toReturn);
			return toReturn;
		}

		/// <summary>Builds the resultset fields.</summary>
		/// <returns>ready to use resultset</returns>
		protected override IEntityFields BuildResultset()
		{
			ResultsetFields toReturn = new ResultsetFields(AmountOfFields);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 0, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 1, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.FkKullaniciId, 2, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.FkLogIslemId, 3, "FkLogIslemId", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.LogAciklama, 4, "LogAciklama", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.LogId, 5, "LogId", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.LogIpsi, 6, "LogIpsi", "", AggregateFunction.None);
			toReturn.DefineField(LogFields.LogTarih, 7, "LogTarih", "", AggregateFunction.None);
			toReturn.DefineField(LogIslemFields.LogIslemAd, 8, "LogIslemAd", "", AggregateFunction.None);
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call toReturn.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnResultsetBuilt(toReturn);
			return toReturn;
		}

		/// <summary>Initializes the hashtables for the typed list type and typed list field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable = null;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkLogIslemId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LogAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LogId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LogIpsi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LogTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("LogIslemAd", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnFkLogIslemId = GeneralUtils.CreateTypedDataTableColumn("FkLogIslemId", @"FkLogIslemId", typeof(System.Int16), this.Columns);
			_columnLogAciklama = GeneralUtils.CreateTypedDataTableColumn("LogAciklama", @"LogAciklama", typeof(System.String), this.Columns);
			_columnLogId = GeneralUtils.CreateTypedDataTableColumn("LogId", @"LogId", typeof(System.Int64), this.Columns);
			_columnLogIpsi = GeneralUtils.CreateTypedDataTableColumn("LogIpsi", @"LogIpsi", typeof(System.String), this.Columns);
			_columnLogTarih = GeneralUtils.CreateTypedDataTableColumn("LogTarih", @"LogTarih", typeof(System.DateTime), this.Columns);
			_columnLogIslemAd = GeneralUtils.CreateTypedDataTableColumn("LogIslemAd", @"LogIslemAd", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnFkLogIslemId = this.Columns["FkLogIslemId"];
			_columnLogAciklama = this.Columns["LogAciklama"];
			_columnLogId = this.Columns["LogId"];
			_columnLogIpsi = this.Columns["LogIpsi"];
			_columnLogTarih = this.Columns["LogTarih"];
			_columnLogIslemAd = this.Columns["LogIslemAd"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListLogTypedList();
		}
#endif
		#region Class Property Declarations
		/// <summary>The custom properties for this TypedList type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedList instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return ListLogTypedList.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedList type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedList instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return ListLogTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAdSoyad</summary>
		internal DataColumn KullaniciAdSoyadColumn 
		{
			get { return _columnKullaniciAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciId</summary>
		internal DataColumn KullaniciIdColumn 
		{
			get { return _columnKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkLogIslemId</summary>
		internal DataColumn FkLogIslemIdColumn 
		{
			get { return _columnFkLogIslemId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field LogAciklama</summary>
		internal DataColumn LogAciklamaColumn 
		{
			get { return _columnLogAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field LogId</summary>
		internal DataColumn LogIdColumn 
		{
			get { return _columnLogId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field LogIpsi</summary>
		internal DataColumn LogIpsiColumn 
		{
			get { return _columnLogIpsi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field LogTarih</summary>
		internal DataColumn LogTarihColumn 
		{
			get { return _columnLogTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field LogIslemAd</summary>
		internal DataColumn LogIslemAdColumn 
		{
			get { return _columnLogIslemAd; }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
 		#endregion
		
		#region Custom TypedList code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}

	/// <summary>Typed datarow for the typed datatable ListLog</summary>
	public partial class ListLogRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListLogTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListLogRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListLogTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field KullaniciAdSoyad<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciAdSoyad</remarks>
		public System.String KullaniciAdSoyad 
		{
			get { return IsKullaniciAdSoyadNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciAdSoyadColumn]; }
			set { this[_parent.KullaniciAdSoyadColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciAdSoyad is NULL, false otherwise.</summary>
		public bool IsKullaniciAdSoyadNull() 
		{
			return IsNull(_parent.KullaniciAdSoyadColumn);
		}

		/// <summary>Sets the TypedList field KullaniciAdSoyad to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciAdSoyadNull() 
		{
			this[_parent.KullaniciAdSoyadColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciId</remarks>
		public System.Int16 KullaniciId 
		{
			get { return IsKullaniciIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.KullaniciIdColumn]; }
			set { this[_parent.KullaniciIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciId is NULL, false otherwise.</summary>
		public bool IsKullaniciIdNull() 
		{
			return IsNull(_parent.KullaniciIdColumn);
		}

		/// <summary>Sets the TypedList field KullaniciId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciIdNull() 
		{
			this[_parent.KullaniciIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.FkKullaniciId</remarks>
		public System.Int16 FkKullaniciId 
		{
			get { return IsFkKullaniciIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkKullaniciIdColumn]; }
			set { this[_parent.FkKullaniciIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKullaniciId is NULL, false otherwise.</summary>
		public bool IsFkKullaniciIdNull() 
		{
			return IsNull(_parent.FkKullaniciIdColumn);
		}

		/// <summary>Sets the TypedList field FkKullaniciId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKullaniciIdNull() 
		{
			this[_parent.FkKullaniciIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkLogIslemId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.FkLogIslemId</remarks>
		public System.Int16 FkLogIslemId 
		{
			get { return IsFkLogIslemIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkLogIslemIdColumn]; }
			set { this[_parent.FkLogIslemIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkLogIslemId is NULL, false otherwise.</summary>
		public bool IsFkLogIslemIdNull() 
		{
			return IsNull(_parent.FkLogIslemIdColumn);
		}

		/// <summary>Sets the TypedList field FkLogIslemId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkLogIslemIdNull() 
		{
			this[_parent.FkLogIslemIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field LogAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.LogAciklama</remarks>
		public System.String LogAciklama 
		{
			get { return IsLogAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LogAciklamaColumn]; }
			set { this[_parent.LogAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field LogAciklama is NULL, false otherwise.</summary>
		public bool IsLogAciklamaNull() 
		{
			return IsNull(_parent.LogAciklamaColumn);
		}

		/// <summary>Sets the TypedList field LogAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLogAciklamaNull() 
		{
			this[_parent.LogAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field LogId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.LogId</remarks>
		public System.Int64 LogId 
		{
			get { return IsLogIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.LogIdColumn]; }
			set { this[_parent.LogIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field LogId is NULL, false otherwise.</summary>
		public bool IsLogIdNull() 
		{
			return IsNull(_parent.LogIdColumn);
		}

		/// <summary>Sets the TypedList field LogId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLogIdNull() 
		{
			this[_parent.LogIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field LogIpsi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.LogIpsi</remarks>
		public System.String LogIpsi 
		{
			get { return IsLogIpsiNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LogIpsiColumn]; }
			set { this[_parent.LogIpsiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field LogIpsi is NULL, false otherwise.</summary>
		public bool IsLogIpsiNull() 
		{
			return IsNull(_parent.LogIpsiColumn);
		}

		/// <summary>Sets the TypedList field LogIpsi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLogIpsiNull() 
		{
			this[_parent.LogIpsiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field LogTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Log.LogTarih</remarks>
		public System.DateTime LogTarih 
		{
			get { return IsLogTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.LogTarihColumn]; }
			set { this[_parent.LogTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field LogTarih is NULL, false otherwise.</summary>
		public bool IsLogTarihNull() 
		{
			return IsNull(_parent.LogTarihColumn);
		}

		/// <summary>Sets the TypedList field LogTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLogTarihNull() 
		{
			this[_parent.LogTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field LogIslemAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: LogIslem.LogIslemAd</remarks>
		public System.String LogIslemAd 
		{
			get { return IsLogIslemAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.LogIslemAdColumn]; }
			set { this[_parent.LogIslemAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field LogIslemAd is NULL, false otherwise.</summary>
		public bool IsLogIslemAdNull() 
		{
			return IsNull(_parent.LogIslemAdColumn);
		}

		/// <summary>Sets the TypedList field LogIslemAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetLogIslemAdNull() 
		{
			this[_parent.LogIslemAdColumn] = System.Convert.DBNull;
		}
		#endregion

		#region Custom Typed List Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
