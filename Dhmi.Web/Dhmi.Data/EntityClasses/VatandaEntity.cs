///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:38
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

	/// <summary>Entity class which represents the entity 'Vatanda'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class VatandaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimCollection	_bildirims;
		private bool	_alwaysFetchBildirims, _alreadyFetchedBildirims;
		private dhmi.CollectionClasses.KaraListeCollection	_karaListes;
		private bool	_alwaysFetchKaraListes, _alreadyFetchedKaraListes;
		private dhmi.CollectionClasses.VatandasArsivCollection	_vatandasArsivs;
		private bool	_alwaysFetchVatandasArsivs, _alreadyFetchedVatandasArsivs;
		private dhmi.CollectionClasses.VipListeCollection	_vipListes;
		private bool	_alwaysFetchVipListes, _alreadyFetchedVipListes;
		private KullaniciEntity _kullanici;
		private bool	_alwaysFetchKullanici, _alreadyFetchedKullanici, _kullaniciReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Kullanici</summary>
			public static readonly string Kullanici = "Kullanici";
			/// <summary>Member name Bildirims</summary>
			public static readonly string Bildirims = "Bildirims";
			/// <summary>Member name KaraListes</summary>
			public static readonly string KaraListes = "KaraListes";
			/// <summary>Member name VatandasArsivs</summary>
			public static readonly string VatandasArsivs = "VatandasArsivs";
			/// <summary>Member name VipListes</summary>
			public static readonly string VipListes = "VipListes";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VatandaEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public VatandaEntity() :base("VatandaEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		public VatandaEntity(System.Int64 vatandasId):base("VatandaEntity")
		{
			InitClassFetch(vatandasId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public VatandaEntity(System.Int64 vatandasId, IPrefetchPath prefetchPathToUse):base("VatandaEntity")
		{
			InitClassFetch(vatandasId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="validator">The custom validator object for this VatandaEntity</param>
		public VatandaEntity(System.Int64 vatandasId, IValidator validator):base("VatandaEntity")
		{
			InitClassFetch(vatandasId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VatandaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirims = (dhmi.CollectionClasses.BildirimCollection)info.GetValue("_bildirims", typeof(dhmi.CollectionClasses.BildirimCollection));
			_alwaysFetchBildirims = info.GetBoolean("_alwaysFetchBildirims");
			_alreadyFetchedBildirims = info.GetBoolean("_alreadyFetchedBildirims");

			_karaListes = (dhmi.CollectionClasses.KaraListeCollection)info.GetValue("_karaListes", typeof(dhmi.CollectionClasses.KaraListeCollection));
			_alwaysFetchKaraListes = info.GetBoolean("_alwaysFetchKaraListes");
			_alreadyFetchedKaraListes = info.GetBoolean("_alreadyFetchedKaraListes");

			_vatandasArsivs = (dhmi.CollectionClasses.VatandasArsivCollection)info.GetValue("_vatandasArsivs", typeof(dhmi.CollectionClasses.VatandasArsivCollection));
			_alwaysFetchVatandasArsivs = info.GetBoolean("_alwaysFetchVatandasArsivs");
			_alreadyFetchedVatandasArsivs = info.GetBoolean("_alreadyFetchedVatandasArsivs");

			_vipListes = (dhmi.CollectionClasses.VipListeCollection)info.GetValue("_vipListes", typeof(dhmi.CollectionClasses.VipListeCollection));
			_alwaysFetchVipListes = info.GetBoolean("_alwaysFetchVipListes");
			_alreadyFetchedVipListes = info.GetBoolean("_alreadyFetchedVipListes");
			_kullanici = (KullaniciEntity)info.GetValue("_kullanici", typeof(KullaniciEntity));
			if(_kullanici!=null)
			{
				_kullanici.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_kullaniciReturnsNewIfNotFound = info.GetBoolean("_kullaniciReturnsNewIfNotFound");
			_alwaysFetchKullanici = info.GetBoolean("_alwaysFetchKullanici");
			_alreadyFetchedKullanici = info.GetBoolean("_alreadyFetchedKullanici");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((VatandaFieldIndex)fieldIndex)
			{
				case VatandaFieldIndex.FkKullaniciId:
					DesetupSyncKullanici(true, false);
					_alreadyFetchedKullanici = false;
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
			_alreadyFetchedKaraListes = (_karaListes.Count > 0);
			_alreadyFetchedVatandasArsivs = (_vatandasArsivs.Count > 0);
			_alreadyFetchedVipListes = (_vipListes.Count > 0);
			_alreadyFetchedKullanici = (_kullanici != null);
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
				case "Kullanici":
					toReturn.Add(Relations.KullaniciEntityUsingFkKullaniciId);
					break;
				case "Bildirims":
					toReturn.Add(Relations.BildirimEntityUsingFkVatandasId);
					break;
				case "KaraListes":
					toReturn.Add(Relations.KaraListeEntityUsingFkVatandasId);
					break;
				case "VatandasArsivs":
					toReturn.Add(Relations.VatandasArsivEntityUsingFkVatandasId);
					break;
				case "VipListes":
					toReturn.Add(Relations.VipListeEntityUsingFkVatandasId);
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
			info.AddValue("_karaListes", (!this.MarkedForDeletion?_karaListes:null));
			info.AddValue("_alwaysFetchKaraListes", _alwaysFetchKaraListes);
			info.AddValue("_alreadyFetchedKaraListes", _alreadyFetchedKaraListes);
			info.AddValue("_vatandasArsivs", (!this.MarkedForDeletion?_vatandasArsivs:null));
			info.AddValue("_alwaysFetchVatandasArsivs", _alwaysFetchVatandasArsivs);
			info.AddValue("_alreadyFetchedVatandasArsivs", _alreadyFetchedVatandasArsivs);
			info.AddValue("_vipListes", (!this.MarkedForDeletion?_vipListes:null));
			info.AddValue("_alwaysFetchVipListes", _alwaysFetchVipListes);
			info.AddValue("_alreadyFetchedVipListes", _alreadyFetchedVipListes);
			info.AddValue("_kullanici", (!this.MarkedForDeletion?_kullanici:null));
			info.AddValue("_kullaniciReturnsNewIfNotFound", _kullaniciReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchKullanici", _alwaysFetchKullanici);
			info.AddValue("_alreadyFetchedKullanici", _alreadyFetchedKullanici);

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
				case "Kullanici":
					_alreadyFetchedKullanici = true;
					this.Kullanici = (KullaniciEntity)entity;
					break;
				case "Bildirims":
					_alreadyFetchedBildirims = true;
					if(entity!=null)
					{
						this.Bildirims.Add((BildirimEntity)entity);
					}
					break;
				case "KaraListes":
					_alreadyFetchedKaraListes = true;
					if(entity!=null)
					{
						this.KaraListes.Add((KaraListeEntity)entity);
					}
					break;
				case "VatandasArsivs":
					_alreadyFetchedVatandasArsivs = true;
					if(entity!=null)
					{
						this.VatandasArsivs.Add((VatandasArsivEntity)entity);
					}
					break;
				case "VipListes":
					_alreadyFetchedVipListes = true;
					if(entity!=null)
					{
						this.VipListes.Add((VipListeEntity)entity);
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
				case "Kullanici":
					SetupSyncKullanici(relatedEntity);
					break;
				case "Bildirims":
					_bildirims.Add((BildirimEntity)relatedEntity);
					break;
				case "KaraListes":
					_karaListes.Add((KaraListeEntity)relatedEntity);
					break;
				case "VatandasArsivs":
					_vatandasArsivs.Add((VatandasArsivEntity)relatedEntity);
					break;
				case "VipListes":
					_vipListes.Add((VipListeEntity)relatedEntity);
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
				case "Kullanici":
					DesetupSyncKullanici(false, true);
					break;
				case "Bildirims":
					this.PerformRelatedEntityRemoval(_bildirims, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "KaraListes":
					this.PerformRelatedEntityRemoval(_karaListes, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VatandasArsivs":
					this.PerformRelatedEntityRemoval(_vatandasArsivs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "VipListes":
					this.PerformRelatedEntityRemoval(_vipListes, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_kullanici!=null)
			{
				toReturn.Add(_kullanici);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_bildirims);
			toReturn.Add(_karaListes);
			toReturn.Add(_vatandasArsivs);
			toReturn.Add(_vipListes);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 vatandasId)
		{
			return FetchUsingPK(vatandasId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 vatandasId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(vatandasId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 vatandasId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(vatandasId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 vatandasId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(vatandasId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.VatandasId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new VatandaRelations().GetAllRelations();
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
				_bildirims.GetMultiManyToOne(null, null, null, null, null, null, this, filter);
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

		/// <summary> Retrieves all related entities of type 'KaraListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'KaraListeEntity'</returns>
		public dhmi.CollectionClasses.KaraListeCollection GetMultiKaraListes(bool forceFetch)
		{
			return GetMultiKaraListes(forceFetch, _karaListes.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KaraListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'KaraListeEntity'</returns>
		public dhmi.CollectionClasses.KaraListeCollection GetMultiKaraListes(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiKaraListes(forceFetch, _karaListes.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'KaraListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.KaraListeCollection GetMultiKaraListes(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiKaraListes(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KaraListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.KaraListeCollection GetMultiKaraListes(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedKaraListes || forceFetch || _alwaysFetchKaraListes) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_karaListes);
				_karaListes.SuppressClearInGetMulti=!forceFetch;
				_karaListes.EntityFactoryToUse = entityFactoryToUse;
				_karaListes.GetMultiManyToOne(this, filter);
				_karaListes.SuppressClearInGetMulti=false;
				_alreadyFetchedKaraListes = true;
			}
			return _karaListes;
		}

		/// <summary> Sets the collection parameters for the collection for 'KaraListes'. These settings will be taken into account
		/// when the property KaraListes is requested or GetMultiKaraListes is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersKaraListes(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_karaListes.SortClauses=sortClauses;
			_karaListes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VatandasArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VatandasArsivEntity'</returns>
		public dhmi.CollectionClasses.VatandasArsivCollection GetMultiVatandasArsivs(bool forceFetch)
		{
			return GetMultiVatandasArsivs(forceFetch, _vatandasArsivs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VatandasArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VatandasArsivEntity'</returns>
		public dhmi.CollectionClasses.VatandasArsivCollection GetMultiVatandasArsivs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVatandasArsivs(forceFetch, _vatandasArsivs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VatandasArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.VatandasArsivCollection GetMultiVatandasArsivs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVatandasArsivs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VatandasArsivEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.VatandasArsivCollection GetMultiVatandasArsivs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVatandasArsivs || forceFetch || _alwaysFetchVatandasArsivs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vatandasArsivs);
				_vatandasArsivs.SuppressClearInGetMulti=!forceFetch;
				_vatandasArsivs.EntityFactoryToUse = entityFactoryToUse;
				_vatandasArsivs.GetMultiManyToOne(this, filter);
				_vatandasArsivs.SuppressClearInGetMulti=false;
				_alreadyFetchedVatandasArsivs = true;
			}
			return _vatandasArsivs;
		}

		/// <summary> Sets the collection parameters for the collection for 'VatandasArsivs'. These settings will be taken into account
		/// when the property VatandasArsivs is requested or GetMultiVatandasArsivs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVatandasArsivs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vatandasArsivs.SortClauses=sortClauses;
			_vatandasArsivs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'VipListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VipListeEntity'</returns>
		public dhmi.CollectionClasses.VipListeCollection GetMultiVipListes(bool forceFetch)
		{
			return GetMultiVipListes(forceFetch, _vipListes.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VipListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VipListeEntity'</returns>
		public dhmi.CollectionClasses.VipListeCollection GetMultiVipListes(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiVipListes(forceFetch, _vipListes.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'VipListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.VipListeCollection GetMultiVipListes(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiVipListes(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'VipListeEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.VipListeCollection GetMultiVipListes(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVipListes || forceFetch || _alwaysFetchVipListes) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_vipListes);
				_vipListes.SuppressClearInGetMulti=!forceFetch;
				_vipListes.EntityFactoryToUse = entityFactoryToUse;
				_vipListes.GetMultiManyToOne(this, filter);
				_vipListes.SuppressClearInGetMulti=false;
				_alreadyFetchedVipListes = true;
			}
			return _vipListes;
		}

		/// <summary> Sets the collection parameters for the collection for 'VipListes'. These settings will be taken into account
		/// when the property VipListes is requested or GetMultiVipListes is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVipListes(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vipListes.SortClauses=sortClauses;
			_vipListes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Kullanici", _kullanici);
			toReturn.Add("Bildirims", _bildirims);
			toReturn.Add("KaraListes", _karaListes);
			toReturn.Add("VatandasArsivs", _vatandasArsivs);
			toReturn.Add("VipListes", _vipListes);
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
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="validator">The validator object for this VatandaEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 vatandasId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(vatandasId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirims = new dhmi.CollectionClasses.BildirimCollection();
			_bildirims.SetContainingEntityInfo(this, "Vatanda");

			_karaListes = new dhmi.CollectionClasses.KaraListeCollection();
			_karaListes.SetContainingEntityInfo(this, "Vatanda");

			_vatandasArsivs = new dhmi.CollectionClasses.VatandasArsivCollection();
			_vatandasArsivs.SetContainingEntityInfo(this, "Vatanda");

			_vipListes = new dhmi.CollectionClasses.VipListeCollection();
			_vipListes.SetContainingEntityInfo(this, "Vatanda");
			_kullaniciReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasAdres", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasAdSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasCinsiyet", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasDogumTarihi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasFax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasIslemTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasMail", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasNotes", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasPasaportNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasTcNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasTel1", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasTel2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasTur", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasUyruk", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VatandasVergiNo", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _kullanici</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncKullanici(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticVatandaRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, signalRelatedEntity, "Vatandas", resetFKFields, new int[] { (int)VatandaFieldIndex.FkKullaniciId } );		
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
				this.PerformSetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticVatandaRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, ref _alreadyFetchedKullanici, new string[] {  } );
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

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="vatandasId">PK value for Vatanda which data should be fetched into this Vatanda object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 vatandasId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)VatandaFieldIndex.VatandasId].ForcedCurrentValueWrite(vatandasId);
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
			return DAOFactory.CreateVatandaDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new VatandaEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static VatandaRelations Relations
		{
			get	{ return new VatandaRelations(); }
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
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimCollection(), (IEntityRelation)GetRelationsForField("Bildirims")[0], (int)dhmi.EntityType.VatandaEntity, (int)dhmi.EntityType.BildirimEntity, 0, null, null, null, "Bildirims", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'KaraListe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKaraListes
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KaraListeCollection(), (IEntityRelation)GetRelationsForField("KaraListes")[0], (int)dhmi.EntityType.VatandaEntity, (int)dhmi.EntityType.KaraListeEntity, 0, null, null, null, "KaraListes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VatandasArsiv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVatandasArsivs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.VatandasArsivCollection(), (IEntityRelation)GetRelationsForField("VatandasArsivs")[0], (int)dhmi.EntityType.VatandaEntity, (int)dhmi.EntityType.VatandasArsivEntity, 0, null, null, null, "VatandasArsivs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'VipListe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVipListes
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.VipListeCollection(), (IEntityRelation)GetRelationsForField("VipListes")[0], (int)dhmi.EntityType.VatandaEntity, (int)dhmi.EntityType.VipListeEntity, 0, null, null, null, "VipListes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanici
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanici")[0], (int)dhmi.EntityType.VatandaEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanici", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FkKullaniciId property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."FK_Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkKullaniciId
		{
			get { return (System.Int16)GetValue((int)VatandaFieldIndex.FkKullaniciId, true); }
			set	{ SetValue((int)VatandaFieldIndex.FkKullaniciId, value, true); }
		}

		/// <summary> The VatandasAd property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String VatandasAd
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasAd, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasAd, value, true); }
		}

		/// <summary> The VatandasAdres property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Adres"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasAdres
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasAdres, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasAdres, value, true); }
		}

		/// <summary> The VatandasAdSoyad property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Ad_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String VatandasAdSoyad
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasAdSoyad, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasAdSoyad, value, true); }
		}

		/// <summary> The VatandasCinsiyet property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Cinsiyet"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasCinsiyet
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasCinsiyet, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasCinsiyet, value, true); }
		}

		/// <summary> The VatandasDogumTarihi property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Dogum_Tarihi"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> VatandasDogumTarihi
		{
			get { return (Nullable<System.DateTime>)GetValue((int)VatandaFieldIndex.VatandasDogumTarihi, false); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasDogumTarihi, value, true); }
		}

		/// <summary> The VatandasFax property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Fax"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasFax
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasFax, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasFax, value, true); }
		}

		/// <summary> The VatandasId property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 VatandasId
		{
			get { return (System.Int64)GetValue((int)VatandaFieldIndex.VatandasId, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasId, value, true); }
		}

		/// <summary> The VatandasIslemTarih property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Islem_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime VatandasIslemTarih
		{
			get { return (System.DateTime)GetValue((int)VatandaFieldIndex.VatandasIslemTarih, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasIslemTarih, value, true); }
		}

		/// <summary> The VatandasMail property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Mail"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 75<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasMail
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasMail, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasMail, value, true); }
		}

		/// <summary> The VatandasNotes property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasNotes
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasNotes, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasNotes, value, true); }
		}

		/// <summary> The VatandasPasaportNo property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Pasaport_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 75<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasPasaportNo
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasPasaportNo, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasPasaportNo, value, true); }
		}

		/// <summary> The VatandasSoyad property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasSoyad
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasSoyad, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasSoyad, value, true); }
		}

		/// <summary> The VatandasTcNo property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_TC_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 11<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasTcNo
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasTcNo, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasTcNo, value, true); }
		}

		/// <summary> The VatandasTel1 property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Tel_1"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasTel1
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasTel1, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasTel1, value, true); }
		}

		/// <summary> The VatandasTel2 property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Tel_2"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasTel2
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasTel2, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasTel2, value, true); }
		}

		/// <summary> The VatandasTur property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Tur"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String VatandasTur
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasTur, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasTur, value, true); }
		}

		/// <summary> The VatandasUyruk property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Uyruk"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 35<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String VatandasUyruk
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasUyruk, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasUyruk, value, true); }
		}

		/// <summary> The VatandasVergiNo property of the Entity Vatanda<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vatandas"."Vatandas_Vergi_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String VatandasVergiNo
		{
			get { return (System.String)GetValue((int)VatandaFieldIndex.VatandasVergiNo, true); }
			set	{ SetValue((int)VatandaFieldIndex.VatandasVergiNo, value, true); }
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
		/// <summary> Retrieves all related entities of type 'KaraListeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiKaraListes()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.KaraListeCollection KaraListes
		{
			get	{ return GetMultiKaraListes(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for KaraListes. When set to true, KaraListes is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time KaraListes is accessed. You can always execute/ a forced fetch by calling GetMultiKaraListes(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKaraListes
		{
			get	{ return _alwaysFetchKaraListes; }
			set	{ _alwaysFetchKaraListes = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property KaraListes already has been fetched. Setting this property to false when KaraListes has been fetched
		/// will clear the KaraListes collection well. Setting this property to true while KaraListes hasn't been fetched disables lazy loading for KaraListes</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKaraListes
		{
			get { return _alreadyFetchedKaraListes;}
			set 
			{
				if(_alreadyFetchedKaraListes && !value && (_karaListes != null))
				{
					_karaListes.Clear();
				}
				_alreadyFetchedKaraListes = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VatandasArsivEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVatandasArsivs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.VatandasArsivCollection VatandasArsivs
		{
			get	{ return GetMultiVatandasArsivs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VatandasArsivs. When set to true, VatandasArsivs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VatandasArsivs is accessed. You can always execute/ a forced fetch by calling GetMultiVatandasArsivs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVatandasArsivs
		{
			get	{ return _alwaysFetchVatandasArsivs; }
			set	{ _alwaysFetchVatandasArsivs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VatandasArsivs already has been fetched. Setting this property to false when VatandasArsivs has been fetched
		/// will clear the VatandasArsivs collection well. Setting this property to true while VatandasArsivs hasn't been fetched disables lazy loading for VatandasArsivs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVatandasArsivs
		{
			get { return _alreadyFetchedVatandasArsivs;}
			set 
			{
				if(_alreadyFetchedVatandasArsivs && !value && (_vatandasArsivs != null))
				{
					_vatandasArsivs.Clear();
				}
				_alreadyFetchedVatandasArsivs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'VipListeEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVipListes()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.VipListeCollection VipListes
		{
			get	{ return GetMultiVipListes(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for VipListes. When set to true, VipListes is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VipListes is accessed. You can always execute/ a forced fetch by calling GetMultiVipListes(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVipListes
		{
			get	{ return _alwaysFetchVipListes; }
			set	{ _alwaysFetchVipListes = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property VipListes already has been fetched. Setting this property to false when VipListes has been fetched
		/// will clear the VipListes collection well. Setting this property to true while VipListes hasn't been fetched disables lazy loading for VipListes</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVipListes
		{
			get { return _alreadyFetchedVipListes;}
			set 
			{
				if(_alreadyFetchedVipListes && !value && (_vipListes != null))
				{
					_vipListes.Clear();
				}
				_alreadyFetchedVipListes = value;
			}
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
					SetSingleRelatedEntityNavigator(value, "Vatandas", "Kullanici", _kullanici, true); 
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
			get { return (int)dhmi.EntityType.VatandaEntity; }
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
