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
	/// <summary>Typed datatable for the list 'ListTakip'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListTakipTypedList : TypedListBase<ListTakipRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAltKonuAd;
		private DataColumn _columnBildirimAciklama;
		private DataColumn _columnBildirimAtanmaDurumu;
		private DataColumn _columnBildirimDavaAdSoyad;
		private DataColumn _columnBildirimDavaDosyaNo;
		private DataColumn _columnBildirimDavaKonu;
		private DataColumn _columnBildirimDavaMahkeme;
		private DataColumn _columnBildirimGelenYer;
		private DataColumn _columnBildirimGeriYapildiMi;
		private DataColumn _columnBildirimHavalimani;
		private DataColumn _columnBildirimId;
		private DataColumn _columnBildirimKimBitirdi;
		private DataColumn _columnBildirimKonuDiger;
		private DataColumn _columnBildirimMetin;
		private DataColumn _columnBildirimSonIslemTarih;
		private DataColumn _columnBildirimTarih;
		private DataColumn _columnBildirimToplamSure;
		private DataColumn _columnBildirimYil;
		private DataColumn _columnBildirimYonlendirilenKurum;
		private DataColumn _columnFkAltKonuId;
		private DataColumn _columnFkBildirimGeriDonusId;
		private DataColumn _columnFkBildirimSonucId;
		private DataColumn _columnFkBildirimTuruId;
		private DataColumn _columnFkCagriTipiId;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnFkVatandasId;
		private DataColumn _columnCagriTipiAd;
		private DataColumn _columnVatandasId;
		private DataColumn _columnVatandasAdSoyad;
		private DataColumn _columnBildirimAtamaKullaniciBittiMi;
		private DataColumn _columnBildirimAtamaKullaniciBittiTarih;
		private DataColumn _columnBildirimAtamaKullaniciId;
		private DataColumn _columnBildirimAtamaKullaniciYonMu;
		private DataColumn _columnFkBildirimId;
		private DataColumn _columnFkKonuId;
		private DataColumn _columnFkKullaniciId_;
		private DataColumn _columnBildirimSonucAd;
		private DataColumn _columnVatandasTel1;
		private DataColumn _columnVatandasTcNo;
		private DataColumn _columnVatandasPasaportNo;
		private DataColumn _columnBildirimAtamaKullaniciTarih;
		private DataColumn _columnBildirimTuruAd;
		private DataColumn _columnBildirimGeriDonusAd;
		private DataColumn _columnBildirimVatandasKarar;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 44;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListTakipTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListTakipTypedList():base("ListTakip")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListTakipTypedList(bool obeyWeakRelations):base("ListTakip")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListTakipTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListTakipTypedList cloneToReturn = ((ListTakipTypedList)(base.Clone()));
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
			return new ListTakipRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(BildirimEntity.Relations.AltKonuEntityUsingFkAltKonuId, "", "", JoinHint.Inner);
			toReturn.Add(BildirimAtamaKullaniciEntity.Relations.BildirimEntityUsingFkBildirimId, "", "", JoinHint.Inner);
			toReturn.Add(BildirimGeriDonuEntity.Relations.BildirimEntityUsingFkBildirimGeriDonusId, "", "", JoinHint.Inner);
			toReturn.Add(BildirimSonucEntity.Relations.BildirimEntityUsingFkBildirimSonucId, "", "", JoinHint.Inner);
			toReturn.Add(BildirimTuruEntity.Relations.BildirimEntityUsingFkBildirimTuruId, "", "", JoinHint.Inner);
			toReturn.Add(CagriTipiEntity.Relations.BildirimEntityUsingFkCagriTipiId, "", "", JoinHint.Inner);
			toReturn.Add(VatandaEntity.Relations.BildirimEntityUsingFkVatandasId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(AltKonuFields.AltKonuAd, 0, "AltKonuAd", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimAciklama, 1, "BildirimAciklama", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimAtanmaDurumu, 2, "BildirimAtanmaDurumu", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimDavaAdSoyad, 3, "BildirimDavaAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimDavaDosyaNo, 4, "BildirimDavaDosyaNo", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimDavaKonu, 5, "BildirimDavaKonu", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimDavaMahkeme, 6, "BildirimDavaMahkeme", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimGelenYer, 7, "BildirimGelenYer", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimGeriYapildiMi, 8, "BildirimGeriYapildiMi", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimHavalimani, 9, "BildirimHavalimani", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimId, 10, "BildirimId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimKimBitirdi, 11, "BildirimKimBitirdi", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimKonuDiger, 12, "BildirimKonuDiger", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimMetin, 13, "BildirimMetin", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimSonIslemTarih, 14, "BildirimSonIslemTarih", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimTarih, 15, "BildirimTarih", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimToplamSure, 16, "BildirimToplamSure", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimYil, 17, "BildirimYil", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimYonlendirilenKurum, 18, "BildirimYonlendirilenKurum", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkAltKonuId, 19, "FkAltKonuId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkBildirimGeriDonusId, 20, "FkBildirimGeriDonusId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkBildirimSonucId, 21, "FkBildirimSonucId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkBildirimTuruId, 22, "FkBildirimTuruId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkCagriTipiId, 23, "FkCagriTipiId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkKullaniciId, 24, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.FkVatandasId, 25, "FkVatandasId", "", AggregateFunction.None);
			toReturn.DefineField(CagriTipiFields.CagriTipiAd, 26, "CagriTipiAd", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasId, 27, "VatandasId", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasAdSoyad, 28, "VatandasAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi, 29, "BildirimAtamaKullaniciBittiMi", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiTarih, 30, "BildirimAtamaKullaniciBittiTarih", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciId, 31, "BildirimAtamaKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu, 32, "BildirimAtamaKullaniciYonMu", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.FkBildirimId, 33, "FkBildirimId", "", AggregateFunction.None);
			toReturn.DefineField(AltKonuFields.FkKonuId, 34, "FkKonuId", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.FkKullaniciId, 35, "FkKullaniciId_", "", AggregateFunction.None);
			toReturn.DefineField(BildirimSonucFields.BildirimSonucAd, 36, "BildirimSonucAd", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasTel1, 37, "VatandasTel1", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasTcNo, 38, "VatandasTcNo", "", AggregateFunction.None);
			toReturn.DefineField(VatandaFields.VatandasPasaportNo, 39, "VatandasPasaportNo", "", AggregateFunction.None);
			toReturn.DefineField(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciTarih, 40, "BildirimAtamaKullaniciTarih", "", AggregateFunction.None);
			toReturn.DefineField(BildirimTuruFields.BildirimTuruAd, 41, "BildirimTuruAd", "", AggregateFunction.None);
			toReturn.DefineField(BildirimGeriDonuFields.BildirimGeriDonusAd, 42, "BildirimGeriDonusAd", "", AggregateFunction.None);
			toReturn.DefineField(BildirimFields.BildirimVatandasKarar, 43, "BildirimVatandasKarar", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("AltKonuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtanmaDurumu", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimDavaAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimDavaDosyaNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimDavaKonu", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimDavaMahkeme", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimGelenYer", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimGeriYapildiMi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimHavalimani", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimKimBitirdi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimKonuDiger", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimMetin", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimSonIslemTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimToplamSure", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimYil", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimYonlendirilenKurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkAltKonuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkBildirimGeriDonusId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkBildirimSonucId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkBildirimTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkCagriTipiId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkVatandasId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CagriTipiAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtamaKullaniciBittiMi", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtamaKullaniciBittiTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtamaKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtamaKullaniciYonMu", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkBildirimId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKonuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId_", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimSonucAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasTel1", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasTcNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("VatandasPasaportNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimAtamaKullaniciTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimTuruAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimGeriDonusAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BildirimVatandasKarar", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAltKonuAd = GeneralUtils.CreateTypedDataTableColumn("AltKonuAd", @"AltKonuAd", typeof(System.String), this.Columns);
			_columnBildirimAciklama = GeneralUtils.CreateTypedDataTableColumn("BildirimAciklama", @"BildirimAciklama", typeof(System.String), this.Columns);
			_columnBildirimAtanmaDurumu = GeneralUtils.CreateTypedDataTableColumn("BildirimAtanmaDurumu", @"BildirimAtanmaDurumu", typeof(System.String), this.Columns);
			_columnBildirimDavaAdSoyad = GeneralUtils.CreateTypedDataTableColumn("BildirimDavaAdSoyad", @"BildirimDavaAdSoyad", typeof(System.String), this.Columns);
			_columnBildirimDavaDosyaNo = GeneralUtils.CreateTypedDataTableColumn("BildirimDavaDosyaNo", @"BildirimDavaDosyaNo", typeof(System.String), this.Columns);
			_columnBildirimDavaKonu = GeneralUtils.CreateTypedDataTableColumn("BildirimDavaKonu", @"BildirimDavaKonu", typeof(System.String), this.Columns);
			_columnBildirimDavaMahkeme = GeneralUtils.CreateTypedDataTableColumn("BildirimDavaMahkeme", @"BildirimDavaMahkeme", typeof(System.String), this.Columns);
			_columnBildirimGelenYer = GeneralUtils.CreateTypedDataTableColumn("BildirimGelenYer", @"BildirimGelenYer", typeof(System.String), this.Columns);
			_columnBildirimGeriYapildiMi = GeneralUtils.CreateTypedDataTableColumn("BildirimGeriYapildiMi", @"BildirimGeriYapildiMi", typeof(System.Boolean), this.Columns);
			_columnBildirimHavalimani = GeneralUtils.CreateTypedDataTableColumn("BildirimHavalimani", @"BildirimHavalimani", typeof(System.String), this.Columns);
			_columnBildirimId = GeneralUtils.CreateTypedDataTableColumn("BildirimId", @"BildirimId", typeof(System.Int64), this.Columns);
			_columnBildirimKimBitirdi = GeneralUtils.CreateTypedDataTableColumn("BildirimKimBitirdi", @"BildirimKimBitirdi", typeof(System.Int16), this.Columns);
			_columnBildirimKonuDiger = GeneralUtils.CreateTypedDataTableColumn("BildirimKonuDiger", @"BildirimKonuDiger", typeof(System.String), this.Columns);
			_columnBildirimMetin = GeneralUtils.CreateTypedDataTableColumn("BildirimMetin", @"BildirimMetin", typeof(System.String), this.Columns);
			_columnBildirimSonIslemTarih = GeneralUtils.CreateTypedDataTableColumn("BildirimSonIslemTarih", @"BildirimSonIslemTarih", typeof(System.DateTime), this.Columns);
			_columnBildirimTarih = GeneralUtils.CreateTypedDataTableColumn("BildirimTarih", @"BildirimTarih", typeof(System.DateTime), this.Columns);
			_columnBildirimToplamSure = GeneralUtils.CreateTypedDataTableColumn("BildirimToplamSure", @"BildirimToplamSure", typeof(System.String), this.Columns);
			_columnBildirimYil = GeneralUtils.CreateTypedDataTableColumn("BildirimYil", @"BildirimYil", typeof(System.Int16), this.Columns);
			_columnBildirimYonlendirilenKurum = GeneralUtils.CreateTypedDataTableColumn("BildirimYonlendirilenKurum", @"BildirimYonlendirilenKurum", typeof(System.String), this.Columns);
			_columnFkAltKonuId = GeneralUtils.CreateTypedDataTableColumn("FkAltKonuId", @"FkAltKonuId", typeof(System.Int64), this.Columns);
			_columnFkBildirimGeriDonusId = GeneralUtils.CreateTypedDataTableColumn("FkBildirimGeriDonusId", @"FkBildirimGeriDonusId", typeof(System.Int16), this.Columns);
			_columnFkBildirimSonucId = GeneralUtils.CreateTypedDataTableColumn("FkBildirimSonucId", @"FkBildirimSonucId", typeof(System.Int16), this.Columns);
			_columnFkBildirimTuruId = GeneralUtils.CreateTypedDataTableColumn("FkBildirimTuruId", @"FkBildirimTuruId", typeof(System.Int16), this.Columns);
			_columnFkCagriTipiId = GeneralUtils.CreateTypedDataTableColumn("FkCagriTipiId", @"FkCagriTipiId", typeof(System.Int16), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnFkVatandasId = GeneralUtils.CreateTypedDataTableColumn("FkVatandasId", @"FkVatandasId", typeof(System.Int64), this.Columns);
			_columnCagriTipiAd = GeneralUtils.CreateTypedDataTableColumn("CagriTipiAd", @"CagriTipiAd", typeof(System.String), this.Columns);
			_columnVatandasId = GeneralUtils.CreateTypedDataTableColumn("VatandasId", @"VatandasId", typeof(System.Int64), this.Columns);
			_columnVatandasAdSoyad = GeneralUtils.CreateTypedDataTableColumn("VatandasAdSoyad", @"VatandasAdSoyad", typeof(System.String), this.Columns);
			_columnBildirimAtamaKullaniciBittiMi = GeneralUtils.CreateTypedDataTableColumn("BildirimAtamaKullaniciBittiMi", @"BildirimAtamaKullaniciBittiMi", typeof(System.Boolean), this.Columns);
			_columnBildirimAtamaKullaniciBittiTarih = GeneralUtils.CreateTypedDataTableColumn("BildirimAtamaKullaniciBittiTarih", @"BildirimAtamaKullaniciBittiTarih", typeof(System.DateTime), this.Columns);
			_columnBildirimAtamaKullaniciId = GeneralUtils.CreateTypedDataTableColumn("BildirimAtamaKullaniciId", @"BildirimAtamaKullaniciId", typeof(System.Int64), this.Columns);
			_columnBildirimAtamaKullaniciYonMu = GeneralUtils.CreateTypedDataTableColumn("BildirimAtamaKullaniciYonMu", @"BildirimAtamaKullaniciYonMu", typeof(System.String), this.Columns);
			_columnFkBildirimId = GeneralUtils.CreateTypedDataTableColumn("FkBildirimId", @"FkBildirimId", typeof(System.Int64), this.Columns);
			_columnFkKonuId = GeneralUtils.CreateTypedDataTableColumn("FkKonuId", @"FkKonuId", typeof(System.Int64), this.Columns);
			_columnFkKullaniciId_ = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId_", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnBildirimSonucAd = GeneralUtils.CreateTypedDataTableColumn("BildirimSonucAd", @"BildirimSonucAd", typeof(System.String), this.Columns);
			_columnVatandasTel1 = GeneralUtils.CreateTypedDataTableColumn("VatandasTel1", @"VatandasTel1", typeof(System.String), this.Columns);
			_columnVatandasTcNo = GeneralUtils.CreateTypedDataTableColumn("VatandasTcNo", @"VatandasTcNo", typeof(System.String), this.Columns);
			_columnVatandasPasaportNo = GeneralUtils.CreateTypedDataTableColumn("VatandasPasaportNo", @"VatandasPasaportNo", typeof(System.String), this.Columns);
			_columnBildirimAtamaKullaniciTarih = GeneralUtils.CreateTypedDataTableColumn("BildirimAtamaKullaniciTarih", @"BildirimAtamaKullaniciTarih", typeof(System.DateTime), this.Columns);
			_columnBildirimTuruAd = GeneralUtils.CreateTypedDataTableColumn("BildirimTuruAd", @"BildirimTuruAd", typeof(System.String), this.Columns);
			_columnBildirimGeriDonusAd = GeneralUtils.CreateTypedDataTableColumn("BildirimGeriDonusAd", @"BildirimGeriDonusAd", typeof(System.String), this.Columns);
			_columnBildirimVatandasKarar = GeneralUtils.CreateTypedDataTableColumn("BildirimVatandasKarar", @"BildirimVatandasKarar", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnAltKonuAd = this.Columns["AltKonuAd"];
			_columnBildirimAciklama = this.Columns["BildirimAciklama"];
			_columnBildirimAtanmaDurumu = this.Columns["BildirimAtanmaDurumu"];
			_columnBildirimDavaAdSoyad = this.Columns["BildirimDavaAdSoyad"];
			_columnBildirimDavaDosyaNo = this.Columns["BildirimDavaDosyaNo"];
			_columnBildirimDavaKonu = this.Columns["BildirimDavaKonu"];
			_columnBildirimDavaMahkeme = this.Columns["BildirimDavaMahkeme"];
			_columnBildirimGelenYer = this.Columns["BildirimGelenYer"];
			_columnBildirimGeriYapildiMi = this.Columns["BildirimGeriYapildiMi"];
			_columnBildirimHavalimani = this.Columns["BildirimHavalimani"];
			_columnBildirimId = this.Columns["BildirimId"];
			_columnBildirimKimBitirdi = this.Columns["BildirimKimBitirdi"];
			_columnBildirimKonuDiger = this.Columns["BildirimKonuDiger"];
			_columnBildirimMetin = this.Columns["BildirimMetin"];
			_columnBildirimSonIslemTarih = this.Columns["BildirimSonIslemTarih"];
			_columnBildirimTarih = this.Columns["BildirimTarih"];
			_columnBildirimToplamSure = this.Columns["BildirimToplamSure"];
			_columnBildirimYil = this.Columns["BildirimYil"];
			_columnBildirimYonlendirilenKurum = this.Columns["BildirimYonlendirilenKurum"];
			_columnFkAltKonuId = this.Columns["FkAltKonuId"];
			_columnFkBildirimGeriDonusId = this.Columns["FkBildirimGeriDonusId"];
			_columnFkBildirimSonucId = this.Columns["FkBildirimSonucId"];
			_columnFkBildirimTuruId = this.Columns["FkBildirimTuruId"];
			_columnFkCagriTipiId = this.Columns["FkCagriTipiId"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnFkVatandasId = this.Columns["FkVatandasId"];
			_columnCagriTipiAd = this.Columns["CagriTipiAd"];
			_columnVatandasId = this.Columns["VatandasId"];
			_columnVatandasAdSoyad = this.Columns["VatandasAdSoyad"];
			_columnBildirimAtamaKullaniciBittiMi = this.Columns["BildirimAtamaKullaniciBittiMi"];
			_columnBildirimAtamaKullaniciBittiTarih = this.Columns["BildirimAtamaKullaniciBittiTarih"];
			_columnBildirimAtamaKullaniciId = this.Columns["BildirimAtamaKullaniciId"];
			_columnBildirimAtamaKullaniciYonMu = this.Columns["BildirimAtamaKullaniciYonMu"];
			_columnFkBildirimId = this.Columns["FkBildirimId"];
			_columnFkKonuId = this.Columns["FkKonuId"];
			_columnFkKullaniciId_ = this.Columns["FkKullaniciId_"];
			_columnBildirimSonucAd = this.Columns["BildirimSonucAd"];
			_columnVatandasTel1 = this.Columns["VatandasTel1"];
			_columnVatandasTcNo = this.Columns["VatandasTcNo"];
			_columnVatandasPasaportNo = this.Columns["VatandasPasaportNo"];
			_columnBildirimAtamaKullaniciTarih = this.Columns["BildirimAtamaKullaniciTarih"];
			_columnBildirimTuruAd = this.Columns["BildirimTuruAd"];
			_columnBildirimGeriDonusAd = this.Columns["BildirimGeriDonusAd"];
			_columnBildirimVatandasKarar = this.Columns["BildirimVatandasKarar"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListTakipTypedList();
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
			get { return ListTakipTypedList.CustomProperties;}
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
			get { return ListTakipTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field AltKonuAd</summary>
		internal DataColumn AltKonuAdColumn 
		{
			get { return _columnAltKonuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAciklama</summary>
		internal DataColumn BildirimAciklamaColumn 
		{
			get { return _columnBildirimAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtanmaDurumu</summary>
		internal DataColumn BildirimAtanmaDurumuColumn 
		{
			get { return _columnBildirimAtanmaDurumu; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimDavaAdSoyad</summary>
		internal DataColumn BildirimDavaAdSoyadColumn 
		{
			get { return _columnBildirimDavaAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimDavaDosyaNo</summary>
		internal DataColumn BildirimDavaDosyaNoColumn 
		{
			get { return _columnBildirimDavaDosyaNo; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimDavaKonu</summary>
		internal DataColumn BildirimDavaKonuColumn 
		{
			get { return _columnBildirimDavaKonu; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimDavaMahkeme</summary>
		internal DataColumn BildirimDavaMahkemeColumn 
		{
			get { return _columnBildirimDavaMahkeme; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimGelenYer</summary>
		internal DataColumn BildirimGelenYerColumn 
		{
			get { return _columnBildirimGelenYer; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimGeriYapildiMi</summary>
		internal DataColumn BildirimGeriYapildiMiColumn 
		{
			get { return _columnBildirimGeriYapildiMi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimHavalimani</summary>
		internal DataColumn BildirimHavalimaniColumn 
		{
			get { return _columnBildirimHavalimani; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimId</summary>
		internal DataColumn BildirimIdColumn 
		{
			get { return _columnBildirimId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimKimBitirdi</summary>
		internal DataColumn BildirimKimBitirdiColumn 
		{
			get { return _columnBildirimKimBitirdi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimKonuDiger</summary>
		internal DataColumn BildirimKonuDigerColumn 
		{
			get { return _columnBildirimKonuDiger; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimMetin</summary>
		internal DataColumn BildirimMetinColumn 
		{
			get { return _columnBildirimMetin; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimSonIslemTarih</summary>
		internal DataColumn BildirimSonIslemTarihColumn 
		{
			get { return _columnBildirimSonIslemTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimTarih</summary>
		internal DataColumn BildirimTarihColumn 
		{
			get { return _columnBildirimTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimToplamSure</summary>
		internal DataColumn BildirimToplamSureColumn 
		{
			get { return _columnBildirimToplamSure; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimYil</summary>
		internal DataColumn BildirimYilColumn 
		{
			get { return _columnBildirimYil; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimYonlendirilenKurum</summary>
		internal DataColumn BildirimYonlendirilenKurumColumn 
		{
			get { return _columnBildirimYonlendirilenKurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkAltKonuId</summary>
		internal DataColumn FkAltKonuIdColumn 
		{
			get { return _columnFkAltKonuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkBildirimGeriDonusId</summary>
		internal DataColumn FkBildirimGeriDonusIdColumn 
		{
			get { return _columnFkBildirimGeriDonusId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkBildirimSonucId</summary>
		internal DataColumn FkBildirimSonucIdColumn 
		{
			get { return _columnFkBildirimSonucId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkBildirimTuruId</summary>
		internal DataColumn FkBildirimTuruIdColumn 
		{
			get { return _columnFkBildirimTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkCagriTipiId</summary>
		internal DataColumn FkCagriTipiIdColumn 
		{
			get { return _columnFkCagriTipiId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkVatandasId</summary>
		internal DataColumn FkVatandasIdColumn 
		{
			get { return _columnFkVatandasId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field CagriTipiAd</summary>
		internal DataColumn CagriTipiAdColumn 
		{
			get { return _columnCagriTipiAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasId</summary>
		internal DataColumn VatandasIdColumn 
		{
			get { return _columnVatandasId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasAdSoyad</summary>
		internal DataColumn VatandasAdSoyadColumn 
		{
			get { return _columnVatandasAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtamaKullaniciBittiMi</summary>
		internal DataColumn BildirimAtamaKullaniciBittiMiColumn 
		{
			get { return _columnBildirimAtamaKullaniciBittiMi; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtamaKullaniciBittiTarih</summary>
		internal DataColumn BildirimAtamaKullaniciBittiTarihColumn 
		{
			get { return _columnBildirimAtamaKullaniciBittiTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtamaKullaniciId</summary>
		internal DataColumn BildirimAtamaKullaniciIdColumn 
		{
			get { return _columnBildirimAtamaKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtamaKullaniciYonMu</summary>
		internal DataColumn BildirimAtamaKullaniciYonMuColumn 
		{
			get { return _columnBildirimAtamaKullaniciYonMu; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkBildirimId</summary>
		internal DataColumn FkBildirimIdColumn 
		{
			get { return _columnFkBildirimId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKonuId</summary>
		internal DataColumn FkKonuIdColumn 
		{
			get { return _columnFkKonuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId_</summary>
		internal DataColumn FkKullaniciId_Column 
		{
			get { return _columnFkKullaniciId_; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimSonucAd</summary>
		internal DataColumn BildirimSonucAdColumn 
		{
			get { return _columnBildirimSonucAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasTel1</summary>
		internal DataColumn VatandasTel1Column 
		{
			get { return _columnVatandasTel1; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasTcNo</summary>
		internal DataColumn VatandasTcNoColumn 
		{
			get { return _columnVatandasTcNo; }
		}

		/// <summary>Returns the column object belonging to the TypedList field VatandasPasaportNo</summary>
		internal DataColumn VatandasPasaportNoColumn 
		{
			get { return _columnVatandasPasaportNo; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimAtamaKullaniciTarih</summary>
		internal DataColumn BildirimAtamaKullaniciTarihColumn 
		{
			get { return _columnBildirimAtamaKullaniciTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimTuruAd</summary>
		internal DataColumn BildirimTuruAdColumn 
		{
			get { return _columnBildirimTuruAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimGeriDonusAd</summary>
		internal DataColumn BildirimGeriDonusAdColumn 
		{
			get { return _columnBildirimGeriDonusAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BildirimVatandasKarar</summary>
		internal DataColumn BildirimVatandasKararColumn 
		{
			get { return _columnBildirimVatandasKarar; }
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

	/// <summary>Typed datarow for the typed datatable ListTakip</summary>
	public partial class ListTakipRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListTakipTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListTakipRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListTakipTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field AltKonuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.AltKonuAd</remarks>
		public System.String AltKonuAd 
		{
			get { return IsAltKonuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltKonuAdColumn]; }
			set { this[_parent.AltKonuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltKonuAd is NULL, false otherwise.</summary>
		public bool IsAltKonuAdNull() 
		{
			return IsNull(_parent.AltKonuAdColumn);
		}

		/// <summary>Sets the TypedList field AltKonuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltKonuAdNull() 
		{
			this[_parent.AltKonuAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimAciklama</remarks>
		public System.String BildirimAciklama 
		{
			get { return IsBildirimAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimAciklamaColumn]; }
			set { this[_parent.BildirimAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAciklama is NULL, false otherwise.</summary>
		public bool IsBildirimAciklamaNull() 
		{
			return IsNull(_parent.BildirimAciklamaColumn);
		}

		/// <summary>Sets the TypedList field BildirimAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAciklamaNull() 
		{
			this[_parent.BildirimAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAtanmaDurumu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimAtanmaDurumu</remarks>
		public System.String BildirimAtanmaDurumu 
		{
			get { return IsBildirimAtanmaDurumuNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimAtanmaDurumuColumn]; }
			set { this[_parent.BildirimAtanmaDurumuColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtanmaDurumu is NULL, false otherwise.</summary>
		public bool IsBildirimAtanmaDurumuNull() 
		{
			return IsNull(_parent.BildirimAtanmaDurumuColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtanmaDurumu to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtanmaDurumuNull() 
		{
			this[_parent.BildirimAtanmaDurumuColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimDavaAdSoyad<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimDavaAdSoyad</remarks>
		public System.String BildirimDavaAdSoyad 
		{
			get { return IsBildirimDavaAdSoyadNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimDavaAdSoyadColumn]; }
			set { this[_parent.BildirimDavaAdSoyadColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimDavaAdSoyad is NULL, false otherwise.</summary>
		public bool IsBildirimDavaAdSoyadNull() 
		{
			return IsNull(_parent.BildirimDavaAdSoyadColumn);
		}

		/// <summary>Sets the TypedList field BildirimDavaAdSoyad to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimDavaAdSoyadNull() 
		{
			this[_parent.BildirimDavaAdSoyadColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimDavaDosyaNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimDavaDosyaNo</remarks>
		public System.String BildirimDavaDosyaNo 
		{
			get { return IsBildirimDavaDosyaNoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimDavaDosyaNoColumn]; }
			set { this[_parent.BildirimDavaDosyaNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimDavaDosyaNo is NULL, false otherwise.</summary>
		public bool IsBildirimDavaDosyaNoNull() 
		{
			return IsNull(_parent.BildirimDavaDosyaNoColumn);
		}

		/// <summary>Sets the TypedList field BildirimDavaDosyaNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimDavaDosyaNoNull() 
		{
			this[_parent.BildirimDavaDosyaNoColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimDavaKonu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimDavaKonu</remarks>
		public System.String BildirimDavaKonu 
		{
			get { return IsBildirimDavaKonuNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimDavaKonuColumn]; }
			set { this[_parent.BildirimDavaKonuColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimDavaKonu is NULL, false otherwise.</summary>
		public bool IsBildirimDavaKonuNull() 
		{
			return IsNull(_parent.BildirimDavaKonuColumn);
		}

		/// <summary>Sets the TypedList field BildirimDavaKonu to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimDavaKonuNull() 
		{
			this[_parent.BildirimDavaKonuColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimDavaMahkeme<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimDavaMahkeme</remarks>
		public System.String BildirimDavaMahkeme 
		{
			get { return IsBildirimDavaMahkemeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimDavaMahkemeColumn]; }
			set { this[_parent.BildirimDavaMahkemeColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimDavaMahkeme is NULL, false otherwise.</summary>
		public bool IsBildirimDavaMahkemeNull() 
		{
			return IsNull(_parent.BildirimDavaMahkemeColumn);
		}

		/// <summary>Sets the TypedList field BildirimDavaMahkeme to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimDavaMahkemeNull() 
		{
			this[_parent.BildirimDavaMahkemeColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimGelenYer<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimGelenYer</remarks>
		public System.String BildirimGelenYer 
		{
			get { return IsBildirimGelenYerNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimGelenYerColumn]; }
			set { this[_parent.BildirimGelenYerColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimGelenYer is NULL, false otherwise.</summary>
		public bool IsBildirimGelenYerNull() 
		{
			return IsNull(_parent.BildirimGelenYerColumn);
		}

		/// <summary>Sets the TypedList field BildirimGelenYer to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimGelenYerNull() 
		{
			this[_parent.BildirimGelenYerColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimGeriYapildiMi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimGeriYapildiMi</remarks>
		public System.Boolean BildirimGeriYapildiMi 
		{
			get { return IsBildirimGeriYapildiMiNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.BildirimGeriYapildiMiColumn]; }
			set { this[_parent.BildirimGeriYapildiMiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimGeriYapildiMi is NULL, false otherwise.</summary>
		public bool IsBildirimGeriYapildiMiNull() 
		{
			return IsNull(_parent.BildirimGeriYapildiMiColumn);
		}

		/// <summary>Sets the TypedList field BildirimGeriYapildiMi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimGeriYapildiMiNull() 
		{
			this[_parent.BildirimGeriYapildiMiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimHavalimani<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimHavalimani</remarks>
		public System.String BildirimHavalimani 
		{
			get { return IsBildirimHavalimaniNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimHavalimaniColumn]; }
			set { this[_parent.BildirimHavalimaniColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimHavalimani is NULL, false otherwise.</summary>
		public bool IsBildirimHavalimaniNull() 
		{
			return IsNull(_parent.BildirimHavalimaniColumn);
		}

		/// <summary>Sets the TypedList field BildirimHavalimani to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimHavalimaniNull() 
		{
			this[_parent.BildirimHavalimaniColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimId</remarks>
		public System.Int64 BildirimId 
		{
			get { return IsBildirimIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.BildirimIdColumn]; }
			set { this[_parent.BildirimIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimId is NULL, false otherwise.</summary>
		public bool IsBildirimIdNull() 
		{
			return IsNull(_parent.BildirimIdColumn);
		}

		/// <summary>Sets the TypedList field BildirimId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimIdNull() 
		{
			this[_parent.BildirimIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimKimBitirdi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimKimBitirdi</remarks>
		public System.Int16 BildirimKimBitirdi 
		{
			get { return IsBildirimKimBitirdiNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.BildirimKimBitirdiColumn]; }
			set { this[_parent.BildirimKimBitirdiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimKimBitirdi is NULL, false otherwise.</summary>
		public bool IsBildirimKimBitirdiNull() 
		{
			return IsNull(_parent.BildirimKimBitirdiColumn);
		}

		/// <summary>Sets the TypedList field BildirimKimBitirdi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimKimBitirdiNull() 
		{
			this[_parent.BildirimKimBitirdiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimKonuDiger<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimKonuDiger</remarks>
		public System.String BildirimKonuDiger 
		{
			get { return IsBildirimKonuDigerNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimKonuDigerColumn]; }
			set { this[_parent.BildirimKonuDigerColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimKonuDiger is NULL, false otherwise.</summary>
		public bool IsBildirimKonuDigerNull() 
		{
			return IsNull(_parent.BildirimKonuDigerColumn);
		}

		/// <summary>Sets the TypedList field BildirimKonuDiger to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimKonuDigerNull() 
		{
			this[_parent.BildirimKonuDigerColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimMetin<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimMetin</remarks>
		public System.String BildirimMetin 
		{
			get { return IsBildirimMetinNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimMetinColumn]; }
			set { this[_parent.BildirimMetinColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimMetin is NULL, false otherwise.</summary>
		public bool IsBildirimMetinNull() 
		{
			return IsNull(_parent.BildirimMetinColumn);
		}

		/// <summary>Sets the TypedList field BildirimMetin to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimMetinNull() 
		{
			this[_parent.BildirimMetinColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimSonIslemTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimSonIslemTarih</remarks>
		public System.DateTime BildirimSonIslemTarih 
		{
			get { return IsBildirimSonIslemTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BildirimSonIslemTarihColumn]; }
			set { this[_parent.BildirimSonIslemTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimSonIslemTarih is NULL, false otherwise.</summary>
		public bool IsBildirimSonIslemTarihNull() 
		{
			return IsNull(_parent.BildirimSonIslemTarihColumn);
		}

		/// <summary>Sets the TypedList field BildirimSonIslemTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimSonIslemTarihNull() 
		{
			this[_parent.BildirimSonIslemTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimTarih</remarks>
		public System.DateTime BildirimTarih 
		{
			get { return IsBildirimTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BildirimTarihColumn]; }
			set { this[_parent.BildirimTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimTarih is NULL, false otherwise.</summary>
		public bool IsBildirimTarihNull() 
		{
			return IsNull(_parent.BildirimTarihColumn);
		}

		/// <summary>Sets the TypedList field BildirimTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimTarihNull() 
		{
			this[_parent.BildirimTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimToplamSure<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimToplamSure</remarks>
		public System.String BildirimToplamSure 
		{
			get { return IsBildirimToplamSureNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimToplamSureColumn]; }
			set { this[_parent.BildirimToplamSureColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimToplamSure is NULL, false otherwise.</summary>
		public bool IsBildirimToplamSureNull() 
		{
			return IsNull(_parent.BildirimToplamSureColumn);
		}

		/// <summary>Sets the TypedList field BildirimToplamSure to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimToplamSureNull() 
		{
			this[_parent.BildirimToplamSureColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimYil<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimYil</remarks>
		public System.Int16 BildirimYil 
		{
			get { return IsBildirimYilNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.BildirimYilColumn]; }
			set { this[_parent.BildirimYilColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimYil is NULL, false otherwise.</summary>
		public bool IsBildirimYilNull() 
		{
			return IsNull(_parent.BildirimYilColumn);
		}

		/// <summary>Sets the TypedList field BildirimYil to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimYilNull() 
		{
			this[_parent.BildirimYilColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimYonlendirilenKurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimYonlendirilenKurum</remarks>
		public System.String BildirimYonlendirilenKurum 
		{
			get { return IsBildirimYonlendirilenKurumNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimYonlendirilenKurumColumn]; }
			set { this[_parent.BildirimYonlendirilenKurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimYonlendirilenKurum is NULL, false otherwise.</summary>
		public bool IsBildirimYonlendirilenKurumNull() 
		{
			return IsNull(_parent.BildirimYonlendirilenKurumColumn);
		}

		/// <summary>Sets the TypedList field BildirimYonlendirilenKurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimYonlendirilenKurumNull() 
		{
			this[_parent.BildirimYonlendirilenKurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkAltKonuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkAltKonuId</remarks>
		public System.Int64 FkAltKonuId 
		{
			get { return IsFkAltKonuIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.FkAltKonuIdColumn]; }
			set { this[_parent.FkAltKonuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkAltKonuId is NULL, false otherwise.</summary>
		public bool IsFkAltKonuIdNull() 
		{
			return IsNull(_parent.FkAltKonuIdColumn);
		}

		/// <summary>Sets the TypedList field FkAltKonuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkAltKonuIdNull() 
		{
			this[_parent.FkAltKonuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkBildirimGeriDonusId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkBildirimGeriDonusId</remarks>
		public System.Int16 FkBildirimGeriDonusId 
		{
			get { return IsFkBildirimGeriDonusIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkBildirimGeriDonusIdColumn]; }
			set { this[_parent.FkBildirimGeriDonusIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkBildirimGeriDonusId is NULL, false otherwise.</summary>
		public bool IsFkBildirimGeriDonusIdNull() 
		{
			return IsNull(_parent.FkBildirimGeriDonusIdColumn);
		}

		/// <summary>Sets the TypedList field FkBildirimGeriDonusId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkBildirimGeriDonusIdNull() 
		{
			this[_parent.FkBildirimGeriDonusIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkBildirimSonucId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkBildirimSonucId</remarks>
		public System.Int16 FkBildirimSonucId 
		{
			get { return IsFkBildirimSonucIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkBildirimSonucIdColumn]; }
			set { this[_parent.FkBildirimSonucIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkBildirimSonucId is NULL, false otherwise.</summary>
		public bool IsFkBildirimSonucIdNull() 
		{
			return IsNull(_parent.FkBildirimSonucIdColumn);
		}

		/// <summary>Sets the TypedList field FkBildirimSonucId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkBildirimSonucIdNull() 
		{
			this[_parent.FkBildirimSonucIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkBildirimTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkBildirimTuruId</remarks>
		public System.Int16 FkBildirimTuruId 
		{
			get { return IsFkBildirimTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkBildirimTuruIdColumn]; }
			set { this[_parent.FkBildirimTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkBildirimTuruId is NULL, false otherwise.</summary>
		public bool IsFkBildirimTuruIdNull() 
		{
			return IsNull(_parent.FkBildirimTuruIdColumn);
		}

		/// <summary>Sets the TypedList field FkBildirimTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkBildirimTuruIdNull() 
		{
			this[_parent.FkBildirimTuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkCagriTipiId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkCagriTipiId</remarks>
		public System.Int16 FkCagriTipiId 
		{
			get { return IsFkCagriTipiIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkCagriTipiIdColumn]; }
			set { this[_parent.FkCagriTipiIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkCagriTipiId is NULL, false otherwise.</summary>
		public bool IsFkCagriTipiIdNull() 
		{
			return IsNull(_parent.FkCagriTipiIdColumn);
		}

		/// <summary>Sets the TypedList field FkCagriTipiId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkCagriTipiIdNull() 
		{
			this[_parent.FkCagriTipiIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field FkVatandasId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.FkVatandasId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field CagriTipiAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: CagriTipi.CagriTipiAd</remarks>
		public System.String CagriTipiAd 
		{
			get { return IsCagriTipiAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CagriTipiAdColumn]; }
			set { this[_parent.CagriTipiAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field CagriTipiAd is NULL, false otherwise.</summary>
		public bool IsCagriTipiAdNull() 
		{
			return IsNull(_parent.CagriTipiAdColumn);
		}

		/// <summary>Sets the TypedList field CagriTipiAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCagriTipiAdNull() 
		{
			this[_parent.CagriTipiAdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field BildirimAtamaKullaniciBittiMi<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.BildirimAtamaKullaniciBittiMi</remarks>
		public System.Boolean BildirimAtamaKullaniciBittiMi 
		{
			get { return IsBildirimAtamaKullaniciBittiMiNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.BildirimAtamaKullaniciBittiMiColumn]; }
			set { this[_parent.BildirimAtamaKullaniciBittiMiColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtamaKullaniciBittiMi is NULL, false otherwise.</summary>
		public bool IsBildirimAtamaKullaniciBittiMiNull() 
		{
			return IsNull(_parent.BildirimAtamaKullaniciBittiMiColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtamaKullaniciBittiMi to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtamaKullaniciBittiMiNull() 
		{
			this[_parent.BildirimAtamaKullaniciBittiMiColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAtamaKullaniciBittiTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.BildirimAtamaKullaniciBittiTarih</remarks>
		public System.DateTime BildirimAtamaKullaniciBittiTarih 
		{
			get { return IsBildirimAtamaKullaniciBittiTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BildirimAtamaKullaniciBittiTarihColumn]; }
			set { this[_parent.BildirimAtamaKullaniciBittiTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtamaKullaniciBittiTarih is NULL, false otherwise.</summary>
		public bool IsBildirimAtamaKullaniciBittiTarihNull() 
		{
			return IsNull(_parent.BildirimAtamaKullaniciBittiTarihColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtamaKullaniciBittiTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtamaKullaniciBittiTarihNull() 
		{
			this[_parent.BildirimAtamaKullaniciBittiTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAtamaKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.BildirimAtamaKullaniciId</remarks>
		public System.Int64 BildirimAtamaKullaniciId 
		{
			get { return IsBildirimAtamaKullaniciIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.BildirimAtamaKullaniciIdColumn]; }
			set { this[_parent.BildirimAtamaKullaniciIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtamaKullaniciId is NULL, false otherwise.</summary>
		public bool IsBildirimAtamaKullaniciIdNull() 
		{
			return IsNull(_parent.BildirimAtamaKullaniciIdColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtamaKullaniciId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtamaKullaniciIdNull() 
		{
			this[_parent.BildirimAtamaKullaniciIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAtamaKullaniciYonMu<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.BildirimAtamaKullaniciYonMu</remarks>
		public System.String BildirimAtamaKullaniciYonMu 
		{
			get { return IsBildirimAtamaKullaniciYonMuNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimAtamaKullaniciYonMuColumn]; }
			set { this[_parent.BildirimAtamaKullaniciYonMuColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtamaKullaniciYonMu is NULL, false otherwise.</summary>
		public bool IsBildirimAtamaKullaniciYonMuNull() 
		{
			return IsNull(_parent.BildirimAtamaKullaniciYonMuColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtamaKullaniciYonMu to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtamaKullaniciYonMuNull() 
		{
			this[_parent.BildirimAtamaKullaniciYonMuColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkBildirimId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.FkBildirimId</remarks>
		public System.Int64 FkBildirimId 
		{
			get { return IsFkBildirimIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.FkBildirimIdColumn]; }
			set { this[_parent.FkBildirimIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkBildirimId is NULL, false otherwise.</summary>
		public bool IsFkBildirimIdNull() 
		{
			return IsNull(_parent.FkBildirimIdColumn);
		}

		/// <summary>Sets the TypedList field FkBildirimId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkBildirimIdNull() 
		{
			this[_parent.FkBildirimIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKonuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.FkKonuId</remarks>
		public System.Int64 FkKonuId 
		{
			get { return IsFkKonuIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.FkKonuIdColumn]; }
			set { this[_parent.FkKonuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKonuId is NULL, false otherwise.</summary>
		public bool IsFkKonuIdNull() 
		{
			return IsNull(_parent.FkKonuIdColumn);
		}

		/// <summary>Sets the TypedList field FkKonuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKonuIdNull() 
		{
			this[_parent.FkKonuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId_<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.FkKullaniciId</remarks>
		public System.Int16 FkKullaniciId_ 
		{
			get { return IsFkKullaniciId_Null() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkKullaniciId_Column]; }
			set { this[_parent.FkKullaniciId_Column] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKullaniciId_ is NULL, false otherwise.</summary>
		public bool IsFkKullaniciId_Null() 
		{
			return IsNull(_parent.FkKullaniciId_Column);
		}

		/// <summary>Sets the TypedList field FkKullaniciId_ to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKullaniciId_Null() 
		{
			this[_parent.FkKullaniciId_Column] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimSonucAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimSonuc.BildirimSonucAd</remarks>
		public System.String BildirimSonucAd 
		{
			get { return IsBildirimSonucAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimSonucAdColumn]; }
			set { this[_parent.BildirimSonucAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimSonucAd is NULL, false otherwise.</summary>
		public bool IsBildirimSonucAdNull() 
		{
			return IsNull(_parent.BildirimSonucAdColumn);
		}

		/// <summary>Sets the TypedList field BildirimSonucAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimSonucAdNull() 
		{
			this[_parent.BildirimSonucAdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field VatandasTcNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Vatanda.VatandasTcNo</remarks>
		public System.String VatandasTcNo 
		{
			get { return IsVatandasTcNoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VatandasTcNoColumn]; }
			set { this[_parent.VatandasTcNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VatandasTcNo is NULL, false otherwise.</summary>
		public bool IsVatandasTcNoNull() 
		{
			return IsNull(_parent.VatandasTcNoColumn);
		}

		/// <summary>Sets the TypedList field VatandasTcNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVatandasTcNoNull() 
		{
			this[_parent.VatandasTcNoColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field VatandasPasaportNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Vatanda.VatandasPasaportNo</remarks>
		public System.String VatandasPasaportNo 
		{
			get { return IsVatandasPasaportNoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.VatandasPasaportNoColumn]; }
			set { this[_parent.VatandasPasaportNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field VatandasPasaportNo is NULL, false otherwise.</summary>
		public bool IsVatandasPasaportNoNull() 
		{
			return IsNull(_parent.VatandasPasaportNoColumn);
		}

		/// <summary>Sets the TypedList field VatandasPasaportNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetVatandasPasaportNoNull() 
		{
			this[_parent.VatandasPasaportNoColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimAtamaKullaniciTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimAtamaKullanici.BildirimAtamaKullaniciTarih</remarks>
		public System.DateTime BildirimAtamaKullaniciTarih 
		{
			get { return IsBildirimAtamaKullaniciTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BildirimAtamaKullaniciTarihColumn]; }
			set { this[_parent.BildirimAtamaKullaniciTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimAtamaKullaniciTarih is NULL, false otherwise.</summary>
		public bool IsBildirimAtamaKullaniciTarihNull() 
		{
			return IsNull(_parent.BildirimAtamaKullaniciTarihColumn);
		}

		/// <summary>Sets the TypedList field BildirimAtamaKullaniciTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimAtamaKullaniciTarihNull() 
		{
			this[_parent.BildirimAtamaKullaniciTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimTuruAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimTuru.BildirimTuruAd</remarks>
		public System.String BildirimTuruAd 
		{
			get { return IsBildirimTuruAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimTuruAdColumn]; }
			set { this[_parent.BildirimTuruAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimTuruAd is NULL, false otherwise.</summary>
		public bool IsBildirimTuruAdNull() 
		{
			return IsNull(_parent.BildirimTuruAdColumn);
		}

		/// <summary>Sets the TypedList field BildirimTuruAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimTuruAdNull() 
		{
			this[_parent.BildirimTuruAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimGeriDonusAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BildirimGeriDonu.BildirimGeriDonusAd</remarks>
		public System.String BildirimGeriDonusAd 
		{
			get { return IsBildirimGeriDonusAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimGeriDonusAdColumn]; }
			set { this[_parent.BildirimGeriDonusAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimGeriDonusAd is NULL, false otherwise.</summary>
		public bool IsBildirimGeriDonusAdNull() 
		{
			return IsNull(_parent.BildirimGeriDonusAdColumn);
		}

		/// <summary>Sets the TypedList field BildirimGeriDonusAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimGeriDonusAdNull() 
		{
			this[_parent.BildirimGeriDonusAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BildirimVatandasKarar<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Bildirim.BildirimVatandasKarar</remarks>
		public System.String BildirimVatandasKarar 
		{
			get { return IsBildirimVatandasKararNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BildirimVatandasKararColumn]; }
			set { this[_parent.BildirimVatandasKararColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BildirimVatandasKarar is NULL, false otherwise.</summary>
		public bool IsBildirimVatandasKararNull() 
		{
			return IsNull(_parent.BildirimVatandasKararColumn);
		}

		/// <summary>Sets the TypedList field BildirimVatandasKarar to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBildirimVatandasKararNull() 
		{
			this[_parent.BildirimVatandasKararColumn] = System.Convert.DBNull;
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
