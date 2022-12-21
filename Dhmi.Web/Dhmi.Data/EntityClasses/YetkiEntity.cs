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

	/// <summary>Entity class which represents the entity 'Yetki'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class YetkiEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.IslemOlusturCollection	_islemOlusturs;
		private bool	_alwaysFetchIslemOlusturs, _alreadyFetchedIslemOlusturs;
		private dhmi.CollectionClasses.KullaniciCollection	_kullanicis;
		private bool	_alwaysFetchKullanicis, _alreadyFetchedKullanicis;
		private dhmi.CollectionClasses.MenuOlusturCollection	_menuOlusturs;
		private bool	_alwaysFetchMenuOlusturs, _alreadyFetchedMenuOlusturs;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name IslemOlusturs</summary>
			public static readonly string IslemOlusturs = "IslemOlusturs";
			/// <summary>Member name Kullanicis</summary>
			public static readonly string Kullanicis = "Kullanicis";
			/// <summary>Member name MenuOlusturs</summary>
			public static readonly string MenuOlusturs = "MenuOlusturs";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static YetkiEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public YetkiEntity() :base("YetkiEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		public YetkiEntity(System.Int16 yetkiId):base("YetkiEntity")
		{
			InitClassFetch(yetkiId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public YetkiEntity(System.Int16 yetkiId, IPrefetchPath prefetchPathToUse):base("YetkiEntity")
		{
			InitClassFetch(yetkiId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="validator">The custom validator object for this YetkiEntity</param>
		public YetkiEntity(System.Int16 yetkiId, IValidator validator):base("YetkiEntity")
		{
			InitClassFetch(yetkiId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected YetkiEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_islemOlusturs = (dhmi.CollectionClasses.IslemOlusturCollection)info.GetValue("_islemOlusturs", typeof(dhmi.CollectionClasses.IslemOlusturCollection));
			_alwaysFetchIslemOlusturs = info.GetBoolean("_alwaysFetchIslemOlusturs");
			_alreadyFetchedIslemOlusturs = info.GetBoolean("_alreadyFetchedIslemOlusturs");

			_kullanicis = (dhmi.CollectionClasses.KullaniciCollection)info.GetValue("_kullanicis", typeof(dhmi.CollectionClasses.KullaniciCollection));
			_alwaysFetchKullanicis = info.GetBoolean("_alwaysFetchKullanicis");
			_alreadyFetchedKullanicis = info.GetBoolean("_alreadyFetchedKullanicis");

			_menuOlusturs = (dhmi.CollectionClasses.MenuOlusturCollection)info.GetValue("_menuOlusturs", typeof(dhmi.CollectionClasses.MenuOlusturCollection));
			_alwaysFetchMenuOlusturs = info.GetBoolean("_alwaysFetchMenuOlusturs");
			_alreadyFetchedMenuOlusturs = info.GetBoolean("_alreadyFetchedMenuOlusturs");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedIslemOlusturs = (_islemOlusturs.Count > 0);
			_alreadyFetchedKullanicis = (_kullanicis.Count > 0);
			_alreadyFetchedMenuOlusturs = (_menuOlusturs.Count > 0);
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
				case "IslemOlusturs":
					toReturn.Add(Relations.IslemOlusturEntityUsingFkYetkiId);
					break;
				case "Kullanicis":
					toReturn.Add(Relations.KullaniciEntityUsingFkYetkiId);
					break;
				case "MenuOlusturs":
					toReturn.Add(Relations.MenuOlusturEntityUsingFkYetkiId);
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
			info.AddValue("_islemOlusturs", (!this.MarkedForDeletion?_islemOlusturs:null));
			info.AddValue("_alwaysFetchIslemOlusturs", _alwaysFetchIslemOlusturs);
			info.AddValue("_alreadyFetchedIslemOlusturs", _alreadyFetchedIslemOlusturs);
			info.AddValue("_kullanicis", (!this.MarkedForDeletion?_kullanicis:null));
			info.AddValue("_alwaysFetchKullanicis", _alwaysFetchKullanicis);
			info.AddValue("_alreadyFetchedKullanicis", _alreadyFetchedKullanicis);
			info.AddValue("_menuOlusturs", (!this.MarkedForDeletion?_menuOlusturs:null));
			info.AddValue("_alwaysFetchMenuOlusturs", _alwaysFetchMenuOlusturs);
			info.AddValue("_alreadyFetchedMenuOlusturs", _alreadyFetchedMenuOlusturs);

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
				case "IslemOlusturs":
					_alreadyFetchedIslemOlusturs = true;
					if(entity!=null)
					{
						this.IslemOlusturs.Add((IslemOlusturEntity)entity);
					}
					break;
				case "Kullanicis":
					_alreadyFetchedKullanicis = true;
					if(entity!=null)
					{
						this.Kullanicis.Add((KullaniciEntity)entity);
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
				case "IslemOlusturs":
					_islemOlusturs.Add((IslemOlusturEntity)relatedEntity);
					break;
				case "Kullanicis":
					_kullanicis.Add((KullaniciEntity)relatedEntity);
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
				case "IslemOlusturs":
					this.PerformRelatedEntityRemoval(_islemOlusturs, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Kullanicis":
					this.PerformRelatedEntityRemoval(_kullanicis, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_islemOlusturs);
			toReturn.Add(_kullanicis);
			toReturn.Add(_menuOlusturs);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 yetkiId)
		{
			return FetchUsingPK(yetkiId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 yetkiId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(yetkiId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 yetkiId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(yetkiId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 yetkiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(yetkiId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.YetkiId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new YetkiRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'IslemOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IslemOlusturEntity'</returns>
		public dhmi.CollectionClasses.IslemOlusturCollection GetMultiIslemOlusturs(bool forceFetch)
		{
			return GetMultiIslemOlusturs(forceFetch, _islemOlusturs.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IslemOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IslemOlusturEntity'</returns>
		public dhmi.CollectionClasses.IslemOlusturCollection GetMultiIslemOlusturs(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiIslemOlusturs(forceFetch, _islemOlusturs.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'IslemOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.IslemOlusturCollection GetMultiIslemOlusturs(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiIslemOlusturs(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'IslemOlusturEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.IslemOlusturCollection GetMultiIslemOlusturs(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIslemOlusturs || forceFetch || _alwaysFetchIslemOlusturs) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_islemOlusturs);
				_islemOlusturs.SuppressClearInGetMulti=!forceFetch;
				_islemOlusturs.EntityFactoryToUse = entityFactoryToUse;
				_islemOlusturs.GetMultiManyToOne(null, this, filter);
				_islemOlusturs.SuppressClearInGetMulti=false;
				_alreadyFetchedIslemOlusturs = true;
			}
			return _islemOlusturs;
		}

		/// <summary> Sets the collection parameters for the collection for 'IslemOlusturs'. These settings will be taken into account
		/// when the property IslemOlusturs is requested or GetMultiIslemOlusturs is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIslemOlusturs(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_islemOlusturs.SortClauses=sortClauses;
			_islemOlusturs.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'KullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'KullaniciEntity'</returns>
		public dhmi.CollectionClasses.KullaniciCollection GetMultiKullanicis(bool forceFetch)
		{
			return GetMultiKullanicis(forceFetch, _kullanicis.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'KullaniciEntity'</returns>
		public dhmi.CollectionClasses.KullaniciCollection GetMultiKullanicis(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiKullanicis(forceFetch, _kullanicis.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'KullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.KullaniciCollection GetMultiKullanicis(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiKullanicis(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KullaniciEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.KullaniciCollection GetMultiKullanicis(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedKullanicis || forceFetch || _alwaysFetchKullanicis) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_kullanicis);
				_kullanicis.SuppressClearInGetMulti=!forceFetch;
				_kullanicis.EntityFactoryToUse = entityFactoryToUse;
				_kullanicis.GetMultiManyToOne(null, null, this, filter);
				_kullanicis.SuppressClearInGetMulti=false;
				_alreadyFetchedKullanicis = true;
			}
			return _kullanicis;
		}

		/// <summary> Sets the collection parameters for the collection for 'Kullanicis'. These settings will be taken into account
		/// when the property Kullanicis is requested or GetMultiKullanicis is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersKullanicis(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_kullanicis.SortClauses=sortClauses;
			_kullanicis.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_menuOlusturs.GetMultiManyToOne(null, null, null, this, filter);
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("IslemOlusturs", _islemOlusturs);
			toReturn.Add("Kullanicis", _kullanicis);
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
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="validator">The validator object for this YetkiEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 yetkiId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(yetkiId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_islemOlusturs = new dhmi.CollectionClasses.IslemOlusturCollection();
			_islemOlusturs.SetContainingEntityInfo(this, "Yetki");

			_kullanicis = new dhmi.CollectionClasses.KullaniciCollection();
			_kullanicis.SetContainingEntityInfo(this, "Yetki");

			_menuOlusturs = new dhmi.CollectionClasses.MenuOlusturCollection();
			_menuOlusturs.SetContainingEntityInfo(this, "Yetki");
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
			_fieldsCustomProperties.Add("YetkiAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("YetkiAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("YetkiDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("YetkiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("YetkiTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="yetkiId">PK value for Yetki which data should be fetched into this Yetki object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 yetkiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)YetkiFieldIndex.YetkiId].ForcedCurrentValueWrite(yetkiId);
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
			return DAOFactory.CreateYetkiDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new YetkiEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static YetkiRelations Relations
		{
			get	{ return new YetkiRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'IslemOlustur' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathIslemOlusturs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.IslemOlusturCollection(), (IEntityRelation)GetRelationsForField("IslemOlusturs")[0], (int)dhmi.EntityType.YetkiEntity, (int)dhmi.EntityType.IslemOlusturEntity, 0, null, null, null, "IslemOlusturs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanicis
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanicis")[0], (int)dhmi.EntityType.YetkiEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanicis", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MenuOlustur' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMenuOlusturs
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.MenuOlusturCollection(), (IEntityRelation)GetRelationsForField("MenuOlusturs")[0], (int)dhmi.EntityType.YetkiEntity, (int)dhmi.EntityType.MenuOlusturEntity, 0, null, null, null, "MenuOlusturs", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The YetkiAciklama property of the Entity Yetki<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Yetki"."Yetki_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String YetkiAciklama
		{
			get { return (System.String)GetValue((int)YetkiFieldIndex.YetkiAciklama, true); }
			set	{ SetValue((int)YetkiFieldIndex.YetkiAciklama, value, true); }
		}

		/// <summary> The YetkiAd property of the Entity Yetki<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Yetki"."Yetki_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String YetkiAd
		{
			get { return (System.String)GetValue((int)YetkiFieldIndex.YetkiAd, true); }
			set	{ SetValue((int)YetkiFieldIndex.YetkiAd, value, true); }
		}

		/// <summary> The YetkiDurum property of the Entity Yetki<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Yetki"."Yetki_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean YetkiDurum
		{
			get { return (System.Boolean)GetValue((int)YetkiFieldIndex.YetkiDurum, true); }
			set	{ SetValue((int)YetkiFieldIndex.YetkiDurum, value, true); }
		}

		/// <summary> The YetkiId property of the Entity Yetki<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Yetki"."Yetki_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 YetkiId
		{
			get { return (System.Int16)GetValue((int)YetkiFieldIndex.YetkiId, true); }
			set	{ SetValue((int)YetkiFieldIndex.YetkiId, value, true); }
		}

		/// <summary> The YetkiTarih property of the Entity Yetki<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Yetki"."Yetki_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime YetkiTarih
		{
			get { return (System.DateTime)GetValue((int)YetkiFieldIndex.YetkiTarih, true); }
			set	{ SetValue((int)YetkiFieldIndex.YetkiTarih, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'IslemOlusturEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIslemOlusturs()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.IslemOlusturCollection IslemOlusturs
		{
			get	{ return GetMultiIslemOlusturs(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for IslemOlusturs. When set to true, IslemOlusturs is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time IslemOlusturs is accessed. You can always execute/ a forced fetch by calling GetMultiIslemOlusturs(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchIslemOlusturs
		{
			get	{ return _alwaysFetchIslemOlusturs; }
			set	{ _alwaysFetchIslemOlusturs = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property IslemOlusturs already has been fetched. Setting this property to false when IslemOlusturs has been fetched
		/// will clear the IslemOlusturs collection well. Setting this property to true while IslemOlusturs hasn't been fetched disables lazy loading for IslemOlusturs</summary>
		[Browsable(false)]
		public bool AlreadyFetchedIslemOlusturs
		{
			get { return _alreadyFetchedIslemOlusturs;}
			set 
			{
				if(_alreadyFetchedIslemOlusturs && !value && (_islemOlusturs != null))
				{
					_islemOlusturs.Clear();
				}
				_alreadyFetchedIslemOlusturs = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'KullaniciEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiKullanicis()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.KullaniciCollection Kullanicis
		{
			get	{ return GetMultiKullanicis(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Kullanicis. When set to true, Kullanicis is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Kullanicis is accessed. You can always execute/ a forced fetch by calling GetMultiKullanicis(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKullanicis
		{
			get	{ return _alwaysFetchKullanicis; }
			set	{ _alwaysFetchKullanicis = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Kullanicis already has been fetched. Setting this property to false when Kullanicis has been fetched
		/// will clear the Kullanicis collection well. Setting this property to true while Kullanicis hasn't been fetched disables lazy loading for Kullanicis</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKullanicis
		{
			get { return _alreadyFetchedKullanicis;}
			set 
			{
				if(_alreadyFetchedKullanicis && !value && (_kullanicis != null))
				{
					_kullanicis.Clear();
				}
				_alreadyFetchedKullanicis = value;
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
			get { return (int)dhmi.EntityType.YetkiEntity; }
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
