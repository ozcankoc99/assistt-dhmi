///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:33
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (74 + 0));
			InitAcikBildirimEntityInfos();
			InitAcikBildirimAyrintiEntityInfos();
			InitAltAltMenuEntityInfos();
			InitAltKarakterEntityInfos();
			InitAltKonuEntityInfos();
			InitAltMenuEntityInfos();
			InitBaskanlikEntityInfos();
			InitBildirimEntityInfos();
			InitBildirimAtamaGrupEntityInfos();
			InitBildirimAtamaKullaniciEntityInfos();
			InitBildirimGeriDonuEntityInfos();
			InitBildirimHistoryEntityInfos();
			InitBildirimIslemEntityInfos();
			InitBildirimSonucEntityInfos();
			InitBildirimTuruEntityInfos();
			InitBilgiBankasiEntityInfos();
			InitBilgiBankasiTurEntityInfos();
			InitBilgilendirmeEntityInfos();
			InitCagriMerkezEntityInfos();
			InitCagriTipiEntityInfos();
			InitDigerBirimlerEntityInfos();
			InitDigerBirimlerAyrintiEntityInfos();
			InitDosyaEntityInfos();
			InitDuyuruEntityInfos();
			InitEkSureEntityInfos();
			InitGecenSureEntityInfos();
			InitGizliSoruTuruEntityInfos();
			InitGorevEntityInfos();
			InitGrupEntityInfos();
			InitGrupAtamaEntityInfos();
			InitHavalimaniEntityInfos();
			InitHiyerarsiTurEntityInfos();
			InitIlEntityInfos();
			InitIpBankEntityInfos();
			InitIslemEntityInfos();
			InitIslemOlusturEntityInfos();
			InitIslemTuruEntityInfos();
			InitIstatistikEntityInfos();
			InitKapatmaTurEntityInfos();
			InitKarakterEntityInfos();
			InitKaraListeEntityInfos();
			InitKonuEntityInfos();
			InitKonusalDagilimEntityInfos();
			InitKopukCagriEntityInfos();
			InitKopukCagriTuruEntityInfos();
			InitKpsArsivEntityInfos();
			InitKpsBilgiEntityInfos();
			InitKullaniciEntityInfos();
			InitKulTcNoEntityInfos();
			InitLogEntityInfos();
			InitLogEmailEntityInfos();
			InitLogHataEntityInfos();
			InitLogIslemEntityInfos();
			InitLogSmEntityInfos();
			InitMailBankEntityInfos();
			InitMenuEntityInfos();
			InitMenuOlusturEntityInfos();
			InitMesajEntityInfos();
			InitParametreEntityInfos();
			InitParametreGenelArsivEntityInfos();
			InitParametreTurEntityInfos();
			InitRaporIcerikEntityInfos();
			InitRaporTuruEntityInfos();
			InitRaporYetkiEntityInfos();
			InitSorunEntityInfos();
			InitSorunTuruEntityInfos();
			InitSureTakipEntityInfos();
			InitTurBankEntityInfos();
			InitVatandaEntityInfos();
			InitVatandasArsivEntityInfos();
			InitVipListeEntityInfos();
			InitWebServiEntityInfos();
			InitYetkiEntityInfos();
			InitZamanEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AcikBildirimEntity's FieldInfo objects</summary>
		private void InitAcikBildirimEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AcikBildirimFieldIndex), "AcikBildirimEntity");
			this.AddElementFieldInfo("AcikBildirimEntity", "AcikBildirimAtandiSayi", typeof(System.Int16), false, false, false, false,  (int)AcikBildirimFieldIndex.AcikBildirimAtandiSayi, 0, 0, 5);
			this.AddElementFieldInfo("AcikBildirimEntity", "AcikBildirimBirim", typeof(System.String), false, false, false, false,  (int)AcikBildirimFieldIndex.AcikBildirimBirim, 100, 0, 0);
			this.AddElementFieldInfo("AcikBildirimEntity", "AcikBildirimId", typeof(System.Int64), true, false, true, false,  (int)AcikBildirimFieldIndex.AcikBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("AcikBildirimEntity", "AcikBildirimInceleniyorEkSureSayi", typeof(System.Int16), false, false, false, false,  (int)AcikBildirimFieldIndex.AcikBildirimInceleniyorEkSureSayi, 0, 0, 5);
			this.AddElementFieldInfo("AcikBildirimEntity", "AcikBildirimInceleniyorSayi", typeof(System.Int16), false, false, false, false,  (int)AcikBildirimFieldIndex.AcikBildirimInceleniyorSayi, 0, 0, 5);
		}
		/// <summary>Inits AcikBildirimAyrintiEntity's FieldInfo objects</summary>
		private void InitAcikBildirimAyrintiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AcikBildirimAyrintiFieldIndex), "AcikBildirimAyrintiEntity");
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiBirim", typeof(System.String), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiBirim, 100, 0, 0);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiDurum", typeof(System.String), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiDurum, 25, 0, 0);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiIcerik", typeof(System.String), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiIcerik, 2147483647, 0, 0);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiId", typeof(System.Int64), true, false, true, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiId, 0, 0, 19);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiNo", typeof(System.Int64), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiNo, 0, 0, 19);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiSonDurum", typeof(System.String), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiSonDurum, 2147483647, 0, 0);
			this.AddElementFieldInfo("AcikBildirimAyrintiEntity", "AcikBildirimAyrintiSure", typeof(System.String), false, false, false, false,  (int)AcikBildirimAyrintiFieldIndex.AcikBildirimAyrintiSure, 50, 0, 0);
		}
		/// <summary>Inits AltAltMenuEntity's FieldInfo objects</summary>
		private void InitAltAltMenuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AltAltMenuFieldIndex), "AltAltMenuEntity");
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuAciklama", typeof(System.String), false, false, false, true,  (int)AltAltMenuFieldIndex.AltAltMenuAciklama, 250, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuAd", typeof(System.String), false, false, false, false,  (int)AltAltMenuFieldIndex.AltAltMenuAd, 50, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuDurum", typeof(System.Boolean), false, false, false, false,  (int)AltAltMenuFieldIndex.AltAltMenuDurum, 0, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuId", typeof(System.Int16), true, false, true, false,  (int)AltAltMenuFieldIndex.AltAltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuLink", typeof(System.String), false, false, false, false,  (int)AltAltMenuFieldIndex.AltAltMenuLink, 100, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuSira", typeof(System.Int16), false, false, false, false,  (int)AltAltMenuFieldIndex.AltAltMenuSira, 0, 0, 5);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuSonLink", typeof(System.String), false, false, false, true,  (int)AltAltMenuFieldIndex.AltAltMenuSonLink, 150, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "AltAltMenuTarih", typeof(System.DateTime), false, false, false, false,  (int)AltAltMenuFieldIndex.AltAltMenuTarih, 0, 0, 0);
			this.AddElementFieldInfo("AltAltMenuEntity", "FkAltMenuId", typeof(System.Int16), false, true, false, false,  (int)AltAltMenuFieldIndex.FkAltMenuId, 0, 0, 5);
		}
		/// <summary>Inits AltKarakterEntity's FieldInfo objects</summary>
		private void InitAltKarakterEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AltKarakterFieldIndex), "AltKarakterEntity");
			this.AddElementFieldInfo("AltKarakterEntity", "AltKarakterAd", typeof(System.String), false, false, false, false,  (int)AltKarakterFieldIndex.AltKarakterAd, 1, 0, 0);
			this.AddElementFieldInfo("AltKarakterEntity", "AltKarakterId", typeof(System.Int16), true, false, true, false,  (int)AltKarakterFieldIndex.AltKarakterId, 0, 0, 5);
			this.AddElementFieldInfo("AltKarakterEntity", "AltKarakterNo", typeof(System.String), false, false, false, false,  (int)AltKarakterFieldIndex.AltKarakterNo, 1, 0, 0);
		}
		/// <summary>Inits AltKonuEntity's FieldInfo objects</summary>
		private void InitAltKonuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AltKonuFieldIndex), "AltKonuEntity");
			this.AddElementFieldInfo("AltKonuEntity", "AltKonuAd", typeof(System.String), false, false, false, false,  (int)AltKonuFieldIndex.AltKonuAd, 150, 0, 0);
			this.AddElementFieldInfo("AltKonuEntity", "AltKonuDurum", typeof(System.Boolean), false, false, false, false,  (int)AltKonuFieldIndex.AltKonuDurum, 0, 0, 0);
			this.AddElementFieldInfo("AltKonuEntity", "AltKonuId", typeof(System.Int64), true, false, true, false,  (int)AltKonuFieldIndex.AltKonuId, 0, 0, 19);
			this.AddElementFieldInfo("AltKonuEntity", "AltKonuTarih", typeof(System.DateTime), false, false, false, false,  (int)AltKonuFieldIndex.AltKonuTarih, 0, 0, 0);
			this.AddElementFieldInfo("AltKonuEntity", "FkKonuId", typeof(System.Int64), false, true, false, false,  (int)AltKonuFieldIndex.FkKonuId, 0, 0, 19);
		}
		/// <summary>Inits AltMenuEntity's FieldInfo objects</summary>
		private void InitAltMenuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AltMenuFieldIndex), "AltMenuEntity");
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuAciklama", typeof(System.String), false, false, false, true,  (int)AltMenuFieldIndex.AltMenuAciklama, 250, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuAd", typeof(System.String), false, false, false, false,  (int)AltMenuFieldIndex.AltMenuAd, 50, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuDurum", typeof(System.Boolean), false, false, false, false,  (int)AltMenuFieldIndex.AltMenuDurum, 0, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuId", typeof(System.Int16), true, false, true, false,  (int)AltMenuFieldIndex.AltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuLink", typeof(System.String), false, false, false, false,  (int)AltMenuFieldIndex.AltMenuLink, 100, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuSira", typeof(System.Int16), false, false, false, false,  (int)AltMenuFieldIndex.AltMenuSira, 0, 0, 5);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuSonLink", typeof(System.String), false, false, false, true,  (int)AltMenuFieldIndex.AltMenuSonLink, 150, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "AltMenuTarih", typeof(System.DateTime), false, false, false, false,  (int)AltMenuFieldIndex.AltMenuTarih, 0, 0, 0);
			this.AddElementFieldInfo("AltMenuEntity", "FkMenuId", typeof(System.Int16), false, true, false, false,  (int)AltMenuFieldIndex.FkMenuId, 0, 0, 5);
		}
		/// <summary>Inits BaskanlikEntity's FieldInfo objects</summary>
		private void InitBaskanlikEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BaskanlikFieldIndex), "BaskanlikEntity");
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikAd", typeof(System.String), false, false, false, false,  (int)BaskanlikFieldIndex.BaskanlikAd, 250, 0, 0);
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikAlt", typeof(System.String), false, false, false, false,  (int)BaskanlikFieldIndex.BaskanlikAlt, 250, 0, 0);
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikCanliAd", typeof(System.String), false, false, false, true,  (int)BaskanlikFieldIndex.BaskanlikCanliAd, 250, 0, 0);
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikId", typeof(System.Int64), true, false, true, false,  (int)BaskanlikFieldIndex.BaskanlikId, 0, 0, 19);
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikKullaniciId", typeof(System.Int16), false, false, false, false,  (int)BaskanlikFieldIndex.BaskanlikKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("BaskanlikEntity", "BaskanlikSol", typeof(System.Double), false, false, false, false,  (int)BaskanlikFieldIndex.BaskanlikSol, 0, 0, 38);
		}
		/// <summary>Inits BildirimEntity's FieldInfo objects</summary>
		private void InitBildirimEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimFieldIndex), "BildirimEntity");
			this.AddElementFieldInfo("BildirimEntity", "BildirimAciklama", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimAciklama, 2147483647, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimAtanmaDurumu", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimAtanmaDurumu, 2147483647, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimDavaAdSoyad", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimDavaAdSoyad, 100, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimDavaDosyaNo", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimDavaDosyaNo, 20, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimDavaKonu", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimDavaKonu, 2147483647, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimDavaMahkeme", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimDavaMahkeme, 250, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimGelenYer", typeof(System.String), false, false, false, false,  (int)BildirimFieldIndex.BildirimGelenYer, 20, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimGeriYapildiMi", typeof(System.Boolean), false, false, false, false,  (int)BildirimFieldIndex.BildirimGeriYapildiMi, 0, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimHavalimani", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimHavalimani, 100, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimId", typeof(System.Int64), true, false, true, false,  (int)BildirimFieldIndex.BildirimId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimEntity", "BildirimKimBitirdi", typeof(Nullable<System.Int16>), false, false, false, true,  (int)BildirimFieldIndex.BildirimKimBitirdi, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "BildirimKonuDiger", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimKonuDiger, 500, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimMetin", typeof(System.String), false, false, false, false,  (int)BildirimFieldIndex.BildirimMetin, 2147483647, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimSonIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimFieldIndex.BildirimSonIslemTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimFieldIndex.BildirimTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimToplamSure", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimToplamSure, 50, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimVatandasKarar", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimVatandasKarar, 2147483647, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "BildirimYil", typeof(System.Int16), false, false, false, false,  (int)BildirimFieldIndex.BildirimYil, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "BildirimYonlendirilenKurum", typeof(System.String), false, false, false, true,  (int)BildirimFieldIndex.BildirimYonlendirilenKurum, 150, 0, 0);
			this.AddElementFieldInfo("BildirimEntity", "FkAltKonuId", typeof(System.Int64), false, true, false, false,  (int)BildirimFieldIndex.FkAltKonuId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimEntity", "FkBildirimGeriDonusId", typeof(System.Int16), false, true, false, false,  (int)BildirimFieldIndex.FkBildirimGeriDonusId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "FkBildirimSonucId", typeof(System.Int16), false, true, false, false,  (int)BildirimFieldIndex.FkBildirimSonucId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "FkBildirimTuruId", typeof(System.Int16), false, true, false, false,  (int)BildirimFieldIndex.FkBildirimTuruId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "FkCagriTipiId", typeof(System.Int16), false, true, false, false,  (int)BildirimFieldIndex.FkCagriTipiId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)BildirimFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimEntity", "FkVatandasId", typeof(System.Int64), false, true, false, false,  (int)BildirimFieldIndex.FkVatandasId, 0, 0, 19);
		}
		/// <summary>Inits BildirimAtamaGrupEntity's FieldInfo objects</summary>
		private void InitBildirimAtamaGrupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimAtamaGrupFieldIndex), "BildirimAtamaGrupEntity");
			this.AddElementFieldInfo("BildirimAtamaGrupEntity", "BildirimAtamaGrupId", typeof(System.Int64), true, false, true, false,  (int)BildirimAtamaGrupFieldIndex.BildirimAtamaGrupId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimAtamaGrupEntity", "BildirimAtamaGrupTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimAtamaGrupFieldIndex.BildirimAtamaGrupTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaGrupEntity", "BildirimAtamaGrupYonMu", typeof(System.String), false, false, false, true,  (int)BildirimAtamaGrupFieldIndex.BildirimAtamaGrupYonMu, 10, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaGrupEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)BildirimAtamaGrupFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimAtamaGrupEntity", "FkGrupId", typeof(System.Int16), false, true, false, false,  (int)BildirimAtamaGrupFieldIndex.FkGrupId, 0, 0, 5);
		}
		/// <summary>Inits BildirimAtamaKullaniciEntity's FieldInfo objects</summary>
		private void InitBildirimAtamaKullaniciEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimAtamaKullaniciFieldIndex), "BildirimAtamaKullaniciEntity");
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciBittiMi", typeof(System.Boolean), false, false, false, false,  (int)BildirimAtamaKullaniciFieldIndex.BildirimAtamaKullaniciBittiMi, 0, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciBittiTarih", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BildirimAtamaKullaniciFieldIndex.BildirimAtamaKullaniciBittiTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciId", typeof(System.Int64), true, false, true, false,  (int)BildirimAtamaKullaniciFieldIndex.BildirimAtamaKullaniciId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimAtamaKullaniciFieldIndex.BildirimAtamaKullaniciTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciYonMu", typeof(System.String), false, false, false, true,  (int)BildirimAtamaKullaniciFieldIndex.BildirimAtamaKullaniciYonMu, 10, 0, 0);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)BildirimAtamaKullaniciFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimAtamaKullaniciEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)BildirimAtamaKullaniciFieldIndex.FkKullaniciId, 0, 0, 5);
		}
		/// <summary>Inits BildirimGeriDonuEntity's FieldInfo objects</summary>
		private void InitBildirimGeriDonuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimGeriDonuFieldIndex), "BildirimGeriDonuEntity");
			this.AddElementFieldInfo("BildirimGeriDonuEntity", "BildirimGeriDonusAd", typeof(System.String), false, false, false, false,  (int)BildirimGeriDonuFieldIndex.BildirimGeriDonusAd, 50, 0, 0);
			this.AddElementFieldInfo("BildirimGeriDonuEntity", "BildirimGeriDonusId", typeof(System.Int16), true, false, true, false,  (int)BildirimGeriDonuFieldIndex.BildirimGeriDonusId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimGeriDonuEntity", "BildirimGeriDonusTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimGeriDonuFieldIndex.BildirimGeriDonusTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimGeriDonuEntity", "BildirimGeriDonusTur", typeof(System.Boolean), false, false, false, false,  (int)BildirimGeriDonuFieldIndex.BildirimGeriDonusTur, 0, 0, 0);
		}
		/// <summary>Inits BildirimHistoryEntity's FieldInfo objects</summary>
		private void InitBildirimHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimHistoryFieldIndex), "BildirimHistoryEntity");
			this.AddElementFieldInfo("BildirimHistoryEntity", "BildirimHistoryAciklama", typeof(System.String), false, false, false, false,  (int)BildirimHistoryFieldIndex.BildirimHistoryAciklama, 2000, 0, 0);
			this.AddElementFieldInfo("BildirimHistoryEntity", "BildirimHistoryId", typeof(System.Int64), true, false, true, false,  (int)BildirimHistoryFieldIndex.BildirimHistoryId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimHistoryEntity", "BildirimHistorySure", typeof(System.String), false, false, false, false,  (int)BildirimHistoryFieldIndex.BildirimHistorySure, 50, 0, 0);
			this.AddElementFieldInfo("BildirimHistoryEntity", "BildirimHistoryTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimHistoryFieldIndex.BildirimHistoryTarih, 0, 0, 0);
			this.AddElementFieldInfo("BildirimHistoryEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)BildirimHistoryFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("BildirimHistoryEntity", "FkBildirimIslemId", typeof(System.Int16), false, true, false, false,  (int)BildirimHistoryFieldIndex.FkBildirimIslemId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimHistoryEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)BildirimHistoryFieldIndex.FkKullaniciId, 0, 0, 5);
		}
		/// <summary>Inits BildirimIslemEntity's FieldInfo objects</summary>
		private void InitBildirimIslemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimIslemFieldIndex), "BildirimIslemEntity");
			this.AddElementFieldInfo("BildirimIslemEntity", "BildirimIslemAd", typeof(System.String), false, false, false, false,  (int)BildirimIslemFieldIndex.BildirimIslemAd, 100, 0, 0);
			this.AddElementFieldInfo("BildirimIslemEntity", "BildirimIslemDurum", typeof(System.Boolean), false, false, false, false,  (int)BildirimIslemFieldIndex.BildirimIslemDurum, 0, 0, 0);
			this.AddElementFieldInfo("BildirimIslemEntity", "BildirimIslemId", typeof(System.Int16), true, false, true, false,  (int)BildirimIslemFieldIndex.BildirimIslemId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimIslemEntity", "BildirimIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimIslemFieldIndex.BildirimIslemTarih, 0, 0, 0);
		}
		/// <summary>Inits BildirimSonucEntity's FieldInfo objects</summary>
		private void InitBildirimSonucEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimSonucFieldIndex), "BildirimSonucEntity");
			this.AddElementFieldInfo("BildirimSonucEntity", "BildirimSonucAd", typeof(System.String), false, false, false, false,  (int)BildirimSonucFieldIndex.BildirimSonucAd, 50, 0, 0);
			this.AddElementFieldInfo("BildirimSonucEntity", "BildirimSonucDurum", typeof(System.Boolean), false, false, false, false,  (int)BildirimSonucFieldIndex.BildirimSonucDurum, 0, 0, 0);
			this.AddElementFieldInfo("BildirimSonucEntity", "BildirimSonucId", typeof(System.Int16), true, false, true, false,  (int)BildirimSonucFieldIndex.BildirimSonucId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimSonucEntity", "BildirimSonucTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimSonucFieldIndex.BildirimSonucTarih, 0, 0, 0);
		}
		/// <summary>Inits BildirimTuruEntity's FieldInfo objects</summary>
		private void InitBildirimTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BildirimTuruFieldIndex), "BildirimTuruEntity");
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruAd", typeof(System.String), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruAd, 100, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruIcerik", typeof(System.Boolean), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruIcerik, 0, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruId", typeof(System.Int16), true, false, true, false,  (int)BildirimTuruFieldIndex.BildirimTuruId, 0, 0, 5);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruIncelemeSaatZaman", typeof(System.Int64), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruIncelemeSaatZaman, 0, 0, 19);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruInclemeSure", typeof(System.String), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruInclemeSure, 50, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruIslemAlSaatZaman", typeof(System.Int64), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruIslemAlSaatZaman, 0, 0, 19);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruIslemAlSure", typeof(System.String), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruIslemAlSure, 50, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruMail", typeof(System.Boolean), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruMail, 0, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruSms", typeof(System.Boolean), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruSms, 0, 0, 0);
			this.AddElementFieldInfo("BildirimTuruEntity", "BildirimTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)BildirimTuruFieldIndex.BildirimTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits BilgiBankasiEntity's FieldInfo objects</summary>
		private void InitBilgiBankasiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BilgiBankasiFieldIndex), "BilgiBankasiEntity");
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiAd", typeof(System.String), false, false, false, false,  (int)BilgiBankasiFieldIndex.BilgiBankasiAd, 350, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiDosya", typeof(System.String), false, false, false, true,  (int)BilgiBankasiFieldIndex.BilgiBankasiDosya, 150, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiEtiket", typeof(System.String), false, false, false, true,  (int)BilgiBankasiFieldIndex.BilgiBankasiEtiket, 250, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiIcerik", typeof(System.String), false, false, false, false,  (int)BilgiBankasiFieldIndex.BilgiBankasiIcerik, 2147483647, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiId", typeof(System.Int16), true, false, true, false,  (int)BilgiBankasiFieldIndex.BilgiBankasiId, 0, 0, 5);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiSira", typeof(System.Int16), false, false, false, false,  (int)BilgiBankasiFieldIndex.BilgiBankasiSira, 0, 0, 5);
			this.AddElementFieldInfo("BilgiBankasiEntity", "BilgiBankasiTarih", typeof(System.DateTime), false, false, false, false,  (int)BilgiBankasiFieldIndex.BilgiBankasiTarih, 0, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiEntity", "FkBilgiBankasiTurId", typeof(System.Int16), false, true, false, false,  (int)BilgiBankasiFieldIndex.FkBilgiBankasiTurId, 0, 0, 5);
		}
		/// <summary>Inits BilgiBankasiTurEntity's FieldInfo objects</summary>
		private void InitBilgiBankasiTurEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BilgiBankasiTurFieldIndex), "BilgiBankasiTurEntity");
			this.AddElementFieldInfo("BilgiBankasiTurEntity", "BilgiBankasiTurAd", typeof(System.String), false, false, false, false,  (int)BilgiBankasiTurFieldIndex.BilgiBankasiTurAd, 100, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiTurEntity", "BilgiBankasiTurDurum", typeof(System.Boolean), false, false, false, false,  (int)BilgiBankasiTurFieldIndex.BilgiBankasiTurDurum, 0, 0, 0);
			this.AddElementFieldInfo("BilgiBankasiTurEntity", "BilgiBankasiTurId", typeof(System.Int16), true, false, true, false,  (int)BilgiBankasiTurFieldIndex.BilgiBankasiTurId, 0, 0, 5);
			this.AddElementFieldInfo("BilgiBankasiTurEntity", "BilgiBankasiTurTarih", typeof(System.DateTime), false, false, false, false,  (int)BilgiBankasiTurFieldIndex.BilgiBankasiTurTarih, 0, 0, 0);
		}
		/// <summary>Inits BilgilendirmeEntity's FieldInfo objects</summary>
		private void InitBilgilendirmeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BilgilendirmeFieldIndex), "BilgilendirmeEntity");
			this.AddElementFieldInfo("BilgilendirmeEntity", "BilgilendirmeGelenKullanici", typeof(System.String), false, false, false, false,  (int)BilgilendirmeFieldIndex.BilgilendirmeGelenKullanici, 75, 0, 0);
			this.AddElementFieldInfo("BilgilendirmeEntity", "BilgilendirmeGidenKullanici", typeof(System.String), false, false, false, false,  (int)BilgilendirmeFieldIndex.BilgilendirmeGidenKullanici, 75, 0, 0);
			this.AddElementFieldInfo("BilgilendirmeEntity", "BilgilendirmeIcerik", typeof(System.String), false, false, false, false,  (int)BilgilendirmeFieldIndex.BilgilendirmeIcerik, 200, 0, 0);
			this.AddElementFieldInfo("BilgilendirmeEntity", "BilgilendirmeId", typeof(System.Int64), true, false, true, false,  (int)BilgilendirmeFieldIndex.BilgilendirmeId, 0, 0, 19);
			this.AddElementFieldInfo("BilgilendirmeEntity", "BilgilendirmeTarih", typeof(System.DateTime), false, false, false, false,  (int)BilgilendirmeFieldIndex.BilgilendirmeTarih, 0, 0, 0);
		}
		/// <summary>Inits CagriMerkezEntity's FieldInfo objects</summary>
		private void InitCagriMerkezEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CagriMerkezFieldIndex), "CagriMerkezEntity");
			this.AddElementFieldInfo("CagriMerkezEntity", "CagriMerkezDurum", typeof(System.Boolean), false, false, false, false,  (int)CagriMerkezFieldIndex.CagriMerkezDurum, 0, 0, 0);
			this.AddElementFieldInfo("CagriMerkezEntity", "CagriMerkezId", typeof(System.Int16), true, false, true, false,  (int)CagriMerkezFieldIndex.CagriMerkezId, 0, 0, 5);
			this.AddElementFieldInfo("CagriMerkezEntity", "CagriMerkezNo", typeof(System.String), false, false, false, false,  (int)CagriMerkezFieldIndex.CagriMerkezNo, 50, 0, 0);
			this.AddElementFieldInfo("CagriMerkezEntity", "CagriMerkezTarih", typeof(System.DateTime), false, false, false, false,  (int)CagriMerkezFieldIndex.CagriMerkezTarih, 0, 0, 0);
		}
		/// <summary>Inits CagriTipiEntity's FieldInfo objects</summary>
		private void InitCagriTipiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CagriTipiFieldIndex), "CagriTipiEntity");
			this.AddElementFieldInfo("CagriTipiEntity", "CagriTipiAd", typeof(System.String), false, false, false, false,  (int)CagriTipiFieldIndex.CagriTipiAd, 75, 0, 0);
			this.AddElementFieldInfo("CagriTipiEntity", "CagriTipiDurum", typeof(System.Boolean), false, false, false, false,  (int)CagriTipiFieldIndex.CagriTipiDurum, 0, 0, 0);
			this.AddElementFieldInfo("CagriTipiEntity", "CagriTipiId", typeof(System.Int16), true, false, true, false,  (int)CagriTipiFieldIndex.CagriTipiId, 0, 0, 5);
			this.AddElementFieldInfo("CagriTipiEntity", "CagriTipiTarih", typeof(System.DateTime), false, false, false, false,  (int)CagriTipiFieldIndex.CagriTipiTarih, 0, 0, 0);
		}
		/// <summary>Inits DigerBirimlerEntity's FieldInfo objects</summary>
		private void InitDigerBirimlerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DigerBirimlerFieldIndex), "DigerBirimlerEntity");
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerAtandiSayi", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerAtandiSayi, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerBirim", typeof(System.String), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerBirim, 250, 0, 0);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerId", typeof(System.Int64), true, false, true, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerId, 0, 0, 19);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerInceleniyorEkSureSayi", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerInceleniyorEkSureSayi, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerInceleniyorSayi", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerInceleniyorSayi, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerKullaniciId", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerReddedildiSayi", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerReddedildiSayi, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerEntity", "DigerBirimlerSonuclandiSayi", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerFieldIndex.DigerBirimlerSonuclandiSayi, 0, 0, 5);
		}
		/// <summary>Inits DigerBirimlerAyrintiEntity's FieldInfo objects</summary>
		private void InitDigerBirimlerAyrintiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DigerBirimlerAyrintiFieldIndex), "DigerBirimlerAyrintiEntity");
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiDurum", typeof(System.String), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiDurum, 25, 0, 0);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiIcerik", typeof(System.String), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiIcerik, 2147483647, 0, 0);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiId", typeof(System.Int64), true, false, true, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiId, 0, 0, 19);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiKullaniciId", typeof(System.Int16), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiNo", typeof(System.Int64), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiNo, 0, 0, 19);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiSonDurum", typeof(System.String), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSonDurum, 2147483647, 0, 0);
			this.AddElementFieldInfo("DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiSure", typeof(System.String), false, false, false, false,  (int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSure, 50, 0, 0);
		}
		/// <summary>Inits DosyaEntity's FieldInfo objects</summary>
		private void InitDosyaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DosyaFieldIndex), "DosyaEntity");
			this.AddElementFieldInfo("DosyaEntity", "DosyaBildirimi", typeof(System.Int64), false, false, false, false,  (int)DosyaFieldIndex.DosyaBildirimi, 0, 0, 19);
			this.AddElementFieldInfo("DosyaEntity", "DosyaIcerikDurum", typeof(System.String), false, false, false, false,  (int)DosyaFieldIndex.DosyaIcerikDurum, 10, 0, 0);
			this.AddElementFieldInfo("DosyaEntity", "DosyaIcerikPath", typeof(System.String), false, false, false, false,  (int)DosyaFieldIndex.DosyaIcerikPath, 150, 0, 0);
			this.AddElementFieldInfo("DosyaEntity", "DosyaIcerikTarih", typeof(System.DateTime), false, false, false, false,  (int)DosyaFieldIndex.DosyaIcerikTarih, 0, 0, 0);
			this.AddElementFieldInfo("DosyaEntity", "DosyaId", typeof(System.Int64), true, false, true, false,  (int)DosyaFieldIndex.DosyaId, 0, 0, 19);
		}
		/// <summary>Inits DuyuruEntity's FieldInfo objects</summary>
		private void InitDuyuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DuyuruFieldIndex), "DuyuruEntity");
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruBaslik", typeof(System.String), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruBaslik, 250, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruDurum", typeof(System.Boolean), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruIcerik", typeof(System.String), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruIcerik, 2147483647, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruId", typeof(System.Int16), true, false, true, false,  (int)DuyuruFieldIndex.DuyuruId, 0, 0, 5);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruLink", typeof(System.String), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruLink, 150, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruResim", typeof(System.String), false, false, false, true,  (int)DuyuruFieldIndex.DuyuruResim, 150, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruTarih", typeof(System.DateTime), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruTarih, 0, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "DuyuruYayinTarih", typeof(System.DateTime), false, false, false, false,  (int)DuyuruFieldIndex.DuyuruYayinTarih, 0, 0, 0);
			this.AddElementFieldInfo("DuyuruEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)DuyuruFieldIndex.FkKullaniciId, 0, 0, 5);
		}
		/// <summary>Inits EkSureEntity's FieldInfo objects</summary>
		private void InitEkSureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EkSureFieldIndex), "EkSureEntity");
			this.AddElementFieldInfo("EkSureEntity", "EkSureGun", typeof(System.Int16), false, false, false, false,  (int)EkSureFieldIndex.EkSureGun, 0, 0, 5);
			this.AddElementFieldInfo("EkSureEntity", "EkSureId", typeof(System.Int64), true, false, true, false,  (int)EkSureFieldIndex.EkSureId, 0, 0, 19);
			this.AddElementFieldInfo("EkSureEntity", "EkSureSaat", typeof(System.Int16), false, false, false, false,  (int)EkSureFieldIndex.EkSureSaat, 0, 0, 5);
			this.AddElementFieldInfo("EkSureEntity", "EkSureTarih", typeof(System.DateTime), false, false, false, false,  (int)EkSureFieldIndex.EkSureTarih, 0, 0, 0);
			this.AddElementFieldInfo("EkSureEntity", "EkSureTotal", typeof(System.Int16), false, false, false, false,  (int)EkSureFieldIndex.EkSureTotal, 0, 0, 5);
			this.AddElementFieldInfo("EkSureEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)EkSureFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("EkSureEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)EkSureFieldIndex.FkKullaniciId, 0, 0, 5);
		}
		/// <summary>Inits GecenSureEntity's FieldInfo objects</summary>
		private void InitGecenSureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GecenSureFieldIndex), "GecenSureEntity");
			this.AddElementFieldInfo("GecenSureEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)GecenSureFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("GecenSureEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)GecenSureFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("GecenSureEntity", "GecenSureAciklama", typeof(System.String), false, false, false, false,  (int)GecenSureFieldIndex.GecenSureAciklama, 50, 0, 0);
			this.AddElementFieldInfo("GecenSureEntity", "GecenSureId", typeof(System.Int64), true, false, true, false,  (int)GecenSureFieldIndex.GecenSureId, 0, 0, 19);
			this.AddElementFieldInfo("GecenSureEntity", "GecenSureTarih", typeof(System.DateTime), false, false, false, false,  (int)GecenSureFieldIndex.GecenSureTarih, 0, 0, 0);
			this.AddElementFieldInfo("GecenSureEntity", "GecenSureTotal", typeof(System.Int16), false, false, false, false,  (int)GecenSureFieldIndex.GecenSureTotal, 0, 0, 5);
			this.AddElementFieldInfo("GecenSureEntity", "GecenSureZaman", typeof(System.String), false, false, false, false,  (int)GecenSureFieldIndex.GecenSureZaman, 50, 0, 0);
		}
		/// <summary>Inits GizliSoruTuruEntity's FieldInfo objects</summary>
		private void InitGizliSoruTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GizliSoruTuruFieldIndex), "GizliSoruTuruEntity");
			this.AddElementFieldInfo("GizliSoruTuruEntity", "GizliSoruTuruAd", typeof(System.String), false, false, false, false,  (int)GizliSoruTuruFieldIndex.GizliSoruTuruAd, 50, 0, 0);
			this.AddElementFieldInfo("GizliSoruTuruEntity", "GizliSoruTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)GizliSoruTuruFieldIndex.GizliSoruTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("GizliSoruTuruEntity", "GizliSoruTuruId", typeof(System.Int16), true, false, true, false,  (int)GizliSoruTuruFieldIndex.GizliSoruTuruId, 0, 0, 5);
			this.AddElementFieldInfo("GizliSoruTuruEntity", "GizliSoruTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)GizliSoruTuruFieldIndex.GizliSoruTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits GorevEntity's FieldInfo objects</summary>
		private void InitGorevEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GorevFieldIndex), "GorevEntity");
			this.AddElementFieldInfo("GorevEntity", "GorevAd", typeof(System.String), false, false, false, false,  (int)GorevFieldIndex.GorevAd, 100, 0, 0);
			this.AddElementFieldInfo("GorevEntity", "GorevDurum", typeof(System.Boolean), false, false, false, false,  (int)GorevFieldIndex.GorevDurum, 0, 0, 0);
			this.AddElementFieldInfo("GorevEntity", "GorevId", typeof(System.Int16), true, false, true, false,  (int)GorevFieldIndex.GorevId, 0, 0, 5);
			this.AddElementFieldInfo("GorevEntity", "GorevTarih", typeof(System.DateTime), false, false, false, false,  (int)GorevFieldIndex.GorevTarih, 0, 0, 0);
		}
		/// <summary>Inits GrupEntity's FieldInfo objects</summary>
		private void InitGrupEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GrupFieldIndex), "GrupEntity");
			this.AddElementFieldInfo("GrupEntity", "GrupAciklama", typeof(System.String), false, false, false, true,  (int)GrupFieldIndex.GrupAciklama, 500, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupAd", typeof(System.String), false, false, false, false,  (int)GrupFieldIndex.GrupAd, 100, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupAmir", typeof(System.String), false, false, false, true,  (int)GrupFieldIndex.GrupAmir, 100, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupDurum", typeof(System.Boolean), false, false, false, false,  (int)GrupFieldIndex.GrupDurum, 0, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupId", typeof(System.Int16), true, false, true, false,  (int)GrupFieldIndex.GrupId, 0, 0, 5);
			this.AddElementFieldInfo("GrupEntity", "GrupIrtibat", typeof(System.String), false, false, false, true,  (int)GrupFieldIndex.GrupIrtibat, 100, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupKisaltma", typeof(System.String), false, false, false, true,  (int)GrupFieldIndex.GrupKisaltma, 100, 0, 0);
			this.AddElementFieldInfo("GrupEntity", "GrupTarih", typeof(System.DateTime), false, false, false, false,  (int)GrupFieldIndex.GrupTarih, 0, 0, 0);
		}
		/// <summary>Inits GrupAtamaEntity's FieldInfo objects</summary>
		private void InitGrupAtamaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(GrupAtamaFieldIndex), "GrupAtamaEntity");
			this.AddElementFieldInfo("GrupAtamaEntity", "FkGrupId", typeof(System.Int16), false, true, false, false,  (int)GrupAtamaFieldIndex.FkGrupId, 0, 0, 5);
			this.AddElementFieldInfo("GrupAtamaEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)GrupAtamaFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("GrupAtamaEntity", "GrupAtamaDurum", typeof(System.Boolean), false, false, false, false,  (int)GrupAtamaFieldIndex.GrupAtamaDurum, 0, 0, 0);
			this.AddElementFieldInfo("GrupAtamaEntity", "GrupAtamaId", typeof(System.Int64), true, false, true, false,  (int)GrupAtamaFieldIndex.GrupAtamaId, 0, 0, 19);
			this.AddElementFieldInfo("GrupAtamaEntity", "GrupAtamaTarih", typeof(System.DateTime), false, false, false, false,  (int)GrupAtamaFieldIndex.GrupAtamaTarih, 0, 0, 0);
		}
		/// <summary>Inits HavalimaniEntity's FieldInfo objects</summary>
		private void InitHavalimaniEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(HavalimaniFieldIndex), "HavalimaniEntity");
			this.AddElementFieldInfo("HavalimaniEntity", "HavalimaniAd", typeof(System.String), false, false, false, false,  (int)HavalimaniFieldIndex.HavalimaniAd, 150, 0, 0);
			this.AddElementFieldInfo("HavalimaniEntity", "HavalimaniDurum", typeof(System.Boolean), false, false, false, false,  (int)HavalimaniFieldIndex.HavalimaniDurum, 0, 0, 0);
			this.AddElementFieldInfo("HavalimaniEntity", "HavalimaniId", typeof(System.Int16), true, false, true, false,  (int)HavalimaniFieldIndex.HavalimaniId, 0, 0, 5);
			this.AddElementFieldInfo("HavalimaniEntity", "HavalimaniTarih", typeof(System.DateTime), false, false, false, false,  (int)HavalimaniFieldIndex.HavalimaniTarih, 0, 0, 0);
		}
		/// <summary>Inits HiyerarsiTurEntity's FieldInfo objects</summary>
		private void InitHiyerarsiTurEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(HiyerarsiTurFieldIndex), "HiyerarsiTurEntity");
			this.AddElementFieldInfo("HiyerarsiTurEntity", "HiyerarsiTurAd", typeof(System.String), false, false, false, false,  (int)HiyerarsiTurFieldIndex.HiyerarsiTurAd, 50, 0, 0);
			this.AddElementFieldInfo("HiyerarsiTurEntity", "HiyerarsiTurDurum", typeof(System.Boolean), false, false, false, false,  (int)HiyerarsiTurFieldIndex.HiyerarsiTurDurum, 0, 0, 0);
			this.AddElementFieldInfo("HiyerarsiTurEntity", "HiyerarsiTurId", typeof(System.Int16), true, false, true, false,  (int)HiyerarsiTurFieldIndex.HiyerarsiTurId, 0, 0, 5);
			this.AddElementFieldInfo("HiyerarsiTurEntity", "HiyerarsiTurSira", typeof(System.Int16), false, false, false, false,  (int)HiyerarsiTurFieldIndex.HiyerarsiTurSira, 0, 0, 5);
			this.AddElementFieldInfo("HiyerarsiTurEntity", "HiyerarsiTurTarih", typeof(System.DateTime), false, false, false, false,  (int)HiyerarsiTurFieldIndex.HiyerarsiTurTarih, 0, 0, 0);
		}
		/// <summary>Inits IlEntity's FieldInfo objects</summary>
		private void InitIlEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IlFieldIndex), "IlEntity");
			this.AddElementFieldInfo("IlEntity", "IlAd", typeof(System.String), false, false, false, false,  (int)IlFieldIndex.IlAd, 50, 0, 0);
			this.AddElementFieldInfo("IlEntity", "IlDurum", typeof(System.Boolean), false, false, false, false,  (int)IlFieldIndex.IlDurum, 0, 0, 0);
			this.AddElementFieldInfo("IlEntity", "IlId", typeof(System.Int16), true, false, true, false,  (int)IlFieldIndex.IlId, 0, 0, 5);
			this.AddElementFieldInfo("IlEntity", "IlPlakaKodu", typeof(System.Int16), false, false, false, false,  (int)IlFieldIndex.IlPlakaKodu, 0, 0, 5);
			this.AddElementFieldInfo("IlEntity", "IlTarih", typeof(System.DateTime), false, false, false, false,  (int)IlFieldIndex.IlTarih, 0, 0, 0);
		}
		/// <summary>Inits IpBankEntity's FieldInfo objects</summary>
		private void InitIpBankEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IpBankFieldIndex), "IpBankEntity");
			this.AddElementFieldInfo("IpBankEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)IpBankFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("IpBankEntity", "IpBanksAciklama", typeof(System.String), false, false, false, false,  (int)IpBankFieldIndex.IpBanksAciklama, 250, 0, 0);
			this.AddElementFieldInfo("IpBankEntity", "IpBanksAd", typeof(System.String), false, false, false, false,  (int)IpBankFieldIndex.IpBanksAd, 30, 0, 0);
			this.AddElementFieldInfo("IpBankEntity", "IpBanksDurum", typeof(System.Boolean), false, false, false, false,  (int)IpBankFieldIndex.IpBanksDurum, 0, 0, 0);
			this.AddElementFieldInfo("IpBankEntity", "IpBanksId", typeof(System.Int64), true, false, true, false,  (int)IpBankFieldIndex.IpBanksId, 0, 0, 19);
			this.AddElementFieldInfo("IpBankEntity", "IpBanksTarih", typeof(System.DateTime), false, false, false, false,  (int)IpBankFieldIndex.IpBanksTarih, 0, 0, 0);
		}
		/// <summary>Inits IslemEntity's FieldInfo objects</summary>
		private void InitIslemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IslemFieldIndex), "IslemEntity");
			this.AddElementFieldInfo("IslemEntity", "FkAltAltMenuId", typeof(System.Int16), false, true, false, false,  (int)IslemFieldIndex.FkAltAltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "FkAltMenuId", typeof(System.Int16), false, true, false, false,  (int)IslemFieldIndex.FkAltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "FkIslemTuruId", typeof(System.Int16), false, true, false, false,  (int)IslemFieldIndex.FkIslemTuruId, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "FkMenuId", typeof(System.Int16), false, true, false, false,  (int)IslemFieldIndex.FkMenuId, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "IslemAd", typeof(System.String), false, false, false, false,  (int)IslemFieldIndex.IslemAd, 100, 0, 0);
			this.AddElementFieldInfo("IslemEntity", "IslemId", typeof(System.Int16), true, false, true, false,  (int)IslemFieldIndex.IslemId, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "IslemSira", typeof(System.Int16), false, false, false, false,  (int)IslemFieldIndex.IslemSira, 0, 0, 5);
			this.AddElementFieldInfo("IslemEntity", "IslemTarih", typeof(System.DateTime), false, false, false, false,  (int)IslemFieldIndex.IslemTarih, 0, 0, 0);
		}
		/// <summary>Inits IslemOlusturEntity's FieldInfo objects</summary>
		private void InitIslemOlusturEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IslemOlusturFieldIndex), "IslemOlusturEntity");
			this.AddElementFieldInfo("IslemOlusturEntity", "FkIslemId", typeof(System.Int16), false, true, false, false,  (int)IslemOlusturFieldIndex.FkIslemId, 0, 0, 5);
			this.AddElementFieldInfo("IslemOlusturEntity", "FkYetkiId", typeof(System.Int16), false, true, false, false,  (int)IslemOlusturFieldIndex.FkYetkiId, 0, 0, 5);
			this.AddElementFieldInfo("IslemOlusturEntity", "IslemOlusturId", typeof(System.Int16), true, false, true, false,  (int)IslemOlusturFieldIndex.IslemOlusturId, 0, 0, 5);
			this.AddElementFieldInfo("IslemOlusturEntity", "IslemOlusturTarih", typeof(System.DateTime), false, false, false, false,  (int)IslemOlusturFieldIndex.IslemOlusturTarih, 0, 0, 0);
		}
		/// <summary>Inits IslemTuruEntity's FieldInfo objects</summary>
		private void InitIslemTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IslemTuruFieldIndex), "IslemTuruEntity");
			this.AddElementFieldInfo("IslemTuruEntity", "IslemTuruAd", typeof(System.String), false, false, false, false,  (int)IslemTuruFieldIndex.IslemTuruAd, 100, 0, 0);
			this.AddElementFieldInfo("IslemTuruEntity", "IslemTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)IslemTuruFieldIndex.IslemTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("IslemTuruEntity", "IslemTuruId", typeof(System.Int16), true, false, true, false,  (int)IslemTuruFieldIndex.IslemTuruId, 0, 0, 5);
			this.AddElementFieldInfo("IslemTuruEntity", "IslemTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)IslemTuruFieldIndex.IslemTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits IstatistikEntity's FieldInfo objects</summary>
		private void InitIstatistikEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IstatistikFieldIndex), "IstatistikEntity");
			this.AddElementFieldInfo("IstatistikEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)IstatistikFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("IstatistikEntity", "IstatistikAd", typeof(System.String), false, false, false, false,  (int)IstatistikFieldIndex.IstatistikAd, 250, 0, 0);
			this.AddElementFieldInfo("IstatistikEntity", "IstatistikAlt", typeof(System.String), false, false, false, false,  (int)IstatistikFieldIndex.IstatistikAlt, 250, 0, 0);
			this.AddElementFieldInfo("IstatistikEntity", "IstatistikCanliAd", typeof(System.String), false, false, false, true,  (int)IstatistikFieldIndex.IstatistikCanliAd, 250, 0, 0);
			this.AddElementFieldInfo("IstatistikEntity", "IstatistikId", typeof(System.Int64), true, false, true, false,  (int)IstatistikFieldIndex.IstatistikId, 0, 0, 19);
			this.AddElementFieldInfo("IstatistikEntity", "IstatistikSol", typeof(System.Double), false, false, false, false,  (int)IstatistikFieldIndex.IstatistikSol, 0, 0, 38);
		}
		/// <summary>Inits KapatmaTurEntity's FieldInfo objects</summary>
		private void InitKapatmaTurEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KapatmaTurFieldIndex), "KapatmaTurEntity");
			this.AddElementFieldInfo("KapatmaTurEntity", "KapatmaTurAd", typeof(System.String), false, false, false, false,  (int)KapatmaTurFieldIndex.KapatmaTurAd, 100, 0, 0);
			this.AddElementFieldInfo("KapatmaTurEntity", "KapatmaTurDurum", typeof(System.Boolean), false, false, false, false,  (int)KapatmaTurFieldIndex.KapatmaTurDurum, 0, 0, 0);
			this.AddElementFieldInfo("KapatmaTurEntity", "KapatmaTurId", typeof(System.Int16), true, false, true, false,  (int)KapatmaTurFieldIndex.KapatmaTurId, 0, 0, 5);
			this.AddElementFieldInfo("KapatmaTurEntity", "KapatmaTurTarih", typeof(System.DateTime), false, false, false, false,  (int)KapatmaTurFieldIndex.KapatmaTurTarih, 0, 0, 0);
		}
		/// <summary>Inits KarakterEntity's FieldInfo objects</summary>
		private void InitKarakterEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KarakterFieldIndex), "KarakterEntity");
			this.AddElementFieldInfo("KarakterEntity", "KarakterAd", typeof(System.String), false, false, false, false,  (int)KarakterFieldIndex.KarakterAd, 1, 0, 0);
			this.AddElementFieldInfo("KarakterEntity", "KarakterId", typeof(System.Int64), true, false, true, false,  (int)KarakterFieldIndex.KarakterId, 0, 0, 19);
			this.AddElementFieldInfo("KarakterEntity", "KarakterNo", typeof(System.Int16), false, false, false, false,  (int)KarakterFieldIndex.KarakterNo, 0, 0, 5);
		}
		/// <summary>Inits KaraListeEntity's FieldInfo objects</summary>
		private void InitKaraListeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KaraListeFieldIndex), "KaraListeEntity");
			this.AddElementFieldInfo("KaraListeEntity", "FkVatandasId", typeof(System.Int64), false, true, false, false,  (int)KaraListeFieldIndex.FkVatandasId, 0, 0, 19);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeAciklama", typeof(System.String), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeAciklama, 1000, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeBslTarihSaat", typeof(System.DateTime), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeBslTarihSaat, 0, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeBtsTarihSaat", typeof(System.DateTime), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeBtsTarihSaat, 0, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeDurum", typeof(System.Boolean), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeDurum, 0, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeId", typeof(System.Int64), true, false, true, false,  (int)KaraListeFieldIndex.KaraListeId, 0, 0, 19);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeIptalEdenKullanici", typeof(System.String), false, false, false, true,  (int)KaraListeFieldIndex.KaraListeIptalEdenKullanici, 100, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeIptalTarihi", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KaraListeFieldIndex.KaraListeIptalTarihi, 0, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeIslemTarih, 0, 0, 0);
			this.AddElementFieldInfo("KaraListeEntity", "KaraListeIslemYapan", typeof(System.String), false, false, false, false,  (int)KaraListeFieldIndex.KaraListeIslemYapan, 100, 0, 0);
		}
		/// <summary>Inits KonuEntity's FieldInfo objects</summary>
		private void InitKonuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KonuFieldIndex), "KonuEntity");
			this.AddElementFieldInfo("KonuEntity", "KonuAd", typeof(System.String), false, false, false, false,  (int)KonuFieldIndex.KonuAd, 150, 0, 0);
			this.AddElementFieldInfo("KonuEntity", "KonuDurum", typeof(System.Boolean), false, false, false, false,  (int)KonuFieldIndex.KonuDurum, 0, 0, 0);
			this.AddElementFieldInfo("KonuEntity", "KonuId", typeof(System.Int64), true, false, true, false,  (int)KonuFieldIndex.KonuId, 0, 0, 19);
			this.AddElementFieldInfo("KonuEntity", "KonuTarih", typeof(System.DateTime), false, false, false, false,  (int)KonuFieldIndex.KonuTarih, 0, 0, 0);
		}
		/// <summary>Inits KonusalDagilimEntity's FieldInfo objects</summary>
		private void InitKonusalDagilimEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KonusalDagilimFieldIndex), "KonusalDagilimEntity");
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimDurum", typeof(System.String), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimDurum, 25, 0, 0);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimIcerik", typeof(System.String), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimIcerik, 2147483647, 0, 0);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimId", typeof(System.Int64), true, false, true, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimId, 0, 0, 19);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimKonu", typeof(System.String), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimKonu, 1000, 0, 0);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimKullaniciId", typeof(System.Int16), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimNo", typeof(System.Int64), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimNo, 0, 0, 19);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimSonDurum", typeof(System.String), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimSonDurum, 2147483647, 0, 0);
			this.AddElementFieldInfo("KonusalDagilimEntity", "KonusalDagilimSure", typeof(System.String), false, false, false, false,  (int)KonusalDagilimFieldIndex.KonusalDagilimSure, 50, 0, 0);
		}
		/// <summary>Inits KopukCagriEntity's FieldInfo objects</summary>
		private void InitKopukCagriEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KopukCagriFieldIndex), "KopukCagriEntity");
			this.AddElementFieldInfo("KopukCagriEntity", "FkKopukCagriTuruId", typeof(System.Int16), false, true, false, false,  (int)KopukCagriFieldIndex.FkKopukCagriTuruId, 0, 0, 5);
			this.AddElementFieldInfo("KopukCagriEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)KopukCagriFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("KopukCagriEntity", "KopukCagriAciklama", typeof(System.String), false, false, false, true,  (int)KopukCagriFieldIndex.KopukCagriAciklama, 250, 0, 0);
			this.AddElementFieldInfo("KopukCagriEntity", "KopukCagriId", typeof(System.Int64), true, false, true, false,  (int)KopukCagriFieldIndex.KopukCagriId, 0, 0, 19);
			this.AddElementFieldInfo("KopukCagriEntity", "KopukCagriTarih", typeof(System.DateTime), false, false, false, false,  (int)KopukCagriFieldIndex.KopukCagriTarih, 0, 0, 0);
			this.AddElementFieldInfo("KopukCagriEntity", "KopukCagriTelNo", typeof(System.String), false, false, false, false,  (int)KopukCagriFieldIndex.KopukCagriTelNo, 20, 0, 0);
		}
		/// <summary>Inits KopukCagriTuruEntity's FieldInfo objects</summary>
		private void InitKopukCagriTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KopukCagriTuruFieldIndex), "KopukCagriTuruEntity");
			this.AddElementFieldInfo("KopukCagriTuruEntity", "KopukCagriTuruAd", typeof(System.String), false, false, false, false,  (int)KopukCagriTuruFieldIndex.KopukCagriTuruAd, 50, 0, 0);
			this.AddElementFieldInfo("KopukCagriTuruEntity", "KopukCagriTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)KopukCagriTuruFieldIndex.KopukCagriTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("KopukCagriTuruEntity", "KopukCagriTuruId", typeof(System.Int16), true, false, true, false,  (int)KopukCagriTuruFieldIndex.KopukCagriTuruId, 0, 0, 5);
			this.AddElementFieldInfo("KopukCagriTuruEntity", "KopukCagriTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)KopukCagriTuruFieldIndex.KopukCagriTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits KpsArsivEntity's FieldInfo objects</summary>
		private void InitKpsArsivEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KpsArsivFieldIndex), "KpsArsivEntity");
			this.AddElementFieldInfo("KpsArsivEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)KpsArsivFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("KpsArsivEntity", "KpsArsivDurum", typeof(System.Boolean), false, false, false, false,  (int)KpsArsivFieldIndex.KpsArsivDurum, 0, 0, 0);
			this.AddElementFieldInfo("KpsArsivEntity", "KpsArsivId", typeof(System.Int64), true, false, true, false,  (int)KpsArsivFieldIndex.KpsArsivId, 0, 0, 19);
			this.AddElementFieldInfo("KpsArsivEntity", "KpsArsivTarih", typeof(System.DateTime), false, false, false, false,  (int)KpsArsivFieldIndex.KpsArsivTarih, 0, 0, 0);
			this.AddElementFieldInfo("KpsArsivEntity", "KpsArsivTcNo", typeof(System.Int64), false, false, false, false,  (int)KpsArsivFieldIndex.KpsArsivTcNo, 0, 0, 19);
		}
		/// <summary>Inits KpsBilgiEntity's FieldInfo objects</summary>
		private void InitKpsBilgiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KpsBilgiFieldIndex), "KpsBilgiEntity");
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiAd", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiAd, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiAnneAd", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiAnneAd, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiBabaAd", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiBabaAd, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiCaddeSokak", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiCaddeSokak, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiCinsiyet", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiCinsiyet, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiDis", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiDis, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiDogumTarihi", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiDogumTarihi, 0, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiDogumYeri", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiDogumYeri, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiIc", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiIc, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiId", typeof(System.Int64), true, false, true, false,  (int)KpsBilgiFieldIndex.KpsBilgiId, 0, 0, 19);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiIl", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiIl, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiIlce", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiIlce, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiKayitNo", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiKayitNo, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiMahalle", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiMahalle, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiMedeniHal", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiMedeniHal, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiNo", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiNo, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiSeri", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiSeri, 10, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiSiteBlok", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiSiteBlok, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiSoyad", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiSoyad, 50, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiTarih", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiTarih, 0, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiTcKimlik", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiTcKimlik, 11, 0, 0);
			this.AddElementFieldInfo("KpsBilgiEntity", "KpsBilgiUyruk", typeof(System.String), false, false, false, true,  (int)KpsBilgiFieldIndex.KpsBilgiUyruk, 50, 0, 0);
		}
		/// <summary>Inits KullaniciEntity's FieldInfo objects</summary>
		private void InitKullaniciEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KullaniciFieldIndex), "KullaniciEntity");
			this.AddElementFieldInfo("KullaniciEntity", "AvayaLoginId", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.AvayaLoginId, 6, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "Extension", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.Extension, 5, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "FkGorevId", typeof(System.Int16), false, true, false, false,  (int)KullaniciFieldIndex.FkGorevId, 0, 0, 5);
			this.AddElementFieldInfo("KullaniciEntity", "FkHiyerarsiTurId", typeof(System.Int16), false, true, false, false,  (int)KullaniciFieldIndex.FkHiyerarsiTurId, 0, 0, 5);
			this.AddElementFieldInfo("KullaniciEntity", "FkYetkiId", typeof(System.Int16), false, true, false, false,  (int)KullaniciFieldIndex.FkYetkiId, 0, 0, 5);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciAciklama", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.KullaniciAciklama, 250, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciAd", typeof(System.String), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciAd, 50, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciAdSoyad", typeof(System.String), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciAdSoyad, 100, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciBirim", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.KullaniciBirim, 150, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciDurum", typeof(System.Boolean), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciDurum, 0, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciGizliSoru", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.KullaniciGizliSoru, 150, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciGizliSoruCevap", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.KullaniciGizliSoruCevap, 150, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciId", typeof(System.Int16), true, false, true, false,  (int)KullaniciFieldIndex.KullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciMail", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.KullaniciMail, 70, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciPassword", typeof(System.String), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciPassword, 50, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciSoyad", typeof(System.String), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciSoyad, 50, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciTarih", typeof(System.DateTime), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciTarih, 0, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "KullaniciUsername", typeof(System.String), false, false, false, false,  (int)KullaniciFieldIndex.KullaniciUsername, 20, 0, 0);
			this.AddElementFieldInfo("KullaniciEntity", "TcKimlikNo", typeof(System.String), false, false, false, true,  (int)KullaniciFieldIndex.TcKimlikNo, 11, 0, 0);
		}
		/// <summary>Inits KulTcNoEntity's FieldInfo objects</summary>
		private void InitKulTcNoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KulTcNoFieldIndex), "KulTcNoEntity");
			this.AddElementFieldInfo("KulTcNoEntity", "KulTcNoId", typeof(System.Int64), true, false, true, false,  (int)KulTcNoFieldIndex.KulTcNoId, 0, 0, 19);
			this.AddElementFieldInfo("KulTcNoEntity", "KulTcNoNumara", typeof(System.String), false, false, false, false,  (int)KulTcNoFieldIndex.KulTcNoNumara, 11, 0, 0);
			this.AddElementFieldInfo("KulTcNoEntity", "KulTcNoTarih", typeof(System.DateTime), false, false, false, false,  (int)KulTcNoFieldIndex.KulTcNoTarih, 0, 0, 0);
		}
		/// <summary>Inits LogEntity's FieldInfo objects</summary>
		private void InitLogEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogFieldIndex), "LogEntity");
			this.AddElementFieldInfo("LogEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)LogFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("LogEntity", "FkLogIslemId", typeof(System.Int16), false, true, false, false,  (int)LogFieldIndex.FkLogIslemId, 0, 0, 5);
			this.AddElementFieldInfo("LogEntity", "LogAciklama", typeof(System.String), false, false, false, false,  (int)LogFieldIndex.LogAciklama, 250, 0, 0);
			this.AddElementFieldInfo("LogEntity", "LogId", typeof(System.Int64), true, false, true, false,  (int)LogFieldIndex.LogId, 0, 0, 19);
			this.AddElementFieldInfo("LogEntity", "LogIpsi", typeof(System.String), false, false, false, false,  (int)LogFieldIndex.LogIpsi, 30, 0, 0);
			this.AddElementFieldInfo("LogEntity", "LogTarih", typeof(System.DateTime), false, false, false, false,  (int)LogFieldIndex.LogTarih, 0, 0, 0);
		}
		/// <summary>Inits LogEmailEntity's FieldInfo objects</summary>
		private void InitLogEmailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogEmailFieldIndex), "LogEmailEntity");
			this.AddElementFieldInfo("LogEmailEntity", "FkBildirimId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogEmailFieldIndex.FkBildirimId, 0, 0, 10);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailBcc", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailBcc, 2000, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailCc", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailCc, 2000, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailContent", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailContent, 2147483647, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailCreatedDateTime", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailCreatedDateTime, 0, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailFrom", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailFrom, 100, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailId", typeof(System.Int32), true, false, true, false,  (int)LogEmailFieldIndex.LogEmailId, 0, 0, 10);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailSendDateTime", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailSendDateTime, 0, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailSendStatus", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailSendStatus, 0, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailSubject", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailSubject, 2000, 0, 0);
			this.AddElementFieldInfo("LogEmailEntity", "LogEmailTo", typeof(System.String), false, false, false, true,  (int)LogEmailFieldIndex.LogEmailTo, 2000, 0, 0);
		}
		/// <summary>Inits LogHataEntity's FieldInfo objects</summary>
		private void InitLogHataEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogHataFieldIndex), "LogHataEntity");
			this.AddElementFieldInfo("LogHataEntity", "Duzeltildi", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)LogHataFieldIndex.Duzeltildi, 0, 0, 0);
			this.AddElementFieldInfo("LogHataEntity", "Ekran", typeof(System.String), false, false, false, true,  (int)LogHataFieldIndex.Ekran, 500, 0, 0);
			this.AddElementFieldInfo("LogHataEntity", "FkKullaniciDuzeltenId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogHataFieldIndex.FkKullaniciDuzeltenId, 0, 0, 10);
			this.AddElementFieldInfo("LogHataEntity", "FkKullaniciId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogHataFieldIndex.FkKullaniciId, 0, 0, 10);
			this.AddElementFieldInfo("LogHataEntity", "LogHataId", typeof(System.Int32), true, false, true, false,  (int)LogHataFieldIndex.LogHataId, 0, 0, 10);
			this.AddElementFieldInfo("LogHataEntity", "Mesaj", typeof(System.String), false, false, false, true,  (int)LogHataFieldIndex.Mesaj, 2147483647, 0, 0);
			this.AddElementFieldInfo("LogHataEntity", "Method", typeof(System.String), false, false, false, true,  (int)LogHataFieldIndex.Method, 2147483647, 0, 0);
			this.AddElementFieldInfo("LogHataEntity", "Tarih", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogHataFieldIndex.Tarih, 0, 0, 0);
			this.AddElementFieldInfo("LogHataEntity", "Trace", typeof(System.String), false, false, false, true,  (int)LogHataFieldIndex.Trace, 2147483647, 0, 0);
		}
		/// <summary>Inits LogIslemEntity's FieldInfo objects</summary>
		private void InitLogIslemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogIslemFieldIndex), "LogIslemEntity");
			this.AddElementFieldInfo("LogIslemEntity", "LogIslemAd", typeof(System.String), false, false, false, false,  (int)LogIslemFieldIndex.LogIslemAd, 100, 0, 0);
			this.AddElementFieldInfo("LogIslemEntity", "LogIslemDurum", typeof(System.Boolean), false, false, false, false,  (int)LogIslemFieldIndex.LogIslemDurum, 0, 0, 0);
			this.AddElementFieldInfo("LogIslemEntity", "LogIslemId", typeof(System.Int16), true, false, true, false,  (int)LogIslemFieldIndex.LogIslemId, 0, 0, 5);
			this.AddElementFieldInfo("LogIslemEntity", "LogIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)LogIslemFieldIndex.LogIslemTarih, 0, 0, 0);
		}
		/// <summary>Inits LogSmEntity's FieldInfo objects</summary>
		private void InitLogSmEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LogSmFieldIndex), "LogSmEntity");
			this.AddElementFieldInfo("LogSmEntity", "FkBildirimId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogSmFieldIndex.FkBildirimId, 0, 0, 10);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsCreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogSmFieldIndex.LogSmsCreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsGsmNumber", typeof(System.String), false, false, false, true,  (int)LogSmFieldIndex.LogSmsGsmNumber, 50, 0, 0);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsId", typeof(System.Int32), true, false, true, false,  (int)LogSmFieldIndex.LogSmsId, 0, 0, 10);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsMessage", typeof(System.String), false, false, false, true,  (int)LogSmFieldIndex.LogSmsMessage, 480, 0, 0);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsSender", typeof(System.String), false, false, false, true,  (int)LogSmFieldIndex.LogSmsSender, 50, 0, 0);
			this.AddElementFieldInfo("LogSmEntity", "LogSmsSmsId", typeof(System.String), false, false, false, true,  (int)LogSmFieldIndex.LogSmsSmsId, 50, 0, 0);
		}
		/// <summary>Inits MailBankEntity's FieldInfo objects</summary>
		private void InitMailBankEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(MailBankFieldIndex), "MailBankEntity");
			this.AddElementFieldInfo("MailBankEntity", "MailBanksBildirim", typeof(Nullable<System.Int64>), false, false, false, true,  (int)MailBankFieldIndex.MailBanksBildirim, 0, 0, 19);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksDurum", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)MailBankFieldIndex.MailBanksDurum, 0, 0, 0);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksId", typeof(System.Int64), true, false, true, false,  (int)MailBankFieldIndex.MailBanksId, 0, 0, 19);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksKullanici", typeof(Nullable<System.Int16>), false, false, false, true,  (int)MailBankFieldIndex.MailBanksKullanici, 0, 0, 5);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksLink", typeof(System.String), false, false, false, true,  (int)MailBankFieldIndex.MailBanksLink, 300, 0, 0);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksTarih", typeof(System.DateTime), false, false, false, false,  (int)MailBankFieldIndex.MailBanksTarih, 0, 0, 0);
			this.AddElementFieldInfo("MailBankEntity", "MailBanksTikAdet", typeof(Nullable<System.Int16>), false, false, false, true,  (int)MailBankFieldIndex.MailBanksTikAdet, 0, 0, 5);
		}
		/// <summary>Inits MenuEntity's FieldInfo objects</summary>
		private void InitMenuEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(MenuFieldIndex), "MenuEntity");
			this.AddElementFieldInfo("MenuEntity", "MenuAciklama", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.MenuAciklama, 250, 0, 0);
			this.AddElementFieldInfo("MenuEntity", "MenuAd", typeof(System.String), false, false, false, false,  (int)MenuFieldIndex.MenuAd, 50, 0, 0);
			this.AddElementFieldInfo("MenuEntity", "MenuDurum", typeof(System.Boolean), false, false, false, false,  (int)MenuFieldIndex.MenuDurum, 0, 0, 0);
			this.AddElementFieldInfo("MenuEntity", "MenuId", typeof(System.Int16), true, false, true, false,  (int)MenuFieldIndex.MenuId, 0, 0, 5);
			this.AddElementFieldInfo("MenuEntity", "MenuLink", typeof(System.String), false, false, false, false,  (int)MenuFieldIndex.MenuLink, 100, 0, 0);
			this.AddElementFieldInfo("MenuEntity", "MenuSira", typeof(System.Int16), false, false, false, false,  (int)MenuFieldIndex.MenuSira, 0, 0, 5);
			this.AddElementFieldInfo("MenuEntity", "MenuSonLink", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.MenuSonLink, 150, 0, 0);
			this.AddElementFieldInfo("MenuEntity", "MenuTarih", typeof(System.DateTime), false, false, false, false,  (int)MenuFieldIndex.MenuTarih, 0, 0, 0);
		}
		/// <summary>Inits MenuOlusturEntity's FieldInfo objects</summary>
		private void InitMenuOlusturEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(MenuOlusturFieldIndex), "MenuOlusturEntity");
			this.AddElementFieldInfo("MenuOlusturEntity", "FkAltAltMenuId", typeof(System.Int16), false, true, false, false,  (int)MenuOlusturFieldIndex.FkAltAltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("MenuOlusturEntity", "FkAltMenuId", typeof(System.Int16), false, true, false, false,  (int)MenuOlusturFieldIndex.FkAltMenuId, 0, 0, 5);
			this.AddElementFieldInfo("MenuOlusturEntity", "FkMenuId", typeof(System.Int16), false, true, false, false,  (int)MenuOlusturFieldIndex.FkMenuId, 0, 0, 5);
			this.AddElementFieldInfo("MenuOlusturEntity", "FkYetkiId", typeof(System.Int16), false, true, false, false,  (int)MenuOlusturFieldIndex.FkYetkiId, 0, 0, 5);
			this.AddElementFieldInfo("MenuOlusturEntity", "MenuOlusturId", typeof(System.Int32), true, false, true, false,  (int)MenuOlusturFieldIndex.MenuOlusturId, 0, 0, 10);
			this.AddElementFieldInfo("MenuOlusturEntity", "MenuOlusturSayi", typeof(Nullable<System.Int16>), false, false, false, true,  (int)MenuOlusturFieldIndex.MenuOlusturSayi, 0, 0, 5);
			this.AddElementFieldInfo("MenuOlusturEntity", "MenuOlusturTarih", typeof(System.DateTime), false, false, false, false,  (int)MenuOlusturFieldIndex.MenuOlusturTarih, 0, 0, 0);
		}
		/// <summary>Inits MesajEntity's FieldInfo objects</summary>
		private void InitMesajEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(MesajFieldIndex), "MesajEntity");
			this.AddElementFieldInfo("MesajEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)MesajFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("MesajEntity", "MesajBaslik", typeof(System.String), false, false, false, false,  (int)MesajFieldIndex.MesajBaslik, 100, 0, 0);
			this.AddElementFieldInfo("MesajEntity", "MesajHangiKullanici", typeof(System.String), false, false, false, false,  (int)MesajFieldIndex.MesajHangiKullanici, 75, 0, 0);
			this.AddElementFieldInfo("MesajEntity", "MesajIcerik", typeof(System.String), false, false, false, false,  (int)MesajFieldIndex.MesajIcerik, 500, 0, 0);
			this.AddElementFieldInfo("MesajEntity", "MesajId", typeof(System.Int64), true, false, true, false,  (int)MesajFieldIndex.MesajId, 0, 0, 19);
			this.AddElementFieldInfo("MesajEntity", "MesajTarih", typeof(System.DateTime), false, false, false, false,  (int)MesajFieldIndex.MesajTarih, 0, 0, 0);
		}
		/// <summary>Inits ParametreEntity's FieldInfo objects</summary>
		private void InitParametreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ParametreFieldIndex), "ParametreEntity");
			this.AddElementFieldInfo("ParametreEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)ParametreFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreEntity", "FkParametreTurId", typeof(System.Int16), false, true, false, false,  (int)ParametreFieldIndex.FkParametreTurId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreEntity", "ParametreAd", typeof(System.String), false, false, false, false,  (int)ParametreFieldIndex.ParametreAd, 100, 0, 0);
			this.AddElementFieldInfo("ParametreEntity", "ParametreBasTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreFieldIndex.ParametreBasTarih, 0, 0, 0);
			this.AddElementFieldInfo("ParametreEntity", "ParametreBitTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreFieldIndex.ParametreBitTarih, 0, 0, 0);
			this.AddElementFieldInfo("ParametreEntity", "ParametreDeger", typeof(System.String), false, false, false, false,  (int)ParametreFieldIndex.ParametreDeger, 100, 0, 0);
			this.AddElementFieldInfo("ParametreEntity", "ParametreId", typeof(System.Int16), true, false, true, false,  (int)ParametreFieldIndex.ParametreId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreEntity", "ParametreIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreFieldIndex.ParametreIslemTarih, 0, 0, 0);
		}
		/// <summary>Inits ParametreGenelArsivEntity's FieldInfo objects</summary>
		private void InitParametreGenelArsivEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ParametreGenelArsivFieldIndex), "ParametreGenelArsivEntity");
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)ParametreGenelArsivFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "FkParametreId", typeof(System.Int16), false, true, false, false,  (int)ParametreGenelArsivFieldIndex.FkParametreId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivAd", typeof(System.String), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivAd, 100, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivBasTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivBasTarih, 0, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivBitTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivBitTarih, 0, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivId", typeof(System.Int16), true, false, true, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivKullanici", typeof(System.String), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivKullanici, 50, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivNew", typeof(System.String), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivNew, 100, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivOld", typeof(System.String), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivOld, 100, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivTarih, 0, 0, 0);
			this.AddElementFieldInfo("ParametreGenelArsivEntity", "ParametreGenelArsivTur", typeof(System.String), false, false, false, false,  (int)ParametreGenelArsivFieldIndex.ParametreGenelArsivTur, 50, 0, 0);
		}
		/// <summary>Inits ParametreTurEntity's FieldInfo objects</summary>
		private void InitParametreTurEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ParametreTurFieldIndex), "ParametreTurEntity");
			this.AddElementFieldInfo("ParametreTurEntity", "ParametreTurAciklama", typeof(System.String), false, false, false, true,  (int)ParametreTurFieldIndex.ParametreTurAciklama, 500, 0, 0);
			this.AddElementFieldInfo("ParametreTurEntity", "ParametreTurAd", typeof(System.String), false, false, false, false,  (int)ParametreTurFieldIndex.ParametreTurAd, 50, 0, 0);
			this.AddElementFieldInfo("ParametreTurEntity", "ParametreTurDurum", typeof(System.Boolean), false, false, false, false,  (int)ParametreTurFieldIndex.ParametreTurDurum, 0, 0, 0);
			this.AddElementFieldInfo("ParametreTurEntity", "ParametreTurId", typeof(System.Int16), true, false, true, false,  (int)ParametreTurFieldIndex.ParametreTurId, 0, 0, 5);
			this.AddElementFieldInfo("ParametreTurEntity", "ParametreTurTarih", typeof(System.DateTime), false, false, false, false,  (int)ParametreTurFieldIndex.ParametreTurTarih, 0, 0, 0);
		}
		/// <summary>Inits RaporIcerikEntity's FieldInfo objects</summary>
		private void InitRaporIcerikEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RaporIcerikFieldIndex), "RaporIcerikEntity");
			this.AddElementFieldInfo("RaporIcerikEntity", "FkRaporTuruId", typeof(System.Int16), false, true, false, false,  (int)RaporIcerikFieldIndex.FkRaporTuruId, 0, 0, 5);
			this.AddElementFieldInfo("RaporIcerikEntity", "RaporIcerikAnaVeri", typeof(System.String), false, false, false, false,  (int)RaporIcerikFieldIndex.RaporIcerikAnaVeri, 100, 0, 0);
			this.AddElementFieldInfo("RaporIcerikEntity", "RaporIcerikDurum", typeof(System.Boolean), false, false, false, false,  (int)RaporIcerikFieldIndex.RaporIcerikDurum, 0, 0, 0);
			this.AddElementFieldInfo("RaporIcerikEntity", "RaporIcerikId", typeof(System.Int64), true, false, true, false,  (int)RaporIcerikFieldIndex.RaporIcerikId, 0, 0, 19);
			this.AddElementFieldInfo("RaporIcerikEntity", "RaporIcerikKolon", typeof(System.String), false, false, false, false,  (int)RaporIcerikFieldIndex.RaporIcerikKolon, 100, 0, 0);
			this.AddElementFieldInfo("RaporIcerikEntity", "RaporIcerikTarih", typeof(System.DateTime), false, false, false, false,  (int)RaporIcerikFieldIndex.RaporIcerikTarih, 0, 0, 0);
		}
		/// <summary>Inits RaporTuruEntity's FieldInfo objects</summary>
		private void InitRaporTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RaporTuruFieldIndex), "RaporTuruEntity");
			this.AddElementFieldInfo("RaporTuruEntity", "RaporTuruAd", typeof(System.String), false, false, false, false,  (int)RaporTuruFieldIndex.RaporTuruAd, 150, 0, 0);
			this.AddElementFieldInfo("RaporTuruEntity", "RaporTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)RaporTuruFieldIndex.RaporTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("RaporTuruEntity", "RaporTuruId", typeof(System.Int16), true, false, true, false,  (int)RaporTuruFieldIndex.RaporTuruId, 0, 0, 5);
			this.AddElementFieldInfo("RaporTuruEntity", "RaporTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)RaporTuruFieldIndex.RaporTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits RaporYetkiEntity's FieldInfo objects</summary>
		private void InitRaporYetkiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RaporYetkiFieldIndex), "RaporYetkiEntity");
			this.AddElementFieldInfo("RaporYetkiEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)RaporYetkiFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("RaporYetkiEntity", "FkRaporTuruId", typeof(System.Int16), false, true, false, false,  (int)RaporYetkiFieldIndex.FkRaporTuruId, 0, 0, 5);
			this.AddElementFieldInfo("RaporYetkiEntity", "RaporYetkiDurum", typeof(System.Boolean), false, false, false, false,  (int)RaporYetkiFieldIndex.RaporYetkiDurum, 0, 0, 0);
			this.AddElementFieldInfo("RaporYetkiEntity", "RaporYetkiId", typeof(System.Int64), true, false, true, false,  (int)RaporYetkiFieldIndex.RaporYetkiId, 0, 0, 19);
			this.AddElementFieldInfo("RaporYetkiEntity", "RaporYetkiTarih", typeof(System.DateTime), false, false, false, false,  (int)RaporYetkiFieldIndex.RaporYetkiTarih, 0, 0, 0);
		}
		/// <summary>Inits SorunEntity's FieldInfo objects</summary>
		private void InitSorunEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SorunFieldIndex), "SorunEntity");
			this.AddElementFieldInfo("SorunEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)SorunFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("SorunEntity", "FkSorunTuruId", typeof(System.Int16), false, true, false, false,  (int)SorunFieldIndex.FkSorunTuruId, 0, 0, 5);
			this.AddElementFieldInfo("SorunEntity", "SorunAciklama", typeof(System.String), false, false, false, false,  (int)SorunFieldIndex.SorunAciklama, 750, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunCevaplandiMi", typeof(System.String), false, false, false, false,  (int)SorunFieldIndex.SorunCevaplandiMi, 10, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunCevapTarih", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SorunFieldIndex.SorunCevapTarih, 0, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunCozum", typeof(System.String), false, false, false, false,  (int)SorunFieldIndex.SorunCozum, 750, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunId", typeof(System.Int16), true, false, true, false,  (int)SorunFieldIndex.SorunId, 0, 0, 5);
			this.AddElementFieldInfo("SorunEntity", "SorunIrtibat", typeof(System.String), false, false, false, false,  (int)SorunFieldIndex.SorunIrtibat, 100, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunOneri", typeof(System.String), false, false, false, false,  (int)SorunFieldIndex.SorunOneri, 200, 0, 0);
			this.AddElementFieldInfo("SorunEntity", "SorunTarih", typeof(System.DateTime), false, false, false, false,  (int)SorunFieldIndex.SorunTarih, 0, 0, 0);
		}
		/// <summary>Inits SorunTuruEntity's FieldInfo objects</summary>
		private void InitSorunTuruEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SorunTuruFieldIndex), "SorunTuruEntity");
			this.AddElementFieldInfo("SorunTuruEntity", "SorunTuruAd", typeof(System.String), false, false, false, false,  (int)SorunTuruFieldIndex.SorunTuruAd, 100, 0, 0);
			this.AddElementFieldInfo("SorunTuruEntity", "SorunTuruDurum", typeof(System.Boolean), false, false, false, false,  (int)SorunTuruFieldIndex.SorunTuruDurum, 0, 0, 0);
			this.AddElementFieldInfo("SorunTuruEntity", "SorunTuruId", typeof(System.Int16), true, false, true, false,  (int)SorunTuruFieldIndex.SorunTuruId, 0, 0, 5);
			this.AddElementFieldInfo("SorunTuruEntity", "SorunTuruTarih", typeof(System.DateTime), false, false, false, false,  (int)SorunTuruFieldIndex.SorunTuruTarih, 0, 0, 0);
		}
		/// <summary>Inits SureTakipEntity's FieldInfo objects</summary>
		private void InitSureTakipEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SureTakipFieldIndex), "SureTakipEntity");
			this.AddElementFieldInfo("SureTakipEntity", "FkBildirimId", typeof(System.Int64), false, true, false, false,  (int)SureTakipFieldIndex.FkBildirimId, 0, 0, 19);
			this.AddElementFieldInfo("SureTakipEntity", "SureTakipGun", typeof(System.Double), false, false, false, false,  (int)SureTakipFieldIndex.SureTakipGun, 0, 0, 38);
			this.AddElementFieldInfo("SureTakipEntity", "SureTakipId", typeof(System.Int64), true, false, true, false,  (int)SureTakipFieldIndex.SureTakipId, 0, 0, 19);
			this.AddElementFieldInfo("SureTakipEntity", "SureTakipSaat", typeof(System.Int16), false, false, false, false,  (int)SureTakipFieldIndex.SureTakipSaat, 0, 0, 5);
			this.AddElementFieldInfo("SureTakipEntity", "SureTakipTarih", typeof(System.DateTime), false, false, false, false,  (int)SureTakipFieldIndex.SureTakipTarih, 0, 0, 0);
			this.AddElementFieldInfo("SureTakipEntity", "SureTakipTuru", typeof(System.String), false, false, false, false,  (int)SureTakipFieldIndex.SureTakipTuru, 150, 0, 0);
		}
		/// <summary>Inits TurBankEntity's FieldInfo objects</summary>
		private void InitTurBankEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TurBankFieldIndex), "TurBankEntity");
			this.AddElementFieldInfo("TurBankEntity", "TurBanksAd", typeof(System.String), false, false, false, false,  (int)TurBankFieldIndex.TurBanksAd, 50, 0, 0);
			this.AddElementFieldInfo("TurBankEntity", "TurBanksDurum", typeof(System.Boolean), false, false, false, false,  (int)TurBankFieldIndex.TurBanksDurum, 0, 0, 0);
			this.AddElementFieldInfo("TurBankEntity", "TurBanksId", typeof(System.Int16), true, false, true, false,  (int)TurBankFieldIndex.TurBanksId, 0, 0, 5);
			this.AddElementFieldInfo("TurBankEntity", "TurBanksTable", typeof(System.String), false, false, false, false,  (int)TurBankFieldIndex.TurBanksTable, 50, 0, 0);
			this.AddElementFieldInfo("TurBankEntity", "TurBanksTarih", typeof(System.DateTime), false, false, false, false,  (int)TurBankFieldIndex.TurBanksTarih, 0, 0, 0);
		}
		/// <summary>Inits VatandaEntity's FieldInfo objects</summary>
		private void InitVatandaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VatandaFieldIndex), "VatandaEntity");
			this.AddElementFieldInfo("VatandaEntity", "FkKullaniciId", typeof(System.Int16), false, true, false, false,  (int)VatandaFieldIndex.FkKullaniciId, 0, 0, 5);
			this.AddElementFieldInfo("VatandaEntity", "VatandasAd", typeof(System.String), false, false, false, false,  (int)VatandaFieldIndex.VatandasAd, 50, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasAdres", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasAdres, 500, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasAdSoyad", typeof(System.String), false, false, false, false,  (int)VatandaFieldIndex.VatandasAdSoyad, 100, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasCinsiyet", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasCinsiyet, 10, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasDogumTarihi", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)VatandaFieldIndex.VatandasDogumTarihi, 0, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasFax", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasFax, 20, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasId", typeof(System.Int64), true, false, true, false,  (int)VatandaFieldIndex.VatandasId, 0, 0, 19);
			this.AddElementFieldInfo("VatandaEntity", "VatandasIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)VatandaFieldIndex.VatandasIslemTarih, 0, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasMail", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasMail, 75, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasNotes", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasNotes, 2147483647, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasPasaportNo", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasPasaportNo, 75, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasSoyad", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasSoyad, 50, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasTcNo", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasTcNo, 11, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasTel1", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasTel1, 20, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasTel2", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasTel2, 20, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasTur", typeof(System.String), false, false, false, false,  (int)VatandaFieldIndex.VatandasTur, 50, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasUyruk", typeof(System.String), false, false, false, false,  (int)VatandaFieldIndex.VatandasUyruk, 35, 0, 0);
			this.AddElementFieldInfo("VatandaEntity", "VatandasVergiNo", typeof(System.String), false, false, false, true,  (int)VatandaFieldIndex.VatandasVergiNo, 20, 0, 0);
		}
		/// <summary>Inits VatandasArsivEntity's FieldInfo objects</summary>
		private void InitVatandasArsivEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VatandasArsivFieldIndex), "VatandasArsivEntity");
			this.AddElementFieldInfo("VatandasArsivEntity", "FkVatandasId", typeof(System.Int64), false, true, false, false,  (int)VatandasArsivFieldIndex.FkVatandasId, 0, 0, 19);
			this.AddElementFieldInfo("VatandasArsivEntity", "VatandasArsivAciklama", typeof(System.String), false, false, false, false,  (int)VatandasArsivFieldIndex.VatandasArsivAciklama, 250, 0, 0);
			this.AddElementFieldInfo("VatandasArsivEntity", "VatandasArsivId", typeof(System.Int64), true, false, true, false,  (int)VatandasArsivFieldIndex.VatandasArsivId, 0, 0, 19);
			this.AddElementFieldInfo("VatandasArsivEntity", "VatandasArsivIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)VatandasArsivFieldIndex.VatandasArsivIslemTarih, 0, 0, 0);
		}
		/// <summary>Inits VipListeEntity's FieldInfo objects</summary>
		private void InitVipListeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VipListeFieldIndex), "VipListeEntity");
			this.AddElementFieldInfo("VipListeEntity", "FkVatandasId", typeof(System.Int64), false, true, false, false,  (int)VipListeFieldIndex.FkVatandasId, 0, 0, 19);
			this.AddElementFieldInfo("VipListeEntity", "VipListeAciklama", typeof(System.String), false, false, false, false,  (int)VipListeFieldIndex.VipListeAciklama, 1000, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeBslTarihSaat", typeof(System.DateTime), false, false, false, false,  (int)VipListeFieldIndex.VipListeBslTarihSaat, 0, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeBtsTarihSaat", typeof(System.DateTime), false, false, false, false,  (int)VipListeFieldIndex.VipListeBtsTarihSaat, 0, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeDurum", typeof(System.Boolean), false, false, false, false,  (int)VipListeFieldIndex.VipListeDurum, 0, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeId", typeof(System.Int64), true, false, true, false,  (int)VipListeFieldIndex.VipListeId, 0, 0, 19);
			this.AddElementFieldInfo("VipListeEntity", "VipListeIptalEdenKullanici", typeof(System.String), false, false, false, true,  (int)VipListeFieldIndex.VipListeIptalEdenKullanici, 100, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeIptalTarihi", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)VipListeFieldIndex.VipListeIptalTarihi, 0, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeIslemTarih", typeof(System.DateTime), false, false, false, false,  (int)VipListeFieldIndex.VipListeIslemTarih, 0, 0, 0);
			this.AddElementFieldInfo("VipListeEntity", "VipListeIslemYapan", typeof(System.String), false, false, false, false,  (int)VipListeFieldIndex.VipListeIslemYapan, 100, 0, 0);
		}
		/// <summary>Inits WebServiEntity's FieldInfo objects</summary>
		private void InitWebServiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WebServiFieldIndex), "WebServiEntity");
			this.AddElementFieldInfo("WebServiEntity", "WebServisAlan1", typeof(System.String), false, false, false, false,  (int)WebServiFieldIndex.WebServisAlan1, 500, 0, 0);
			this.AddElementFieldInfo("WebServiEntity", "WebServisAlan2", typeof(System.String), false, false, false, true,  (int)WebServiFieldIndex.WebServisAlan2, 500, 0, 0);
			this.AddElementFieldInfo("WebServiEntity", "WebServisAlan3", typeof(System.String), false, false, false, true,  (int)WebServiFieldIndex.WebServisAlan3, 500, 0, 0);
			this.AddElementFieldInfo("WebServiEntity", "WebServisId", typeof(System.Int64), true, false, true, false,  (int)WebServiFieldIndex.WebServisId, 0, 0, 19);
			this.AddElementFieldInfo("WebServiEntity", "WebServisKullaniciKim", typeof(System.Int64), false, false, false, false,  (int)WebServiFieldIndex.WebServisKullaniciKim, 0, 0, 19);
		}
		/// <summary>Inits YetkiEntity's FieldInfo objects</summary>
		private void InitYetkiEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(YetkiFieldIndex), "YetkiEntity");
			this.AddElementFieldInfo("YetkiEntity", "YetkiAciklama", typeof(System.String), false, false, false, true,  (int)YetkiFieldIndex.YetkiAciklama, 250, 0, 0);
			this.AddElementFieldInfo("YetkiEntity", "YetkiAd", typeof(System.String), false, false, false, false,  (int)YetkiFieldIndex.YetkiAd, 100, 0, 0);
			this.AddElementFieldInfo("YetkiEntity", "YetkiDurum", typeof(System.Boolean), false, false, false, false,  (int)YetkiFieldIndex.YetkiDurum, 0, 0, 0);
			this.AddElementFieldInfo("YetkiEntity", "YetkiId", typeof(System.Int16), true, false, true, false,  (int)YetkiFieldIndex.YetkiId, 0, 0, 5);
			this.AddElementFieldInfo("YetkiEntity", "YetkiTarih", typeof(System.DateTime), false, false, false, false,  (int)YetkiFieldIndex.YetkiTarih, 0, 0, 0);
		}
		/// <summary>Inits ZamanEntity's FieldInfo objects</summary>
		private void InitZamanEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ZamanFieldIndex), "ZamanEntity");
			this.AddElementFieldInfo("ZamanEntity", "ZamanAd", typeof(System.String), false, false, false, false,  (int)ZamanFieldIndex.ZamanAd, 50, 0, 0);
			this.AddElementFieldInfo("ZamanEntity", "ZamanDurum", typeof(System.Boolean), false, false, false, false,  (int)ZamanFieldIndex.ZamanDurum, 0, 0, 0);
			this.AddElementFieldInfo("ZamanEntity", "ZamanId", typeof(System.Int16), true, false, true, false,  (int)ZamanFieldIndex.ZamanId, 0, 0, 5);
			this.AddElementFieldInfo("ZamanEntity", "ZamanSaat", typeof(System.Int64), false, false, false, false,  (int)ZamanFieldIndex.ZamanSaat, 0, 0, 19);
			this.AddElementFieldInfo("ZamanEntity", "ZamanSira", typeof(System.Int16), false, false, false, false,  (int)ZamanFieldIndex.ZamanSira, 0, 0, 5);
			this.AddElementFieldInfo("ZamanEntity", "ZamanTarih", typeof(System.DateTime), false, false, false, false,  (int)ZamanFieldIndex.ZamanTarih, 0, 0, 0);
		}
		
	}
}




