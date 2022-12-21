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
	/// <summary>Typed datatable for the list 'ListKonu'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListKonuTypedList : TypedListBase<ListKonuRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnAltKonuAd;
		private DataColumn _columnAltKonuDurum;
		private DataColumn _columnAltKonuId;
		private DataColumn _columnAltKonuTarih;
		private DataColumn _columnFkKonuId;
		private DataColumn _columnKonuAd;
		private DataColumn _columnKonuDurum;
		private DataColumn _columnKonuId;
		private DataColumn _columnKonuTarih;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 9;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListKonuTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListKonuTypedList():base("ListKonu")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListKonuTypedList(bool obeyWeakRelations):base("ListKonu")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListKonuTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListKonuTypedList cloneToReturn = ((ListKonuTypedList)(base.Clone()));
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
			return new ListKonuRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KonuEntity.Relations.AltKonuEntityUsingFkKonuId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(AltKonuFields.AltKonuAd, 0, "AltKonuAd", "", AggregateFunction.None);
			toReturn.DefineField(AltKonuFields.AltKonuDurum, 1, "AltKonuDurum", "", AggregateFunction.None);
			toReturn.DefineField(AltKonuFields.AltKonuId, 2, "AltKonuId", "", AggregateFunction.None);
			toReturn.DefineField(AltKonuFields.AltKonuTarih, 3, "AltKonuTarih", "", AggregateFunction.None);
			toReturn.DefineField(AltKonuFields.FkKonuId, 4, "FkKonuId", "", AggregateFunction.None);
			toReturn.DefineField(KonuFields.KonuAd, 5, "KonuAd", "", AggregateFunction.None);
			toReturn.DefineField(KonuFields.KonuDurum, 6, "KonuDurum", "", AggregateFunction.None);
			toReturn.DefineField(KonuFields.KonuId, 7, "KonuId", "", AggregateFunction.None);
			toReturn.DefineField(KonuFields.KonuTarih, 8, "KonuTarih", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("AltKonuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltKonuDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltKonuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("AltKonuTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKonuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KonuAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KonuDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KonuId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KonuTarih", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnAltKonuAd = GeneralUtils.CreateTypedDataTableColumn("AltKonuAd", @"AltKonuAd", typeof(System.String), this.Columns);
			_columnAltKonuDurum = GeneralUtils.CreateTypedDataTableColumn("AltKonuDurum", @"AltKonuDurum", typeof(System.Boolean), this.Columns);
			_columnAltKonuId = GeneralUtils.CreateTypedDataTableColumn("AltKonuId", @"AltKonuId", typeof(System.Int64), this.Columns);
			_columnAltKonuTarih = GeneralUtils.CreateTypedDataTableColumn("AltKonuTarih", @"AltKonuTarih", typeof(System.DateTime), this.Columns);
			_columnFkKonuId = GeneralUtils.CreateTypedDataTableColumn("FkKonuId", @"FkKonuId", typeof(System.Int64), this.Columns);
			_columnKonuAd = GeneralUtils.CreateTypedDataTableColumn("KonuAd", @"KonuAd", typeof(System.String), this.Columns);
			_columnKonuDurum = GeneralUtils.CreateTypedDataTableColumn("KonuDurum", @"KonuDurum", typeof(System.Boolean), this.Columns);
			_columnKonuId = GeneralUtils.CreateTypedDataTableColumn("KonuId", @"KonuId", typeof(System.Int64), this.Columns);
			_columnKonuTarih = GeneralUtils.CreateTypedDataTableColumn("KonuTarih", @"KonuTarih", typeof(System.DateTime), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnAltKonuAd = this.Columns["AltKonuAd"];
			_columnAltKonuDurum = this.Columns["AltKonuDurum"];
			_columnAltKonuId = this.Columns["AltKonuId"];
			_columnAltKonuTarih = this.Columns["AltKonuTarih"];
			_columnFkKonuId = this.Columns["FkKonuId"];
			_columnKonuAd = this.Columns["KonuAd"];
			_columnKonuDurum = this.Columns["KonuDurum"];
			_columnKonuId = this.Columns["KonuId"];
			_columnKonuTarih = this.Columns["KonuTarih"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListKonuTypedList();
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
			get { return ListKonuTypedList.CustomProperties;}
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
			get { return ListKonuTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field AltKonuAd</summary>
		internal DataColumn AltKonuAdColumn 
		{
			get { return _columnAltKonuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltKonuDurum</summary>
		internal DataColumn AltKonuDurumColumn 
		{
			get { return _columnAltKonuDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltKonuId</summary>
		internal DataColumn AltKonuIdColumn 
		{
			get { return _columnAltKonuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field AltKonuTarih</summary>
		internal DataColumn AltKonuTarihColumn 
		{
			get { return _columnAltKonuTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKonuId</summary>
		internal DataColumn FkKonuIdColumn 
		{
			get { return _columnFkKonuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KonuAd</summary>
		internal DataColumn KonuAdColumn 
		{
			get { return _columnKonuAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KonuDurum</summary>
		internal DataColumn KonuDurumColumn 
		{
			get { return _columnKonuDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KonuId</summary>
		internal DataColumn KonuIdColumn 
		{
			get { return _columnKonuId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KonuTarih</summary>
		internal DataColumn KonuTarihColumn 
		{
			get { return _columnKonuTarih; }
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

	/// <summary>Typed datarow for the typed datatable ListKonu</summary>
	public partial class ListKonuRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListKonuTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListKonuRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListKonuTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field AltKonuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.AltKonuAd</remarks>
		public System.String AltKonuAd 
		{
			get { return IsAltKonuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.AltKonuAdColumn]; }
			set { this[_parent.AltKonuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltKonuAd is NULL, false otherwise.</summary>
		public bool IsAltKonuAdNull() 
		{
			return IsNull(_parent.AltKonuAdColumn);
		}

		/// <summary>Sets the TypedList field AltKonuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltKonuAdNull() 
		{
			this[_parent.AltKonuAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltKonuDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.AltKonuDurum</remarks>
		public System.Boolean AltKonuDurum 
		{
			get { return IsAltKonuDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.AltKonuDurumColumn]; }
			set { this[_parent.AltKonuDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltKonuDurum is NULL, false otherwise.</summary>
		public bool IsAltKonuDurumNull() 
		{
			return IsNull(_parent.AltKonuDurumColumn);
		}

		/// <summary>Sets the TypedList field AltKonuDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltKonuDurumNull() 
		{
			this[_parent.AltKonuDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltKonuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.AltKonuId</remarks>
		public System.Int64 AltKonuId 
		{
			get { return IsAltKonuIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.AltKonuIdColumn]; }
			set { this[_parent.AltKonuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltKonuId is NULL, false otherwise.</summary>
		public bool IsAltKonuIdNull() 
		{
			return IsNull(_parent.AltKonuIdColumn);
		}

		/// <summary>Sets the TypedList field AltKonuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltKonuIdNull() 
		{
			this[_parent.AltKonuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field AltKonuTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.AltKonuTarih</remarks>
		public System.DateTime AltKonuTarih 
		{
			get { return IsAltKonuTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.AltKonuTarihColumn]; }
			set { this[_parent.AltKonuTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field AltKonuTarih is NULL, false otherwise.</summary>
		public bool IsAltKonuTarihNull() 
		{
			return IsNull(_parent.AltKonuTarihColumn);
		}

		/// <summary>Sets the TypedList field AltKonuTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetAltKonuTarihNull() 
		{
			this[_parent.AltKonuTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKonuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: AltKonu.FkKonuId</remarks>
		public System.Int64 FkKonuId 
		{
			get { return IsFkKonuIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.FkKonuIdColumn]; }
			set { this[_parent.FkKonuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKonuId is NULL, false otherwise.</summary>
		public bool IsFkKonuIdNull() 
		{
			return IsNull(_parent.FkKonuIdColumn);
		}

		/// <summary>Sets the TypedList field FkKonuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKonuIdNull() 
		{
			this[_parent.FkKonuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KonuAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Konu.KonuAd</remarks>
		public System.String KonuAd 
		{
			get { return IsKonuAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KonuAdColumn]; }
			set { this[_parent.KonuAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KonuAd is NULL, false otherwise.</summary>
		public bool IsKonuAdNull() 
		{
			return IsNull(_parent.KonuAdColumn);
		}

		/// <summary>Sets the TypedList field KonuAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKonuAdNull() 
		{
			this[_parent.KonuAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KonuDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Konu.KonuDurum</remarks>
		public System.Boolean KonuDurum 
		{
			get { return IsKonuDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.KonuDurumColumn]; }
			set { this[_parent.KonuDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KonuDurum is NULL, false otherwise.</summary>
		public bool IsKonuDurumNull() 
		{
			return IsNull(_parent.KonuDurumColumn);
		}

		/// <summary>Sets the TypedList field KonuDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKonuDurumNull() 
		{
			this[_parent.KonuDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KonuId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Konu.KonuId</remarks>
		public System.Int64 KonuId 
		{
			get { return IsKonuIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.KonuIdColumn]; }
			set { this[_parent.KonuIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KonuId is NULL, false otherwise.</summary>
		public bool IsKonuIdNull() 
		{
			return IsNull(_parent.KonuIdColumn);
		}

		/// <summary>Sets the TypedList field KonuId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKonuIdNull() 
		{
			this[_parent.KonuIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KonuTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Konu.KonuTarih</remarks>
		public System.DateTime KonuTarih 
		{
			get { return IsKonuTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KonuTarihColumn]; }
			set { this[_parent.KonuTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KonuTarih is NULL, false otherwise.</summary>
		public bool IsKonuTarihNull() 
		{
			return IsNull(_parent.KonuTarihColumn);
		}

		/// <summary>Sets the TypedList field KonuTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKonuTarihNull() 
		{
			this[_parent.KonuTarihColumn] = System.Convert.DBNull;
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
