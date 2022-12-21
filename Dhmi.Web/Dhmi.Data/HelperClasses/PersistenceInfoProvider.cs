///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:39
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.HelperClasses
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((74 + 0));
			InitAcikBildirimEntityMappings();
			InitAcikBildirimAyrintiEntityMappings();
			InitAltAltMenuEntityMappings();
			InitAltKarakterEntityMappings();
			InitAltKonuEntityMappings();
			InitAltMenuEntityMappings();
			InitBaskanlikEntityMappings();
			InitBildirimEntityMappings();
			InitBildirimAtamaGrupEntityMappings();
			InitBildirimAtamaKullaniciEntityMappings();
			InitBildirimGeriDonuEntityMappings();
			InitBildirimHistoryEntityMappings();
			InitBildirimIslemEntityMappings();
			InitBildirimSonucEntityMappings();
			InitBildirimTuruEntityMappings();
			InitBilgiBankasiEntityMappings();
			InitBilgiBankasiTurEntityMappings();
			InitBilgilendirmeEntityMappings();
			InitCagriMerkezEntityMappings();
			InitCagriTipiEntityMappings();
			InitDigerBirimlerEntityMappings();
			InitDigerBirimlerAyrintiEntityMappings();
			InitDosyaEntityMappings();
			InitDuyuruEntityMappings();
			InitEkSureEntityMappings();
			InitGecenSureEntityMappings();
			InitGizliSoruTuruEntityMappings();
			InitGorevEntityMappings();
			InitGrupEntityMappings();
			InitGrupAtamaEntityMappings();
			InitHavalimaniEntityMappings();
			InitHiyerarsiTurEntityMappings();
			InitIlEntityMappings();
			InitIpBankEntityMappings();
			InitIslemEntityMappings();
			InitIslemOlusturEntityMappings();
			InitIslemTuruEntityMappings();
			InitIstatistikEntityMappings();
			InitKapatmaTurEntityMappings();
			InitKarakterEntityMappings();
			InitKaraListeEntityMappings();
			InitKonuEntityMappings();
			InitKonusalDagilimEntityMappings();
			InitKopukCagriEntityMappings();
			InitKopukCagriTuruEntityMappings();
			InitKpsArsivEntityMappings();
			InitKpsBilgiEntityMappings();
			InitKullaniciEntityMappings();
			InitKulTcNoEntityMappings();
			InitLogEntityMappings();
			InitLogEmailEntityMappings();
			InitLogHataEntityMappings();
			InitLogIslemEntityMappings();
			InitLogSmEntityMappings();
			InitMailBankEntityMappings();
			InitMenuEntityMappings();
			InitMenuOlusturEntityMappings();
			InitMesajEntityMappings();
			InitParametreEntityMappings();
			InitParametreGenelArsivEntityMappings();
			InitParametreTurEntityMappings();
			InitRaporIcerikEntityMappings();
			InitRaporTuruEntityMappings();
			InitRaporYetkiEntityMappings();
			InitSorunEntityMappings();
			InitSorunTuruEntityMappings();
			InitSureTakipEntityMappings();
			InitTurBankEntityMappings();
			InitVatandaEntityMappings();
			InitVatandasArsivEntityMappings();
			InitVipListeEntityMappings();
			InitWebServiEntityMappings();
			InitYetkiEntityMappings();
			InitZamanEntityMappings();

		}


		/// <summary>Inits AcikBildirimEntity's mappings</summary>
		private void InitAcikBildirimEntityMappings()
		{
			this.AddElementMapping( "AcikBildirimEntity", @"Dhmi", @"dbo", "Acik_Bildirim", 5 );
			this.AddElementFieldMapping( "AcikBildirimEntity", "AcikBildirimAtandiSayi", "Acik_Bildirim_Atandi_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "AcikBildirimEntity", "AcikBildirimBirim", "Acik_Bildirim_Birim", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AcikBildirimEntity", "AcikBildirimId", "Acik_Bildirim_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "AcikBildirimEntity", "AcikBildirimInceleniyorEkSureSayi", "Acik_Bildirim_Inceleniyor_Ek_Sure_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "AcikBildirimEntity", "AcikBildirimInceleniyorSayi", "Acik_Bildirim_Inceleniyor_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
		}
		/// <summary>Inits AcikBildirimAyrintiEntity's mappings</summary>
		private void InitAcikBildirimAyrintiEntityMappings()
		{
			this.AddElementMapping( "AcikBildirimAyrintiEntity", @"Dhmi", @"dbo", "Acik_Bildirim_Ayrinti", 7 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiBirim", "Acik_Bildirim_Ayrinti_Birim", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiDurum", "Acik_Bildirim_Ayrinti_Durum", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiIcerik", "Acik_Bildirim_Ayrinti_Icerik", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiId", "Acik_Bildirim_Ayrinti_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiNo", "Acik_Bildirim_Ayrinti_No", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiSonDurum", "Acik_Bildirim_Ayrinti_Son_Durum", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "AcikBildirimAyrintiEntity", "AcikBildirimAyrintiSure", "Acik_Bildirim_Ayrinti_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits AltAltMenuEntity's mappings</summary>
		private void InitAltAltMenuEntityMappings()
		{
			this.AddElementMapping( "AltAltMenuEntity", @"Dhmi", @"dbo", "Alt_Alt_Menu", 9 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuAciklama", "Alt_Alt_Menu_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuAd", "Alt_Alt_Menu_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuDurum", "Alt_Alt_Menu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuId", "Alt_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuLink", "Alt_Alt_Menu_Link", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuSira", "Alt_Alt_Menu_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuSonLink", "Alt_Alt_Menu_Son_Link", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "AltAltMenuTarih", "Alt_Alt_Menu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "AltAltMenuEntity", "FkAltMenuId", "FK_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
		}
		/// <summary>Inits AltKarakterEntity's mappings</summary>
		private void InitAltKarakterEntityMappings()
		{
			this.AddElementMapping( "AltKarakterEntity", @"Dhmi", @"dbo", "Alt_Karakter", 3 );
			this.AddElementFieldMapping( "AltKarakterEntity", "AltKarakterAd", "Alt_Karakter_Ad", false, "NVarChar", 1, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AltKarakterEntity", "AltKarakterId", "Alt_Karakter_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "AltKarakterEntity", "AltKarakterNo", "Alt_Karakter_No", false, "NVarChar", 1, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits AltKonuEntity's mappings</summary>
		private void InitAltKonuEntityMappings()
		{
			this.AddElementMapping( "AltKonuEntity", @"Dhmi", @"dbo", "Alt_Konu", 5 );
			this.AddElementFieldMapping( "AltKonuEntity", "AltKonuAd", "Alt_Konu_Ad", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AltKonuEntity", "AltKonuDurum", "Alt_Konu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "AltKonuEntity", "AltKonuId", "Alt_Konu_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "AltKonuEntity", "AltKonuTarih", "Alt_Konu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "AltKonuEntity", "FkKonuId", "FK_Konu_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
		}
		/// <summary>Inits AltMenuEntity's mappings</summary>
		private void InitAltMenuEntityMappings()
		{
			this.AddElementMapping( "AltMenuEntity", @"Dhmi", @"dbo", "Alt_Menu", 9 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuAciklama", "Alt_Menu_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuAd", "Alt_Menu_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuDurum", "Alt_Menu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuId", "Alt_Menu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuLink", "Alt_Menu_Link", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuSira", "Alt_Menu_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuSonLink", "Alt_Menu_Son_Link", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "AltMenuEntity", "AltMenuTarih", "Alt_Menu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "AltMenuEntity", "FkMenuId", "FK_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
		}
		/// <summary>Inits BaskanlikEntity's mappings</summary>
		private void InitBaskanlikEntityMappings()
		{
			this.AddElementMapping( "BaskanlikEntity", @"Dhmi", @"dbo", "Baskanlik", 6 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikAd", "Baskanlik_Ad", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikAlt", "Baskanlik_Alt", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikCanliAd", "Baskanlik_Canli_Ad", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikId", "Baskanlik_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikKullaniciId", "Baskanlik_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "BaskanlikEntity", "BaskanlikSol", "Baskanlik_Sol", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 5 );
		}
		/// <summary>Inits BildirimEntity's mappings</summary>
		private void InitBildirimEntityMappings()
		{
			this.AddElementMapping( "BildirimEntity", @"Dhmi", @"dbo", "Bildirim", 26 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimAciklama", "Bildirim_Aciklama", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimAtanmaDurumu", "Bildirim_Atanma_Durumu", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimDavaAdSoyad", "Bildirim_Dava_Ad_Soyad", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimDavaDosyaNo", "Bildirim_Dava_Dosya_No", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimDavaKonu", "Bildirim_Dava_Konu", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimDavaMahkeme", "Bildirim_Dava_Mahkeme", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimGelenYer", "Bildirim_Gelen_Yer", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimGeriYapildiMi", "Bildirim_Geri_Yapildi_Mi", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimHavalimani", "Bildirim_Havalimani", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimId", "Bildirim_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 9 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimKimBitirdi", "Bildirim_Kim_Bitirdi", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 10 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimKonuDiger", "Bildirim_Konu_Diger", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimMetin", "Bildirim_Metin", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimSonIslemTarih", "Bildirim_Son_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimTarih", "Bildirim_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimToplamSure", "Bildirim_Toplam_Sure", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimVatandasKarar", "Bildirim_Vatandas_Karar", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimYil", "Bildirim_Yil", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 17 );
			this.AddElementFieldMapping( "BildirimEntity", "BildirimYonlendirilenKurum", "Bildirim_Yonlendirilen_Kurum", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 18 );
			this.AddElementFieldMapping( "BildirimEntity", "FkAltKonuId", "FK_Alt_Konu_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 19 );
			this.AddElementFieldMapping( "BildirimEntity", "FkBildirimGeriDonusId", "FK_Bildirim_Geri_Donus_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 20 );
			this.AddElementFieldMapping( "BildirimEntity", "FkBildirimSonucId", "FK_Bildirim_Sonuc_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 21 );
			this.AddElementFieldMapping( "BildirimEntity", "FkBildirimTuruId", "FK_Bildirim_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 22 );
			this.AddElementFieldMapping( "BildirimEntity", "FkCagriTipiId", "FK_Cagri_Tipi_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 23 );
			this.AddElementFieldMapping( "BildirimEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 24 );
			this.AddElementFieldMapping( "BildirimEntity", "FkVatandasId", "FK_Vatandas_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 25 );
		}
		/// <summary>Inits BildirimAtamaGrupEntity's mappings</summary>
		private void InitBildirimAtamaGrupEntityMappings()
		{
			this.AddElementMapping( "BildirimAtamaGrupEntity", @"Dhmi", @"dbo", "Bildirim_Atama_Grup", 5 );
			this.AddElementFieldMapping( "BildirimAtamaGrupEntity", "BildirimAtamaGrupId", "Bildirim_Atama_Grup_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "BildirimAtamaGrupEntity", "BildirimAtamaGrupTarih", "Bildirim_Atama_Grup_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "BildirimAtamaGrupEntity", "BildirimAtamaGrupYonMu", "Bildirim_Atama_Grup_Yon_mu", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BildirimAtamaGrupEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "BildirimAtamaGrupEntity", "FkGrupId", "FK_Grup_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
		}
		/// <summary>Inits BildirimAtamaKullaniciEntity's mappings</summary>
		private void InitBildirimAtamaKullaniciEntityMappings()
		{
			this.AddElementMapping( "BildirimAtamaKullaniciEntity", @"Dhmi", @"dbo", "Bildirim_Atama_Kullanici", 7 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciBittiMi", "Bildirim_Atama_Kullanici_Bitti_Mi", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciBittiTarih", "Bildirim_Atama_Kullanici_Bitti_Tarih", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciId", "Bildirim_Atama_Kullanici_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciTarih", "Bildirim_Atama_Kullanici_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "BildirimAtamaKullaniciYonMu", "Bildirim_Atama_Kullanici_Yon_mu", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "BildirimAtamaKullaniciEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
		}
		/// <summary>Inits BildirimGeriDonuEntity's mappings</summary>
		private void InitBildirimGeriDonuEntityMappings()
		{
			this.AddElementMapping( "BildirimGeriDonuEntity", @"Dhmi", @"dbo", "Bildirim_Geri_Donus", 4 );
			this.AddElementFieldMapping( "BildirimGeriDonuEntity", "BildirimGeriDonusAd", "Bildirim_Geri_Donus_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimGeriDonuEntity", "BildirimGeriDonusId", "Bildirim_Geri_Donus_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "BildirimGeriDonuEntity", "BildirimGeriDonusTarih", "Bildirim_Geri_Donus_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "BildirimGeriDonuEntity", "BildirimGeriDonusTur", "Bildirim_Geri_Donus_Tur", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
		}
		/// <summary>Inits BildirimHistoryEntity's mappings</summary>
		private void InitBildirimHistoryEntityMappings()
		{
			this.AddElementMapping( "BildirimHistoryEntity", @"Dhmi", @"dbo", "Bildirim_History", 7 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "BildirimHistoryAciklama", "Bildirim_History_Aciklama", false, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "BildirimHistoryId", "Bildirim_History_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "BildirimHistorySure", "Bildirim_History_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "BildirimHistoryTarih", "Bildirim_History_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "FkBildirimIslemId", "FK_Bildirim_Islem_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "BildirimHistoryEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
		}
		/// <summary>Inits BildirimIslemEntity's mappings</summary>
		private void InitBildirimIslemEntityMappings()
		{
			this.AddElementMapping( "BildirimIslemEntity", @"Dhmi", @"dbo", "Bildirim_Islem", 4 );
			this.AddElementFieldMapping( "BildirimIslemEntity", "BildirimIslemAd", "Bildirim_Islem_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimIslemEntity", "BildirimIslemDurum", "Bildirim_Islem_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "BildirimIslemEntity", "BildirimIslemId", "Bildirim_Islem_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "BildirimIslemEntity", "BildirimIslemTarih", "Bildirim_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits BildirimSonucEntity's mappings</summary>
		private void InitBildirimSonucEntityMappings()
		{
			this.AddElementMapping( "BildirimSonucEntity", @"Dhmi", @"dbo", "Bildirim_Sonuc", 4 );
			this.AddElementFieldMapping( "BildirimSonucEntity", "BildirimSonucAd", "Bildirim_Sonuc_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimSonucEntity", "BildirimSonucDurum", "Bildirim_Sonuc_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "BildirimSonucEntity", "BildirimSonucId", "Bildirim_Sonuc_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "BildirimSonucEntity", "BildirimSonucTarih", "Bildirim_Sonuc_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits BildirimTuruEntity's mappings</summary>
		private void InitBildirimTuruEntityMappings()
		{
			this.AddElementMapping( "BildirimTuruEntity", @"Dhmi", @"dbo", "Bildirim_Turu", 11 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruAd", "Bildirim_Turu_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruDurum", "Bildirim_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruIcerik", "Bildirim_Turu_Icerik", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruId", "Bildirim_Turu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruIncelemeSaatZaman", "Bildirim_Turu_Inceleme_Saat_Zaman", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruInclemeSure", "Bildirim_Turu_Incleme_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruIslemAlSaatZaman", "Bildirim_Turu_Islem_Al_Saat_Zaman", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 6 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruIslemAlSure", "Bildirim_Turu_Islem_Al_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruMail", "Bildirim_Turu_Mail", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruSms", "Bildirim_Turu_SMS", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "BildirimTuruEntity", "BildirimTuruTarih", "Bildirim_Turu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
		}
		/// <summary>Inits BilgiBankasiEntity's mappings</summary>
		private void InitBilgiBankasiEntityMappings()
		{
			this.AddElementMapping( "BilgiBankasiEntity", @"Dhmi", @"dbo", "Bilgi_Bankasi", 8 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiAd", "Bilgi_Bankasi_Ad", false, "NVarChar", 350, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiDosya", "Bilgi_Bankasi_Dosya", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiEtiket", "Bilgi_Bankasi_Etiket", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiIcerik", "Bilgi_Bankasi_Icerik", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiId", "Bilgi_Bankasi_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiSira", "Bilgi_Bankasi_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "BilgiBankasiTarih", "Bilgi_Bankasi_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "BilgiBankasiEntity", "FkBilgiBankasiTurId", "FK_Bilgi_Bankasi_Tur_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 7 );
		}
		/// <summary>Inits BilgiBankasiTurEntity's mappings</summary>
		private void InitBilgiBankasiTurEntityMappings()
		{
			this.AddElementMapping( "BilgiBankasiTurEntity", @"Dhmi", @"dbo", "Bilgi_Bankasi_Tur", 4 );
			this.AddElementFieldMapping( "BilgiBankasiTurEntity", "BilgiBankasiTurAd", "Bilgi_Bankasi_Tur_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BilgiBankasiTurEntity", "BilgiBankasiTurDurum", "Bilgi_Bankasi_Tur_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "BilgiBankasiTurEntity", "BilgiBankasiTurId", "Bilgi_Bankasi_Tur_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "BilgiBankasiTurEntity", "BilgiBankasiTurTarih", "Bilgi_Bankasi_Tur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits BilgilendirmeEntity's mappings</summary>
		private void InitBilgilendirmeEntityMappings()
		{
			this.AddElementMapping( "BilgilendirmeEntity", @"Dhmi", @"dbo", "Bilgilendirme", 5 );
			this.AddElementFieldMapping( "BilgilendirmeEntity", "BilgilendirmeGelenKullanici", "Bilgilendirme_Gelen_Kullanici", false, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "BilgilendirmeEntity", "BilgilendirmeGidenKullanici", "Bilgilendirme_Giden_Kullanici", false, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BilgilendirmeEntity", "BilgilendirmeIcerik", "Bilgilendirme_Icerik", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "BilgilendirmeEntity", "BilgilendirmeId", "Bilgilendirme_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "BilgilendirmeEntity", "BilgilendirmeTarih", "Bilgilendirme_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits CagriMerkezEntity's mappings</summary>
		private void InitCagriMerkezEntityMappings()
		{
			this.AddElementMapping( "CagriMerkezEntity", @"Dhmi", @"dbo", "Cagri_Merkez", 4 );
			this.AddElementFieldMapping( "CagriMerkezEntity", "CagriMerkezDurum", "Cagri_Merkez_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0 );
			this.AddElementFieldMapping( "CagriMerkezEntity", "CagriMerkezId", "Cagri_Merkez_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "CagriMerkezEntity", "CagriMerkezNo", "Cagri_Merkez_No", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CagriMerkezEntity", "CagriMerkezTarih", "Cagri_Merkez_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits CagriTipiEntity's mappings</summary>
		private void InitCagriTipiEntityMappings()
		{
			this.AddElementMapping( "CagriTipiEntity", @"Dhmi", @"dbo", "Cagri_Tipi", 4 );
			this.AddElementFieldMapping( "CagriTipiEntity", "CagriTipiAd", "Cagri_Tipi_Ad", false, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CagriTipiEntity", "CagriTipiDurum", "Cagri_Tipi_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "CagriTipiEntity", "CagriTipiId", "Cagri_Tipi_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "CagriTipiEntity", "CagriTipiTarih", "Cagri_Tipi_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits DigerBirimlerEntity's mappings</summary>
		private void InitDigerBirimlerEntityMappings()
		{
			this.AddElementMapping( "DigerBirimlerEntity", @"Dhmi", @"dbo", "Diger_Birimler", 8 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerAtandiSayi", "Diger_Birimler_Atandi_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerBirim", "Diger_Birimler_Birim", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerId", "Diger_Birimler_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerInceleniyorEkSureSayi", "Diger_Birimler_Inceleniyor_Ek_Sure_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerInceleniyorSayi", "Diger_Birimler_Inceleniyor_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerKullaniciId", "Diger_Birimler_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerReddedildiSayi", "Diger_Birimler_Reddedildi_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
			this.AddElementFieldMapping( "DigerBirimlerEntity", "DigerBirimlerSonuclandiSayi", "Diger_Birimler_Sonuclandi_Sayi", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 7 );
		}
		/// <summary>Inits DigerBirimlerAyrintiEntity's mappings</summary>
		private void InitDigerBirimlerAyrintiEntityMappings()
		{
			this.AddElementMapping( "DigerBirimlerAyrintiEntity", @"Dhmi", @"dbo", "Diger_Birimler_Ayrinti", 7 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiDurum", "Diger_Birimler_Ayrinti_Durum", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiIcerik", "Diger_Birimler_Ayrinti_Icerik", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiId", "Diger_Birimler_Ayrinti_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiKullaniciId", "Diger_Birimler_Ayrinti_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiNo", "Diger_Birimler_Ayrinti_No", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiSonDurum", "Diger_Birimler_Ayrinti_Son_Durum", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "DigerBirimlerAyrintiEntity", "DigerBirimlerAyrintiSure", "Diger_Birimler_Ayrinti_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DosyaEntity's mappings</summary>
		private void InitDosyaEntityMappings()
		{
			this.AddElementMapping( "DosyaEntity", @"Dhmi", @"dbo", "Dosya", 5 );
			this.AddElementFieldMapping( "DosyaEntity", "DosyaBildirimi", "Dosya_Bildirimi", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "DosyaEntity", "DosyaIcerikDurum", "Dosya_Icerik_Durum", false, "NChar", 10, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "DosyaEntity", "DosyaIcerikPath", "Dosya_Icerik_Path", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "DosyaEntity", "DosyaIcerikTarih", "Dosya_Icerik_Tarih", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "DosyaEntity", "DosyaId", "Dosya_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 4 );
		}
		/// <summary>Inits DuyuruEntity's mappings</summary>
		private void InitDuyuruEntityMappings()
		{
			this.AddElementMapping( "DuyuruEntity", @"Dhmi", @"dbo", "Duyuru", 9 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruBaslik", "Duyuru_Baslik", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruDurum", "Duyuru_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruIcerik", "Duyuru_Icerik", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruId", "Duyuru_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruLink", "Duyuru_Link", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruResim", "Duyuru_Resim", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruTarih", "Duyuru_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "DuyuruEntity", "DuyuruYayinTarih", "Duyuru_Yayin_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "DuyuruEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
		}
		/// <summary>Inits EkSureEntity's mappings</summary>
		private void InitEkSureEntityMappings()
		{
			this.AddElementMapping( "EkSureEntity", @"Dhmi", @"dbo", "Ek_Sure", 7 );
			this.AddElementFieldMapping( "EkSureEntity", "EkSureGun", "Ek_Sure_Gun", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "EkSureEntity", "EkSureId", "Ek_Sure_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "EkSureEntity", "EkSureSaat", "Ek_Sure_Saat", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "EkSureEntity", "EkSureTarih", "Ek_Sure_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "EkSureEntity", "EkSureTotal", "Ek_Sure_Total", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "EkSureEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "EkSureEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
		}
		/// <summary>Inits GecenSureEntity's mappings</summary>
		private void InitGecenSureEntityMappings()
		{
			this.AddElementMapping( "GecenSureEntity", @"Dhmi", @"dbo", "Gecen_Sure", 7 );
			this.AddElementFieldMapping( "GecenSureEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "GecenSureEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "GecenSureEntity", "GecenSureAciklama", "Gecen_Sure_Aciklama", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "GecenSureEntity", "GecenSureId", "Gecen_Sure_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "GecenSureEntity", "GecenSureTarih", "Gecen_Sure_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "GecenSureEntity", "GecenSureTotal", "Gecen_Sure_Total", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "GecenSureEntity", "GecenSureZaman", "Gecen_Sure_Zaman", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits GizliSoruTuruEntity's mappings</summary>
		private void InitGizliSoruTuruEntityMappings()
		{
			this.AddElementMapping( "GizliSoruTuruEntity", @"Dhmi", @"dbo", "Gizli_Soru_Turu", 4 );
			this.AddElementFieldMapping( "GizliSoruTuruEntity", "GizliSoruTuruAd", "Gizli_Soru_Turu_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "GizliSoruTuruEntity", "GizliSoruTuruDurum", "Gizli_Soru_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "GizliSoruTuruEntity", "GizliSoruTuruId", "Gizli_Soru_Turu_I", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "GizliSoruTuruEntity", "GizliSoruTuruTarih", "Gizli_Soru_Turu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits GorevEntity's mappings</summary>
		private void InitGorevEntityMappings()
		{
			this.AddElementMapping( "GorevEntity", @"Dhmi", @"dbo", "Gorev", 4 );
			this.AddElementFieldMapping( "GorevEntity", "GorevAd", "Gorev_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "GorevEntity", "GorevDurum", "Gorev_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "GorevEntity", "GorevId", "Gorev_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "GorevEntity", "GorevTarih", "Gorev_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits GrupEntity's mappings</summary>
		private void InitGrupEntityMappings()
		{
			this.AddElementMapping( "GrupEntity", @"Dhmi", @"dbo", "Grup", 8 );
			this.AddElementFieldMapping( "GrupEntity", "GrupAciklama", "Grup_Aciklama", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "GrupEntity", "GrupAd", "Grup_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "GrupEntity", "GrupAmir", "Grup_Amir", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "GrupEntity", "GrupDurum", "Grup_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "GrupEntity", "GrupId", "Grup_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "GrupEntity", "GrupIrtibat", "Grup_Irtibat", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "GrupEntity", "GrupKisaltma", "Grup_Kisaltma", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "GrupEntity", "GrupTarih", "Grup_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits GrupAtamaEntity's mappings</summary>
		private void InitGrupAtamaEntityMappings()
		{
			this.AddElementMapping( "GrupAtamaEntity", @"Dhmi", @"dbo", "Grup_Atama", 5 );
			this.AddElementFieldMapping( "GrupAtamaEntity", "FkGrupId", "FK_Grup_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "GrupAtamaEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "GrupAtamaEntity", "GrupAtamaDurum", "Grup_Atama_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "GrupAtamaEntity", "GrupAtamaId", "Grup_Atama_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "GrupAtamaEntity", "GrupAtamaTarih", "Grup_Atama_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits HavalimaniEntity's mappings</summary>
		private void InitHavalimaniEntityMappings()
		{
			this.AddElementMapping( "HavalimaniEntity", @"Dhmi", @"dbo", "Havalimani", 4 );
			this.AddElementFieldMapping( "HavalimaniEntity", "HavalimaniAd", "Havalimani_Ad", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "HavalimaniEntity", "HavalimaniDurum", "Havalimani_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "HavalimaniEntity", "HavalimaniId", "Havalimani_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "HavalimaniEntity", "HavalimaniTarih", "Havalimani_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits HiyerarsiTurEntity's mappings</summary>
		private void InitHiyerarsiTurEntityMappings()
		{
			this.AddElementMapping( "HiyerarsiTurEntity", @"Dhmi", @"dbo", "Hiyerarsi_Tur", 5 );
			this.AddElementFieldMapping( "HiyerarsiTurEntity", "HiyerarsiTurAd", "Hiyerarsi_Tur_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "HiyerarsiTurEntity", "HiyerarsiTurDurum", "Hiyerarsi_Tur_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "HiyerarsiTurEntity", "HiyerarsiTurId", "Hiyerarsi_Tur_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "HiyerarsiTurEntity", "HiyerarsiTurSira", "Hiyerarsi_Tur_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "HiyerarsiTurEntity", "HiyerarsiTurTarih", "Hiyerarsi_Tur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits IlEntity's mappings</summary>
		private void InitIlEntityMappings()
		{
			this.AddElementMapping( "IlEntity", @"Dhmi", @"dbo", "Il", 5 );
			this.AddElementFieldMapping( "IlEntity", "IlAd", "Il_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "IlEntity", "IlDurum", "Il_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "IlEntity", "IlId", "Il_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "IlEntity", "IlPlakaKodu", "Il_Plaka_Kodu", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "IlEntity", "IlTarih", "Il_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits IpBankEntity's mappings</summary>
		private void InitIpBankEntityMappings()
		{
			this.AddElementMapping( "IpBankEntity", @"Dhmi", @"dbo", "IP_Banks", 6 );
			this.AddElementFieldMapping( "IpBankEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "IpBankEntity", "IpBanksAciklama", "IP_Banks_Aciklama", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "IpBankEntity", "IpBanksAd", "IP_Banks_Ad", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "IpBankEntity", "IpBanksDurum", "IP_Banks_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			this.AddElementFieldMapping( "IpBankEntity", "IpBanksId", "IP_Banks_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "IpBankEntity", "IpBanksTarih", "IP_Banks_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits IslemEntity's mappings</summary>
		private void InitIslemEntityMappings()
		{
			this.AddElementMapping( "IslemEntity", @"Dhmi", @"dbo", "Islem", 8 );
			this.AddElementFieldMapping( "IslemEntity", "FkAltAltMenuId", "FK_Alt_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "IslemEntity", "FkAltMenuId", "FK_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "IslemEntity", "FkIslemTuruId", "FK_Islem_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "IslemEntity", "FkMenuId", "FK_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "IslemEntity", "IslemAd", "Islem_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "IslemEntity", "IslemId", "Islem_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "IslemEntity", "IslemSira", "Islem_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
			this.AddElementFieldMapping( "IslemEntity", "IslemTarih", "Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits IslemOlusturEntity's mappings</summary>
		private void InitIslemOlusturEntityMappings()
		{
			this.AddElementMapping( "IslemOlusturEntity", @"Dhmi", @"dbo", "Islem_Olustur", 4 );
			this.AddElementFieldMapping( "IslemOlusturEntity", "FkIslemId", "FK_Islem_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "IslemOlusturEntity", "FkYetkiId", "FK_Yetki_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "IslemOlusturEntity", "IslemOlusturId", "Islem_Olustur_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "IslemOlusturEntity", "IslemOlusturTarih", "Islem_Olustur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits IslemTuruEntity's mappings</summary>
		private void InitIslemTuruEntityMappings()
		{
			this.AddElementMapping( "IslemTuruEntity", @"Dhmi", @"dbo", "Islem_Turu", 4 );
			this.AddElementFieldMapping( "IslemTuruEntity", "IslemTuruAd", "Islem_Turu_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "IslemTuruEntity", "IslemTuruDurum", "Islem_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "IslemTuruEntity", "IslemTuruId", "Islem_Turu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "IslemTuruEntity", "IslemTuruTarih", "Islem_Turu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits IstatistikEntity's mappings</summary>
		private void InitIstatistikEntityMappings()
		{
			this.AddElementMapping( "IstatistikEntity", @"Dhmi", @"dbo", "Istatistik", 6 );
			this.AddElementFieldMapping( "IstatistikEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "IstatistikEntity", "IstatistikAd", "Istatistik_Ad", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "IstatistikEntity", "IstatistikAlt", "Istatistik_Alt", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "IstatistikEntity", "IstatistikCanliAd", "Istatistik_Canli_Ad", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "IstatistikEntity", "IstatistikId", "Istatistik_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "IstatistikEntity", "IstatistikSol", "Istatistik_Sol", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 5 );
		}
		/// <summary>Inits KapatmaTurEntity's mappings</summary>
		private void InitKapatmaTurEntityMappings()
		{
			this.AddElementMapping( "KapatmaTurEntity", @"Dhmi", @"dbo", "Kapatma_Tur", 4 );
			this.AddElementFieldMapping( "KapatmaTurEntity", "KapatmaTurAd", "Kapatma_Tur_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KapatmaTurEntity", "KapatmaTurDurum", "Kapatma_Tur_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "KapatmaTurEntity", "KapatmaTurId", "Kapatma_Tur_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "KapatmaTurEntity", "KapatmaTurTarih", "Kapatma_Tur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits KarakterEntity's mappings</summary>
		private void InitKarakterEntityMappings()
		{
			this.AddElementMapping( "KarakterEntity", @"Dhmi", @"dbo", "Karakter", 3 );
			this.AddElementFieldMapping( "KarakterEntity", "KarakterAd", "Karakter_Ad", false, "NVarChar", 1, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KarakterEntity", "KarakterId", "Karakter_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "KarakterEntity", "KarakterNo", "Karakter_No", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
		}
		/// <summary>Inits KaraListeEntity's mappings</summary>
		private void InitKaraListeEntityMappings()
		{
			this.AddElementMapping( "KaraListeEntity", @"Dhmi", @"dbo", "Kara_Liste", 10 );
			this.AddElementFieldMapping( "KaraListeEntity", "FkVatandasId", "FK_Vatandas_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeAciklama", "Kara_Liste_Aciklama", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeBslTarihSaat", "Kara_Liste_Bsl_Tarih_Saat", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeBtsTarihSaat", "Kara_Liste_Bts_Tarih_Saat", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeDurum", "Kara_Liste_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeId", "Kara_Liste_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeIptalEdenKullanici", "Kara_Liste_Iptal_Eden_Kullanici", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeIptalTarihi", "Kara_Liste_Iptal_Tarihi", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeIslemTarih", "Kara_Liste_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "KaraListeEntity", "KaraListeIslemYapan", "Kara_Liste_Islem_Yapan", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits KonuEntity's mappings</summary>
		private void InitKonuEntityMappings()
		{
			this.AddElementMapping( "KonuEntity", @"Dhmi", @"dbo", "Konu", 4 );
			this.AddElementFieldMapping( "KonuEntity", "KonuAd", "Konu_Ad", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KonuEntity", "KonuDurum", "Konu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "KonuEntity", "KonuId", "Konu_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "KonuEntity", "KonuTarih", "Konu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits KonusalDagilimEntity's mappings</summary>
		private void InitKonusalDagilimEntityMappings()
		{
			this.AddElementMapping( "KonusalDagilimEntity", @"Dhmi", @"dbo", "Konusal_Dagilim", 8 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimDurum", "Konusal_Dagilim_Durum", false, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimIcerik", "Konusal_Dagilim_Icerik", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimId", "Konusal_Dagilim_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimKonu", "Konusal_Dagilim_Konu", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimKullaniciId", "Konusal_Dagilim_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimNo", "Konusal_Dagilim_No", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimSonDurum", "Konusal_Dagilim_Son_Durum", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "KonusalDagilimEntity", "KonusalDagilimSure", "Konusal_Dagilim_Sure", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits KopukCagriEntity's mappings</summary>
		private void InitKopukCagriEntityMappings()
		{
			this.AddElementMapping( "KopukCagriEntity", @"Dhmi", @"dbo", "Kopuk_Cagri", 6 );
			this.AddElementFieldMapping( "KopukCagriEntity", "FkKopukCagriTuruId", "FK_Kopuk_Cagri_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "KopukCagriEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "KopukCagriEntity", "KopukCagriAciklama", "Kopuk_Cagri_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "KopukCagriEntity", "KopukCagriId", "Kopuk_Cagri_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "KopukCagriEntity", "KopukCagriTarih", "Kopuk_Cagri_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "KopukCagriEntity", "KopukCagriTelNo", "Kopuk_Cagri_Tel_No", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits KopukCagriTuruEntity's mappings</summary>
		private void InitKopukCagriTuruEntityMappings()
		{
			this.AddElementMapping( "KopukCagriTuruEntity", @"Dhmi", @"dbo", "Kopuk_Cagri_Turu", 4 );
			this.AddElementFieldMapping( "KopukCagriTuruEntity", "KopukCagriTuruAd", "Kopuk_Cagri_Turu_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KopukCagriTuruEntity", "KopukCagriTuruDurum", "Kopuk_Cagri_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "KopukCagriTuruEntity", "KopukCagriTuruId", "Kopuk_Cagri_Turu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "KopukCagriTuruEntity", "KopukCagriTuruTarih", "Kopuk_Cagri_Turu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits KpsArsivEntity's mappings</summary>
		private void InitKpsArsivEntityMappings()
		{
			this.AddElementMapping( "KpsArsivEntity", @"Dhmi", @"dbo", "Kps_Arsiv", 5 );
			this.AddElementFieldMapping( "KpsArsivEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "KpsArsivEntity", "KpsArsivDurum", "Kps_Arsiv_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "KpsArsivEntity", "KpsArsivId", "Kps_Arsiv_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "KpsArsivEntity", "KpsArsivTarih", "Kps_Arsiv_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "KpsArsivEntity", "KpsArsivTcNo", "Kps_Arsiv_Tc_No", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
		}
		/// <summary>Inits KpsBilgiEntity's mappings</summary>
		private void InitKpsBilgiEntityMappings()
		{
			this.AddElementMapping( "KpsBilgiEntity", @"Dhmi", @"dbo", "Kps_Bilgi", 22 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiAd", "Kps_Bilgi_Ad", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiAnneAd", "Kps_Bilgi_Anne_Ad", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiBabaAd", "Kps_Bilgi_Baba_Ad", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiCaddeSokak", "Kps_Bilgi_Cadde_Sokak", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiCinsiyet", "Kps_Bilgi_Cinsiyet", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiDis", "Kps_Bilgi_Dis", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiDogumTarihi", "Kps_Bilgi_Dogum_Tarihi", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiDogumYeri", "Kps_Bilgi_Dogum_Yeri", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiIc", "Kps_Bilgi_Ic", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiId", "Kps_Bilgi_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 9 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiIl", "Kps_Bilgi_Il", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiIlce", "Kps_Bilgi_Ilce", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiKayitNo", "Kps_Bilgi_Kayit_No", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiMahalle", "Kps_Bilgi_Mahalle", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiMedeniHal", "Kps_Bilgi_Medeni_Hal", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiNo", "Kps_Bilgi_No", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiSeri", "Kps_Bilgi_Seri", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiSiteBlok", "Kps_Bilgi_Site_Blok", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiSoyad", "Kps_Bilgi_Soyad", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 18 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiTarih", "Kps_Bilgi_Tarih", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 19 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiTcKimlik", "Kps_Bilgi_TC_Kimlik", true, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 20 );
			this.AddElementFieldMapping( "KpsBilgiEntity", "KpsBilgiUyruk", "Kps_Bilgi_Uyruk", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 21 );
		}
		/// <summary>Inits KullaniciEntity's mappings</summary>
		private void InitKullaniciEntityMappings()
		{
			this.AddElementMapping( "KullaniciEntity", @"Dhmi", @"dbo", "Kullanici", 19 );
			this.AddElementFieldMapping( "KullaniciEntity", "AvayaLoginId", "AvayaLoginId", true, "NVarChar", 6, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KullaniciEntity", "Extension", "Extension", true, "NVarChar", 5, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "KullaniciEntity", "FkGorevId", "FK_Gorev_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "KullaniciEntity", "FkHiyerarsiTurId", "FK_Hiyerarsi_Tur_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "KullaniciEntity", "FkYetkiId", "FK_Yetki_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciAciklama", "Kullanici_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciAd", "Kullanici_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciAdSoyad", "Kullanici_Ad_Soyad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciBirim", "Kullanici_Birim", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciDurum", "Kullanici_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciGizliSoru", "Kullanici_Gizli_Soru", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciGizliSoruCevap", "Kullanici_Gizli_Soru_Cevap", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciId", "Kullanici_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 12 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciMail", "Kullanici_Mail", true, "NVarChar", 70, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciPassword", "Kullanici_Password", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciSoyad", "Kullanici_Soyad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciTarih", "Kullanici_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			this.AddElementFieldMapping( "KullaniciEntity", "KullaniciUsername", "Kullanici_Username", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "KullaniciEntity", "TcKimlikNo", "TcKimlikNo", true, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits KulTcNoEntity's mappings</summary>
		private void InitKulTcNoEntityMappings()
		{
			this.AddElementMapping( "KulTcNoEntity", @"Dhmi", @"dbo", "Kul_Tc_No", 3 );
			this.AddElementFieldMapping( "KulTcNoEntity", "KulTcNoId", "Kul_Tc_No_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "KulTcNoEntity", "KulTcNoNumara", "Kul_Tc_No_Numara", false, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "KulTcNoEntity", "KulTcNoTarih", "Kul_Tc_No_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
		}
		/// <summary>Inits LogEntity's mappings</summary>
		private void InitLogEntityMappings()
		{
			this.AddElementMapping( "LogEntity", @"Dhmi", @"dbo", "Log", 6 );
			this.AddElementFieldMapping( "LogEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "LogEntity", "FkLogIslemId", "FK_Log_Islem_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "LogEntity", "LogAciklama", "Log_Aciklama", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "LogEntity", "LogId", "Log_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "LogEntity", "LogIpsi", "Log_IPsi", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "LogEntity", "LogTarih", "Log_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits LogEmailEntity's mappings</summary>
		private void InitLogEmailEntityMappings()
		{
			this.AddElementMapping( "LogEmailEntity", @"Dhmi", @"dbo", "Log_Email", 11 );
			this.AddElementFieldMapping( "LogEmailEntity", "FkBildirimId", "FK_Bildirim_ID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailBcc", "Log_Email_Bcc", true, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailCc", "Log_Email_Cc", true, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailContent", "Log_Email_Content", true, "Text", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailCreatedDateTime", "Log_Email_CreatedDateTime", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailFrom", "Log_Email_From", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailId", "Log_Email_ID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailSendDateTime", "Log_Email_SendDateTime", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailSendStatus", "Log_Email_SendStatus", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailSubject", "Log_Email_Subject", true, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "LogEmailEntity", "LogEmailTo", "Log_Email_To", true, "NVarChar", 2000, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits LogHataEntity's mappings</summary>
		private void InitLogHataEntityMappings()
		{
			this.AddElementMapping( "LogHataEntity", @"Dhmi", @"dbo", "Log_Hata", 9 );
			this.AddElementFieldMapping( "LogHataEntity", "Duzeltildi", "Duzeltildi", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 0 );
			this.AddElementFieldMapping( "LogHataEntity", "Ekran", "Ekran", true, "VarChar", 500, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "LogHataEntity", "FkKullaniciDuzeltenId", "FK_Kullanici_Duzelten_ID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "LogHataEntity", "FkKullaniciId", "FK_Kullanici_ID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "LogHataEntity", "LogHataId", "Log_Hata_ID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "LogHataEntity", "Mesaj", "Mesaj", true, "Text", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "LogHataEntity", "Method", "Method", true, "Text", 2147483647, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "LogHataEntity", "Tarih", "Tarih", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "LogHataEntity", "Trace", "Trace", true, "Text", 2147483647, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits LogIslemEntity's mappings</summary>
		private void InitLogIslemEntityMappings()
		{
			this.AddElementMapping( "LogIslemEntity", @"Dhmi", @"dbo", "Log_Islem", 4 );
			this.AddElementFieldMapping( "LogIslemEntity", "LogIslemAd", "Log_Islem_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "LogIslemEntity", "LogIslemDurum", "Log_Islem_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "LogIslemEntity", "LogIslemId", "Log_Islem_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "LogIslemEntity", "LogIslemTarih", "Log_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits LogSmEntity's mappings</summary>
		private void InitLogSmEntityMappings()
		{
			this.AddElementMapping( "LogSmEntity", @"Dhmi", @"dbo", "Log_Sms", 7 );
			this.AddElementFieldMapping( "LogSmEntity", "FkBildirimId", "FK_Bildirim_ID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsCreatedDate", "Log_Sms_CreatedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsGsmNumber", "Log_Sms_GsmNumber", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsId", "Log_Sms_ID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsMessage", "Log_Sms_Message", true, "NVarChar", 480, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsSender", "Log_Sms_Sender", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "LogSmEntity", "LogSmsSmsId", "Log_Sms_SmsId", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits MailBankEntity's mappings</summary>
		private void InitMailBankEntityMappings()
		{
			this.AddElementMapping( "MailBankEntity", @"Dhmi", @"dbo", "Mail_Banks", 7 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksBildirim", "Mail_Banks_Bildirim", true, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksDurum", "Mail_Banks_Durum", true, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksId", "Mail_Banks_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksKullanici", "Mail_Banks_Kullanici", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksLink", "Mail_Banks_Link", true, "NVarChar", 300, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksTarih", "Mail_Banks_Tarih", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "MailBankEntity", "MailBanksTikAdet", "Mail_Banks_Tik_Adet", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
		}
		/// <summary>Inits MenuEntity's mappings</summary>
		private void InitMenuEntityMappings()
		{
			this.AddElementMapping( "MenuEntity", @"Dhmi", @"dbo", "Menu", 8 );
			this.AddElementFieldMapping( "MenuEntity", "MenuAciklama", "Menu_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "MenuEntity", "MenuAd", "Menu_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "MenuEntity", "MenuDurum", "Menu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "MenuEntity", "MenuId", "Menu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "MenuEntity", "MenuLink", "Menu_Link", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "MenuEntity", "MenuSira", "Menu_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "MenuEntity", "MenuSonLink", "Menu_Son_Link", true, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "MenuEntity", "MenuTarih", "Menu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits MenuOlusturEntity's mappings</summary>
		private void InitMenuOlusturEntityMappings()
		{
			this.AddElementMapping( "MenuOlusturEntity", @"Dhmi", @"dbo", "Menu_Olustur", 7 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "FkAltAltMenuId", "FK_Alt_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "FkAltMenuId", "FK_Alt_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "FkMenuId", "FK_Menu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "FkYetkiId", "FK_Yetki_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "MenuOlusturId", "Menu_Olustur_ID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "MenuOlusturSayi", "Menu_Olustur_Sayi", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "MenuOlusturEntity", "MenuOlusturTarih", "Menu_Olustur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
		}
		/// <summary>Inits MesajEntity's mappings</summary>
		private void InitMesajEntityMappings()
		{
			this.AddElementMapping( "MesajEntity", @"Dhmi", @"dbo", "Mesaj", 6 );
			this.AddElementFieldMapping( "MesajEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "MesajEntity", "MesajBaslik", "Mesaj_Baslik", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "MesajEntity", "MesajHangiKullanici", "Mesaj_Hangi_Kullanici", false, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "MesajEntity", "MesajIcerik", "Mesaj_Icerik", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "MesajEntity", "MesajId", "Mesaj_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "MesajEntity", "MesajTarih", "Mesaj_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits ParametreEntity's mappings</summary>
		private void InitParametreEntityMappings()
		{
			this.AddElementMapping( "ParametreEntity", @"Dhmi", @"dbo", "Parametre", 8 );
			this.AddElementFieldMapping( "ParametreEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "ParametreEntity", "FkParametreTurId", "FK_Parametre_Tur_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreAd", "Parametre_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreBasTarih", "Parametre_Bas_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreBitTarih", "Parametre_Bit_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreDeger", "Parametre_Deger", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreId", "Parametre_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 6 );
			this.AddElementFieldMapping( "ParametreEntity", "ParametreIslemTarih", "Parametre_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
		}
		/// <summary>Inits ParametreGenelArsivEntity's mappings</summary>
		private void InitParametreGenelArsivEntityMappings()
		{
			this.AddElementMapping( "ParametreGenelArsivEntity", @"Dhmi", @"dbo", "Parametre_Genel_Arsiv", 11 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "FkParametreId", "FK_Parametre_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivAd", "Parametre_Genel_Arsiv_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivBasTarih", "Parametre_Genel_Arsiv_Bas_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivBitTarih", "Parametre_Genel_Arsiv_Bit_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivId", "Parametre_Genel_Arsiv_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivKullanici", "Parametre_Genel_Arsiv_Kullanici", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivNew", "Parametre_Genel_Arsiv_New", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivOld", "Parametre_Genel_Arsiv_Old", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivTarih", "Parametre_Genel_Arsiv_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			this.AddElementFieldMapping( "ParametreGenelArsivEntity", "ParametreGenelArsivTur", "Parametre_Genel_Arsiv_Tur", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits ParametreTurEntity's mappings</summary>
		private void InitParametreTurEntityMappings()
		{
			this.AddElementMapping( "ParametreTurEntity", @"Dhmi", @"dbo", "Parametre_Tur", 5 );
			this.AddElementFieldMapping( "ParametreTurEntity", "ParametreTurAciklama", "Parametre_Tur_Aciklama", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ParametreTurEntity", "ParametreTurAd", "Parametre_Tur_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ParametreTurEntity", "ParametreTurDurum", "Parametre_Tur_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "ParametreTurEntity", "ParametreTurId", "Parametre_Tur_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "ParametreTurEntity", "ParametreTurTarih", "Parametre_Tur_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits RaporIcerikEntity's mappings</summary>
		private void InitRaporIcerikEntityMappings()
		{
			this.AddElementMapping( "RaporIcerikEntity", @"Dhmi", @"dbo", "Rapor_Icerik", 6 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "FkRaporTuruId", "FK_Rapor_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "RaporIcerikAnaVeri", "Rapor_Icerik_Ana_Veri", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "RaporIcerikDurum", "Rapor_Icerik_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "RaporIcerikId", "Rapor_Icerik_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "RaporIcerikKolon", "Rapor_Icerik_Kolon", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "RaporIcerikEntity", "RaporIcerikTarih", "Rapor_Icerik_Tarih", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}
		/// <summary>Inits RaporTuruEntity's mappings</summary>
		private void InitRaporTuruEntityMappings()
		{
			this.AddElementMapping( "RaporTuruEntity", @"Dhmi", @"dbo", "Rapor_Turu", 4 );
			this.AddElementFieldMapping( "RaporTuruEntity", "RaporTuruAd", "Rapor_Turu_Ad", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RaporTuruEntity", "RaporTuruDurum", "Rapor_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "RaporTuruEntity", "RaporTuruId", "Rapor_Turu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "RaporTuruEntity", "RaporTuruTarih", "Rapor_Turu_Tarih", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits RaporYetkiEntity's mappings</summary>
		private void InitRaporYetkiEntityMappings()
		{
			this.AddElementMapping( "RaporYetkiEntity", @"Dhmi", @"dbo", "Rapor_Yetki", 5 );
			this.AddElementFieldMapping( "RaporYetkiEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "RaporYetkiEntity", "FkRaporTuruId", "FK_Rapor_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "RaporYetkiEntity", "RaporYetkiDurum", "Rapor_Yetki_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "RaporYetkiEntity", "RaporYetkiId", "Rapor_Yetki_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "RaporYetkiEntity", "RaporYetkiTarih", "Rapor_Yetki_Tarih", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits SorunEntity's mappings</summary>
		private void InitSorunEntityMappings()
		{
			this.AddElementMapping( "SorunEntity", @"Dhmi", @"dbo", "Sorun", 10 );
			this.AddElementFieldMapping( "SorunEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "SorunEntity", "FkSorunTuruId", "FK_Sorun_Turu_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "SorunEntity", "SorunAciklama", "Sorun_Aciklama", false, "NVarChar", 750, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SorunEntity", "SorunCevaplandiMi", "Sorun_Cevaplandi_Mi", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "SorunEntity", "SorunCevapTarih", "Sorun_Cevap_Tarih", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SorunEntity", "SorunCozum", "Sorun_Cozum", false, "NVarChar", 750, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "SorunEntity", "SorunId", "Sorun_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 6 );
			this.AddElementFieldMapping( "SorunEntity", "SorunIrtibat", "Sorun_Irtibat", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "SorunEntity", "SorunOneri", "Sorun_Oneri", false, "NVarChar", 200, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "SorunEntity", "SorunTarih", "Sorun_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
		}
		/// <summary>Inits SorunTuruEntity's mappings</summary>
		private void InitSorunTuruEntityMappings()
		{
			this.AddElementMapping( "SorunTuruEntity", @"Dhmi", @"dbo", "Sorun_Turu", 4 );
			this.AddElementFieldMapping( "SorunTuruEntity", "SorunTuruAd", "Sorun_Turu_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "SorunTuruEntity", "SorunTuruDurum", "Sorun_Turu_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "SorunTuruEntity", "SorunTuruId", "Sorun_Turu_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "SorunTuruEntity", "SorunTuruTarih", "Sorun_Turu_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits SureTakipEntity's mappings</summary>
		private void InitSureTakipEntityMappings()
		{
			this.AddElementMapping( "SureTakipEntity", @"Dhmi", @"dbo", "Sure_Takip", 6 );
			this.AddElementFieldMapping( "SureTakipEntity", "FkBildirimId", "FK_Bildirim_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "SureTakipEntity", "SureTakipGun", "Sure_Takip_Gun", false, "Float", 0, 0, 38, false, "", null, typeof(System.Double), 1 );
			this.AddElementFieldMapping( "SureTakipEntity", "SureTakipId", "Sure_Takip_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "SureTakipEntity", "SureTakipSaat", "Sure_Takip_Saat", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "SureTakipEntity", "SureTakipTarih", "Sure_Takip_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			this.AddElementFieldMapping( "SureTakipEntity", "SureTakipTuru", "Sure_Takip_Turu", false, "NVarChar", 150, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits TurBankEntity's mappings</summary>
		private void InitTurBankEntityMappings()
		{
			this.AddElementMapping( "TurBankEntity", @"Dhmi", @"dbo", "Tur_Banks", 5 );
			this.AddElementFieldMapping( "TurBankEntity", "TurBanksAd", "Tur_Banks_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "TurBankEntity", "TurBanksDurum", "Tur_Banks_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "TurBankEntity", "TurBanksId", "Tur_Banks_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "TurBankEntity", "TurBanksTable", "Tur_Banks_Table", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "TurBankEntity", "TurBanksTarih", "Tur_Banks_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits VatandaEntity's mappings</summary>
		private void InitVatandaEntityMappings()
		{
			this.AddElementMapping( "VatandaEntity", @"Dhmi", @"dbo", "Vatandas", 19 );
			this.AddElementFieldMapping( "VatandaEntity", "FkKullaniciId", "FK_Kullanici_ID", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 0 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasAd", "Vatandas_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasAdres", "Vatandas_Adres", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasAdSoyad", "Vatandas_Ad_Soyad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasCinsiyet", "Vatandas_Cinsiyet", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasDogumTarihi", "Vatandas_Dogum_Tarihi", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasFax", "Vatandas_Fax", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasId", "Vatandas_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 7 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasIslemTarih", "Vatandas_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasMail", "Vatandas_Mail", true, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasNotes", "Vatandas_Notes", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasPasaportNo", "Vatandas_Pasaport_No", true, "NVarChar", 75, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasSoyad", "Vatandas_Soyad", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasTcNo", "Vatandas_TC_No", true, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasTel1", "Vatandas_Tel_1", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasTel2", "Vatandas_Tel_2", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasTur", "Vatandas_Tur", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasUyruk", "Vatandas_Uyruk", false, "NVarChar", 35, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "VatandaEntity", "VatandasVergiNo", "Vatandas_Vergi_No", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits VatandasArsivEntity's mappings</summary>
		private void InitVatandasArsivEntityMappings()
		{
			this.AddElementMapping( "VatandasArsivEntity", @"Dhmi", @"dbo", "Vatandas_Arsiv", 4 );
			this.AddElementFieldMapping( "VatandasArsivEntity", "FkVatandasId", "FK_Vatandas_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "VatandasArsivEntity", "VatandasArsivAciklama", "Vatandas_Arsiv_Aciklama", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "VatandasArsivEntity", "VatandasArsivId", "Vatandas_Arsiv_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "VatandasArsivEntity", "VatandasArsivIslemTarih", "Vatandas_Arsiv_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits VipListeEntity's mappings</summary>
		private void InitVipListeEntityMappings()
		{
			this.AddElementMapping( "VipListeEntity", @"Dhmi", @"dbo", "Vip_Liste", 10 );
			this.AddElementFieldMapping( "VipListeEntity", "FkVatandasId", "FK_Vatandas_ID", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeAciklama", "Vip_Liste_Aciklama", false, "NVarChar", 1000, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeBslTarihSaat", "Vip_Liste_Bsl_Tarih_Saat", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeBtsTarihSaat", "Vip_Liste_Bts_Tarih_Saat", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeDurum", "Vip_Liste_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeId", "Vip_Liste_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeIptalEdenKullanici", "Vip_Liste_Iptal_Eden_Kullanici", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeIptalTarihi", "Vip_Liste_Iptal_Tarihi", true, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeIslemTarih", "Vip_Liste_Islem_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			this.AddElementFieldMapping( "VipListeEntity", "VipListeIslemYapan", "Vip_Liste_Islem_Yapan", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits WebServiEntity's mappings</summary>
		private void InitWebServiEntityMappings()
		{
			this.AddElementMapping( "WebServiEntity", @"Dhmi", @"dbo", "Web_Servis", 5 );
			this.AddElementFieldMapping( "WebServiEntity", "WebServisAlan1", "Web_Servis_Alan_1", false, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "WebServiEntity", "WebServisAlan2", "Web_Servis_Alan_2", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "WebServiEntity", "WebServisAlan3", "Web_Servis_Alan_3", true, "NVarChar", 500, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "WebServiEntity", "WebServisId", "Web_Servis_ID", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "WebServiEntity", "WebServisKullaniciKim", "Web_Servis_Kullanici_Kim", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
		}
		/// <summary>Inits YetkiEntity's mappings</summary>
		private void InitYetkiEntityMappings()
		{
			this.AddElementMapping( "YetkiEntity", @"Dhmi", @"dbo", "Yetki", 5 );
			this.AddElementFieldMapping( "YetkiEntity", "YetkiAciklama", "Yetki_Aciklama", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "YetkiEntity", "YetkiAd", "Yetki_Ad", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "YetkiEntity", "YetkiDurum", "Yetki_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			this.AddElementFieldMapping( "YetkiEntity", "YetkiId", "Yetki_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "YetkiEntity", "YetkiTarih", "Yetki_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
		}
		/// <summary>Inits ZamanEntity's mappings</summary>
		private void InitZamanEntityMappings()
		{
			this.AddElementMapping( "ZamanEntity", @"Dhmi", @"dbo", "Zaman", 6 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanAd", "Zaman_Ad", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanDurum", "Zaman_Durum", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanId", "Zaman_ID", false, "SmallInt", 0, 0, 5, true, "SCOPE_IDENTITY()", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanSaat", "Zaman_Saat", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanSira", "Zaman_Sira", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 4 );
			this.AddElementFieldMapping( "ZamanEntity", "ZamanTarih", "Zaman_Tarih", false, "SmallDateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
		}

	}
}