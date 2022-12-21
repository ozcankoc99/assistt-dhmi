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

	/// <summary>Entity class which represents the entity 'Grup'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class GrupEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimAtamaGrupCollection	_bildirimAtamaGrups;
		private bool	_alwaysFetchBildirimAtamaGrups, _alreadyFetchedBildirimAtamaGrups;
		private dhmi.CollectionClasses.GrupAtamaCollection	_grupAtamas;
		private bool	_alwaysFetchGrupAtamas, _alreadyFetchedGrupAtamas;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BildirimAtamaGrups</summary>
			public static readonly string BildirimAtamaGrups = "BildirimAtamaGrups";
			/// <summary>Member name GrupAtamas</summary>
			public static readonly string GrupAtamas = "GrupAtamas";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static GrupEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public GrupEntity() :base("GrupEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		public GrupEntity(System.Int16 grupId):base("GrupEntity")
		{
			InitClassFetch(grupId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public GrupEntity(System.Int16 grupId, IPrefetchPath prefetchPathToUse):base("GrupEntity")
		{
			InitClassFetch(grupId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="validator">The custom validator object for this GrupEntity</param>
		public GrupEntity(System.Int16 grupId, IValidator validator):base("GrupEntity")
		{
			InitClassFetch(grupId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected GrupEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirimAtamaGrups = (dhmi.CollectionClasses.BildirimAtamaGrupCollection)info.GetValue("_bildirimAtamaGrups", typeof(dhmi.CollectionClasses.BildirimAtamaGrupCollection));
			_alwaysFetchBildirimAtamaGrups = info.GetBoolean("_alwaysFetchBildirimAtamaGrups");
			_alreadyFetchedBildirimAtamaGrups = info.GetBoolean("_alreadyFetchedBildirimAtamaGrups");

			_grupAtamas = (dhmi.CollectionClasses.GrupAtamaCollection)info.GetValue("_grupAtamas", typeof(dhmi.CollectionClasses.GrupAtamaCollection));
			_alwaysFetchGrupAtamas = info.GetBoolean("_alwaysFetchGrupAtamas");
			_alreadyFetchedGrupAtamas = info.GetBoolean("_alreadyFetchedGrupAtamas");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedBildirimAtamaGrups = (_bildirimAtamaGrups.Count > 0);
			_alreadyFetchedGrupAtamas = (_grupAtamas.Count > 0);
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
				case "BildirimAtamaGrups":
					toReturn.Add(Relations.BildirimAtamaGrupEntityUsingFkGrupId);
					break;
				case "GrupAtamas":
					toReturn.Add(Relations.GrupAtamaEntityUsingFkGrupId);
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
			info.AddValue("_grupAtamas", (!this.MarkedForDeletion?_grupAtamas:null));
			info.AddValue("_alwaysFetchGrupAtamas", _alwaysFetchGrupAtamas);
			info.AddValue("_alreadyFetchedGrupAtamas", _alreadyFetchedGrupAtamas);

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
				case "BildirimAtamaGrups":
					_alreadyFetchedBildirimAtamaGrups = true;
					if(entity!=null)
					{
						this.BildirimAtamaGrups.Add((BildirimAtamaGrupEntity)entity);
					}
					break;
				case "GrupAtamas":
					_alreadyFetchedGrupAtamas = true;
					if(entity!=null)
					{
						this.GrupAtamas.Add((GrupAtamaEntity)entity);
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
				case "BildirimAtamaGrups":
					_bildirimAtamaGrups.Add((BildirimAtamaGrupEntity)relatedEntity);
					break;
				case "GrupAtamas":
					_grupAtamas.Add((GrupAtamaEntity)relatedEntity);
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
				case "BildirimAtamaGrups":
					this.PerformRelatedEntityRemoval(_bildirimAtamaGrups, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "GrupAtamas":
					this.PerformRelatedEntityRemoval(_grupAtamas, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_bildirimAtamaGrups);
			toReturn.Add(_grupAtamas);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 grupId)
		{
			return FetchUsingPK(grupId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 grupId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(grupId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 grupId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(grupId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 grupId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(grupId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.GrupId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new GrupRelations().GetAllRelations();
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
				_bildirimAtamaGrups.GetMultiManyToOne(null, this, filter);
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
				_grupAtamas.GetMultiManyToOne(this, null, filter);
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BildirimAtamaGrups", _bildirimAtamaGrups);
			toReturn.Add("GrupAtamas", _grupAtamas);
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
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="validator">The validator object for this GrupEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 grupId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(grupId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirimAtamaGrups = new dhmi.CollectionClasses.BildirimAtamaGrupCollection();
			_bildirimAtamaGrups.SetContainingEntityInfo(this, "Grup");

			_grupAtamas = new dhmi.CollectionClasses.GrupAtamaCollection();
			_grupAtamas.SetContainingEntityInfo(this, "Grup");
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
			_fieldsCustomProperties.Add("GrupAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupAmir", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupIrtibat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupKisaltma", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GrupTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="grupId">PK value for Grup which data should be fetched into this Grup object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 grupId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)GrupFieldIndex.GrupId].ForcedCurrentValueWrite(grupId);
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
			return DAOFactory.CreateGrupDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new GrupEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static GrupRelations Relations
		{
			get	{ return new GrupRelations(); }
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
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimAtamaGrupCollection(), (IEntityRelation)GetRelationsForField("BildirimAtamaGrups")[0], (int)dhmi.EntityType.GrupEntity, (int)dhmi.EntityType.BildirimAtamaGrupEntity, 0, null, null, null, "BildirimAtamaGrups", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'GrupAtama' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathGrupAtamas
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.GrupAtamaCollection(), (IEntityRelation)GetRelationsForField("GrupAtamas")[0], (int)dhmi.EntityType.GrupEntity, (int)dhmi.EntityType.GrupAtamaEntity, 0, null, null, null, "GrupAtamas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The GrupAciklama property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GrupAciklama
		{
			get { return (System.String)GetValue((int)GrupFieldIndex.GrupAciklama, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupAciklama, value, true); }
		}

		/// <summary> The GrupAd property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String GrupAd
		{
			get { return (System.String)GetValue((int)GrupFieldIndex.GrupAd, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupAd, value, true); }
		}

		/// <summary> The GrupAmir property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Amir"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GrupAmir
		{
			get { return (System.String)GetValue((int)GrupFieldIndex.GrupAmir, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupAmir, value, true); }
		}

		/// <summary> The GrupDurum property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean GrupDurum
		{
			get { return (System.Boolean)GetValue((int)GrupFieldIndex.GrupDurum, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupDurum, value, true); }
		}

		/// <summary> The GrupId property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 GrupId
		{
			get { return (System.Int16)GetValue((int)GrupFieldIndex.GrupId, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupId, value, true); }
		}

		/// <summary> The GrupIrtibat property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Irtibat"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GrupIrtibat
		{
			get { return (System.String)GetValue((int)GrupFieldIndex.GrupIrtibat, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupIrtibat, value, true); }
		}

		/// <summary> The GrupKisaltma property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Kisaltma"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GrupKisaltma
		{
			get { return (System.String)GetValue((int)GrupFieldIndex.GrupKisaltma, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupKisaltma, value, true); }
		}

		/// <summary> The GrupTarih property of the Entity Grup<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Grup"."Grup_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime GrupTarih
		{
			get { return (System.DateTime)GetValue((int)GrupFieldIndex.GrupTarih, true); }
			set	{ SetValue((int)GrupFieldIndex.GrupTarih, value, true); }
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
			get { return (int)dhmi.EntityType.GrupEntity; }
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
