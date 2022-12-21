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
	/// <summary>Typed datatable for the list 'ListKara'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListKaraTypedList : TypedListBase<ListKaraRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnVatandasAdSoyad;
		private DataColumn _columnVatandasTel1;
		private DataColumn _columnFkVatandasId;
		private DataColumn _columnKaraListeAciklama;
		private DataColumn _columnKaraListeBslTarihSaat;
		private DataColumn _columnKaraListeBtsTarihSaat;
		private DataColumn _columnKaraListeDurum;
		private DataColumn _columnKaraListeId;
		private DataColumn _columnKaraListeIptalEdenKullanici;
		private DataColumn _columnKaraListeIptalTarihi;
		private DataColumn _columnKaraListeIslemTarih;
		private DataColumn _columnKaraListeIslemYapan;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 14;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListKaraTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListKaraTypedList():base("ListKara")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListKaraTypedList(bool obeyWeakRelations):base("ListKara")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListKaraTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListKaraTypedList cloneToReturn = ((ListKaraTypedList)(base.Clone()));
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
			return new ListKaraRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(VatandaEntity.Relations.KaraListeEntityUsingFkVatandasId, "", "", JoinHint.Inner);
			toReturn.Add(KullaniciEntity.Relations.VatandaEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(VatandaFields.VatandasAdSoyad, 2, "VatandasAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasTel1, 3, "VatandasTel1", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.FkVatandasId, 4, "FkVatandasId", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeAciklama, 5, "KaraListeAciklama", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeBslTarihSaat, 6, "KaraListeBslTarihSaat", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeBtsTarihSaat, 7, "KaraListeBtsTarihSaat", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeDurum, 8, "KaraListeDurum", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeId, 9, "KaraListeId", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeIptalEdenKullanici, 10, "KaraListeIptalEdenKullanici", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeIptalTarihi, 11, "KaraListeIptalTarihi", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeIslemTarih, 12, "KaraListeIslemTarih", "", AggregateFunction.None);
			toReturn.DefineField(KaraListeFields.KaraListeIslemYapan, 13, "KaraListeIslemYapan", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("VatandasAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasTel1", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkVatandasId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeBslTarihSaat", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeBtsTarihSaat", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeIptalEdenKullanici", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeIptalTarihi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeIslemTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KaraListeIslemYapan", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnVatandasAdSoyad = GeneralUtils.CreateTypedDataTableColumn("VatandasAdSoyad", @"VatandasAdSoyad", typeof(System.String), this.Columns);
			_columnVatandasTel1 = GeneralUtils.CreateTypedDataTableColumn("VatandasTel1", @"VatandasTel1", typeof(System.String), this.Columns);
			_columnFkVatandasId = GeneralUtils.CreateTypedDataTableColumn("FkVatandasId", @"FkVatandasId", typeof(System.Int64), this.Columns);
			_columnKaraListeAciklama = GeneralUtils.CreateTypedDataTableColumn("KaraListeAciklama", @"KaraListeAciklama", typeof(System.String), this.Columns);
			_columnKaraListeBslTarihSaat = GeneralUtils.CreateTypedDataTableColumn("KaraListeBslTarihSaat", @"KaraListeBslTarihSaat", typeof(System.DateTime), this.Columns);
			_columnKaraListeBtsTarihSaat = GeneralUtils.CreateTypedDataTableColumn("KaraListeBtsTarihSaat", @"KaraListeBtsTarihSaat", typeof(System.DateTime), this.Columns);
			_columnKaraListeDurum = GeneralUtils.CreateTypedDataTableColumn("KaraListeDurum", @"KaraListeDurum", typeof(System.Boolean), this.Columns);
			_columnKaraListeId = GeneralUtils.CreateTypedDataTableColumn("KaraListeId", @"KaraListeId", typeof(System.Int64), this.Columns);
			_columnKaraListeIptalEdenKullanici = GeneralUtils.CreateTypedDataTableColumn("KaraListeIptalEdenKullanici", @"KaraListeIptalEdenKullanici", typeof(System.String), this.Columns);
			_columnKaraListeIptalTarihi = GeneralUtils.CreateTypedDataTableColumn("KaraListeIptalTarihi", @"KaraListeIptalTarihi", typeof(System.DateTime), this.Columns);
			_columnKaraListeIslemTarih = GeneralUtils.CreateTypedDataTableColumn("KaraListeIslemTarih", @"KaraListeIslemTarih", typeof(System.DateTime), this.Columns);
			_columnKaraListeIslemYapan = GeneralUtils.CreateTypedDataTableColumn("KaraListeIslemYapan", @"KaraListeIslemYapan", typeof(System.String), this.Columns);

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
			_columnVatandasAdSoyad = this.Columns["VatandasAdSoyad"];
			_columnVatandasTel1 = this.Columns["VatandasTel1"];
			_columnFkVatandasId = this.Columns["FkVatandasId"];
			_columnKaraListeAciklama = this.Columns["KaraListeAciklama"];
			_columnKaraListeBslTarihSaat = this.Columns["KaraListeBslTarihSaat"];
			_columnKaraListeBtsTarihSaat = this.Columns["KaraListeBtsTarihSaat"];
			_columnKaraListeDurum = this.Columns["KaraListeDurum"];
			_columnKaraListeId = this.Columns["KaraListeId"];
			_columnKaraListeIptalEdenKullanici = this.Columns["KaraListeIptalEdenKullanici"];
			_columnKaraListeIptalTarihi = this.Columns["KaraListeIptalTarihi"];
			_columnKaraListeIslemTarih = this.Columns["KaraListeIslemTarih"];
			_columnKaraListeIslemYapan = this.Columns["KaraListeIslemYapan"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListKaraTypedList();
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
			get { return ListKaraTypedList.CustomProperties;}
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
			get { return ListKaraTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field VatandasAdSoyad</summary>
		internal DataColumn VatandasAdSoyadColumn 
		{
			get { return _columnVatandasAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasTel1</summary>
		internal DataColumn VatandasTel1Column 
		{
			get { return _columnVatandasTel1; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkVatandasId</summary>
		internal DataColumn FkVatandasIdColumn 
		{
			get { return _columnFkVatandasId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeAciklama</summary>
		internal DataColumn KaraListeAciklamaColumn 
		{
			get { return _columnKaraListeAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeBslTarihSaat</summary>
		internal DataColumn KaraListeBslTarihSaatColumn 
		{
			get { return _columnKaraListeBslTarihSaat; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeBtsTarihSaat</summary>
		internal DataColumn KaraListeBtsTarihSaatColumn 
		{
			get { return _columnKaraListeBtsTarihSaat; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeDurum</summary>
		internal DataColumn KaraListeDurumColumn 
		{
			get { return _columnKaraListeDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeId</summary>
		internal DataColumn KaraListeIdColumn 
		{
			get { return _columnKaraListeId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeIptalEdenKullanici</summary>
		internal DataColumn KaraListeIptalEdenKullaniciColumn 
		{
			get { return _columnKaraListeIptalEdenKullanici; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeIptalTarihi</summary>
		internal DataColumn KaraListeIptalTarihiColumn 
		{
			get { return _columnKaraListeIptalTarihi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeIslemTarih</summary>
		internal DataColumn KaraListeIslemTarihColumn 
		{
			get { return _columnKaraListeIslemTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KaraListeIslemYapan</summary>
		internal DataColumn KaraListeIslemYapanColumn 
		{
			get { return _columnKaraListeIslemYapan; }
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

	/// <summary>Typed datarow for the typed datatable ListKara</summary>
	public partial class ListKaraRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListKaraTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListKaraRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListKaraTypedList)(this.Table));
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
		/// <summary>Gets / sets the value of the TypedList field VatandasAdSoyad<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Vatanda.VatandasAdSoyad</remarks>
		public System.String VatandasAdSoyad 
		{
			get { return IsVatandasAdSoyadNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VatandasAdSoyadColumn]; }
			set { this[_parent.VatandasAdSoyadColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VatandasAdSoyad is NULL, false otherwise.</summary>
		public bool IsVatandasAdSoyadNull() 
		{
			return IsNull(_parent.VatandasAdSoyadColumn);
		}

		/// <summary>Sets the TypedList field VatandasAdSoyad to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVatandasAdSoyadNull() 
		{
			this[_parent.VatandasAdSoyadColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VatandasTel1<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Vatanda.VatandasTel1</remarks>
		public System.String VatandasTel1 
		{
			get { return IsVatandasTel1Null() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VatandasTel1Column]; }
			set { this[_parent.VatandasTel1Column] = value; }
		}

		/// <summary>Returns true if the TypedList field VatandasTel1 is NULL, false otherwise.</summary>
		public bool IsVatandasTel1Null() 
		{
			return IsNull(_parent.VatandasTel1Column);
		}

		/// <summary>Sets the TypedList field VatandasTel1 to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVatandasTel1Null() 
		{
			this[_parent.VatandasTel1Column] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkVatandasId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.FkVatandasId</remarks>
		public System.Int64 FkVatandasId 
		{
			get { return IsFkVatandasIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.FkVatandasIdColumn]; }
			set { this[_parent.FkVatandasIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkVatandasId is NULL, false otherwise.</summary>
		public bool IsFkVatandasIdNull() 
		{
			return IsNull(_parent.FkVatandasIdColumn);
		}

		/// <summary>Sets the TypedList field FkVatandasId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkVatandasIdNull() 
		{
			this[_parent.FkVatandasIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeAciklama</remarks>
		public System.String KaraListeAciklama 
		{
			get { return IsKaraListeAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KaraListeAciklamaColumn]; }
			set { this[_parent.KaraListeAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeAciklama is NULL, false otherwise.</summary>
		public bool IsKaraListeAciklamaNull() 
		{
			return IsNull(_parent.KaraListeAciklamaColumn);
		}

		/// <summary>Sets the TypedList field KaraListeAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeAciklamaNull() 
		{
			this[_parent.KaraListeAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeBslTarihSaat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeBslTarihSaat</remarks>
		public System.DateTime KaraListeBslTarihSaat 
		{
			get { return IsKaraListeBslTarihSaatNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KaraListeBslTarihSaatColumn]; }
			set { this[_parent.KaraListeBslTarihSaatColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeBslTarihSaat is NULL, false otherwise.</summary>
		public bool IsKaraListeBslTarihSaatNull() 
		{
			return IsNull(_parent.KaraListeBslTarihSaatColumn);
		}

		/// <summary>Sets the TypedList field KaraListeBslTarihSaat to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeBslTarihSaatNull() 
		{
			this[_parent.KaraListeBslTarihSaatColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeBtsTarihSaat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeBtsTarihSaat</remarks>
		public System.DateTime KaraListeBtsTarihSaat 
		{
			get { return IsKaraListeBtsTarihSaatNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KaraListeBtsTarihSaatColumn]; }
			set { this[_parent.KaraListeBtsTarihSaatColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeBtsTarihSaat is NULL, false otherwise.</summary>
		public bool IsKaraListeBtsTarihSaatNull() 
		{
			return IsNull(_parent.KaraListeBtsTarihSaatColumn);
		}

		/// <summary>Sets the TypedList field KaraListeBtsTarihSaat to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeBtsTarihSaatNull() 
		{
			this[_parent.KaraListeBtsTarihSaatColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeDurum</remarks>
		public System.Boolean KaraListeDurum 
		{
			get { return IsKaraListeDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.KaraListeDurumColumn]; }
			set { this[_parent.KaraListeDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeDurum is NULL, false otherwise.</summary>
		public bool IsKaraListeDurumNull() 
		{
			return IsNull(_parent.KaraListeDurumColumn);
		}

		/// <summary>Sets the TypedList field KaraListeDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeDurumNull() 
		{
			this[_parent.KaraListeDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeId</remarks>
		public System.Int64 KaraListeId 
		{
			get { return IsKaraListeIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.KaraListeIdColumn]; }
			set { this[_parent.KaraListeIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeId is NULL, false otherwise.</summary>
		public bool IsKaraListeIdNull() 
		{
			return IsNull(_parent.KaraListeIdColumn);
		}

		/// <summary>Sets the TypedList field KaraListeId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeIdNull() 
		{
			this[_parent.KaraListeIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeIptalEdenKullanici<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeIptalEdenKullanici</remarks>
		public System.String KaraListeIptalEdenKullanici 
		{
			get { return IsKaraListeIptalEdenKullaniciNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KaraListeIptalEdenKullaniciColumn]; }
			set { this[_parent.KaraListeIptalEdenKullaniciColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeIptalEdenKullanici is NULL, false otherwise.</summary>
		public bool IsKaraListeIptalEdenKullaniciNull() 
		{
			return IsNull(_parent.KaraListeIptalEdenKullaniciColumn);
		}

		/// <summary>Sets the TypedList field KaraListeIptalEdenKullanici to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeIptalEdenKullaniciNull() 
		{
			this[_parent.KaraListeIptalEdenKullaniciColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeIptalTarihi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeIptalTarihi</remarks>
		public System.DateTime KaraListeIptalTarihi 
		{
			get { return IsKaraListeIptalTarihiNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KaraListeIptalTarihiColumn]; }
			set { this[_parent.KaraListeIptalTarihiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeIptalTarihi is NULL, false otherwise.</summary>
		public bool IsKaraListeIptalTarihiNull() 
		{
			return IsNull(_parent.KaraListeIptalTarihiColumn);
		}

		/// <summary>Sets the TypedList field KaraListeIptalTarihi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeIptalTarihiNull() 
		{
			this[_parent.KaraListeIptalTarihiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeIslemTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeIslemTarih</remarks>
		public System.DateTime KaraListeIslemTarih 
		{
			get { return IsKaraListeIslemTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KaraListeIslemTarihColumn]; }
			set { this[_parent.KaraListeIslemTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeIslemTarih is NULL, false otherwise.</summary>
		public bool IsKaraListeIslemTarihNull() 
		{
			return IsNull(_parent.KaraListeIslemTarihColumn);
		}

		/// <summary>Sets the TypedList field KaraListeIslemTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeIslemTarihNull() 
		{
			this[_parent.KaraListeIslemTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KaraListeIslemYapan<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KaraListe.KaraListeIslemYapan</remarks>
		public System.String KaraListeIslemYapan 
		{
			get { return IsKaraListeIslemYapanNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KaraListeIslemYapanColumn]; }
			set { this[_parent.KaraListeIslemYapanColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KaraListeIslemYapan is NULL, false otherwise.</summary>
		public bool IsKaraListeIslemYapanNull() 
		{
			return IsNull(_parent.KaraListeIslemYapanColumn);
		}

		/// <summary>Sets the TypedList field KaraListeIslemYapan to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKaraListeIslemYapanNull() 
		{
			this[_parent.KaraListeIslemYapanColumn] = System.Convert.DBNull;
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
