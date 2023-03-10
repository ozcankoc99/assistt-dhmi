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

	/// <summary>Entity class which represents the entity 'SorunTuru'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class SorunTuruEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.SorunCollection	_soruns;
		private bool	_alwaysFetchSoruns, _alreadyFetchedSoruns;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Soruns</summary>
			public static readonly string Soruns = "Soruns";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SorunTuruEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public SorunTuruEntity() :base("SorunTuruEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		public SorunTuruEntity(System.Int16 sorunTuruId):base("SorunTuruEntity")
		{
			InitClassFetch(sorunTuruId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public SorunTuruEntity(System.Int16 sorunTuruId, IPrefetchPath prefetchPathToUse):base("SorunTuruEntity")
		{
			InitClassFetch(sorunTuruId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="validator">The custom validator object for this SorunTuruEntity</param>
		public SorunTuruEntity(System.Int16 sorunTuruId, IValidator validator):base("SorunTuruEntity")
		{
			InitClassFetch(sorunTuruId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SorunTuruEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_soruns = (dhmi.CollectionClasses.SorunCollection)info.GetValue("_soruns", typeof(dhmi.CollectionClasses.SorunCollection));
			_alwaysFetchSoruns = info.GetBoolean("_alwaysFetchSoruns");
			_alreadyFetchedSoruns = info.GetBoolean("_alreadyFetchedSoruns");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedSoruns = (_soruns.Count > 0);
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
				case "Soruns":
					toReturn.Add(Relations.SorunEntityUsingFkSorunTuruId);
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
			info.AddValue("_soruns", (!this.MarkedForDeletion?_soruns:null));
			info.AddValue("_alwaysFetchSoruns", _alwaysFetchSoruns);
			info.AddValue("_alreadyFetchedSoruns", _alreadyFetchedSoruns);

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
				case "Soruns":
					_alreadyFetchedSoruns = true;
					if(entity!=null)
					{
						this.Soruns.Add((SorunEntity)entity);
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
				case "Soruns":
					_soruns.Add((SorunEntity)relatedEntity);
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
				case "Soruns":
					this.PerformRelatedEntityRemoval(_soruns, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_soruns);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 sorunTuruId)
		{
			return FetchUsingPK(sorunTuruId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 sorunTuruId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(sorunTuruId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 sorunTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(sorunTuruId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 sorunTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(sorunTuruId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.SorunTuruId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SorunTuruRelations().GetAllRelations();
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SorunEntity'</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch)
		{
			return GetMultiSoruns(forceFetch, _soruns.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SorunEntity'</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiSoruns(forceFetch, _soruns.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiSoruns(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual dhmi.CollectionClasses.SorunCollection GetMultiSoruns(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSoruns || forceFetch || _alwaysFetchSoruns) && !this.IsSerializing && !this.IsDeserializing && !this.InDesignMode)
			{
				AddToTransactionIfNecessary(_soruns);
				_soruns.SuppressClearInGetMulti=!forceFetch;
				_soruns.EntityFactoryToUse = entityFactoryToUse;
				_soruns.GetMultiManyToOne(null, this, filter);
				_soruns.SuppressClearInGetMulti=false;
				_alreadyFetchedSoruns = true;
			}
			return _soruns;
		}

		/// <summary> Sets the collection parameters for the collection for 'Soruns'. These settings will be taken into account
		/// when the property Soruns is requested or GetMultiSoruns is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSoruns(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_soruns.SortClauses=sortClauses;
			_soruns.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Soruns", _soruns);
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
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="validator">The validator object for this SorunTuruEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 sorunTuruId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(sorunTuruId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_soruns = new dhmi.CollectionClasses.SorunCollection();
			_soruns.SetContainingEntityInfo(this, "SorunTuru");
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
			_fieldsCustomProperties.Add("SorunTuruAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SorunTuruDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SorunTuruId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SorunTuruTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="sorunTuruId">PK value for SorunTuru which data should be fetched into this SorunTuru object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 sorunTuruId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)SorunTuruFieldIndex.SorunTuruId].ForcedCurrentValueWrite(sorunTuruId);
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
			return DAOFactory.CreateSorunTuruDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new SorunTuruEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SorunTuruRelations Relations
		{
			get	{ return new SorunTuruRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sorun' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathSoruns
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.SorunCollection(), (IEntityRelation)GetRelationsForField("Soruns")[0], (int)dhmi.EntityType.SorunTuruEntity, (int)dhmi.EntityType.SorunEntity, 0, null, null, null, "Soruns", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The SorunTuruAd property of the Entity SorunTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Sorun_Turu"."Sorun_Turu_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String SorunTuruAd
		{
			get { return (System.String)GetValue((int)SorunTuruFieldIndex.SorunTuruAd, true); }
			set	{ SetValue((int)SorunTuruFieldIndex.SorunTuruAd, value, true); }
		}

		/// <summary> The SorunTuruDurum property of the Entity SorunTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Sorun_Turu"."Sorun_Turu_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SorunTuruDurum
		{
			get { return (System.Boolean)GetValue((int)SorunTuruFieldIndex.SorunTuruDurum, true); }
			set	{ SetValue((int)SorunTuruFieldIndex.SorunTuruDurum, value, true); }
		}

		/// <summary> The SorunTuruId property of the Entity SorunTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Sorun_Turu"."Sorun_Turu_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 SorunTuruId
		{
			get { return (System.Int16)GetValue((int)SorunTuruFieldIndex.SorunTuruId, true); }
			set	{ SetValue((int)SorunTuruFieldIndex.SorunTuruId, value, true); }
		}

		/// <summary> The SorunTuruTarih property of the Entity SorunTuru<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Sorun_Turu"."Sorun_Turu_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SorunTuruTarih
		{
			get { return (System.DateTime)GetValue((int)SorunTuruFieldIndex.SorunTuruTarih, true); }
			set	{ SetValue((int)SorunTuruFieldIndex.SorunTuruTarih, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'SorunEntity' using a relation of type '1:n'.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSoruns()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual dhmi.CollectionClasses.SorunCollection Soruns
		{
			get	{ return GetMultiSoruns(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Soruns. When set to true, Soruns is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Soruns is accessed. You can always execute/ a forced fetch by calling GetMultiSoruns(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchSoruns
		{
			get	{ return _alwaysFetchSoruns; }
			set	{ _alwaysFetchSoruns = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Soruns already has been fetched. Setting this property to false when Soruns has been fetched
		/// will clear the Soruns collection well. Setting this property to true while Soruns hasn't been fetched disables lazy loading for Soruns</summary>
		[Browsable(false)]
		public bool AlreadyFetchedSoruns
		{
			get { return _alreadyFetchedSoruns;}
			set 
			{
				if(_alreadyFetchedSoruns && !value && (_soruns != null))
				{
					_soruns.Clear();
				}
				_alreadyFetchedSoruns = value;
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
			get { return (int)dhmi.EntityType.SorunTuruEntity; }
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
