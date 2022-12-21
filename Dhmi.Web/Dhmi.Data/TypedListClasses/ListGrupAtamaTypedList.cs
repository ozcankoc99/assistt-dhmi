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
	/// <summary>Typed datatable for the list 'ListGrupAtama'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListGrupAtamaTypedList : TypedListBase<ListGrupAtamaRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnGrupAd;
		private DataColumn _columnGrupAmir;
		private DataColumn _columnGrupDurum;
		private DataColumn _columnGrupId;
		private DataColumn _columnGrupKisaltma;
		private DataColumn _columnFkGrupId;
		private DataColumn _columnGrupAtamaDurum;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnKullaniciMail;
		private DataColumn _columnKullaniciDurum;
		private DataColumn _columnGrupAtamaId;
		private DataColumn _columnGrupAtamaTarih;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 13;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListGrupAtamaTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListGrupAtamaTypedList():base("ListGrupAtama")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListGrupAtamaTypedList(bool obeyWeakRelations):base("ListGrupAtama")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListGrupAtamaTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListGrupAtamaTypedList cloneToReturn = ((ListGrupAtamaTypedList)(base.Clone()));
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
			return new ListGrupAtamaRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(GrupAtamaEntity.Relations.GrupEntityUsingFkGrupId, "", "", JoinHint.Inner);
			toReturn.Add(KullaniciEntity.Relations.GrupAtamaEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(GrupFields.GrupAd, 0, "GrupAd", "", AggregateFunction.None);
			toReturn.DefineField(GrupFields.GrupAmir, 1, "GrupAmir", "", AggregateFunction.None);
			toReturn.DefineField(GrupFields.GrupDurum, 2, "GrupDurum", "", AggregateFunction.None);
			toReturn.DefineField(GrupFields.GrupId, 3, "GrupId", "", AggregateFunction.None);
			toReturn.DefineField(GrupFields.GrupKisaltma, 4, "GrupKisaltma", "", AggregateFunction.None);
			toReturn.DefineField(GrupAtamaFields.FkGrupId, 5, "FkGrupId", "", AggregateFunction.None);
			toReturn.DefineField(GrupAtamaFields.GrupAtamaDurum, 6, "GrupAtamaDurum", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 7, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 8, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciMail, 9, "KullaniciMail", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciDurum, 10, "KullaniciDurum", "", AggregateFunction.None);
			toReturn.DefineField(GrupAtamaFields.GrupAtamaId, 11, "GrupAtamaId", "", AggregateFunction.None);
			toReturn.DefineField(GrupAtamaFields.GrupAtamaTarih, 12, "GrupAtamaTarih", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("GrupAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupAmir", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupKisaltma", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkGrupId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupAtamaDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciMail", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupAtamaId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GrupAtamaTarih", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnGrupAd = GeneralUtils.CreateTypedDataTableColumn("GrupAd", @"GrupAd", typeof(System.String), this.Columns);
			_columnGrupAmir = GeneralUtils.CreateTypedDataTableColumn("GrupAmir", @"GrupAmir", typeof(System.String), this.Columns);
			_columnGrupDurum = GeneralUtils.CreateTypedDataTableColumn("GrupDurum", @"GrupDurum", typeof(System.Boolean), this.Columns);
			_columnGrupId = GeneralUtils.CreateTypedDataTableColumn("GrupId", @"GrupId", typeof(System.Int16), this.Columns);
			_columnGrupKisaltma = GeneralUtils.CreateTypedDataTableColumn("GrupKisaltma", @"GrupKisaltma", typeof(System.String), this.Columns);
			_columnFkGrupId = GeneralUtils.CreateTypedDataTableColumn("FkGrupId", @"FkGrupId", typeof(System.Int16), this.Columns);
			_columnGrupAtamaDurum = GeneralUtils.CreateTypedDataTableColumn("GrupAtamaDurum", @"GrupAtamaDurum", typeof(System.Boolean), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciMail = GeneralUtils.CreateTypedDataTableColumn("KullaniciMail", @"KullaniciMail", typeof(System.String), this.Columns);
			_columnKullaniciDurum = GeneralUtils.CreateTypedDataTableColumn("KullaniciDurum", @"KullaniciDurum", typeof(System.Boolean), this.Columns);
			_columnGrupAtamaId = GeneralUtils.CreateTypedDataTableColumn("GrupAtamaId", @"GrupAtamaId", typeof(System.Int64), this.Columns);
			_columnGrupAtamaTarih = GeneralUtils.CreateTypedDataTableColumn("GrupAtamaTarih", @"GrupAtamaTarih", typeof(System.DateTime), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnGrupAd = this.Columns["GrupAd"];
			_columnGrupAmir = this.Columns["GrupAmir"];
			_columnGrupDurum = this.Columns["GrupDurum"];
			_columnGrupId = this.Columns["GrupId"];
			_columnGrupKisaltma = this.Columns["GrupKisaltma"];
			_columnFkGrupId = this.Columns["FkGrupId"];
			_columnGrupAtamaDurum = this.Columns["GrupAtamaDurum"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnKullaniciMail = this.Columns["KullaniciMail"];
			_columnKullaniciDurum = this.Columns["KullaniciDurum"];
			_columnGrupAtamaId = this.Columns["GrupAtamaId"];
			_columnGrupAtamaTarih = this.Columns["GrupAtamaTarih"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListGrupAtamaTypedList();
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
			get { return ListGrupAtamaTypedList.CustomProperties;}
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
			get { return ListGrupAtamaTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupAd</summary>
		internal DataColumn GrupAdColumn 
		{
			get { return _columnGrupAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupAmir</summary>
		internal DataColumn GrupAmirColumn 
		{
			get { return _columnGrupAmir; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupDurum</summary>
		internal DataColumn GrupDurumColumn 
		{
			get { return _columnGrupDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupId</summary>
		internal DataColumn GrupIdColumn 
		{
			get { return _columnGrupId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupKisaltma</summary>
		internal DataColumn GrupKisaltmaColumn 
		{
			get { return _columnGrupKisaltma; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkGrupId</summary>
		internal DataColumn FkGrupIdColumn 
		{
			get { return _columnFkGrupId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupAtamaDurum</summary>
		internal DataColumn GrupAtamaDurumColumn 
		{
			get { return _columnGrupAtamaDurum; }
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

		/// <summary>Returns the column object belonging to the TypedList field KullaniciMail</summary>
		internal DataColumn KullaniciMailColumn 
		{
			get { return _columnKullaniciMail; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciDurum</summary>
		internal DataColumn KullaniciDurumColumn 
		{
			get { return _columnKullaniciDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupAtamaId</summary>
		internal DataColumn GrupAtamaIdColumn 
		{
			get { return _columnGrupAtamaId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field GrupAtamaTarih</summary>
		internal DataColumn GrupAtamaTarihColumn 
		{
			get { return _columnGrupAtamaTarih; }
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

	/// <summary>Typed datarow for the typed datatable ListGrupAtama</summary>
	public partial class ListGrupAtamaRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListGrupAtamaTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListGrupAtamaRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListGrupAtamaTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field GrupAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Grup.GrupAd</remarks>
		public System.String GrupAd 
		{
			get { return IsGrupAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GrupAdColumn]; }
			set { this[_parent.GrupAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupAd is NULL, false otherwise.</summary>
		public bool IsGrupAdNull() 
		{
			return IsNull(_parent.GrupAdColumn);
		}

		/// <summary>Sets the TypedList field GrupAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupAdNull() 
		{
			this[_parent.GrupAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupAmir<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Grup.GrupAmir</remarks>
		public System.String GrupAmir 
		{
			get { return IsGrupAmirNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GrupAmirColumn]; }
			set { this[_parent.GrupAmirColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupAmir is NULL, false otherwise.</summary>
		public bool IsGrupAmirNull() 
		{
			return IsNull(_parent.GrupAmirColumn);
		}

		/// <summary>Sets the TypedList field GrupAmir to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupAmirNull() 
		{
			this[_parent.GrupAmirColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Grup.GrupDurum</remarks>
		public System.Boolean GrupDurum 
		{
			get { return IsGrupDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.GrupDurumColumn]; }
			set { this[_parent.GrupDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupDurum is NULL, false otherwise.</summary>
		public bool IsGrupDurumNull() 
		{
			return IsNull(_parent.GrupDurumColumn);
		}

		/// <summary>Sets the TypedList field GrupDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupDurumNull() 
		{
			this[_parent.GrupDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Grup.GrupId</remarks>
		public System.Int16 GrupId 
		{
			get { return IsGrupIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.GrupIdColumn]; }
			set { this[_parent.GrupIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupId is NULL, false otherwise.</summary>
		public bool IsGrupIdNull() 
		{
			return IsNull(_parent.GrupIdColumn);
		}

		/// <summary>Sets the TypedList field GrupId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupIdNull() 
		{
			this[_parent.GrupIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupKisaltma<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Grup.GrupKisaltma</remarks>
		public System.String GrupKisaltma 
		{
			get { return IsGrupKisaltmaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GrupKisaltmaColumn]; }
			set { this[_parent.GrupKisaltmaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupKisaltma is NULL, false otherwise.</summary>
		public bool IsGrupKisaltmaNull() 
		{
			return IsNull(_parent.GrupKisaltmaColumn);
		}

		/// <summary>Sets the TypedList field GrupKisaltma to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupKisaltmaNull() 
		{
			this[_parent.GrupKisaltmaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkGrupId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: GrupAtama.FkGrupId</remarks>
		public System.Int16 FkGrupId 
		{
			get { return IsFkGrupIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkGrupIdColumn]; }
			set { this[_parent.FkGrupIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkGrupId is NULL, false otherwise.</summary>
		public bool IsFkGrupIdNull() 
		{
			return IsNull(_parent.FkGrupIdColumn);
		}

		/// <summary>Sets the TypedList field FkGrupId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkGrupIdNull() 
		{
			this[_parent.FkGrupIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupAtamaDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: GrupAtama.GrupAtamaDurum</remarks>
		public System.Boolean GrupAtamaDurum 
		{
			get { return IsGrupAtamaDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.GrupAtamaDurumColumn]; }
			set { this[_parent.GrupAtamaDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupAtamaDurum is NULL, false otherwise.</summary>
		public bool IsGrupAtamaDurumNull() 
		{
			return IsNull(_parent.GrupAtamaDurumColumn);
		}

		/// <summary>Sets the TypedList field GrupAtamaDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupAtamaDurumNull() 
		{
			this[_parent.GrupAtamaDurumColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field KullaniciMail<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciMail</remarks>
		public System.String KullaniciMail 
		{
			get { return IsKullaniciMailNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KullaniciMailColumn]; }
			set { this[_parent.KullaniciMailColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciMail is NULL, false otherwise.</summary>
		public bool IsKullaniciMailNull() 
		{
			return IsNull(_parent.KullaniciMailColumn);
		}

		/// <summary>Sets the TypedList field KullaniciMail to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciMailNull() 
		{
			this[_parent.KullaniciMailColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KullaniciDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Kullanici.KullaniciDurum</remarks>
		public System.Boolean KullaniciDurum 
		{
			get { return IsKullaniciDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.KullaniciDurumColumn]; }
			set { this[_parent.KullaniciDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KullaniciDurum is NULL, false otherwise.</summary>
		public bool IsKullaniciDurumNull() 
		{
			return IsNull(_parent.KullaniciDurumColumn);
		}

		/// <summary>Sets the TypedList field KullaniciDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKullaniciDurumNull() 
		{
			this[_parent.KullaniciDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupAtamaId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: GrupAtama.GrupAtamaId</remarks>
		public System.Int64 GrupAtamaId 
		{
			get { return IsGrupAtamaIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.GrupAtamaIdColumn]; }
			set { this[_parent.GrupAtamaIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupAtamaId is NULL, false otherwise.</summary>
		public bool IsGrupAtamaIdNull() 
		{
			return IsNull(_parent.GrupAtamaIdColumn);
		}

		/// <summary>Sets the TypedList field GrupAtamaId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupAtamaIdNull() 
		{
			this[_parent.GrupAtamaIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field GrupAtamaTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: GrupAtama.GrupAtamaTarih</remarks>
		public System.DateTime GrupAtamaTarih 
		{
			get { return IsGrupAtamaTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.GrupAtamaTarihColumn]; }
			set { this[_parent.GrupAtamaTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field GrupAtamaTarih is NULL, false otherwise.</summary>
		public bool IsGrupAtamaTarihNull() 
		{
			return IsNull(_parent.GrupAtamaTarihColumn);
		}

		/// <summary>Sets the TypedList field GrupAtamaTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGrupAtamaTarihNull() 
		{
			this[_parent.GrupAtamaTarihColumn] = System.Convert.DBNull;
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
