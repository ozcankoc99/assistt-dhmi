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
	/// <summary>Typed datatable for the list 'ListBilgi'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListBilgiTypedList : TypedListBase<ListBilgiRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnBilgiBankasiAd;
		private DataColumn _columnBilgiBankasiDosya;
		private DataColumn _columnBilgiBankasiEtiket;
		private DataColumn _columnBilgiBankasiIcerik;
		private DataColumn _columnBilgiBankasiId;
		private DataColumn _columnBilgiBankasiSira;
		private DataColumn _columnBilgiBankasiTarih;
		private DataColumn _columnFkBilgiBankasiTurId;
		private DataColumn _columnBilgiBankasiTurAd;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 9;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListBilgiTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListBilgiTypedList():base("ListBilgi")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListBilgiTypedList(bool obeyWeakRelations):base("ListBilgi")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListBilgiTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListBilgiTypedList cloneToReturn = ((ListBilgiTypedList)(base.Clone()));
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
			return new ListBilgiRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(BilgiBankasiTurEntity.Relations.BilgiBankasiEntityUsingFkBilgiBankasiTurId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiAd, 0, "BilgiBankasiAd", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiDosya, 1, "BilgiBankasiDosya", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiEtiket, 2, "BilgiBankasiEtiket", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiIcerik, 3, "BilgiBankasiIcerik", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiId, 4, "BilgiBankasiId", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiSira, 5, "BilgiBankasiSira", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.BilgiBankasiTarih, 6, "BilgiBankasiTarih", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiFields.FkBilgiBankasiTurId, 7, "FkBilgiBankasiTurId", "", AggregateFunction.None);
			toReturn.DefineField(BilgiBankasiTurFields.BilgiBankasiTurAd, 8, "BilgiBankasiTurAd", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("BilgiBankasiAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiDosya", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiEtiket", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiIcerik", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiSira", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkBilgiBankasiTurId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("BilgiBankasiTurAd", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnBilgiBankasiAd = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiAd", @"BilgiBankasiAd", typeof(System.String), this.Columns);
			_columnBilgiBankasiDosya = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiDosya", @"BilgiBankasiDosya", typeof(System.String), this.Columns);
			_columnBilgiBankasiEtiket = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiEtiket", @"BilgiBankasiEtiket", typeof(System.String), this.Columns);
			_columnBilgiBankasiIcerik = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiIcerik", @"BilgiBankasiIcerik", typeof(System.String), this.Columns);
			_columnBilgiBankasiId = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiId", @"BilgiBankasiId", typeof(System.Int16), this.Columns);
			_columnBilgiBankasiSira = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiSira", @"BilgiBankasiSira", typeof(System.Int16), this.Columns);
			_columnBilgiBankasiTarih = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiTarih", @"BilgiBankasiTarih", typeof(System.DateTime), this.Columns);
			_columnFkBilgiBankasiTurId = GeneralUtils.CreateTypedDataTableColumn("FkBilgiBankasiTurId", @"FkBilgiBankasiTurId", typeof(System.Int16), this.Columns);
			_columnBilgiBankasiTurAd = GeneralUtils.CreateTypedDataTableColumn("BilgiBankasiTurAd", @"BilgiBankasiTurAd", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnBilgiBankasiAd = this.Columns["BilgiBankasiAd"];
			_columnBilgiBankasiDosya = this.Columns["BilgiBankasiDosya"];
			_columnBilgiBankasiEtiket = this.Columns["BilgiBankasiEtiket"];
			_columnBilgiBankasiIcerik = this.Columns["BilgiBankasiIcerik"];
			_columnBilgiBankasiId = this.Columns["BilgiBankasiId"];
			_columnBilgiBankasiSira = this.Columns["BilgiBankasiSira"];
			_columnBilgiBankasiTarih = this.Columns["BilgiBankasiTarih"];
			_columnFkBilgiBankasiTurId = this.Columns["FkBilgiBankasiTurId"];
			_columnBilgiBankasiTurAd = this.Columns["BilgiBankasiTurAd"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListBilgiTypedList();
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
			get { return ListBilgiTypedList.CustomProperties;}
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
			get { return ListBilgiTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiAd</summary>
		internal DataColumn BilgiBankasiAdColumn 
		{
			get { return _columnBilgiBankasiAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiDosya</summary>
		internal DataColumn BilgiBankasiDosyaColumn 
		{
			get { return _columnBilgiBankasiDosya; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiEtiket</summary>
		internal DataColumn BilgiBankasiEtiketColumn 
		{
			get { return _columnBilgiBankasiEtiket; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiIcerik</summary>
		internal DataColumn BilgiBankasiIcerikColumn 
		{
			get { return _columnBilgiBankasiIcerik; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiId</summary>
		internal DataColumn BilgiBankasiIdColumn 
		{
			get { return _columnBilgiBankasiId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiSira</summary>
		internal DataColumn BilgiBankasiSiraColumn 
		{
			get { return _columnBilgiBankasiSira; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiTarih</summary>
		internal DataColumn BilgiBankasiTarihColumn 
		{
			get { return _columnBilgiBankasiTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkBilgiBankasiTurId</summary>
		internal DataColumn FkBilgiBankasiTurIdColumn 
		{
			get { return _columnFkBilgiBankasiTurId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field BilgiBankasiTurAd</summary>
		internal DataColumn BilgiBankasiTurAdColumn 
		{
			get { return _columnBilgiBankasiTurAd; }
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

	/// <summary>Typed datarow for the typed datatable ListBilgi</summary>
	public partial class ListBilgiRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListBilgiTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListBilgiRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListBilgiTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiAd</remarks>
		public System.String BilgiBankasiAd 
		{
			get { return IsBilgiBankasiAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BilgiBankasiAdColumn]; }
			set { this[_parent.BilgiBankasiAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiAd is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiAdNull() 
		{
			return IsNull(_parent.BilgiBankasiAdColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiAdNull() 
		{
			this[_parent.BilgiBankasiAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiDosya<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiDosya</remarks>
		public System.String BilgiBankasiDosya 
		{
			get { return IsBilgiBankasiDosyaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BilgiBankasiDosyaColumn]; }
			set { this[_parent.BilgiBankasiDosyaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiDosya is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiDosyaNull() 
		{
			return IsNull(_parent.BilgiBankasiDosyaColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiDosya to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiDosyaNull() 
		{
			this[_parent.BilgiBankasiDosyaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiEtiket<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiEtiket</remarks>
		public System.String BilgiBankasiEtiket 
		{
			get { return IsBilgiBankasiEtiketNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BilgiBankasiEtiketColumn]; }
			set { this[_parent.BilgiBankasiEtiketColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiEtiket is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiEtiketNull() 
		{
			return IsNull(_parent.BilgiBankasiEtiketColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiEtiket to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiEtiketNull() 
		{
			this[_parent.BilgiBankasiEtiketColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiIcerik<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiIcerik</remarks>
		public System.String BilgiBankasiIcerik 
		{
			get { return IsBilgiBankasiIcerikNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BilgiBankasiIcerikColumn]; }
			set { this[_parent.BilgiBankasiIcerikColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiIcerik is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiIcerikNull() 
		{
			return IsNull(_parent.BilgiBankasiIcerikColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiIcerik to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiIcerikNull() 
		{
			this[_parent.BilgiBankasiIcerikColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiId</remarks>
		public System.Int16 BilgiBankasiId 
		{
			get { return IsBilgiBankasiIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.BilgiBankasiIdColumn]; }
			set { this[_parent.BilgiBankasiIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiId is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiIdNull() 
		{
			return IsNull(_parent.BilgiBankasiIdColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiIdNull() 
		{
			this[_parent.BilgiBankasiIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiSira<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiSira</remarks>
		public System.Int16 BilgiBankasiSira 
		{
			get { return IsBilgiBankasiSiraNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.BilgiBankasiSiraColumn]; }
			set { this[_parent.BilgiBankasiSiraColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiSira is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiSiraNull() 
		{
			return IsNull(_parent.BilgiBankasiSiraColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiSira to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiSiraNull() 
		{
			this[_parent.BilgiBankasiSiraColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.BilgiBankasiTarih</remarks>
		public System.DateTime BilgiBankasiTarih 
		{
			get { return IsBilgiBankasiTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BilgiBankasiTarihColumn]; }
			set { this[_parent.BilgiBankasiTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiTarih is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiTarihNull() 
		{
			return IsNull(_parent.BilgiBankasiTarihColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiTarihNull() 
		{
			this[_parent.BilgiBankasiTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkBilgiBankasiTurId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasi.FkBilgiBankasiTurId</remarks>
		public System.Int16 FkBilgiBankasiTurId 
		{
			get { return IsFkBilgiBankasiTurIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkBilgiBankasiTurIdColumn]; }
			set { this[_parent.FkBilgiBankasiTurIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkBilgiBankasiTurId is NULL, false otherwise.</summary>
		public bool IsFkBilgiBankasiTurIdNull() 
		{
			return IsNull(_parent.FkBilgiBankasiTurIdColumn);
		}

		/// <summary>Sets the TypedList field FkBilgiBankasiTurId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkBilgiBankasiTurIdNull() 
		{
			this[_parent.FkBilgiBankasiTurIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field BilgiBankasiTurAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: BilgiBankasiTur.BilgiBankasiTurAd</remarks>
		public System.String BilgiBankasiTurAd 
		{
			get { return IsBilgiBankasiTurAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.BilgiBankasiTurAdColumn]; }
			set { this[_parent.BilgiBankasiTurAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field BilgiBankasiTurAd is NULL, false otherwise.</summary>
		public bool IsBilgiBankasiTurAdNull() 
		{
			return IsNull(_parent.BilgiBankasiTurAdColumn);
		}

		/// <summary>Sets the TypedList field BilgiBankasiTurAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBilgiBankasiTurAdNull() 
		{
			this[_parent.BilgiBankasiTurAdColumn] = System.Convert.DBNull;
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
