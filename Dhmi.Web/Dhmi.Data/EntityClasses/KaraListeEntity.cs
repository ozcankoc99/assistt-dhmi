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

	/// <summary>Entity class which represents the entity 'KaraListe'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class KaraListeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private VatandaEntity _vatanda;
		private bool	_alwaysFetchVatanda, _alreadyFetchedVatanda, _vatandaReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Vatanda</summary>
			public static readonly string Vatanda = "Vatanda";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static KaraListeEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public KaraListeEntity() :base("KaraListeEntity")
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		public KaraListeEntity(System.Int64 karaListeId):base("KaraListeEntity")
		{
			InitClassFetch(karaListeId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public KaraListeEntity(System.Int64 karaListeId, IPrefetchPath prefetchPathToUse):base("KaraListeEntity")
		{
			InitClassFetch(karaListeId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="validator">The custom validator object for this KaraListeEntity</param>
		public KaraListeEntity(System.Int64 karaListeId, IValidator validator):base("KaraListeEntity")
		{
			InitClassFetch(karaListeId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected KaraListeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_vatanda = (VatandaEntity)info.GetValue("_vatanda", typeof(VatandaEntity));
			if(_vatanda!=null)
			{
				_vatanda.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_vatandaReturnsNewIfNotFound = info.GetBoolean("_vatandaReturnsNewIfNotFound");
			_alwaysFetchVatanda = info.GetBoolean("_alwaysFetchVatanda");
			_alreadyFetchedVatanda = info.GetBoolean("_alreadyFetchedVatanda");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((KaraListeFieldIndex)fieldIndex)
			{
				case KaraListeFieldIndex.FkVatandasId:
					DesetupSyncVatanda(true, false);
					_alreadyFetchedVatanda = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedVatanda = (_vatanda != null);
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
				case "Vatanda":
					toReturn.Add(Relations.VatandaEntityUsingFkVatandasId);
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
			info.AddValue("_vatanda", (!this.MarkedForDeletion?_vatanda:null));
			info.AddValue("_vatandaReturnsNewIfNotFound", _vatandaReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchVatanda", _alwaysFetchVatanda);
			info.AddValue("_alreadyFetchedVatanda", _alreadyFetchedVatanda);

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
				case "Vatanda":
					_alreadyFetchedVatanda = true;
					this.Vatanda = (VatandaEntity)entity;
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
				case "Vatanda":
					SetupSyncVatanda(relatedEntity);
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
				case "Vatanda":
					DesetupSyncVatanda(false, true);
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
			if(_vatanda!=null)
			{
				toReturn.Add(_vatanda);
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
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 karaListeId)
		{
			return FetchUsingPK(karaListeId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 karaListeId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(karaListeId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 karaListeId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(karaListeId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int64 karaListeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(karaListeId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.KaraListeId, null, null, null);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new KaraListeRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'VatandaEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'VatandaEntity' which is related to this entity.</returns>
		public VatandaEntity GetSingleVatanda()
		{
			return GetSingleVatanda(false);
		}

		/// <summary> Retrieves the related entity of type 'VatandaEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'VatandaEntity' which is related to this entity.</returns>
		public virtual VatandaEntity GetSingleVatanda(bool forceFetch)
		{
			if( ( !_alreadyFetchedVatanda || forceFetch || _alwaysFetchVatanda) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.VatandaEntityUsingFkVatandasId);
				VatandaEntity newEntity = new VatandaEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.FkVatandasId);
				}
				if(fetchResult)
				{
					newEntity = (VatandaEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_vatandaReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.Vatanda = newEntity;
				_alreadyFetchedVatanda = fetchResult;
			}
			return _vatanda;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Vatanda", _vatanda);
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
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="validator">The validator object for this KaraListeEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int64 karaListeId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(karaListeId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_vatandaReturnsNewIfNotFound = false;
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
			_fieldsCustomProperties.Add("FkVatandasId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeAciklama", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeBslTarihSaat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeBtsTarihSaat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeDurum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeIptalEdenKullanici", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeIptalTarihi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeIslemTarih", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KaraListeIslemYapan", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _vatanda</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVatanda(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vatanda, new PropertyChangedEventHandler( OnVatandaPropertyChanged ), "Vatanda", dhmi.RelationClasses.StaticKaraListeRelations.VatandaEntityUsingFkVatandasIdStatic, true, signalRelatedEntity, "KaraListes", resetFKFields, new int[] { (int)KaraListeFieldIndex.FkVatandasId } );		
			_vatanda = null;
		}
		
		/// <summary> setups the sync logic for member _vatanda</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVatanda(IEntityCore relatedEntity)
		{
			if(_vatanda!=relatedEntity)
			{		
				DesetupSyncVatanda(true, true);
				_vatanda = (VatandaEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vatanda, new PropertyChangedEventHandler( OnVatandaPropertyChanged ), "Vatanda", dhmi.RelationClasses.StaticKaraListeRelations.VatandaEntityUsingFkVatandasIdStatic, true, ref _alreadyFetchedVatanda, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVatandaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="karaListeId">PK value for KaraListe which data should be fetched into this KaraListe object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int64 karaListeId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)KaraListeFieldIndex.KaraListeId].ForcedCurrentValueWrite(karaListeId);
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
			return DAOFactory.CreateKaraListeDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new KaraListeEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static KaraListeRelations Relations
		{
			get	{ return new KaraListeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Vatanda'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathVatanda
		{
			get	{ return new PrefetchPathElement(new dhmi.CollectionClasses.VatandaCollection(), (IEntityRelation)GetRelationsForField("Vatanda")[0], (int)dhmi.EntityType.KaraListeEntity, (int)dhmi.EntityType.VatandaEntity, 0, null, null, null, "Vatanda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The FkVatandasId property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."FK_Vatandas_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 FkVatandasId
		{
			get { return (System.Int64)GetValue((int)KaraListeFieldIndex.FkVatandasId, true); }
			set	{ SetValue((int)KaraListeFieldIndex.FkVatandasId, value, true); }
		}

		/// <summary> The KaraListeAciklama property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Aciklama"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1000<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KaraListeAciklama
		{
			get { return (System.String)GetValue((int)KaraListeFieldIndex.KaraListeAciklama, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeAciklama, value, true); }
		}

		/// <summary> The KaraListeBslTarihSaat property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Bsl_Tarih_Saat"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime KaraListeBslTarihSaat
		{
			get { return (System.DateTime)GetValue((int)KaraListeFieldIndex.KaraListeBslTarihSaat, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeBslTarihSaat, value, true); }
		}

		/// <summary> The KaraListeBtsTarihSaat property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Bts_Tarih_Saat"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime KaraListeBtsTarihSaat
		{
			get { return (System.DateTime)GetValue((int)KaraListeFieldIndex.KaraListeBtsTarihSaat, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeBtsTarihSaat, value, true); }
		}

		/// <summary> The KaraListeDurum property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Durum"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean KaraListeDurum
		{
			get { return (System.Boolean)GetValue((int)KaraListeFieldIndex.KaraListeDurum, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeDurum, value, true); }
		}

		/// <summary> The KaraListeId property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_ID"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 KaraListeId
		{
			get { return (System.Int64)GetValue((int)KaraListeFieldIndex.KaraListeId, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeId, value, true); }
		}

		/// <summary> The KaraListeIptalEdenKullanici property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Iptal_Eden_Kullanici"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String KaraListeIptalEdenKullanici
		{
			get { return (System.String)GetValue((int)KaraListeFieldIndex.KaraListeIptalEdenKullanici, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeIptalEdenKullanici, value, true); }
		}

		/// <summary> The KaraListeIptalTarihi property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Iptal_Tarihi"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> KaraListeIptalTarihi
		{
			get { return (Nullable<System.DateTime>)GetValue((int)KaraListeFieldIndex.KaraListeIptalTarihi, false); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeIptalTarihi, value, true); }
		}

		/// <summary> The KaraListeIslemTarih property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Islem_Tarih"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallDateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime KaraListeIslemTarih
		{
			get { return (System.DateTime)GetValue((int)KaraListeFieldIndex.KaraListeIslemTarih, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeIslemTarih, value, true); }
		}

		/// <summary> The KaraListeIslemYapan property of the Entity KaraListe<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Kara_Liste"."Kara_Liste_Islem_Yapan"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String KaraListeIslemYapan
		{
			get { return (System.String)GetValue((int)KaraListeFieldIndex.KaraListeIslemYapan, true); }
			set	{ SetValue((int)KaraListeFieldIndex.KaraListeIslemYapan, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'VatandaEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVatanda()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual VatandaEntity Vatanda
		{
			get	{ return GetSingleVatanda(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncVatanda(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "KaraListes", "Vatanda", _vatanda, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Vatanda. When set to true, Vatanda is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vatanda is accessed. You can always execute a forced fetch by calling GetSingleVatanda(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchVatanda
		{
			get	{ return _alwaysFetchVatanda; }
			set	{ _alwaysFetchVatanda = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Vatanda already has been fetched. Setting this property to false when Vatanda has been fetched
		/// will set Vatanda to null as well. Setting this property to true while Vatanda hasn't been fetched disables lazy loading for Vatanda</summary>
		[Browsable(false)]
		public bool AlreadyFetchedVatanda
		{
			get { return _alreadyFetchedVatanda;}
			set 
			{
				if(_alreadyFetchedVatanda && !value)
				{
					this.Vatanda = null;
				}
				_alreadyFetchedVatanda = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Vatanda is not found
		/// in the database. When set to true, Vatanda will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: false.</summary>
		[Browsable(false)]
		public bool VatandaReturnsNewIfNotFound
		{
			get	{ return _vatandaReturnsNewIfNotFound; }
			set { _vatandaReturnsNewIfNotFound = value; }	
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
			get { return (int)dhmi.EntityType.KaraListeEntity; }
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
