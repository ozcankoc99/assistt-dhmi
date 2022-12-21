///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:37
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using dhmi;
using dhmi.FactoryClasses;
using dhmi.DaoClasses;
using dhmi.RelationClasses;
using dhmi.HelperClasses;
using dhmi.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Kullanici'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KullaniciEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimCollection	_bildirims;
		private bool	_alwaysFetchBildirims, _alreadyFetchedBildirims;
		private dhmi.CollectionClasses.BildirimAtamaKullaniciCollection	_bildirimAtamaKullanicis;
		private bool	_alwaysFetchBildirimAtamaKullanicis, _alreadyFetchedBildirimAtamaKullanicis;
		private dhmi.CollectionClasses.BildirimHistoryCollection	_bildirimHistories;
		private bool	_alwaysFetchBildirimHistories, _alreadyFetchedBildirimHistories;
		private dhmi.CollectionClasses.DuyuruCollection	_duyurus;
		private bool	_alwaysFetchDuyurus, _alreadyFetchedDuyurus;
		private dhmi.CollectionClasses.EkSureCollection	_ekSures;
		private bool	_alwaysFetchEkSures, _alreadyFetchedEkSures;
		private dhmi.CollectionClasses.GecenSureCollection	_gecenSures;
		private bool	_alwaysFetchGecenSures, _alreadyFetchedGecenSures;
		private dhmi.CollectionClasses.GrupAtamaCollection	_grupAtamas;
		private bool	_alwaysFetchGrupAtamas, _alreadyFetchedGrupAtamas;
		private dhmi.CollectionClasses.IpBankCollection	_ipBanks;
		private bool	_alwaysFetchIpBanks, _alreadyFetchedIpBanks;
		private dhmi.CollectionClasses.IstatistikCollection	_istatistiks;
		private bool	_alwaysFetchIstatistiks, _alreadyFetchedIstatistiks;
		private dhmi.CollectionClasses.KopukCagriCollection	_kopukCagris;
		private bool	_alwaysFetchKopukCagris, _alreadyFetchedKopukCagris;
		private dhmi.CollectionClasses.KpsArsivCollection	_kpsArsivs;
		private bool	_alwaysFetchKpsArsivs, _alreadyFetchedKpsArsivs;
		private dhmi.CollectionClasses.LogCollection	_logs;
		private bool	_alwaysFetchLogs, _alreadyFetchedLogs;
		private dhmi.CollectionClasses.MesajCollection	_mesajs;
		private bool	_alwaysFetchMesajs, _alreadyFetchedMesajs;
		private dhmi.CollectionClasses.ParametreCollection	_parametres;
		private bool	_alwaysFetchParametres, _alreadyFetchedParametres;
		private dhmi.CollectionClasses.ParametreGenelArsivCollection	_parametreGenelArsivs;
		private bool	_alwaysFetchParametreGenelArsivs, _alreadyFetchedParametreGenelArsivs;
		private dhmi.CollectionClasses.RaporYetkiCollection	_raporYetkis;
		private bool	_alwaysFetchRaporYetkis, _alreadyFetchedRaporYetkis;
		private dhmi.CollectionClasses.SorunCollection	_soruns;
		private bool	_alwaysFetchSoruns, _alreadyFetchedSoruns;
		private dhmi.CollectionClasses.VatandaCollection	_vatandas;
		private bool	_alwaysFetchVatandas, _alreadyFetchedVatandas;
		private GorevEntity _gorev;
		private bool	_alwaysFetchGorev, _alreadyFetchedGorev, _gorevReturnsNewIfNotFound;
		private HiyerarsiTurEntity _hiyerarsiTur;
		private bool	_alwaysFetchHiyerarsiTur, _alreadyFetchedHiyerarsiTur, _hiyerarsiTurReturnsNewIfNotFound;
		private YetkiEntity _yetki;
		private bool	_alwaysFetchYetki, _alreadyFetchedYetki, _yetkiReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Gorev</summary>
			public static readonly string Gorev = "Gorev";
			/// <summary>Member name HiyerarsiTur</summary>
			public static readonly string HiyerarsiTur = "HiyerarsiTur";
			/// <summary>Member name Yetki</summary>
			public static readonly string Yetki = "Yetki";
			/// <summary>Member name Bildirims</summary>
			public static readonly string Bildirims = "Bildirims";
			/// <summary>Member name BildirimAtamaKullanicis</summary>
			public static readonly string BildirimAtamaKullanicis = "BildirimAtamaKullanicis";
			/// <summary>Member name BildirimHistories</summary>
			public static readonly string BildirimHistories = "BildirimHistories";
			/// <summary>Member name Duyurus</summary>
			public static readonly string Duyurus = "Duyurus";
			/// <summary>Member name EkSures</summary>
			public static readonly string EkSures = "EkSures";
			/// <summary>Member name GecenSures</summary>
			public static readonly string GecenSures = "GecenSures";
			/// <summary>Member name GrupAtamas</summary>
			public static readonly string GrupAtamas = "GrupAtamas";
			/// <summary>Member name IpBanks</summary>
			public static readonly string IpBanks = "IpBanks";
			/// <summary>Member name Istatistiks</summary>
			public static readonly string Istatistiks = "Istatistiks";
			/// <summary>Member name KopukCagris</summary>
			public static readonly string KopukCagris = "KopukCagris";
			/// <summary>Member name KpsArsivs</summary>
			public static readonly string KpsArsivs = "KpsArsivs";
			/// <summary>Member name Logs</summary>
			public static readonly string Logs = "Logs";
			/// <summary>Member name Mesajs</summary>
			public static readonly string Mesajs = "Mesajs";
			/// <summary>Member name Parametres</summary>
			public static readonly string Parametres = "Parametres";
			/// <summary>Member name ParametreGenelArsivs</summary>
			public static readonly string ParametreGenelArsivs = "ParametreGenelArsivs";
			/// <summary>Member name RaporYetkis</summary>
			public static readonly string RaporYetkis = "RaporYetkis";
			/// <summary>Member name Soruns</summary>
			public static readonly string Soruns = "Soruns";
			/// <summary>Member name Vatandas</summary>
			public static readonly string Vatandas = "Vatandas";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static KullaniciEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public KullaniciEntity() :base("KullaniciEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		public KullaniciEntity(System.Int16 kullaniciId):base("KullaniciEntity")
		{
			InitClassFetch(kullaniciId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public KullaniciEntity(System.Int16 kullaniciId, IPrefetchPath prefetchPathToUse):base("KullaniciEntity")
		{
			InitClassFetch(kullaniciId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="validator">The custom validator object for this KullaniciEntity</param>
		public KullaniciEntity(System.Int16 kullaniciId, IValidator validator):base("KullaniciEntity")
		{
			InitClassFetch(kullaniciId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected KullaniciEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirims = (dhmi.CollectionClasses.BildirimCollection)info.GetValue("_bildirims", typeof(dhmi.CollectionClasses.BildirimCollection));
			_alwaysFetchBildirims = info.GetBoolean("_alwaysFetchBildirims");
			_alreadyFetchedBildirims = info.GetBoolean("_alreadyFetchedBildirims");

			_bildirimAtamaKullanicis = (dhmi.CollectionClasses.BildirimAtamaKullaniciCollection)info.GetValue("_bildirimAtamaKullanicis", typeof(dhmi.CollectionClasses.BildirimAtamaKullaniciCollection));
			_alwaysFetchBildirimAtamaKullanicis = info.GetBoolean("_alwaysFetchBildirimAtamaKullanicis");
			_alreadyFetchedBildirimAtamaKullanicis = info.GetBoolean("_alreadyFetchedBildirimAtamaKullanicis");

			_bildirimHistories = (dhmi.CollectionClasses.BildirimHistoryCollection)info.GetValue("_bildirimHistories", typeof(dhmi.CollectionClasses.BildirimHistoryCollection));
			_alwaysFetchBildirimHistories = info.GetBoolean("_alwaysFetchBildirimHistories");
			_alreadyFetchedBildirimHistories = info.GetBoolean("_alreadyFetchedBildirimHistories");

			_duyurus = (dhmi.CollectionClasses.DuyuruCollection)info.GetValue("_duyurus", typeof(dhmi.CollectionClasses.DuyuruCollection));
			_alwaysFetchDuyurus = info.GetBoolean("_alwaysFetchDuyurus");
			_alreadyFetchedDuyurus = info.GetBoolean("_alreadyFetchedDuyurus");

			_ekSures = (dhmi.CollectionClasses.EkSureCollection)info.GetValue("_ekSures", typeof(dhmi.CollectionClasses.EkSureCollection));
			_alwaysFetchEkSures = info.GetBoolean("_alwaysFetchEkSures");
			_alreadyFetchedEkSures = info.GetBoolean("_alreadyFetchedEkSures");

			_gecenSures = (dhmi.CollectionClasses.GecenSureCollection)info.GetValue("_gecenSures", typeof(dhmi.CollectionClasses.GecenSureCollection));
			_alwaysFetchGecenSures = info.GetBoolean("_alwaysFetchGecenSures");
			_alreadyFetchedGecenSures = info.GetBoolean("_alreadyFetchedGecenSures");

			_grupAtamas = (dhmi.CollectionClasses.GrupAtamaCollection)info.GetValue("_grupAtamas", typeof(dhmi.CollectionClasses.GrupAtamaCollection));
			_alwaysFetchGrupAtamas = info.GetBoolean("_alwaysFetchGrupAtamas");
			_alreadyFetchedGrupAtamas = info.GetBoolean("_alreadyFetchedGrupAtamas");

			_ipBanks = (dhmi.CollectionClasses.IpBankCollection)info.GetValue("_ipBanks", typeof(dhmi.CollectionClasses.IpBankCollection));
			_alwaysFetchIpBanks = info.GetBoolean("_alwaysFetchIpBanks");
			_alreadyFetchedIpBanks = info.GetBoolean("_alreadyFetchedIpBanks");

			_istatistiks = (dhmi.CollectionClasses.IstatistikCollection)info.GetValue("_istatistiks", typeof(dhmi.CollectionClasses.IstatistikCollection));
			_alwaysFetchIstatistiks = info.GetBoolean("_alwaysFetchIstatistiks");
			_alreadyFetchedIstatistiks = info.GetBoolean("_alreadyFetchedIstatistiks");

			_kopukCagris = (dhmi.CollectionClasses.KopukCagriCollection)info.GetValue("_kopukCagris", typeof(dhmi.CollectionClasses.KopukCagriCollection));
			_alwaysFetchKopukCagris = info.GetBoolean("_alwaysFetchKopukCagris");
			_alreadyFetchedKopukCagris = info.GetBoolean("_alreadyFetchedKopukCagris");

			_kpsArsivs = (dhmi.CollectionClasses.KpsArsivCollection)info.GetValue("_kpsArsivs", typeof(dhmi.CollectionClasses.KpsArsivCollection));
			_alwaysFetchKpsArsivs = info.GetBoolean("_alwaysFetchKpsArsivs");
			_alreadyFetchedKpsArsivs = info.GetBoolean("_alreadyFetchedKpsArsivs");

			_logs = (dhmi.CollectionClasses.LogCollection)info.GetValue("_logs", typeof(dhmi.CollectionClasses.LogCollection));
			_alwaysFetchLogs = info.GetBoolean("_alwaysFetchLogs");
			_alreadyFetchedLogs = info.GetBoolean("_alreadyFetchedLogs");

			_mesajs = (dhmi.CollectionClasses.MesajCollection)info.GetValue("_mesajs", typeof(dhmi.CollectionClasses.MesajCollection));
			_alwaysFetchMesajs = info.GetBoolean("_alwaysFetchMesajs");
			_alreadyFetchedMesajs = info.GetBoolean("_alreadyFetchedMesajs");

			_parametres = (dhmi.CollectionClasses.ParametreCollection)info.GetValue("_parametres", typeof(dhmi.CollectionClasses.ParametreCollection));
			_alwaysFetchParametres = info.GetBoolean("_alwaysFetchParametres");
			_alreadyFetchedParametres = info.GetBoolean("_alreadyFetchedParametres");

			_parametreGenelArsivs = (dhmi.CollectionClasses.ParametreGenelArsivCollection)info.GetValue("_parametreGenelArsivs", typeof(dhmi.CollectionClasses.ParametreGenelArsivCollection));
			_alwaysFetchParametreGenelArsivs = info.GetBoolean("_alwaysFetchParametreGenelArsivs");
			_alreadyFetchedParametreGenelArsivs = info.GetBoolean("_alreadyFetchedParametreGenelArsivs");

			_raporYetkis = (dhmi.CollectionClasses.RaporYetkiCollection)info.GetValue("_raporYetkis", typeof(dhmi.CollectionClasses.RaporYetkiCollection));
			_alwaysFetchRaporYetkis = info.GetBoolean("_alwaysFetchRaporYetkis");
			_alreadyFetchedRaporYetkis = info.GetBoolean("_alreadyFetchedRaporYetkis");

			_soruns = (dhmi.CollectionClasses.SorunCollection)info.GetValue("_soruns", typeof(dhmi.CollectionClasses.SorunCollection));
			_alwaysFetchSoruns = info.GetBoolean("_alwaysFetchSoruns");
			_alreadyFetchedSoruns = info.GetBoolean("_alreadyFetchedSoruns");

			_vatandas = (dhmi.CollectionClasses.VatandaCollection)info.GetValue("_vatandas", typeof(dhmi.CollectionClasses.VatandaCollection));
			_alwaysFetchVatandas = info.GetBoolean("_alwaysFetchVatandas");
			_alreadyFetchedVatandas = info.GetBoolean("_alreadyFetchedVatandas");
			_gorev = (GorevEntity)info.GetValue("_gorev", typeof(GorevEntity));
			if(_gorev!=null)
			{
				_gorev.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_gorevReturnsNewIfNotFound = info.GetBoolean("_gorevReturnsNewIfNotFound");
			_alwaysFetchGorev = info.GetBoolean("_alwaysFetchGorev");
			_alreadyFetchedGorev = info.GetBoolean("_alreadyFetchedGorev");

			_hiyerarsiTur = (HiyerarsiTurEntity)info.GetValue("_hiyerarsiTur", typeof(HiyerarsiTurEntity));
			if(_hiyerarsiTur!=null)
			{
				_hiyerarsiTur.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_hiyerarsiTurReturnsNewIfNotFound = info.GetBoolean("_hiyerarsiTurReturnsNewIfNotFound");
			_alwaysFetchHiyerarsiTur = info.GetBoolean("_alwaysFetchHiyerarsiTur");
			_alreadyFetchedHiyerarsiTur = info.GetBoolean("_alreadyFetchedHiyerarsiTur");

			_yetki = (YetkiEntity)info.GetValue("_yetki", typeof(YetkiEntity));
			if(_yetki!=null)
			{
				_yetki.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_yetkiReturnsNewIfNotFound = info.GetBoolean("_yetkiReturnsNewIfNotFound");
			_alwaysFetchYetki = info.GetBoolean("_alwaysFetchYetki");
			_alreadyFetchedYetki = info.GetBoolean("_alreadyFetchedYetki");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((KullaniciFieldIndex)fieldIndex)
			{
				case KullaniciFieldIndex.FkGorevId:
					DesetupSyncGorev(true, false);
					_alreadyFetchedGorev = false;
					break;
				case KullaniciFieldIndex.FkHiyerarsiTurId:
					DesetupSyncHiyerarsiTur(true, false);
					_alreadyFetchedHiyerarsiTur = false;
					break;
				case KullaniciFieldIndex.FkYetkiId:
					DesetupSyncYetki(true, false);
					_alreadyFetchedYetki = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedBildirims = (_bildirims.Count > 0);
			_alreadyFetchedBildirimAtamaKullanicis = (_bildirimAtamaKullanicis.Count > 0);
			_alreadyFetchedBildirimHistories = (_bildirimHistories.Count > 0);
			_alreadyFetchedDuyurus = (_duyurus.Count > 0);
			_alreadyFetchedEkSures = (_ekSures.Count > 0);
			_alreadyFetchedGecenSures = (_gecenSures.Count > 0);
			_alreadyFetchedGrupAtamas = (_grupAtamas.Count > 0);
			_alreadyFetchedIpBanks = (_ipBanks.Count > 0);
			_alreadyFetchedIstatistiks = (_istatistiks.Count > 0);
			_alreadyFetchedKopukCagris = (_kopukCagris.Count > 0);
			_alreadyFetchedKpsArsivs = (_kpsArsivs.Count > 0);
			_alreadyFetchedLogs = (_logs.Count > 0);
			_alreadyFetchedMesajs = (_mesajs.Count > 0);
			_alreadyFetchedParametres = (_parametres.Count > 0);
			_alreadyFetchedParametreGenelArsivs = (_parametreGenelArsivs.Count > 0);
			_alreadyFetchedRaporYetkis = (_raporYetkis.Count > 0);
			_alreadyFetchedSoruns = (_soruns.Count > 0);
			_alreadyFetchedVatandas = (_vatandas.Count > 0);
			_alreadyFetchedGorev = (_gorev != null);
			_alreadyFetchedHiyerarsiTur = (_hiyerarsiTur != null);
			_alreadyFetchedYetki = (_yetki != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Gorev":
					toReturn.Add(Relations.GorevEntityUsingFkGorevId);
					break;
				case "HiyerarsiTur":
					toReturn.Add(Relations.HiyerarsiTurEntityUsingFkHiyerarsiTurId);
					break;
				case "Yetki":
					toReturn.Add(Relations.YetkiEntityUsingFkYetkiId);
					break;
				case "Bildirims":
					toReturn.Add(Relations.BildirimEntityUsingFkKullaniciId);
					break;
				case "BildirimAtamaKullanicis":
					toReturn.Add(Relations.BildirimAtamaKullaniciEntityUsingFkKullaniciId);
					break;
				case "BildirimHistories":
					toReturn.Add(Relations.BildirimHistoryEntityUsingFkKullaniciId);
					break;
				case "Duyurus":
					toReturn.Add(Relations.DuyuruEntityUsingFkKullaniciId);
					break;
				case "EkSures":
					toReturn.Add(Relations.EkSureEntityUsingFkKullaniciId);
					break;
				case "GecenSures":
					toReturn.Add(Relations.GecenSureEntityUsingFkKullaniciId);
					break;
				case "GrupAtamas":
					toReturn.Add(Relations.GrupAtamaEntityUsingFkKullaniciId);
					break;
				case "IpBanks":
					toReturn.Add(Relations.IpBankEntityUsingFkKullaniciId);
					break;
				case "Istatistiks":
					toReturn.Add(Relations.IstatistikEntityUsingFkKullaniciId);
					break;
				case "KopukCagris":
					toReturn.Add(Relations.KopukCagriEntityUsingFkKullaniciId);
					break;
				case "KpsArsivs":
					toReturn.Add(Relations.KpsArsivEntityUsingFkKullaniciId);
					break;
				case "Logs":
					toReturn.Add(Relations.LogEntityUsingFkKullaniciId);
					break;
				case "Mesajs":
					toReturn.Add(Relations.MesajEntityUsingFkKullaniciId);
					break;
				case "Parametres":
					toReturn.Add(Relations.ParametreEntityUsingFkKullaniciId);
					break;
				case "ParametreGenelArsivs":
					toReturn.Add(Relations.ParametreGenelArsivEntityUsingFkKullaniciId);
					break;
				case "RaporYetkis":
					toReturn.Add(Relations.RaporYetkiEntityUsingFkKullaniciId);
					break;
				case "Soruns":
					toReturn.Add(Relations.SorunEntityUsingFkKullaniciId);
					break;
				case "Vatandas":
					toReturn.Add(Relations.VatandaEntityUsingFkKullaniciId);
					break;
				default:
					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_bildirims", (!this.MarkedForDeletion?_bildirims:null));
			info.AddValue("_alwaysFetchBildirims", _alwaysFetchBildirims);
			info.AddValue("_alreadyFetchedBildirims", _alreadyFetchedBildirims);
			info.AddValue("_bildirimAtamaKullanicis", (!this.MarkedForDeletion?_bildirimAtamaKullanicis:null));
			info.AddValue("_alwaysFetchBildirimAtamaKullanicis", _alwaysFetchBildirimAtamaKullanicis);
			info.AddValue("_alreadyFetchedBildirimAtamaKullanicis", _alreadyFetchedBildirimAtamaKullanicis);
			info.AddValue("_bildirimHistories", (!this.MarkedForDeletion?_bildirimHistories:null));
			info.AddValue("_alwaysFetchBildirimHistories", _alwaysFetchBildirimHistories);
			info.AddValue("_alreadyFetchedBildirimHistories", _alreadyFetchedBildirimHistories);
			info.AddValue("_duyurus", (!this.MarkedForDeletion?_duyurus:null));
			info.AddValue("_alwaysFetchDuyurus", _alwaysFetchDuyurus);
			info.AddValue("_alreadyFetchedDuyurus", _alreadyFetchedDuyurus);
			info.AddValue("_ekSures", (!this.MarkedForDeletion?_ekSures:null));
			info.AddValue("_alwaysFetchEkSures", _alwaysFetchEkSures);
			info.AddValue("_alreadyFetchedEkSures", _alreadyFetchedEkSures);
			info.AddValue("_gecenSures", (!this.MarkedForDeletion?_gecenSures:null));
			info.AddValue("_alwaysFetchGecenSures", _alwaysFetchGecenSures);
			info.AddValue("_alreadyFetchedGecenSures", _alreadyFetchedGecenSures);
			info.AddValue("_grupAtamas", (!this.MarkedForDeletion?_grupAtamas:null));
			info.AddValue("_alwaysFetchGrupAtamas", _alwaysFetchGrupAtamas);
			info.AddValue("_alreadyFetchedGrupAtamas", _alreadyFetchedGrupAtamas);
			info.AddValue("_ipBanks", (!this.MarkedForDeletion?_ipBanks:null));
			info.AddValue("_alwaysFetchIpBanks", _alwaysFetchIpBanks);
			info.AddValue("_alreadyFetchedIpBanks", _alreadyFetchedIpBanks);
			info.AddValue("_istatistiks", (!this.MarkedForDeletion?_istatistiks:null));
			info.AddValue("_alwaysFetchIstatistiks", _alwaysFetchIstatistiks);
			info.AddValue("_alreadyFetchedIstatistiks", _alreadyFetchedIstatistiks);
			info.AddValue("_kopukCagris", (!this.MarkedForDeletion?_kopukCagris:null));
			info.AddValue("_alwaysFetchKopukCagris", _alwaysFetchKopukCagris);
			info.AddValue("_alreadyFetchedKopukCagris", _alreadyFetchedKopukCagris);
			info.AddValue("_kpsArsivs", (!this.MarkedForDeletion?_kpsArsivs:null));
			info.AddValue("_alwaysFetchKpsArsivs", _alwaysFetchKpsArsivs);
			info.AddValue("_alreadyFetchedKpsArsivs", _alreadyFetchedKpsArsivs);
			info.AddValue("_logs", (!this.MarkedForDeletion?_logs:null));
			info.AddValue("_alwaysFetchLogs", _alwaysFetchLogs);
			info.AddValue("_alreadyFetchedLogs", _alreadyFetchedLogs);
			info.AddValue("_mesajs", (!this.MarkedForDeletion?_mesajs:null));
			info.AddValue("_alwaysFetchMesajs", _alwaysFetchMesajs);
			info.AddValue("_alreadyFetchedMesajs", _alreadyFetchedMesajs);
			info.AddValue("_parametres", (!this.MarkedForDeletion?_parametres:null));
			info.AddValue("_alwaysFetchParametres", _alwaysFetchParametres);
			info.AddValue("_alreadyFetchedParametres", _alreadyFetchedParametres);
			info.AddValue("_parametreGenelArsivs", (!this.MarkedForDeletion?_parametreGenelArsivs:null));
			info.AddValue("_alwaysFetchParametreGenelArsivs", _alwaysFetchParametreGenelArsivs);
			info.AddValue("_alreadyFetchedParametreGenelArsivs", _alreadyFetchedParametreGenelArsivs);
			info.AddValue("_raporYetkis", (!this.MarkedForDeletion?_raporYetkis:null));
			info.AddValue("_alwaysFetchRaporYetkis", _alwaysFetchRaporYetkis);
			info.AddValue("_alreadyFetchedRaporYetkis", _alreadyFetchedRaporYetkis);
			info.AddValue("_soruns", (!this.MarkedForDeletion?_soruns:null));
			info.AddValue("_alwaysFetchSoruns", _alwaysFetchSoruns);
			info.AddValue("_alreadyFetchedSoruns", _alreadyFetchedSoruns);
			info.AddValue("_vatandas", (!this.MarkedForDeletion?_vatandas:null));
			info.AddValue("_alwaysFetchVatandas", _alwaysFetchVatandas);
			info.AddValue("_alreadyFetchedVatandas", _alreadyFetchedVatandas);
			info.AddValue("_gorev", (!this.MarkedForDeletion?_gorev:null));
			info.AddValue("_gorevReturnsNewIfNotFound", _gorevReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchGorev", _alwaysFetchGorev);
			info.AddValue("_alreadyFetchedGorev", _alreadyFetchedGorev);
			info.AddValue("_hiyerarsiTur", (!this.MarkedForDeletion?_hiyerarsiTur:null));
			info.AddValue("_hiyerarsiTurReturnsNewIfNotFound", _hiyerarsiTurReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchHiyerarsiTur", _alwaysFetchHiyerarsiTur);
			info.AddValue("_alreadyFetchedHiyerarsiTur", _alreadyFetchedHiyerarsiTur);
			info.AddValue("_yetki", (!this.MarkedForDeletion?_yetki:null));
			info.AddValue("_yetkiReturnsNewIfNotFound", _yetkiReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchYetki", _alwaysFetchYetki);
			info.AddValue("_alreadyFetchedYetki", _alreadyFetchedYetki);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Gorev":
					_alreadyFetchedGorev = true;
					this.Gorev = (GorevEntity)entity;
					break;
				case "HiyerarsiTur":
					_alreadyFetchedHiyerarsiTur = true;
					this.HiyerarsiTur = (HiyerarsiTurEntity)entity;
					break;
				case "Yetki":
					_alreadyFetchedYetki = true;
					this.Yetki = (YetkiEntity)entity;
					break;
				case "Bildirims":
					_alreadyFetchedBildirims = true;
					if(entity!=null)
					{
						this.Bildirims.Add((BildirimEntity)entity);
					}
					break;
				case "BildirimAtamaKullanicis":
					_alreadyFetchedBildirimAtamaKullanicis = true;
					if(entity!=null)
					{
						this.BildirimAtamaKullanicis.Add((BildirimAtamaKullaniciEntity)entity);
					}
					break;
				case "BildirimHistories":
					_alreadyFetchedBildirimHistories = true;
					if(entity!=null)
					{
						this.BildirimHistories.Add((BildirimHistoryEntity)entity);
					}
					break;
				case "Duyurus":
					_alreadyFetchedDuyurus = true;
					if(entity!=null)
					{
						this.Duyurus.Add((DuyuruEntity)entity);
					}
					break;
				case "EkSures":
					_alreadyFetchedEkSures = true;
					if(entity!=null)
					{
						this.EkSures.Add((EkSureEntity)entity);
					}
					break;
				case "GecenSures":
					_alreadyFetchedGecenSures = true;
					if(entity!=null)
					{
						this.GecenSures.Add((GecenSureEntity)entity);
					}
					break;
				case "GrupAtamas":
					_alreadyFetchedGrupAtamas = true;
					if(entity!=null)
					{
						this.GrupAtamas.Add((GrupAtamaEntity)entity);
					}
					break;
				case "IpBanks":
					_alreadyFetchedIpBanks = true;
					if(entity!=null)
					{
						this.IpBanks.Add((IpBankEntity)entity);
					}
					break;
				case "Istatistiks":
					_alreadyFetchedIstatistiks = true;
					if(entity!=null)
					{
						this.Istatistiks.Add((IstatistikEntity)entity);
					}
					break;
				case "KopukCagris":
					_alreadyFetchedKopukCagris = true;
					if(entity!=null)
					{
						this.KopukCagris.Add((KopukCagriEntity)entity);
					}
					break;
				case "KpsArsivs":
					_alreadyFetchedKpsArsivs = true;
					if(entity!=null)
					{
						this.KpsArsivs.Add((KpsArsivEntity)entity);
					}
					break;
				case "Logs":
					_alreadyFetchedLogs = true;
					if(entity!=null)
					{
						this.Logs.Add((LogEntity)entity);
					}
					break;
				case "Mesajs":
					_alreadyFetchedMesajs = true;
					if(entity!=null)
					{
						this.Mesajs.Add((MesajEntity)entity);
					}
					break;
				case "Parametres":
					_alreadyFetchedParametres = true;
					if(entity!=null)
					{
						this.Parametres.Add((ParametreEntity)entity);
					}
					break;
				case "ParametreGenelArsivs":
					_alreadyFetchedParametreGenelArsivs = true;
					if(entity!=null)
					{
						this.ParametreGenelArsivs.Add((ParametreGenelArsivEntity)entity);
					}
					break;
				case "RaporYetkis":
					_alreadyFetchedRaporYetkis = true;
					if(entity!=null)
					{
						this.RaporYetkis.Add((RaporYetkiEntity)entity);
					}
					break;
				case "Soruns":
					_alreadyFetchedSoruns = true;
					if(entity!=null)
					{
						this.Soruns.Add((SorunEntity)entity);
					}
					break;
				case "Vatandas":
					_alreadyFetchedVatandas = true;
					if(entity!=null)
					{
						this.Vatandas.Add((VatandaEntity)entity);
					}
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Gorev":
					SetupSyncGorev(relatedEntity);
					break;
				case "HiyerarsiTur":
					SetupSyncHiyerarsiTur(relatedEntity);
					break;
				case "Yetki":
					SetupSyncYetki(relatedEntity);
					break;
				case "Bildirims":
					_bildirims.Add((BildirimEntity)relatedEntity);
					break;
				case "BildirimAtamaKullanicis":
					_bildirimAtamaKullanicis.Add((BildirimAtamaKullaniciEntity)relatedEntity);
					break;
				case "BildirimHistories":
					_bildirimHistories.Add((BildirimHistoryEntity)relatedEntity);
					break;
				case "Duyurus":
					_duyurus.Add((DuyuruEntity)relatedEntity);
					break;
				case "EkSures":
					_ekSures.Add((EkSureEntity)relatedEntity);
					break;
				case "GecenSures":
					_gecenSures.Add((GecenSureEntity)relatedEntity);
					break;
				case "GrupAtamas":
					_grupAtamas.Add((GrupAtamaEntity)relatedEntity);
					break;
				case "IpBanks":
					_ipBanks.Add((IpBankEntity)relatedEntity);
					break;
				case "Istatistiks":
					_istatistiks.Add((IstatistikEntity)relatedEntity);
					break;
				case "KopukCagris":
					_kopukCagris.Add((KopukCagriEntity)relatedEntity);
					break;
				case "KpsArsivs":
					_kpsArsivs.Add((KpsArsivEntity)relatedEntity);
					break;
				case "Logs":
					_logs.Add((LogEntity)relatedEntity);
					break;
				case "Mesajs":
					_mesajs.Add((MesajEntity)relatedEntity);
					break;
				case "Parametres":
					_parametres.Add((ParametreEntity)relatedEntity);
					break;
				case "ParametreGenelArsivs":
					_parametreGenelArsivs.Add((ParametreGenelArsivEntity)relatedEntity);
					break;
				case "RaporYetkis":
					_raporYetkis.Add((RaporYetkiEntity)relatedEntity);
					break;
				case "Soruns":
					_soruns.Add((SorunEntity)relatedEntity);
					break;
				case "Vatandas":
					_vatandas.Add((VatandaEntity)relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Gorev":
					DesetupSyncGorev(false, true);
					break;
				case "HiyerarsiTur":
					DesetupSyncHiyerarsiTur(false, true);
					break;
				case "Yetki":
					DesetupSyncYetki(false, true);
					break;
				case "Bildirims":
					this.PerformRelatedEntityRemoval(_bildirims, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BildirimAtamaKullanicis":
					this.PerformRelatedEntityRemoval(_bildirimAtamaKullanicis, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BildirimHistories":
					this.PerformRelatedEntityRemoval(_bildirimHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Duyurus":
					this.PerformRelatedEntityRemoval(_duyurus, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EkSures":
					this.PerformRelatedEntityRemoval(_ekSures, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "GecenSures":
					this.PerformRelatedEntityRemoval(_gecenSures, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "GrupAtamas":
					this.PerformRelatedEntityRemoval(_grupAtamas, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "IpBanks":
					this.PerformRelatedEntityRemoval(_ipBanks, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Istatistiks":
					this.PerformRelatedEntityRemoval(_istatistiks, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "KopukCagris":
					this.PerformRelatedEntityRemoval(_kopukCagris, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "KpsArsivs":
					this.PerformRelatedEntityRemoval(_kpsArsivs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Logs":
					this.PerformRelatedEntityRemoval(_logs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Mesajs":
					this.PerformRelatedEntityRemoval(_mesajs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Parametres":
					this.PerformRelatedEntityRemoval(_parametres, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ParametreGenelArsivs":
					this.PerformRelatedEntityRemoval(_parametreGenelArsivs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RaporYetkis":
					this.PerformRelatedEntityRemoval(_raporYetkis, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Soruns":
					this.PerformRelatedEntityRemoval(_soruns, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Vatandas":
					this.PerformRelatedEntityRemoval(_vatandas, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_gorev!=null)
			{
				toReturn.Add(_gorev);
			}
			if(_hiyerarsiTur!=null)
			{
				toReturn.Add(_hiyerarsiTur);
			}
			if(_yetki!=null)
			{
				toReturn.Add(_yetki);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_bildirims);
			toReturn.Add(_bildirimAtamaKullanicis);
			toReturn.Add(_bildirimHistories);
			toReturn.Add(_duyurus);
			toReturn.Add(_ekSures);
			toReturn.Add(_gecenSures);
			toReturn.Add(_grupAtamas);
			toReturn.Add(_ipBanks);
			toReturn.Add(_istatistiks);
			toReturn.Add(_kopukCagris);
			toReturn.Add(_kpsArsivs);
			toReturn.Add(_logs);
			toReturn.Add(_mesajs);
			toReturn.Add(_parametres);
			toReturn.Add(_parametreGenelArsivs);
			toReturn.Add(_raporYetkis);
			toReturn.Add(_soruns);
			toReturn.Add(_vatandas);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kullaniciId)
		{
			return FetchUsingPK(kullaniciId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kullaniciId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(kullaniciId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kullaniciId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(kullaniciId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kullaniciId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(kullaniciId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.KullaniciId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new KullaniciRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'BildirimEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BildirimEntity'</returns>
		public dhmi.CollectionClasses.BildirimCollection GetMultiBildirims(bool forceFetch)
		{
			return GetMultiBildirims(forceFetch, _bildirims.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BildirimEntity'</returns>
		public dhmi.CollectionClasses.BildirimCollection GetMultiBildirims(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBildirims(forceFetch, _bildirims.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BildirimEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.BildirimCollection GetMultiBildirims(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBildirims(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.BildirimCollection GetMultiBildirims(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBildirims || forceFetch || _alwaysFetchBildirims) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_bildirims);
				_bildirims.SuppressClearInGetMulti=!forceFetch;
				_bildirims.EntityFactoryToUse = entityFactoryToUse;
				_bildirims.GetMultiManyToOne(null, null, null, null, null, this, null, filter);
				_bildirims.SuppressClearInGetMulti=false;
				_alreadyFetchedBildirims = true;
			}
			return _bildirims;
		}

		/// <summary> Sets the collection parameters for the collection for 'Bildirims'. These settings will be taken into account
		/// when the property Bildirims is requested or GetMultiBildirims is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBildirims(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bildirims.SortClauses=sortClauses;
			_bildirims.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaKullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BildirimAtamaKullaniciEntity'</returns>
		public dhmi.CollectionClasses.BildirimAtamaKullaniciCollection GetMultiBildirimAtamaKullanicis(bool forceFetch)
		{
			return GetMultiBildirimAtamaKullanicis(forceFetch, _bildirimAtamaKullanicis.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaKullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BildirimAtamaKullaniciEntity'</returns>
		public dhmi.CollectionClasses.BildirimAtamaKullaniciCollection GetMultiBildirimAtamaKullanicis(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBildirimAtamaKullanicis(forceFetch, _bildirimAtamaKullanicis.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaKullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.BildirimAtamaKullaniciCollection GetMultiBildirimAtamaKullanicis(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBildirimAtamaKullanicis(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaKullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.BildirimAtamaKullaniciCollection GetMultiBildirimAtamaKullanicis(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBildirimAtamaKullanicis || forceFetch || _alwaysFetchBildirimAtamaKullanicis) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_bildirimAtamaKullanicis);
				_bildirimAtamaKullanicis.SuppressClearInGetMulti=!forceFetch;
				_bildirimAtamaKullanicis.EntityFactoryToUse = entityFactoryToUse;
				_bildirimAtamaKullanicis.GetMultiManyToOne(null, this, filter);
				_bildirimAtamaKullanicis.SuppressClearInGetMulti=false;
				_alreadyFetchedBildirimAtamaKullanicis = true;
			}
			return _bildirimAtamaKullanicis;
		}

		/// <summary> Sets the collection parameters for the collection for 'BildirimAtamaKullanicis'. These settings will be taken into account
		/// when the property BildirimAtamaKullanicis is requested or GetMultiBildirimAtamaKullanicis is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBildirimAtamaKullanicis(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bildirimAtamaKullanicis.SortClauses=sortClauses;
			_bildirimAtamaKullanicis.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BildirimHistoryEntity'</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch)
		{
			return GetMultiBildirimHistories(forceFetch, _bildirimHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BildirimHistoryEntity'</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBildirimHistories(forceFetch, _bildirimHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBildirimHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBildirimHistories || forceFetch || _alwaysFetchBildirimHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_bildirimHistories);
				_bildirimHistories.SuppressClearInGetMulti=!forceFetch;
				_bildirimHistories.EntityFactoryToUse = entityFactoryToUse;
				_bildirimHistories.GetMultiManyToOne(null, null, this, filter);
				_bildirimHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedBildirimHistories = true;
			}
			return _bildirimHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'BildirimHistories'. These settings will be taken into account
		/// when the property BildirimHistories is requested or GetMultiBildirimHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBildirimHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bildirimHistories.SortClauses=sortClauses;
			_bildirimHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'DuyuruEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DuyuruEntity'</returns>
		public dhmi.CollectionClasses.DuyuruCollection GetMultiDuyurus(bool forceFetch)
		{
			return GetMultiDuyurus(forceFetch, _duyurus.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DuyuruEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'DuyuruEntity'</returns>
		public dhmi.CollectionClasses.DuyuruCollection GetMultiDuyurus(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiDuyurus(forceFetch, _duyurus.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'DuyuruEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.DuyuruCollection GetMultiDuyurus(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiDuyurus(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'DuyuruEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.DuyuruCollection GetMultiDuyurus(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedDuyurus || forceFetch || _alwaysFetchDuyurus) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_duyurus);
				_duyurus.SuppressClearInGetMulti=!forceFetch;
				_duyurus.EntityFactoryToUse = entityFactoryToUse;
				_duyurus.GetMultiManyToOne(this, filter);
				_duyurus.SuppressClearInGetMulti=false;
				_alreadyFetchedDuyurus = true;
			}
			return _duyurus;
		}

		/// <summary> Sets the collection parameters for the collection for 'Duyurus'. These settings will be taken into account
		/// when the property Duyurus is requested or GetMultiDuyurus is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDuyurus(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_duyurus.SortClauses=sortClauses;
			_duyurus.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'EkSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EkSureEntity'</returns>
		public dhmi.CollectionClasses.EkSureCollection GetMultiEkSures(bool forceFetch)
		{
			return GetMultiEkSures(forceFetch, _ekSures.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EkSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EkSureEntity'</returns>
		public dhmi.CollectionClasses.EkSureCollection GetMultiEkSures(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiEkSures(forceFetch, _ekSures.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'EkSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.EkSureCollection GetMultiEkSures(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiEkSures(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'EkSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.EkSureCollection GetMultiEkSures(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEkSures || forceFetch || _alwaysFetchEkSures) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_ekSures);
				_ekSures.SuppressClearInGetMulti=!forceFetch;
				_ekSures.EntityFactoryToUse = entityFactoryToUse;
				_ekSures.GetMultiManyToOne(null, this, filter);
				_ekSures.SuppressClearInGetMulti=false;
				_alreadyFetchedEkSures = true;
			}
			return _ekSures;
		}

		/// <summary> Sets the collection parameters for the collection for 'EkSures'. These settings will be taken into account
		/// when the property EkSures is requested or GetMultiEkSures is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEkSures(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_ekSures.SortClauses=sortClauses;
			_ekSures.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'GecenSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'GecenSureEntity'</returns>
		public dhmi.CollectionClasses.GecenSureCollection GetMultiGecenSures(bool forceFetch)
		{
			return GetMultiGecenSures(forceFetch, _gecenSures.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GecenSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'GecenSureEntity'</returns>
		public dhmi.CollectionClasses.GecenSureCollection GetMultiGecenSures(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiGecenSures(forceFetch, _gecenSures.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'GecenSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.GecenSureCollection GetMultiGecenSures(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiGecenSures(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GecenSureEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.GecenSureCollection GetMultiGecenSures(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedGecenSures || forceFetch || _alwaysFetchGecenSures) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_gecenSures);
				_gecenSures.SuppressClearInGetMulti=!forceFetch;
				_gecenSures.EntityFactoryToUse = entityFactoryToUse;
				_gecenSures.GetMultiManyToOne(null, this, filter);
				_gecenSures.SuppressClearInGetMulti=false;
				_alreadyFetchedGecenSures = true;
			}
			return _gecenSures;
		}

		/// <summary> Sets the collection parameters for the collection for 'GecenSures'. These settings will be taken into account
		/// when the property GecenSures is requested or GetMultiGecenSures is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersGecenSures(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_gecenSures.SortClauses=sortClauses;
			_gecenSures.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'GrupAtamaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'GrupAtamaEntity'</returns>
		public dhmi.CollectionClasses.GrupAtamaCollection GetMultiGrupAtamas(bool forceFetch)
		{
			return GetMultiGrupAtamas(forceFetch, _grupAtamas.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GrupAtamaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'GrupAtamaEntity'</returns>
		public dhmi.CollectionClasses.GrupAtamaCollection GetMultiGrupAtamas(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiGrupAtamas(forceFetch, _grupAtamas.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'GrupAtamaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.GrupAtamaCollection GetMultiGrupAtamas(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiGrupAtamas(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'GrupAtamaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.GrupAtamaCollection GetMultiGrupAtamas(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedGrupAtamas || forceFetch || _alwaysFetchGrupAtamas) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_grupAtamas);
				_grupAtamas.SuppressClearInGetMulti=!forceFetch;
				_grupAtamas.EntityFactoryToUse = entityFactoryToUse;
				_grupAtamas.GetMultiManyToOne(null, this, filter);
				_grupAtamas.SuppressClearInGetMulti=false;
				_alreadyFetchedGrupAtamas = true;
			}
			return _grupAtamas;
		}

		/// <summary> Sets the collection parameters for the collection for 'GrupAtamas'. These settings will be taken into account
		/// when the property GrupAtamas is requested or GetMultiGrupAtamas is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersGrupAtamas(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_grupAtamas.SortClauses=sortClauses;
			_grupAtamas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IpBankEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IpBankEntity'</returns>
		public dhmi.CollectionClasses.IpBankCollection GetMultiIpBanks(bool forceFetch)
		{
			return GetMultiIpBanks(forceFetch, _ipBanks.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IpBankEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IpBankEntity'</returns>
		public dhmi.CollectionClasses.IpBankCollection GetMultiIpBanks(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIpBanks(forceFetch, _ipBanks.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IpBankEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.IpBankCollection GetMultiIpBanks(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIpBanks(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IpBankEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.IpBankCollection GetMultiIpBanks(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIpBanks || forceFetch || _alwaysFetchIpBanks) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_ipBanks);
				_ipBanks.SuppressClearInGetMulti=!forceFetch;
				_ipBanks.EntityFactoryToUse = entityFactoryToUse;
				_ipBanks.GetMultiManyToOne(this, filter);
				_ipBanks.SuppressClearInGetMulti=false;
				_alreadyFetchedIpBanks = true;
			}
			return _ipBanks;
		}

		/// <summary> Sets the collection parameters for the collection for 'IpBanks'. These settings will be taken into account
		/// when the property IpBanks is requested or GetMultiIpBanks is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIpBanks(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_ipBanks.SortClauses=sortClauses;
			_ipBanks.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'IstatistikEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IstatistikEntity'</returns>
		public dhmi.CollectionClasses.IstatistikCollection GetMultiIstatistiks(bool forceFetch)
		{
			return GetMultiIstatistiks(forceFetch, _istatistiks.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IstatistikEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IstatistikEntity'</returns>
		public dhmi.CollectionClasses.IstatistikCollection GetMultiIstatistiks(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIstatistiks(forceFetch, _istatistiks.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IstatistikEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.IstatistikCollection GetMultiIstatistiks(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIstatistiks(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IstatistikEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.IstatistikCollection GetMultiIstatistiks(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIstatistiks || forceFetch || _alwaysFetchIstatistiks) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_istatistiks);
				_istatistiks.SuppressClearInGetMulti=!forceFetch;
				_istatistiks.EntityFactoryToUse = entityFactoryToUse;
				_istatistiks.GetMultiManyToOne(this, filter);
				_istatistiks.SuppressClearInGetMulti=false;
				_alreadyFetchedIstatistiks = true;
			}
			return _istatistiks;
		}

		/// <summary> Sets the collection parameters for the collection for 'Istatistiks'. These settings will be taken into account
		/// when the property Istatistiks is requested or GetMultiIstatistiks is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIstatistiks(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_istatistiks.SortClauses=sortClauses;
			_istatistiks.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'KopukCagriEntity'</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch)
		{
			return GetMultiKopukCagris(forceFetch, _kopukCagris.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'KopukCagriEntity'</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiKopukCagris(forceFetch, _kopukCagris.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiKopukCagris(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedKopukCagris || forceFetch || _alwaysFetchKopukCagris) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_kopukCagris);
				_kopukCagris.SuppressClearInGetMulti=!forceFetch;
				_kopukCagris.EntityFactoryToUse = entityFactoryToUse;
				_kopukCagris.GetMultiManyToOne(null, this, filter);
				_kopukCagris.SuppressClearInGetMulti=false;
				_alreadyFetchedKopukCagris = true;
			}
			return _kopukCagris;
		}

		/// <summary> Sets the collection parameters for the collection for 'KopukCagris'. These settings will be taken into account
		/// when the property KopukCagris is requested or GetMultiKopukCagris is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersKopukCagris(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_kopukCagris.SortClauses=sortClauses;
			_kopukCagris.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'KpsArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'KpsArsivEntity'</returns>
		public dhmi.CollectionClasses.KpsArsivCollection GetMultiKpsArsivs(bool forceFetch)
		{
			return GetMultiKpsArsivs(forceFetch, _kpsArsivs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KpsArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'KpsArsivEntity'</returns>
		public dhmi.CollectionClasses.KpsArsivCollection GetMultiKpsArsivs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiKpsArsivs(forceFetch, _kpsArsivs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'KpsArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.KpsArsivCollection GetMultiKpsArsivs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiKpsArsivs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KpsArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.KpsArsivCollection GetMultiKpsArsivs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedKpsArsivs || forceFetch || _alwaysFetchKpsArsivs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_kpsArsivs);
				_kpsArsivs.SuppressClearInGetMulti=!forceFetch;
				_kpsArsivs.EntityFactoryToUse = entityFactoryToUse;
				_kpsArsivs.GetMultiManyToOne(this, filter);
				_kpsArsivs.SuppressClearInGetMulti=false;
				_alreadyFetchedKpsArsivs = true;
			}
			return _kpsArsivs;
		}

		/// <summary> Sets the collection parameters for the collection for 'KpsArsivs'. These settings will be taken into account
		/// when the property KpsArsivs is requested or GetMultiKpsArsivs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersKpsArsivs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_kpsArsivs.SortClauses=sortClauses;
			_kpsArsivs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'LogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LogEntity'</returns>
		public dhmi.CollectionClasses.LogCollection GetMultiLogs(bool forceFetch)
		{
			return GetMultiLogs(forceFetch, _logs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'LogEntity'</returns>
		public dhmi.CollectionClasses.LogCollection GetMultiLogs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiLogs(forceFetch, _logs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'LogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.LogCollection GetMultiLogs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiLogs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'LogEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.LogCollection GetMultiLogs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedLogs || forceFetch || _alwaysFetchLogs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_logs);
				_logs.SuppressClearInGetMulti=!forceFetch;
				_logs.EntityFactoryToUse = entityFactoryToUse;
				_logs.GetMultiManyToOne(this, null, filter);
				_logs.SuppressClearInGetMulti=false;
				_alreadyFetchedLogs = true;
			}
			return _logs;
		}

		/// <summary> Sets the collection parameters for the collection for 'Logs'. These settings will be taken into account
		/// when the property Logs is requested or GetMultiLogs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLogs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_logs.SortClauses=sortClauses;
			_logs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'MesajEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MesajEntity'</returns>
		public dhmi.CollectionClasses.MesajCollection GetMultiMesajs(bool forceFetch)
		{
			return GetMultiMesajs(forceFetch, _mesajs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MesajEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MesajEntity'</returns>
		public dhmi.CollectionClasses.MesajCollection GetMultiMesajs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMesajs(forceFetch, _mesajs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MesajEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.MesajCollection GetMultiMesajs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMesajs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MesajEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.MesajCollection GetMultiMesajs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMesajs || forceFetch || _alwaysFetchMesajs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_mesajs);
				_mesajs.SuppressClearInGetMulti=!forceFetch;
				_mesajs.EntityFactoryToUse = entityFactoryToUse;
				_mesajs.GetMultiManyToOne(this, filter);
				_mesajs.SuppressClearInGetMulti=false;
				_alreadyFetchedMesajs = true;
			}
			return _mesajs;
		}

		/// <summary> Sets the collection parameters for the collection for 'Mesajs'. These settings will be taken into account
		/// when the property Mesajs is requested or GetMultiMesajs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMesajs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_mesajs.SortClauses=sortClauses;
			_mesajs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ParametreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParametreEntity'</returns>
		public dhmi.CollectionClasses.ParametreCollection GetMultiParametres(bool forceFetch)
		{
			return GetMultiParametres(forceFetch, _parametres.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParametreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ParametreEntity'</returns>
		public dhmi.CollectionClasses.ParametreCollection GetMultiParametres(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiParametres(forceFetch, _parametres.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ParametreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.ParametreCollection GetMultiParametres(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiParametres(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParametreEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.ParametreCollection GetMultiParametres(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedParametres || forceFetch || _alwaysFetchParametres) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_parametres);
				_parametres.SuppressClearInGetMulti=!forceFetch;
				_parametres.EntityFactoryToUse = entityFactoryToUse;
				_parametres.GetMultiManyToOne(this, null, filter);
				_parametres.SuppressClearInGetMulti=false;
				_alreadyFetchedParametres = true;
			}
			return _parametres;
		}

		/// <summary> Sets the collection parameters for the collection for 'Parametres'. These settings will be taken into account
		/// when the property Parametres is requested or GetMultiParametres is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParametres(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_parametres.SortClauses=sortClauses;
			_parametres.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ParametreGenelArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ParametreGenelArsivEntity'</returns>
		public dhmi.CollectionClasses.ParametreGenelArsivCollection GetMultiParametreGenelArsivs(bool forceFetch)
		{
			return GetMultiParametreGenelArsivs(forceFetch, _parametreGenelArsivs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParametreGenelArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ParametreGenelArsivEntity'</returns>
		public dhmi.CollectionClasses.ParametreGenelArsivCollection GetMultiParametreGenelArsivs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiParametreGenelArsivs(forceFetch, _parametreGenelArsivs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ParametreGenelArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.ParametreGenelArsivCollection GetMultiParametreGenelArsivs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiParametreGenelArsivs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ParametreGenelArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.ParametreGenelArsivCollection GetMultiParametreGenelArsivs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedParametreGenelArsivs || forceFetch || _alwaysFetchParametreGenelArsivs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_parametreGenelArsivs);
				_parametreGenelArsivs.SuppressClearInGetMulti=!forceFetch;
				_parametreGenelArsivs.EntityFactoryToUse = entityFactoryToUse;
				_parametreGenelArsivs.GetMultiManyToOne(this, null, filter);
				_parametreGenelArsivs.SuppressClearInGetMulti=false;
				_alreadyFetchedParametreGenelArsivs = true;
			}
			return _parametreGenelArsivs;
		}

		/// <summary> Sets the collection parameters for the collection for 'ParametreGenelArsivs'. These settings will be taken into account
		/// when the property ParametreGenelArsivs is requested or GetMultiParametreGenelArsivs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersParametreGenelArsivs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_parametreGenelArsivs.SortClauses=sortClauses;
			_parametreGenelArsivs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'RaporYetkiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'RaporYetkiEntity'</returns>
		public dhmi.CollectionClasses.RaporYetkiCollection GetMultiRaporYetkis(bool forceFetch)
		{
			return GetMultiRaporYetkis(forceFetch, _raporYetkis.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RaporYetkiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'RaporYetkiEntity'</returns>
		public dhmi.CollectionClasses.RaporYetkiCollection GetMultiRaporYetkis(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiRaporYetkis(forceFetch, _raporYetkis.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'RaporYetkiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.RaporYetkiCollection GetMultiRaporYetkis(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiRaporYetkis(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'RaporYetkiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.RaporYetkiCollection GetMultiRaporYetkis(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedRaporYetkis || forceFetch || _alwaysFetchRaporYetkis) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_raporYetkis);
				_raporYetkis.SuppressClearInGetMulti=!forceFetch;
				_raporYetkis.EntityFactoryToUse = entityFactoryToUse;
				_raporYetkis.GetMultiManyToOne(this, null, filter);
				_raporYetkis.SuppressClearInGetMulti=false;
				_alreadyFetchedRaporYetkis = true;
			}
			return _raporYetkis;
		}

		/// <summary> Sets the collection parameters for the collection for 'RaporYetkis'. These settings will be taken into account
		/// when the property RaporYetkis is requested or GetMultiRaporYetkis is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersRaporYetkis(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_raporYetkis.SortClauses=sortClauses;
			_raporYetkis.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SorunEntity'</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch)
		{
			return GetMultiSoruns(forceFetch, _soruns.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SorunEntity'</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSoruns(forceFetch, _soruns.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSoruns(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSoruns || forceFetch || _alwaysFetchSoruns) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_soruns);
				_soruns.SuppressClearInGetMulti=!forceFetch;
				_soruns.EntityFactoryToUse = entityFactoryToUse;
				_soruns.GetMultiManyToOne(this, null, filter);
				_soruns.SuppressClearInGetMulti=false;
				_alreadyFetchedSoruns = true;
			}
			return _soruns;
		}

		/// <summary> Sets the collection parameters for the collection for 'Soruns'. These settings will be taken into account
		/// when the property Soruns is requested or GetMultiSoruns is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSoruns(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_soruns.SortClauses=sortClauses;
			_soruns.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VatandaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VatandaEntity'</returns>
		public dhmi.CollectionClasses.VatandaCollection GetMultiVatandas(bool forceFetch)
		{
			return GetMultiVatandas(forceFetch, _vatandas.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VatandaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VatandaEntity'</returns>
		public dhmi.CollectionClasses.VatandaCollection GetMultiVatandas(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVatandas(forceFetch, _vatandas.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VatandaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.VatandaCollection GetMultiVatandas(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVatandas(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VatandaEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.VatandaCollection GetMultiVatandas(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVatandas || forceFetch || _alwaysFetchVatandas) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vatandas);
				_vatandas.SuppressClearInGetMulti=!forceFetch;
				_vatandas.EntityFactoryToUse = entityFactoryToUse;
				_vatandas.GetMultiManyToOne(this, filter);
				_vatandas.SuppressClearInGetMulti=false;
				_alreadyFetchedVatandas = true;
			}
			return _vatandas;
		}

		/// <summary> Sets the collection parameters for the collection for 'Vatandas'. These settings will be taken into account
		/// when the property Vatandas is requested or GetMultiVatandas is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVatandas(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vatandas.SortClauses=sortClauses;
			_vatandas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'GorevEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'GorevEntity' which is related to this entity.</returns>
		public GorevEntity GetSingleGorev()
		{
			return GetSingleGorev(false);
		}

		/// <summary> Retrieves the related entity of type 'GorevEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'GorevEntity' which is related to this entity.</returns>
		public virtual GorevEntity GetSingleGorev(bool forceFetch)
		{
			if( ( !_alreadyFetchedGorev || forceFetch || _alwaysFetchGorev) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.GorevEntityUsingFkGorevId);
				GorevEntity newEntity = new GorevEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkGorevId);
				}
				if(fetchResult)
				{
					newEntity = (GorevEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_gorevReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Gorev = newEntity;
				_alreadyFetchedGorev = fetchResult;
			}
			return _gorev;
		}


		/// <summary> Retrieves the related entity of type 'HiyerarsiTurEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'HiyerarsiTurEntity' which is related to this entity.</returns>
		public HiyerarsiTurEntity GetSingleHiyerarsiTur()
		{
			return GetSingleHiyerarsiTur(false);
		}

		/// <summary> Retrieves the related entity of type 'HiyerarsiTurEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'HiyerarsiTurEntity' which is related to this entity.</returns>
		public virtual HiyerarsiTurEntity GetSingleHiyerarsiTur(bool forceFetch)
		{
			if( ( !_alreadyFetchedHiyerarsiTur || forceFetch || _alwaysFetchHiyerarsiTur) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.HiyerarsiTurEntityUsingFkHiyerarsiTurId);
				HiyerarsiTurEntity newEntity = new HiyerarsiTurEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkHiyerarsiTurId);
				}
				if(fetchResult)
				{
					newEntity = (HiyerarsiTurEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_hiyerarsiTurReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.HiyerarsiTur = newEntity;
				_alreadyFetchedHiyerarsiTur = fetchResult;
			}
			return _hiyerarsiTur;
		}


		/// <summary> Retrieves the related entity of type 'YetkiEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'YetkiEntity' which is related to this entity.</returns>
		public YetkiEntity GetSingleYetki()
		{
			return GetSingleYetki(false);
		}

		/// <summary> Retrieves the related entity of type 'YetkiEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'YetkiEntity' which is related to this entity.</returns>
		public virtual YetkiEntity GetSingleYetki(bool forceFetch)
		{
			if( ( !_alreadyFetchedYetki || forceFetch || _alwaysFetchYetki) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.YetkiEntityUsingFkYetkiId);
				YetkiEntity newEntity = new YetkiEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkYetkiId);
				}
				if(fetchResult)
				{
					newEntity = (YetkiEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_yetkiReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Yetki = newEntity;
				_alreadyFetchedYetki = fetchResult;
			}
			return _yetki;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Gorev", _gorev);
			toReturn.Add("HiyerarsiTur", _hiyerarsiTur);
			toReturn.Add("Yetki", _yetki);
			toReturn.Add("Bildirims", _bildirims);
			toReturn.Add("BildirimAtamaKullanicis", _bildirimAtamaKullanicis);
			toReturn.Add("BildirimHistories", _bildirimHistories);
			toReturn.Add("Duyurus", _duyurus);
			toReturn.Add("EkSures", _ekSures);
			toReturn.Add("GecenSures", _gecenSures);
			toReturn.Add("GrupAtamas", _grupAtamas);
			toReturn.Add("IpBanks", _ipBanks);
			toReturn.Add("Istatistiks", _istatistiks);
			toReturn.Add("KopukCagris", _kopukCagris);
			toReturn.Add("KpsArsivs", _kpsArsivs);
			toReturn.Add("Logs", _logs);
			toReturn.Add("Mesajs", _mesajs);
			toReturn.Add("Parametres", _parametres);
			toReturn.Add("ParametreGenelArsivs", _parametreGenelArsivs);
			toReturn.Add("RaporYetkis", _raporYetkis);
			toReturn.Add("Soruns", _soruns);
			toReturn.Add("Vatandas", _vatandas);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="validator">The validator object for this KullaniciEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 kullaniciId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(kullaniciId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirims = new dhmi.CollectionClasses.BildirimCollection();
			_bildirims.SetContainingEntityInfo(this, "Kullanici");

			_bildirimAtamaKullanicis = new dhmi.CollectionClasses.BildirimAtamaKullaniciCollection();
			_bildirimAtamaKullanicis.SetContainingEntityInfo(this, "Kullanici");

			_bildirimHistories = new dhmi.CollectionClasses.BildirimHistoryCollection();
			_bildirimHistories.SetContainingEntityInfo(this, "Kullanici");

			_duyurus = new dhmi.CollectionClasses.DuyuruCollection();
			_duyurus.SetContainingEntityInfo(this, "Kullanici");

			_ekSures = new dhmi.CollectionClasses.EkSureCollection();
			_ekSures.SetContainingEntityInfo(this, "Kullanici");

			_gecenSures = new dhmi.CollectionClasses.GecenSureCollection();
			_gecenSures.SetContainingEntityInfo(this, "Kullanici");

			_grupAtamas = new dhmi.CollectionClasses.GrupAtamaCollection();
			_grupAtamas.SetContainingEntityInfo(this, "Kullanici");

			_ipBanks = new dhmi.CollectionClasses.IpBankCollection();
			_ipBanks.SetContainingEntityInfo(this, "Kullanici");

			_istatistiks = new dhmi.CollectionClasses.IstatistikCollection();
			_istatistiks.SetContainingEntityInfo(this, "Kullanici");

			_kopukCagris = new dhmi.CollectionClasses.KopukCagriCollection();
			_kopukCagris.SetContainingEntityInfo(this, "Kullanici");

			_kpsArsivs = new dhmi.CollectionClasses.KpsArsivCollection();
			_kpsArsivs.SetContainingEntityInfo(this, "Kullanici");

			_logs = new dhmi.CollectionClasses.LogCollection();
			_logs.SetContainingEntityInfo(this, "Kullanici");

			_mesajs = new dhmi.CollectionClasses.MesajCollection();
			_mesajs.SetContainingEntityInfo(this, "Kullanici");

			_parametres = new dhmi.CollectionClasses.ParametreCollection();
			_parametres.SetContainingEntityInfo(this, "Kullanici");

			_parametreGenelArsivs = new dhmi.CollectionClasses.ParametreGenelArsivCollection();
			_parametreGenelArsivs.SetContainingEntityInfo(this, "Kullanici");

			_raporYetkis = new dhmi.CollectionClasses.RaporYetkiCollection();
			_raporYetkis.SetContainingEntityInfo(this, "Kullanici");

			_soruns = new dhmi.CollectionClasses.SorunCollection();
			_soruns.SetContainingEntityInfo(this, "Kullanici");

			_vatandas = new dhmi.CollectionClasses.VatandaCollection();
			_vatandas.SetContainingEntityInfo(this, "Kullanici");
			_gorevReturnsNewIfNotFound = false;
			_hiyerarsiTurReturnsNewIfNotFound = false;
			_yetkiReturnsNewIfNotFound = false;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AvayaLoginId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Extension", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkGorevId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkHiyerarsiTurId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkYetkiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciBirim", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciGizliSoru", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciGizliSoruCevap", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciMail", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciPassword", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KullaniciUsername", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TcKimlikNo", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _gorev</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncGorev(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _gorev, new PropertyChangedEventHandler( OnGorevPropertyChanged ), "Gorev", dhmi.RelationClasses.StaticKullaniciRelations.GorevEntityUsingFkGorevIdStatic, true, signalRelatedEntity, "Kullanicis", resetFKFields, new int[] { (int)KullaniciFieldIndex.FkGorevId } );		
			_gorev = null;
		}
		
		/// <summary> setups the sync logic for member _gorev</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncGorev(IEntityCore relatedEntity)
		{
			if(_gorev!=relatedEntity)
			{		
				DesetupSyncGorev(true, true);
				_gorev = (GorevEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _gorev, new PropertyChangedEventHandler( OnGorevPropertyChanged ), "Gorev", dhmi.RelationClasses.StaticKullaniciRelations.GorevEntityUsingFkGorevIdStatic, true, ref _alreadyFetchedGorev, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnGorevPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _hiyerarsiTur</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncHiyerarsiTur(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _hiyerarsiTur, new PropertyChangedEventHandler( OnHiyerarsiTurPropertyChanged ), "HiyerarsiTur", dhmi.RelationClasses.StaticKullaniciRelations.HiyerarsiTurEntityUsingFkHiyerarsiTurIdStatic, true, signalRelatedEntity, "Kullanicis", resetFKFields, new int[] { (int)KullaniciFieldIndex.FkHiyerarsiTurId } );		
			_hiyerarsiTur = null;
		}
		
		/// <summary> setups the sync logic for member _hiyerarsiTur</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncHiyerarsiTur(IEntityCore relatedEntity)
		{
			if(_hiyerarsiTur!=relatedEntity)
			{		
				DesetupSyncHiyerarsiTur(true, true);
				_hiyerarsiTur = (HiyerarsiTurEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _hiyerarsiTur, new PropertyChangedEventHandler( OnHiyerarsiTurPropertyChanged ), "HiyerarsiTur", dhmi.RelationClasses.StaticKullaniciRelations.HiyerarsiTurEntityUsingFkHiyerarsiTurIdStatic, true, ref _alreadyFetchedHiyerarsiTur, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnHiyerarsiTurPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _yetki</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncYetki(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticKullaniciRelations.YetkiEntityUsingFkYetkiIdStatic, true, signalRelatedEntity, "Kullanicis", resetFKFields, new int[] { (int)KullaniciFieldIndex.FkYetkiId } );		
			_yetki = null;
		}
		
		/// <summary> setups the sync logic for member _yetki</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncYetki(IEntityCore relatedEntity)
		{
			if(_yetki!=relatedEntity)
			{		
				DesetupSyncYetki(true, true);
				_yetki = (YetkiEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticKullaniciRelations.YetkiEntityUsingFkYetkiIdStatic, true, ref _alreadyFetchedYetki, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnYetkiPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="kullaniciId">PK value for Kullanici which data should be fetched into this Kullanici object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 kullaniciId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)KullaniciFieldIndex.KullaniciId].ForcedCurrentValueWrite(kullaniciId);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateKullaniciDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new KullaniciEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static KullaniciRelations Relations
		{
			get	{ return new KullaniciRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bildirim' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirims
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimCollection(), (IEntityRelation)GetRelationsForField("Bildirims")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.BildirimEntity, 0, null, null, null, "Bildirims", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimAtamaKullanici' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimAtamaKullanicis
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimAtamaKullaniciCollection(), (IEntityRelation)GetRelationsForField("BildirimAtamaKullanicis")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.BildirimAtamaKullaniciEntity, 0, null, null, null, "BildirimAtamaKullanicis", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimHistories
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimHistoryCollection(), (IEntityRelation)GetRelationsForField("BildirimHistories")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.BildirimHistoryEntity, 0, null, null, null, "BildirimHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Duyuru' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathDuyurus
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.DuyuruCollection(), (IEntityRelation)GetRelationsForField("Duyurus")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.DuyuruEntity, 0, null, null, null, "Duyurus", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EkSure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEkSures
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.EkSureCollection(), (IEntityRelation)GetRelationsForField("EkSures")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.EkSureEntity, 0, null, null, null, "EkSures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GecenSure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGecenSures
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.GecenSureCollection(), (IEntityRelation)GetRelationsForField("GecenSures")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.GecenSureEntity, 0, null, null, null, "GecenSures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GrupAtama' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGrupAtamas
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.GrupAtamaCollection(), (IEntityRelation)GetRelationsForField("GrupAtamas")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.GrupAtamaEntity, 0, null, null, null, "GrupAtamas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'IpBank' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIpBanks
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.IpBankCollection(), (IEntityRelation)GetRelationsForField("IpBanks")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.IpBankEntity, 0, null, null, null, "IpBanks", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Istatistik' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIstatistiks
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.IstatistikCollection(), (IEntityRelation)GetRelationsForField("Istatistiks")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.IstatistikEntity, 0, null, null, null, "Istatistiks", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'KopukCagri' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKopukCagris
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KopukCagriCollection(), (IEntityRelation)GetRelationsForField("KopukCagris")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.KopukCagriEntity, 0, null, null, null, "KopukCagris", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'KpsArsiv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKpsArsivs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KpsArsivCollection(), (IEntityRelation)GetRelationsForField("KpsArsivs")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.KpsArsivEntity, 0, null, null, null, "KpsArsivs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Log' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathLogs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.LogCollection(), (IEntityRelation)GetRelationsForField("Logs")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.LogEntity, 0, null, null, null, "Logs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Mesaj' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMesajs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.MesajCollection(), (IEntityRelation)GetRelationsForField("Mesajs")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.MesajEntity, 0, null, null, null, "Mesajs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Parametre' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParametres
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.ParametreCollection(), (IEntityRelation)GetRelationsForField("Parametres")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.ParametreEntity, 0, null, null, null, "Parametres", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ParametreGenelArsiv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParametreGenelArsivs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.ParametreGenelArsivCollection(), (IEntityRelation)GetRelationsForField("ParametreGenelArsivs")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.ParametreGenelArsivEntity, 0, null, null, null, "ParametreGenelArsivs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RaporYetki' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathRaporYetkis
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.RaporYetkiCollection(), (IEntityRelation)GetRelationsForField("RaporYetkis")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.RaporYetkiEntity, 0, null, null, null, "RaporYetkis", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sorun' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSoruns
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.SorunCollection(), (IEntityRelation)GetRelationsForField("Soruns")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.SorunEntity, 0, null, null, null, "Soruns", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vatanda' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVatandas
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.VatandaCollection(), (IEntityRelation)GetRelationsForField("Vatandas")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.VatandaEntity, 0, null, null, null, "Vatandas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Gorev'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGorev
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.GorevCollection(), (IEntityRelation)GetRelationsForField("Gorev")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.GorevEntity, 0, null, null, null, "Gorev", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'HiyerarsiTur'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathHiyerarsiTur
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.HiyerarsiTurCollection(), (IEntityRelation)GetRelationsForField("HiyerarsiTur")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.HiyerarsiTurEntity, 0, null, null, null, "HiyerarsiTur", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Yetki'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathYetki
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.YetkiCollection(), (IEntityRelation)GetRelationsForField("Yetki")[0], (int)dhmi.EntityType.KullaniciEntity, (int)dhmi.EntityType.YetkiEntity, 0, null, null, null, "Yetki", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The AvayaLoginId property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."AvayaLoginId"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 6<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AvayaLoginId
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.AvayaLoginId, true); }
			set	{ SetValue((int)KullaniciFieldIndex.AvayaLoginId, value, true); }
		}

		/// <summary> The Extension property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Extension"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Extension
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.Extension, true); }
			set	{ SetValue((int)KullaniciFieldIndex.Extension, value, true); }
		}

		/// <summary> The FkGorevId property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."FK_Gorev_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkGorevId
		{
			get { return (System.Int16)GetValue((int)KullaniciFieldIndex.FkGorevId, true); }
			set	{ SetValue((int)KullaniciFieldIndex.FkGorevId, value, true); }
		}

		/// <summary> The FkHiyerarsiTurId property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."FK_Hiyerarsi_Tur_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkHiyerarsiTurId
		{
			get { return (System.Int16)GetValue((int)KullaniciFieldIndex.FkHiyerarsiTurId, true); }
			set	{ SetValue((int)KullaniciFieldIndex.FkHiyerarsiTurId, value, true); }
		}

		/// <summary> The FkYetkiId property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."FK_Yetki_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkYetkiId
		{
			get { return (System.Int16)GetValue((int)KullaniciFieldIndex.FkYetkiId, true); }
			set	{ SetValue((int)KullaniciFieldIndex.FkYetkiId, value, true); }
		}

		/// <summary> The KullaniciAciklama property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KullaniciAciklama
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciAciklama, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciAciklama, value, true); }
		}

		/// <summary> The KullaniciAd property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KullaniciAd
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciAd, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciAd, value, true); }
		}

		/// <summary> The KullaniciAdSoyad property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Ad_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KullaniciAdSoyad
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciAdSoyad, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciAdSoyad, value, true); }
		}

		/// <summary> The KullaniciBirim property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Birim"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KullaniciBirim
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciBirim, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciBirim, value, true); }
		}

		/// <summary> The KullaniciDurum property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean KullaniciDurum
		{
			get { return (System.Boolean)GetValue((int)KullaniciFieldIndex.KullaniciDurum, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciDurum, value, true); }
		}

		/// <summary> The KullaniciGizliSoru property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Gizli_Soru"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KullaniciGizliSoru
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciGizliSoru, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciGizliSoru, value, true); }
		}

		/// <summary> The KullaniciGizliSoruCevap property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Gizli_Soru_Cevap"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KullaniciGizliSoruCevap
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciGizliSoruCevap, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciGizliSoruCevap, value, true); }
		}

		/// <summary> The KullaniciId property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 KullaniciId
		{
			get { return (System.Int16)GetValue((int)KullaniciFieldIndex.KullaniciId, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciId, value, true); }
		}

		/// <summary> The KullaniciMail property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Mail"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 70<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KullaniciMail
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciMail, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciMail, value, true); }
		}

		/// <summary> The KullaniciPassword property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KullaniciPassword
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciPassword, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciPassword, value, true); }
		}

		/// <summary> The KullaniciSoyad property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KullaniciSoyad
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciSoyad, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciSoyad, value, true); }
		}

		/// <summary> The KullaniciTarih property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime KullaniciTarih
		{
			get { return (System.DateTime)GetValue((int)KullaniciFieldIndex.KullaniciTarih, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciTarih, value, true); }
		}

		/// <summary> The KullaniciUsername property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."Kullanici_Username"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KullaniciUsername
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.KullaniciUsername, true); }
			set	{ SetValue((int)KullaniciFieldIndex.KullaniciUsername, value, true); }
		}

		/// <summary> The TcKimlikNo property of the Entity Kullanici<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kullanici"."TcKimlikNo"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 11<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TcKimlikNo
		{
			get { return (System.String)GetValue((int)KullaniciFieldIndex.TcKimlikNo, true); }
			set	{ SetValue((int)KullaniciFieldIndex.TcKimlikNo, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BildirimEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBildirims()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.BildirimCollection Bildirims
		{
			get	{ return GetMultiBildirims(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Bildirims. When set to true, Bildirims is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Bildirims is accessed. You can always execute/ a forced fetch by calling GetMultiBildirims(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirims
		{
			get	{ return _alwaysFetchBildirims; }
			set	{ _alwaysFetchBildirims = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Bildirims already has been fetched. Setting this property to false when Bildirims has been fetched
		/// will clear the Bildirims collection well. Setting this property to true while Bildirims hasn't been fetched disables lazy loading for Bildirims</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirims
		{
			get { return _alreadyFetchedBildirims;}
			set 
			{
				if(_alreadyFetchedBildirims && !value && (_bildirims != null))
				{
					_bildirims.Clear();
				}
				_alreadyFetchedBildirims = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'BildirimAtamaKullaniciEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBildirimAtamaKullanicis()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.BildirimAtamaKullaniciCollection BildirimAtamaKullanicis
		{
			get	{ return GetMultiBildirimAtamaKullanicis(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimAtamaKullanicis. When set to true, BildirimAtamaKullanicis is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimAtamaKullanicis is accessed. You can always execute/ a forced fetch by calling GetMultiBildirimAtamaKullanicis(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimAtamaKullanicis
		{
			get	{ return _alwaysFetchBildirimAtamaKullanicis; }
			set	{ _alwaysFetchBildirimAtamaKullanicis = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimAtamaKullanicis already has been fetched. Setting this property to false when BildirimAtamaKullanicis has been fetched
		/// will clear the BildirimAtamaKullanicis collection well. Setting this property to true while BildirimAtamaKullanicis hasn't been fetched disables lazy loading for BildirimAtamaKullanicis</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimAtamaKullanicis
		{
			get { return _alreadyFetchedBildirimAtamaKullanicis;}
			set 
			{
				if(_alreadyFetchedBildirimAtamaKullanicis && !value && (_bildirimAtamaKullanicis != null))
				{
					_bildirimAtamaKullanicis.Clear();
				}
				_alreadyFetchedBildirimAtamaKullanicis = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBildirimHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.BildirimHistoryCollection BildirimHistories
		{
			get	{ return GetMultiBildirimHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimHistories. When set to true, BildirimHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimHistories is accessed. You can always execute/ a forced fetch by calling GetMultiBildirimHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimHistories
		{
			get	{ return _alwaysFetchBildirimHistories; }
			set	{ _alwaysFetchBildirimHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimHistories already has been fetched. Setting this property to false when BildirimHistories has been fetched
		/// will clear the BildirimHistories collection well. Setting this property to true while BildirimHistories hasn't been fetched disables lazy loading for BildirimHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimHistories
		{
			get { return _alreadyFetchedBildirimHistories;}
			set 
			{
				if(_alreadyFetchedBildirimHistories && !value && (_bildirimHistories != null))
				{
					_bildirimHistories.Clear();
				}
				_alreadyFetchedBildirimHistories = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'DuyuruEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDuyurus()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.DuyuruCollection Duyurus
		{
			get	{ return GetMultiDuyurus(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Duyurus. When set to true, Duyurus is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Duyurus is accessed. You can always execute/ a forced fetch by calling GetMultiDuyurus(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchDuyurus
		{
			get	{ return _alwaysFetchDuyurus; }
			set	{ _alwaysFetchDuyurus = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Duyurus already has been fetched. Setting this property to false when Duyurus has been fetched
		/// will clear the Duyurus collection well. Setting this property to true while Duyurus hasn't been fetched disables lazy loading for Duyurus</summary>
		[Browsable(false)]
		public bool AlreadyFetchedDuyurus
		{
			get { return _alreadyFetchedDuyurus;}
			set 
			{
				if(_alreadyFetchedDuyurus && !value && (_duyurus != null))
				{
					_duyurus.Clear();
				}
				_alreadyFetchedDuyurus = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'EkSureEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEkSures()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.EkSureCollection EkSures
		{
			get	{ return GetMultiEkSures(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for EkSures. When set to true, EkSures is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EkSures is accessed. You can always execute/ a forced fetch by calling GetMultiEkSures(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchEkSures
		{
			get	{ return _alwaysFetchEkSures; }
			set	{ _alwaysFetchEkSures = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property EkSures already has been fetched. Setting this property to false when EkSures has been fetched
		/// will clear the EkSures collection well. Setting this property to true while EkSures hasn't been fetched disables lazy loading for EkSures</summary>
		[Browsable(false)]
		public bool AlreadyFetchedEkSures
		{
			get { return _alreadyFetchedEkSures;}
			set 
			{
				if(_alreadyFetchedEkSures && !value && (_ekSures != null))
				{
					_ekSures.Clear();
				}
				_alreadyFetchedEkSures = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'GecenSureEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGecenSures()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.GecenSureCollection GecenSures
		{
			get	{ return GetMultiGecenSures(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for GecenSures. When set to true, GecenSures is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time GecenSures is accessed. You can always execute/ a forced fetch by calling GetMultiGecenSures(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchGecenSures
		{
			get	{ return _alwaysFetchGecenSures; }
			set	{ _alwaysFetchGecenSures = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property GecenSures already has been fetched. Setting this property to false when GecenSures has been fetched
		/// will clear the GecenSures collection well. Setting this property to true while GecenSures hasn't been fetched disables lazy loading for GecenSures</summary>
		[Browsable(false)]
		public bool AlreadyFetchedGecenSures
		{
			get { return _alreadyFetchedGecenSures;}
			set 
			{
				if(_alreadyFetchedGecenSures && !value && (_gecenSures != null))
				{
					_gecenSures.Clear();
				}
				_alreadyFetchedGecenSures = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'GrupAtamaEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiGrupAtamas()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.GrupAtamaCollection GrupAtamas
		{
			get	{ return GetMultiGrupAtamas(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for GrupAtamas. When set to true, GrupAtamas is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time GrupAtamas is accessed. You can always execute/ a forced fetch by calling GetMultiGrupAtamas(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchGrupAtamas
		{
			get	{ return _alwaysFetchGrupAtamas; }
			set	{ _alwaysFetchGrupAtamas = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property GrupAtamas already has been fetched. Setting this property to false when GrupAtamas has been fetched
		/// will clear the GrupAtamas collection well. Setting this property to true while GrupAtamas hasn't been fetched disables lazy loading for GrupAtamas</summary>
		[Browsable(false)]
		public bool AlreadyFetchedGrupAtamas
		{
			get { return _alreadyFetchedGrupAtamas;}
			set 
			{
				if(_alreadyFetchedGrupAtamas && !value && (_grupAtamas != null))
				{
					_grupAtamas.Clear();
				}
				_alreadyFetchedGrupAtamas = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IpBankEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIpBanks()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.IpBankCollection IpBanks
		{
			get	{ return GetMultiIpBanks(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for IpBanks. When set to true, IpBanks is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time IpBanks is accessed. You can always execute/ a forced fetch by calling GetMultiIpBanks(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIpBanks
		{
			get	{ return _alwaysFetchIpBanks; }
			set	{ _alwaysFetchIpBanks = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property IpBanks already has been fetched. Setting this property to false when IpBanks has been fetched
		/// will clear the IpBanks collection well. Setting this property to true while IpBanks hasn't been fetched disables lazy loading for IpBanks</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIpBanks
		{
			get { return _alreadyFetchedIpBanks;}
			set 
			{
				if(_alreadyFetchedIpBanks && !value && (_ipBanks != null))
				{
					_ipBanks.Clear();
				}
				_alreadyFetchedIpBanks = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'IstatistikEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIstatistiks()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.IstatistikCollection Istatistiks
		{
			get	{ return GetMultiIstatistiks(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Istatistiks. When set to true, Istatistiks is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Istatistiks is accessed. You can always execute/ a forced fetch by calling GetMultiIstatistiks(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIstatistiks
		{
			get	{ return _alwaysFetchIstatistiks; }
			set	{ _alwaysFetchIstatistiks = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Istatistiks already has been fetched. Setting this property to false when Istatistiks has been fetched
		/// will clear the Istatistiks collection well. Setting this property to true while Istatistiks hasn't been fetched disables lazy loading for Istatistiks</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIstatistiks
		{
			get { return _alreadyFetchedIstatistiks;}
			set 
			{
				if(_alreadyFetchedIstatistiks && !value && (_istatistiks != null))
				{
					_istatistiks.Clear();
				}
				_alreadyFetchedIstatistiks = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiKopukCagris()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.KopukCagriCollection KopukCagris
		{
			get	{ return GetMultiKopukCagris(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for KopukCagris. When set to true, KopukCagris is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time KopukCagris is accessed. You can always execute/ a forced fetch by calling GetMultiKopukCagris(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKopukCagris
		{
			get	{ return _alwaysFetchKopukCagris; }
			set	{ _alwaysFetchKopukCagris = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property KopukCagris already has been fetched. Setting this property to false when KopukCagris has been fetched
		/// will clear the KopukCagris collection well. Setting this property to true while KopukCagris hasn't been fetched disables lazy loading for KopukCagris</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKopukCagris
		{
			get { return _alreadyFetchedKopukCagris;}
			set 
			{
				if(_alreadyFetchedKopukCagris && !value && (_kopukCagris != null))
				{
					_kopukCagris.Clear();
				}
				_alreadyFetchedKopukCagris = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'KpsArsivEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiKpsArsivs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.KpsArsivCollection KpsArsivs
		{
			get	{ return GetMultiKpsArsivs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for KpsArsivs. When set to true, KpsArsivs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time KpsArsivs is accessed. You can always execute/ a forced fetch by calling GetMultiKpsArsivs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKpsArsivs
		{
			get	{ return _alwaysFetchKpsArsivs; }
			set	{ _alwaysFetchKpsArsivs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property KpsArsivs already has been fetched. Setting this property to false when KpsArsivs has been fetched
		/// will clear the KpsArsivs collection well. Setting this property to true while KpsArsivs hasn't been fetched disables lazy loading for KpsArsivs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKpsArsivs
		{
			get { return _alreadyFetchedKpsArsivs;}
			set 
			{
				if(_alreadyFetchedKpsArsivs && !value && (_kpsArsivs != null))
				{
					_kpsArsivs.Clear();
				}
				_alreadyFetchedKpsArsivs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'LogEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLogs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.LogCollection Logs
		{
			get	{ return GetMultiLogs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Logs. When set to true, Logs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Logs is accessed. You can always execute/ a forced fetch by calling GetMultiLogs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchLogs
		{
			get	{ return _alwaysFetchLogs; }
			set	{ _alwaysFetchLogs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Logs already has been fetched. Setting this property to false when Logs has been fetched
		/// will clear the Logs collection well. Setting this property to true while Logs hasn't been fetched disables lazy loading for Logs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedLogs
		{
			get { return _alreadyFetchedLogs;}
			set 
			{
				if(_alreadyFetchedLogs && !value && (_logs != null))
				{
					_logs.Clear();
				}
				_alreadyFetchedLogs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'MesajEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMesajs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.MesajCollection Mesajs
		{
			get	{ return GetMultiMesajs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Mesajs. When set to true, Mesajs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Mesajs is accessed. You can always execute/ a forced fetch by calling GetMultiMesajs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMesajs
		{
			get	{ return _alwaysFetchMesajs; }
			set	{ _alwaysFetchMesajs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Mesajs already has been fetched. Setting this property to false when Mesajs has been fetched
		/// will clear the Mesajs collection well. Setting this property to true while Mesajs hasn't been fetched disables lazy loading for Mesajs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMesajs
		{
			get { return _alreadyFetchedMesajs;}
			set 
			{
				if(_alreadyFetchedMesajs && !value && (_mesajs != null))
				{
					_mesajs.Clear();
				}
				_alreadyFetchedMesajs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ParametreEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParametres()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.ParametreCollection Parametres
		{
			get	{ return GetMultiParametres(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Parametres. When set to true, Parametres is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Parametres is accessed. You can always execute/ a forced fetch by calling GetMultiParametres(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParametres
		{
			get	{ return _alwaysFetchParametres; }
			set	{ _alwaysFetchParametres = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Parametres already has been fetched. Setting this property to false when Parametres has been fetched
		/// will clear the Parametres collection well. Setting this property to true while Parametres hasn't been fetched disables lazy loading for Parametres</summary>
		[Browsable(false)]
		public bool AlreadyFetchedParametres
		{
			get { return _alreadyFetchedParametres;}
			set 
			{
				if(_alreadyFetchedParametres && !value && (_parametres != null))
				{
					_parametres.Clear();
				}
				_alreadyFetchedParametres = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ParametreGenelArsivEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiParametreGenelArsivs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.ParametreGenelArsivCollection ParametreGenelArsivs
		{
			get	{ return GetMultiParametreGenelArsivs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ParametreGenelArsivs. When set to true, ParametreGenelArsivs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ParametreGenelArsivs is accessed. You can always execute/ a forced fetch by calling GetMultiParametreGenelArsivs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParametreGenelArsivs
		{
			get	{ return _alwaysFetchParametreGenelArsivs; }
			set	{ _alwaysFetchParametreGenelArsivs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ParametreGenelArsivs already has been fetched. Setting this property to false when ParametreGenelArsivs has been fetched
		/// will clear the ParametreGenelArsivs collection well. Setting this property to true while ParametreGenelArsivs hasn't been fetched disables lazy loading for ParametreGenelArsivs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedParametreGenelArsivs
		{
			get { return _alreadyFetchedParametreGenelArsivs;}
			set 
			{
				if(_alreadyFetchedParametreGenelArsivs && !value && (_parametreGenelArsivs != null))
				{
					_parametreGenelArsivs.Clear();
				}
				_alreadyFetchedParametreGenelArsivs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'RaporYetkiEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRaporYetkis()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.RaporYetkiCollection RaporYetkis
		{
			get	{ return GetMultiRaporYetkis(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for RaporYetkis. When set to true, RaporYetkis is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time RaporYetkis is accessed. You can always execute/ a forced fetch by calling GetMultiRaporYetkis(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchRaporYetkis
		{
			get	{ return _alwaysFetchRaporYetkis; }
			set	{ _alwaysFetchRaporYetkis = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property RaporYetkis already has been fetched. Setting this property to false when RaporYetkis has been fetched
		/// will clear the RaporYetkis collection well. Setting this property to true while RaporYetkis hasn't been fetched disables lazy loading for RaporYetkis</summary>
		[Browsable(false)]
		public bool AlreadyFetchedRaporYetkis
		{
			get { return _alreadyFetchedRaporYetkis;}
			set 
			{
				if(_alreadyFetchedRaporYetkis && !value && (_raporYetkis != null))
				{
					_raporYetkis.Clear();
				}
				_alreadyFetchedRaporYetkis = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSoruns()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.SorunCollection Soruns
		{
			get	{ return GetMultiSoruns(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Soruns. When set to true, Soruns is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Soruns is accessed. You can always execute/ a forced fetch by calling GetMultiSoruns(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSoruns
		{
			get	{ return _alwaysFetchSoruns; }
			set	{ _alwaysFetchSoruns = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Soruns already has been fetched. Setting this property to false when Soruns has been fetched
		/// will clear the Soruns collection well. Setting this property to true while Soruns hasn't been fetched disables lazy loading for Soruns</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSoruns
		{
			get { return _alreadyFetchedSoruns;}
			set 
			{
				if(_alreadyFetchedSoruns && !value && (_soruns != null))
				{
					_soruns.Clear();
				}
				_alreadyFetchedSoruns = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VatandaEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVatandas()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.VatandaCollection Vatandas
		{
			get	{ return GetMultiVatandas(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Vatandas. When set to true, Vatandas is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vatandas is accessed. You can always execute/ a forced fetch by calling GetMultiVatandas(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVatandas
		{
			get	{ return _alwaysFetchVatandas; }
			set	{ _alwaysFetchVatandas = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Vatandas already has been fetched. Setting this property to false when Vatandas has been fetched
		/// will clear the Vatandas collection well. Setting this property to true while Vatandas hasn't been fetched disables lazy loading for Vatandas</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVatandas
		{
			get { return _alreadyFetchedVatandas;}
			set 
			{
				if(_alreadyFetchedVatandas && !value && (_vatandas != null))
				{
					_vatandas.Clear();
				}
				_alreadyFetchedVatandas = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'GorevEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleGorev()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual GorevEntity Gorev
		{
			get	{ return GetSingleGorev(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncGorev(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Kullanicis", "Gorev", _gorev, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Gorev. When set to true, Gorev is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Gorev is accessed. You can always execute a forced fetch by calling GetSingleGorev(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchGorev
		{
			get	{ return _alwaysFetchGorev; }
			set	{ _alwaysFetchGorev = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Gorev already has been fetched. Setting this property to false when Gorev has been fetched
		/// will set Gorev to null as well. Setting this property to true while Gorev hasn't been fetched disables lazy loading for Gorev</summary>
		[Browsable(false)]
		public bool AlreadyFetchedGorev
		{
			get { return _alreadyFetchedGorev;}
			set 
			{
				if(_alreadyFetchedGorev && !value)
				{
					this.Gorev = null;
				}
				_alreadyFetchedGorev = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Gorev is not found
		/// in the database. When set to true, Gorev will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool GorevReturnsNewIfNotFound
		{
			get	{ return _gorevReturnsNewIfNotFound; }
			set { _gorevReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'HiyerarsiTurEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleHiyerarsiTur()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual HiyerarsiTurEntity HiyerarsiTur
		{
			get	{ return GetSingleHiyerarsiTur(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncHiyerarsiTur(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Kullanicis", "HiyerarsiTur", _hiyerarsiTur, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for HiyerarsiTur. When set to true, HiyerarsiTur is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time HiyerarsiTur is accessed. You can always execute a forced fetch by calling GetSingleHiyerarsiTur(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchHiyerarsiTur
		{
			get	{ return _alwaysFetchHiyerarsiTur; }
			set	{ _alwaysFetchHiyerarsiTur = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property HiyerarsiTur already has been fetched. Setting this property to false when HiyerarsiTur has been fetched
		/// will set HiyerarsiTur to null as well. Setting this property to true while HiyerarsiTur hasn't been fetched disables lazy loading for HiyerarsiTur</summary>
		[Browsable(false)]
		public bool AlreadyFetchedHiyerarsiTur
		{
			get { return _alreadyFetchedHiyerarsiTur;}
			set 
			{
				if(_alreadyFetchedHiyerarsiTur && !value)
				{
					this.HiyerarsiTur = null;
				}
				_alreadyFetchedHiyerarsiTur = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property HiyerarsiTur is not found
		/// in the database. When set to true, HiyerarsiTur will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool HiyerarsiTurReturnsNewIfNotFound
		{
			get	{ return _hiyerarsiTurReturnsNewIfNotFound; }
			set { _hiyerarsiTurReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'YetkiEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleYetki()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual YetkiEntity Yetki
		{
			get	{ return GetSingleYetki(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncYetki(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Kullanicis", "Yetki", _yetki, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Yetki. When set to true, Yetki is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Yetki is accessed. You can always execute a forced fetch by calling GetSingleYetki(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchYetki
		{
			get	{ return _alwaysFetchYetki; }
			set	{ _alwaysFetchYetki = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Yetki already has been fetched. Setting this property to false when Yetki has been fetched
		/// will set Yetki to null as well. Setting this property to true while Yetki hasn't been fetched disables lazy loading for Yetki</summary>
		[Browsable(false)]
		public bool AlreadyFetchedYetki
		{
			get { return _alreadyFetchedYetki;}
			set 
			{
				if(_alreadyFetchedYetki && !value)
				{
					this.Yetki = null;
				}
				_alreadyFetchedYetki = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Yetki is not found
		/// in the database. When set to true, Yetki will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool YetkiReturnsNewIfNotFound
		{
			get	{ return _yetkiReturnsNewIfNotFound; }
			set { _yetkiReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the dhmi.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)dhmi.EntityType.KullaniciEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
