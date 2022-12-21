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

	/// <summary>Entity class which represents the entity 'AltKonu'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AltKonuEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimCollection	_bildirims;
		private bool	_alwaysFetchBildirims, _alreadyFetchedBildirims;
		private KonuEntity _konu;
		private bool	_alwaysFetchKonu, _alreadyFetchedKonu, _konuReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Konu</summary>
			public static readonly string Konu = "Konu";
			/// <summary>Member name Bildirims</summary>
			public static readonly string Bildirims = "Bildirims";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AltKonuEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AltKonuEntity() :base("AltKonuEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		public AltKonuEntity(System.Int64 altKonuId):base("AltKonuEntity")
		{
			InitClassFetch(altKonuId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AltKonuEntity(System.Int64 altKonuId, IPrefetchPath prefetchPathToUse):base("AltKonuEntity")
		{
			InitClassFetch(altKonuId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="validator">The custom validator object for this AltKonuEntity</param>
		public AltKonuEntity(System.Int64 altKonuId, IValidator validator):base("AltKonuEntity")
		{
			InitClassFetch(altKonuId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AltKonuEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirims = (dhmi.CollectionClasses.BildirimCollection)info.GetValue("_bildirims", typeof(dhmi.CollectionClasses.BildirimCollection));
			_alwaysFetchBildirims = info.GetBoolean("_alwaysFetchBildirims");
			_alreadyFetchedBildirims = info.GetBoolean("_alreadyFetchedBildirims");
			_konu = (KonuEntity)info.GetValue("_konu", typeof(KonuEntity));
			if(_konu!=null)
			{
				_konu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_konuReturnsNewIfNotFound = info.GetBoolean("_konuReturnsNewIfNotFound");
			_alwaysFetchKonu = info.GetBoolean("_alwaysFetchKonu");
			_alreadyFetchedKonu = info.GetBoolean("_alreadyFetchedKonu");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AltKonuFieldIndex)fieldIndex)
			{
				case AltKonuFieldIndex.FkKonuId:
					DesetupSyncKonu(true, false);
					_alreadyFetchedKonu = false;
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
			_alreadyFetchedKonu = (_konu != null);
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
				case "Konu":
					toReturn.Add(Relations.KonuEntityUsingFkKonuId);
					break;
				case "Bildirims":
					toReturn.Add(Relations.BildirimEntityUsingFkAltKonuId);
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
			info.AddValue("_konu", (!this.MarkedForDeletion?_konu:null));
			info.AddValue("_konuReturnsNewIfNotFound", _konuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchKonu", _alwaysFetchKonu);
			info.AddValue("_alreadyFetchedKonu", _alreadyFetchedKonu);

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
				case "Konu":
					_alreadyFetchedKonu = true;
					this.Konu = (KonuEntity)entity;
					break;
				case "Bildirims":
					_alreadyFetchedBildirims = true;
					if(entity!=null)
					{
						this.Bildirims.Add((BildirimEntity)entity);
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
				case "Konu":
					SetupSyncKonu(relatedEntity);
					break;
				case "Bildirims":
					_bildirims.Add((BildirimEntity)relatedEntity);
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
				case "Konu":
					DesetupSyncKonu(false, true);
					break;
				case "Bildirims":
					this.PerformRelatedEntityRemoval(_bildirims, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_konu!=null)
			{
				toReturn.Add(_konu);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_bildirims);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 altKonuId)
		{
			return FetchUsingPK(altKonuId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 altKonuId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(altKonuId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 altKonuId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(altKonuId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 altKonuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(altKonuId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AltKonuId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AltKonuRelations().GetAllRelations();
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
				_bildirims.GetMultiManyToOne(this, null, null, null, null, null, null, filter);
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

		/// <summary> Retrieves the related entity of type 'KonuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'KonuEntity' which is related to this entity.</returns>
		public KonuEntity GetSingleKonu()
		{
			return GetSingleKonu(false);
		}

		/// <summary> Retrieves the related entity of type 'KonuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'KonuEntity' which is related to this entity.</returns>
		public virtual KonuEntity GetSingleKonu(bool forceFetch)
		{
			if( ( !_alreadyFetchedKonu || forceFetch || _alwaysFetchKonu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.KonuEntityUsingFkKonuId);
				KonuEntity newEntity = new KonuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkKonuId);
				}
				if(fetchResult)
				{
					newEntity = (KonuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_konuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Konu = newEntity;
				_alreadyFetchedKonu = fetchResult;
			}
			return _konu;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Konu", _konu);
			toReturn.Add("Bildirims", _bildirims);
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
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="validator">The validator object for this AltKonuEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 altKonuId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(altKonuId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirims = new dhmi.CollectionClasses.BildirimCollection();
			_bildirims.SetContainingEntityInfo(this, "AltKonu");
			_konuReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("AltKonuAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltKonuDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltKonuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltKonuTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkKonuId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _konu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncKonu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _konu, new PropertyChangedEventHandler( OnKonuPropertyChanged ), "Konu", dhmi.RelationClasses.StaticAltKonuRelations.KonuEntityUsingFkKonuIdStatic, true, signalRelatedEntity, "AltKonus", resetFKFields, new int[] { (int)AltKonuFieldIndex.FkKonuId } );		
			_konu = null;
		}
		
		/// <summary> setups the sync logic for member _konu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncKonu(IEntityCore relatedEntity)
		{
			if(_konu!=relatedEntity)
			{		
				DesetupSyncKonu(true, true);
				_konu = (KonuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _konu, new PropertyChangedEventHandler( OnKonuPropertyChanged ), "Konu", dhmi.RelationClasses.StaticAltKonuRelations.KonuEntityUsingFkKonuIdStatic, true, ref _alreadyFetchedKonu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnKonuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="altKonuId">PK value for AltKonu which data should be fetched into this AltKonu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 altKonuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AltKonuFieldIndex.AltKonuId].ForcedCurrentValueWrite(altKonuId);
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
			return DAOFactory.CreateAltKonuDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AltKonuEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AltKonuRelations Relations
		{
			get	{ return new AltKonuRelations(); }
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
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimCollection(), (IEntityRelation)GetRelationsForField("Bildirims")[0], (int)dhmi.EntityType.AltKonuEntity, (int)dhmi.EntityType.BildirimEntity, 0, null, null, null, "Bildirims", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Konu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKonu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.KonuCollection(), (IEntityRelation)GetRelationsForField("Konu")[0], (int)dhmi.EntityType.AltKonuEntity, (int)dhmi.EntityType.KonuEntity, 0, null, null, null, "Konu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AltKonuAd property of the Entity AltKonu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Konu"."Alt_Konu_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AltKonuAd
		{
			get { return (System.String)GetValue((int)AltKonuFieldIndex.AltKonuAd, true); }
			set	{ SetValue((int)AltKonuFieldIndex.AltKonuAd, value, true); }
		}

		/// <summary> The AltKonuDurum property of the Entity AltKonu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Konu"."Alt_Konu_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean AltKonuDurum
		{
			get { return (System.Boolean)GetValue((int)AltKonuFieldIndex.AltKonuDurum, true); }
			set	{ SetValue((int)AltKonuFieldIndex.AltKonuDurum, value, true); }
		}

		/// <summary> The AltKonuId property of the Entity AltKonu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Konu"."Alt_Konu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 AltKonuId
		{
			get { return (System.Int64)GetValue((int)AltKonuFieldIndex.AltKonuId, true); }
			set	{ SetValue((int)AltKonuFieldIndex.AltKonuId, value, true); }
		}

		/// <summary> The AltKonuTarih property of the Entity AltKonu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Konu"."Alt_Konu_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime AltKonuTarih
		{
			get { return (System.DateTime)GetValue((int)AltKonuFieldIndex.AltKonuTarih, true); }
			set	{ SetValue((int)AltKonuFieldIndex.AltKonuTarih, value, true); }
		}

		/// <summary> The FkKonuId property of the Entity AltKonu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Konu"."FK_Konu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 FkKonuId
		{
			get { return (System.Int64)GetValue((int)AltKonuFieldIndex.FkKonuId, true); }
			set	{ SetValue((int)AltKonuFieldIndex.FkKonuId, value, true); }
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

		/// <summary> Gets / sets related entity of type 'KonuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleKonu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual KonuEntity Konu
		{
			get	{ return GetSingleKonu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncKonu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AltKonus", "Konu", _konu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Konu. When set to true, Konu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Konu is accessed. You can always execute a forced fetch by calling GetSingleKonu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKonu
		{
			get	{ return _alwaysFetchKonu; }
			set	{ _alwaysFetchKonu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Konu already has been fetched. Setting this property to false when Konu has been fetched
		/// will set Konu to null as well. Setting this property to true while Konu hasn't been fetched disables lazy loading for Konu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKonu
		{
			get { return _alreadyFetchedKonu;}
			set 
			{
				if(_alreadyFetchedKonu && !value)
				{
					this.Konu = null;
				}
				_alreadyFetchedKonu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Konu is not found
		/// in the database. When set to true, Konu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool KonuReturnsNewIfNotFound
		{
			get	{ return _konuReturnsNewIfNotFound; }
			set { _konuReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.AltKonuEntity; }
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
