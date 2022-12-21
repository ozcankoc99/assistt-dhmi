///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:35
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using dhmi;
using dhmi.DaoClasses;
using dhmi.EntityClasses;
using dhmi.FactoryClasses;
using dhmi.HelperClasses;
using dhmi.RelationClasses;

namespace dhmi.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData : ILinqMetaData
	{
		#region Class Member Declarations
		private ITransaction _transactionToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the transaction object to use empty. This is ok if you're not executing queries created with this
		/// meta data inside a transaction. If you're executing the queries created with this meta-data inside a transaction, either set the Transaction property
		/// on the IQueryable.Provider instance of the created LLBLGenProQuery object prior to execution or use the ctor which accepts a transaction object.</summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse) : this(transactionToUse, null)
		{
		}
		
		/// <summary>CTor. If you're executing the queries created with this meta-data inside a transaction, pass a live ITransaction object to this ctor.</summary>
		/// <param name="transactionToUse">the transaction to use in queries created with this meta-data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(ITransaction transactionToUse, FunctionMappingStore customFunctionMappings)
		{
			_transactionToUse = transactionToUse;
			_customFunctionMappings = customFunctionMappings;
		}
		
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((dhmi.EntityType)typeOfEntity)
			{
				case dhmi.EntityType.AcikBildirimEntity:
					toReturn = this.AcikBildirim;
					break;
				case dhmi.EntityType.AcikBildirimAyrintiEntity:
					toReturn = this.AcikBildirimAyrinti;
					break;
				case dhmi.EntityType.AltAltMenuEntity:
					toReturn = this.AltAltMenu;
					break;
				case dhmi.EntityType.AltKarakterEntity:
					toReturn = this.AltKarakter;
					break;
				case dhmi.EntityType.AltKonuEntity:
					toReturn = this.AltKonu;
					break;
				case dhmi.EntityType.AltMenuEntity:
					toReturn = this.AltMenu;
					break;
				case dhmi.EntityType.BaskanlikEntity:
					toReturn = this.Baskanlik;
					break;
				case dhmi.EntityType.BildirimEntity:
					toReturn = this.Bildirim;
					break;
				case dhmi.EntityType.BildirimAtamaGrupEntity:
					toReturn = this.BildirimAtamaGrup;
					break;
				case dhmi.EntityType.BildirimAtamaKullaniciEntity:
					toReturn = this.BildirimAtamaKullanici;
					break;
				case dhmi.EntityType.BildirimGeriDonuEntity:
					toReturn = this.BildirimGeriDonu;
					break;
				case dhmi.EntityType.BildirimHistoryEntity:
					toReturn = this.BildirimHistory;
					break;
				case dhmi.EntityType.BildirimIslemEntity:
					toReturn = this.BildirimIslem;
					break;
				case dhmi.EntityType.BildirimSonucEntity:
					toReturn = this.BildirimSonuc;
					break;
				case dhmi.EntityType.BildirimTuruEntity:
					toReturn = this.BildirimTuru;
					break;
				case dhmi.EntityType.BilgiBankasiEntity:
					toReturn = this.BilgiBankasi;
					break;
				case dhmi.EntityType.BilgiBankasiTurEntity:
					toReturn = this.BilgiBankasiTur;
					break;
				case dhmi.EntityType.BilgilendirmeEntity:
					toReturn = this.Bilgilendirme;
					break;
				case dhmi.EntityType.CagriMerkezEntity:
					toReturn = this.CagriMerkez;
					break;
				case dhmi.EntityType.CagriTipiEntity:
					toReturn = this.CagriTipi;
					break;
				case dhmi.EntityType.DigerBirimlerEntity:
					toReturn = this.DigerBirimler;
					break;
				case dhmi.EntityType.DigerBirimlerAyrintiEntity:
					toReturn = this.DigerBirimlerAyrinti;
					break;
				case dhmi.EntityType.DosyaEntity:
					toReturn = this.Dosya;
					break;
				case dhmi.EntityType.DuyuruEntity:
					toReturn = this.Duyuru;
					break;
				case dhmi.EntityType.EkSureEntity:
					toReturn = this.EkSure;
					break;
				case dhmi.EntityType.GecenSureEntity:
					toReturn = this.GecenSure;
					break;
				case dhmi.EntityType.GizliSoruTuruEntity:
					toReturn = this.GizliSoruTuru;
					break;
				case dhmi.EntityType.GorevEntity:
					toReturn = this.Gorev;
					break;
				case dhmi.EntityType.GrupEntity:
					toReturn = this.Grup;
					break;
				case dhmi.EntityType.GrupAtamaEntity:
					toReturn = this.GrupAtama;
					break;
				case dhmi.EntityType.HavalimaniEntity:
					toReturn = this.Havalimani;
					break;
				case dhmi.EntityType.HiyerarsiTurEntity:
					toReturn = this.HiyerarsiTur;
					break;
				case dhmi.EntityType.IlEntity:
					toReturn = this.Il;
					break;
				case dhmi.EntityType.IpBankEntity:
					toReturn = this.IpBank;
					break;
				case dhmi.EntityType.IslemEntity:
					toReturn = this.Islem;
					break;
				case dhmi.EntityType.IslemOlusturEntity:
					toReturn = this.IslemOlustur;
					break;
				case dhmi.EntityType.IslemTuruEntity:
					toReturn = this.IslemTuru;
					break;
				case dhmi.EntityType.IstatistikEntity:
					toReturn = this.Istatistik;
					break;
				case dhmi.EntityType.KapatmaTurEntity:
					toReturn = this.KapatmaTur;
					break;
				case dhmi.EntityType.KarakterEntity:
					toReturn = this.Karakter;
					break;
				case dhmi.EntityType.KaraListeEntity:
					toReturn = this.KaraListe;
					break;
				case dhmi.EntityType.KonuEntity:
					toReturn = this.Konu;
					break;
				case dhmi.EntityType.KonusalDagilimEntity:
					toReturn = this.KonusalDagilim;
					break;
				case dhmi.EntityType.KopukCagriEntity:
					toReturn = this.KopukCagri;
					break;
				case dhmi.EntityType.KopukCagriTuruEntity:
					toReturn = this.KopukCagriTuru;
					break;
				case dhmi.EntityType.KpsArsivEntity:
					toReturn = this.KpsArsiv;
					break;
				case dhmi.EntityType.KpsBilgiEntity:
					toReturn = this.KpsBilgi;
					break;
				case dhmi.EntityType.KullaniciEntity:
					toReturn = this.Kullanici;
					break;
				case dhmi.EntityType.KulTcNoEntity:
					toReturn = this.KulTcNo;
					break;
				case dhmi.EntityType.LogEntity:
					toReturn = this.Log;
					break;
				case dhmi.EntityType.LogEmailEntity:
					toReturn = this.LogEmail;
					break;
				case dhmi.EntityType.LogHataEntity:
					toReturn = this.LogHata;
					break;
				case dhmi.EntityType.LogIslemEntity:
					toReturn = this.LogIslem;
					break;
				case dhmi.EntityType.LogSmEntity:
					toReturn = this.LogSm;
					break;
				case dhmi.EntityType.MailBankEntity:
					toReturn = this.MailBank;
					break;
				case dhmi.EntityType.MenuEntity:
					toReturn = this.Menu;
					break;
				case dhmi.EntityType.MenuOlusturEntity:
					toReturn = this.MenuOlustur;
					break;
				case dhmi.EntityType.MesajEntity:
					toReturn = this.Mesaj;
					break;
				case dhmi.EntityType.ParametreEntity:
					toReturn = this.Parametre;
					break;
				case dhmi.EntityType.ParametreGenelArsivEntity:
					toReturn = this.ParametreGenelArsiv;
					break;
				case dhmi.EntityType.ParametreTurEntity:
					toReturn = this.ParametreTur;
					break;
				case dhmi.EntityType.RaporIcerikEntity:
					toReturn = this.RaporIcerik;
					break;
				case dhmi.EntityType.RaporTuruEntity:
					toReturn = this.RaporTuru;
					break;
				case dhmi.EntityType.RaporYetkiEntity:
					toReturn = this.RaporYetki;
					break;
				case dhmi.EntityType.SorunEntity:
					toReturn = this.Sorun;
					break;
				case dhmi.EntityType.SorunTuruEntity:
					toReturn = this.SorunTuru;
					break;
				case dhmi.EntityType.SureTakipEntity:
					toReturn = this.SureTakip;
					break;
				case dhmi.EntityType.TurBankEntity:
					toReturn = this.TurBank;
					break;
				case dhmi.EntityType.VatandaEntity:
					toReturn = this.Vatanda;
					break;
				case dhmi.EntityType.VatandasArsivEntity:
					toReturn = this.VatandasArsiv;
					break;
				case dhmi.EntityType.VipListeEntity:
					toReturn = this.VipListe;
					break;
				case dhmi.EntityType.WebServiEntity:
					toReturn = this.WebServi;
					break;
				case dhmi.EntityType.YetkiEntity:
					toReturn = this.Yetki;
					break;
				case dhmi.EntityType.ZamanEntity:
					toReturn = this.Zaman;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AcikBildirimEntity instances in the database.</summary>
		public DataSource<AcikBildirimEntity> AcikBildirim
		{
			get { return new DataSource<AcikBildirimEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AcikBildirimAyrintiEntity instances in the database.</summary>
		public DataSource<AcikBildirimAyrintiEntity> AcikBildirimAyrinti
		{
			get { return new DataSource<AcikBildirimAyrintiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AltAltMenuEntity instances in the database.</summary>
		public DataSource<AltAltMenuEntity> AltAltMenu
		{
			get { return new DataSource<AltAltMenuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AltKarakterEntity instances in the database.</summary>
		public DataSource<AltKarakterEntity> AltKarakter
		{
			get { return new DataSource<AltKarakterEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AltKonuEntity instances in the database.</summary>
		public DataSource<AltKonuEntity> AltKonu
		{
			get { return new DataSource<AltKonuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting AltMenuEntity instances in the database.</summary>
		public DataSource<AltMenuEntity> AltMenu
		{
			get { return new DataSource<AltMenuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BaskanlikEntity instances in the database.</summary>
		public DataSource<BaskanlikEntity> Baskanlik
		{
			get { return new DataSource<BaskanlikEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimEntity instances in the database.</summary>
		public DataSource<BildirimEntity> Bildirim
		{
			get { return new DataSource<BildirimEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimAtamaGrupEntity instances in the database.</summary>
		public DataSource<BildirimAtamaGrupEntity> BildirimAtamaGrup
		{
			get { return new DataSource<BildirimAtamaGrupEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimAtamaKullaniciEntity instances in the database.</summary>
		public DataSource<BildirimAtamaKullaniciEntity> BildirimAtamaKullanici
		{
			get { return new DataSource<BildirimAtamaKullaniciEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimGeriDonuEntity instances in the database.</summary>
		public DataSource<BildirimGeriDonuEntity> BildirimGeriDonu
		{
			get { return new DataSource<BildirimGeriDonuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimHistoryEntity instances in the database.</summary>
		public DataSource<BildirimHistoryEntity> BildirimHistory
		{
			get { return new DataSource<BildirimHistoryEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimIslemEntity instances in the database.</summary>
		public DataSource<BildirimIslemEntity> BildirimIslem
		{
			get { return new DataSource<BildirimIslemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimSonucEntity instances in the database.</summary>
		public DataSource<BildirimSonucEntity> BildirimSonuc
		{
			get { return new DataSource<BildirimSonucEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BildirimTuruEntity instances in the database.</summary>
		public DataSource<BildirimTuruEntity> BildirimTuru
		{
			get { return new DataSource<BildirimTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BilgiBankasiEntity instances in the database.</summary>
		public DataSource<BilgiBankasiEntity> BilgiBankasi
		{
			get { return new DataSource<BilgiBankasiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BilgiBankasiTurEntity instances in the database.</summary>
		public DataSource<BilgiBankasiTurEntity> BilgiBankasiTur
		{
			get { return new DataSource<BilgiBankasiTurEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting BilgilendirmeEntity instances in the database.</summary>
		public DataSource<BilgilendirmeEntity> Bilgilendirme
		{
			get { return new DataSource<BilgilendirmeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CagriMerkezEntity instances in the database.</summary>
		public DataSource<CagriMerkezEntity> CagriMerkez
		{
			get { return new DataSource<CagriMerkezEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting CagriTipiEntity instances in the database.</summary>
		public DataSource<CagriTipiEntity> CagriTipi
		{
			get { return new DataSource<CagriTipiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DigerBirimlerEntity instances in the database.</summary>
		public DataSource<DigerBirimlerEntity> DigerBirimler
		{
			get { return new DataSource<DigerBirimlerEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DigerBirimlerAyrintiEntity instances in the database.</summary>
		public DataSource<DigerBirimlerAyrintiEntity> DigerBirimlerAyrinti
		{
			get { return new DataSource<DigerBirimlerAyrintiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DosyaEntity instances in the database.</summary>
		public DataSource<DosyaEntity> Dosya
		{
			get { return new DataSource<DosyaEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting DuyuruEntity instances in the database.</summary>
		public DataSource<DuyuruEntity> Duyuru
		{
			get { return new DataSource<DuyuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting EkSureEntity instances in the database.</summary>
		public DataSource<EkSureEntity> EkSure
		{
			get { return new DataSource<EkSureEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GecenSureEntity instances in the database.</summary>
		public DataSource<GecenSureEntity> GecenSure
		{
			get { return new DataSource<GecenSureEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GizliSoruTuruEntity instances in the database.</summary>
		public DataSource<GizliSoruTuruEntity> GizliSoruTuru
		{
			get { return new DataSource<GizliSoruTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GorevEntity instances in the database.</summary>
		public DataSource<GorevEntity> Gorev
		{
			get { return new DataSource<GorevEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GrupEntity instances in the database.</summary>
		public DataSource<GrupEntity> Grup
		{
			get { return new DataSource<GrupEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting GrupAtamaEntity instances in the database.</summary>
		public DataSource<GrupAtamaEntity> GrupAtama
		{
			get { return new DataSource<GrupAtamaEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting HavalimaniEntity instances in the database.</summary>
		public DataSource<HavalimaniEntity> Havalimani
		{
			get { return new DataSource<HavalimaniEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting HiyerarsiTurEntity instances in the database.</summary>
		public DataSource<HiyerarsiTurEntity> HiyerarsiTur
		{
			get { return new DataSource<HiyerarsiTurEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IlEntity instances in the database.</summary>
		public DataSource<IlEntity> Il
		{
			get { return new DataSource<IlEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IpBankEntity instances in the database.</summary>
		public DataSource<IpBankEntity> IpBank
		{
			get { return new DataSource<IpBankEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IslemEntity instances in the database.</summary>
		public DataSource<IslemEntity> Islem
		{
			get { return new DataSource<IslemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IslemOlusturEntity instances in the database.</summary>
		public DataSource<IslemOlusturEntity> IslemOlustur
		{
			get { return new DataSource<IslemOlusturEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IslemTuruEntity instances in the database.</summary>
		public DataSource<IslemTuruEntity> IslemTuru
		{
			get { return new DataSource<IslemTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting IstatistikEntity instances in the database.</summary>
		public DataSource<IstatistikEntity> Istatistik
		{
			get { return new DataSource<IstatistikEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KapatmaTurEntity instances in the database.</summary>
		public DataSource<KapatmaTurEntity> KapatmaTur
		{
			get { return new DataSource<KapatmaTurEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KarakterEntity instances in the database.</summary>
		public DataSource<KarakterEntity> Karakter
		{
			get { return new DataSource<KarakterEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KaraListeEntity instances in the database.</summary>
		public DataSource<KaraListeEntity> KaraListe
		{
			get { return new DataSource<KaraListeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KonuEntity instances in the database.</summary>
		public DataSource<KonuEntity> Konu
		{
			get { return new DataSource<KonuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KonusalDagilimEntity instances in the database.</summary>
		public DataSource<KonusalDagilimEntity> KonusalDagilim
		{
			get { return new DataSource<KonusalDagilimEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KopukCagriEntity instances in the database.</summary>
		public DataSource<KopukCagriEntity> KopukCagri
		{
			get { return new DataSource<KopukCagriEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KopukCagriTuruEntity instances in the database.</summary>
		public DataSource<KopukCagriTuruEntity> KopukCagriTuru
		{
			get { return new DataSource<KopukCagriTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KpsArsivEntity instances in the database.</summary>
		public DataSource<KpsArsivEntity> KpsArsiv
		{
			get { return new DataSource<KpsArsivEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KpsBilgiEntity instances in the database.</summary>
		public DataSource<KpsBilgiEntity> KpsBilgi
		{
			get { return new DataSource<KpsBilgiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KullaniciEntity instances in the database.</summary>
		public DataSource<KullaniciEntity> Kullanici
		{
			get { return new DataSource<KullaniciEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting KulTcNoEntity instances in the database.</summary>
		public DataSource<KulTcNoEntity> KulTcNo
		{
			get { return new DataSource<KulTcNoEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LogEntity instances in the database.</summary>
		public DataSource<LogEntity> Log
		{
			get { return new DataSource<LogEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LogEmailEntity instances in the database.</summary>
		public DataSource<LogEmailEntity> LogEmail
		{
			get { return new DataSource<LogEmailEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LogHataEntity instances in the database.</summary>
		public DataSource<LogHataEntity> LogHata
		{
			get { return new DataSource<LogHataEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LogIslemEntity instances in the database.</summary>
		public DataSource<LogIslemEntity> LogIslem
		{
			get { return new DataSource<LogIslemEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting LogSmEntity instances in the database.</summary>
		public DataSource<LogSmEntity> LogSm
		{
			get { return new DataSource<LogSmEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MailBankEntity instances in the database.</summary>
		public DataSource<MailBankEntity> MailBank
		{
			get { return new DataSource<MailBankEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MenuEntity instances in the database.</summary>
		public DataSource<MenuEntity> Menu
		{
			get { return new DataSource<MenuEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MenuOlusturEntity instances in the database.</summary>
		public DataSource<MenuOlusturEntity> MenuOlustur
		{
			get { return new DataSource<MenuOlusturEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting MesajEntity instances in the database.</summary>
		public DataSource<MesajEntity> Mesaj
		{
			get { return new DataSource<MesajEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ParametreEntity instances in the database.</summary>
		public DataSource<ParametreEntity> Parametre
		{
			get { return new DataSource<ParametreEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ParametreGenelArsivEntity instances in the database.</summary>
		public DataSource<ParametreGenelArsivEntity> ParametreGenelArsiv
		{
			get { return new DataSource<ParametreGenelArsivEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ParametreTurEntity instances in the database.</summary>
		public DataSource<ParametreTurEntity> ParametreTur
		{
			get { return new DataSource<ParametreTurEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RaporIcerikEntity instances in the database.</summary>
		public DataSource<RaporIcerikEntity> RaporIcerik
		{
			get { return new DataSource<RaporIcerikEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RaporTuruEntity instances in the database.</summary>
		public DataSource<RaporTuruEntity> RaporTuru
		{
			get { return new DataSource<RaporTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting RaporYetkiEntity instances in the database.</summary>
		public DataSource<RaporYetkiEntity> RaporYetki
		{
			get { return new DataSource<RaporYetkiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SorunEntity instances in the database.</summary>
		public DataSource<SorunEntity> Sorun
		{
			get { return new DataSource<SorunEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SorunTuruEntity instances in the database.</summary>
		public DataSource<SorunTuruEntity> SorunTuru
		{
			get { return new DataSource<SorunTuruEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting SureTakipEntity instances in the database.</summary>
		public DataSource<SureTakipEntity> SureTakip
		{
			get { return new DataSource<SureTakipEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting TurBankEntity instances in the database.</summary>
		public DataSource<TurBankEntity> TurBank
		{
			get { return new DataSource<TurBankEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VatandaEntity instances in the database.</summary>
		public DataSource<VatandaEntity> Vatanda
		{
			get { return new DataSource<VatandaEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VatandasArsivEntity instances in the database.</summary>
		public DataSource<VatandasArsivEntity> VatandasArsiv
		{
			get { return new DataSource<VatandasArsivEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting VipListeEntity instances in the database.</summary>
		public DataSource<VipListeEntity> VipListe
		{
			get { return new DataSource<VipListeEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting WebServiEntity instances in the database.</summary>
		public DataSource<WebServiEntity> WebServi
		{
			get { return new DataSource<WebServiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting YetkiEntity instances in the database.</summary>
		public DataSource<YetkiEntity> Yetki
		{
			get { return new DataSource<YetkiEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		/// <summary>returns the datasource to use in a Linq query when targeting ZamanEntity instances in the database.</summary>
		public DataSource<ZamanEntity> Zaman
		{
			get { return new DataSource<ZamanEntity>(_transactionToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		#region Class Property Declarations
		/// <summary> Gets / sets the ITransaction to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the ITransaction object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public ITransaction TransactionToUse
		{
			get { return _transactionToUse;}
			set { _transactionToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}