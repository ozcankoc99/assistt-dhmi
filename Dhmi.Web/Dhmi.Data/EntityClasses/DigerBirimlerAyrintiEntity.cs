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

	/// <summary>Entity class which represents the entity 'DigerBirimlerAyrinti'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class DigerBirimlerAyrintiEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static DigerBirimlerAyrintiEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public DigerBirimlerAyrintiEntity() :base("DigerBirimlerAyrintiEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		public DigerBirimlerAyrintiEntity(System.Int64 digerBirimlerAyrintiId):base("DigerBirimlerAyrintiEntity")
		{
			InitClassFetch(digerBirimlerAyrintiId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public DigerBirimlerAyrintiEntity(System.Int64 digerBirimlerAyrintiId, IPrefetchPath prefetchPathToUse):base("DigerBirimlerAyrintiEntity")
		{
			InitClassFetch(digerBirimlerAyrintiId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="validator">The custom validator object for this DigerBirimlerAyrintiEntity</param>
		public DigerBirimlerAyrintiEntity(System.Int64 digerBirimlerAyrintiId, IValidator validator):base("DigerBirimlerAyrintiEntity")
		{
			InitClassFetch(digerBirimlerAyrintiId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DigerBirimlerAyrintiEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
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


			return toReturn;
		}


		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 digerBirimlerAyrintiId)
		{
			return FetchUsingPK(digerBirimlerAyrintiId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 digerBirimlerAyrintiId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(digerBirimlerAyrintiId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 digerBirimlerAyrintiId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(digerBirimlerAyrintiId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 digerBirimlerAyrintiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(digerBirimlerAyrintiId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DigerBirimlerAyrintiId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new DigerBirimlerAyrintiRelations().GetAllRelations();
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
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
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="validator">The validator object for this DigerBirimlerAyrintiEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 digerBirimlerAyrintiId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(digerBirimlerAyrintiId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
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
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiIcerik", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiKullaniciId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiSonDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DigerBirimlerAyrintiSure", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="digerBirimlerAyrintiId">PK value for DigerBirimlerAyrinti which data should be fetched into this DigerBirimlerAyrinti object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 digerBirimlerAyrintiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiId].ForcedCurrentValueWrite(digerBirimlerAyrintiId);
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
			return DAOFactory.CreateDigerBirimlerAyrintiDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new DigerBirimlerAyrintiEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static DigerBirimlerAyrintiRelations Relations
		{
			get	{ return new DigerBirimlerAyrintiRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
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

		/// <summary> The DigerBirimlerAyrintiDurum property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DigerBirimlerAyrintiDurum
		{
			get { return (System.String)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiDurum, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiDurum, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiIcerik property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_Icerik"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DigerBirimlerAyrintiIcerik
		{
			get { return (System.String)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiIcerik, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiIcerik, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiId property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 DigerBirimlerAyrintiId
		{
			get { return (System.Int64)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiId, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiId, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiKullaniciId property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_Kullanici_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 DigerBirimlerAyrintiKullaniciId
		{
			get { return (System.Int16)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiKullaniciId, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiKullaniciId, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiNo property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 DigerBirimlerAyrintiNo
		{
			get { return (System.Int64)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiNo, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiNo, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiSonDurum property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_Son_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DigerBirimlerAyrintiSonDurum
		{
			get { return (System.String)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSonDurum, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSonDurum, value, true); }
		}

		/// <summary> The DigerBirimlerAyrintiSure property of the Entity DigerBirimlerAyrinti<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Diger_Birimler_Ayrinti"."Diger_Birimler_Ayrinti_Sure"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DigerBirimlerAyrintiSure
		{
			get { return (System.String)GetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSure, true); }
			set	{ SetValue((int)DigerBirimlerAyrintiFieldIndex.DigerBirimlerAyrintiSure, value, true); }
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
			get { return (int)dhmi.EntityType.DigerBirimlerAyrintiEntity; }
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
