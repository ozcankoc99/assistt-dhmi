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
	/// <summary>Typed datatable for the list 'ListParArsiv'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListParArsivTypedList : TypedListBase<ListParArsivRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnFkParametreId;
		private DataColumn _columnParametreGenelArsivAd;
		private DataColumn _columnParametreGenelArsivBasTarih;
		private DataColumn _columnParametreGenelArsivBitTarih;
		private DataColumn _columnParametreGenelArsivId;
		private DataColumn _columnParametreGenelArsivKullanici;
		private DataColumn _columnParametreGenelArsivNew;
		private DataColumn _columnParametreGenelArsivOld;
		private DataColumn _columnParametreGenelArsivTarih;
		private DataColumn _columnParametreGenelArsivTur;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 13;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListParArsivTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListParArsivTypedList():base("ListParArsiv")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListParArsivTypedList(bool obeyWeakRelations):base("ListParArsiv")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListParArsivTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListParArsivTypedList cloneToReturn = ((ListParArsivTypedList)(base.Clone()));
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
			return new ListParArsivRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(ParametreGenelArsivEntity.Relations.KullaniciEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(ParametreGenelArsivFields.FkKullaniciId, 2, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.FkParametreId, 3, "FkParametreId", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivAd, 4, "ParametreGenelArsivAd", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivBasTarih, 5, "ParametreGenelArsivBasTarih", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivBitTarih, 6, "ParametreGenelArsivBitTarih", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivId, 7, "ParametreGenelArsivId", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivKullanici, 8, "ParametreGenelArsivKullanici", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivNew, 9, "ParametreGenelArsivNew", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivOld, 10, "ParametreGenelArsivOld", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivTarih, 11, "ParametreGenelArsivTarih", "", AggregateFunction.None);
			toReturn.DefineField(ParametreGenelArsivFields.ParametreGenelArsivTur, 12, "ParametreGenelArsivTur", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("FkParametreId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivBasTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivBitTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivKullanici", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivNew", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivOld", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ParametreGenelArsivTur", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnFkParametreId = GeneralUtils.CreateTypedDataTableColumn("FkParametreId", @"FkParametreId", typeof(System.Int16), this.Columns);
			_columnParametreGenelArsivAd = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivAd", @"ParametreGenelArsivAd", typeof(System.String), this.Columns);
			_columnParametreGenelArsivBasTarih = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivBasTarih", @"ParametreGenelArsivBasTarih", typeof(System.DateTime), this.Columns);
			_columnParametreGenelArsivBitTarih = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivBitTarih", @"ParametreGenelArsivBitTarih", typeof(System.DateTime), this.Columns);
			_columnParametreGenelArsivId = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivId", @"ParametreGenelArsivId", typeof(System.Int16), this.Columns);
			_columnParametreGenelArsivKullanici = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivKullanici", @"ParametreGenelArsivKullanici", typeof(System.String), this.Columns);
			_columnParametreGenelArsivNew = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivNew", @"ParametreGenelArsivNew", typeof(System.String), this.Columns);
			_columnParametreGenelArsivOld = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivOld", @"ParametreGenelArsivOld", typeof(System.String), this.Columns);
			_columnParametreGenelArsivTarih = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivTarih", @"ParametreGenelArsivTarih", typeof(System.DateTime), this.Columns);
			_columnParametreGenelArsivTur = GeneralUtils.CreateTypedDataTableColumn("ParametreGenelArsivTur", @"ParametreGenelArsivTur", typeof(System.String), this.Columns);

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
			_columnFkParametreId = this.Columns["FkParametreId"];
			_columnParametreGenelArsivAd = this.Columns["ParametreGenelArsivAd"];
			_columnParametreGenelArsivBasTarih = this.Columns["ParametreGenelArsivBasTarih"];
			_columnParametreGenelArsivBitTarih = this.Columns["ParametreGenelArsivBitTarih"];
			_columnParametreGenelArsivId = this.Columns["ParametreGenelArsivId"];
			_columnParametreGenelArsivKullanici = this.Columns["ParametreGenelArsivKullanici"];
			_columnParametreGenelArsivNew = this.Columns["ParametreGenelArsivNew"];
			_columnParametreGenelArsivOld = this.Columns["ParametreGenelArsivOld"];
			_columnParametreGenelArsivTarih = this.Columns["ParametreGenelArsivTarih"];
			_columnParametreGenelArsivTur = this.Columns["ParametreGenelArsivTur"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListParArsivTypedList();
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
			get { return ListParArsivTypedList.CustomProperties;}
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
			get { return ListParArsivTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field FkParametreId</summary>
		internal DataColumn FkParametreIdColumn 
		{
			get { return _columnFkParametreId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivAd</summary>
		internal DataColumn ParametreGenelArsivAdColumn 
		{
			get { return _columnParametreGenelArsivAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivBasTarih</summary>
		internal DataColumn ParametreGenelArsivBasTarihColumn 
		{
			get { return _columnParametreGenelArsivBasTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivBitTarih</summary>
		internal DataColumn ParametreGenelArsivBitTarihColumn 
		{
			get { return _columnParametreGenelArsivBitTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivId</summary>
		internal DataColumn ParametreGenelArsivIdColumn 
		{
			get { return _columnParametreGenelArsivId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivKullanici</summary>
		internal DataColumn ParametreGenelArsivKullaniciColumn 
		{
			get { return _columnParametreGenelArsivKullanici; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivNew</summary>
		internal DataColumn ParametreGenelArsivNewColumn 
		{
			get { return _columnParametreGenelArsivNew; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivOld</summary>
		internal DataColumn ParametreGenelArsivOldColumn 
		{
			get { return _columnParametreGenelArsivOld; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivTarih</summary>
		internal DataColumn ParametreGenelArsivTarihColumn 
		{
			get { return _columnParametreGenelArsivTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field ParametreGenelArsivTur</summary>
		internal DataColumn ParametreGenelArsivTurColumn 
		{
			get { return _columnParametreGenelArsivTur; }
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

	/// <summary>Typed datarow for the typed datatable ListParArsiv</summary>
	public partial class ListParArsivRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListParArsivTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListParArsivRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListParArsivTypedList)(this.Table));
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
		/// <remarks>Mapped on: ParametreGenelArsiv.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field FkParametreId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.FkParametreId</remarks>
		public System.Int16 FkParametreId 
		{
			get { return IsFkParametreIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkParametreIdColumn]; }
			set { this[_parent.FkParametreIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkParametreId is NULL, false otherwise.</summary>
		public bool IsFkParametreIdNull() 
		{
			return IsNull(_parent.FkParametreIdColumn);
		}

		/// <summary>Sets the TypedList field FkParametreId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkParametreIdNull() 
		{
			this[_parent.FkParametreIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivAd</remarks>
		public System.String ParametreGenelArsivAd 
		{
			get { return IsParametreGenelArsivAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ParametreGenelArsivAdColumn]; }
			set { this[_parent.ParametreGenelArsivAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivAd is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivAdNull() 
		{
			return IsNull(_parent.ParametreGenelArsivAdColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivAdNull() 
		{
			this[_parent.ParametreGenelArsivAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivBasTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivBasTarih</remarks>
		public System.DateTime ParametreGenelArsivBasTarih 
		{
			get { return IsParametreGenelArsivBasTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.ParametreGenelArsivBasTarihColumn]; }
			set { this[_parent.ParametreGenelArsivBasTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivBasTarih is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivBasTarihNull() 
		{
			return IsNull(_parent.ParametreGenelArsivBasTarihColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivBasTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivBasTarihNull() 
		{
			this[_parent.ParametreGenelArsivBasTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivBitTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivBitTarih</remarks>
		public System.DateTime ParametreGenelArsivBitTarih 
		{
			get { return IsParametreGenelArsivBitTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.ParametreGenelArsivBitTarihColumn]; }
			set { this[_parent.ParametreGenelArsivBitTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivBitTarih is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivBitTarihNull() 
		{
			return IsNull(_parent.ParametreGenelArsivBitTarihColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivBitTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivBitTarihNull() 
		{
			this[_parent.ParametreGenelArsivBitTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivId</remarks>
		public System.Int16 ParametreGenelArsivId 
		{
			get { return IsParametreGenelArsivIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.ParametreGenelArsivIdColumn]; }
			set { this[_parent.ParametreGenelArsivIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivId is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivIdNull() 
		{
			return IsNull(_parent.ParametreGenelArsivIdColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivIdNull() 
		{
			this[_parent.ParametreGenelArsivIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivKullanici<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivKullanici</remarks>
		public System.String ParametreGenelArsivKullanici 
		{
			get { return IsParametreGenelArsivKullaniciNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ParametreGenelArsivKullaniciColumn]; }
			set { this[_parent.ParametreGenelArsivKullaniciColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivKullanici is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivKullaniciNull() 
		{
			return IsNull(_parent.ParametreGenelArsivKullaniciColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivKullanici to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivKullaniciNull() 
		{
			this[_parent.ParametreGenelArsivKullaniciColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivNew<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivNew</remarks>
		public System.String ParametreGenelArsivNew 
		{
			get { return IsParametreGenelArsivNewNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ParametreGenelArsivNewColumn]; }
			set { this[_parent.ParametreGenelArsivNewColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivNew is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivNewNull() 
		{
			return IsNull(_parent.ParametreGenelArsivNewColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivNew to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivNewNull() 
		{
			this[_parent.ParametreGenelArsivNewColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivOld<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivOld</remarks>
		public System.String ParametreGenelArsivOld 
		{
			get { return IsParametreGenelArsivOldNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ParametreGenelArsivOldColumn]; }
			set { this[_parent.ParametreGenelArsivOldColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivOld is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivOldNull() 
		{
			return IsNull(_parent.ParametreGenelArsivOldColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivOld to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivOldNull() 
		{
			this[_parent.ParametreGenelArsivOldColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivTarih</remarks>
		public System.DateTime ParametreGenelArsivTarih 
		{
			get { return IsParametreGenelArsivTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.ParametreGenelArsivTarihColumn]; }
			set { this[_parent.ParametreGenelArsivTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivTarih is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivTarihNull() 
		{
			return IsNull(_parent.ParametreGenelArsivTarihColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivTarihNull() 
		{
			this[_parent.ParametreGenelArsivTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field ParametreGenelArsivTur<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: ParametreGenelArsiv.ParametreGenelArsivTur</remarks>
		public System.String ParametreGenelArsivTur 
		{
			get { return IsParametreGenelArsivTurNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ParametreGenelArsivTurColumn]; }
			set { this[_parent.ParametreGenelArsivTurColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field ParametreGenelArsivTur is NULL, false otherwise.</summary>
		public bool IsParametreGenelArsivTurNull() 
		{
			return IsNull(_parent.ParametreGenelArsivTurColumn);
		}

		/// <summary>Sets the TypedList field ParametreGenelArsivTur to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetParametreGenelArsivTurNull() 
		{
			this[_parent.ParametreGenelArsivTurColumn] = System.Convert.DBNull;
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
