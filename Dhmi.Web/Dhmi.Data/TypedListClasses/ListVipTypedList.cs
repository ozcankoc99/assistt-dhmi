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
	/// <summary>Typed datatable for the list 'ListVip'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListVipTypedList : TypedListBase<ListVipRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnVatandasAdSoyad;
		private DataColumn _columnVatandasId;
		private DataColumn _columnFkVatandasId;
		private DataColumn _columnVipListeAciklama;
		private DataColumn _columnVipListeBslTarihSaat;
		private DataColumn _columnVipListeBtsTarihSaat;
		private DataColumn _columnVipListeDurum;
		private DataColumn _columnVipListeId;
		private DataColumn _columnVipListeIptalEdenKullanici;
		private DataColumn _columnVipListeIptalTarihi;
		private DataColumn _columnVipListeIslemTarih;
		private DataColumn _columnVipListeIslemYapan;
		private DataColumn _columnVatandasTel1;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 15;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListVipTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListVipTypedList():base("ListVip")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListVipTypedList(bool obeyWeakRelations):base("ListVip")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListVipTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListVipTypedList cloneToReturn = ((ListVipTypedList)(base.Clone()));
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
			return new ListVipRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(VatandaEntity.Relations.KullaniciEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
			toReturn.Add(VipListeEntity.Relations.VatandaEntityUsingFkVatandasId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(VatandaFields.VatandasId, 3, "VatandasId", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.FkVatandasId, 4, "FkVatandasId", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeAciklama, 5, "VipListeAciklama", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeBslTarihSaat, 6, "VipListeBslTarihSaat", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeBtsTarihSaat, 7, "VipListeBtsTarihSaat", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeDurum, 8, "VipListeDurum", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeId, 9, "VipListeId", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeIptalEdenKullanici, 10, "VipListeIptalEdenKullanici", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeIptalTarihi, 11, "VipListeIptalTarihi", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeIslemTarih, 12, "VipListeIslemTarih", "", AggregateFunction.None);
			toReturn.DefineField(VipListeFields.VipListeIslemYapan, 13, "VipListeIslemYapan", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasTel1, 14, "VatandasTel1", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("VatandasId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkVatandasId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeBslTarihSaat", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeBtsTarihSaat", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeIptalEdenKullanici", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeIptalTarihi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeIslemTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VipListeIslemYapan", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasTel1", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnVatandasAdSoyad = GeneralUtils.CreateTypedDataTableColumn("VatandasAdSoyad", @"VatandasAdSoyad", typeof(System.String), this.Columns);
			_columnVatandasId = GeneralUtils.CreateTypedDataTableColumn("VatandasId", @"VatandasId", typeof(System.Int64), this.Columns);
			_columnFkVatandasId = GeneralUtils.CreateTypedDataTableColumn("FkVatandasId", @"FkVatandasId", typeof(System.Int64), this.Columns);
			_columnVipListeAciklama = GeneralUtils.CreateTypedDataTableColumn("VipListeAciklama", @"VipListeAciklama", typeof(System.String), this.Columns);
			_columnVipListeBslTarihSaat = GeneralUtils.CreateTypedDataTableColumn("VipListeBslTarihSaat", @"VipListeBslTarihSaat", typeof(System.DateTime), this.Columns);
			_columnVipListeBtsTarihSaat = GeneralUtils.CreateTypedDataTableColumn("VipListeBtsTarihSaat", @"VipListeBtsTarihSaat", typeof(System.DateTime), this.Columns);
			_columnVipListeDurum = GeneralUtils.CreateTypedDataTableColumn("VipListeDurum", @"VipListeDurum", typeof(System.Boolean), this.Columns);
			_columnVipListeId = GeneralUtils.CreateTypedDataTableColumn("VipListeId", @"VipListeId", typeof(System.Int64), this.Columns);
			_columnVipListeIptalEdenKullanici = GeneralUtils.CreateTypedDataTableColumn("VipListeIptalEdenKullanici", @"VipListeIptalEdenKullanici", typeof(System.String), this.Columns);
			_columnVipListeIptalTarihi = GeneralUtils.CreateTypedDataTableColumn("VipListeIptalTarihi", @"VipListeIptalTarihi", typeof(System.DateTime), this.Columns);
			_columnVipListeIslemTarih = GeneralUtils.CreateTypedDataTableColumn("VipListeIslemTarih", @"VipListeIslemTarih", typeof(System.DateTime), this.Columns);
			_columnVipListeIslemYapan = GeneralUtils.CreateTypedDataTableColumn("VipListeIslemYapan", @"VipListeIslemYapan", typeof(System.String), this.Columns);
			_columnVatandasTel1 = GeneralUtils.CreateTypedDataTableColumn("VatandasTel1", @"VatandasTel1", typeof(System.String), this.Columns);

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
			_columnVatandasId = this.Columns["VatandasId"];
			_columnFkVatandasId = this.Columns["FkVatandasId"];
			_columnVipListeAciklama = this.Columns["VipListeAciklama"];
			_columnVipListeBslTarihSaat = this.Columns["VipListeBslTarihSaat"];
			_columnVipListeBtsTarihSaat = this.Columns["VipListeBtsTarihSaat"];
			_columnVipListeDurum = this.Columns["VipListeDurum"];
			_columnVipListeId = this.Columns["VipListeId"];
			_columnVipListeIptalEdenKullanici = this.Columns["VipListeIptalEdenKullanici"];
			_columnVipListeIptalTarihi = this.Columns["VipListeIptalTarihi"];
			_columnVipListeIslemTarih = this.Columns["VipListeIslemTarih"];
			_columnVipListeIslemYapan = this.Columns["VipListeIslemYapan"];
			_columnVatandasTel1 = this.Columns["VatandasTel1"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListVipTypedList();
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
			get { return ListVipTypedList.CustomProperties;}
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
			get { return ListVipTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field VatandasId</summary>
		internal DataColumn VatandasIdColumn 
		{
			get { return _columnVatandasId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkVatandasId</summary>
		internal DataColumn FkVatandasIdColumn 
		{
			get { return _columnFkVatandasId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeAciklama</summary>
		internal DataColumn VipListeAciklamaColumn 
		{
			get { return _columnVipListeAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeBslTarihSaat</summary>
		internal DataColumn VipListeBslTarihSaatColumn 
		{
			get { return _columnVipListeBslTarihSaat; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeBtsTarihSaat</summary>
		internal DataColumn VipListeBtsTarihSaatColumn 
		{
			get { return _columnVipListeBtsTarihSaat; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeDurum</summary>
		internal DataColumn VipListeDurumColumn 
		{
			get { return _columnVipListeDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeId</summary>
		internal DataColumn VipListeIdColumn 
		{
			get { return _columnVipListeId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeIptalEdenKullanici</summary>
		internal DataColumn VipListeIptalEdenKullaniciColumn 
		{
			get { return _columnVipListeIptalEdenKullanici; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeIptalTarihi</summary>
		internal DataColumn VipListeIptalTarihiColumn 
		{
			get { return _columnVipListeIptalTarihi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeIslemTarih</summary>
		internal DataColumn VipListeIslemTarihColumn 
		{
			get { return _columnVipListeIslemTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VipListeIslemYapan</summary>
		internal DataColumn VipListeIslemYapanColumn 
		{
			get { return _columnVipListeIslemYapan; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasTel1</summary>
		internal DataColumn VatandasTel1Column 
		{
			get { return _columnVatandasTel1; }
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

	/// <summary>Typed datarow for the typed datatable ListVip</summary>
	public partial class ListVipRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListVipTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListVipRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListVipTypedList)(this.Table));
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
		/// <summary>Gets / sets the value of the TypedList field VatandasId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Vatanda.VatandasId</remarks>
		public System.Int64 VatandasId 
		{
			get { return IsVatandasIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.VatandasIdColumn]; }
			set { this[_parent.VatandasIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VatandasId is NULL, false otherwise.</summary>
		public bool IsVatandasIdNull() 
		{
			return IsNull(_parent.VatandasIdColumn);
		}

		/// <summary>Sets the TypedList field VatandasId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVatandasIdNull() 
		{
			this[_parent.VatandasIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkVatandasId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.FkVatandasId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field VipListeAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeAciklama</remarks>
		public System.String VipListeAciklama 
		{
			get { return IsVipListeAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VipListeAciklamaColumn]; }
			set { this[_parent.VipListeAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeAciklama is NULL, false otherwise.</summary>
		public bool IsVipListeAciklamaNull() 
		{
			return IsNull(_parent.VipListeAciklamaColumn);
		}

		/// <summary>Sets the TypedList field VipListeAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeAciklamaNull() 
		{
			this[_parent.VipListeAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeBslTarihSaat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeBslTarihSaat</remarks>
		public System.DateTime VipListeBslTarihSaat 
		{
			get { return IsVipListeBslTarihSaatNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.VipListeBslTarihSaatColumn]; }
			set { this[_parent.VipListeBslTarihSaatColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeBslTarihSaat is NULL, false otherwise.</summary>
		public bool IsVipListeBslTarihSaatNull() 
		{
			return IsNull(_parent.VipListeBslTarihSaatColumn);
		}

		/// <summary>Sets the TypedList field VipListeBslTarihSaat to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeBslTarihSaatNull() 
		{
			this[_parent.VipListeBslTarihSaatColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeBtsTarihSaat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeBtsTarihSaat</remarks>
		public System.DateTime VipListeBtsTarihSaat 
		{
			get { return IsVipListeBtsTarihSaatNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.VipListeBtsTarihSaatColumn]; }
			set { this[_parent.VipListeBtsTarihSaatColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeBtsTarihSaat is NULL, false otherwise.</summary>
		public bool IsVipListeBtsTarihSaatNull() 
		{
			return IsNull(_parent.VipListeBtsTarihSaatColumn);
		}

		/// <summary>Sets the TypedList field VipListeBtsTarihSaat to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeBtsTarihSaatNull() 
		{
			this[_parent.VipListeBtsTarihSaatColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeDurum</remarks>
		public System.Boolean VipListeDurum 
		{
			get { return IsVipListeDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.VipListeDurumColumn]; }
			set { this[_parent.VipListeDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeDurum is NULL, false otherwise.</summary>
		public bool IsVipListeDurumNull() 
		{
			return IsNull(_parent.VipListeDurumColumn);
		}

		/// <summary>Sets the TypedList field VipListeDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeDurumNull() 
		{
			this[_parent.VipListeDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeId</remarks>
		public System.Int64 VipListeId 
		{
			get { return IsVipListeIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.VipListeIdColumn]; }
			set { this[_parent.VipListeIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeId is NULL, false otherwise.</summary>
		public bool IsVipListeIdNull() 
		{
			return IsNull(_parent.VipListeIdColumn);
		}

		/// <summary>Sets the TypedList field VipListeId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeIdNull() 
		{
			this[_parent.VipListeIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeIptalEdenKullanici<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeIptalEdenKullanici</remarks>
		public System.String VipListeIptalEdenKullanici 
		{
			get { return IsVipListeIptalEdenKullaniciNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VipListeIptalEdenKullaniciColumn]; }
			set { this[_parent.VipListeIptalEdenKullaniciColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeIptalEdenKullanici is NULL, false otherwise.</summary>
		public bool IsVipListeIptalEdenKullaniciNull() 
		{
			return IsNull(_parent.VipListeIptalEdenKullaniciColumn);
		}

		/// <summary>Sets the TypedList field VipListeIptalEdenKullanici to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeIptalEdenKullaniciNull() 
		{
			this[_parent.VipListeIptalEdenKullaniciColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeIptalTarihi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeIptalTarihi</remarks>
		public System.DateTime VipListeIptalTarihi 
		{
			get { return IsVipListeIptalTarihiNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.VipListeIptalTarihiColumn]; }
			set { this[_parent.VipListeIptalTarihiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeIptalTarihi is NULL, false otherwise.</summary>
		public bool IsVipListeIptalTarihiNull() 
		{
			return IsNull(_parent.VipListeIptalTarihiColumn);
		}

		/// <summary>Sets the TypedList field VipListeIptalTarihi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeIptalTarihiNull() 
		{
			this[_parent.VipListeIptalTarihiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeIslemTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeIslemTarih</remarks>
		public System.DateTime VipListeIslemTarih 
		{
			get { return IsVipListeIslemTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.VipListeIslemTarihColumn]; }
			set { this[_parent.VipListeIslemTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeIslemTarih is NULL, false otherwise.</summary>
		public bool IsVipListeIslemTarihNull() 
		{
			return IsNull(_parent.VipListeIslemTarihColumn);
		}

		/// <summary>Sets the TypedList field VipListeIslemTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeIslemTarihNull() 
		{
			this[_parent.VipListeIslemTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VipListeIslemYapan<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: VipListe.VipListeIslemYapan</remarks>
		public System.String VipListeIslemYapan 
		{
			get { return IsVipListeIslemYapanNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VipListeIslemYapanColumn]; }
			set { this[_parent.VipListeIslemYapanColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VipListeIslemYapan is NULL, false otherwise.</summary>
		public bool IsVipListeIslemYapanNull() 
		{
			return IsNull(_parent.VipListeIslemYapanColumn);
		}

		/// <summary>Sets the TypedList field VipListeIslemYapan to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVipListeIslemYapanNull() 
		{
			this[_parent.VipListeIslemYapanColumn] = System.Convert.DBNull;
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
		#endregion

		#region Custom Typed List Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
