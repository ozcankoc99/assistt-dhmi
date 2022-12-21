///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:40
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using dhmi.HelperClasses;
using dhmi.DaoClasses;
using dhmi.EntityClasses;
using dhmi.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace dhmi.TypedListClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Typed datatable for the list 'ListDuyuru'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListDuyuruTypedList : TypedListBase<ListDuyuruRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnDuyuruBaslik;
		private DataColumn _columnDuyuruDurum;
		private DataColumn _columnDuyuruIcerik;
		private DataColumn _columnDuyuruId;
		private DataColumn _columnDuyuruLink;
		private DataColumn _columnDuyuruResim;
		private DataColumn _columnDuyuruTarih;
		private DataColumn _columnDuyuruYayinTarih;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 11;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListDuyuruTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListDuyuruTypedList():base("ListDuyuru")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListDuyuruTypedList(bool obeyWeakRelations):base("ListDuyuru")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListDuyuruTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListDuyuruTypedList cloneToReturn = ((ListDuyuruTypedList)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

		/// <summary>Creates a new TypedList dao instance</summary>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateTypedListDAO();
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new ListDuyuruRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KullaniciEntity.Relations.DuyuruEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalRelations
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnRelationSetBuilt(toReturn);
			return toReturn;
		}

		/// <summary>Builds the resultset fields.</summary>
		/// <returns>ready to use resultset</returns>
		protected override IEntityFields BuildResultset()
		{
			ResultsetFields toReturn = new ResultsetFields(AmountOfFields);
			toReturn.DefineField(DuyuruFields.DuyuruBaslik, 0, "DuyuruBaslik", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruDurum, 1, "DuyuruDurum", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruIcerik, 2, "DuyuruIcerik", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruId, 3, "DuyuruId", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruLink, 4, "DuyuruLink", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruResim, 5, "DuyuruResim", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruTarih, 6, "DuyuruTarih", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.DuyuruYayinTarih, 7, "DuyuruYayinTarih", "", AggregateFunction.None);
			toReturn.DefineField(DuyuruFields.FkKullaniciId, 8, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 9, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 10, "KullaniciId", "", AggregateFunction.None);
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call toReturn.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnResultsetBuilt(toReturn);
			return toReturn;
		}

		/// <summary>Initializes the hashtables for the typed list type and typed list field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable = null;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruBaslik", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruIcerik", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruResim", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("DuyuruYayinTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnDuyuruBaslik = GeneralUtils.CreateTypedDataTableColumn("DuyuruBaslik", @"DuyuruBaslik", typeof(System.String), this.Columns);
			_columnDuyuruDurum = GeneralUtils.CreateTypedDataTableColumn("DuyuruDurum", @"DuyuruDurum", typeof(System.Boolean), this.Columns);
			_columnDuyuruIcerik = GeneralUtils.CreateTypedDataTableColumn("DuyuruIcerik", @"DuyuruIcerik", typeof(System.String), this.Columns);
			_columnDuyuruId = GeneralUtils.CreateTypedDataTableColumn("DuyuruId", @"DuyuruId", typeof(System.Int16), this.Columns);
			_columnDuyuruLink = GeneralUtils.CreateTypedDataTableColumn("DuyuruLink", @"DuyuruLink", typeof(System.String), this.Columns);
			_columnDuyuruResim = GeneralUtils.CreateTypedDataTableColumn("DuyuruResim", @"DuyuruResim", typeof(System.String), this.Columns);
			_columnDuyuruTarih = GeneralUtils.CreateTypedDataTableColumn("DuyuruTarih", @"DuyuruTarih", typeof(System.DateTime), this.Columns);
			_columnDuyuruYayinTarih = GeneralUtils.CreateTypedDataTableColumn("DuyuruYayinTarih", @"DuyuruYayinTarih", typeof(System.DateTime), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnDuyuruBaslik = this.Columns["DuyuruBaslik"];
			_columnDuyuruDurum = this.Columns["DuyuruDurum"];
			_columnDuyuruIcerik = this.Columns["DuyuruIcerik"];
			_columnDuyuruId = this.Columns["DuyuruId"];
			_columnDuyuruLink = this.Columns["DuyuruLink"];
			_columnDuyuruResim = this.Columns["DuyuruResim"];
			_columnDuyuruTarih = this.Columns["DuyuruTarih"];
			_columnDuyuruYayinTarih = this.Columns["DuyuruYayinTarih"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciId = this.Columns["KullaniciId"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListDuyuruTypedList();
		}
#endif
		#region Class Property Declarations
		/// <summary>The custom properties for this TypedList type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedList instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return ListDuyuruTypedList.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedList type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedList instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return ListDuyuruTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruBaslik</summary>
		internal DataColumn DuyuruBaslikColumn 
		{
			get { return _columnDuyuruBaslik; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruDurum</summary>
		internal DataColumn DuyuruDurumColumn 
		{
			get { return _columnDuyuruDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruIcerik</summary>
		internal DataColumn DuyuruIcerikColumn 
		{
			get { return _columnDuyuruIcerik; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruId</summary>
		internal DataColumn DuyuruIdColumn 
		{
			get { return _columnDuyuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruLink</summary>
		internal DataColumn DuyuruLinkColumn 
		{
			get { return _columnDuyuruLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruResim</summary>
		internal DataColumn DuyuruResimColumn 
		{
			get { return _columnDuyuruResim; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruTarih</summary>
		internal DataColumn DuyuruTarihColumn 
		{
			get { return _columnDuyuruTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field DuyuruYayinTarih</summary>
		internal DataColumn DuyuruYayinTarihColumn 
		{
			get { return _columnDuyuruYayinTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAdSoyad</summary>
		internal DataColumn KullaniciAdSoyadColumn 
		{
			get { return _columnKullaniciAdSoyad; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciId</summary>
		internal DataColumn KullaniciIdColumn 
		{
			get { return _columnKullaniciId; }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
 		#endregion
		
		#region Custom TypedList code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}

	/// <summary>Typed datarow for the typed datatable ListDuyuru</summary>
	public partial class ListDuyuruRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListDuyuruTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListDuyuruRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListDuyuruTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field DuyuruBaslik<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruBaslik</remarks>
		public System.String DuyuruBaslik 
		{
			get { return IsDuyuruBaslikNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DuyuruBaslikColumn]; }
			set { this[_parent.DuyuruBaslikColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruBaslik is NULL, false otherwise.</summary>
		public bool IsDuyuruBaslikNull() 
		{
			return IsNull(_parent.DuyuruBaslikColumn);
		}

		/// <summary>Sets the TypedList field DuyuruBaslik to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruBaslikNull() 
		{
			this[_parent.DuyuruBaslikColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruDurum</remarks>
		public System.Boolean DuyuruDurum 
		{
			get { return IsDuyuruDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.DuyuruDurumColumn]; }
			set { this[_parent.DuyuruDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruDurum is NULL, false otherwise.</summary>
		public bool IsDuyuruDurumNull() 
		{
			return IsNull(_parent.DuyuruDurumColumn);
		}

		/// <summary>Sets the TypedList field DuyuruDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruDurumNull() 
		{
			this[_parent.DuyuruDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruIcerik<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruIcerik</remarks>
		public System.String DuyuruIcerik 
		{
			get { return IsDuyuruIcerikNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DuyuruIcerikColumn]; }
			set { this[_parent.DuyuruIcerikColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruIcerik is NULL, false otherwise.</summary>
		public bool IsDuyuruIcerikNull() 
		{
			return IsNull(_parent.DuyuruIcerikColumn);
		}

		/// <summary>Sets the TypedList field DuyuruIcerik to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruIcerikNull() 
		{
			this[_parent.DuyuruIcerikColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruId</remarks>
		public System.Int16 DuyuruId 
		{
			get { return IsDuyuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.DuyuruIdColumn]; }
			set { this[_parent.DuyuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruId is NULL, false otherwise.</summary>
		public bool IsDuyuruIdNull() 
		{
			return IsNull(_parent.DuyuruIdColumn);
		}

		/// <summary>Sets the TypedList field DuyuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruIdNull() 
		{
			this[_parent.DuyuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruLink</remarks>
		public System.String DuyuruLink 
		{
			get { return IsDuyuruLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DuyuruLinkColumn]; }
			set { this[_parent.DuyuruLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruLink is NULL, false otherwise.</summary>
		public bool IsDuyuruLinkNull() 
		{
			return IsNull(_parent.DuyuruLinkColumn);
		}

		/// <summary>Sets the TypedList field DuyuruLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruLinkNull() 
		{
			this[_parent.DuyuruLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruResim<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruResim</remarks>
		public System.String DuyuruResim 
		{
			get { return IsDuyuruResimNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.DuyuruResimColumn]; }
			set { this[_parent.DuyuruResimColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruResim is NULL, false otherwise.</summary>
		public bool IsDuyuruResimNull() 
		{
			return IsNull(_parent.DuyuruResimColumn);
		}

		/// <summary>Sets the TypedList field DuyuruResim to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruResimNull() 
		{
			this[_parent.DuyuruResimColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruTarih</remarks>
		public System.DateTime DuyuruTarih 
		{
			get { return IsDuyuruTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.DuyuruTarihColumn]; }
			set { this[_parent.DuyuruTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruTarih is NULL, false otherwise.</summary>
		public bool IsDuyuruTarihNull() 
		{
			return IsNull(_parent.DuyuruTarihColumn);
		}

		/// <summary>Sets the TypedList field DuyuruTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruTarihNull() 
		{
			this[_parent.DuyuruTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field DuyuruYayinTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.DuyuruYayinTarih</remarks>
		public System.DateTime DuyuruYayinTarih 
		{
			get { return IsDuyuruYayinTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.DuyuruYayinTarihColumn]; }
			set { this[_parent.DuyuruYayinTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field DuyuruYayinTarih is NULL, false otherwise.</summary>
		public bool IsDuyuruYayinTarihNull() 
		{
			return IsNull(_parent.DuyuruYayinTarihColumn);
		}

		/// <summary>Sets the TypedList field DuyuruYayinTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDuyuruYayinTarihNull() 
		{
			this[_parent.DuyuruYayinTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Duyuru.FkKullaniciId</remarks>
		public System.Int16 FkKullaniciId 
		{
			get { return IsFkKullaniciIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkKullaniciIdColumn]; }
			set { this[_parent.FkKullaniciIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKullaniciId is NULL, false otherwise.</summary>
		public bool IsFkKullaniciIdNull() 
		{
			return IsNull(_parent.FkKullaniciIdColumn);
		}

		/// <summary>Sets the TypedList field FkKullaniciId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKullaniciIdNull() 
		{
			this[_parent.FkKullaniciIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciAdSoyad<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciAdSoyad</remarks>
		public System.String KullaniciAdSoyad 
		{
			get { return IsKullaniciAdSoyadNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciAdSoyadColumn]; }
			set { this[_parent.KullaniciAdSoyadColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciAdSoyad is NULL, false otherwise.</summary>
		public bool IsKullaniciAdSoyadNull() 
		{
			return IsNull(_parent.KullaniciAdSoyadColumn);
		}

		/// <summary>Sets the TypedList field KullaniciAdSoyad to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciAdSoyadNull() 
		{
			this[_parent.KullaniciAdSoyadColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciId</remarks>
		public System.Int16 KullaniciId 
		{
			get { return IsKullaniciIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.KullaniciIdColumn]; }
			set { this[_parent.KullaniciIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciId is NULL, false otherwise.</summary>
		public bool IsKullaniciIdNull() 
		{
			return IsNull(_parent.KullaniciIdColumn);
		}

		/// <summary>Sets the TypedList field KullaniciId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciIdNull() 
		{
			this[_parent.KullaniciIdColumn] = System.Convert.DBNull;
		}
		#endregion

		#region Custom Typed List Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
