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

	/// <summary>Entity class which represents the entity 'BildirimHistory'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BildirimHistoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private BildirimEntity _bildirim;
		private bool	_alwaysFetchBildirim, _alreadyFetchedBildirim, _bildirimReturnsNewIfNotFound;
		private BildirimIslemEntity _bildirimIslem;
		private bool	_alwaysFetchBildirimIslem, _alreadyFetchedBildirimIslem, _bildirimIslemReturnsNewIfNotFound;
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
			/// <summary>Member name Bildirim</summary>
			public static readonly string Bildirim = "Bildirim";
			/// <summary>Member name BildirimIslem</summary>
			public static readonly string BildirimIslem = "BildirimIslem";
			/// <summary>Member name Kullanici</summary>
			public static readonly string Kullanici = "Kullanici";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BildirimHistoryEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BildirimHistoryEntity() :base("BildirimHistoryEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		public BildirimHistoryEntity(System.Int64 bildirimHistoryId):base("BildirimHistoryEntity")
		{
			InitClassFetch(bildirimHistoryId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BildirimHistoryEntity(System.Int64 bildirimHistoryId, IPrefetchPath prefetchPathToUse):base("BildirimHistoryEntity")
		{
			InitClassFetch(bildirimHistoryId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="validator">The custom validator object for this BildirimHistoryEntity</param>
		public BildirimHistoryEntity(System.Int64 bildirimHistoryId, IValidator validator):base("BildirimHistoryEntity")
		{
			InitClassFetch(bildirimHistoryId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BildirimHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirim = (BildirimEntity)info.GetValue("_bildirim", typeof(BildirimEntity));
			if(_bildirim!=null)
			{
				_bildirim.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_bildirimReturnsNewIfNotFound = info.GetBoolean("_bildirimReturnsNewIfNotFound");
			_alwaysFetchBildirim = info.GetBoolean("_alwaysFetchBildirim");
			_alreadyFetchedBildirim = info.GetBoolean("_alreadyFetchedBildirim");

			_bildirimIslem = (BildirimIslemEntity)info.GetValue("_bildirimIslem", typeof(BildirimIslemEntity));
			if(_bildirimIslem!=null)
			{
				_bildirimIslem.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_bildirimIslemReturnsNewIfNotFound = info.GetBoolean("_bildirimIslemReturnsNewIfNotFound");
			_alwaysFetchBildirimIslem = info.GetBoolean("_alwaysFetchBildirimIslem");
			_alreadyFetchedBildirimIslem = info.GetBoolean("_alreadyFetchedBildirimIslem");

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
			switch((BildirimHistoryFieldIndex)fieldIndex)
			{
				case BildirimHistoryFieldIndex.FkBildirimId:
					DesetupSyncBildirim(true, false);
					_alreadyFetchedBildirim = false;
					break;
				case BildirimHistoryFieldIndex.FkBildirimIslemId:
					DesetupSyncBildirimIslem(true, false);
					_alreadyFetchedBildirimIslem = false;
					break;
				case BildirimHistoryFieldIndex.FkKullaniciId:
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
			_alreadyFetchedBildirim = (_bildirim != null);
			_alreadyFetchedBildirimIslem = (_bildirimIslem != null);
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
				case "Bildirim":
					toReturn.Add(Relations.BildirimEntityUsingFkBildirimId);
					break;
				case "BildirimIslem":
					toReturn.Add(Relations.BildirimIslemEntityUsingFkBildirimIslemId);
					break;
				case "Kullanici":
					toReturn.Add(Relations.KullaniciEntityUsingFkKullaniciId);
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
			info.AddValue("_bildirim", (!this.MarkedForDeletion?_bildirim:null));
			info.AddValue("_bildirimReturnsNewIfNotFound", _bildirimReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBildirim", _alwaysFetchBildirim);
			info.AddValue("_alreadyFetchedBildirim", _alreadyFetchedBildirim);
			info.AddValue("_bildirimIslem", (!this.MarkedForDeletion?_bildirimIslem:null));
			info.AddValue("_bildirimIslemReturnsNewIfNotFound", _bildirimIslemReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchBildirimIslem", _alwaysFetchBildirimIslem);
			info.AddValue("_alreadyFetchedBildirimIslem", _alreadyFetchedBildirimIslem);
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
				case "Bildirim":
					_alreadyFetchedBildirim = true;
					this.Bildirim = (BildirimEntity)entity;
					break;
				case "BildirimIslem":
					_alreadyFetchedBildirimIslem = true;
					this.BildirimIslem = (BildirimIslemEntity)entity;
					break;
				case "Kullanici":
					_alreadyFetchedKullanici = true;
					this.Kullanici = (KullaniciEntity)entity;
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
				case "Bildirim":
					SetupSyncBildirim(relatedEntity);
					break;
				case "BildirimIslem":
					SetupSyncBildirimIslem(relatedEntity);
					break;
				case "Kullanici":
					SetupSyncKullanici(relatedEntity);
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
				case "Bildirim":
					DesetupSyncBildirim(false, true);
					break;
				case "BildirimIslem":
					DesetupSyncBildirimIslem(false, true);
					break;
				case "Kullanici":
					DesetupSyncKullanici(false, true);
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
			if(_bildirim!=null)
			{
				toReturn.Add(_bildirim);
			}
			if(_bildirimIslem!=null)
			{
				toReturn.Add(_bildirimIslem);
			}
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


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimHistoryId)
		{
			return FetchUsingPK(bildirimHistoryId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimHistoryId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(bildirimHistoryId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimHistoryId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(bildirimHistoryId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 bildirimHistoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(bildirimHistoryId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BildirimHistoryId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BildirimHistoryRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'BildirimEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BildirimEntity' which is related to this entity.</returns>
		public BildirimEntity GetSingleBildirim()
		{
			return GetSingleBildirim(false);
		}

		/// <summary> Retrieves the related entity of type 'BildirimEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BildirimEntity' which is related to this entity.</returns>
		public virtual BildirimEntity GetSingleBildirim(bool forceFetch)
		{
			if( ( !_alreadyFetchedBildirim || forceFetch || _alwaysFetchBildirim) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BildirimEntityUsingFkBildirimId);
				BildirimEntity newEntity = new BildirimEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkBildirimId);
				}
				if(fetchResult)
				{
					newEntity = (BildirimEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_bildirimReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Bildirim = newEntity;
				_alreadyFetchedBildirim = fetchResult;
			}
			return _bildirim;
		}


		/// <summary> Retrieves the related entity of type 'BildirimIslemEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'BildirimIslemEntity' which is related to this entity.</returns>
		public BildirimIslemEntity GetSingleBildirimIslem()
		{
			return GetSingleBildirimIslem(false);
		}

		/// <summary> Retrieves the related entity of type 'BildirimIslemEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'BildirimIslemEntity' which is related to this entity.</returns>
		public virtual BildirimIslemEntity GetSingleBildirimIslem(bool forceFetch)
		{
			if( ( !_alreadyFetchedBildirimIslem || forceFetch || _alwaysFetchBildirimIslem) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.BildirimIslemEntityUsingFkBildirimIslemId);
				BildirimIslemEntity newEntity = new BildirimIslemEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkBildirimIslemId);
				}
				if(fetchResult)
				{
					newEntity = (BildirimIslemEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_bildirimIslemReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.BildirimIslem = newEntity;
				_alreadyFetchedBildirimIslem = fetchResult;
			}
			return _bildirimIslem;
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
			toReturn.Add("Bildirim", _bildirim);
			toReturn.Add("BildirimIslem", _bildirimIslem);
			toReturn.Add("Kullanici", _kullanici);
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
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="validator">The validator object for this BildirimHistoryEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 bildirimHistoryId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(bildirimHistoryId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_bildirimReturnsNewIfNotFound = false;
			_bildirimIslemReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("BildirimHistoryAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimHistoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimHistorySure", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimHistoryTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkBildirimId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkBildirimIslemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _bildirim</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBildirim(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _bildirim, new PropertyChangedEventHandler( OnBildirimPropertyChanged ), "Bildirim", dhmi.RelationClasses.StaticBildirimHistoryRelations.BildirimEntityUsingFkBildirimIdStatic, true, signalRelatedEntity, "BildirimHistories", resetFKFields, new int[] { (int)BildirimHistoryFieldIndex.FkBildirimId } );		
			_bildirim = null;
		}
		
		/// <summary> setups the sync logic for member _bildirim</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBildirim(IEntityCore relatedEntity)
		{
			if(_bildirim!=relatedEntity)
			{		
				DesetupSyncBildirim(true, true);
				_bildirim = (BildirimEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _bildirim, new PropertyChangedEventHandler( OnBildirimPropertyChanged ), "Bildirim", dhmi.RelationClasses.StaticBildirimHistoryRelations.BildirimEntityUsingFkBildirimIdStatic, true, ref _alreadyFetchedBildirim, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBildirimPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _bildirimIslem</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBildirimIslem(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _bildirimIslem, new PropertyChangedEventHandler( OnBildirimIslemPropertyChanged ), "BildirimIslem", dhmi.RelationClasses.StaticBildirimHistoryRelations.BildirimIslemEntityUsingFkBildirimIslemIdStatic, true, signalRelatedEntity, "BildirimHistories", resetFKFields, new int[] { (int)BildirimHistoryFieldIndex.FkBildirimIslemId } );		
			_bildirimIslem = null;
		}
		
		/// <summary> setups the sync logic for member _bildirimIslem</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBildirimIslem(IEntityCore relatedEntity)
		{
			if(_bildirimIslem!=relatedEntity)
			{		
				DesetupSyncBildirimIslem(true, true);
				_bildirimIslem = (BildirimIslemEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _bildirimIslem, new PropertyChangedEventHandler( OnBildirimIslemPropertyChanged ), "BildirimIslem", dhmi.RelationClasses.StaticBildirimHistoryRelations.BildirimIslemEntityUsingFkBildirimIslemIdStatic, true, ref _alreadyFetchedBildirimIslem, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBildirimIslemPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticBildirimHistoryRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, signalRelatedEntity, "BildirimHistories", resetFKFields, new int[] { (int)BildirimHistoryFieldIndex.FkKullaniciId } );		
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
				this.PerformSetupSyncRelatedEntity( _kullanici, new PropertyChangedEventHandler( OnKullaniciPropertyChanged ), "Kullanici", dhmi.RelationClasses.StaticBildirimHistoryRelations.KullaniciEntityUsingFkKullaniciIdStatic, true, ref _alreadyFetchedKullanici, new string[] {  } );
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
		/// <param name="bildirimHistoryId">PK value for BildirimHistory which data should be fetched into this BildirimHistory object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 bildirimHistoryId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)BildirimHistoryFieldIndex.BildirimHistoryId].ForcedCurrentValueWrite(bildirimHistoryId);
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
			return DAOFactory.CreateBildirimHistoryDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BildirimHistoryEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BildirimHistoryRelations Relations
		{
			get	{ return new BildirimHistoryRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bildirim'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirim
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimCollection(), (IEntityRelation)GetRelationsForField("Bildirim")[0], (int)dhmi.EntityType.BildirimHistoryEntity, (int)dhmi.EntityType.BildirimEntity, 0, null, null, null, "Bildirim", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimIslem'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimIslem
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimIslemCollection(), (IEntityRelation)GetRelationsForField("BildirimIslem")[0], (int)dhmi.EntityType.BildirimHistoryEntity, (int)dhmi.EntityType.BildirimIslemEntity, 0, null, null, null, "BildirimIslem", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanici
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanici")[0], (int)dhmi.EntityType.BildirimHistoryEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanici", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The BildirimHistoryAciklama property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."Bildirim_History_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2000<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BildirimHistoryAciklama
		{
			get { return (System.String)GetValue((int)BildirimHistoryFieldIndex.BildirimHistoryAciklama, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.BildirimHistoryAciklama, value, true); }
		}

		/// <summary> The BildirimHistoryId property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."Bildirim_History_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 BildirimHistoryId
		{
			get { return (System.Int64)GetValue((int)BildirimHistoryFieldIndex.BildirimHistoryId, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.BildirimHistoryId, value, true); }
		}

		/// <summary> The BildirimHistorySure property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."Bildirim_History_Sure"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BildirimHistorySure
		{
			get { return (System.String)GetValue((int)BildirimHistoryFieldIndex.BildirimHistorySure, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.BildirimHistorySure, value, true); }
		}

		/// <summary> The BildirimHistoryTarih property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."Bildirim_History_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BildirimHistoryTarih
		{
			get { return (System.DateTime)GetValue((int)BildirimHistoryFieldIndex.BildirimHistoryTarih, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.BildirimHistoryTarih, value, true); }
		}

		/// <summary> The FkBildirimId property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."FK_Bildirim_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 FkBildirimId
		{
			get { return (System.Int64)GetValue((int)BildirimHistoryFieldIndex.FkBildirimId, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.FkBildirimId, value, true); }
		}

		/// <summary> The FkBildirimIslemId property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."FK_Bildirim_Islem_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkBildirimIslemId
		{
			get { return (System.Int16)GetValue((int)BildirimHistoryFieldIndex.FkBildirimIslemId, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.FkBildirimIslemId, value, true); }
		}

		/// <summary> The FkKullaniciId property of the Entity BildirimHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_History"."FK_Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 FkKullaniciId
		{
			get { return (System.Int16)GetValue((int)BildirimHistoryFieldIndex.FkKullaniciId, true); }
			set	{ SetValue((int)BildirimHistoryFieldIndex.FkKullaniciId, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'BildirimEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBildirim()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BildirimEntity Bildirim
		{
			get	{ return GetSingleBildirim(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBildirim(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BildirimHistories", "Bildirim", _bildirim, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Bildirim. When set to true, Bildirim is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Bildirim is accessed. You can always execute a forced fetch by calling GetSingleBildirim(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirim
		{
			get	{ return _alwaysFetchBildirim; }
			set	{ _alwaysFetchBildirim = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Bildirim already has been fetched. Setting this property to false when Bildirim has been fetched
		/// will set Bildirim to null as well. Setting this property to true while Bildirim hasn't been fetched disables lazy loading for Bildirim</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirim
		{
			get { return _alreadyFetchedBildirim;}
			set 
			{
				if(_alreadyFetchedBildirim && !value)
				{
					this.Bildirim = null;
				}
				_alreadyFetchedBildirim = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Bildirim is not found
		/// in the database. When set to true, Bildirim will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BildirimReturnsNewIfNotFound
		{
			get	{ return _bildirimReturnsNewIfNotFound; }
			set { _bildirimReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'BildirimIslemEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBildirimIslem()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual BildirimIslemEntity BildirimIslem
		{
			get	{ return GetSingleBildirimIslem(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncBildirimIslem(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BildirimHistories", "BildirimIslem", _bildirimIslem, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimIslem. When set to true, BildirimIslem is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimIslem is accessed. You can always execute a forced fetch by calling GetSingleBildirimIslem(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimIslem
		{
			get	{ return _alwaysFetchBildirimIslem; }
			set	{ _alwaysFetchBildirimIslem = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimIslem already has been fetched. Setting this property to false when BildirimIslem has been fetched
		/// will set BildirimIslem to null as well. Setting this property to true while BildirimIslem hasn't been fetched disables lazy loading for BildirimIslem</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimIslem
		{
			get { return _alreadyFetchedBildirimIslem;}
			set 
			{
				if(_alreadyFetchedBildirimIslem && !value)
				{
					this.BildirimIslem = null;
				}
				_alreadyFetchedBildirimIslem = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property BildirimIslem is not found
		/// in the database. When set to true, BildirimIslem will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool BildirimIslemReturnsNewIfNotFound
		{
			get	{ return _bildirimIslemReturnsNewIfNotFound; }
			set { _bildirimIslemReturnsNewIfNotFound = value; }	
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
					SetSingleRelatedEntityNavigator(value, "BildirimHistories", "Kullanici", _kullanici, true); 
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
			get { return (int)dhmi.EntityType.BildirimHistoryEntity; }
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
