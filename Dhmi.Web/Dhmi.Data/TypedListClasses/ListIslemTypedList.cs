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
	/// <summary>Typed datatable for the list 'ListIslem'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListIslemTypedList : TypedListBase<ListIslemRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAltAltMenuAd;
		private DataColumn _columnAltMenuAd;
		private DataColumn _columnMenuAd;
		private DataColumn _columnIslemTuruAd;
		private DataColumn _columnIslemSira;
		private DataColumn _columnIslemId;
		private DataColumn _columnIslemAd;
		private DataColumn _columnIslemTarih;
		private DataColumn _columnFkAltAltMenuId;
		private DataColumn _columnFkAltMenuId;
		private DataColumn _columnFkAltMenuId_;
		private DataColumn _columnFkIslemTuruId;
		private DataColumn _columnFkMenuId;
		private DataColumn _columnFkMenuId_;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 14;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListIslemTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListIslemTypedList():base("ListIslem")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListIslemTypedList(bool obeyWeakRelations):base("ListIslem")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListIslemTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListIslemTypedList cloneToReturn = ((ListIslemTypedList)(base.Clone()));
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
			return new ListIslemRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(AltMenuEntity.Relations.AltAltMenuEntityUsingFkAltMenuId, "", "", JoinHint.Inner);
			toReturn.Add(IslemEntity.Relations.AltAltMenuEntityUsingFkAltAltMenuId, "", "", JoinHint.Inner);
			toReturn.Add(MenuEntity.Relations.AltMenuEntityUsingFkMenuId, "", "", JoinHint.Inner);
			toReturn.Add(IslemTuruEntity.Relations.IslemEntityUsingFkIslemTuruId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(IslemTuruFields.IslemTuruAd, 3, "IslemTuruAd", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.IslemSira, 4, "IslemSira", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.IslemId, 5, "IslemId", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.IslemAd, 6, "IslemAd", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.IslemTarih, 7, "IslemTarih", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.FkAltAltMenuId, 8, "FkAltAltMenuId", "", AggregateFunction.None);
			toReturn.DefineField(AltAltMenuFields.FkAltMenuId, 9, "FkAltMenuId", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.FkAltMenuId, 10, "FkAltMenuId_", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.FkIslemTuruId, 11, "FkIslemTuruId", "", AggregateFunction.None);
			toReturn.DefineField(AltMenuFields.FkMenuId, 12, "FkMenuId", "", AggregateFunction.None);
			toReturn.DefineField(IslemFields.FkMenuId, 13, "FkMenuId_", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("IslemTuruAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IslemSira", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IslemId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IslemAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IslemTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkAltAltMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkAltMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkAltMenuId_", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkIslemTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkMenuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkMenuId_", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAltAltMenuAd = GeneralUtils.CreateTypedDataTableColumn("AltAltMenuAd", @"AltAltMenuAd", typeof(System.String), this.Columns);
			_columnAltMenuAd = GeneralUtils.CreateTypedDataTableColumn("AltMenuAd", @"AltMenuAd", typeof(System.String), this.Columns);
			_columnMenuAd = GeneralUtils.CreateTypedDataTableColumn("MenuAd", @"MenuAd", typeof(System.String), this.Columns);
			_columnIslemTuruAd = GeneralUtils.CreateTypedDataTableColumn("IslemTuruAd", @"IslemTuruAd", typeof(System.String), this.Columns);
			_columnIslemSira = GeneralUtils.CreateTypedDataTableColumn("IslemSira", @"IslemSira", typeof(System.Int16), this.Columns);
			_columnIslemId = GeneralUtils.CreateTypedDataTableColumn("IslemId", @"IslemId", typeof(System.Int16), this.Columns);
			_columnIslemAd = GeneralUtils.CreateTypedDataTableColumn("IslemAd", @"IslemAd", typeof(System.String), this.Columns);
			_columnIslemTarih = GeneralUtils.CreateTypedDataTableColumn("IslemTarih", @"IslemTarih", typeof(System.DateTime), this.Columns);
			_columnFkAltAltMenuId = GeneralUtils.CreateTypedDataTableColumn("FkAltAltMenuId", @"FkAltAltMenuId", typeof(System.Int16), this.Columns);
			_columnFkAltMenuId = GeneralUtils.CreateTypedDataTableColumn("FkAltMenuId", @"FkAltMenuId", typeof(System.Int16), this.Columns);
			_columnFkAltMenuId_ = GeneralUtils.CreateTypedDataTableColumn("FkAltMenuId_", @"FkAltMenuId", typeof(System.Int16), this.Columns);
			_columnFkIslemTuruId = GeneralUtils.CreateTypedDataTableColumn("FkIslemTuruId", @"FkIslemTuruId", typeof(System.Int16), this.Columns);
			_columnFkMenuId = GeneralUtils.CreateTypedDataTableColumn("FkMenuId", @"FkMenuId", typeof(System.Int16), this.Columns);
			_columnFkMenuId_ = GeneralUtils.CreateTypedDataTableColumn("FkMenuId_", @"FkMenuId", typeof(System.Int16), this.Columns);

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
			_columnIslemTuruAd = this.Columns["IslemTuruAd"];
			_columnIslemSira = this.Columns["IslemSira"];
			_columnIslemId = this.Columns["IslemId"];
			_columnIslemAd = this.Columns["IslemAd"];
			_columnIslemTarih = this.Columns["IslemTarih"];
			_columnFkAltAltMenuId = this.Columns["FkAltAltMenuId"];
			_columnFkAltMenuId = this.Columns["FkAltMenuId"];
			_columnFkAltMenuId_ = this.Columns["FkAltMenuId_"];
			_columnFkIslemTuruId = this.Columns["FkIslemTuruId"];
			_columnFkMenuId = this.Columns["FkMenuId"];
			_columnFkMenuId_ = this.Columns["FkMenuId_"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListIslemTypedList();
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
			get { return ListIslemTypedList.CustomProperties;}
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
			get { return ListIslemTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field IslemTuruAd</summary>
		internal DataColumn IslemTuruAdColumn 
		{
			get { return _columnIslemTuruAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IslemSira</summary>
		internal DataColumn IslemSiraColumn 
		{
			get { return _columnIslemSira; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IslemId</summary>
		internal DataColumn IslemIdColumn 
		{
			get { return _columnIslemId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IslemAd</summary>
		internal DataColumn IslemAdColumn 
		{
			get { return _columnIslemAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IslemTarih</summary>
		internal DataColumn IslemTarihColumn 
		{
			get { return _columnIslemTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkAltAltMenuId</summary>
		internal DataColumn FkAltAltMenuIdColumn 
		{
			get { return _columnFkAltAltMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkAltMenuId</summary>
		internal DataColumn FkAltMenuIdColumn 
		{
			get { return _columnFkAltMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkAltMenuId_</summary>
		internal DataColumn FkAltMenuId_Column 
		{
			get { return _columnFkAltMenuId_; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkIslemTuruId</summary>
		internal DataColumn FkIslemTuruIdColumn 
		{
			get { return _columnFkIslemTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkMenuId</summary>
		internal DataColumn FkMenuIdColumn 
		{
			get { return _columnFkMenuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkMenuId_</summary>
		internal DataColumn FkMenuId_Column 
		{
			get { return _columnFkMenuId_; }
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

	/// <summary>Typed datarow for the typed datatable ListIslem</summary>
	public partial class ListIslemRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListIslemTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListIslemRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListIslemTypedList)(this.Table));
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
		/// <summary>Gets / sets the value of the TypedList field IslemTuruAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IslemTuru.IslemTuruAd</remarks>
		public System.String IslemTuruAd 
		{
			get { return IsIslemTuruAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.IslemTuruAdColumn]; }
			set { this[_parent.IslemTuruAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IslemTuruAd is NULL, false otherwise.</summary>
		public bool IsIslemTuruAdNull() 
		{
			return IsNull(_parent.IslemTuruAdColumn);
		}

		/// <summary>Sets the TypedList field IslemTuruAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIslemTuruAdNull() 
		{
			this[_parent.IslemTuruAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IslemSira<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.IslemSira</remarks>
		public System.Int16 IslemSira 
		{
			get { return IsIslemSiraNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.IslemSiraColumn]; }
			set { this[_parent.IslemSiraColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IslemSira is NULL, false otherwise.</summary>
		public bool IsIslemSiraNull() 
		{
			return IsNull(_parent.IslemSiraColumn);
		}

		/// <summary>Sets the TypedList field IslemSira to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIslemSiraNull() 
		{
			this[_parent.IslemSiraColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IslemId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.IslemId</remarks>
		public System.Int16 IslemId 
		{
			get { return IsIslemIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.IslemIdColumn]; }
			set { this[_parent.IslemIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IslemId is NULL, false otherwise.</summary>
		public bool IsIslemIdNull() 
		{
			return IsNull(_parent.IslemIdColumn);
		}

		/// <summary>Sets the TypedList field IslemId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIslemIdNull() 
		{
			this[_parent.IslemIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IslemAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.IslemAd</remarks>
		public System.String IslemAd 
		{
			get { return IsIslemAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.IslemAdColumn]; }
			set { this[_parent.IslemAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IslemAd is NULL, false otherwise.</summary>
		public bool IsIslemAdNull() 
		{
			return IsNull(_parent.IslemAdColumn);
		}

		/// <summary>Sets the TypedList field IslemAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIslemAdNull() 
		{
			this[_parent.IslemAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IslemTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.IslemTarih</remarks>
		public System.DateTime IslemTarih 
		{
			get { return IsIslemTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.IslemTarihColumn]; }
			set { this[_parent.IslemTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IslemTarih is NULL, false otherwise.</summary>
		public bool IsIslemTarihNull() 
		{
			return IsNull(_parent.IslemTarihColumn);
		}

		/// <summary>Sets the TypedList field IslemTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIslemTarihNull() 
		{
			this[_parent.IslemTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkAltAltMenuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.FkAltAltMenuId</remarks>
		public System.Int16 FkAltAltMenuId 
		{
			get { return IsFkAltAltMenuIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkAltAltMenuIdColumn]; }
			set { this[_parent.FkAltAltMenuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkAltAltMenuId is NULL, false otherwise.</summary>
		public bool IsFkAltAltMenuIdNull() 
		{
			return IsNull(_parent.FkAltAltMenuIdColumn);
		}

		/// <summary>Sets the TypedList field FkAltAltMenuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkAltAltMenuIdNull() 
		{
			this[_parent.FkAltAltMenuIdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field FkAltMenuId_<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.FkAltMenuId</remarks>
		public System.Int16 FkAltMenuId_ 
		{
			get { return IsFkAltMenuId_Null() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkAltMenuId_Column]; }
			set { this[_parent.FkAltMenuId_Column] = value; }
		}

		/// <summary>Returns true if the TypedList field FkAltMenuId_ is NULL, false otherwise.</summary>
		public bool IsFkAltMenuId_Null() 
		{
			return IsNull(_parent.FkAltMenuId_Column);
		}

		/// <summary>Sets the TypedList field FkAltMenuId_ to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkAltMenuId_Null() 
		{
			this[_parent.FkAltMenuId_Column] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkIslemTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.FkIslemTuruId</remarks>
		public System.Int16 FkIslemTuruId 
		{
			get { return IsFkIslemTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkIslemTuruIdColumn]; }
			set { this[_parent.FkIslemTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkIslemTuruId is NULL, false otherwise.</summary>
		public bool IsFkIslemTuruIdNull() 
		{
			return IsNull(_parent.FkIslemTuruIdColumn);
		}

		/// <summary>Sets the TypedList field FkIslemTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkIslemTuruIdNull() 
		{
			this[_parent.FkIslemTuruIdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field FkMenuId_<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Islem.FkMenuId</remarks>
		public System.Int16 FkMenuId_ 
		{
			get { return IsFkMenuId_Null() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkMenuId_Column]; }
			set { this[_parent.FkMenuId_Column] = value; }
		}

		/// <summary>Returns true if the TypedList field FkMenuId_ is NULL, false otherwise.</summary>
		public bool IsFkMenuId_Null() 
		{
			return IsNull(_parent.FkMenuId_Column);
		}

		/// <summary>Sets the TypedList field FkMenuId_ to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkMenuId_Null() 
		{
			this[_parent.FkMenuId_Column] = System.Convert.DBNull;
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
