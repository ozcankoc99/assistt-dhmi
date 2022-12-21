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

	/// <summary>Entity class which represents the entity 'HiyerarsiTur'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class HiyerarsiTurEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private dhmi.CollectionClasses.KullaniciCollection	_kullanicis;
		private bool	_alwaysFetchKullanicis, _alreadyFetchedKullanicis;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Kullanicis</summary>
			public static readonly string Kullanicis = "Kullanicis";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static HiyerarsiTurEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public HiyerarsiTurEntity() :base("HiyerarsiTurEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		public HiyerarsiTurEntity(System.Int16 hiyerarsiTurId):base("HiyerarsiTurEntity")
		{
			InitClassFetch(hiyerarsiTurId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public HiyerarsiTurEntity(System.Int16 hiyerarsiTurId, IPrefetchPath prefetchPathToUse):base("HiyerarsiTurEntity")
		{
			InitClassFetch(hiyerarsiTurId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="validator">The custom validator object for this HiyerarsiTurEntity</param>
		public HiyerarsiTurEntity(System.Int16 hiyerarsiTurId, IValidator validator):base("HiyerarsiTurEntity")
		{
			InitClassFetch(hiyerarsiTurId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected HiyerarsiTurEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_kullanicis = (dhmi.CollectionClasses.KullaniciCollection)info.GetValue("_kullanicis", typeof(dhmi.CollectionClasses.KullaniciCollection));
			_alwaysFetchKullanicis = info.GetBoolean("_alwaysFetchKullanicis");
			_alreadyFetchedKullanicis = info.GetBoolean("_alreadyFetchedKullanicis");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedKullanicis = (_kullanicis.Count > 0);
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
				case "Kullanicis":
					toReturn.Add(Relations.KullaniciEntityUsingFkHiyerarsiTurId);
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
			info.AddValue("_kullanicis", (!this.MarkedForDeletion?_kullanicis:null));
			info.AddValue("_alwaysFetchKullanicis", _alwaysFetchKullanicis);
			info.AddValue("_alreadyFetchedKullanicis", _alreadyFetchedKullanicis);

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
				case "Kullanicis":
					_alreadyFetchedKullanicis = true;
					if(entity!=null)
					{
						this.Kullanicis.Add((KullaniciEntity)entity);
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
				case "Kullanicis":
					_kullanicis.Add((KullaniciEntity)relatedEntity);
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
				case "Kullanicis":
					this.PerformRelatedEntityRemoval(_kullanicis, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_kullanicis);

			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 hiyerarsiTurId)
		{
			return FetchUsingPK(hiyerarsiTurId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 hiyerarsiTurId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(hiyerarsiTurId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 hiyerarsiTurId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(hiyerarsiTurId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int16 hiyerarsiTurId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(hiyerarsiTurId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.HiyerarsiTurId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new HiyerarsiTurRelations().GetAllRelations();
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
				_kullanicis.GetMultiManyToOne(null, this, null, filter);
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


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Kullanicis", _kullanicis);
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
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="validator">The validator object for this HiyerarsiTurEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int16 hiyerarsiTurId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(hiyerarsiTurId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{

			_kullanicis = new dhmi.CollectionClasses.KullaniciCollection();
			_kullanicis.SetContainingEntityInfo(this, "HiyerarsiTur");
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
			_fieldsCustomProperties.Add("HiyerarsiTurAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HiyerarsiTurDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HiyerarsiTurId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HiyerarsiTurSira", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HiyerarsiTurTarih", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="hiyerarsiTurId">PK value for HiyerarsiTur which data should be fetched into this HiyerarsiTur object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int16 hiyerarsiTurId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)HiyerarsiTurFieldIndex.HiyerarsiTurId].ForcedCurrentValueWrite(hiyerarsiTurId);
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
			return DAOFactory.CreateHiyerarsiTurDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new HiyerarsiTurEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static HiyerarsiTurRelations Relations
		{
			get	{ return new HiyerarsiTurRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Kullanici' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathKullanicis
		{
			get { return new PrefetchPathElement(new dhmi.CollectionClasses.KullaniciCollection(), (IEntityRelation)GetRelationsForField("Kullanicis")[0], (int)dhmi.EntityType.HiyerarsiTurEntity, (int)dhmi.EntityType.KullaniciEntity, 0, null, null, null, "Kullanicis", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany); }
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

		/// <summary> The HiyerarsiTurAd property of the Entity HiyerarsiTur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Hiyerarsi_Tur"."Hiyerarsi_Tur_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String HiyerarsiTurAd
		{
			get { return (System.String)GetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurAd, true); }
			set	{ SetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurAd, value, true); }
		}

		/// <summary> The HiyerarsiTurDurum property of the Entity HiyerarsiTur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Hiyerarsi_Tur"."Hiyerarsi_Tur_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean HiyerarsiTurDurum
		{
			get { return (System.Boolean)GetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurDurum, true); }
			set	{ SetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurDurum, value, true); }
		}

		/// <summary> The HiyerarsiTurId property of the Entity HiyerarsiTur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Hiyerarsi_Tur"."Hiyerarsi_Tur_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int16 HiyerarsiTurId
		{
			get { return (System.Int16)GetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurId, true); }
			set	{ SetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurId, value, true); }
		}

		/// <summary> The HiyerarsiTurSira property of the Entity HiyerarsiTur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Hiyerarsi_Tur"."Hiyerarsi_Tur_Sira"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 HiyerarsiTurSira
		{
			get { return (System.Int16)GetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurSira, true); }
			set	{ SetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurSira, value, true); }
		}

		/// <summary> The HiyerarsiTurTarih property of the Entity HiyerarsiTur<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Hiyerarsi_Tur"."Hiyerarsi_Tur_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HiyerarsiTurTarih
		{
			get { return (System.DateTime)GetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurTarih, true); }
			set	{ SetValue((int)HiyerarsiTurFieldIndex.HiyerarsiTurTarih, value, true); }
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
			get { return (int)dhmi.EntityType.HiyerarsiTurEntity; }
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
