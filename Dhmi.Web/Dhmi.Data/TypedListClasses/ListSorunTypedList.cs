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
	/// <summary>Typed datatable for the list 'ListSorun'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListSorunTypedList : TypedListBase<ListSorunRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnFkSorunTuruId;
		private DataColumn _columnSorunAciklama;
		private DataColumn _columnSorunCevaplandiMi;
		private DataColumn _columnSorunCevapTarih;
		private DataColumn _columnSorunCozum;
		private DataColumn _columnSorunId;
		private DataColumn _columnSorunIrtibat;
		private DataColumn _columnSorunOneri;
		private DataColumn _columnSorunTarih;
		private DataColumn _columnSorunTuruAd;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 13;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListSorunTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListSorunTypedList():base("ListSorun")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListSorunTypedList(bool obeyWeakRelations):base("ListSorun")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListSorunTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListSorunTypedList cloneToReturn = ((ListSorunTypedList)(base.Clone()));
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
			return new ListSorunRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(SorunEntity.Relations.KullaniciEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
			toReturn.Add(SorunTuruEntity.Relations.SorunEntityUsingFkSorunTuruId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(SorunFields.FkKullaniciId, 2, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.FkSorunTuruId, 3, "FkSorunTuruId", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunAciklama, 4, "SorunAciklama", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunCevaplandiMi, 5, "SorunCevaplandiMi", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunCevapTarih, 6, "SorunCevapTarih", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunCozum, 7, "SorunCozum", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunId, 8, "SorunId", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunIrtibat, 9, "SorunIrtibat", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunOneri, 10, "SorunOneri", "", AggregateFunction.None);
			toReturn.DefineField(SorunFields.SorunTarih, 11, "SorunTarih", "", AggregateFunction.None);
			toReturn.DefineField(SorunTuruFields.SorunTuruAd, 12, "SorunTuruAd", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("FkSorunTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunCevaplandiMi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunCevapTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunCozum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunIrtibat", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunOneri", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SorunTuruAd", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnFkSorunTuruId = GeneralUtils.CreateTypedDataTableColumn("FkSorunTuruId", @"FkSorunTuruId", typeof(System.Int16), this.Columns);
			_columnSorunAciklama = GeneralUtils.CreateTypedDataTableColumn("SorunAciklama", @"SorunAciklama", typeof(System.String), this.Columns);
			_columnSorunCevaplandiMi = GeneralUtils.CreateTypedDataTableColumn("SorunCevaplandiMi", @"SorunCevaplandiMi", typeof(System.String), this.Columns);
			_columnSorunCevapTarih = GeneralUtils.CreateTypedDataTableColumn("SorunCevapTarih", @"SorunCevapTarih", typeof(System.DateTime), this.Columns);
			_columnSorunCozum = GeneralUtils.CreateTypedDataTableColumn("SorunCozum", @"SorunCozum", typeof(System.String), this.Columns);
			_columnSorunId = GeneralUtils.CreateTypedDataTableColumn("SorunId", @"SorunId", typeof(System.Int16), this.Columns);
			_columnSorunIrtibat = GeneralUtils.CreateTypedDataTableColumn("SorunIrtibat", @"SorunIrtibat", typeof(System.String), this.Columns);
			_columnSorunOneri = GeneralUtils.CreateTypedDataTableColumn("SorunOneri", @"SorunOneri", typeof(System.String), this.Columns);
			_columnSorunTarih = GeneralUtils.CreateTypedDataTableColumn("SorunTarih", @"SorunTarih", typeof(System.DateTime), this.Columns);
			_columnSorunTuruAd = GeneralUtils.CreateTypedDataTableColumn("SorunTuruAd", @"SorunTuruAd", typeof(System.String), this.Columns);

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
			_columnFkSorunTuruId = this.Columns["FkSorunTuruId"];
			_columnSorunAciklama = this.Columns["SorunAciklama"];
			_columnSorunCevaplandiMi = this.Columns["SorunCevaplandiMi"];
			_columnSorunCevapTarih = this.Columns["SorunCevapTarih"];
			_columnSorunCozum = this.Columns["SorunCozum"];
			_columnSorunId = this.Columns["SorunId"];
			_columnSorunIrtibat = this.Columns["SorunIrtibat"];
			_columnSorunOneri = this.Columns["SorunOneri"];
			_columnSorunTarih = this.Columns["SorunTarih"];
			_columnSorunTuruAd = this.Columns["SorunTuruAd"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListSorunTypedList();
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
			get { return ListSorunTypedList.CustomProperties;}
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
			get { return ListSorunTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field FkSorunTuruId</summary>
		internal DataColumn FkSorunTuruIdColumn 
		{
			get { return _columnFkSorunTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunAciklama</summary>
		internal DataColumn SorunAciklamaColumn 
		{
			get { return _columnSorunAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunCevaplandiMi</summary>
		internal DataColumn SorunCevaplandiMiColumn 
		{
			get { return _columnSorunCevaplandiMi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunCevapTarih</summary>
		internal DataColumn SorunCevapTarihColumn 
		{
			get { return _columnSorunCevapTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunCozum</summary>
		internal DataColumn SorunCozumColumn 
		{
			get { return _columnSorunCozum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunId</summary>
		internal DataColumn SorunIdColumn 
		{
			get { return _columnSorunId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunIrtibat</summary>
		internal DataColumn SorunIrtibatColumn 
		{
			get { return _columnSorunIrtibat; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunOneri</summary>
		internal DataColumn SorunOneriColumn 
		{
			get { return _columnSorunOneri; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunTarih</summary>
		internal DataColumn SorunTarihColumn 
		{
			get { return _columnSorunTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field SorunTuruAd</summary>
		internal DataColumn SorunTuruAdColumn 
		{
			get { return _columnSorunTuruAd; }
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

	/// <summary>Typed datarow for the typed datatable ListSorun</summary>
	public partial class ListSorunRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListSorunTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListSorunRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListSorunTypedList)(this.Table));
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
		/// <remarks>Mapped on: Sorun.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field FkSorunTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.FkSorunTuruId</remarks>
		public System.Int16 FkSorunTuruId 
		{
			get { return IsFkSorunTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkSorunTuruIdColumn]; }
			set { this[_parent.FkSorunTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkSorunTuruId is NULL, false otherwise.</summary>
		public bool IsFkSorunTuruIdNull() 
		{
			return IsNull(_parent.FkSorunTuruIdColumn);
		}

		/// <summary>Sets the TypedList field FkSorunTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkSorunTuruIdNull() 
		{
			this[_parent.FkSorunTuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunAciklama</remarks>
		public System.String SorunAciklama 
		{
			get { return IsSorunAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunAciklamaColumn]; }
			set { this[_parent.SorunAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunAciklama is NULL, false otherwise.</summary>
		public bool IsSorunAciklamaNull() 
		{
			return IsNull(_parent.SorunAciklamaColumn);
		}

		/// <summary>Sets the TypedList field SorunAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunAciklamaNull() 
		{
			this[_parent.SorunAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunCevaplandiMi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunCevaplandiMi</remarks>
		public System.String SorunCevaplandiMi 
		{
			get { return IsSorunCevaplandiMiNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunCevaplandiMiColumn]; }
			set { this[_parent.SorunCevaplandiMiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunCevaplandiMi is NULL, false otherwise.</summary>
		public bool IsSorunCevaplandiMiNull() 
		{
			return IsNull(_parent.SorunCevaplandiMiColumn);
		}

		/// <summary>Sets the TypedList field SorunCevaplandiMi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunCevaplandiMiNull() 
		{
			this[_parent.SorunCevaplandiMiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunCevapTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunCevapTarih</remarks>
		public System.DateTime SorunCevapTarih 
		{
			get { return IsSorunCevapTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.SorunCevapTarihColumn]; }
			set { this[_parent.SorunCevapTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunCevapTarih is NULL, false otherwise.</summary>
		public bool IsSorunCevapTarihNull() 
		{
			return IsNull(_parent.SorunCevapTarihColumn);
		}

		/// <summary>Sets the TypedList field SorunCevapTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunCevapTarihNull() 
		{
			this[_parent.SorunCevapTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunCozum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunCozum</remarks>
		public System.String SorunCozum 
		{
			get { return IsSorunCozumNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunCozumColumn]; }
			set { this[_parent.SorunCozumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunCozum is NULL, false otherwise.</summary>
		public bool IsSorunCozumNull() 
		{
			return IsNull(_parent.SorunCozumColumn);
		}

		/// <summary>Sets the TypedList field SorunCozum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunCozumNull() 
		{
			this[_parent.SorunCozumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunId</remarks>
		public System.Int16 SorunId 
		{
			get { return IsSorunIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.SorunIdColumn]; }
			set { this[_parent.SorunIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunId is NULL, false otherwise.</summary>
		public bool IsSorunIdNull() 
		{
			return IsNull(_parent.SorunIdColumn);
		}

		/// <summary>Sets the TypedList field SorunId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunIdNull() 
		{
			this[_parent.SorunIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunIrtibat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunIrtibat</remarks>
		public System.String SorunIrtibat 
		{
			get { return IsSorunIrtibatNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunIrtibatColumn]; }
			set { this[_parent.SorunIrtibatColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunIrtibat is NULL, false otherwise.</summary>
		public bool IsSorunIrtibatNull() 
		{
			return IsNull(_parent.SorunIrtibatColumn);
		}

		/// <summary>Sets the TypedList field SorunIrtibat to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunIrtibatNull() 
		{
			this[_parent.SorunIrtibatColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunOneri<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunOneri</remarks>
		public System.String SorunOneri 
		{
			get { return IsSorunOneriNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunOneriColumn]; }
			set { this[_parent.SorunOneriColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunOneri is NULL, false otherwise.</summary>
		public bool IsSorunOneriNull() 
		{
			return IsNull(_parent.SorunOneriColumn);
		}

		/// <summary>Sets the TypedList field SorunOneri to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunOneriNull() 
		{
			this[_parent.SorunOneriColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Sorun.SorunTarih</remarks>
		public System.DateTime SorunTarih 
		{
			get { return IsSorunTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.SorunTarihColumn]; }
			set { this[_parent.SorunTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunTarih is NULL, false otherwise.</summary>
		public bool IsSorunTarihNull() 
		{
			return IsNull(_parent.SorunTarihColumn);
		}

		/// <summary>Sets the TypedList field SorunTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunTarihNull() 
		{
			this[_parent.SorunTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field SorunTuruAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: SorunTuru.SorunTuruAd</remarks>
		public System.String SorunTuruAd 
		{
			get { return IsSorunTuruAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SorunTuruAdColumn]; }
			set { this[_parent.SorunTuruAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field SorunTuruAd is NULL, false otherwise.</summary>
		public bool IsSorunTuruAdNull() 
		{
			return IsNull(_parent.SorunTuruAdColumn);
		}

		/// <summary>Sets the TypedList field SorunTuruAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSorunTuruAdNull() 
		{
			this[_parent.SorunTuruAdColumn] = System.Convert.DBNull;
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
