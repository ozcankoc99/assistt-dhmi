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

	/// <summary>Entity class which represents the entity 'MenuOlustur'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MenuOlusturEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AltAltMenuEntity _altAltMenu;
		private bool	_alwaysFetchAltAltMenu, _alreadyFetchedAltAltMenu, _altAltMenuReturnsNewIfNotFound;
		private AltMenuEntity _altMenu;
		private bool	_alwaysFetchAltMenu, _alreadyFetchedAltMenu, _altMenuReturnsNewIfNotFound;
		private MenuEntity _menu;
		private bool	_alwaysFetchMenu, _alreadyFetchedMenu, _menuReturnsNewIfNotFound;
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
			/// <summary>Member name AltAltMenu</summary>
			public static readonly string AltAltMenu = "AltAltMenu";
			/// <summary>Member name AltMenu</summary>
			public static readonly string AltMenu = "AltMenu";
			/// <summary>Member name Menu</summary>
			public static readonly string Menu = "Menu";
			/// <summary>Member name Yetki</summary>
			public static readonly string Yetki = "Yetki";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static MenuOlusturEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public MenuOlusturEntity() :base("MenuOlusturEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		public MenuOlusturEntity(System.Int32 menuOlusturId):base("MenuOlusturEntity")
		{
			InitClassFetch(menuOlusturId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public MenuOlusturEntity(System.Int32 menuOlusturId, IPrefetchPath prefetchPathToUse):base("MenuOlusturEntity")
		{
			InitClassFetch(menuOlusturId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="validator">The custom validator object for this MenuOlusturEntity</param>
		public MenuOlusturEntity(System.Int32 menuOlusturId, IValidator validator):base("MenuOlusturEntity")
		{
			InitClassFetch(menuOlusturId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected MenuOlusturEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_altAltMenu = (AltAltMenuEntity)info.GetValue("_altAltMenu", typeof(AltAltMenuEntity));
			if(_altAltMenu!=null)
			{
				_altAltMenu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_altAltMenuReturnsNewIfNotFound = info.GetBoolean("_altAltMenuReturnsNewIfNotFound");
			_alwaysFetchAltAltMenu = info.GetBoolean("_alwaysFetchAltAltMenu");
			_alreadyFetchedAltAltMenu = info.GetBoolean("_alreadyFetchedAltAltMenu");

			_altMenu = (AltMenuEntity)info.GetValue("_altMenu", typeof(AltMenuEntity));
			if(_altMenu!=null)
			{
				_altMenu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_altMenuReturnsNewIfNotFound = info.GetBoolean("_altMenuReturnsNewIfNotFound");
			_alwaysFetchAltMenu = info.GetBoolean("_alwaysFetchAltMenu");
			_alreadyFetchedAltMenu = info.GetBoolean("_alreadyFetchedAltMenu");

			_menu = (MenuEntity)info.GetValue("_menu", typeof(MenuEntity));
			if(_menu!=null)
			{
				_menu.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_menuReturnsNewIfNotFound = info.GetBoolean("_menuReturnsNewIfNotFound");
			_alwaysFetchMenu = info.GetBoolean("_alwaysFetchMenu");
			_alreadyFetchedMenu = info.GetBoolean("_alreadyFetchedMenu");

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
			switch((MenuOlusturFieldIndex)fieldIndex)
			{
				case MenuOlusturFieldIndex.FkAltAltMenuId:
					DesetupSyncAltAltMenu(true, false);
					_alreadyFetchedAltAltMenu = false;
					break;
				case MenuOlusturFieldIndex.FkAltMenuId:
					DesetupSyncAltMenu(true, false);
					_alreadyFetchedAltMenu = false;
					break;
				case MenuOlusturFieldIndex.FkMenuId:
					DesetupSyncMenu(true, false);
					_alreadyFetchedMenu = false;
					break;
				case MenuOlusturFieldIndex.FkYetkiId:
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
			_alreadyFetchedAltAltMenu = (_altAltMenu != null);
			_alreadyFetchedAltMenu = (_altMenu != null);
			_alreadyFetchedMenu = (_menu != null);
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
				case "AltAltMenu":
					toReturn.Add(Relations.AltAltMenuEntityUsingFkAltAltMenuId);
					break;
				case "AltMenu":
					toReturn.Add(Relations.AltMenuEntityUsingFkAltMenuId);
					break;
				case "Menu":
					toReturn.Add(Relations.MenuEntityUsingFkMenuId);
					break;
				case "Yetki":
					toReturn.Add(Relations.YetkiEntityUsingFkYetkiId);
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
			info.AddValue("_altAltMenu", (!this.MarkedForDeletion?_altAltMenu:null));
			info.AddValue("_altAltMenuReturnsNewIfNotFound", _altAltMenuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAltAltMenu", _alwaysFetchAltAltMenu);
			info.AddValue("_alreadyFetchedAltAltMenu", _alreadyFetchedAltAltMenu);
			info.AddValue("_altMenu", (!this.MarkedForDeletion?_altMenu:null));
			info.AddValue("_altMenuReturnsNewIfNotFound", _altMenuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAltMenu", _alwaysFetchAltMenu);
			info.AddValue("_alreadyFetchedAltMenu", _alreadyFetchedAltMenu);
			info.AddValue("_menu", (!this.MarkedForDeletion?_menu:null));
			info.AddValue("_menuReturnsNewIfNotFound", _menuReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMenu", _alwaysFetchMenu);
			info.AddValue("_alreadyFetchedMenu", _alreadyFetchedMenu);
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
				case "AltAltMenu":
					_alreadyFetchedAltAltMenu = true;
					this.AltAltMenu = (AltAltMenuEntity)entity;
					break;
				case "AltMenu":
					_alreadyFetchedAltMenu = true;
					this.AltMenu = (AltMenuEntity)entity;
					break;
				case "Menu":
					_alreadyFetchedMenu = true;
					this.Menu = (MenuEntity)entity;
					break;
				case "Yetki":
					_alreadyFetchedYetki = true;
					this.Yetki = (YetkiEntity)entity;
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
				case "AltAltMenu":
					SetupSyncAltAltMenu(relatedEntity);
					break;
				case "AltMenu":
					SetupSyncAltMenu(relatedEntity);
					break;
				case "Menu":
					SetupSyncMenu(relatedEntity);
					break;
				case "Yetki":
					SetupSyncYetki(relatedEntity);
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
				case "AltAltMenu":
					DesetupSyncAltAltMenu(false, true);
					break;
				case "AltMenu":
					DesetupSyncAltMenu(false, true);
					break;
				case "Menu":
					DesetupSyncMenu(false, true);
					break;
				case "Yetki":
					DesetupSyncYetki(false, true);
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
			if(_altAltMenu!=null)
			{
				toReturn.Add(_altAltMenu);
			}
			if(_altMenu!=null)
			{
				toReturn.Add(_altMenu);
			}
			if(_menu!=null)
			{
				toReturn.Add(_menu);
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


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 menuOlusturId)
		{
			return FetchUsingPK(menuOlusturId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 menuOlusturId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(menuOlusturId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 menuOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(menuOlusturId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 menuOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(menuOlusturId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.MenuOlusturId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new MenuOlusturRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'AltAltMenuEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AltAltMenuEntity' which is related to this entity.</returns>
		public AltAltMenuEntity GetSingleAltAltMenu()
		{
			return GetSingleAltAltMenu(false);
		}

		/// <summary> Retrieves the related entity of type 'AltAltMenuEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AltAltMenuEntity' which is related to this entity.</returns>
		public virtual AltAltMenuEntity GetSingleAltAltMenu(bool forceFetch)
		{
			if( ( !_alreadyFetchedAltAltMenu || forceFetch || _alwaysFetchAltAltMenu) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AltAltMenuEntityUsingFkAltAltMenuId);
				AltAltMenuEntity newEntity = new AltAltMenuEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkAltAltMenuId);
				}
				if(fetchResult)
				{
					newEntity = (AltAltMenuEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_altAltMenuReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AltAltMenu = newEntity;
				_alreadyFetchedAltAltMenu = fetchResult;
			}
			return _altAltMenu;
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
			toReturn.Add("AltAltMenu", _altAltMenu);
			toReturn.Add("AltMenu", _altMenu);
			toReturn.Add("Menu", _menu);
			toReturn.Add("Yetki", _yetki);
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
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="validator">The validator object for this MenuOlusturEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 menuOlusturId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(menuOlusturId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_altAltMenuReturnsNewIfNotFound = false;
			_altMenuReturnsNewIfNotFound = false;
			_menuReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FkAltAltMenuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkAltMenuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkMenuId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkYetkiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MenuOlusturId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MenuOlusturSayi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MenuOlusturTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _altAltMenu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAltAltMenu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _altAltMenu, new PropertyChangedEventHandler( OnAltAltMenuPropertyChanged ), "AltAltMenu", dhmi.RelationClasses.StaticMenuOlusturRelations.AltAltMenuEntityUsingFkAltAltMenuIdStatic, true, signalRelatedEntity, "MenuOlusturs", resetFKFields, new int[] { (int)MenuOlusturFieldIndex.FkAltAltMenuId } );		
			_altAltMenu = null;
		}
		
		/// <summary> setups the sync logic for member _altAltMenu</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAltAltMenu(IEntityCore relatedEntity)
		{
			if(_altAltMenu!=relatedEntity)
			{		
				DesetupSyncAltAltMenu(true, true);
				_altAltMenu = (AltAltMenuEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _altAltMenu, new PropertyChangedEventHandler( OnAltAltMenuPropertyChanged ), "AltAltMenu", dhmi.RelationClasses.StaticMenuOlusturRelations.AltAltMenuEntityUsingFkAltAltMenuIdStatic, true, ref _alreadyFetchedAltAltMenu, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAltAltMenuPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _altMenu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAltMenu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _altMenu, new PropertyChangedEventHandler( OnAltMenuPropertyChanged ), "AltMenu", dhmi.RelationClasses.StaticMenuOlusturRelations.AltMenuEntityUsingFkAltMenuIdStatic, true, signalRelatedEntity, "MenuOlusturs", resetFKFields, new int[] { (int)MenuOlusturFieldIndex.FkAltMenuId } );		
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
				this.PerformSetupSyncRelatedEntity( _altMenu, new PropertyChangedEventHandler( OnAltMenuPropertyChanged ), "AltMenu", dhmi.RelationClasses.StaticMenuOlusturRelations.AltMenuEntityUsingFkAltMenuIdStatic, true, ref _alreadyFetchedAltMenu, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _menu</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMenu(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _menu, new PropertyChangedEventHandler( OnMenuPropertyChanged ), "Menu", dhmi.RelationClasses.StaticMenuOlusturRelations.MenuEntityUsingFkMenuIdStatic, true, signalRelatedEntity, "MenuOlusturs", resetFKFields, new int[] { (int)MenuOlusturFieldIndex.FkMenuId } );		
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
				this.PerformSetupSyncRelatedEntity( _menu, new PropertyChangedEventHandler( OnMenuPropertyChanged ), "Menu", dhmi.RelationClasses.StaticMenuOlusturRelations.MenuEntityUsingFkMenuIdStatic, true, ref _alreadyFetchedMenu, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _yetki</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncYetki(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticMenuOlusturRelations.YetkiEntityUsingFkYetkiIdStatic, true, signalRelatedEntity, "MenuOlusturs", resetFKFields, new int[] { (int)MenuOlusturFieldIndex.FkYetkiId } );		
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
				this.PerformSetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticMenuOlusturRelations.YetkiEntityUsingFkYetkiIdStatic, true, ref _alreadyFetchedYetki, new string[] {  } );
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
		/// <param name="menuOlusturId">PK value for MenuOlustur which data should be fetched into this MenuOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 menuOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)MenuOlusturFieldIndex.MenuOlusturId].ForcedCurrentValueWrite(menuOlusturId);
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
			return DAOFactory.CreateMenuOlusturDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new MenuOlusturEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static MenuOlusturRelations Relations
		{
			get	{ return new MenuOlusturRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AltAltMenu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAltAltMenu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.AltAltMenuCollection(), (IEntityRelation)GetRelationsForField("AltAltMenu")[0], (int)dhmi.EntityType.MenuOlusturEntity, (int)dhmi.EntityType.AltAltMenuEntity, 0, null, null, null, "AltAltMenu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AltMenu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAltMenu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.AltMenuCollection(), (IEntityRelation)GetRelationsForField("AltMenu")[0], (int)dhmi.EntityType.MenuOlusturEntity, (int)dhmi.EntityType.AltMenuEntity, 0, null, null, null, "AltMenu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Menu'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMenu
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.MenuCollection(), (IEntityRelation)GetRelationsForField("Menu")[0], (int)dhmi.EntityType.MenuOlusturEntity, (int)dhmi.EntityType.MenuEntity, 0, null, null, null, "Menu", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Yetki'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathYetki
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.YetkiCollection(), (IEntityRelation)GetRelationsForField("Yetki")[0], (int)dhmi.EntityType.MenuOlusturEntity, (int)dhmi.EntityType.YetkiEntity, 0, null, null, null, "Yetki", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FkAltAltMenuId property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."FK_Alt_Alt_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkAltAltMenuId
		{
			get { return (System.Int16)GetValue((int)MenuOlusturFieldIndex.FkAltAltMenuId, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.FkAltAltMenuId, value, true); }
		}

		/// <summary> The FkAltMenuId property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."FK_Alt_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkAltMenuId
		{
			get { return (System.Int16)GetValue((int)MenuOlusturFieldIndex.FkAltMenuId, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.FkAltMenuId, value, true); }
		}

		/// <summary> The FkMenuId property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."FK_Menu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkMenuId
		{
			get { return (System.Int16)GetValue((int)MenuOlusturFieldIndex.FkMenuId, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.FkMenuId, value, true); }
		}

		/// <summary> The FkYetkiId property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."FK_Yetki_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkYetkiId
		{
			get { return (System.Int16)GetValue((int)MenuOlusturFieldIndex.FkYetkiId, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.FkYetkiId, value, true); }
		}

		/// <summary> The MenuOlusturId property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."Menu_Olustur_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 MenuOlusturId
		{
			get { return (System.Int32)GetValue((int)MenuOlusturFieldIndex.MenuOlusturId, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.MenuOlusturId, value, true); }
		}

		/// <summary> The MenuOlusturSayi property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."Menu_Olustur_Sayi"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> MenuOlusturSayi
		{
			get { return (Nullable<System.Int16>)GetValue((int)MenuOlusturFieldIndex.MenuOlusturSayi, false); }
			set	{ SetValue((int)MenuOlusturFieldIndex.MenuOlusturSayi, value, true); }
		}

		/// <summary> The MenuOlusturTarih property of the Entity MenuOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Menu_Olustur"."Menu_Olustur_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime MenuOlusturTarih
		{
			get { return (System.DateTime)GetValue((int)MenuOlusturFieldIndex.MenuOlusturTarih, true); }
			set	{ SetValue((int)MenuOlusturFieldIndex.MenuOlusturTarih, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'AltAltMenuEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAltAltMenu()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AltAltMenuEntity AltAltMenu
		{
			get	{ return GetSingleAltAltMenu(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAltAltMenu(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "MenuOlusturs", "AltAltMenu", _altAltMenu, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AltAltMenu. When set to true, AltAltMenu is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AltAltMenu is accessed. You can always execute a forced fetch by calling GetSingleAltAltMenu(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAltAltMenu
		{
			get	{ return _alwaysFetchAltAltMenu; }
			set	{ _alwaysFetchAltAltMenu = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AltAltMenu already has been fetched. Setting this property to false when AltAltMenu has been fetched
		/// will set AltAltMenu to null as well. Setting this property to true while AltAltMenu hasn't been fetched disables lazy loading for AltAltMenu</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAltAltMenu
		{
			get { return _alreadyFetchedAltAltMenu;}
			set 
			{
				if(_alreadyFetchedAltAltMenu && !value)
				{
					this.AltAltMenu = null;
				}
				_alreadyFetchedAltAltMenu = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AltAltMenu is not found
		/// in the database. When set to true, AltAltMenu will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool AltAltMenuReturnsNewIfNotFound
		{
			get	{ return _altAltMenuReturnsNewIfNotFound; }
			set { _altAltMenuReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "MenuOlusturs", "AltMenu", _altMenu, true); 
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
					SetSingleRelatedEntityNavigator(value, "MenuOlusturs", "Menu", _menu, true); 
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
					SetSingleRelatedEntityNavigator(value, "MenuOlusturs", "Yetki", _yetki, true); 
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
			get { return (int)dhmi.EntityType.MenuOlusturEntity; }
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
