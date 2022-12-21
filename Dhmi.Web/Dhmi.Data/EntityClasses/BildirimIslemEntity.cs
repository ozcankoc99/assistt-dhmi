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

	/// <summary>Entity class which represents the entity 'BildirimIslem'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class BildirimIslemEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.BildirimHistoryCollection	_bildirimHistories;
		private bool	_alwaysFetchBildirimHistories, _alreadyFetchedBildirimHistories;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BildirimHistories</summary>
			public static readonly string BildirimHistories = "BildirimHistories";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BildirimIslemEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public BildirimIslemEntity() :base("BildirimIslemEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		public BildirimIslemEntity(System.Int16 bildirimIslemId):base("BildirimIslemEntity")
		{
			InitClassFetch(bildirimIslemId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public BildirimIslemEntity(System.Int16 bildirimIslemId, IPrefetchPath prefetchPathToUse):base("BildirimIslemEntity")
		{
			InitClassFetch(bildirimIslemId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="validator">The custom validator object for this BildirimIslemEntity</param>
		public BildirimIslemEntity(System.Int16 bildirimIslemId, IValidator validator):base("BildirimIslemEntity")
		{
			InitClassFetch(bildirimIslemId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BildirimIslemEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_bildirimHistories = (dhmi.CollectionClasses.BildirimHistoryCollection)info.GetValue("_bildirimHistories", typeof(dhmi.CollectionClasses.BildirimHistoryCollection));
			_alwaysFetchBildirimHistories = info.GetBoolean("_alwaysFetchBildirimHistories");
			_alreadyFetchedBildirimHistories = info.GetBoolean("_alreadyFetchedBildirimHistories");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedBildirimHistories = (_bildirimHistories.Count > 0);
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
				case "BildirimHistories":
					toReturn.Add(Relations.BildirimHistoryEntityUsingFkBildirimIslemId);
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
			info.AddValue("_bildirimHistories", (!this.MarkedForDeletion?_bildirimHistories:null));
			info.AddValue("_alwaysFetchBildirimHistories", _alwaysFetchBildirimHistories);
			info.AddValue("_alreadyFetchedBildirimHistories", _alreadyFetchedBildirimHistories);

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
				case "BildirimHistories":
					_alreadyFetchedBildirimHistories = true;
					if(entity!=null)
					{
						this.BildirimHistories.Add((BildirimHistoryEntity)entity);
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
				case "BildirimHistories":
					_bildirimHistories.Add((BildirimHistoryEntity)relatedEntity);
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
				case "BildirimHistories":
					this.PerformRelatedEntityRemoval(_bildirimHistories, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_bildirimHistories);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 bildirimIslemId)
		{
			return FetchUsingPK(bildirimIslemId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 bildirimIslemId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(bildirimIslemId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 bildirimIslemId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(bildirimIslemId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 bildirimIslemId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(bildirimIslemId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.BildirimIslemId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BildirimIslemRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BildirimHistoryEntity'</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch)
		{
			return GetMultiBildirimHistories(forceFetch, _bildirimHistories.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BildirimHistoryEntity'</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiBildirimHistories(forceFetch, _bildirimHistories.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiBildirimHistories(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.BildirimHistoryCollection GetMultiBildirimHistories(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBildirimHistories || forceFetch || _alwaysFetchBildirimHistories) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_bildirimHistories);
				_bildirimHistories.SuppressClearInGetMulti=!forceFetch;
				_bildirimHistories.EntityFactoryToUse = entityFactoryToUse;
				_bildirimHistories.GetMultiManyToOne(null, this, null, filter);
				_bildirimHistories.SuppressClearInGetMulti=false;
				_alreadyFetchedBildirimHistories = true;
			}
			return _bildirimHistories;
		}

		/// <summary> Sets the collection parameters for the collection for 'BildirimHistories'. These settings will be taken into account
		/// when the property BildirimHistories is requested or GetMultiBildirimHistories is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBildirimHistories(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_bildirimHistories.SortClauses=sortClauses;
			_bildirimHistories.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BildirimHistories", _bildirimHistories);
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
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="validator">The validator object for this BildirimIslemEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 bildirimIslemId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(bildirimIslemId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_bildirimHistories = new dhmi.CollectionClasses.BildirimHistoryCollection();
			_bildirimHistories.SetContainingEntityInfo(this, "BildirimIslem");
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
			_fieldsCustomProperties.Add("BildirimIslemAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimIslemDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimIslemId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BildirimIslemTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="bildirimIslemId">PK value for BildirimIslem which data should be fetched into this BildirimIslem object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 bildirimIslemId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)BildirimIslemFieldIndex.BildirimIslemId].ForcedCurrentValueWrite(bildirimIslemId);
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
			return DAOFactory.CreateBildirimIslemDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new BildirimIslemEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BildirimIslemRelations Relations
		{
			get	{ return new BildirimIslemRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'BildirimHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathBildirimHistories
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.BildirimHistoryCollection(), (IEntityRelation)GetRelationsForField("BildirimHistories")[0], (int)dhmi.EntityType.BildirimIslemEntity, (int)dhmi.EntityType.BildirimHistoryEntity, 0, null, null, null, "BildirimHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The BildirimIslemAd property of the Entity BildirimIslem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_Islem"."Bildirim_Islem_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String BildirimIslemAd
		{
			get { return (System.String)GetValue((int)BildirimIslemFieldIndex.BildirimIslemAd, true); }
			set	{ SetValue((int)BildirimIslemFieldIndex.BildirimIslemAd, value, true); }
		}

		/// <summary> The BildirimIslemDurum property of the Entity BildirimIslem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_Islem"."Bildirim_Islem_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean BildirimIslemDurum
		{
			get { return (System.Boolean)GetValue((int)BildirimIslemFieldIndex.BildirimIslemDurum, true); }
			set	{ SetValue((int)BildirimIslemFieldIndex.BildirimIslemDurum, value, true); }
		}

		/// <summary> The BildirimIslemId property of the Entity BildirimIslem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_Islem"."Bildirim_Islem_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 BildirimIslemId
		{
			get { return (System.Int16)GetValue((int)BildirimIslemFieldIndex.BildirimIslemId, true); }
			set	{ SetValue((int)BildirimIslemFieldIndex.BildirimIslemId, value, true); }
		}

		/// <summary> The BildirimIslemTarih property of the Entity BildirimIslem<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Bildirim_Islem"."Bildirim_Islem_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BildirimIslemTarih
		{
			get { return (System.DateTime)GetValue((int)BildirimIslemFieldIndex.BildirimIslemTarih, true); }
			set	{ SetValue((int)BildirimIslemFieldIndex.BildirimIslemTarih, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'BildirimHistoryEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBildirimHistories()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.BildirimHistoryCollection BildirimHistories
		{
			get	{ return GetMultiBildirimHistories(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for BildirimHistories. When set to true, BildirimHistories is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BildirimHistories is accessed. You can always execute/ a forced fetch by calling GetMultiBildirimHistories(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchBildirimHistories
		{
			get	{ return _alwaysFetchBildirimHistories; }
			set	{ _alwaysFetchBildirimHistories = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property BildirimHistories already has been fetched. Setting this property to false when BildirimHistories has been fetched
		/// will clear the BildirimHistories collection well. Setting this property to true while BildirimHistories hasn't been fetched disables lazy loading for BildirimHistories</summary>
		[Browsable(false)]
		public bool AlreadyFetchedBildirimHistories
		{
			get { return _alreadyFetchedBildirimHistories;}
			set 
			{
				if(_alreadyFetchedBildirimHistories && !value && (_bildirimHistories != null))
				{
					_bildirimHistories.Clear();
				}
				_alreadyFetchedBildirimHistories = value;
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
			get { return (int)dhmi.EntityType.BildirimIslemEntity; }
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
