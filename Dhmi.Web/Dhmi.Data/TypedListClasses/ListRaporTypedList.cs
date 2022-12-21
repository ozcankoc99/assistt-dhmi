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
	/// <summary>Typed datatable for the list 'ListRapor'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListRaporTypedList : TypedListBase<ListRaporRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAvayaLoginId;
		private DataColumn _columnExtension;
		private DataColumn _columnFkGorevId;
		private DataColumn _columnFkHiyerarsiTurId;
		private DataColumn _columnFkYetkiId;
		private DataColumn _columnKullaniciAciklama;
		private DataColumn _columnKullaniciAd;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciBirim;
		private DataColumn _columnKullaniciDurum;
		private DataColumn _columnKullaniciGizliSoru;
		private DataColumn _columnKullaniciGizliSoruCevap;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnKullaniciMail;
		private DataColumn _columnKullaniciPassword;
		private DataColumn _columnKullaniciSoyad;
		private DataColumn _columnKullaniciTarih;
		private DataColumn _columnKullaniciUsername;
		private DataColumn _columnTcKimlikNo;
		private DataColumn _columnFkRaporTuruId;
		private DataColumn _columnRaporIcerikAnaVeri;
		private DataColumn _columnRaporIcerikDurum;
		private DataColumn _columnRaporIcerikId;
		private DataColumn _columnRaporIcerikKolon;
		private DataColumn _columnRaporIcerikTarih;
		private DataColumn _columnRaporTuruAd;
		private DataColumn _columnRaporTuruDurum;
		private DataColumn _columnRaporTuruId;
		private DataColumn _columnRaporTuruTarih;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnFkRaporTuruId_;
		private DataColumn _columnRaporYetkiDurum;
		private DataColumn _columnRaporYetkiId;
		private DataColumn _columnRaporYetkiTarih;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 34;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListRaporTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListRaporTypedList():base("ListRapor")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListRaporTypedList(bool obeyWeakRelations):base("ListRapor")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListRaporTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListRaporTypedList cloneToReturn = ((ListRaporTypedList)(base.Clone()));
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
			return new ListRaporRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(RaporIcerikEntity.Relations.RaporTuruEntityUsingFkRaporTuruId, "", "", JoinHint.Inner);
			toReturn.Add(RaporYetkiEntity.Relations.RaporTuruEntityUsingFkRaporTuruId, "", "", JoinHint.Inner);
			toReturn.Add(KullaniciEntity.Relations.RaporYetkiEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(KullaniciFields.AvayaLoginId, 0, "AvayaLoginId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.Extension, 1, "Extension", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkGorevId, 2, "FkGorevId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkHiyerarsiTurId, 3, "FkHiyerarsiTurId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.FkYetkiId, 4, "FkYetkiId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAciklama, 5, "KullaniciAciklama", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAd, 6, "KullaniciAd", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 7, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciBirim, 8, "KullaniciBirim", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciDurum, 9, "KullaniciDurum", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciGizliSoru, 10, "KullaniciGizliSoru", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciGizliSoruCevap, 11, "KullaniciGizliSoruCevap", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 12, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciMail, 13, "KullaniciMail", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciPassword, 14, "KullaniciPassword", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciSoyad, 15, "KullaniciSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciTarih, 16, "KullaniciTarih", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciUsername, 17, "KullaniciUsername", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.TcKimlikNo, 18, "TcKimlikNo", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.FkRaporTuruId, 19, "FkRaporTuruId", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.RaporIcerikAnaVeri, 20, "RaporIcerikAnaVeri", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.RaporIcerikDurum, 21, "RaporIcerikDurum", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.RaporIcerikId, 22, "RaporIcerikId", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.RaporIcerikKolon, 23, "RaporIcerikKolon", "", AggregateFunction.None);
			toReturn.DefineField(RaporIcerikFields.RaporIcerikTarih, 24, "RaporIcerikTarih", "", AggregateFunction.None);
			toReturn.DefineField(RaporTuruFields.RaporTuruAd, 25, "RaporTuruAd", "", AggregateFunction.None);
			toReturn.DefineField(RaporTuruFields.RaporTuruDurum, 26, "RaporTuruDurum", "", AggregateFunction.None);
			toReturn.DefineField(RaporTuruFields.RaporTuruId, 27, "RaporTuruId", "", AggregateFunction.None);
			toReturn.DefineField(RaporTuruFields.RaporTuruTarih, 28, "RaporTuruTarih", "", AggregateFunction.None);
			toReturn.DefineField(RaporYetkiFields.FkKullaniciId, 29, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(RaporYetkiFields.FkRaporTuruId, 30, "FkRaporTuruId_", "", AggregateFunction.None);
			toReturn.DefineField(RaporYetkiFields.RaporYetkiDurum, 31, "RaporYetkiDurum", "", AggregateFunction.None);
			toReturn.DefineField(RaporYetkiFields.RaporYetkiId, 32, "RaporYetkiId", "", AggregateFunction.None);
			toReturn.DefineField(RaporYetkiFields.RaporYetkiTarih, 33, "RaporYetkiTarih", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("KullaniciBirim", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciGizliSoru", fieldHashtable);
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
			_fieldsCustomProperties.Add("FkRaporTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporIcerikAnaVeri", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporIcerikDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporIcerikId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporIcerikKolon", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporIcerikTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporTuruAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporTuruDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporTuruTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkRaporTuruId_", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporYetkiDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporYetkiId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("RaporYetkiTarih", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAvayaLoginId = GeneralUtils.CreateTypedDataTableColumn("AvayaLoginId", @"AvayaLoginId", typeof(System.String), this.Columns);
			_columnExtension = GeneralUtils.CreateTypedDataTableColumn("Extension", @"Extension", typeof(System.String), this.Columns);
			_columnFkGorevId = GeneralUtils.CreateTypedDataTableColumn("FkGorevId", @"FkGorevId", typeof(System.Int16), this.Columns);
			_columnFkHiyerarsiTurId = GeneralUtils.CreateTypedDataTableColumn("FkHiyerarsiTurId", @"FkHiyerarsiTurId", typeof(System.Int16), this.Columns);
			_columnFkYetkiId = GeneralUtils.CreateTypedDataTableColumn("FkYetkiId", @"FkYetkiId", typeof(System.Int16), this.Columns);
			_columnKullaniciAciklama = GeneralUtils.CreateTypedDataTableColumn("KullaniciAciklama", @"KullaniciAciklama", typeof(System.String), this.Columns);
			_columnKullaniciAd = GeneralUtils.CreateTypedDataTableColumn("KullaniciAd", @"KullaniciAd", typeof(System.String), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciBirim = GeneralUtils.CreateTypedDataTableColumn("KullaniciBirim", @"KullaniciBirim", typeof(System.String), this.Columns);
			_columnKullaniciDurum = GeneralUtils.CreateTypedDataTableColumn("KullaniciDurum", @"KullaniciDurum", typeof(System.Boolean), this.Columns);
			_columnKullaniciGizliSoru = GeneralUtils.CreateTypedDataTableColumn("KullaniciGizliSoru", @"KullaniciGizliSoru", typeof(System.String), this.Columns);
			_columnKullaniciGizliSoruCevap = GeneralUtils.CreateTypedDataTableColumn("KullaniciGizliSoruCevap", @"KullaniciGizliSoruCevap", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciMail = GeneralUtils.CreateTypedDataTableColumn("KullaniciMail", @"KullaniciMail", typeof(System.String), this.Columns);
			_columnKullaniciPassword = GeneralUtils.CreateTypedDataTableColumn("KullaniciPassword", @"KullaniciPassword", typeof(System.String), this.Columns);
			_columnKullaniciSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciSoyad", @"KullaniciSoyad", typeof(System.String), this.Columns);
			_columnKullaniciTarih = GeneralUtils.CreateTypedDataTableColumn("KullaniciTarih", @"KullaniciTarih", typeof(System.DateTime), this.Columns);
			_columnKullaniciUsername = GeneralUtils.CreateTypedDataTableColumn("KullaniciUsername", @"KullaniciUsername", typeof(System.String), this.Columns);
			_columnTcKimlikNo = GeneralUtils.CreateTypedDataTableColumn("TcKimlikNo", @"TcKimlikNo", typeof(System.String), this.Columns);
			_columnFkRaporTuruId = GeneralUtils.CreateTypedDataTableColumn("FkRaporTuruId", @"FkRaporTuruId", typeof(System.Int16), this.Columns);
			_columnRaporIcerikAnaVeri = GeneralUtils.CreateTypedDataTableColumn("RaporIcerikAnaVeri", @"RaporIcerikAnaVeri", typeof(System.String), this.Columns);
			_columnRaporIcerikDurum = GeneralUtils.CreateTypedDataTableColumn("RaporIcerikDurum", @"RaporIcerikDurum", typeof(System.Boolean), this.Columns);
			_columnRaporIcerikId = GeneralUtils.CreateTypedDataTableColumn("RaporIcerikId", @"RaporIcerikId", typeof(System.Int64), this.Columns);
			_columnRaporIcerikKolon = GeneralUtils.CreateTypedDataTableColumn("RaporIcerikKolon", @"RaporIcerikKolon", typeof(System.String), this.Columns);
			_columnRaporIcerikTarih = GeneralUtils.CreateTypedDataTableColumn("RaporIcerikTarih", @"RaporIcerikTarih", typeof(System.DateTime), this.Columns);
			_columnRaporTuruAd = GeneralUtils.CreateTypedDataTableColumn("RaporTuruAd", @"RaporTuruAd", typeof(System.String), this.Columns);
			_columnRaporTuruDurum = GeneralUtils.CreateTypedDataTableColumn("RaporTuruDurum", @"RaporTuruDurum", typeof(System.Boolean), this.Columns);
			_columnRaporTuruId = GeneralUtils.CreateTypedDataTableColumn("RaporTuruId", @"RaporTuruId", typeof(System.Int16), this.Columns);
			_columnRaporTuruTarih = GeneralUtils.CreateTypedDataTableColumn("RaporTuruTarih", @"RaporTuruTarih", typeof(System.DateTime), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnFkRaporTuruId_ = GeneralUtils.CreateTypedDataTableColumn("FkRaporTuruId_", @"FkRaporTuruId", typeof(System.Int16), this.Columns);
			_columnRaporYetkiDurum = GeneralUtils.CreateTypedDataTableColumn("RaporYetkiDurum", @"RaporYetkiDurum", typeof(System.Boolean), this.Columns);
			_columnRaporYetkiId = GeneralUtils.CreateTypedDataTableColumn("RaporYetkiId", @"RaporYetkiId", typeof(System.Int64), this.Columns);
			_columnRaporYetkiTarih = GeneralUtils.CreateTypedDataTableColumn("RaporYetkiTarih", @"RaporYetkiTarih", typeof(System.DateTime), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnAvayaLoginId = this.Columns["AvayaLoginId"];
			_columnExtension = this.Columns["Extension"];
			_columnFkGorevId = this.Columns["FkGorevId"];
			_columnFkHiyerarsiTurId = this.Columns["FkHiyerarsiTurId"];
			_columnFkYetkiId = this.Columns["FkYetkiId"];
			_columnKullaniciAciklama = this.Columns["KullaniciAciklama"];
			_columnKullaniciAd = this.Columns["KullaniciAd"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciBirim = this.Columns["KullaniciBirim"];
			_columnKullaniciDurum = this.Columns["KullaniciDurum"];
			_columnKullaniciGizliSoru = this.Columns["KullaniciGizliSoru"];
			_columnKullaniciGizliSoruCevap = this.Columns["KullaniciGizliSoruCevap"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnKullaniciMail = this.Columns["KullaniciMail"];
			_columnKullaniciPassword = this.Columns["KullaniciPassword"];
			_columnKullaniciSoyad = this.Columns["KullaniciSoyad"];
			_columnKullaniciTarih = this.Columns["KullaniciTarih"];
			_columnKullaniciUsername = this.Columns["KullaniciUsername"];
			_columnTcKimlikNo = this.Columns["TcKimlikNo"];
			_columnFkRaporTuruId = this.Columns["FkRaporTuruId"];
			_columnRaporIcerikAnaVeri = this.Columns["RaporIcerikAnaVeri"];
			_columnRaporIcerikDurum = this.Columns["RaporIcerikDurum"];
			_columnRaporIcerikId = this.Columns["RaporIcerikId"];
			_columnRaporIcerikKolon = this.Columns["RaporIcerikKolon"];
			_columnRaporIcerikTarih = this.Columns["RaporIcerikTarih"];
			_columnRaporTuruAd = this.Columns["RaporTuruAd"];
			_columnRaporTuruDurum = this.Columns["RaporTuruDurum"];
			_columnRaporTuruId = this.Columns["RaporTuruId"];
			_columnRaporTuruTarih = this.Columns["RaporTuruTarih"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnFkRaporTuruId_ = this.Columns["FkRaporTuruId_"];
			_columnRaporYetkiDurum = this.Columns["RaporYetkiDurum"];
			_columnRaporYetkiId = this.Columns["RaporYetkiId"];
			_columnRaporYetkiTarih = this.Columns["RaporYetkiTarih"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListRaporTypedList();
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
			get { return ListRaporTypedList.CustomProperties;}
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
			get { return ListRaporTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field KullaniciBirim</summary>
		internal DataColumn KullaniciBirimColumn 
		{
			get { return _columnKullaniciBirim; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciDurum</summary>
		internal DataColumn KullaniciDurumColumn 
		{
			get { return _columnKullaniciDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciGizliSoru</summary>
		internal DataColumn KullaniciGizliSoruColumn 
		{
			get { return _columnKullaniciGizliSoru; }
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

		/// <summary>Returns the column object belonging to the TypedList field FkRaporTuruId</summary>
		internal DataColumn FkRaporTuruIdColumn 
		{
			get { return _columnFkRaporTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporIcerikAnaVeri</summary>
		internal DataColumn RaporIcerikAnaVeriColumn 
		{
			get { return _columnRaporIcerikAnaVeri; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporIcerikDurum</summary>
		internal DataColumn RaporIcerikDurumColumn 
		{
			get { return _columnRaporIcerikDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporIcerikId</summary>
		internal DataColumn RaporIcerikIdColumn 
		{
			get { return _columnRaporIcerikId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporIcerikKolon</summary>
		internal DataColumn RaporIcerikKolonColumn 
		{
			get { return _columnRaporIcerikKolon; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporIcerikTarih</summary>
		internal DataColumn RaporIcerikTarihColumn 
		{
			get { return _columnRaporIcerikTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporTuruAd</summary>
		internal DataColumn RaporTuruAdColumn 
		{
			get { return _columnRaporTuruAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporTuruDurum</summary>
		internal DataColumn RaporTuruDurumColumn 
		{
			get { return _columnRaporTuruDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporTuruId</summary>
		internal DataColumn RaporTuruIdColumn 
		{
			get { return _columnRaporTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporTuruTarih</summary>
		internal DataColumn RaporTuruTarihColumn 
		{
			get { return _columnRaporTuruTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkRaporTuruId_</summary>
		internal DataColumn FkRaporTuruId_Column 
		{
			get { return _columnFkRaporTuruId_; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporYetkiDurum</summary>
		internal DataColumn RaporYetkiDurumColumn 
		{
			get { return _columnRaporYetkiDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporYetkiId</summary>
		internal DataColumn RaporYetkiIdColumn 
		{
			get { return _columnRaporYetkiId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field RaporYetkiTarih</summary>
		internal DataColumn RaporYetkiTarihColumn 
		{
			get { return _columnRaporYetkiTarih; }
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

	/// <summary>Typed datarow for the typed datatable ListRapor</summary>
	public partial class ListRaporRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListRaporTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListRaporRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListRaporTypedList)(this.Table));
		}

		#region Class Property Declarations
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
		/// <summary>Gets / sets the value of the TypedList field FkRaporTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.FkRaporTuruId</remarks>
		public System.Int16 FkRaporTuruId 
		{
			get { return IsFkRaporTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkRaporTuruIdColumn]; }
			set { this[_parent.FkRaporTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkRaporTuruId is NULL, false otherwise.</summary>
		public bool IsFkRaporTuruIdNull() 
		{
			return IsNull(_parent.FkRaporTuruIdColumn);
		}

		/// <summary>Sets the TypedList field FkRaporTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkRaporTuruIdNull() 
		{
			this[_parent.FkRaporTuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporIcerikAnaVeri<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.RaporIcerikAnaVeri</remarks>
		public System.String RaporIcerikAnaVeri 
		{
			get { return IsRaporIcerikAnaVeriNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RaporIcerikAnaVeriColumn]; }
			set { this[_parent.RaporIcerikAnaVeriColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporIcerikAnaVeri is NULL, false otherwise.</summary>
		public bool IsRaporIcerikAnaVeriNull() 
		{
			return IsNull(_parent.RaporIcerikAnaVeriColumn);
		}

		/// <summary>Sets the TypedList field RaporIcerikAnaVeri to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporIcerikAnaVeriNull() 
		{
			this[_parent.RaporIcerikAnaVeriColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporIcerikDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.RaporIcerikDurum</remarks>
		public System.Boolean RaporIcerikDurum 
		{
			get { return IsRaporIcerikDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.RaporIcerikDurumColumn]; }
			set { this[_parent.RaporIcerikDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporIcerikDurum is NULL, false otherwise.</summary>
		public bool IsRaporIcerikDurumNull() 
		{
			return IsNull(_parent.RaporIcerikDurumColumn);
		}

		/// <summary>Sets the TypedList field RaporIcerikDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporIcerikDurumNull() 
		{
			this[_parent.RaporIcerikDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporIcerikId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.RaporIcerikId</remarks>
		public System.Int64 RaporIcerikId 
		{
			get { return IsRaporIcerikIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.RaporIcerikIdColumn]; }
			set { this[_parent.RaporIcerikIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporIcerikId is NULL, false otherwise.</summary>
		public bool IsRaporIcerikIdNull() 
		{
			return IsNull(_parent.RaporIcerikIdColumn);
		}

		/// <summary>Sets the TypedList field RaporIcerikId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporIcerikIdNull() 
		{
			this[_parent.RaporIcerikIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporIcerikKolon<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.RaporIcerikKolon</remarks>
		public System.String RaporIcerikKolon 
		{
			get { return IsRaporIcerikKolonNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RaporIcerikKolonColumn]; }
			set { this[_parent.RaporIcerikKolonColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporIcerikKolon is NULL, false otherwise.</summary>
		public bool IsRaporIcerikKolonNull() 
		{
			return IsNull(_parent.RaporIcerikKolonColumn);
		}

		/// <summary>Sets the TypedList field RaporIcerikKolon to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporIcerikKolonNull() 
		{
			this[_parent.RaporIcerikKolonColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporIcerikTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporIcerik.RaporIcerikTarih</remarks>
		public System.DateTime RaporIcerikTarih 
		{
			get { return IsRaporIcerikTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.RaporIcerikTarihColumn]; }
			set { this[_parent.RaporIcerikTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporIcerikTarih is NULL, false otherwise.</summary>
		public bool IsRaporIcerikTarihNull() 
		{
			return IsNull(_parent.RaporIcerikTarihColumn);
		}

		/// <summary>Sets the TypedList field RaporIcerikTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporIcerikTarihNull() 
		{
			this[_parent.RaporIcerikTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporTuruAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporTuru.RaporTuruAd</remarks>
		public System.String RaporTuruAd 
		{
			get { return IsRaporTuruAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.RaporTuruAdColumn]; }
			set { this[_parent.RaporTuruAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporTuruAd is NULL, false otherwise.</summary>
		public bool IsRaporTuruAdNull() 
		{
			return IsNull(_parent.RaporTuruAdColumn);
		}

		/// <summary>Sets the TypedList field RaporTuruAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporTuruAdNull() 
		{
			this[_parent.RaporTuruAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporTuruDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporTuru.RaporTuruDurum</remarks>
		public System.Boolean RaporTuruDurum 
		{
			get { return IsRaporTuruDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.RaporTuruDurumColumn]; }
			set { this[_parent.RaporTuruDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporTuruDurum is NULL, false otherwise.</summary>
		public bool IsRaporTuruDurumNull() 
		{
			return IsNull(_parent.RaporTuruDurumColumn);
		}

		/// <summary>Sets the TypedList field RaporTuruDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporTuruDurumNull() 
		{
			this[_parent.RaporTuruDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporTuru.RaporTuruId</remarks>
		public System.Int16 RaporTuruId 
		{
			get { return IsRaporTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.RaporTuruIdColumn]; }
			set { this[_parent.RaporTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporTuruId is NULL, false otherwise.</summary>
		public bool IsRaporTuruIdNull() 
		{
			return IsNull(_parent.RaporTuruIdColumn);
		}

		/// <summary>Sets the TypedList field RaporTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporTuruIdNull() 
		{
			this[_parent.RaporTuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporTuruTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporTuru.RaporTuruTarih</remarks>
		public System.DateTime RaporTuruTarih 
		{
			get { return IsRaporTuruTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.RaporTuruTarihColumn]; }
			set { this[_parent.RaporTuruTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporTuruTarih is NULL, false otherwise.</summary>
		public bool IsRaporTuruTarihNull() 
		{
			return IsNull(_parent.RaporTuruTarihColumn);
		}

		/// <summary>Sets the TypedList field RaporTuruTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporTuruTarihNull() 
		{
			this[_parent.RaporTuruTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporYetki.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field FkRaporTuruId_<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporYetki.FkRaporTuruId</remarks>
		public System.Int16 FkRaporTuruId_ 
		{
			get { return IsFkRaporTuruId_Null() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkRaporTuruId_Column]; }
			set { this[_parent.FkRaporTuruId_Column] = value; }
		}

		/// <summary>Returns true if the TypedList field FkRaporTuruId_ is NULL, false otherwise.</summary>
		public bool IsFkRaporTuruId_Null() 
		{
			return IsNull(_parent.FkRaporTuruId_Column);
		}

		/// <summary>Sets the TypedList field FkRaporTuruId_ to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkRaporTuruId_Null() 
		{
			this[_parent.FkRaporTuruId_Column] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporYetkiDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporYetki.RaporYetkiDurum</remarks>
		public System.Boolean RaporYetkiDurum 
		{
			get { return IsRaporYetkiDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.RaporYetkiDurumColumn]; }
			set { this[_parent.RaporYetkiDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporYetkiDurum is NULL, false otherwise.</summary>
		public bool IsRaporYetkiDurumNull() 
		{
			return IsNull(_parent.RaporYetkiDurumColumn);
		}

		/// <summary>Sets the TypedList field RaporYetkiDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporYetkiDurumNull() 
		{
			this[_parent.RaporYetkiDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporYetkiId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporYetki.RaporYetkiId</remarks>
		public System.Int64 RaporYetkiId 
		{
			get { return IsRaporYetkiIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.RaporYetkiIdColumn]; }
			set { this[_parent.RaporYetkiIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporYetkiId is NULL, false otherwise.</summary>
		public bool IsRaporYetkiIdNull() 
		{
			return IsNull(_parent.RaporYetkiIdColumn);
		}

		/// <summary>Sets the TypedList field RaporYetkiId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporYetkiIdNull() 
		{
			this[_parent.RaporYetkiIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field RaporYetkiTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: RaporYetki.RaporYetkiTarih</remarks>
		public System.DateTime RaporYetkiTarih 
		{
			get { return IsRaporYetkiTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.RaporYetkiTarihColumn]; }
			set { this[_parent.RaporYetkiTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field RaporYetkiTarih is NULL, false otherwise.</summary>
		public bool IsRaporYetkiTarihNull() 
		{
			return IsNull(_parent.RaporYetkiTarihColumn);
		}

		/// <summary>Sets the TypedList field RaporYetkiTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetRaporYetkiTarihNull() 
		{
			this[_parent.RaporYetkiTarihColumn] = System.Convert.DBNull;
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
