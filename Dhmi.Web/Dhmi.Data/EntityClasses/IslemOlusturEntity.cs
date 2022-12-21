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

	/// <summary>Entity class which represents the entity 'IslemOlustur'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class IslemOlusturEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private IslemEntity _islem;
		private bool	_alwaysFetchIslem, _alreadyFetchedIslem, _islemReturnsNewIfNotFound;
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
			/// <summary>Member name Islem</summary>
			public static readonly string Islem = "Islem";
			/// <summary>Member name Yetki</summary>
			public static readonly string Yetki = "Yetki";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static IslemOlusturEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public IslemOlusturEntity() :base("IslemOlusturEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		public IslemOlusturEntity(System.Int16 islemOlusturId):base("IslemOlusturEntity")
		{
			InitClassFetch(islemOlusturId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public IslemOlusturEntity(System.Int16 islemOlusturId, IPrefetchPath prefetchPathToUse):base("IslemOlusturEntity")
		{
			InitClassFetch(islemOlusturId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="validator">The custom validator object for this IslemOlusturEntity</param>
		public IslemOlusturEntity(System.Int16 islemOlusturId, IValidator validator):base("IslemOlusturEntity")
		{
			InitClassFetch(islemOlusturId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IslemOlusturEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_islem = (IslemEntity)info.GetValue("_islem", typeof(IslemEntity));
			if(_islem!=null)
			{
				_islem.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_islemReturnsNewIfNotFound = info.GetBoolean("_islemReturnsNewIfNotFound");
			_alwaysFetchIslem = info.GetBoolean("_alwaysFetchIslem");
			_alreadyFetchedIslem = info.GetBoolean("_alreadyFetchedIslem");

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
			switch((IslemOlusturFieldIndex)fieldIndex)
			{
				case IslemOlusturFieldIndex.FkIslemId:
					DesetupSyncIslem(true, false);
					_alreadyFetchedIslem = false;
					break;
				case IslemOlusturFieldIndex.FkYetkiId:
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
			_alreadyFetchedIslem = (_islem != null);
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
				case "Islem":
					toReturn.Add(Relations.IslemEntityUsingFkIslemId);
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
			info.AddValue("_islem", (!this.MarkedForDeletion?_islem:null));
			info.AddValue("_islemReturnsNewIfNotFound", _islemReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchIslem", _alwaysFetchIslem);
			info.AddValue("_alreadyFetchedIslem", _alreadyFetchedIslem);
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
				case "Islem":
					_alreadyFetchedIslem = true;
					this.Islem = (IslemEntity)entity;
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
				case "Islem":
					SetupSyncIslem(relatedEntity);
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
				case "Islem":
					DesetupSyncIslem(false, true);
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
			if(_islem!=null)
			{
				toReturn.Add(_islem);
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
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 islemOlusturId)
		{
			return FetchUsingPK(islemOlusturId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 islemOlusturId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(islemOlusturId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 islemOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(islemOlusturId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 islemOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(islemOlusturId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.IslemOlusturId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new IslemOlusturRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'IslemEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'IslemEntity' which is related to this entity.</returns>
		public IslemEntity GetSingleIslem()
		{
			return GetSingleIslem(false);
		}

		/// <summary> Retrieves the related entity of type 'IslemEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'IslemEntity' which is related to this entity.</returns>
		public virtual IslemEntity GetSingleIslem(bool forceFetch)
		{
			if( ( !_alreadyFetchedIslem || forceFetch || _alwaysFetchIslem) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.IslemEntityUsingFkIslemId);
				IslemEntity newEntity = new IslemEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkIslemId);
				}
				if(fetchResult)
				{
					newEntity = (IslemEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_islemReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Islem = newEntity;
				_alreadyFetchedIslem = fetchResult;
			}
			return _islem;
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
			toReturn.Add("Islem", _islem);
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
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="validator">The validator object for this IslemOlusturEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 islemOlusturId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(islemOlusturId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_islemReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FkIslemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkYetkiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IslemOlusturId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IslemOlusturTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _islem</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncIslem(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _islem, new PropertyChangedEventHandler( OnIslemPropertyChanged ), "Islem", dhmi.RelationClasses.StaticIslemOlusturRelations.IslemEntityUsingFkIslemIdStatic, true, signalRelatedEntity, "IslemOlusturs", resetFKFields, new int[] { (int)IslemOlusturFieldIndex.FkIslemId } );		
			_islem = null;
		}
		
		/// <summary> setups the sync logic for member _islem</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncIslem(IEntityCore relatedEntity)
		{
			if(_islem!=relatedEntity)
			{		
				DesetupSyncIslem(true, true);
				_islem = (IslemEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _islem, new PropertyChangedEventHandler( OnIslemPropertyChanged ), "Islem", dhmi.RelationClasses.StaticIslemOlusturRelations.IslemEntityUsingFkIslemIdStatic, true, ref _alreadyFetchedIslem, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnIslemPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticIslemOlusturRelations.YetkiEntityUsingFkYetkiIdStatic, true, signalRelatedEntity, "IslemOlusturs", resetFKFields, new int[] { (int)IslemOlusturFieldIndex.FkYetkiId } );		
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
				this.PerformSetupSyncRelatedEntity( _yetki, new PropertyChangedEventHandler( OnYetkiPropertyChanged ), "Yetki", dhmi.RelationClasses.StaticIslemOlusturRelations.YetkiEntityUsingFkYetkiIdStatic, true, ref _alreadyFetchedYetki, new string[] {  } );
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
		/// <param name="islemOlusturId">PK value for IslemOlustur which data should be fetched into this IslemOlustur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 islemOlusturId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)IslemOlusturFieldIndex.IslemOlusturId].ForcedCurrentValueWrite(islemOlusturId);
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
			return DAOFactory.CreateIslemOlusturDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new IslemOlusturEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static IslemOlusturRelations Relations
		{
			get	{ return new IslemOlusturRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Islem'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIslem
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.IslemCollection(), (IEntityRelation)GetRelationsForField("Islem")[0], (int)dhmi.EntityType.IslemOlusturEntity, (int)dhmi.EntityType.IslemEntity, 0, null, null, null, "Islem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Yetki'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathYetki
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.YetkiCollection(), (IEntityRelation)GetRelationsForField("Yetki")[0], (int)dhmi.EntityType.IslemOlusturEntity, (int)dhmi.EntityType.YetkiEntity, 0, null, null, null, "Yetki", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FkIslemId property of the Entity IslemOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Islem_Olustur"."FK_Islem_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkIslemId
		{
			get { return (System.Int16)GetValue((int)IslemOlusturFieldIndex.FkIslemId, true); }
			set	{ SetValue((int)IslemOlusturFieldIndex.FkIslemId, value, true); }
		}

		/// <summary> The FkYetkiId property of the Entity IslemOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Islem_Olustur"."FK_Yetki_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkYetkiId
		{
			get { return (System.Int16)GetValue((int)IslemOlusturFieldIndex.FkYetkiId, true); }
			set	{ SetValue((int)IslemOlusturFieldIndex.FkYetkiId, value, true); }
		}

		/// <summary> The IslemOlusturId property of the Entity IslemOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Islem_Olustur"."Islem_Olustur_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 IslemOlusturId
		{
			get { return (System.Int16)GetValue((int)IslemOlusturFieldIndex.IslemOlusturId, true); }
			set	{ SetValue((int)IslemOlusturFieldIndex.IslemOlusturId, value, true); }
		}

		/// <summary> The IslemOlusturTarih property of the Entity IslemOlustur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Islem_Olustur"."Islem_Olustur_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime IslemOlusturTarih
		{
			get { return (System.DateTime)GetValue((int)IslemOlusturFieldIndex.IslemOlusturTarih, true); }
			set	{ SetValue((int)IslemOlusturFieldIndex.IslemOlusturTarih, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'IslemEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleIslem()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual IslemEntity Islem
		{
			get	{ return GetSingleIslem(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncIslem(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "IslemOlusturs", "Islem", _islem, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Islem. When set to true, Islem is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Islem is accessed. You can always execute a forced fetch by calling GetSingleIslem(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIslem
		{
			get	{ return _alwaysFetchIslem; }
			set	{ _alwaysFetchIslem = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Islem already has been fetched. Setting this property to false when Islem has been fetched
		/// will set Islem to null as well. Setting this property to true while Islem hasn't been fetched disables lazy loading for Islem</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIslem
		{
			get { return _alreadyFetchedIslem;}
			set 
			{
				if(_alreadyFetchedIslem && !value)
				{
					this.Islem = null;
				}
				_alreadyFetchedIslem = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Islem is not found
		/// in the database. When set to true, Islem will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool IslemReturnsNewIfNotFound
		{
			get	{ return _islemReturnsNewIfNotFound; }
			set { _islemReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "IslemOlusturs", "Yetki", _yetki, true); 
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
			get { return (int)dhmi.EntityType.IslemOlusturEntity; }
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
