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
	/// <summary>Typed datatable for the list 'ListMenuAlt'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListMenuAltTypedList : TypedListBase<ListMenuAltRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAltMenuAciklama;
		private DataColumn _columnAltMenuAd;
		private DataColumn _columnAltMenuDurum;
		private DataColumn _columnAltMenuId;
		private DataColumn _columnAltMenuLink;
		private DataColumn _columnAltMenuSira;
		private DataColumn _columnAltMenuSonLink;
		private DataColumn _columnAltMenuTarih;
		private DataColumn _columnFkMenuId;
		private DataColumn _columnMenuAciklama;
		private DataColumn _columnMenuAd;
		private DataColumn _columnMenuDurum;
		private DataColumn _columnMenuId;
		private DataColumn _columnMenuLink;
		private DataColumn _columnMenuSira;
		private DataColumn _columnMenuSonLink;
		private DataColumn _columnMenuTarih;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 17;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListMenuAltTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListMenuAltTypedList():base("ListMenuAlt")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListMenuAltTypedList(bool obeyWeakRelations):base("ListMenuAlt")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListMenuAltTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListMenuAltTypedList cloneToReturn = ((ListMenuAltTypedList)(base.Clone()));
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
			return new ListMenuAltRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(MenuEntity.Relations.AltMenuEntityUsingFkMenuId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(AltMenuFields.AltMenuAciklama, 0, "AltMenuAciklama", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuAd, 1, "AltMenuAd", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuDurum, 2, "AltMenuDurum", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuId, 3, "AltMenuId", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuLink, 4, "AltMenuLink", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuSira, 5, "AltMenuSira", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuSonLink, 6, "AltMenuSonLink", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuTarih, 7, "AltMenuTarih", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.FkMenuId, 8, "FkMenuId", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuAciklama, 9, "MenuAciklama", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuAd, 10, "MenuAd", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuDurum, 11, "MenuDurum", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuId, 12, "MenuId", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuLink, 13, "MenuLink", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuSira, 14, "MenuSira", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuSonLink, 15, "MenuSonLink", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuTarih, 16, "MenuTarih", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("AltMenuAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuSira", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuSonLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuSira", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuSonLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuTarih", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAltMenuAciklama = GeneralUtils.CreateTypedDataTableColumn("AltMenuAciklama", @"AltMenuAciklama", typeof(System.String), this.Columns);
			_columnAltMenuAd = GeneralUtils.CreateTypedDataTableColumn("AltMenuAd", @"AltMenuAd", typeof(System.String), this.Columns);
			_columnAltMenuDurum = GeneralUtils.CreateTypedDataTableColumn("AltMenuDurum", @"AltMenuDurum", typeof(System.Boolean), this.Columns);
			_columnAltMenuId = GeneralUtils.CreateTypedDataTableColumn("AltMenuId", @"AltMenuId", typeof(System.Int16), this.Columns);
			_columnAltMenuLink = GeneralUtils.CreateTypedDataTableColumn("AltMenuLink", @"AltMenuLink", typeof(System.String), this.Columns);
			_columnAltMenuSira = GeneralUtils.CreateTypedDataTableColumn("AltMenuSira", @"AltMenuSira", typeof(System.Int16), this.Columns);
			_columnAltMenuSonLink = GeneralUtils.CreateTypedDataTableColumn("AltMenuSonLink", @"AltMenuSonLink", typeof(System.String), this.Columns);
			_columnAltMenuTarih = GeneralUtils.CreateTypedDataTableColumn("AltMenuTarih", @"AltMenuTarih", typeof(System.DateTime), this.Columns);
			_columnFkMenuId = GeneralUtils.CreateTypedDataTableColumn("FkMenuId", @"FkMenuId", typeof(System.Int16), this.Columns);
			_columnMenuAciklama = GeneralUtils.CreateTypedDataTableColumn("MenuAciklama", @"MenuAciklama", typeof(System.String), this.Columns);
			_columnMenuAd = GeneralUtils.CreateTypedDataTableColumn("MenuAd", @"MenuAd", typeof(System.String), this.Columns);
			_columnMenuDurum = GeneralUtils.CreateTypedDataTableColumn("MenuDurum", @"MenuDurum", typeof(System.Boolean), this.Columns);
			_columnMenuId = GeneralUtils.CreateTypedDataTableColumn("MenuId", @"MenuId", typeof(System.Int16), this.Columns);
			_columnMenuLink = GeneralUtils.CreateTypedDataTableColumn("MenuLink", @"MenuLink", typeof(System.String), this.Columns);
			_columnMenuSira = GeneralUtils.CreateTypedDataTableColumn("MenuSira", @"MenuSira", typeof(System.Int16), this.Columns);
			_columnMenuSonLink = GeneralUtils.CreateTypedDataTableColumn("MenuSonLink", @"MenuSonLink", typeof(System.String), this.Columns);
			_columnMenuTarih = GeneralUtils.CreateTypedDataTableColumn("MenuTarih", @"MenuTarih", typeof(System.DateTime), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnAltMenuAciklama = this.Columns["AltMenuAciklama"];
			_columnAltMenuAd = this.Columns["AltMenuAd"];
			_columnAltMenuDurum = this.Columns["AltMenuDurum"];
			_columnAltMenuId = this.Columns["AltMenuId"];
			_columnAltMenuLink = this.Columns["AltMenuLink"];
			_columnAltMenuSira = this.Columns["AltMenuSira"];
			_columnAltMenuSonLink = this.Columns["AltMenuSonLink"];
			_columnAltMenuTarih = this.Columns["AltMenuTarih"];
			_columnFkMenuId = this.Columns["FkMenuId"];
			_columnMenuAciklama = this.Columns["MenuAciklama"];
			_columnMenuAd = this.Columns["MenuAd"];
			_columnMenuDurum = this.Columns["MenuDurum"];
			_columnMenuId = this.Columns["MenuId"];
			_columnMenuLink = this.Columns["MenuLink"];
			_columnMenuSira = this.Columns["MenuSira"];
			_columnMenuSonLink = this.Columns["MenuSonLink"];
			_columnMenuTarih = this.Columns["MenuTarih"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListMenuAltTypedList();
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
			get { return ListMenuAltTypedList.CustomProperties;}
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
			get { return ListMenuAltTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuAciklama</summary>
		internal DataColumn AltMenuAciklamaColumn 
		{
			get { return _columnAltMenuAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuAd</summary>
		internal DataColumn AltMenuAdColumn 
		{
			get { return _columnAltMenuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuDurum</summary>
		internal DataColumn AltMenuDurumColumn 
		{
			get { return _columnAltMenuDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuId</summary>
		internal DataColumn AltMenuIdColumn 
		{
			get { return _columnAltMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuLink</summary>
		internal DataColumn AltMenuLinkColumn 
		{
			get { return _columnAltMenuLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuSira</summary>
		internal DataColumn AltMenuSiraColumn 
		{
			get { return _columnAltMenuSira; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuSonLink</summary>
		internal DataColumn AltMenuSonLinkColumn 
		{
			get { return _columnAltMenuSonLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuTarih</summary>
		internal DataColumn AltMenuTarihColumn 
		{
			get { return _columnAltMenuTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkMenuId</summary>
		internal DataColumn FkMenuIdColumn 
		{
			get { return _columnFkMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuAciklama</summary>
		internal DataColumn MenuAciklamaColumn 
		{
			get { return _columnMenuAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuAd</summary>
		internal DataColumn MenuAdColumn 
		{
			get { return _columnMenuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuDurum</summary>
		internal DataColumn MenuDurumColumn 
		{
			get { return _columnMenuDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuId</summary>
		internal DataColumn MenuIdColumn 
		{
			get { return _columnMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuLink</summary>
		internal DataColumn MenuLinkColumn 
		{
			get { return _columnMenuLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuSira</summary>
		internal DataColumn MenuSiraColumn 
		{
			get { return _columnMenuSira; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuSonLink</summary>
		internal DataColumn MenuSonLinkColumn 
		{
			get { return _columnMenuSonLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuTarih</summary>
		internal DataColumn MenuTarihColumn 
		{
			get { return _columnMenuTarih; }
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

	/// <summary>Typed datarow for the typed datatable ListMenuAlt</summary>
	public partial class ListMenuAltRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListMenuAltTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListMenuAltRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListMenuAltTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field AltMenuAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuAciklama</remarks>
		public System.String AltMenuAciklama 
		{
			get { return IsAltMenuAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltMenuAciklamaColumn]; }
			set { this[_parent.AltMenuAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuAciklama is NULL, false otherwise.</summary>
		public bool IsAltMenuAciklamaNull() 
		{
			return IsNull(_parent.AltMenuAciklamaColumn);
		}

		/// <summary>Sets the TypedList field AltMenuAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuAciklamaNull() 
		{
			this[_parent.AltMenuAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuAd</remarks>
		public System.String AltMenuAd 
		{
			get { return IsAltMenuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltMenuAdColumn]; }
			set { this[_parent.AltMenuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuAd is NULL, false otherwise.</summary>
		public bool IsAltMenuAdNull() 
		{
			return IsNull(_parent.AltMenuAdColumn);
		}

		/// <summary>Sets the TypedList field AltMenuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuAdNull() 
		{
			this[_parent.AltMenuAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuDurum</remarks>
		public System.Boolean AltMenuDurum 
		{
			get { return IsAltMenuDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.AltMenuDurumColumn]; }
			set { this[_parent.AltMenuDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuDurum is NULL, false otherwise.</summary>
		public bool IsAltMenuDurumNull() 
		{
			return IsNull(_parent.AltMenuDurumColumn);
		}

		/// <summary>Sets the TypedList field AltMenuDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuDurumNull() 
		{
			this[_parent.AltMenuDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuId</remarks>
		public System.Int16 AltMenuId 
		{
			get { return IsAltMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.AltMenuIdColumn]; }
			set { this[_parent.AltMenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuId is NULL, false otherwise.</summary>
		public bool IsAltMenuIdNull() 
		{
			return IsNull(_parent.AltMenuIdColumn);
		}

		/// <summary>Sets the TypedList field AltMenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuIdNull() 
		{
			this[_parent.AltMenuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuLink</remarks>
		public System.String AltMenuLink 
		{
			get { return IsAltMenuLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltMenuLinkColumn]; }
			set { this[_parent.AltMenuLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuLink is NULL, false otherwise.</summary>
		public bool IsAltMenuLinkNull() 
		{
			return IsNull(_parent.AltMenuLinkColumn);
		}

		/// <summary>Sets the TypedList field AltMenuLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuLinkNull() 
		{
			this[_parent.AltMenuLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuSira<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuSira</remarks>
		public System.Int16 AltMenuSira 
		{
			get { return IsAltMenuSiraNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.AltMenuSiraColumn]; }
			set { this[_parent.AltMenuSiraColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuSira is NULL, false otherwise.</summary>
		public bool IsAltMenuSiraNull() 
		{
			return IsNull(_parent.AltMenuSiraColumn);
		}

		/// <summary>Sets the TypedList field AltMenuSira to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuSiraNull() 
		{
			this[_parent.AltMenuSiraColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuSonLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuSonLink</remarks>
		public System.String AltMenuSonLink 
		{
			get { return IsAltMenuSonLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltMenuSonLinkColumn]; }
			set { this[_parent.AltMenuSonLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuSonLink is NULL, false otherwise.</summary>
		public bool IsAltMenuSonLinkNull() 
		{
			return IsNull(_parent.AltMenuSonLinkColumn);
		}

		/// <summary>Sets the TypedList field AltMenuSonLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuSonLinkNull() 
		{
			this[_parent.AltMenuSonLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltMenuTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.AltMenuTarih</remarks>
		public System.DateTime AltMenuTarih 
		{
			get { return IsAltMenuTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.AltMenuTarihColumn]; }
			set { this[_parent.AltMenuTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltMenuTarih is NULL, false otherwise.</summary>
		public bool IsAltMenuTarihNull() 
		{
			return IsNull(_parent.AltMenuTarihColumn);
		}

		/// <summary>Sets the TypedList field AltMenuTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltMenuTarihNull() 
		{
			this[_parent.AltMenuTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkMenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltMenu.FkMenuId</remarks>
		public System.Int16 FkMenuId 
		{
			get { return IsFkMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkMenuIdColumn]; }
			set { this[_parent.FkMenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkMenuId is NULL, false otherwise.</summary>
		public bool IsFkMenuIdNull() 
		{
			return IsNull(_parent.FkMenuIdColumn);
		}

		/// <summary>Sets the TypedList field FkMenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkMenuIdNull() 
		{
			this[_parent.FkMenuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuAciklama</remarks>
		public System.String MenuAciklama 
		{
			get { return IsMenuAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MenuAciklamaColumn]; }
			set { this[_parent.MenuAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuAciklama is NULL, false otherwise.</summary>
		public bool IsMenuAciklamaNull() 
		{
			return IsNull(_parent.MenuAciklamaColumn);
		}

		/// <summary>Sets the TypedList field MenuAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuAciklamaNull() 
		{
			this[_parent.MenuAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuAd</remarks>
		public System.String MenuAd 
		{
			get { return IsMenuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MenuAdColumn]; }
			set { this[_parent.MenuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuAd is NULL, false otherwise.</summary>
		public bool IsMenuAdNull() 
		{
			return IsNull(_parent.MenuAdColumn);
		}

		/// <summary>Sets the TypedList field MenuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuAdNull() 
		{
			this[_parent.MenuAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuDurum</remarks>
		public System.Boolean MenuDurum 
		{
			get { return IsMenuDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.MenuDurumColumn]; }
			set { this[_parent.MenuDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuDurum is NULL, false otherwise.</summary>
		public bool IsMenuDurumNull() 
		{
			return IsNull(_parent.MenuDurumColumn);
		}

		/// <summary>Sets the TypedList field MenuDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuDurumNull() 
		{
			this[_parent.MenuDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuId</remarks>
		public System.Int16 MenuId 
		{
			get { return IsMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.MenuIdColumn]; }
			set { this[_parent.MenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuId is NULL, false otherwise.</summary>
		public bool IsMenuIdNull() 
		{
			return IsNull(_parent.MenuIdColumn);
		}

		/// <summary>Sets the TypedList field MenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuIdNull() 
		{
			this[_parent.MenuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuLink</remarks>
		public System.String MenuLink 
		{
			get { return IsMenuLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MenuLinkColumn]; }
			set { this[_parent.MenuLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuLink is NULL, false otherwise.</summary>
		public bool IsMenuLinkNull() 
		{
			return IsNull(_parent.MenuLinkColumn);
		}

		/// <summary>Sets the TypedList field MenuLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuLinkNull() 
		{
			this[_parent.MenuLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuSira<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuSira</remarks>
		public System.Int16 MenuSira 
		{
			get { return IsMenuSiraNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.MenuSiraColumn]; }
			set { this[_parent.MenuSiraColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuSira is NULL, false otherwise.</summary>
		public bool IsMenuSiraNull() 
		{
			return IsNull(_parent.MenuSiraColumn);
		}

		/// <summary>Sets the TypedList field MenuSira to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuSiraNull() 
		{
			this[_parent.MenuSiraColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuSonLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuSonLink</remarks>
		public System.String MenuSonLink 
		{
			get { return IsMenuSonLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MenuSonLinkColumn]; }
			set { this[_parent.MenuSonLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuSonLink is NULL, false otherwise.</summary>
		public bool IsMenuSonLinkNull() 
		{
			return IsNull(_parent.MenuSonLinkColumn);
		}

		/// <summary>Sets the TypedList field MenuSonLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuSonLinkNull() 
		{
			this[_parent.MenuSonLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MenuTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Menu.MenuTarih</remarks>
		public System.DateTime MenuTarih 
		{
			get { return IsMenuTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.MenuTarihColumn]; }
			set { this[_parent.MenuTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MenuTarih is NULL, false otherwise.</summary>
		public bool IsMenuTarihNull() 
		{
			return IsNull(_parent.MenuTarihColumn);
		}

		/// <summary>Sets the TypedList field MenuTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMenuTarihNull() 
		{
			this[_parent.MenuTarihColumn] = System.Convert.DBNull;
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
