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

	/// <summary>Entity class which represents the entity 'AltMenu'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AltMenuEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.AltAltMenuCollection	_altAltMenus;
		private bool	_alwaysFetchAltAltMenus, _alreadyFetchedAltAltMenus;
		private dhmi.CollectionClasses.IslemCollection	_islems;
		private bool	_alwaysFetchIslems, _alreadyFetchedIslems;
		private dhmi.CollectionClasses.MenuOlusturCollection	_menuOlusturs;
		private bool	_alwaysFetchMenuOlusturs, _alreadyFetchedMenuOlusturs;
		private MenuEntity _menu;
		private bool	_alwaysFetchMenu, _alreadyFetchedMenu, _menuReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Menu</summary>
			public static readonly string Menu = "Menu";
			/// <summary>Member name AltAltMenus</summary>
			public static readonly string AltAltMenus = "AltAltMenus";
			/// <summary>Member name Islems</summary>
			public static readonly string Islems = "Islems";
			/// <summary>Member name MenuOlusturs</summary>
			public static readonly string MenuOlusturs = "MenuOlusturs";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AltMenuEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AltMenuEntity() :base("AltMenuEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		public AltMenuEntity(System.Int16 altMenuId):base("AltMenuEntity")
		{
			InitClassFetch(altMenuId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AltMenuEntity(System.Int16 altMenuId, IPrefetchPath prefetchPathToUse):base("AltMenuEntity")
		{
			InitClassFetch(altMenuId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="validator">The custom validator object for this AltMenuEntity</param>
		public AltMenuEntity(System.Int16 altMenuId, IValidator validator):base("AltMenuEntity")
		{
			InitClassFetch(altMenuId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AltMenuEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_altAltMenus = (dhmi.CollectionClasses.AltAltMenuCollection)info.GetValue("_altAltMenus", typeof(dhmi.CollectionClasses.AltAltMenuCollection));
			_alwaysFetchAltAltMenus = info.GetBoolean("_alwaysFetchAltAltMenus");
			_alreadyFetchedAltAltMenus = info.GetBoolean("_alreadyFetchedAltAltMenus");

			_islems = (dhmi.CollectionClasses.IslemCollection)info.GetValue("_islems", typeof(dhmi.CollectionClasses.IslemCollection));
			_alwaysFetchIslems = info.GetBoolean("_alwaysFetchIslems");
			_alreadyFetchedIslems = info.GetBoolean("_alreadyFetchedIslems");

			_menuOlusturs = (dhmi.CollectionClasses.MenuOlusturCollection)info.GetValue("_menuOlusturs", typeof(dhmi.CollectionClasses.MenuOlusturCollection));
			_alwaysFetchMenuOlusturs = info.GetBoolean("_alwaysFetchMenuOlusturs");
			_alreadyFetchedMenuOlusturs = info.GetBoolean("_alreadyFetchedMenuOlusturs");
			_menu = (MenuEntity)info.GetValue("_menu", typeof(MenuEntity));
			if(_menu!=null)
			{
				_menu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_menuReturnsNewIfNotFound = info.GetBoolean("_menuReturnsNewIfNotFound");
			_alwaysFetchMenu = info.GetBoolean("_alwaysFetchMenu");
			_alreadyFetchedMenu = info.GetBoolean("_alreadyFetchedMenu");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AltMenuFieldIndex)fieldIndex)
			{
				case AltMenuFieldIndex.FkMenuId:
					DesetupSyncMenu(true, false);
					_alreadyFetchedMenu = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedAltAltMenus = (_altAltMenus.Count > 0);
			_alreadyFetchedIslems = (_islems.Count > 0);
			_alreadyFetchedMenuOlusturs = (_menuOlusturs.Count > 0);
			_alreadyFetchedMenu = (_menu != null);
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
				case "Menu":
					toReturn.Add(Relations.MenuEntityUsingFkMenuId);
					break;
				case "AltAltMenus":
					toReturn.Add(Relations.AltAltMenuEntityUsingFkAltMenuId);
					break;
				case "Islems":
					toReturn.Add(Relations.IslemEntityUsingFkAltMenuId);
					break;
				case "MenuOlusturs":
					toReturn.Add(Relations.MenuOlusturEntityUsingFkAltMenuId);
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
			info.AddValue("_altAltMenus", (!this.MarkedForDeletion?_altAltMenus:null));
			info.AddValue("_alwaysFetchAltAltMenus", _alwaysFetchAltAltMenus);
			info.AddValue("_alreadyFetchedAltAltMenus", _alreadyFetchedAltAltMenus);
			info.AddValue("_islems", (!this.MarkedForDeletion?_islems:null));
			info.AddValue("_alwaysFetchIslems", _alwaysFetchIslems);
			info.AddValue("_alreadyFetchedIslems", _alreadyFetchedIslems);
			info.AddValue("_menuOlusturs", (!this.MarkedForDeletion?_menuOlusturs:null));
			info.AddValue("_alwaysFetchMenuOlusturs", _alwaysFetchMenuOlusturs);
			info.AddValue("_alreadyFetchedMenuOlusturs", _alreadyFetchedMenuOlusturs);
			info.AddValue("_menu", (!this.MarkedForDeletion?_menu:null));
			info.AddValue("_menuReturnsNewIfNotFound", _menuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMenu", _alwaysFetchMenu);
			info.AddValue("_alreadyFetchedMenu", _alreadyFetchedMenu);

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
				case "Menu":
					_alreadyFetchedMenu = true;
					this.Menu = (MenuEntity)entity;
					break;
				case "AltAltMenus":
					_alreadyFetchedAltAltMenus = true;
					if(entity!=null)
					{
						this.AltAltMenus.Add((AltAltMenuEntity)entity);
					}
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
				case "Menu":
					SetupSyncMenu(relatedEntity);
					break;
				case "AltAltMenus":
					_altAltMenus.Add((AltAltMenuEntity)relatedEntity);
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
				case "Menu":
					DesetupSyncMenu(false, true);
					break;
				case "AltAltMenus":
					this.PerformRelatedEntityRemoval(_altAltMenus, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_menu!=null)
			{
				toReturn.Add(_menu);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_altAltMenus);
			toReturn.Add(_islems);
			toReturn.Add(_menuOlusturs);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altMenuId)
		{
			return FetchUsingPK(altMenuId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altMenuId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(altMenuId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(altMenuId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 altMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(altMenuId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AltMenuId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AltMenuRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'AltAltMenuEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AltAltMenuEntity'</returns>
		public dhmi.CollectionClasses.AltAltMenuCollection GetMultiAltAltMenus(bool forceFetch)
		{
			return GetMultiAltAltMenus(forceFetch, _altAltMenus.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AltAltMenuEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'AltAltMenuEntity'</returns>
		public dhmi.CollectionClasses.AltAltMenuCollection GetMultiAltAltMenus(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiAltAltMenus(forceFetch, _altAltMenus.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'AltAltMenuEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.AltAltMenuCollection GetMultiAltAltMenus(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiAltAltMenus(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'AltAltMenuEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.AltAltMenuCollection GetMultiAltAltMenus(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedAltAltMenus || forceFetch || _alwaysFetchAltAltMenus) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_altAltMenus);
				_altAltMenus.SuppressClearInGetMulti=!forceFetch;
				_altAltMenus.EntityFactoryToUse = entityFactoryToUse;
				_altAltMenus.GetMultiManyToOne(this, filter);
				_altAltMenus.SuppressClearInGetMulti=false;
				_alreadyFetchedAltAltMenus = true;
			}
			return _altAltMenus;
		}

		/// <summary> Sets the collection parameters for the collection for 'AltAltMenus'. These settings will be taken into account
		/// when the property AltAltMenus is requested or GetMultiAltAltMenus is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAltAltMenus(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_altAltMenus.SortClauses=sortClauses;
			_altAltMenus.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_islems.GetMultiManyToOne(null, this, null, null, filter);
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
				_menuOlusturs.GetMultiManyToOne(null, this, null, null, filter);
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

		/// <summary> Retrieves the related entity of type 'MenuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'MenuEntity' which is related to this entity.</returns>
		public MenuEntity GetSingleMenu()
		{
			return GetSingleMenu(false);
		}

		/// <summary> Retrieves the related entity of type 'MenuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'MenuEntity' which is related to this entity.</returns>
		public virtual MenuEntity GetSingleMenu(bool forceFetch)
		{
			if( ( !_alreadyFetchedMenu || forceFetch || _alwaysFetchMenu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.MenuEntityUsingFkMenuId);
				MenuEntity newEntity = new MenuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkMenuId);
				}
				if(fetchResult)
				{
					newEntity = (MenuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_menuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Menu = newEntity;
				_alreadyFetchedMenu = fetchResult;
			}
			return _menu;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Menu", _menu);
			toReturn.Add("AltAltMenus", _altAltMenus);
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
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="validator">The validator object for this AltMenuEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 altMenuId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(altMenuId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_altAltMenus = new dhmi.CollectionClasses.AltAltMenuCollection();
			_altAltMenus.SetContainingEntityInfo(this, "AltMenu");

			_islems = new dhmi.CollectionClasses.IslemCollection();
			_islems.SetContainingEntityInfo(this, "AltMenu");

			_menuOlusturs = new dhmi.CollectionClasses.MenuOlusturCollection();
			_menuOlusturs.SetContainingEntityInfo(this, "AltMenu");
			_menuReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("AltMenuAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuLink", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuSira", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuSonLink", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AltMenuTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkMenuId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _menu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMenu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _menu, new PropertyChangedEventHandler( OnMenuPropertyChanged ), "Menu", dhmi.RelationClasses.StaticAltMenuRelations.MenuEntityUsingFkMenuIdStatic, true, signalRelatedEntity, "AltMenus", resetFKFields, new int[] { (int)AltMenuFieldIndex.FkMenuId } );		
			_menu = null;
		}
		
		/// <summary> setups the sync logic for member _menu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncMenu(IEntityCore relatedEntity)
		{
			if(_menu!=relatedEntity)
			{		
				DesetupSyncMenu(true, true);
				_menu = (MenuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _menu, new PropertyChangedEventHandler( OnMenuPropertyChanged ), "Menu", dhmi.RelationClasses.StaticAltMenuRelations.MenuEntityUsingFkMenuIdStatic, true, ref _alreadyFetchedMenu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMenuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="altMenuId">PK value for AltMenu which data should be fetched into this AltMenu object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 altMenuId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AltMenuFieldIndex.AltMenuId].ForcedCurrentValueWrite(altMenuId);
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
			return DAOFactory.CreateAltMenuDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AltMenuEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AltMenuRelations Relations
		{
			get	{ return new AltMenuRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AltAltMenu' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAltAltMenus
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.AltAltMenuCollection(), (IEntityRelation)GetRelationsForField("AltAltMenus")[0], (int)dhmi.EntityType.AltMenuEntity, (int)dhmi.EntityType.AltAltMenuEntity, 0, null, null, null, "AltAltMenus", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Islem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIslems
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.IslemCollection(), (IEntityRelation)GetRelationsForField("Islems")[0], (int)dhmi.EntityType.AltMenuEntity, (int)dhmi.EntityType.IslemEntity, 0, null, null, null, "Islems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MenuOlustur' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMenuOlusturs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.MenuOlusturCollection(), (IEntityRelation)GetRelationsForField("MenuOlusturs")[0], (int)dhmi.EntityType.AltMenuEntity, (int)dhmi.EntityType.MenuOlusturEntity, 0, null, null, null, "MenuOlusturs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Menu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMenu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.MenuCollection(), (IEntityRelation)GetRelationsForField("Menu")[0], (int)dhmi.EntityType.AltMenuEntity, (int)dhmi.EntityType.MenuEntity, 0, null, null, null, "Menu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AltMenuAciklama property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AltMenuAciklama
		{
			get { return (System.String)GetValue((int)AltMenuFieldIndex.AltMenuAciklama, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuAciklama, value, true); }
		}

		/// <summary> The AltMenuAd property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AltMenuAd
		{
			get { return (System.String)GetValue((int)AltMenuFieldIndex.AltMenuAd, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuAd, value, true); }
		}

		/// <summary> The AltMenuDurum property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean AltMenuDurum
		{
			get { return (System.Boolean)GetValue((int)AltMenuFieldIndex.AltMenuDurum, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuDurum, value, true); }
		}

		/// <summary> The AltMenuId property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 AltMenuId
		{
			get { return (System.Int16)GetValue((int)AltMenuFieldIndex.AltMenuId, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuId, value, true); }
		}

		/// <summary> The AltMenuLink property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Link"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AltMenuLink
		{
			get { return (System.String)GetValue((int)AltMenuFieldIndex.AltMenuLink, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuLink, value, true); }
		}

		/// <summary> The AltMenuSira property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Sira"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 AltMenuSira
		{
			get { return (System.Int16)GetValue((int)AltMenuFieldIndex.AltMenuSira, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuSira, value, true); }
		}

		/// <summary> The AltMenuSonLink property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Son_Link"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AltMenuSonLink
		{
			get { return (System.String)GetValue((int)AltMenuFieldIndex.AltMenuSonLink, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuSonLink, value, true); }
		}

		/// <summary> The AltMenuTarih property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."Alt_Menu_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime AltMenuTarih
		{
			get { return (System.DateTime)GetValue((int)AltMenuFieldIndex.AltMenuTarih, true); }
			set	{ SetValue((int)AltMenuFieldIndex.AltMenuTarih, value, true); }
		}

		/// <summary> The FkMenuId property of the Entity AltMenu<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Alt_Menu"."FK_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkMenuId
		{
			get { return (System.Int16)GetValue((int)AltMenuFieldIndex.FkMenuId, true); }
			set	{ SetValue((int)AltMenuFieldIndex.FkMenuId, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'AltAltMenuEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAltAltMenus()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.AltAltMenuCollection AltAltMenus
		{
			get	{ return GetMultiAltAltMenus(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for AltAltMenus. When set to true, AltAltMenus is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AltAltMenus is accessed. You can always execute/ a forced fetch by calling GetMultiAltAltMenus(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAltAltMenus
		{
			get	{ return _alwaysFetchAltAltMenus; }
			set	{ _alwaysFetchAltAltMenus = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property AltAltMenus already has been fetched. Setting this property to false when AltAltMenus has been fetched
		/// will clear the AltAltMenus collection well. Setting this property to true while AltAltMenus hasn't been fetched disables lazy loading for AltAltMenus</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAltAltMenus
		{
			get { return _alreadyFetchedAltAltMenus;}
			set 
			{
				if(_alreadyFetchedAltAltMenus && !value && (_altAltMenus != null))
				{
					_altAltMenus.Clear();
				}
				_alreadyFetchedAltAltMenus = value;
			}
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

		/// <summary> Gets / sets related entity of type 'MenuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMenu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual MenuEntity Menu
		{
			get	{ return GetSingleMenu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncMenu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AltMenus", "Menu", _menu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Menu. When set to true, Menu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Menu is accessed. You can always execute a forced fetch by calling GetSingleMenu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMenu
		{
			get	{ return _alwaysFetchMenu; }
			set	{ _alwaysFetchMenu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Menu already has been fetched. Setting this property to false when Menu has been fetched
		/// will set Menu to null as well. Setting this property to true while Menu hasn't been fetched disables lazy loading for Menu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMenu
		{
			get { return _alreadyFetchedMenu;}
			set 
			{
				if(_alreadyFetchedMenu && !value)
				{
					this.Menu = null;
				}
				_alreadyFetchedMenu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Menu is not found
		/// in the database. When set to true, Menu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool MenuReturnsNewIfNotFound
		{
			get	{ return _menuReturnsNewIfNotFound; }
			set { _menuReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.AltMenuEntity; }
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
