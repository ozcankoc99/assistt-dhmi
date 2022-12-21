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

	/// <summary>Entity class which represents the entity 'AltAltMenu'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AltAltMenuEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.IslemCollection	_islems;
		private bool	_alwaysFetchIslems, _alreadyFetchedIslems;
		private dhmi.CollectionClasses.MenuOlusturCollection	_menuOlusturs;
		private bool	_alwaysFetchMenuOlusturs, _alreadyFetchedMenuOlusturs;
		private AltMenuEntity _altMenu;
		private bool	_alwaysFetchAltMenu, _alreadyFetchedAltMenu, _altMenuReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AltMenu</summary>
			public static readonly string AltMenu = "AltMenu";
			/// <summary>Member name Islems</summary>
			public static readonly string Islems = "Islems";
			/// <summary>Member name MenuOlusturs</summary>
			public static readonly string MenuOlusturs = "MenuOlusturs";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AltAltMenuEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AltAltMenuEntity() :base("AltAltMenuEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		public AltAltMenuEntity(System.Int16 altAltMenuId):base("AltAltMenuEntity")
		{
			InitClassFetch(altAltMenuId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AltAltMenuEntity(System.Int16 altAltMenuId, IPrefetchPath prefetchPathToUse):base("AltAltMenuEntity")
		{
			InitClassFetch(altAltMenuId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="validator">The custom validator object for this AltAltMenuEntity</param>
		public AltAltMenuEntity(System.Int16 altAltMenuId, IValidator validator):base("AltAltMenuEntity")
		{
			InitClassFetch(altAltMenuId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AltAltMenuEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_islems = (dhmi.CollectionClasses.IslemCollection)info.GetValue("_islems", typeof(dhmi.CollectionClasses.IslemCollection));
			_alwaysFetchIslems = info.GetBoolean("_alwaysFetchIslems");
			_alreadyFetchedIslems = info.GetBoolean("_alreadyFetchedIslems");

			_menuOlusturs = (dhmi.CollectionClasses.MenuOlusturCollection)info.GetValue("_menuOlusturs", typeof(dhmi.CollectionClasses.MenuOlusturCollection));
			_alwaysFetchMenuOlusturs = info.GetBoolean("_alwaysFetchMenuOlusturs");
			_alreadyFetchedMenuOlusturs = info.GetBoolean("_alreadyFetchedMenuOlusturs");
			_altMenu = (AltMenuEntity)info.GetValue("_altMenu", typeof(AltMenuEntity));
			if(_altMenu!=null)
			{
				_altMenu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_altMenuReturnsNewIfNotFound = info.GetBoolean("_altMenuReturnsNewIfNotFound");
			_alwaysFetchAltMenu = info.GetBoolean("_alwaysFetchAltMenu");
			_alreadyFetchedAltMenu = info.GetBoolean("_alreadyFetchedAltMenu");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AltAltMenuFieldIndex)fieldIndex)
			{
				case AltAltMenuFieldIndex.FkAltMenuId:
					DesetupSyncAltMenu(true, false);
					_alreadyFetchedAltMenu = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedIslems = (_islems.Count > 0);
			_alreadyFetchedMenuOlusturs = (_menuOlusturs.Count > 0);
			_alreadyFetchedAltMenu = (_altMenu != null);
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
				case "AltMenu":
					toReturn.Add(Relations.AltMenuEntityUsingFkAltMenuId);
					break;
				case "Islems":
					toReturn.Add(Relations.IslemEntityUsingFkAltAltMenuId);
					break;
				case "MenuOlusturs":
					toReturn.Add(Relations.MenuOlusturEntityUsingFkAltAltMenuId);
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
			info.AddValue("_islems", (!this.MarkedForDeletion?_islems:null));
			info.AddValue("_alwaysFetchIslems", _alwaysFetchIslems);
			info.AddValue("_alreadyFetchedIslems", _alreadyFetchedIslems);
			info.AddValue("_menuOlusturs", (!this.MarkedForDeletion?_menuOlusturs:null));
			info.AddValue("_alwaysFetchMenuOlusturs", _alwaysFetchMenuOlusturs);
			info.AddValue("_alreadyFetchedMenuOlusturs", _alreadyFetchedMenuOlusturs);
			info.AddValue("_altMenu", (!this.MarkedForDeletion?_altMenu:null));
			info.AddValue("_altMenuReturnsNewIfNotFound", _altMenuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAltMenu", _alwaysFetchAltMenu);
			info.AddValue("_alreadyFetchedAltMenu", _alreadyFetchedAltMenu);

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
				case "AltMenu":
					_alreadyFetchedAltMenu = true;
					this.AltMenu = (AltMenuEntity)entity;
					break;
				case "Islems":
					_alreadyFetchedIslems = true;
					if(entity!=null)
					{
						this.Islems.Add((IslemEntity)entity);
					}
					break;
				case "MenuOlusturs":
					_alreadyFetchedMenuOlusturs = true;
					if(entity!=null)
					{
						this.MenuOlusturs.Add((MenuOlusturEntity)entity);
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
				case "AltMenu":
					SetupSyncAltMenu(relatedEntity);
					break;
				case "Islems":
					_islems.Add((IslemEntity)relatedEntity);
					break;
				case "MenuOlusturs":
					_menuOlusturs.Add((MenuOlusturEntity)relatedEntity);
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
				case "AltMenu":
					DesetupSyncAltMenu(false, true);
					break;
				case "Islems":
					this.PerformRelatedEntityRemoval(_islems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "MenuOlusturs":
					this.PerformRelatedEntityRemoval(_menuOlusturs, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_altMenu!=null)
			{
				toReturn.Add(_altMenu);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_islems);
			toReturn.Add(_menuOlusturs);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altAltMenuId)
		{
			return FetchUsingPK(altAltMenuId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altAltMenuId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(altAltMenuId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altAltMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(altAltMenuId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altAltMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(altAltMenuId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AltAltMenuId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AltAltMenuRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'IslemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IslemEntity'</returns>
		public dhmi.CollectionClasses.IslemCollection GetMultiIslems(bool forceFetch)
		{
			return GetMultiIslems(forceFetch, _islems.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IslemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IslemEntity'</returns>
		public dhmi.CollectionClasses.IslemCollection GetMultiIslems(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIslems(forceFetch, _islems.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IslemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.IslemCollection GetMultiIslems(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIslems(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IslemEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.IslemCollection GetMultiIslems(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIslems || forceFetch || _alwaysFetchIslems) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_islems);
				_islems.SuppressClearInGetMulti=!forceFetch;
				_islems.EntityFactoryToUse = entityFactoryToUse;
				_islems.GetMultiManyToOne(this, null, null, null, filter);
				_islems.SuppressClearInGetMulti=false;
				_alreadyFetchedIslems = true;
			}
			return _islems;
		}

		/// <summary> Sets the collection parameters for the collection for 'Islems'. These settings will be taken into account
		/// when the property Islems is requested or GetMultiIslems is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIslems(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_islems.SortClauses=sortClauses;
			_islems.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'MenuOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MenuOlusturEntity'</returns>
		public dhmi.CollectionClasses.MenuOlusturCollection GetMultiMenuOlusturs(bool forceFetch)
		{
			return GetMultiMenuOlusturs(forceFetch, _menuOlusturs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MenuOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MenuOlusturEntity'</returns>
		public dhmi.CollectionClasses.MenuOlusturCollection GetMultiMenuOlusturs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMenuOlusturs(forceFetch, _menuOlusturs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MenuOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.MenuOlusturCollection GetMultiMenuOlusturs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMenuOlusturs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MenuOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.MenuOlusturCollection GetMultiMenuOlusturs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMenuOlusturs || forceFetch || _alwaysFetchMenuOlusturs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_menuOlusturs);
				_menuOlusturs.SuppressClearInGetMulti=!forceFetch;
				_menuOlusturs.EntityFactoryToUse = entityFactoryToUse;
				_menuOlusturs.GetMultiManyToOne(this, null, null, null, filter);
				_menuOlusturs.SuppressClearInGetMulti=false;
				_alreadyFetchedMenuOlusturs = true;
			}
			return _menuOlusturs;
		}

		/// <summary> Sets the collection parameters for the collection for 'MenuOlusturs'. These settings will be taken into account
		/// when the property MenuOlusturs is requested or GetMultiMenuOlusturs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMenuOlusturs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_menuOlusturs.SortClauses=sortClauses;
			_menuOlusturs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves the related entity of type 'AltMenuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AltMenuEntity' which is related to this entity.</returns>
		public AltMenuEntity GetSingleAltMenu()
		{
			return GetSingleAltMenu(false);
		}

		/// <summary> Retrieves the related entity of type 'AltMenuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AltMenuEntity' which is related to this entity.</returns>
		public virtual AltMenuEntity GetSingleAltMenu(bool forceFetch)
		{
			if( ( !_alreadyFetchedAltMenu || forceFetch || _alwaysFetchAltMenu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AltMenuEntityUsingFkAltMenuId);
				AltMenuEntity newEntity = new AltMenuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkAltMenuId);
				}
				if(fetchResult)
				{
					newEntity = (AltMenuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_altMenuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AltMenu = newEntity;
				_alreadyFetchedAltMenu = fetchResult;
			}
			return _altMenu;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AltMenu", _altMenu);
			toReturn.Add("Islems", _islems);
			toReturn.Add("MenuOlusturs", _menuOlusturs);
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
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="validator">The validator object for this AltAltMenuEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 altAltMenuId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(altAltMenuId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_islems = new dhmi.CollectionClasses.IslemCollection();
			_islems.SetContainingEntityInfo(this, "AltAltMenu");

			_menuOlusturs = new dhmi.CollectionClasses.MenuOlusturCollection();
			_menuOlusturs.SetContainingEntityInfo(this, "AltAltMenu");
			_altMenuReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("AltAltMenuAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuLink", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuSira", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuSonLink", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltAltMenuTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkAltMenuId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _altMenu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAltMenu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _altMenu, new PropertyChangedEventHandler( OnAltMenuPropertyChanged ), "AltMenu", dhmi.RelationClasses.StaticAltAltMenuRelations.AltMenuEntityUsingFkAltMenuIdStatic, true, signalRelatedEntity, "AltAltMenus", resetFKFields, new int[] { (int)AltAltMenuFieldIndex.FkAltMenuId } );		
			_altMenu = null;
		}
		
		/// <summary> setups the sync logic for member _altMenu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAltMenu(IEntityCore relatedEntity)
		{
			if(_altMenu!=relatedEntity)
			{		
				DesetupSyncAltMenu(true, true);
				_altMenu = (AltMenuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _altMenu, new PropertyChangedEventHandler( OnAltMenuPropertyChanged ), "AltMenu", dhmi.RelationClasses.StaticAltAltMenuRelations.AltMenuEntityUsingFkAltMenuIdStatic, true, ref _alreadyFetchedAltMenu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAltMenuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="altAltMenuId">PK value for AltAltMenu which data should be fetched into this AltAltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 altAltMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AltAltMenuFieldIndex.AltAltMenuId].ForcedCurrentValueWrite(altAltMenuId);
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
			return DAOFactory.CreateAltAltMenuDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AltAltMenuEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AltAltMenuRelations Relations
		{
			get	{ return new AltAltMenuRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Islem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIslems
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.IslemCollection(), (IEntityRelation)GetRelationsForField("Islems")[0], (int)dhmi.EntityType.AltAltMenuEntity, (int)dhmi.EntityType.IslemEntity, 0, null, null, null, "Islems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MenuOlustur' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMenuOlusturs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.MenuOlusturCollection(), (IEntityRelation)GetRelationsForField("MenuOlusturs")[0], (int)dhmi.EntityType.AltAltMenuEntity, (int)dhmi.EntityType.MenuOlusturEntity, 0, null, null, null, "MenuOlusturs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AltMenu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAltMenu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.AltMenuCollection(), (IEntityRelation)GetRelationsForField("AltMenu")[0], (int)dhmi.EntityType.AltAltMenuEntity, (int)dhmi.EntityType.AltMenuEntity, 0, null, null, null, "AltMenu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AltAltMenuAciklama property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AltAltMenuAciklama
		{
			get { return (System.String)GetValue((int)AltAltMenuFieldIndex.AltAltMenuAciklama, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuAciklama, value, true); }
		}

		/// <summary> The AltAltMenuAd property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AltAltMenuAd
		{
			get { return (System.String)GetValue((int)AltAltMenuFieldIndex.AltAltMenuAd, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuAd, value, true); }
		}

		/// <summary> The AltAltMenuDurum property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean AltAltMenuDurum
		{
			get { return (System.Boolean)GetValue((int)AltAltMenuFieldIndex.AltAltMenuDurum, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuDurum, value, true); }
		}

		/// <summary> The AltAltMenuId property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 AltAltMenuId
		{
			get { return (System.Int16)GetValue((int)AltAltMenuFieldIndex.AltAltMenuId, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuId, value, true); }
		}

		/// <summary> The AltAltMenuLink property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Link"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AltAltMenuLink
		{
			get { return (System.String)GetValue((int)AltAltMenuFieldIndex.AltAltMenuLink, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuLink, value, true); }
		}

		/// <summary> The AltAltMenuSira property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Sira"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 AltAltMenuSira
		{
			get { return (System.Int16)GetValue((int)AltAltMenuFieldIndex.AltAltMenuSira, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuSira, value, true); }
		}

		/// <summary> The AltAltMenuSonLink property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Son_Link"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AltAltMenuSonLink
		{
			get { return (System.String)GetValue((int)AltAltMenuFieldIndex.AltAltMenuSonLink, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuSonLink, value, true); }
		}

		/// <summary> The AltAltMenuTarih property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."Alt_Alt_Menu_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime AltAltMenuTarih
		{
			get { return (System.DateTime)GetValue((int)AltAltMenuFieldIndex.AltAltMenuTarih, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.AltAltMenuTarih, value, true); }
		}

		/// <summary> The FkAltMenuId property of the Entity AltAltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Alt_Menu"."FK_Alt_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkAltMenuId
		{
			get { return (System.Int16)GetValue((int)AltAltMenuFieldIndex.FkAltMenuId, true); }
			set	{ SetValue((int)AltAltMenuFieldIndex.FkAltMenuId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'IslemEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIslems()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.IslemCollection Islems
		{
			get	{ return GetMultiIslems(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Islems. When set to true, Islems is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Islems is accessed. You can always execute/ a forced fetch by calling GetMultiIslems(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIslems
		{
			get	{ return _alwaysFetchIslems; }
			set	{ _alwaysFetchIslems = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Islems already has been fetched. Setting this property to false when Islems has been fetched
		/// will clear the Islems collection well. Setting this property to true while Islems hasn't been fetched disables lazy loading for Islems</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIslems
		{
			get { return _alreadyFetchedIslems;}
			set 
			{
				if(_alreadyFetchedIslems && !value && (_islems != null))
				{
					_islems.Clear();
				}
				_alreadyFetchedIslems = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'MenuOlusturEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMenuOlusturs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.MenuOlusturCollection MenuOlusturs
		{
			get	{ return GetMultiMenuOlusturs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for MenuOlusturs. When set to true, MenuOlusturs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time MenuOlusturs is accessed. You can always execute/ a forced fetch by calling GetMultiMenuOlusturs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMenuOlusturs
		{
			get	{ return _alwaysFetchMenuOlusturs; }
			set	{ _alwaysFetchMenuOlusturs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property MenuOlusturs already has been fetched. Setting this property to false when MenuOlusturs has been fetched
		/// will clear the MenuOlusturs collection well. Setting this property to true while MenuOlusturs hasn't been fetched disables lazy loading for MenuOlusturs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMenuOlusturs
		{
			get { return _alreadyFetchedMenuOlusturs;}
			set 
			{
				if(_alreadyFetchedMenuOlusturs && !value && (_menuOlusturs != null))
				{
					_menuOlusturs.Clear();
				}
				_alreadyFetchedMenuOlusturs = value;
			}
		}

		/// <summary> Gets / sets related entity of type 'AltMenuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAltMenu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AltMenuEntity AltMenu
		{
			get	{ return GetSingleAltMenu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAltMenu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AltAltMenus", "AltMenu", _altMenu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AltMenu. When set to true, AltMenu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AltMenu is accessed. You can always execute a forced fetch by calling GetSingleAltMenu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAltMenu
		{
			get	{ return _alwaysFetchAltMenu; }
			set	{ _alwaysFetchAltMenu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AltMenu already has been fetched. Setting this property to false when AltMenu has been fetched
		/// will set AltMenu to null as well. Setting this property to true while AltMenu hasn't been fetched disables lazy loading for AltMenu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAltMenu
		{
			get { return _alreadyFetchedAltMenu;}
			set 
			{
				if(_alreadyFetchedAltMenu && !value)
				{
					this.AltMenu = null;
				}
				_alreadyFetchedAltMenu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AltMenu is not found
		/// in the database. When set to true, AltMenu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool AltMenuReturnsNewIfNotFound
		{
			get	{ return _altMenuReturnsNewIfNotFound; }
			set { _altMenuReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.AltAltMenuEntity; }
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
