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

	/// <summary>Entity class which represents the entity 'KpsBilgi'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KpsBilgiEntity : CommonEntityBase
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
		static KpsBilgiEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public KpsBilgiEntity() :base("KpsBilgiEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		public KpsBilgiEntity(System.Int64 kpsBilgiId):base("KpsBilgiEntity")
		{
			InitClassFetch(kpsBilgiId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public KpsBilgiEntity(System.Int64 kpsBilgiId, IPrefetchPath prefetchPathToUse):base("KpsBilgiEntity")
		{
			InitClassFetch(kpsBilgiId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="validator">The custom validator object for this KpsBilgiEntity</param>
		public KpsBilgiEntity(System.Int64 kpsBilgiId, IValidator validator):base("KpsBilgiEntity")
		{
			InitClassFetch(kpsBilgiId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected KpsBilgiEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 kpsBilgiId)
		{
			return FetchUsingPK(kpsBilgiId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 kpsBilgiId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(kpsBilgiId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 kpsBilgiId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(kpsBilgiId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 kpsBilgiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(kpsBilgiId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.KpsBilgiId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new KpsBilgiRelations().GetAllRelations();
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
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="validator">The validator object for this KpsBilgiEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 kpsBilgiId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(kpsBilgiId, prefetchPathToUse, null, null);

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
			_fieldsCustomProperties.Add("KpsBilgiAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiAnneAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiBabaAd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiCaddeSokak", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiCinsiyet", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiDis", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiDogumTarihi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiDogumYeri", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiIc", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiIl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiIlce", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiKayitNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiMahalle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiMedeniHal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiNo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiSeri", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiSiteBlok", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiSoyad", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiTcKimlik", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KpsBilgiUyruk", fieldHashtable);
		}
		#endregion

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="kpsBilgiId">PK value for KpsBilgi which data should be fetched into this KpsBilgi object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 kpsBilgiId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)KpsBilgiFieldIndex.KpsBilgiId].ForcedCurrentValueWrite(kpsBilgiId);
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
			return DAOFactory.CreateKpsBilgiDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new KpsBilgiEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static KpsBilgiRelations Relations
		{
			get	{ return new KpsBilgiRelations(); }
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

		/// <summary> The KpsBilgiAd property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiAd
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiAd, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiAd, value, true); }
		}

		/// <summary> The KpsBilgiAnneAd property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Anne_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiAnneAd
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiAnneAd, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiAnneAd, value, true); }
		}

		/// <summary> The KpsBilgiBabaAd property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Baba_Ad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiBabaAd
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiBabaAd, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiBabaAd, value, true); }
		}

		/// <summary> The KpsBilgiCaddeSokak property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Cadde_Sokak"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiCaddeSokak
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiCaddeSokak, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiCaddeSokak, value, true); }
		}

		/// <summary> The KpsBilgiCinsiyet property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Cinsiyet"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiCinsiyet
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiCinsiyet, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiCinsiyet, value, true); }
		}

		/// <summary> The KpsBilgiDis property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Dis"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiDis
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiDis, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiDis, value, true); }
		}

		/// <summary> The KpsBilgiDogumTarihi property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Dogum_Tarihi"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> KpsBilgiDogumTarihi
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KpsBilgiFieldIndex.KpsBilgiDogumTarihi, false); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiDogumTarihi, value, true); }
		}

		/// <summary> The KpsBilgiDogumYeri property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Dogum_Yeri"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiDogumYeri
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiDogumYeri, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiDogumYeri, value, true); }
		}

		/// <summary> The KpsBilgiIc property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Ic"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiIc
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiIc, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiIc, value, true); }
		}

		/// <summary> The KpsBilgiId property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 KpsBilgiId
		{
			get { return (System.Int64)GetValue((int)KpsBilgiFieldIndex.KpsBilgiId, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiId, value, true); }
		}

		/// <summary> The KpsBilgiIl property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Il"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiIl
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiIl, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiIl, value, true); }
		}

		/// <summary> The KpsBilgiIlce property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Ilce"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiIlce
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiIlce, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiIlce, value, true); }
		}

		/// <summary> The KpsBilgiKayitNo property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Kayit_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiKayitNo
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiKayitNo, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiKayitNo, value, true); }
		}

		/// <summary> The KpsBilgiMahalle property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Mahalle"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiMahalle
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiMahalle, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiMahalle, value, true); }
		}

		/// <summary> The KpsBilgiMedeniHal property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Medeni_Hal"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiMedeniHal
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiMedeniHal, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiMedeniHal, value, true); }
		}

		/// <summary> The KpsBilgiNo property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_No"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiNo
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiNo, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiNo, value, true); }
		}

		/// <summary> The KpsBilgiSeri property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Seri"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiSeri
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiSeri, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiSeri, value, true); }
		}

		/// <summary> The KpsBilgiSiteBlok property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Site_Blok"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiSiteBlok
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiSiteBlok, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiSiteBlok, value, true); }
		}

		/// <summary> The KpsBilgiSoyad property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Soyad"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiSoyad
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiSoyad, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiSoyad, value, true); }
		}

		/// <summary> The KpsBilgiTarih property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> KpsBilgiTarih
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KpsBilgiFieldIndex.KpsBilgiTarih, false); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiTarih, value, true); }
		}

		/// <summary> The KpsBilgiTcKimlik property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_TC_Kimlik"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 11<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiTcKimlik
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiTcKimlik, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiTcKimlik, value, true); }
		}

		/// <summary> The KpsBilgiUyruk property of the Entity KpsBilgi<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kps_Bilgi"."Kps_Bilgi_Uyruk"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KpsBilgiUyruk
		{
			get { return (System.String)GetValue((int)KpsBilgiFieldIndex.KpsBilgiUyruk, true); }
			set	{ SetValue((int)KpsBilgiFieldIndex.KpsBilgiUyruk, value, true); }
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
			get { return (int)dhmi.EntityType.KpsBilgiEntity; }
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
