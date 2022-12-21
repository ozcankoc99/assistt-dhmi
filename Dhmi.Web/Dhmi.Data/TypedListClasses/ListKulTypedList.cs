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
	/// <summary>Typed datatable for the list 'ListKul'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListKulTypedList : TypedListBase<ListKulRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnGorevAd;
		private DataColumn _columnHiyerarsiTurAd;
		private DataColumn _columnAvayaLoginId;
		private DataColumn _columnExtension;
		private DataColumn _columnFkGorevId;
		private DataColumn _columnFkHiyerarsiTurId;
		private DataColumn _columnFkYetkiId;
		private DataColumn _columnKullaniciAciklama;
		private DataColumn _columnKullaniciAd;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciDurum;
		private DataColumn _columnKullaniciGizliSoruCevap;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnKullaniciMail;
		private DataColumn _columnKullaniciPassword;
		private DataColumn _columnKullaniciSoyad;
		private DataColumn _columnKullaniciTarih;
		private DataColumn _columnKullaniciUsername;
		private DataColumn _columnTcKimlikNo;
		private DataColumn _columnYetkiAd;
		private DataColumn _columnKullaniciBirim;
		private DataColumn _columnKullaniciGizliSoru;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 22;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListKulTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListKulTypedList():base("ListKul")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListKulTypedList(bool obeyWeakRelations):base("ListKul")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListKulTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListKulTypedList cloneToReturn = ((ListKulTypedList)(base.Clone()));
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
			return new ListKulRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KullaniciEntity.Relations.GorevEntityUsingFkGorevId, "", "", JoinHint.Inner);
			toReturn.Add(HiyerarsiTurEntity.Relations.KullaniciEntityUsingFkHiyerarsiTurId, "", "", JoinHint.Inner);
			toReturn.Add(YetkiEntity.Relations.KullaniciEntityUsingFkYetkiId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(GorevFields.GorevAd, 0, "GorevAd", "", AggregateFunction.None);
			toReturn.DefineField(HiyerarsiTurFields.HiyerarsiTurAd, 1, "HiyerarsiTurAd", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.AvayaLoginId, 2, "AvayaLoginId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.Extension, 3, "Extension", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkGorevId, 4, "FkGorevId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkHiyerarsiTurId, 5, "FkHiyerarsiTurId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkYetkiId, 6, "FkYetkiId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAciklama, 7, "KullaniciAciklama", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAd, 8, "KullaniciAd", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 9, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciDurum, 10, "KullaniciDurum", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciGizliSoruCevap, 11, "KullaniciGizliSoruCevap", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 12, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciMail, 13, "KullaniciMail", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciPassword, 14, "KullaniciPassword", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciSoyad, 15, "KullaniciSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciTarih, 16, "KullaniciTarih", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciUsername, 17, "KullaniciUsername", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.TcKimlikNo, 18, "TcKimlikNo", "", AggregateFunction.None);
			toReturn.DefineField(YetkiFields.YetkiAd, 19, "YetkiAd", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciBirim, 20, "KullaniciBirim", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciGizliSoru, 21, "KullaniciGizliSoru", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("GorevAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("HiyerarsiTurAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AvayaLoginId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Extension", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkGorevId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkHiyerarsiTurId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkYetkiId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciGizliSoruCevap", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciMail", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciPassword", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciUsername", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TcKimlikNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("YetkiAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciBirim", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciGizliSoru", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnGorevAd = GeneralUtils.CreateTypedDataTableColumn("GorevAd", @"GorevAd", typeof(System.String), this.Columns);
			_columnHiyerarsiTurAd = GeneralUtils.CreateTypedDataTableColumn("HiyerarsiTurAd", @"HiyerarsiTurAd", typeof(System.String), this.Columns);
			_columnAvayaLoginId = GeneralUtils.CreateTypedDataTableColumn("AvayaLoginId", @"AvayaLoginId", typeof(System.String), this.Columns);
			_columnExtension = GeneralUtils.CreateTypedDataTableColumn("Extension", @"Extension", typeof(System.String), this.Columns);
			_columnFkGorevId = GeneralUtils.CreateTypedDataTableColumn("FkGorevId", @"FkGorevId", typeof(System.Int16), this.Columns);
			_columnFkHiyerarsiTurId = GeneralUtils.CreateTypedDataTableColumn("FkHiyerarsiTurId", @"FkHiyerarsiTurId", typeof(System.Int16), this.Columns);
			_columnFkYetkiId = GeneralUtils.CreateTypedDataTableColumn("FkYetkiId", @"FkYetkiId", typeof(System.Int16), this.Columns);
			_columnKullaniciAciklama = GeneralUtils.CreateTypedDataTableColumn("KullaniciAciklama", @"KullaniciAciklama", typeof(System.String), this.Columns);
			_columnKullaniciAd = GeneralUtils.CreateTypedDataTableColumn("KullaniciAd", @"KullaniciAd", typeof(System.String), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciDurum = GeneralUtils.CreateTypedDataTableColumn("KullaniciDurum", @"KullaniciDurum", typeof(System.Boolean), this.Columns);
			_columnKullaniciGizliSoruCevap = GeneralUtils.CreateTypedDataTableColumn("KullaniciGizliSoruCevap", @"KullaniciGizliSoruCevap", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciMail = GeneralUtils.CreateTypedDataTableColumn("KullaniciMail", @"KullaniciMail", typeof(System.String), this.Columns);
			_columnKullaniciPassword = GeneralUtils.CreateTypedDataTableColumn("KullaniciPassword", @"KullaniciPassword", typeof(System.String), this.Columns);
			_columnKullaniciSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciSoyad", @"KullaniciSoyad", typeof(System.String), this.Columns);
			_columnKullaniciTarih = GeneralUtils.CreateTypedDataTableColumn("KullaniciTarih", @"KullaniciTarih", typeof(System.DateTime), this.Columns);
			_columnKullaniciUsername = GeneralUtils.CreateTypedDataTableColumn("KullaniciUsername", @"KullaniciUsername", typeof(System.String), this.Columns);
			_columnTcKimlikNo = GeneralUtils.CreateTypedDataTableColumn("TcKimlikNo", @"TcKimlikNo", typeof(System.String), this.Columns);
			_columnYetkiAd = GeneralUtils.CreateTypedDataTableColumn("YetkiAd", @"YetkiAd", typeof(System.String), this.Columns);
			_columnKullaniciBirim = GeneralUtils.CreateTypedDataTableColumn("KullaniciBirim", @"KullaniciBirim", typeof(System.String), this.Columns);
			_columnKullaniciGizliSoru = GeneralUtils.CreateTypedDataTableColumn("KullaniciGizliSoru", @"KullaniciGizliSoru", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnGorevAd = this.Columns["GorevAd"];
			_columnHiyerarsiTurAd = this.Columns["HiyerarsiTurAd"];
			_columnAvayaLoginId = this.Columns["AvayaLoginId"];
			_columnExtension = this.Columns["Extension"];
			_columnFkGorevId = this.Columns["FkGorevId"];
			_columnFkHiyerarsiTurId = this.Columns["FkHiyerarsiTurId"];
			_columnFkYetkiId = this.Columns["FkYetkiId"];
			_columnKullaniciAciklama = this.Columns["KullaniciAciklama"];
			_columnKullaniciAd = this.Columns["KullaniciAd"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciDurum = this.Columns["KullaniciDurum"];
			_columnKullaniciGizliSoruCevap = this.Columns["KullaniciGizliSoruCevap"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnKullaniciMail = this.Columns["KullaniciMail"];
			_columnKullaniciPassword = this.Columns["KullaniciPassword"];
			_columnKullaniciSoyad = this.Columns["KullaniciSoyad"];
			_columnKullaniciTarih = this.Columns["KullaniciTarih"];
			_columnKullaniciUsername = this.Columns["KullaniciUsername"];
			_columnTcKimlikNo = this.Columns["TcKimlikNo"];
			_columnYetkiAd = this.Columns["YetkiAd"];
			_columnKullaniciBirim = this.Columns["KullaniciBirim"];
			_columnKullaniciGizliSoru = this.Columns["KullaniciGizliSoru"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListKulTypedList();
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
			get { return ListKulTypedList.CustomProperties;}
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
			get { return ListKulTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field GorevAd</summary>
		internal DataColumn GorevAdColumn 
		{
			get { return _columnGorevAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field HiyerarsiTurAd</summary>
		internal DataColumn HiyerarsiTurAdColumn 
		{
			get { return _columnHiyerarsiTurAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AvayaLoginId</summary>
		internal DataColumn AvayaLoginIdColumn 
		{
			get { return _columnAvayaLoginId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field Extension</summary>
		internal DataColumn ExtensionColumn 
		{
			get { return _columnExtension; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkGorevId</summary>
		internal DataColumn FkGorevIdColumn 
		{
			get { return _columnFkGorevId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkHiyerarsiTurId</summary>
		internal DataColumn FkHiyerarsiTurIdColumn 
		{
			get { return _columnFkHiyerarsiTurId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkYetkiId</summary>
		internal DataColumn FkYetkiIdColumn 
		{
			get { return _columnFkYetkiId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAciklama</summary>
		internal DataColumn KullaniciAciklamaColumn 
		{
			get { return _columnKullaniciAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAd</summary>
		internal DataColumn KullaniciAdColumn 
		{
			get { return _columnKullaniciAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAdSoyad</summary>
		internal DataColumn KullaniciAdSoyadColumn 
		{
			get { return _columnKullaniciAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciDurum</summary>
		internal DataColumn KullaniciDurumColumn 
		{
			get { return _columnKullaniciDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciGizliSoruCevap</summary>
		internal DataColumn KullaniciGizliSoruCevapColumn 
		{
			get { return _columnKullaniciGizliSoruCevap; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciId</summary>
		internal DataColumn KullaniciIdColumn 
		{
			get { return _columnKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciMail</summary>
		internal DataColumn KullaniciMailColumn 
		{
			get { return _columnKullaniciMail; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciPassword</summary>
		internal DataColumn KullaniciPasswordColumn 
		{
			get { return _columnKullaniciPassword; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciSoyad</summary>
		internal DataColumn KullaniciSoyadColumn 
		{
			get { return _columnKullaniciSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciTarih</summary>
		internal DataColumn KullaniciTarihColumn 
		{
			get { return _columnKullaniciTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciUsername</summary>
		internal DataColumn KullaniciUsernameColumn 
		{
			get { return _columnKullaniciUsername; }
		}

		/// <summary>Returns the column object belonging to the TypedList field TcKimlikNo</summary>
		internal DataColumn TcKimlikNoColumn 
		{
			get { return _columnTcKimlikNo; }
		}

		/// <summary>Returns the column object belonging to the TypedList field YetkiAd</summary>
		internal DataColumn YetkiAdColumn 
		{
			get { return _columnYetkiAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciBirim</summary>
		internal DataColumn KullaniciBirimColumn 
		{
			get { return _columnKullaniciBirim; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciGizliSoru</summary>
		internal DataColumn KullaniciGizliSoruColumn 
		{
			get { return _columnKullaniciGizliSoru; }
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

	/// <summary>Typed datarow for the typed datatable ListKul</summary>
	public partial class ListKulRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListKulTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListKulRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListKulTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field GorevAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Gorev.GorevAd</remarks>
		public System.String GorevAd 
		{
			get { return IsGorevAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GorevAdColumn]; }
			set { this[_parent.GorevAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GorevAd is NULL, false otherwise.</summary>
		public bool IsGorevAdNull() 
		{
			return IsNull(_parent.GorevAdColumn);
		}

		/// <summary>Sets the TypedList field GorevAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGorevAdNull() 
		{
			this[_parent.GorevAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field HiyerarsiTurAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: HiyerarsiTur.HiyerarsiTurAd</remarks>
		public System.String HiyerarsiTurAd 
		{
			get { return IsHiyerarsiTurAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.HiyerarsiTurAdColumn]; }
			set { this[_parent.HiyerarsiTurAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field HiyerarsiTurAd is NULL, false otherwise.</summary>
		public bool IsHiyerarsiTurAdNull() 
		{
			return IsNull(_parent.HiyerarsiTurAdColumn);
		}

		/// <summary>Sets the TypedList field HiyerarsiTurAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetHiyerarsiTurAdNull() 
		{
			this[_parent.HiyerarsiTurAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AvayaLoginId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.AvayaLoginId</remarks>
		public System.String AvayaLoginId 
		{
			get { return IsAvayaLoginIdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AvayaLoginIdColumn]; }
			set { this[_parent.AvayaLoginIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AvayaLoginId is NULL, false otherwise.</summary>
		public bool IsAvayaLoginIdNull() 
		{
			return IsNull(_parent.AvayaLoginIdColumn);
		}

		/// <summary>Sets the TypedList field AvayaLoginId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAvayaLoginIdNull() 
		{
			this[_parent.AvayaLoginIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field Extension<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.Extension</remarks>
		public System.String Extension 
		{
			get { return IsExtensionNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ExtensionColumn]; }
			set { this[_parent.ExtensionColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field Extension is NULL, false otherwise.</summary>
		public bool IsExtensionNull() 
		{
			return IsNull(_parent.ExtensionColumn);
		}

		/// <summary>Sets the TypedList field Extension to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetExtensionNull() 
		{
			this[_parent.ExtensionColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkGorevId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.FkGorevId</remarks>
		public System.Int16 FkGorevId 
		{
			get { return IsFkGorevIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkGorevIdColumn]; }
			set { this[_parent.FkGorevIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkGorevId is NULL, false otherwise.</summary>
		public bool IsFkGorevIdNull() 
		{
			return IsNull(_parent.FkGorevIdColumn);
		}

		/// <summary>Sets the TypedList field FkGorevId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkGorevIdNull() 
		{
			this[_parent.FkGorevIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkHiyerarsiTurId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.FkHiyerarsiTurId</remarks>
		public System.Int16 FkHiyerarsiTurId 
		{
			get { return IsFkHiyerarsiTurIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkHiyerarsiTurIdColumn]; }
			set { this[_parent.FkHiyerarsiTurIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkHiyerarsiTurId is NULL, false otherwise.</summary>
		public bool IsFkHiyerarsiTurIdNull() 
		{
			return IsNull(_parent.FkHiyerarsiTurIdColumn);
		}

		/// <summary>Sets the TypedList field FkHiyerarsiTurId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkHiyerarsiTurIdNull() 
		{
			this[_parent.FkHiyerarsiTurIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkYetkiId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.FkYetkiId</remarks>
		public System.Int16 FkYetkiId 
		{
			get { return IsFkYetkiIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkYetkiIdColumn]; }
			set { this[_parent.FkYetkiIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkYetkiId is NULL, false otherwise.</summary>
		public bool IsFkYetkiIdNull() 
		{
			return IsNull(_parent.FkYetkiIdColumn);
		}

		/// <summary>Sets the TypedList field FkYetkiId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkYetkiIdNull() 
		{
			this[_parent.FkYetkiIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciAciklama</remarks>
		public System.String KullaniciAciklama 
		{
			get { return IsKullaniciAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciAciklamaColumn]; }
			set { this[_parent.KullaniciAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciAciklama is NULL, false otherwise.</summary>
		public bool IsKullaniciAciklamaNull() 
		{
			return IsNull(_parent.KullaniciAciklamaColumn);
		}

		/// <summary>Sets the TypedList field KullaniciAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciAciklamaNull() 
		{
			this[_parent.KullaniciAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciAd</remarks>
		public System.String KullaniciAd 
		{
			get { return IsKullaniciAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciAdColumn]; }
			set { this[_parent.KullaniciAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciAd is NULL, false otherwise.</summary>
		public bool IsKullaniciAdNull() 
		{
			return IsNull(_parent.KullaniciAdColumn);
		}

		/// <summary>Sets the TypedList field KullaniciAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciAdNull() 
		{
			this[_parent.KullaniciAdColumn] = System.Convert.DBNull;
		}
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
		/// <summary>Gets / sets the value of the TypedList field KullaniciDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciDurum</remarks>
		public System.Boolean KullaniciDurum 
		{
			get { return IsKullaniciDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.KullaniciDurumColumn]; }
			set { this[_parent.KullaniciDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciDurum is NULL, false otherwise.</summary>
		public bool IsKullaniciDurumNull() 
		{
			return IsNull(_parent.KullaniciDurumColumn);
		}

		/// <summary>Sets the TypedList field KullaniciDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciDurumNull() 
		{
			this[_parent.KullaniciDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciGizliSoruCevap<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciGizliSoruCevap</remarks>
		public System.String KullaniciGizliSoruCevap 
		{
			get { return IsKullaniciGizliSoruCevapNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciGizliSoruCevapColumn]; }
			set { this[_parent.KullaniciGizliSoruCevapColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciGizliSoruCevap is NULL, false otherwise.</summary>
		public bool IsKullaniciGizliSoruCevapNull() 
		{
			return IsNull(_parent.KullaniciGizliSoruCevapColumn);
		}

		/// <summary>Sets the TypedList field KullaniciGizliSoruCevap to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciGizliSoruCevapNull() 
		{
			this[_parent.KullaniciGizliSoruCevapColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field KullaniciMail<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciMail</remarks>
		public System.String KullaniciMail 
		{
			get { return IsKullaniciMailNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciMailColumn]; }
			set { this[_parent.KullaniciMailColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciMail is NULL, false otherwise.</summary>
		public bool IsKullaniciMailNull() 
		{
			return IsNull(_parent.KullaniciMailColumn);
		}

		/// <summary>Sets the TypedList field KullaniciMail to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciMailNull() 
		{
			this[_parent.KullaniciMailColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciPassword<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciPassword</remarks>
		public System.String KullaniciPassword 
		{
			get { return IsKullaniciPasswordNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciPasswordColumn]; }
			set { this[_parent.KullaniciPasswordColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciPassword is NULL, false otherwise.</summary>
		public bool IsKullaniciPasswordNull() 
		{
			return IsNull(_parent.KullaniciPasswordColumn);
		}

		/// <summary>Sets the TypedList field KullaniciPassword to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciPasswordNull() 
		{
			this[_parent.KullaniciPasswordColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciSoyad<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciSoyad</remarks>
		public System.String KullaniciSoyad 
		{
			get { return IsKullaniciSoyadNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciSoyadColumn]; }
			set { this[_parent.KullaniciSoyadColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciSoyad is NULL, false otherwise.</summary>
		public bool IsKullaniciSoyadNull() 
		{
			return IsNull(_parent.KullaniciSoyadColumn);
		}

		/// <summary>Sets the TypedList field KullaniciSoyad to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciSoyadNull() 
		{
			this[_parent.KullaniciSoyadColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciTarih</remarks>
		public System.DateTime KullaniciTarih 
		{
			get { return IsKullaniciTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KullaniciTarihColumn]; }
			set { this[_parent.KullaniciTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciTarih is NULL, false otherwise.</summary>
		public bool IsKullaniciTarihNull() 
		{
			return IsNull(_parent.KullaniciTarihColumn);
		}

		/// <summary>Sets the TypedList field KullaniciTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciTarihNull() 
		{
			this[_parent.KullaniciTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciUsername<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciUsername</remarks>
		public System.String KullaniciUsername 
		{
			get { return IsKullaniciUsernameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciUsernameColumn]; }
			set { this[_parent.KullaniciUsernameColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciUsername is NULL, false otherwise.</summary>
		public bool IsKullaniciUsernameNull() 
		{
			return IsNull(_parent.KullaniciUsernameColumn);
		}

		/// <summary>Sets the TypedList field KullaniciUsername to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciUsernameNull() 
		{
			this[_parent.KullaniciUsernameColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field TcKimlikNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.TcKimlikNo</remarks>
		public System.String TcKimlikNo 
		{
			get { return IsTcKimlikNoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TcKimlikNoColumn]; }
			set { this[_parent.TcKimlikNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field TcKimlikNo is NULL, false otherwise.</summary>
		public bool IsTcKimlikNoNull() 
		{
			return IsNull(_parent.TcKimlikNoColumn);
		}

		/// <summary>Sets the TypedList field TcKimlikNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTcKimlikNoNull() 
		{
			this[_parent.TcKimlikNoColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field YetkiAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Yetki.YetkiAd</remarks>
		public System.String YetkiAd 
		{
			get { return IsYetkiAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.YetkiAdColumn]; }
			set { this[_parent.YetkiAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field YetkiAd is NULL, false otherwise.</summary>
		public bool IsYetkiAdNull() 
		{
			return IsNull(_parent.YetkiAdColumn);
		}

		/// <summary>Sets the TypedList field YetkiAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetYetkiAdNull() 
		{
			this[_parent.YetkiAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciBirim<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciBirim</remarks>
		public System.String KullaniciBirim 
		{
			get { return IsKullaniciBirimNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciBirimColumn]; }
			set { this[_parent.KullaniciBirimColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciBirim is NULL, false otherwise.</summary>
		public bool IsKullaniciBirimNull() 
		{
			return IsNull(_parent.KullaniciBirimColumn);
		}

		/// <summary>Sets the TypedList field KullaniciBirim to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciBirimNull() 
		{
			this[_parent.KullaniciBirimColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciGizliSoru<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciGizliSoru</remarks>
		public System.String KullaniciGizliSoru 
		{
			get { return IsKullaniciGizliSoruNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciGizliSoruColumn]; }
			set { this[_parent.KullaniciGizliSoruColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciGizliSoru is NULL, false otherwise.</summary>
		public bool IsKullaniciGizliSoruNull() 
		{
			return IsNull(_parent.KullaniciGizliSoruColumn);
		}

		/// <summary>Sets the TypedList field KullaniciGizliSoru to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciGizliSoruNull() 
		{
			this[_parent.KullaniciGizliSoruColumn] = System.Convert.DBNull;
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
