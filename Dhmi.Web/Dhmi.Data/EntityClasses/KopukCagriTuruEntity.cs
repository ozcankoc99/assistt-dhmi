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

	/// <summary>Entity class which represents the entity 'KopukCagriTuru'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KopukCagriTuruEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.KopukCagriCollection	_kopukCagris;
		private bool	_alwaysFetchKopukCagris, _alreadyFetchedKopukCagris;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name KopukCagris</summary>
			public static readonly string KopukCagris = "KopukCagris";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static KopukCagriTuruEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public KopukCagriTuruEntity() :base("KopukCagriTuruEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		public KopukCagriTuruEntity(System.Int16 kopukCagriTuruId):base("KopukCagriTuruEntity")
		{
			InitClassFetch(kopukCagriTuruId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public KopukCagriTuruEntity(System.Int16 kopukCagriTuruId, IPrefetchPath prefetchPathToUse):base("KopukCagriTuruEntity")
		{
			InitClassFetch(kopukCagriTuruId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="validator">The custom validator object for this KopukCagriTuruEntity</param>
		public KopukCagriTuruEntity(System.Int16 kopukCagriTuruId, IValidator validator):base("KopukCagriTuruEntity")
		{
			InitClassFetch(kopukCagriTuruId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected KopukCagriTuruEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_kopukCagris = (dhmi.CollectionClasses.KopukCagriCollection)info.GetValue("_kopukCagris", typeof(dhmi.CollectionClasses.KopukCagriCollection));
			_alwaysFetchKopukCagris = info.GetBoolean("_alwaysFetchKopukCagris");
			_alreadyFetchedKopukCagris = info.GetBoolean("_alreadyFetchedKopukCagris");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedKopukCagris = (_kopukCagris.Count > 0);
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
				case "KopukCagris":
					toReturn.Add(Relations.KopukCagriEntityUsingFkKopukCagriTuruId);
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
			info.AddValue("_kopukCagris", (!this.MarkedForDeletion?_kopukCagris:null));
			info.AddValue("_alwaysFetchKopukCagris", _alwaysFetchKopukCagris);
			info.AddValue("_alreadyFetchedKopukCagris", _alreadyFetchedKopukCagris);

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
				case "KopukCagris":
					_alreadyFetchedKopukCagris = true;
					if(entity!=null)
					{
						this.KopukCagris.Add((KopukCagriEntity)entity);
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
				case "KopukCagris":
					_kopukCagris.Add((KopukCagriEntity)relatedEntity);
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
				case "KopukCagris":
					this.PerformRelatedEntityRemoval(_kopukCagris, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_kopukCagris);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kopukCagriTuruId)
		{
			return FetchUsingPK(kopukCagriTuruId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kopukCagriTuruId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(kopukCagriTuruId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kopukCagriTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(kopukCagriTuruId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 kopukCagriTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(kopukCagriTuruId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.KopukCagriTuruId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new KopukCagriTuruRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'KopukCagriEntity'</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch)
		{
			return GetMultiKopukCagris(forceFetch, _kopukCagris.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'KopukCagriEntity'</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiKopukCagris(forceFetch, _kopukCagris.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiKopukCagris(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.KopukCagriCollection GetMultiKopukCagris(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedKopukCagris || forceFetch || _alwaysFetchKopukCagris) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_kopukCagris);
				_kopukCagris.SuppressClearInGetMulti=!forceFetch;
				_kopukCagris.EntityFactoryToUse = entityFactoryToUse;
				_kopukCagris.GetMultiManyToOne(this, null, filter);
				_kopukCagris.SuppressClearInGetMulti=false;
				_alreadyFetchedKopukCagris = true;
			}
			return _kopukCagris;
		}

		/// <summary> Sets the collection parameters for the collection for 'KopukCagris'. These settings will be taken into account
		/// when the property KopukCagris is requested or GetMultiKopukCagris is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersKopukCagris(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_kopukCagris.SortClauses=sortClauses;
			_kopukCagris.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("KopukCagris", _kopukCagris);
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
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="validator">The validator object for this KopukCagriTuruEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 kopukCagriTuruId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(kopukCagriTuruId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_kopukCagris = new dhmi.CollectionClasses.KopukCagriCollection();
			_kopukCagris.SetContainingEntityInfo(this, "KopukCagriTuru");
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
			_fieldsCustomProperties.Add("KopukCagriTuruAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KopukCagriTuruDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KopukCagriTuruId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KopukCagriTuruTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="kopukCagriTuruId">PK value for KopukCagriTuru which data should be fetched into this KopukCagriTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 kopukCagriTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)KopukCagriTuruFieldIndex.KopukCagriTuruId].ForcedCurrentValueWrite(kopukCagriTuruId);
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
			return DAOFactory.CreateKopukCagriTuruDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new KopukCagriTuruEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static KopukCagriTuruRelations Relations
		{
			get	{ return new KopukCagriTuruRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'KopukCagri' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKopukCagris
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KopukCagriCollection(), (IEntityRelation)GetRelationsForField("KopukCagris")[0], (int)dhmi.EntityType.KopukCagriTuruEntity, (int)dhmi.EntityType.KopukCagriEntity, 0, null, null, null, "KopukCagris", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The KopukCagriTuruAd property of the Entity KopukCagriTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kopuk_Cagri_Turu"."Kopuk_Cagri_Turu_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KopukCagriTuruAd
		{
			get { return (System.String)GetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruAd, true); }
			set	{ SetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruAd, value, true); }
		}

		/// <summary> The KopukCagriTuruDurum property of the Entity KopukCagriTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kopuk_Cagri_Turu"."Kopuk_Cagri_Turu_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean KopukCagriTuruDurum
		{
			get { return (System.Boolean)GetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruDurum, true); }
			set	{ SetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruDurum, value, true); }
		}

		/// <summary> The KopukCagriTuruId property of the Entity KopukCagriTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kopuk_Cagri_Turu"."Kopuk_Cagri_Turu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 KopukCagriTuruId
		{
			get { return (System.Int16)GetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruId, true); }
			set	{ SetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruId, value, true); }
		}

		/// <summary> The KopukCagriTuruTarih property of the Entity KopukCagriTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kopuk_Cagri_Turu"."Kopuk_Cagri_Turu_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime KopukCagriTuruTarih
		{
			get { return (System.DateTime)GetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruTarih, true); }
			set	{ SetValue((int)KopukCagriTuruFieldIndex.KopukCagriTuruTarih, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'KopukCagriEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiKopukCagris()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.KopukCagriCollection KopukCagris
		{
			get	{ return GetMultiKopukCagris(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for KopukCagris. When set to true, KopukCagris is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time KopukCagris is accessed. You can always execute/ a forced fetch by calling GetMultiKopukCagris(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchKopukCagris
		{
			get	{ return _alwaysFetchKopukCagris; }
			set	{ _alwaysFetchKopukCagris = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property KopukCagris already has been fetched. Setting this property to false when KopukCagris has been fetched
		/// will clear the KopukCagris collection well. Setting this property to true while KopukCagris hasn't been fetched disables lazy loading for KopukCagris</summary>
		[Browsable(false)]
		public bool AlreadyFetchedKopukCagris
		{
			get { return _alreadyFetchedKopukCagris;}
			set 
			{
				if(_alreadyFetchedKopukCagris && !value && (_kopukCagris != null))
				{
					_kopukCagris.Clear();
				}
				_alreadyFetchedKopukCagris = value;
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
			get { return (int)dhmi.EntityType.KopukCagriTuruEntity; }
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
