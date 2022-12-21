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

	/// <summary>Entity class which represents the entity 'Parametre'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class ParametreEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.ParametreGenelArsivCollection	_parametreGenelArsivs;
		private bool	_alwaysFetchParametreGenelArsivs, _alreadyFetchedParametreGenelArsivs;
		private KullaniciEntity _kullanici;
		private bool	_alwaysFetchKullanici, _alreadyFetchedKullanici, _kullaniciReturnsNewIfNotFound;
		private ParametreTurEntity _parametreTur;
		private bool	_alwaysFetchParametreTur, _alreadyFetchedParametreTur, _parametreTurReturnsNewIfNotFound;

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
			/// <summary>Member name ParametreTur</summary>
			public static readonly string ParametreTur = "ParametreTur";
			/// <summary>Member name ParametreGenelArsivs</summary>
			public static readonly string ParametreGenelArsivs = "ParametreGenelArsivs";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ParametreEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ParametreEntity() :base("ParametreEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		public ParametreEntity(System.Int16 parametreId):base("ParametreEntity")
		{
			InitClassFetch(parametreId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ParametreEntity(System.Int16 parametreId, IPrefetchPath prefetchPathToUse):base("ParametreEntity")
		{
			InitClassFetch(parametreId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="validator">The custom validator object for this ParametreEntity</param>
		public ParametreEntity(System.Int16 parametreId, IValidator validator):base("ParametreEntity")
		{
			InitClassFetch(parametreId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ParametreEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_parametreGenelArsivs = (dhmi.CollectionClasses.ParametreGenelArsivCollection)info.GetValue("_parametreGenelArsivs", typeof(dhmi.CollectionClasses.ParametreGenelArsivCollection));
			_alwaysFetchParametreGenelArsivs = info.GetBoolean("_alwaysFetchParametreGenelArsivs");
			_alreadyFetchedParametreGenelArsivs = info.GetBoolean("_alreadyFetchedParametreGenelArsivs");
			_kullanici = (KullaniciEntity)info.GetValue("_kullanici", typeof(KullaniciEntity));
			if(_kullanici!=null)
			{
				_kullanici.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_kullaniciReturnsNewIfNotFound = info.GetBoolean("_kullaniciReturnsNewIfNotFound");
			_alwaysFetchKullanici = info.GetBoolean("_alwaysFetchKullanici");
			_alreadyFetchedKullanici = info.GetBoolean("_alreadyFetchedKullanici");

			_parametreTur = (ParametreTurEntity)info.GetValue("_parametreTur", typeof(ParametreTurEntity));
			if(_parametreTur!=null)
			{
				_parametreTur.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_parametreTurReturnsNewIfNotFound = info.GetBoolean("_parametreTurReturnsNewIfNotFound");
			_alwaysFetchParametreTur = info.GetBoolean("_alwaysFetchParametreTur");
			_alreadyFetchedParametreTur = info.GetBoolean("_alreadyFetchedParametreTur");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ParametreFieldIndex)fieldIndex)
			{
				case ParametreFieldIndex.FkKullaniciId:
					DesetupSyncKullanici(true, false);
					_alreadyFetchedKullanici = false;
					break;
				case ParametreFieldIndex.FkParametreTurId:
					DesetupSyncParametreTur(true, false);
					_alreadyFetchedParametreTur = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedParametreGenelArsivs = (_parametreGenelArsivs.Count > 0);
			_alreadyFetchedKullanici = (_kullanici != null);
			_alreadyFetchedParametreTur = (_parametreTur != null);
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
				case "ParametreTur":
					toReturn.Add(Relations.ParametreTurEntityUsingFkParametreTurId);
					break;
				case "ParametreGenelArsivs":
					toReturn.Add(Relations.ParametreGenelArsivEntityUsingFkParametreId);
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
			info.AddValue("_parametreGenelArsivs", (!this.MarkedForDeletion?_parametreGenelArsivs:null));
			info.AddValue("_alwaysFetchParametreGenelArsivs", _alwaysFetchParametreGenelArsivs);
			info.AddValue("_alreadyFetchedParametreGenelArsivs", _alreadyFetchedParametreGenelArsivs);
			info.AddValue("_kullanici", (!this.MarkedForDeletion?_kullanici:null));
			info.AddValue("_kullaniciReturnsNewIfNotFound", _kullaniciReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchKullanici", _alwaysFetchKullanici);
			info.AddValue("_alreadyFetchedKullanici", _alreadyFetchedKullanici);
			info.AddValue("_parametreTur", (!this.MarkedForDeletion?_parametreTur:null));
			info.AddValue("_parametreTurReturnsNewIfNotFound", _parametreTurReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchParametreTur", _alwaysFetchParametreTur);
			info.AddValue("_alreadyFetchedParametreTur", _alreadyFetchedParametreTur);

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
				case "ParametreTur":
					_alreadyFetchedParametreTur = true;
					this.ParametreTur = (ParametreTurEntity)entity;
					break;
				case "ParametreGenelArsivs":
					_alreadyFetchedParametreGenelArsivs = true;
					if(entity!=null)
					{
						this.ParametreGenelArsivs.Add((ParametreGenelArsivEntity)entity);
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
				case "ParametreTur":
					SetupSyncParametreTur(relatedEntity);
					break;
				case "ParametreGenelArsivs":
					_parametreGenelArsivs.Add((ParametreGenelArsivEntity)relatedEntity);
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
				case "ParametreTur":
					DesetupSyncParametreTur(false, true);
					break;
				case "ParametreGenelArsivs":
					this.PerformRelatedEntityRemoval(_parametreGenelArsivs, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_parametreTur!=null)
			{
				toReturn.Add(_parametreTur);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_parametreGenelArsivs);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 parametreId)
		{
			return FetchUsingPK(parametreId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 parametreId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(parametreId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 parametreId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(parametreId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 parametreId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(parametreId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.ParametreId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ParametreRelations().GetAllRelations();
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
				_parametreGenelArsivs.GetMultiManyToOne(null, this, filter);
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


		/// <summary> Retrieves the related entity of type 'ParametreTurEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ParametreTurEntity' which is related to this entity.</returns>
		public ParametreTurEntity GetSingleParametreTur()
		{
			return GetSingleParametreTur(false);
		}

		/// <summary> Retrieves the related entity of type 'ParametreTurEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ParametreTurEntity' which is related to this entity.</returns>
		public virtual ParametreTurEntity GetSingleParametreTur(bool forceFetch)
		{
			if( ( !_alreadyFetchedParametreTur || forceFetch || _alwaysFetchParametreTur) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.ParametreTurEntityUsingFkParametreTurId);
				ParametreTurEntity newEntity = new ParametreTurEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkParametreTurId);
				}
				if(fetchResult)
				{
					newEntity = (ParametreTurEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_parametreTurReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.ParametreTur = newEntity;
				_alreadyFetchedParametreTur = fetchResult;
			}
			return _parametreTur;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Kullanici", _kullanici);
			toReturn.Add("ParametreTur", _parametreTur);
			toReturn.Add("ParametreGenelArsivs", _parametreGenelArsivs);
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
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="validator">The validator object for this ParametreEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 parametreId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(parametreId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_parametreGenelArsivs = new dhmi.CollectionClasses.ParametreGenelArsivCollection();
			_parametreGenelArsivs.SetContainingEntityInfo(this, "Parametre");
			_kullaniciReturnsNewIfNotFound = false;
			_parametreTurReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FkParametreTurId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreBasTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreBitTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreDeger", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ParametreIslemTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _kullanici</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncKullanici(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticParametreRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, signalRelatedEntity, "Parametres", resetFKFields, new int[] { (int)ParametreFieldIndex.FkKullaniciId } );		
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
				this.PerformSetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticParametreRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, ref _alreadyFetchedKullanici, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _parametreTur</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncParametreTur(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _parametreTur, new PropertyChangedEventHandler( OnParametreTurPropertyChanged ), "ParametreTur", dhmi.RelationClasses.StaticParametreRelations.ParametreTurEntityUsingFkParametreTurIdStatic, true, signalRelatedEntity, "Parametres", resetFKFields, new int[] { (int)ParametreFieldIndex.FkParametreTurId } );		
			_parametreTur = null;
		}
		
		/// <summary> setups the sync logic for member _parametreTur</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncParametreTur(IEntityCore relatedEntity)
		{
			if(_parametreTur!=relatedEntity)
			{		
				DesetupSyncParametreTur(true, true);
				_parametreTur = (ParametreTurEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _parametreTur, new PropertyChangedEventHandler( OnParametreTurPropertyChanged ), "ParametreTur", dhmi.RelationClasses.StaticParametreRelations.ParametreTurEntityUsingFkParametreTurIdStatic, true, ref _alreadyFetchedParametreTur, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnParametreTurPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="parametreId">PK value for Parametre which data should be fetched into this Parametre object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 parametreId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)ParametreFieldIndex.ParametreId].ForcedCurrentValueWrite(parametreId);
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
			return DAOFactory.CreateParametreDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ParametreEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ParametreRelations Relations
		{
			get	{ return new ParametreRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ParametreGenelArsiv' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParametreGenelArsivs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.ParametreGenelArsivCollection(), (IEntityRelation)GetRelationsForField("ParametreGenelArsivs")[0], (int)dhmi.EntityType.ParametreEntity, (int)dhmi.EntityType.ParametreGenelArsivEntity, 0, null, null, null, "ParametreGenelArsivs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanici
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanici")[0], (int)dhmi.EntityType.ParametreEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanici", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ParametreTur'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathParametreTur
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.ParametreTurCollection(), (IEntityRelation)GetRelationsForField("ParametreTur")[0], (int)dhmi.EntityType.ParametreEntity, (int)dhmi.EntityType.ParametreTurEntity, 0, null, null, null, "ParametreTur", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FkKullaniciId property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."FK_Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkKullaniciId
		{
			get { return (System.Int16)GetValue((int)ParametreFieldIndex.FkKullaniciId, true); }
			set	{ SetValue((int)ParametreFieldIndex.FkKullaniciId, value, true); }
		}

		/// <summary> The FkParametreTurId property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."FK_Parametre_Tur_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkParametreTurId
		{
			get { return (System.Int16)GetValue((int)ParametreFieldIndex.FkParametreTurId, true); }
			set	{ SetValue((int)ParametreFieldIndex.FkParametreTurId, value, true); }
		}

		/// <summary> The ParametreAd property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ParametreAd
		{
			get { return (System.String)GetValue((int)ParametreFieldIndex.ParametreAd, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreAd, value, true); }
		}

		/// <summary> The ParametreBasTarih property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_Bas_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ParametreBasTarih
		{
			get { return (System.DateTime)GetValue((int)ParametreFieldIndex.ParametreBasTarih, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreBasTarih, value, true); }
		}

		/// <summary> The ParametreBitTarih property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_Bit_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ParametreBitTarih
		{
			get { return (System.DateTime)GetValue((int)ParametreFieldIndex.ParametreBitTarih, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreBitTarih, value, true); }
		}

		/// <summary> The ParametreDeger property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_Deger"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ParametreDeger
		{
			get { return (System.String)GetValue((int)ParametreFieldIndex.ParametreDeger, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreDeger, value, true); }
		}

		/// <summary> The ParametreId property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 ParametreId
		{
			get { return (System.Int16)GetValue((int)ParametreFieldIndex.ParametreId, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreId, value, true); }
		}

		/// <summary> The ParametreIslemTarih property of the Entity Parametre<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Parametre"."Parametre_Islem_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ParametreIslemTarih
		{
			get { return (System.DateTime)GetValue((int)ParametreFieldIndex.ParametreIslemTarih, true); }
			set	{ SetValue((int)ParametreFieldIndex.ParametreIslemTarih, value, true); }
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
					SetSingleRelatedEntityNavigator(value, "Parametres", "Kullanici", _kullanici, true); 
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

		/// <summary> Gets / sets related entity of type 'ParametreTurEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleParametreTur()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ParametreTurEntity ParametreTur
		{
			get	{ return GetSingleParametreTur(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncParametreTur(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Parametres", "ParametreTur", _parametreTur, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ParametreTur. When set to true, ParametreTur is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ParametreTur is accessed. You can always execute a forced fetch by calling GetSingleParametreTur(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchParametreTur
		{
			get	{ return _alwaysFetchParametreTur; }
			set	{ _alwaysFetchParametreTur = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ParametreTur already has been fetched. Setting this property to false when ParametreTur has been fetched
		/// will set ParametreTur to null as well. Setting this property to true while ParametreTur hasn't been fetched disables lazy loading for ParametreTur</summary>
		[Browsable(false)]
		public bool AlreadyFetchedParametreTur
		{
			get { return _alreadyFetchedParametreTur;}
			set 
			{
				if(_alreadyFetchedParametreTur && !value)
				{
					this.ParametreTur = null;
				}
				_alreadyFetchedParametreTur = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ParametreTur is not found
		/// in the database. When set to true, ParametreTur will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool ParametreTurReturnsNewIfNotFound
		{
			get	{ return _parametreTurReturnsNewIfNotFound; }
			set { _parametreTurReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.ParametreEntity; }
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
