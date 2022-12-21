///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:35
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using dhmi.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace dhmi.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField(fieldName, targetAlias, typeof(TValue));
		}
						
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		
		/// <summary>Creates and returns a new EntityQuery for the AcikBildirim entity</summary>
		public EntityQuery<AcikBildirimEntity> AcikBildirim
		{
			get { return Create<AcikBildirimEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AcikBildirimAyrinti entity</summary>
		public EntityQuery<AcikBildirimAyrintiEntity> AcikBildirimAyrinti
		{
			get { return Create<AcikBildirimAyrintiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AltAltMenu entity</summary>
		public EntityQuery<AltAltMenuEntity> AltAltMenu
		{
			get { return Create<AltAltMenuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AltKarakter entity</summary>
		public EntityQuery<AltKarakterEntity> AltKarakter
		{
			get { return Create<AltKarakterEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AltKonu entity</summary>
		public EntityQuery<AltKonuEntity> AltKonu
		{
			get { return Create<AltKonuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AltMenu entity</summary>
		public EntityQuery<AltMenuEntity> AltMenu
		{
			get { return Create<AltMenuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Baskanlik entity</summary>
		public EntityQuery<BaskanlikEntity> Baskanlik
		{
			get { return Create<BaskanlikEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Bildirim entity</summary>
		public EntityQuery<BildirimEntity> Bildirim
		{
			get { return Create<BildirimEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimAtamaGrup entity</summary>
		public EntityQuery<BildirimAtamaGrupEntity> BildirimAtamaGrup
		{
			get { return Create<BildirimAtamaGrupEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimAtamaKullanici entity</summary>
		public EntityQuery<BildirimAtamaKullaniciEntity> BildirimAtamaKullanici
		{
			get { return Create<BildirimAtamaKullaniciEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimGeriDonu entity</summary>
		public EntityQuery<BildirimGeriDonuEntity> BildirimGeriDonu
		{
			get { return Create<BildirimGeriDonuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimHistory entity</summary>
		public EntityQuery<BildirimHistoryEntity> BildirimHistory
		{
			get { return Create<BildirimHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimIslem entity</summary>
		public EntityQuery<BildirimIslemEntity> BildirimIslem
		{
			get { return Create<BildirimIslemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimSonuc entity</summary>
		public EntityQuery<BildirimSonucEntity> BildirimSonuc
		{
			get { return Create<BildirimSonucEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BildirimTuru entity</summary>
		public EntityQuery<BildirimTuruEntity> BildirimTuru
		{
			get { return Create<BildirimTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BilgiBankasi entity</summary>
		public EntityQuery<BilgiBankasiEntity> BilgiBankasi
		{
			get { return Create<BilgiBankasiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BilgiBankasiTur entity</summary>
		public EntityQuery<BilgiBankasiTurEntity> BilgiBankasiTur
		{
			get { return Create<BilgiBankasiTurEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Bilgilendirme entity</summary>
		public EntityQuery<BilgilendirmeEntity> Bilgilendirme
		{
			get { return Create<BilgilendirmeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CagriMerkez entity</summary>
		public EntityQuery<CagriMerkezEntity> CagriMerkez
		{
			get { return Create<CagriMerkezEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CagriTipi entity</summary>
		public EntityQuery<CagriTipiEntity> CagriTipi
		{
			get { return Create<CagriTipiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the DigerBirimler entity</summary>
		public EntityQuery<DigerBirimlerEntity> DigerBirimler
		{
			get { return Create<DigerBirimlerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the DigerBirimlerAyrinti entity</summary>
		public EntityQuery<DigerBirimlerAyrintiEntity> DigerBirimlerAyrinti
		{
			get { return Create<DigerBirimlerAyrintiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Dosya entity</summary>
		public EntityQuery<DosyaEntity> Dosya
		{
			get { return Create<DosyaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Duyuru entity</summary>
		public EntityQuery<DuyuruEntity> Duyuru
		{
			get { return Create<DuyuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EkSure entity</summary>
		public EntityQuery<EkSureEntity> EkSure
		{
			get { return Create<EkSureEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the GecenSure entity</summary>
		public EntityQuery<GecenSureEntity> GecenSure
		{
			get { return Create<GecenSureEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the GizliSoruTuru entity</summary>
		public EntityQuery<GizliSoruTuruEntity> GizliSoruTuru
		{
			get { return Create<GizliSoruTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Gorev entity</summary>
		public EntityQuery<GorevEntity> Gorev
		{
			get { return Create<GorevEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Grup entity</summary>
		public EntityQuery<GrupEntity> Grup
		{
			get { return Create<GrupEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the GrupAtama entity</summary>
		public EntityQuery<GrupAtamaEntity> GrupAtama
		{
			get { return Create<GrupAtamaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Havalimani entity</summary>
		public EntityQuery<HavalimaniEntity> Havalimani
		{
			get { return Create<HavalimaniEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the HiyerarsiTur entity</summary>
		public EntityQuery<HiyerarsiTurEntity> HiyerarsiTur
		{
			get { return Create<HiyerarsiTurEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Il entity</summary>
		public EntityQuery<IlEntity> Il
		{
			get { return Create<IlEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the IpBank entity</summary>
		public EntityQuery<IpBankEntity> IpBank
		{
			get { return Create<IpBankEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Islem entity</summary>
		public EntityQuery<IslemEntity> Islem
		{
			get { return Create<IslemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the IslemOlustur entity</summary>
		public EntityQuery<IslemOlusturEntity> IslemOlustur
		{
			get { return Create<IslemOlusturEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the IslemTuru entity</summary>
		public EntityQuery<IslemTuruEntity> IslemTuru
		{
			get { return Create<IslemTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Istatistik entity</summary>
		public EntityQuery<IstatistikEntity> Istatistik
		{
			get { return Create<IstatistikEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KapatmaTur entity</summary>
		public EntityQuery<KapatmaTurEntity> KapatmaTur
		{
			get { return Create<KapatmaTurEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Karakter entity</summary>
		public EntityQuery<KarakterEntity> Karakter
		{
			get { return Create<KarakterEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KaraListe entity</summary>
		public EntityQuery<KaraListeEntity> KaraListe
		{
			get { return Create<KaraListeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Konu entity</summary>
		public EntityQuery<KonuEntity> Konu
		{
			get { return Create<KonuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KonusalDagilim entity</summary>
		public EntityQuery<KonusalDagilimEntity> KonusalDagilim
		{
			get { return Create<KonusalDagilimEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KopukCagri entity</summary>
		public EntityQuery<KopukCagriEntity> KopukCagri
		{
			get { return Create<KopukCagriEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KopukCagriTuru entity</summary>
		public EntityQuery<KopukCagriTuruEntity> KopukCagriTuru
		{
			get { return Create<KopukCagriTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KpsArsiv entity</summary>
		public EntityQuery<KpsArsivEntity> KpsArsiv
		{
			get { return Create<KpsArsivEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KpsBilgi entity</summary>
		public EntityQuery<KpsBilgiEntity> KpsBilgi
		{
			get { return Create<KpsBilgiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Kullanici entity</summary>
		public EntityQuery<KullaniciEntity> Kullanici
		{
			get { return Create<KullaniciEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the KulTcNo entity</summary>
		public EntityQuery<KulTcNoEntity> KulTcNo
		{
			get { return Create<KulTcNoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Log entity</summary>
		public EntityQuery<LogEntity> Log
		{
			get { return Create<LogEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LogEmail entity</summary>
		public EntityQuery<LogEmailEntity> LogEmail
		{
			get { return Create<LogEmailEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LogHata entity</summary>
		public EntityQuery<LogHataEntity> LogHata
		{
			get { return Create<LogHataEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LogIslem entity</summary>
		public EntityQuery<LogIslemEntity> LogIslem
		{
			get { return Create<LogIslemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the LogSm entity</summary>
		public EntityQuery<LogSmEntity> LogSm
		{
			get { return Create<LogSmEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the MailBank entity</summary>
		public EntityQuery<MailBankEntity> MailBank
		{
			get { return Create<MailBankEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Menu entity</summary>
		public EntityQuery<MenuEntity> Menu
		{
			get { return Create<MenuEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the MenuOlustur entity</summary>
		public EntityQuery<MenuOlusturEntity> MenuOlustur
		{
			get { return Create<MenuOlusturEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Mesaj entity</summary>
		public EntityQuery<MesajEntity> Mesaj
		{
			get { return Create<MesajEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Parametre entity</summary>
		public EntityQuery<ParametreEntity> Parametre
		{
			get { return Create<ParametreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ParametreGenelArsiv entity</summary>
		public EntityQuery<ParametreGenelArsivEntity> ParametreGenelArsiv
		{
			get { return Create<ParametreGenelArsivEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ParametreTur entity</summary>
		public EntityQuery<ParametreTurEntity> ParametreTur
		{
			get { return Create<ParametreTurEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RaporIcerik entity</summary>
		public EntityQuery<RaporIcerikEntity> RaporIcerik
		{
			get { return Create<RaporIcerikEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RaporTuru entity</summary>
		public EntityQuery<RaporTuruEntity> RaporTuru
		{
			get { return Create<RaporTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the RaporYetki entity</summary>
		public EntityQuery<RaporYetkiEntity> RaporYetki
		{
			get { return Create<RaporYetkiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Sorun entity</summary>
		public EntityQuery<SorunEntity> Sorun
		{
			get { return Create<SorunEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SorunTuru entity</summary>
		public EntityQuery<SorunTuruEntity> SorunTuru
		{
			get { return Create<SorunTuruEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SureTakip entity</summary>
		public EntityQuery<SureTakipEntity> SureTakip
		{
			get { return Create<SureTakipEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the TurBank entity</summary>
		public EntityQuery<TurBankEntity> TurBank
		{
			get { return Create<TurBankEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Vatanda entity</summary>
		public EntityQuery<VatandaEntity> Vatanda
		{
			get { return Create<VatandaEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the VatandasArsiv entity</summary>
		public EntityQuery<VatandasArsivEntity> VatandasArsiv
		{
			get { return Create<VatandasArsivEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the VipListe entity</summary>
		public EntityQuery<VipListeEntity> VipListe
		{
			get { return Create<VipListeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the WebServi entity</summary>
		public EntityQuery<WebServiEntity> WebServi
		{
			get { return Create<WebServiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Yetki entity</summary>
		public EntityQuery<YetkiEntity> Yetki
		{
			get { return Create<YetkiEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Zaman entity</summary>
		public EntityQuery<ZamanEntity> Zaman
		{
			get { return Create<ZamanEntity>(); }
		}

	}
}