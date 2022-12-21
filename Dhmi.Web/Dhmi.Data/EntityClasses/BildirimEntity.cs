///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:36
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

	/// <summary>Entity class which represents the entity 'Bildirim'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BildirimEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimAtamaGrupCollection	_bildirimAtamaGrups;
		private bool	_alwaysFetchBildirimAtamaGrups, _alreadyFetchedBildirimAtamaGrups;
		private dhmi.CollectionClasses.BildirimAtamaKullaniciCollection	_bildirimAtamaKullanicis;
		private bool	_alwaysFetchBildirimAtamaKullanicis, _alreadyFetchedBildirimAtamaKullanicis;
		private dhmi.CollectionClasses.BildirimHistoryCollection	_bildirimHistories;
		private bool	_alwaysFetchBildirimHistories, _alreadyFetchedBildirimHistories;
		private dhmi.CollectionClasses.EkSureCollection	_ekSures;
		private bool	_alwaysFetchEkSures, _alreadyFetchedEkSures;
		private dhmi.CollectionClasses.GecenSureCollection	_gecenSures;
		private bool	_alwaysFetchGecenSures, _alreadyFetchedGecenSures;
		private dhmi.CollectionClasses.SureTakipCollection	_sureTakips;
		private bool	_alwaysFetchSureTakips, _alreadyFetchedSureTakips;
		private AltKonuEntity _altKonu;
		private bool	_alwaysFetchAltKonu, _alreadyFetchedAltKonu, _altKonuReturnsNewIfNotFound;
		private BildirimGeriDonuEntity _bildirimGeriDonu;
		private bool	_alwaysFetchBildirimGeriDonu, _alreadyFetchedBildirimGeriDonu, _bildirimGeriDonuReturnsNewIfNotFound;
		private BildirimSonucEntity _bildirimSonuc;
		private bool	_alwaysFetchBildirimSonuc, _alreadyFetchedBildirimSonuc, _bildirimSonucReturnsNewIfNotFound;
		private BildirimTuruEntity _bildirimTuru;
		private bool	_alwaysFetchBildirimTuru, _alreadyFetchedBildirimTuru, _bildirimTuruReturnsNewIfNotFound;
		private CagriTipiEntity _cagriTipi;
		private bool	_alwaysFetchCagriTipi, _alreadyFetchedCagriTipi, _cagriTipiReturnsNewIfNotFound;
		private KullaniciEntity _kullanici;
		private bool	_alwaysFetchKullanici, _alreadyFetchedKullanici, _kullaniciReturnsNewIfNotFound;
		private VatandaEntity _vatanda;
		private bool	_alwaysFetchVatanda, _alreadyFetchedVatanda, _vatandaReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AltKonu</summary>
			public static readonly string AltKonu = "AltKonu";
			/// <summary>Member name BildirimGeriDonu</summary>
			public static readonly string BildirimGeriDonu = "BildirimGeriDonu";
			/// <summary>Member name BildirimSonuc</summary>
			public static readonly string BildirimSonuc = "BildirimSonuc";
			/// <summary>Member name BildirimTuru</summary>
			public static readonly string BildirimTuru = "BildirimTuru";
			/// <summary>Member name CagriTipi</summary>
			public static readonly string CagriTipi = "CagriTipi";
			/// <summary>Member name Kullanici</summary>
			public static readonly string Kullanici = "Kullanici";
			/// <summary>Member name Vatanda</summary>
			public static readonly string Vatanda = "Vatanda";
			/// <summary>Member name BildirimAtamaGrups</summary>
			public static readonly string BildirimAtamaGrups = "BildirimAtamaGrups";
			/// <summary>Member name BildirimAtamaKullanicis</summary>
			public static readonly string BildirimAtamaKullanicis = "BildirimAtamaKullanicis";
			/// <summary>Member name BildirimHistories</summary>
			public static readonly string BildirimHistories = "BildirimHistories";
			/// <summary>Member name EkSures</summary>
			public static readonly string EkSures = "EkSures";
			/// <summary>Member name GecenSures</summary>
			public static readonly string GecenSures = "GecenSures";
			/// <summary>Member name SureTakips</summary>
			public static readonly string SureTakips = "SureTakips";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BildirimEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BildirimEntity() :base("BildirimEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		public BildirimEntity(System.Int64 bildirimId):base("BildirimEntity")
		{
			InitClassFetch(bildirimId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BildirimEntity(System.Int64 bildirimId, IPrefetchPath prefetchPathToUse):base("BildirimEntity")
		{
			InitClassFetch(bildirimId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="validator">The custom validator object for this BildirimEntity</param>
		public BildirimEntity(System.Int64 bildirimId, IValidator validator):base("BildirimEntity")
		{
			InitClassFetch(bildirimId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BildirimEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirimAtamaGrups = (dhmi.CollectionClasses.BildirimAtamaGrupCollection)info.GetValue("_bildirimAtamaGrups", typeof(dhmi.CollectionClasses.BildirimAtamaGrupCollection));
			_alwaysFetchBildirimAtamaGrups = info.GetBoolean("_alwaysFetchBildirimAtamaGrups");
			_alreadyFetchedBildirimAtamaGrups = info.GetBoolean("_alreadyFetchedBildirimAtamaGrups");

			_bildirimAtamaKullanicis = (dhmi.CollectionClasses.BildirimAtamaKullaniciCollection)info.GetValue("_bildirimAtamaKullanicis", typeof(dhmi.CollectionClasses.BildirimAtamaKullaniciCollection));
			_alwaysFetchBildirimAtamaKullanicis = info.GetBoolean("_alwaysFetchBildirimAtamaKullanicis");
			_alreadyFetchedBildirimAtamaKullanicis = info.GetBoolean("_alreadyFetchedBildirimAtamaKullanicis");

			_bildirimHistories = (dhmi.CollectionClasses.BildirimHistoryCollection)info.GetValue("_bildirimHistories", typeof(dhmi.CollectionClasses.BildirimHistoryCollection));
			_alwaysFetchBildirimHistories = info.GetBoolean("_alwaysFetchBildirimHistories");
			_alreadyFetchedBildirimHistories = info.GetBoolean("_alreadyFetchedBildirimHistories");

			_ekSures = (dhmi.CollectionClasses.EkSureCollection)info.GetValue("_ekSures", typeof(dhmi.CollectionClasses.EkSureCollection));
			_alwaysFetchEkSures = info.GetBoolean("_alwaysFetchEkSures");
			_alreadyFetchedEkSures = info.GetBoolean("_alreadyFetchedEkSures");

			_gecenSures = (dhmi.CollectionClasses.GecenSureCollection)info.GetValue("_gecenSures", typeof(dhmi.CollectionClasses.GecenSureCollection));
			_alwaysFetchGecenSures = info.GetBoolean("_alwaysFetchGecenSures");
			_alreadyFetchedGecenSures = info.GetBoolean("_alreadyFetchedGecenSures");

			_sureTakips = (dhmi.CollectionClasses.SureTakipCollection)info.GetValue("_sureTakips", typeof(dhmi.CollectionClasses.SureTakipCollection));
			_alwaysFetchSureTakips = info.GetBoolean("_alwaysFetchSureTakips");
			_alreadyFetchedSureTakips = info.GetBoolean("_alreadyFetchedSureTakips");
			_altKonu = (AltKonuEntity)info.GetValue("_altKonu", typeof(AltKonuEntity));
			if(_altKonu!=null)
			{
				_altKonu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_altKonuReturnsNewIfNotFound = info.GetBoolean("_altKonuReturnsNewIfNotFound");
			_alwaysFetchAltKonu = info.GetBoolean("_alwaysFetchAltKonu");
			_alreadyFetchedAltKonu = info.GetBoolean("_alreadyFetchedAltKonu");

			_bildirimGeriDonu = (BildirimGeriDonuEntity)info.GetValue("_bildirimGeriDonu", typeof(BildirimGeriDonuEntity));
			if(_bildirimGeriDonu!=null)
			{
				_bildirimGeriDonu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_bildirimGeriDonuReturnsNewIfNotFound = info.GetBoolean("_bildirimGeriDonuReturnsNewIfNotFound");
			_alwaysFetchBildirimGeriDonu = info.GetBoolean("_alwaysFetchBildirimGeriDonu");
			_alreadyFetchedBildirimGeriDonu = info.GetBoolean("_alreadyFetchedBildirimGeriDonu");

			_bildirimSonuc = (BildirimSonucEntity)info.GetValue("_bildirimSonuc", typeof(BildirimSonucEntity));
			if(_bildirimSonuc!=null)
			{
				_bildirimSonuc.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_bildirimSonucReturnsNewIfNotFound = info.GetBoolean("_bildirimSonucReturnsNewIfNotFound");
			_alwaysFetchBildirimSonuc = info.GetBoolean("_alwaysFetchBildirimSonuc");
			_alreadyFetchedBildirimSonuc = info.GetBoolean("_alreadyFetchedBildirimSonuc");

			_bildirimTuru = (BildirimTuruEntity)info.GetValue("_bildirimTuru", typeof(BildirimTuruEntity));
			if(_bildirimTuru!=null)
			{
				_bildirimTuru.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_bildirimTuruReturnsNewIfNotFound = info.GetBoolean("_bildirimTuruReturnsNewIfNotFound");
			_alwaysFetchBildirimTuru = info.GetBoolean("_alwaysFetchBildirimTuru");
			_alreadyFetchedBildirimTuru = info.GetBoolean("_alreadyFetchedBildirimTuru");

			_cagriTipi = (CagriTipiEntity)info.GetValue("_cagriTipi", typeof(CagriTipiEntity));
			if(_cagriTipi!=null)
			{
				_cagriTipi.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_cagriTipiReturnsNewIfNotFound = info.GetBoolean("_cagriTipiReturnsNewIfNotFound");
			_alwaysFetchCagriTipi = info.GetBoolean("_alwaysFetchCagriTipi");
			_alreadyFetchedCagriTipi = info.GetBoolean("_alreadyFetchedCagriTipi");

			_kullanici = (KullaniciEntity)info.GetValue("_kullanici", typeof(KullaniciEntity));
			if(_kullanici!=null)
			{
				_kullanici.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_kullaniciReturnsNewIfNotFound = info.GetBoolean("_kullaniciReturnsNewIfNotFound");
			_alwaysFetchKullanici = info.GetBoolean("_alwaysFetchKullanici");
			_alreadyFetchedKullanici = info.GetBoolean("_alreadyFetchedKullanici");

			_vatanda = (VatandaEntity)info.GetValue("_vatanda", typeof(VatandaEntity));
			if(_vatanda!=null)
			{
				_vatanda.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_vatandaReturnsNewIfNotFound = info.GetBoolean("_vatandaReturnsNewIfNotFound");
			_alwaysFetchVatanda = info.GetBoolean("_alwaysFetchVatanda");
			_alreadyFetchedVatanda = info.GetBoolean("_alreadyFetchedVatanda");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((BildirimFieldIndex)fieldIndex)
			{
				case BildirimFieldIndex.FkAltKonuId:
					DesetupSyncAltKonu(true, false);
					_alreadyFetchedAltKonu = false;
					break;
				case BildirimFieldIndex.FkBildirimGeriDonusId:
					DesetupSyncBildirimGeriDonu(true, false);
					_alreadyFetchedBildirimGeriDonu = false;
					break;
				case BildirimFieldIndex.FkBildirimSonucId:
					DesetupSyncBildirimSonuc(true, false);
					_alreadyFetchedBildirimSonuc = false;
					break;
				case BildirimFieldIndex.FkBildirimTuruId:
					DesetupSyncBildirimTuru(true, false);
					_alreadyFetchedBildirimTuru = false;
					break;
				case BildirimFieldIndex.FkCagriTipiId:
					DesetupSyncCagriTipi(true, false);
					_alreadyFetchedCagriTipi = false;
					break;
				case BildirimFieldIndex.FkKullaniciId:
					DesetupSyncKullanici(true, false);
					_alreadyFetchedKullanici = false;
					break;
				case BildirimFieldIndex.FkVatandasId:
					DesetupSyncVatanda(true, false);
					_alreadyFetchedVatanda = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedBildirimAtamaGrups = (_bildirimAtamaGrups.Count > 0);
			_alreadyFetchedBildirimAtamaKullanicis = (_bildirimAtamaKullanicis.Count > 0);
			_alreadyFetchedBildirimHistories = (_bildirimHistories.Count > 0);
			_alreadyFetchedEkSures = (_ekSures.Count > 0);
			_alreadyFetchedGecenSures = (_gecenSures.Count > 0);
			_alreadyFetchedSureTakips = (_sureTakips.Count > 0);
			_alreadyFetchedAltKonu = (_altKonu != null);
			_alreadyFetchedBildirimGeriDonu = (_bildirimGeriDonu != null);
			_alreadyFetchedBildirimSonuc = (_bildirimSonuc != null);
			_alreadyFetchedBildirimTuru = (_bildirimTuru != null);
			_alreadyFetchedCagriTipi = (_cagriTipi != null);
			_alreadyFetchedKullanici = (_kullanici != null);
			_alreadyFetchedVatanda = (_vatanda != null);
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
				case "AltKonu":
					toReturn.Add(Relations.AltKonuEntityUsingFkAltKonuId);
					break;
				case "BildirimGeriDonu":
					toReturn.Add(Relations.BildirimGeriDonuEntityUsingFkBildirimGeriDonusId);
					break;
				case "BildirimSonuc":
					toReturn.Add(Relations.BildirimSonucEntityUsingFkBildirimSonucId);
					break;
				case "BildirimTuru":
					toReturn.Add(Relations.BildirimTuruEntityUsingFkBildirimTuruId);
					break;
				case "CagriTipi":
					toReturn.Add(Relations.CagriTipiEntityUsingFkCagriTipiId);
					break;
				case "Kullanici":
					toReturn.Add(Relations.KullaniciEntityUsingFkKullaniciId);
					break;
				case "Vatanda":
					toReturn.Add(Relations.VatandaEntityUsingFkVatandasId);
					break;
				case "BildirimAtamaGrups":
					toReturn.Add(Relations.BildirimAtamaGrupEntityUsingFkBildirimId);
					break;
				case "BildirimAtamaKullanicis":
					toReturn.Add(Relations.BildirimAtamaKullaniciEntityUsingFkBildirimId);
					break;
				case "BildirimHistories":
					toReturn.Add(Relations.BildirimHistoryEntityUsingFkBildirimId);
					break;
				case "EkSures":
					toReturn.Add(Relations.EkSureEntityUsingFkBildirimId);
					break;
				case "GecenSures":
					toReturn.Add(Relations.GecenSureEntityUsingFkBildirimId);
					break;
				case "SureTakips":
					toReturn.Add(Relations.SureTakipEntityUsingFkBildirimId);
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
			info.AddValue("_bildirimAtamaGrups", (!this.MarkedForDeletion?_bildirimAtamaGrups:null));
			info.AddValue("_alwaysFetchBildirimAtamaGrups", _alwaysFetchBildirimAtamaGrups);
			info.AddValue("_alreadyFetchedBildirimAtamaGrups", _alreadyFetchedBildirimAtamaGrups);
			info.AddValue("_bildirimAtamaKullanicis", (!this.MarkedForDeletion?_bildirimAtamaKullanicis:null));
			info.AddValue("_alwaysFetchBildirimAtamaKullanicis", _alwaysFetchBildirimAtamaKullanicis);
			info.AddValue("_alreadyFetchedBildirimAtamaKullanicis", _alreadyFetchedBildirimAtamaKullanicis);
			info.AddValue("_bildirimHistories", (!this.MarkedForDeletion?_bildirimHistories:null));
			info.AddValue("_alwaysFetchBildirimHistories", _alwaysFetchBildirimHistories);
			info.AddValue("_alreadyFetchedBildirimHistories", _alreadyFetchedBildirimHistories);
			info.AddValue("_ekSures", (!this.MarkedForDeletion?_ekSures:null));
			info.AddValue("_alwaysFetchEkSures", _alwaysFetchEkSures);
			info.AddValue("_alreadyFetchedEkSures", _alreadyFetchedEkSures);
			info.AddValue("_gecenSures", (!this.MarkedForDeletion?_gecenSures:null));
			info.AddValue("_alwaysFetchGecenSures", _alwaysFetchGecenSures);
			info.AddValue("_alreadyFetchedGecenSures", _alreadyFetchedGecenSures);
			info.AddValue("_sureTakips", (!this.MarkedForDeletion?_sureTakips:null));
			info.AddValue("_alwaysFetchSureTakips", _alwaysFetchSureTakips);
			info.AddValue("_alreadyFetchedSureTakips", _alreadyFetchedSureTakips);
			info.AddValue("_altKonu", (!this.MarkedForDeletion?_altKonu:null));
			info.AddValue("_altKonuReturnsNewIfNotFound", _altKonuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAltKonu", _alwaysFetchAltKonu);
			info.AddValue("_alreadyFetchedAltKonu", _alreadyFetchedAltKonu);
			info.AddValue("_bildirimGeriDonu", (!this.MarkedForDeletion?_bildirimGeriDonu:null));
			info.AddValue("_bildirimGeriDonuReturnsNewIfNotFound", _bildirimGeriDonuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBildirimGeriDonu", _alwaysFetchBildirimGeriDonu);
			info.AddValue("_alreadyFetchedBildirimGeriDonu", _alreadyFetchedBildirimGeriDonu);
			info.AddValue("_bildirimSonuc", (!this.MarkedForDeletion?_bildirimSonuc:null));
			info.AddValue("_bildirimSonucReturnsNewIfNotFound", _bildirimSonucReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBildirimSonuc", _alwaysFetchBildirimSonuc);
			info.AddValue("_alreadyFetchedBildirimSonuc", _alreadyFetchedBildirimSonuc);
			info.AddValue("_bildirimTuru", (!this.MarkedForDeletion?_bildirimTuru:null));
			info.AddValue("_bildirimTuruReturnsNewIfNotFound", _bildirimTuruReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBildirimTuru", _alwaysFetchBildirimTuru);
			info.AddValue("_alreadyFetchedBildirimTuru", _alreadyFetchedBildirimTuru);
			info.AddValue("_cagriTipi", (!this.MarkedForDeletion?_cagriTipi:null));
			info.AddValue("_cagriTipiReturnsNewIfNotFound", _cagriTipiReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchCagriTipi", _alwaysFetchCagriTipi);
			info.AddValue("_alreadyFetchedCagriTipi", _alreadyFetchedCagriTipi);
			info.AddValue("_kullanici", (!this.MarkedForDeletion?_kullanici:null));
			info.AddValue("_kullaniciReturnsNewIfNotFound", _kullaniciReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchKullanici", _alwaysFetchKullanici);
			info.AddValue("_alreadyFetchedKullanici", _alreadyFetchedKullanici);
			info.AddValue("_vatanda", (!this.MarkedForDeletion?_vatanda:null));
			info.AddValue("_vatandaReturnsNewIfNotFound", _vatandaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchVatanda", _alwaysFetchVatanda);
			info.AddValue("_alreadyFetchedVatanda", _alreadyFetchedVatanda);

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
				case "AltKonu":
					_alreadyFetchedAltKonu = true;
					this.AltKonu = (AltKonuEntity)entity;
					break;
				case "BildirimGeriDonu":
					_alreadyFetchedBildirimGeriDonu = true;
					this.BildirimGeriDonu = (BildirimGeriDonuEntity)entity;
					break;
				case "BildirimSonuc":
					_alreadyFetchedBildirimSonuc = true;
					this.BildirimSonuc = (BildirimSonucEntity)entity;
					break;
				case "BildirimTuru":
					_alreadyFetchedBildirimTuru = true;
					this.BildirimTuru = (BildirimTuruEntity)entity;
					break;
				case "CagriTipi":
					_alreadyFetchedCagriTipi = true;
					this.CagriTipi = (CagriTipiEntity)entity;
					break;
				case "Kullanici":
					_alreadyFetchedKullanici = true;
					this.Kullanici = (KullaniciEntity)entity;
					break;
				case "Vatanda":
					_alreadyFetchedVatanda = true;
					this.Vatanda = (VatandaEntity)entity;
					break;
				case "BildirimAtamaGrups":
					_alreadyFetchedBildirimAtamaGrups = true;
					if(entity!=null)
					{
						this.BildirimAtamaGrups.Add((BildirimAtamaGrupEntity)entity);
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
				case "SureTakips":
					_alreadyFetchedSureTakips = true;
					if(entity!=null)
					{
						this.SureTakips.Add((SureTakipEntity)entity);
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
				case "AltKonu":
					SetupSyncAltKonu(relatedEntity);
					break;
				case "BildirimGeriDonu":
					SetupSyncBildirimGeriDonu(relatedEntity);
					break;
				case "BildirimSonuc":
					SetupSyncBildirimSonuc(relatedEntity);
					break;
				case "BildirimTuru":
					SetupSyncBildirimTuru(relatedEntity);
					break;
				case "CagriTipi":
					SetupSyncCagriTipi(relatedEntity);
					break;
				case "Kullanici":
					SetupSyncKullanici(relatedEntity);
					break;
				case "Vatanda":
					SetupSyncVatanda(relatedEntity);
					break;
				case "BildirimAtamaGrups":
					_bildirimAtamaGrups.Add((BildirimAtamaGrupEntity)relatedEntity);
					break;
				case "BildirimAtamaKullanicis":
					_bildirimAtamaKullanicis.Add((BildirimAtamaKullaniciEntity)relatedEntity);
					break;
				case "BildirimHistories":
					_bildirimHistories.Add((BildirimHistoryEntity)relatedEntity);
					break;
				case "EkSures":
					_ekSures.Add((EkSureEntity)relatedEntity);
					break;
				case "GecenSures":
					_gecenSures.Add((GecenSureEntity)relatedEntity);
					break;
				case "SureTakips":
					_sureTakips.Add((SureTakipEntity)relatedEntity);
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
				case "AltKonu":
					DesetupSyncAltKonu(false, true);
					break;
				case "BildirimGeriDonu":
					DesetupSyncBildirimGeriDonu(false, true);
					break;
				case "BildirimSonuc":
					DesetupSyncBildirimSonuc(false, true);
					break;
				case "BildirimTuru":
					DesetupSyncBildirimTuru(false, true);
					break;
				case "CagriTipi":
					DesetupSyncCagriTipi(false, true);
					break;
				case "Kullanici":
					DesetupSyncKullanici(false, true);
					break;
				case "Vatanda":
					DesetupSyncVatanda(false, true);
					break;
				case "BildirimAtamaGrups":
					this.PerformRelatedEntityRemoval(_bildirimAtamaGrups, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BildirimAtamaKullanicis":
					this.PerformRelatedEntityRemoval(_bildirimAtamaKullanicis, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BildirimHistories":
					this.PerformRelatedEntityRemoval(_bildirimHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EkSures":
					this.PerformRelatedEntityRemoval(_ekSures, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "GecenSures":
					this.PerformRelatedEntityRemoval(_gecenSures, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SureTakips":
					this.PerformRelatedEntityRemoval(_sureTakips, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_altKonu!=null)
			{
				toReturn.Add(_altKonu);
			}
			if(_bildirimGeriDonu!=null)
			{
				toReturn.Add(_bildirimGeriDonu);
			}
			if(_bildirimSonuc!=null)
			{
				toReturn.Add(_bildirimSonuc);
			}
			if(_bildirimTuru!=null)
			{
				toReturn.Add(_bildirimTuru);
			}
			if(_cagriTipi!=null)
			{
				toReturn.Add(_cagriTipi);
			}
			if(_kullanici!=null)
			{
				toReturn.Add(_kullanici);
			}
			if(_vatanda!=null)
			{
				toReturn.Add(_vatanda);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_bildirimAtamaGrups);
			toReturn.Add(_bildirimAtamaKullanicis);
			toReturn.Add(_bildirimHistories);
			toReturn.Add(_ekSures);
			toReturn.Add(_gecenSures);
			toReturn.Add(_sureTakips);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimId)
		{
			return FetchUsingPK(bildirimId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(bildirimId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(bildirimId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(bildirimId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BildirimId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BildirimRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaGrupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BildirimAtamaGrupEntity'</returns>
		public dhmi.CollectionClasses.BildirimAtamaGrupCollection GetMultiBildirimAtamaGrups(bool forceFetch)
		{
			return GetMultiBildirimAtamaGrups(forceFetch, _bildirimAtamaGrups.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaGrupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BildirimAtamaGrupEntity'</returns>
		public dhmi.CollectionClasses.BildirimAtamaGrupCollection GetMultiBildirimAtamaGrups(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBildirimAtamaGrups(forceFetch, _bildirimAtamaGrups.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaGrupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.BildirimAtamaGrupCollection GetMultiBildirimAtamaGrups(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBildirimAtamaGrups(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaGrupEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.BildirimAtamaGrupCollection GetMultiBildirimAtamaGrups(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBildirimAtamaGrups || forceFetch || _alwaysFetchBildirimAtamaGrups) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_bildirimAtamaGrups);
				_bildirimAtamaGrups.SuppressClearInGetMulti=!forceFetch;
				_bildirimAtamaGrups.EntityFactoryToUse = entityFactoryToUse;
				_bildirimAtamaGrups.GetMultiManyToOne(this, null, filter);
				_bildirimAtamaGrups.SuppressClearInGetMulti=false;
				_alreadyFetchedBildirimAtamaGrups = true;
			}
			return _bildirimAtamaGrups;
		}

		/// <summary> Sets the collection parameters for the collection for 'BildirimAtamaGrups'. These settings will be taken into account
		/// when the property BildirimAtamaGrups is requested or GetMultiBildirimAtamaGrups is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBildirimAtamaGrups(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bildirimAtamaGrups.SortClauses=sortClauses;
			_bildirimAtamaGrups.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_bildirimAtamaKullanicis.GetMultiManyToOne(this, null, filter);
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
				_bildirimHistories.GetMultiManyToOne(this, null, null, filter);
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
				_ekSures.GetMultiManyToOne(this, null, filter);
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
				_gecenSures.GetMultiManyToOne(this, null, filter);
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

		/// <summary> Retrieves all related entities of type 'SureTakipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SureTakipEntity'</returns>
		public dhmi.CollectionClasses.SureTakipCollection GetMultiSureTakips(bool forceFetch)
		{
			return GetMultiSureTakips(forceFetch, _sureTakips.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SureTakipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SureTakipEntity'</returns>
		public dhmi.CollectionClasses.SureTakipCollection GetMultiSureTakips(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSureTakips(forceFetch, _sureTakips.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SureTakipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.SureTakipCollection GetMultiSureTakips(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSureTakips(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SureTakipEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.SureTakipCollection GetMultiSureTakips(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSureTakips || forceFetch || _alwaysFetchSureTakips) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_sureTakips);
				_sureTakips.SuppressClearInGetMulti=!forceFetch;
				_sureTakips.EntityFactoryToUse = entityFactoryToUse;
				_sureTakips.GetMultiManyToOne(this, filter);
				_sureTakips.SuppressClearInGetMulti=false;
				_alreadyFetchedSureTakips = true;
			}
			return _sureTakips;
		}

		/// <summary> Sets the collection parameters for the collection for 'SureTakips'. These settings will be taken into account
		/// when the property SureTakips is requested or GetMultiSureTakips is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSureTakips(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_sureTakips.SortClauses=sortClauses;
			_sureTakips.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AltKonuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AltKonuEntity' which is related to this entity.</returns>
		public AltKonuEntity GetSingleAltKonu()
		{
			return GetSingleAltKonu(false);
		}

		/// <summary> Retrieves the related entity of type 'AltKonuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AltKonuEntity' which is related to this entity.</returns>
		public virtual AltKonuEntity GetSingleAltKonu(bool forceFetch)
		{
			if( ( !_alreadyFetchedAltKonu || forceFetch || _alwaysFetchAltKonu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AltKonuEntityUsingFkAltKonuId);
				AltKonuEntity newEntity = new AltKonuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkAltKonuId);
				}
				if(fetchResult)
				{
					newEntity = (AltKonuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_altKonuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AltKonu = newEntity;
				_alreadyFetchedAltKonu = fetchResult;
			}
			return _altKonu;
		}


		/// <summary> Retrieves the related entity of type 'BildirimGeriDonuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BildirimGeriDonuEntity' which is related to this entity.</returns>
		public BildirimGeriDonuEntity GetSingleBildirimGeriDonu()
		{
			return GetSingleBildirimGeriDonu(false);
		}

		/// <summary> Retrieves the related entity of type 'BildirimGeriDonuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BildirimGeriDonuEntity' which is related to this entity.</returns>
		public virtual BildirimGeriDonuEntity GetSingleBildirimGeriDonu(bool forceFetch)
		{
			if( ( !_alreadyFetchedBildirimGeriDonu || forceFetch || _alwaysFetchBildirimGeriDonu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BildirimGeriDonuEntityUsingFkBildirimGeriDonusId);
				BildirimGeriDonuEntity newEntity = new BildirimGeriDonuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkBildirimGeriDonusId);
				}
				if(fetchResult)
				{
					newEntity = (BildirimGeriDonuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_bildirimGeriDonuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.BildirimGeriDonu = newEntity;
				_alreadyFetchedBildirimGeriDonu = fetchResult;
			}
			return _bildirimGeriDonu;
		}


		/// <summary> Retrieves the related entity of type 'BildirimSonucEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BildirimSonucEntity' which is related to this entity.</returns>
		public BildirimSonucEntity GetSingleBildirimSonuc()
		{
			return GetSingleBildirimSonuc(false);
		}

		/// <summary> Retrieves the related entity of type 'BildirimSonucEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BildirimSonucEntity' which is related to this entity.</returns>
		public virtual BildirimSonucEntity GetSingleBildirimSonuc(bool forceFetch)
		{
			if( ( !_alreadyFetchedBildirimSonuc || forceFetch || _alwaysFetchBildirimSonuc) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BildirimSonucEntityUsingFkBildirimSonucId);
				BildirimSonucEntity newEntity = new BildirimSonucEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkBildirimSonucId);
				}
				if(fetchResult)
				{
					newEntity = (BildirimSonucEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_bildirimSonucReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.BildirimSonuc = newEntity;
				_alreadyFetchedBildirimSonuc = fetchResult;
			}
			return _bildirimSonuc;
		}


		/// <summary> Retrieves the related entity of type 'BildirimTuruEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BildirimTuruEntity' which is related to this entity.</returns>
		public BildirimTuruEntity GetSingleBildirimTuru()
		{
			return GetSingleBildirimTuru(false);
		}

		/// <summary> Retrieves the related entity of type 'BildirimTuruEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BildirimTuruEntity' which is related to this entity.</returns>
		public virtual BildirimTuruEntity GetSingleBildirimTuru(bool forceFetch)
		{
			if( ( !_alreadyFetchedBildirimTuru || forceFetch || _alwaysFetchBildirimTuru) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BildirimTuruEntityUsingFkBildirimTuruId);
				BildirimTuruEntity newEntity = new BildirimTuruEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkBildirimTuruId);
				}
				if(fetchResult)
				{
					newEntity = (BildirimTuruEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_bildirimTuruReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.BildirimTuru = newEntity;
				_alreadyFetchedBildirimTuru = fetchResult;
			}
			return _bildirimTuru;
		}


		/// <summary> Retrieves the related entity of type 'CagriTipiEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'CagriTipiEntity' which is related to this entity.</returns>
		public CagriTipiEntity GetSingleCagriTipi()
		{
			return GetSingleCagriTipi(false);
		}

		/// <summary> Retrieves the related entity of type 'CagriTipiEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'CagriTipiEntity' which is related to this entity.</returns>
		public virtual CagriTipiEntity GetSingleCagriTipi(bool forceFetch)
		{
			if( ( !_alreadyFetchedCagriTipi || forceFetch || _alwaysFetchCagriTipi) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.CagriTipiEntityUsingFkCagriTipiId);
				CagriTipiEntity newEntity = new CagriTipiEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkCagriTipiId);
				}
				if(fetchResult)
				{
					newEntity = (CagriTipiEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_cagriTipiReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.CagriTipi = newEntity;
				_alreadyFetchedCagriTipi = fetchResult;
			}
			return _cagriTipi;
		}


		/// <summary> Retrieves the related entity of type 'KullaniciEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'KullaniciEntity' which is related to this entity.</returns>
		public KullaniciEntity GetSingleKullanici()
		{
			return GetSingleKullanici(false);
		}

		/// <summary> Retrieves the related entity of type 'KullaniciEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'KullaniciEntity' which is related to this entity.</returns>
		public virtual KullaniciEntity GetSingleKullanici(bool forceFetch)
		{
			if( ( !_alreadyFetchedKullanici || forceFetch || _alwaysFetchKullanici) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.KullaniciEntityUsingFkKullaniciId);
				KullaniciEntity newEntity = new KullaniciEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkKullaniciId);
				}
				if(fetchResult)
				{
					newEntity = (KullaniciEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_kullaniciReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Kullanici = newEntity;
				_alreadyFetchedKullanici = fetchResult;
			}
			return _kullanici;
		}


		/// <summary> Retrieves the related entity of type 'VatandaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'VatandaEntity' which is related to this entity.</returns>
		public VatandaEntity GetSingleVatanda()
		{
			return GetSingleVatanda(false);
		}

		/// <summary> Retrieves the related entity of type 'VatandaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'VatandaEntity' which is related to this entity.</returns>
		public virtual VatandaEntity GetSingleVatanda(bool forceFetch)
		{
			if( ( !_alreadyFetchedVatanda || forceFetch || _alwaysFetchVatanda) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.VatandaEntityUsingFkVatandasId);
				VatandaEntity newEntity = new VatandaEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkVatandasId);
				}
				if(fetchResult)
				{
					newEntity = (VatandaEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_vatandaReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Vatanda = newEntity;
				_alreadyFetchedVatanda = fetchResult;
			}
			return _vatanda;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AltKonu", _altKonu);
			toReturn.Add("BildirimGeriDonu", _bildirimGeriDonu);
			toReturn.Add("BildirimSonuc", _bildirimSonuc);
			toReturn.Add("BildirimTuru", _bildirimTuru);
			toReturn.Add("CagriTipi", _cagriTipi);
			toReturn.Add("Kullanici", _kullanici);
			toReturn.Add("Vatanda", _vatanda);
			toReturn.Add("BildirimAtamaGrups", _bildirimAtamaGrups);
			toReturn.Add("BildirimAtamaKullanicis", _bildirimAtamaKullanicis);
			toReturn.Add("BildirimHistories", _bildirimHistories);
			toReturn.Add("EkSures", _ekSures);
			toReturn.Add("GecenSures", _gecenSures);
			toReturn.Add("SureTakips", _sureTakips);
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
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="validator">The validator object for this BildirimEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 bildirimId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(bildirimId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirimAtamaGrups = new dhmi.CollectionClasses.BildirimAtamaGrupCollection();
			_bildirimAtamaGrups.SetContainingEntityInfo(this, "Bildirim");

			_bildirimAtamaKullanicis = new dhmi.CollectionClasses.BildirimAtamaKullaniciCollection();
			_bildirimAtamaKullanicis.SetContainingEntityInfo(this, "Bildirim");

			_bildirimHistories = new dhmi.CollectionClasses.BildirimHistoryCollection();
			_bildirimHistories.SetContainingEntityInfo(this, "Bildirim");

			_ekSures = new dhmi.CollectionClasses.EkSureCollection();
			_ekSures.SetContainingEntityInfo(this, "Bildirim");

			_gecenSures = new dhmi.CollectionClasses.GecenSureCollection();
			_gecenSures.SetContainingEntityInfo(this, "Bildirim");

			_sureTakips = new dhmi.CollectionClasses.SureTakipCollection();
			_sureTakips.SetContainingEntityInfo(this, "Bildirim");
			_altKonuReturnsNewIfNotFound = false;
			_bildirimGeriDonuReturnsNewIfNotFound = false;
			_bildirimSonucReturnsNewIfNotFound = false;
			_bildirimTuruReturnsNewIfNotFound = false;
			_cagriTipiReturnsNewIfNotFound = false;
			_kullaniciReturnsNewIfNotFound = false;
			_vatandaReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("BildirimAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimAtanmaDurumu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimDavaAdSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimDavaDosyaNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimDavaKonu", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimDavaMahkeme", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimGelenYer", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimGeriYapildiMi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimHavalimani", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimKimBitirdi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimKonuDiger", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimMetin", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimSonIslemTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimToplamSure", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimVatandasKarar", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimYil", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimYonlendirilenKurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkAltKonuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkBildirimGeriDonusId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkBildirimSonucId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkBildirimTuruId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkCagriTipiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkVatandasId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _altKonu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAltKonu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _altKonu, new PropertyChangedEventHandler( OnAltKonuPropertyChanged ), "AltKonu", dhmi.RelationClasses.StaticBildirimRelations.AltKonuEntityUsingFkAltKonuIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkAltKonuId } );		
			_altKonu = null;
		}
		
		/// <summary> setups the sync logic for member _altKonu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAltKonu(IEntityCore relatedEntity)
		{
			if(_altKonu!=relatedEntity)
			{		
				DesetupSyncAltKonu(true, true);
				_altKonu = (AltKonuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _altKonu, new PropertyChangedEventHandler( OnAltKonuPropertyChanged ), "AltKonu", dhmi.RelationClasses.StaticBildirimRelations.AltKonuEntityUsingFkAltKonuIdStatic, true, ref _alreadyFetchedAltKonu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAltKonuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _bildirimGeriDonu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBildirimGeriDonu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _bildirimGeriDonu, new PropertyChangedEventHandler( OnBildirimGeriDonuPropertyChanged ), "BildirimGeriDonu", dhmi.RelationClasses.StaticBildirimRelations.BildirimGeriDonuEntityUsingFkBildirimGeriDonusIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkBildirimGeriDonusId } );		
			_bildirimGeriDonu = null;
		}
		
		/// <summary> setups the sync logic for member _bildirimGeriDonu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBildirimGeriDonu(IEntityCore relatedEntity)
		{
			if(_bildirimGeriDonu!=relatedEntity)
			{		
				DesetupSyncBildirimGeriDonu(true, true);
				_bildirimGeriDonu = (BildirimGeriDonuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _bildirimGeriDonu, new PropertyChangedEventHandler( OnBildirimGeriDonuPropertyChanged ), "BildirimGeriDonu", dhmi.RelationClasses.StaticBildirimRelations.BildirimGeriDonuEntityUsingFkBildirimGeriDonusIdStatic, true, ref _alreadyFetchedBildirimGeriDonu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBildirimGeriDonuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _bildirimSonuc</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBildirimSonuc(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _bildirimSonuc, new PropertyChangedEventHandler( OnBildirimSonucPropertyChanged ), "BildirimSonuc", dhmi.RelationClasses.StaticBildirimRelations.BildirimSonucEntityUsingFkBildirimSonucIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkBildirimSonucId } );		
			_bildirimSonuc = null;
		}
		
		/// <summary> setups the sync logic for member _bildirimSonuc</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBildirimSonuc(IEntityCore relatedEntity)
		{
			if(_bildirimSonuc!=relatedEntity)
			{		
				DesetupSyncBildirimSonuc(true, true);
				_bildirimSonuc = (BildirimSonucEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _bildirimSonuc, new PropertyChangedEventHandler( OnBildirimSonucPropertyChanged ), "BildirimSonuc", dhmi.RelationClasses.StaticBildirimRelations.BildirimSonucEntityUsingFkBildirimSonucIdStatic, true, ref _alreadyFetchedBildirimSonuc, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBildirimSonucPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _bildirimTuru</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBildirimTuru(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _bildirimTuru, new PropertyChangedEventHandler( OnBildirimTuruPropertyChanged ), "BildirimTuru", dhmi.RelationClasses.StaticBildirimRelations.BildirimTuruEntityUsingFkBildirimTuruIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkBildirimTuruId } );		
			_bildirimTuru = null;
		}
		
		/// <summary> setups the sync logic for member _bildirimTuru</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBildirimTuru(IEntityCore relatedEntity)
		{
			if(_bildirimTuru!=relatedEntity)
			{		
				DesetupSyncBildirimTuru(true, true);
				_bildirimTuru = (BildirimTuruEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _bildirimTuru, new PropertyChangedEventHandler( OnBildirimTuruPropertyChanged ), "BildirimTuru", dhmi.RelationClasses.StaticBildirimRelations.BildirimTuruEntityUsingFkBildirimTuruIdStatic, true, ref _alreadyFetchedBildirimTuru, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBildirimTuruPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _cagriTipi</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCagriTipi(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _cagriTipi, new PropertyChangedEventHandler( OnCagriTipiPropertyChanged ), "CagriTipi", dhmi.RelationClasses.StaticBildirimRelations.CagriTipiEntityUsingFkCagriTipiIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkCagriTipiId } );		
			_cagriTipi = null;
		}
		
		/// <summary> setups the sync logic for member _cagriTipi</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCagriTipi(IEntityCore relatedEntity)
		{
			if(_cagriTipi!=relatedEntity)
			{		
				DesetupSyncCagriTipi(true, true);
				_cagriTipi = (CagriTipiEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _cagriTipi, new PropertyChangedEventHandler( OnCagriTipiPropertyChanged ), "CagriTipi", dhmi.RelationClasses.StaticBildirimRelations.CagriTipiEntityUsingFkCagriTipiIdStatic, true, ref _alreadyFetchedCagriTipi, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCagriTipiPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _kullanici</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncKullanici(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticBildirimRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkKullaniciId } );		
			_kullanici = null;
		}
		
		/// <summary> setups the sync logic for member _kullanici</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncKullanici(IEntityCore relatedEntity)
		{
			if(_kullanici!=relatedEntity)
			{		
				DesetupSyncKullanici(true, true);
				_kullanici = (KullaniciEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticBildirimRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, ref _alreadyFetchedKullanici, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnKullaniciPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vatanda</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVatanda(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vatanda, new PropertyChangedEventHandler( OnVatandaPropertyChanged ), "Vatanda", dhmi.RelationClasses.StaticBildirimRelations.VatandaEntityUsingFkVatandasIdStatic, true, signalRelatedEntity, "Bildirims", resetFKFields, new int[] { (int)BildirimFieldIndex.FkVatandasId } );		
			_vatanda = null;
		}
		
		/// <summary> setups the sync logic for member _vatanda</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVatanda(IEntityCore relatedEntity)
		{
			if(_vatanda!=relatedEntity)
			{		
				DesetupSyncVatanda(true, true);
				_vatanda = (VatandaEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vatanda, new PropertyChangedEventHandler( OnVatandaPropertyChanged ), "Vatanda", dhmi.RelationClasses.StaticBildirimRelations.VatandaEntityUsingFkVatandasIdStatic, true, ref _alreadyFetchedVatanda, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVatandaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="bildirimId">PK value for Bildirim which data should be fetched into this Bildirim object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 bildirimId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)BildirimFieldIndex.BildirimId].ForcedCurrentValueWrite(bildirimId);
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
			return DAOFactory.CreateBildirimDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BildirimEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BildirimRelations Relations
		{
			get	{ return new BildirimRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimAtamaGrup' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimAtamaGrups
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimAtamaGrupCollection(), (IEntityRelation)GetRelationsForField("BildirimAtamaGrups")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimAtamaGrupEntity, 0, null, null, null, "BildirimAtamaGrups", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimAtamaKullanici' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimAtamaKullanicis
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimAtamaKullaniciCollection(), (IEntityRelation)GetRelationsForField("BildirimAtamaKullanicis")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimAtamaKullaniciEntity, 0, null, null, null, "BildirimAtamaKullanicis", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimHistories
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimHistoryCollection(), (IEntityRelation)GetRelationsForField("BildirimHistories")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimHistoryEntity, 0, null, null, null, "BildirimHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'EkSure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathEkSures
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.EkSureCollection(), (IEntityRelation)GetRelationsForField("EkSures")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.EkSureEntity, 0, null, null, null, "EkSures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GecenSure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGecenSures
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.GecenSureCollection(), (IEntityRelation)GetRelationsForField("GecenSures")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.GecenSureEntity, 0, null, null, null, "GecenSures", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SureTakip' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSureTakips
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.SureTakipCollection(), (IEntityRelation)GetRelationsForField("SureTakips")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.SureTakipEntity, 0, null, null, null, "SureTakips", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AltKonu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAltKonu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.AltKonuCollection(), (IEntityRelation)GetRelationsForField("AltKonu")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.AltKonuEntity, 0, null, null, null, "AltKonu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimGeriDonu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimGeriDonu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimGeriDonuCollection(), (IEntityRelation)GetRelationsForField("BildirimGeriDonu")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimGeriDonuEntity, 0, null, null, null, "BildirimGeriDonu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimSonuc'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimSonuc
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimSonucCollection(), (IEntityRelation)GetRelationsForField("BildirimSonuc")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimSonucEntity, 0, null, null, null, "BildirimSonuc", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimTuru'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimTuru
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimTuruCollection(), (IEntityRelation)GetRelationsForField("BildirimTuru")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.BildirimTuruEntity, 0, null, null, null, "BildirimTuru", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CagriTipi'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathCagriTipi
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.CagriTipiCollection(), (IEntityRelation)GetRelationsForField("CagriTipi")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.CagriTipiEntity, 0, null, null, null, "CagriTipi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanici
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanici")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanici", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vatanda'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVatanda
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.VatandaCollection(), (IEntityRelation)GetRelationsForField("Vatanda")[0], (int)dhmi.EntityType.BildirimEntity, (int)dhmi.EntityType.VatandaEntity, 0, null, null, null, "Vatanda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The BildirimAciklama property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimAciklama
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimAciklama, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimAciklama, value, true); }
		}

		/// <summary> The BildirimAtanmaDurumu property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Atanma_Durumu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimAtanmaDurumu
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimAtanmaDurumu, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimAtanmaDurumu, value, true); }
		}

		/// <summary> The BildirimDavaAdSoyad property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Dava_Ad_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimDavaAdSoyad
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimDavaAdSoyad, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimDavaAdSoyad, value, true); }
		}

		/// <summary> The BildirimDavaDosyaNo property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Dava_Dosya_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimDavaDosyaNo
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimDavaDosyaNo, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimDavaDosyaNo, value, true); }
		}

		/// <summary> The BildirimDavaKonu property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Dava_Konu"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimDavaKonu
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimDavaKonu, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimDavaKonu, value, true); }
		}

		/// <summary> The BildirimDavaMahkeme property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Dava_Mahkeme"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimDavaMahkeme
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimDavaMahkeme, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimDavaMahkeme, value, true); }
		}

		/// <summary> The BildirimGelenYer property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Gelen_Yer"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BildirimGelenYer
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimGelenYer, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimGelenYer, value, true); }
		}

		/// <summary> The BildirimGeriYapildiMi property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Geri_Yapildi_Mi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean BildirimGeriYapildiMi
		{
			get { return (System.Boolean)GetValue((int)BildirimFieldIndex.BildirimGeriYapildiMi, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimGeriYapildiMi, value, true); }
		}

		/// <summary> The BildirimHavalimani property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Havalimani"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimHavalimani
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimHavalimani, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimHavalimani, value, true); }
		}

		/// <summary> The BildirimId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 BildirimId
		{
			get { return (System.Int64)GetValue((int)BildirimFieldIndex.BildirimId, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimId, value, true); }
		}

		/// <summary> The BildirimKimBitirdi property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Kim_Bitirdi"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> BildirimKimBitirdi
		{
			get { return (Nullable<System.Int16>)GetValue((int)BildirimFieldIndex.BildirimKimBitirdi, false); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimKimBitirdi, value, true); }
		}

		/// <summary> The BildirimKonuDiger property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Konu_Diger"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimKonuDiger
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimKonuDiger, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimKonuDiger, value, true); }
		}

		/// <summary> The BildirimMetin property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Metin"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BildirimMetin
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimMetin, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimMetin, value, true); }
		}

		/// <summary> The BildirimSonIslemTarih property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Son_Islem_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BildirimSonIslemTarih
		{
			get { return (System.DateTime)GetValue((int)BildirimFieldIndex.BildirimSonIslemTarih, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimSonIslemTarih, value, true); }
		}

		/// <summary> The BildirimTarih property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BildirimTarih
		{
			get { return (System.DateTime)GetValue((int)BildirimFieldIndex.BildirimTarih, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimTarih, value, true); }
		}

		/// <summary> The BildirimToplamSure property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Toplam_Sure"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimToplamSure
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimToplamSure, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimToplamSure, value, true); }
		}

		/// <summary> The BildirimVatandasKarar property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Vatandas_Karar"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimVatandasKarar
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimVatandasKarar, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimVatandasKarar, value, true); }
		}

		/// <summary> The BildirimYil property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Yil"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 BildirimYil
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.BildirimYil, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimYil, value, true); }
		}

		/// <summary> The BildirimYonlendirilenKurum property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."Bildirim_Yonlendirilen_Kurum"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String BildirimYonlendirilenKurum
		{
			get { return (System.String)GetValue((int)BildirimFieldIndex.BildirimYonlendirilenKurum, true); }
			set	{ SetValue((int)BildirimFieldIndex.BildirimYonlendirilenKurum, value, true); }
		}

		/// <summary> The FkAltKonuId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Alt_Konu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 FkAltKonuId
		{
			get { return (System.Int64)GetValue((int)BildirimFieldIndex.FkAltKonuId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkAltKonuId, value, true); }
		}

		/// <summary> The FkBildirimGeriDonusId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Bildirim_Geri_Donus_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkBildirimGeriDonusId
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.FkBildirimGeriDonusId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkBildirimGeriDonusId, value, true); }
		}

		/// <summary> The FkBildirimSonucId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Bildirim_Sonuc_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkBildirimSonucId
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.FkBildirimSonucId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkBildirimSonucId, value, true); }
		}

		/// <summary> The FkBildirimTuruId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Bildirim_Turu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkBildirimTuruId
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.FkBildirimTuruId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkBildirimTuruId, value, true); }
		}

		/// <summary> The FkCagriTipiId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Cagri_Tipi_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkCagriTipiId
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.FkCagriTipiId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkCagriTipiId, value, true); }
		}

		/// <summary> The FkKullaniciId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkKullaniciId
		{
			get { return (System.Int16)GetValue((int)BildirimFieldIndex.FkKullaniciId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkKullaniciId, value, true); }
		}

		/// <summary> The FkVatandasId property of the Entity Bildirim<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim"."FK_Vatandas_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 FkVatandasId
		{
			get { return (System.Int64)GetValue((int)BildirimFieldIndex.FkVatandasId, true); }
			set	{ SetValue((int)BildirimFieldIndex.FkVatandasId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BildirimAtamaGrupEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBildirimAtamaGrups()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.BildirimAtamaGrupCollection BildirimAtamaGrups
		{
			get	{ return GetMultiBildirimAtamaGrups(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimAtamaGrups. When set to true, BildirimAtamaGrups is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimAtamaGrups is accessed. You can always execute/ a forced fetch by calling GetMultiBildirimAtamaGrups(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimAtamaGrups
		{
			get	{ return _alwaysFetchBildirimAtamaGrups; }
			set	{ _alwaysFetchBildirimAtamaGrups = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimAtamaGrups already has been fetched. Setting this property to false when BildirimAtamaGrups has been fetched
		/// will clear the BildirimAtamaGrups collection well. Setting this property to true while BildirimAtamaGrups hasn't been fetched disables lazy loading for BildirimAtamaGrups</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimAtamaGrups
		{
			get { return _alreadyFetchedBildirimAtamaGrups;}
			set 
			{
				if(_alreadyFetchedBildirimAtamaGrups && !value && (_bildirimAtamaGrups != null))
				{
					_bildirimAtamaGrups.Clear();
				}
				_alreadyFetchedBildirimAtamaGrups = value;
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
		/// <summary> Retrieves all related entities of type 'SureTakipEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSureTakips()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.SureTakipCollection SureTakips
		{
			get	{ return GetMultiSureTakips(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for SureTakips. When set to true, SureTakips is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SureTakips is accessed. You can always execute/ a forced fetch by calling GetMultiSureTakips(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSureTakips
		{
			get	{ return _alwaysFetchSureTakips; }
			set	{ _alwaysFetchSureTakips = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property SureTakips already has been fetched. Setting this property to false when SureTakips has been fetched
		/// will clear the SureTakips collection well. Setting this property to true while SureTakips hasn't been fetched disables lazy loading for SureTakips</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSureTakips
		{
			get { return _alreadyFetchedSureTakips;}
			set 
			{
				if(_alreadyFetchedSureTakips && !value && (_sureTakips != null))
				{
					_sureTakips.Clear();
				}
				_alreadyFetchedSureTakips = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AltKonuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAltKonu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AltKonuEntity AltKonu
		{
			get	{ return GetSingleAltKonu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAltKonu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "AltKonu", _altKonu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AltKonu. When set to true, AltKonu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AltKonu is accessed. You can always execute a forced fetch by calling GetSingleAltKonu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAltKonu
		{
			get	{ return _alwaysFetchAltKonu; }
			set	{ _alwaysFetchAltKonu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AltKonu already has been fetched. Setting this property to false when AltKonu has been fetched
		/// will set AltKonu to null as well. Setting this property to true while AltKonu hasn't been fetched disables lazy loading for AltKonu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAltKonu
		{
			get { return _alreadyFetchedAltKonu;}
			set 
			{
				if(_alreadyFetchedAltKonu && !value)
				{
					this.AltKonu = null;
				}
				_alreadyFetchedAltKonu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AltKonu is not found
		/// in the database. When set to true, AltKonu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool AltKonuReturnsNewIfNotFound
		{
			get	{ return _altKonuReturnsNewIfNotFound; }
			set { _altKonuReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'BildirimGeriDonuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBildirimGeriDonu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BildirimGeriDonuEntity BildirimGeriDonu
		{
			get	{ return GetSingleBildirimGeriDonu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBildirimGeriDonu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "BildirimGeriDonu", _bildirimGeriDonu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimGeriDonu. When set to true, BildirimGeriDonu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimGeriDonu is accessed. You can always execute a forced fetch by calling GetSingleBildirimGeriDonu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimGeriDonu
		{
			get	{ return _alwaysFetchBildirimGeriDonu; }
			set	{ _alwaysFetchBildirimGeriDonu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimGeriDonu already has been fetched. Setting this property to false when BildirimGeriDonu has been fetched
		/// will set BildirimGeriDonu to null as well. Setting this property to true while BildirimGeriDonu hasn't been fetched disables lazy loading for BildirimGeriDonu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimGeriDonu
		{
			get { return _alreadyFetchedBildirimGeriDonu;}
			set 
			{
				if(_alreadyFetchedBildirimGeriDonu && !value)
				{
					this.BildirimGeriDonu = null;
				}
				_alreadyFetchedBildirimGeriDonu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property BildirimGeriDonu is not found
		/// in the database. When set to true, BildirimGeriDonu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BildirimGeriDonuReturnsNewIfNotFound
		{
			get	{ return _bildirimGeriDonuReturnsNewIfNotFound; }
			set { _bildirimGeriDonuReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'BildirimSonucEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBildirimSonuc()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BildirimSonucEntity BildirimSonuc
		{
			get	{ return GetSingleBildirimSonuc(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBildirimSonuc(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "BildirimSonuc", _bildirimSonuc, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimSonuc. When set to true, BildirimSonuc is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimSonuc is accessed. You can always execute a forced fetch by calling GetSingleBildirimSonuc(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimSonuc
		{
			get	{ return _alwaysFetchBildirimSonuc; }
			set	{ _alwaysFetchBildirimSonuc = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimSonuc already has been fetched. Setting this property to false when BildirimSonuc has been fetched
		/// will set BildirimSonuc to null as well. Setting this property to true while BildirimSonuc hasn't been fetched disables lazy loading for BildirimSonuc</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimSonuc
		{
			get { return _alreadyFetchedBildirimSonuc;}
			set 
			{
				if(_alreadyFetchedBildirimSonuc && !value)
				{
					this.BildirimSonuc = null;
				}
				_alreadyFetchedBildirimSonuc = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property BildirimSonuc is not found
		/// in the database. When set to true, BildirimSonuc will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BildirimSonucReturnsNewIfNotFound
		{
			get	{ return _bildirimSonucReturnsNewIfNotFound; }
			set { _bildirimSonucReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'BildirimTuruEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBildirimTuru()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BildirimTuruEntity BildirimTuru
		{
			get	{ return GetSingleBildirimTuru(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBildirimTuru(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "BildirimTuru", _bildirimTuru, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimTuru. When set to true, BildirimTuru is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimTuru is accessed. You can always execute a forced fetch by calling GetSingleBildirimTuru(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimTuru
		{
			get	{ return _alwaysFetchBildirimTuru; }
			set	{ _alwaysFetchBildirimTuru = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimTuru already has been fetched. Setting this property to false when BildirimTuru has been fetched
		/// will set BildirimTuru to null as well. Setting this property to true while BildirimTuru hasn't been fetched disables lazy loading for BildirimTuru</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimTuru
		{
			get { return _alreadyFetchedBildirimTuru;}
			set 
			{
				if(_alreadyFetchedBildirimTuru && !value)
				{
					this.BildirimTuru = null;
				}
				_alreadyFetchedBildirimTuru = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property BildirimTuru is not found
		/// in the database. When set to true, BildirimTuru will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BildirimTuruReturnsNewIfNotFound
		{
			get	{ return _bildirimTuruReturnsNewIfNotFound; }
			set { _bildirimTuruReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'CagriTipiEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCagriTipi()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CagriTipiEntity CagriTipi
		{
			get	{ return GetSingleCagriTipi(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncCagriTipi(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "CagriTipi", _cagriTipi, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for CagriTipi. When set to true, CagriTipi is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CagriTipi is accessed. You can always execute a forced fetch by calling GetSingleCagriTipi(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchCagriTipi
		{
			get	{ return _alwaysFetchCagriTipi; }
			set	{ _alwaysFetchCagriTipi = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property CagriTipi already has been fetched. Setting this property to false when CagriTipi has been fetched
		/// will set CagriTipi to null as well. Setting this property to true while CagriTipi hasn't been fetched disables lazy loading for CagriTipi</summary>
		[Browsable(false)]
		public bool AlreadyFetchedCagriTipi
		{
			get { return _alreadyFetchedCagriTipi;}
			set 
			{
				if(_alreadyFetchedCagriTipi && !value)
				{
					this.CagriTipi = null;
				}
				_alreadyFetchedCagriTipi = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property CagriTipi is not found
		/// in the database. When set to true, CagriTipi will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool CagriTipiReturnsNewIfNotFound
		{
			get	{ return _cagriTipiReturnsNewIfNotFound; }
			set { _cagriTipiReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'KullaniciEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleKullanici()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual KullaniciEntity Kullanici
		{
			get	{ return GetSingleKullanici(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncKullanici(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "Kullanici", _kullanici, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Kullanici. When set to true, Kullanici is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Kullanici is accessed. You can always execute a forced fetch by calling GetSingleKullanici(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKullanici
		{
			get	{ return _alwaysFetchKullanici; }
			set	{ _alwaysFetchKullanici = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Kullanici already has been fetched. Setting this property to false when Kullanici has been fetched
		/// will set Kullanici to null as well. Setting this property to true while Kullanici hasn't been fetched disables lazy loading for Kullanici</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKullanici
		{
			get { return _alreadyFetchedKullanici;}
			set 
			{
				if(_alreadyFetchedKullanici && !value)
				{
					this.Kullanici = null;
				}
				_alreadyFetchedKullanici = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Kullanici is not found
		/// in the database. When set to true, Kullanici will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool KullaniciReturnsNewIfNotFound
		{
			get	{ return _kullaniciReturnsNewIfNotFound; }
			set { _kullaniciReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'VatandaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVatanda()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual VatandaEntity Vatanda
		{
			get	{ return GetSingleVatanda(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncVatanda(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Bildirims", "Vatanda", _vatanda, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Vatanda. When set to true, Vatanda is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vatanda is accessed. You can always execute a forced fetch by calling GetSingleVatanda(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVatanda
		{
			get	{ return _alwaysFetchVatanda; }
			set	{ _alwaysFetchVatanda = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Vatanda already has been fetched. Setting this property to false when Vatanda has been fetched
		/// will set Vatanda to null as well. Setting this property to true while Vatanda hasn't been fetched disables lazy loading for Vatanda</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVatanda
		{
			get { return _alreadyFetchedVatanda;}
			set 
			{
				if(_alreadyFetchedVatanda && !value)
				{
					this.Vatanda = null;
				}
				_alreadyFetchedVatanda = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Vatanda is not found
		/// in the database. When set to true, Vatanda will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool VatandaReturnsNewIfNotFound
		{
			get	{ return _vatandaReturnsNewIfNotFound; }
			set { _vatandaReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.BildirimEntity; }
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
