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
	/// <summary>Typed datatable for the list 'ListAltIkiMenu'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListAltIkiMenuTypedList : TypedListBase<ListAltIkiMenuRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAltAltMenuAd;
		private DataColumn _columnAltMenuAd;
		private DataColumn _columnMenuAd;
		private DataColumn _columnAltAltMenuSira;
		private DataColumn _columnAltAltMenuAciklama;
		private DataColumn _columnAltAltMenuLink;
		private DataColumn _columnAltAltMenuId;
		private DataColumn _columnFkAltMenuId;
		private DataColumn _columnFkMenuId;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 9;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListAltIkiMenuTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListAltIkiMenuTypedList():base("ListAltIkiMenu")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListAltIkiMenuTypedList(bool obeyWeakRelations):base("ListAltIkiMenu")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListAltIkiMenuTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListAltIkiMenuTypedList cloneToReturn = ((ListAltIkiMenuTypedList)(base.Clone()));
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
			return new ListAltIkiMenuRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(AltMenuEntity.Relations.AltAltMenuEntityUsingFkAltMenuId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(AltAltMenuFields.AltAltMenuAd, 0, "AltAltMenuAd", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.AltMenuAd, 1, "AltMenuAd", "", AggregateFunction.None);
			toReturn.DefineField(MenuFields.MenuAd, 2, "MenuAd", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.AltAltMenuSira, 3, "AltAltMenuSira", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.AltAltMenuAciklama, 4, "AltAltMenuAciklama", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.AltAltMenuLink, 5, "AltAltMenuLink", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.AltAltMenuId, 6, "AltAltMenuId", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.FkAltMenuId, 7, "FkAltMenuId", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.FkMenuId, 8, "FkMenuId", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("AltAltMenuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltMenuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MenuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltAltMenuSira", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltAltMenuAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltAltMenuLink", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltAltMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkAltMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkMenuId", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAltAltMenuAd = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuAd", @"AltAltMenuAd", typeof(System.String), this.Columns);
			_columnAltMenuAd = GeneralUtils.CreateTypedDataTableColumn("AltMenuAd", @"AltMenuAd", typeof(System.String), this.Columns);
			_columnMenuAd = GeneralUtils.CreateTypedDataTableColumn("MenuAd", @"MenuAd", typeof(System.String), this.Columns);
			_columnAltAltMenuSira = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuSira", @"AltAltMenuSira", typeof(System.Int16), this.Columns);
			_columnAltAltMenuAciklama = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuAciklama", @"AltAltMenuAciklama", typeof(System.String), this.Columns);
			_columnAltAltMenuLink = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuLink", @"AltAltMenuLink", typeof(System.String), this.Columns);
			_columnAltAltMenuId = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuId", @"AltAltMenuId", typeof(System.Int16), this.Columns);
			_columnFkAltMenuId = GeneralUtils.CreateTypedDataTableColumn("FkAltMenuId", @"FkAltMenuId", typeof(System.Int16), this.Columns);
			_columnFkMenuId = GeneralUtils.CreateTypedDataTableColumn("FkMenuId", @"FkMenuId", typeof(System.Int16), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnAltAltMenuAd = this.Columns["AltAltMenuAd"];
			_columnAltMenuAd = this.Columns["AltMenuAd"];
			_columnMenuAd = this.Columns["MenuAd"];
			_columnAltAltMenuSira = this.Columns["AltAltMenuSira"];
			_columnAltAltMenuAciklama = this.Columns["AltAltMenuAciklama"];
			_columnAltAltMenuLink = this.Columns["AltAltMenuLink"];
			_columnAltAltMenuId = this.Columns["AltAltMenuId"];
			_columnFkAltMenuId = this.Columns["FkAltMenuId"];
			_columnFkMenuId = this.Columns["FkMenuId"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListAltIkiMenuTypedList();
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
			get { return ListAltIkiMenuTypedList.CustomProperties;}
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
			get { return ListAltIkiMenuTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field AltAltMenuAd</summary>
		internal DataColumn AltAltMenuAdColumn 
		{
			get { return _columnAltAltMenuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltMenuAd</summary>
		internal DataColumn AltMenuAdColumn 
		{
			get { return _columnAltMenuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MenuAd</summary>
		internal DataColumn MenuAdColumn 
		{
			get { return _columnMenuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltAltMenuSira</summary>
		internal DataColumn AltAltMenuSiraColumn 
		{
			get { return _columnAltAltMenuSira; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltAltMenuAciklama</summary>
		internal DataColumn AltAltMenuAciklamaColumn 
		{
			get { return _columnAltAltMenuAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltAltMenuLink</summary>
		internal DataColumn AltAltMenuLinkColumn 
		{
			get { return _columnAltAltMenuLink; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltAltMenuId</summary>
		internal DataColumn AltAltMenuIdColumn 
		{
			get { return _columnAltAltMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkAltMenuId</summary>
		internal DataColumn FkAltMenuIdColumn 
		{
			get { return _columnFkAltMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkMenuId</summary>
		internal DataColumn FkMenuIdColumn 
		{
			get { return _columnFkMenuId; }
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

	/// <summary>Typed datarow for the typed datatable ListAltIkiMenu</summary>
	public partial class ListAltIkiMenuRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListAltIkiMenuTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListAltIkiMenuRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListAltIkiMenuTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field AltAltMenuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.AltAltMenuAd</remarks>
		public System.String AltAltMenuAd 
		{
			get { return IsAltAltMenuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltAltMenuAdColumn]; }
			set { this[_parent.AltAltMenuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltAltMenuAd is NULL, false otherwise.</summary>
		public bool IsAltAltMenuAdNull() 
		{
			return IsNull(_parent.AltAltMenuAdColumn);
		}

		/// <summary>Sets the TypedList field AltAltMenuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltAltMenuAdNull() 
		{
			this[_parent.AltAltMenuAdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field AltAltMenuSira<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.AltAltMenuSira</remarks>
		public System.Int16 AltAltMenuSira 
		{
			get { return IsAltAltMenuSiraNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.AltAltMenuSiraColumn]; }
			set { this[_parent.AltAltMenuSiraColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltAltMenuSira is NULL, false otherwise.</summary>
		public bool IsAltAltMenuSiraNull() 
		{
			return IsNull(_parent.AltAltMenuSiraColumn);
		}

		/// <summary>Sets the TypedList field AltAltMenuSira to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltAltMenuSiraNull() 
		{
			this[_parent.AltAltMenuSiraColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltAltMenuAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.AltAltMenuAciklama</remarks>
		public System.String AltAltMenuAciklama 
		{
			get { return IsAltAltMenuAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltAltMenuAciklamaColumn]; }
			set { this[_parent.AltAltMenuAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltAltMenuAciklama is NULL, false otherwise.</summary>
		public bool IsAltAltMenuAciklamaNull() 
		{
			return IsNull(_parent.AltAltMenuAciklamaColumn);
		}

		/// <summary>Sets the TypedList field AltAltMenuAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltAltMenuAciklamaNull() 
		{
			this[_parent.AltAltMenuAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltAltMenuLink<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.AltAltMenuLink</remarks>
		public System.String AltAltMenuLink 
		{
			get { return IsAltAltMenuLinkNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltAltMenuLinkColumn]; }
			set { this[_parent.AltAltMenuLinkColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltAltMenuLink is NULL, false otherwise.</summary>
		public bool IsAltAltMenuLinkNull() 
		{
			return IsNull(_parent.AltAltMenuLinkColumn);
		}

		/// <summary>Sets the TypedList field AltAltMenuLink to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltAltMenuLinkNull() 
		{
			this[_parent.AltAltMenuLinkColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltAltMenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.AltAltMenuId</remarks>
		public System.Int16 AltAltMenuId 
		{
			get { return IsAltAltMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.AltAltMenuIdColumn]; }
			set { this[_parent.AltAltMenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltAltMenuId is NULL, false otherwise.</summary>
		public bool IsAltAltMenuIdNull() 
		{
			return IsNull(_parent.AltAltMenuIdColumn);
		}

		/// <summary>Sets the TypedList field AltAltMenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltAltMenuIdNull() 
		{
			this[_parent.AltAltMenuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkAltMenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltAltMenu.FkAltMenuId</remarks>
		public System.Int16 FkAltMenuId 
		{
			get { return IsFkAltMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkAltMenuIdColumn]; }
			set { this[_parent.FkAltMenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkAltMenuId is NULL, false otherwise.</summary>
		public bool IsFkAltMenuIdNull() 
		{
			return IsNull(_parent.FkAltMenuIdColumn);
		}

		/// <summary>Sets the TypedList field FkAltMenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkAltMenuIdNull() 
		{
			this[_parent.FkAltMenuIdColumn] = System.Convert.DBNull;
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
		#endregion

		#region Custom Typed List Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
