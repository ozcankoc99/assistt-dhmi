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
	/// <summary>Typed datatable for the list 'ListKps'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListKpsTypedList : TypedListBase<ListKpsRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKpsArsivDurum;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnKpsArsivId;
		private DataColumn _columnKpsArsivTarih;
		private DataColumn _columnKpsArsivTcNo;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 7;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListKpsTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListKpsTypedList():base("ListKps")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListKpsTypedList(bool obeyWeakRelations):base("ListKps")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListKpsTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListKpsTypedList cloneToReturn = ((ListKpsTypedList)(base.Clone()));
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
			return new ListKpsRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KullaniciEntity.Relations.KpsArsivEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(KpsArsivFields.KpsArsivDurum, 0, "KpsArsivDurum", "", AggregateFunction.None);
			toReturn.DefineField(KpsArsivFields.FkKullaniciId, 1, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KpsArsivFields.KpsArsivId, 2, "KpsArsivId", "", AggregateFunction.None);
			toReturn.DefineField(KpsArsivFields.KpsArsivTarih, 3, "KpsArsivTarih", "", AggregateFunction.None);
			toReturn.DefineField(KpsArsivFields.KpsArsivTcNo, 4, "KpsArsivTcNo", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 5, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 6, "KullaniciId", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("KpsArsivDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KpsArsivId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KpsArsivTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KpsArsivTcNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKpsArsivDurum = GeneralUtils.CreateTypedDataTableColumn("KpsArsivDurum", @"KpsArsivDurum", typeof(System.Boolean), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnKpsArsivId = GeneralUtils.CreateTypedDataTableColumn("KpsArsivId", @"KpsArsivId", typeof(System.Int64), this.Columns);
			_columnKpsArsivTarih = GeneralUtils.CreateTypedDataTableColumn("KpsArsivTarih", @"KpsArsivTarih", typeof(System.DateTime), this.Columns);
			_columnKpsArsivTcNo = GeneralUtils.CreateTypedDataTableColumn("KpsArsivTcNo", @"KpsArsivTcNo", typeof(System.Int64), this.Columns);
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
			_columnKpsArsivDurum = this.Columns["KpsArsivDurum"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnKpsArsivId = this.Columns["KpsArsivId"];
			_columnKpsArsivTarih = this.Columns["KpsArsivTarih"];
			_columnKpsArsivTcNo = this.Columns["KpsArsivTcNo"];
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
			return new ListKpsTypedList();
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
			get { return ListKpsTypedList.CustomProperties;}
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
			get { return ListKpsTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field KpsArsivDurum</summary>
		internal DataColumn KpsArsivDurumColumn 
		{
			get { return _columnKpsArsivDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KpsArsivId</summary>
		internal DataColumn KpsArsivIdColumn 
		{
			get { return _columnKpsArsivId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KpsArsivTarih</summary>
		internal DataColumn KpsArsivTarihColumn 
		{
			get { return _columnKpsArsivTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KpsArsivTcNo</summary>
		internal DataColumn KpsArsivTcNoColumn 
		{
			get { return _columnKpsArsivTcNo; }
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

	/// <summary>Typed datarow for the typed datatable ListKps</summary>
	public partial class ListKpsRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListKpsTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListKpsRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListKpsTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field KpsArsivDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KpsArsiv.KpsArsivDurum</remarks>
		public System.Boolean KpsArsivDurum 
		{
			get { return IsKpsArsivDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.KpsArsivDurumColumn]; }
			set { this[_parent.KpsArsivDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KpsArsivDurum is NULL, false otherwise.</summary>
		public bool IsKpsArsivDurumNull() 
		{
			return IsNull(_parent.KpsArsivDurumColumn);
		}

		/// <summary>Sets the TypedList field KpsArsivDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKpsArsivDurumNull() 
		{
			this[_parent.KpsArsivDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KpsArsiv.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field KpsArsivId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KpsArsiv.KpsArsivId</remarks>
		public System.Int64 KpsArsivId 
		{
			get { return IsKpsArsivIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.KpsArsivIdColumn]; }
			set { this[_parent.KpsArsivIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KpsArsivId is NULL, false otherwise.</summary>
		public bool IsKpsArsivIdNull() 
		{
			return IsNull(_parent.KpsArsivIdColumn);
		}

		/// <summary>Sets the TypedList field KpsArsivId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKpsArsivIdNull() 
		{
			this[_parent.KpsArsivIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KpsArsivTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KpsArsiv.KpsArsivTarih</remarks>
		public System.DateTime KpsArsivTarih 
		{
			get { return IsKpsArsivTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KpsArsivTarihColumn]; }
			set { this[_parent.KpsArsivTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KpsArsivTarih is NULL, false otherwise.</summary>
		public bool IsKpsArsivTarihNull() 
		{
			return IsNull(_parent.KpsArsivTarihColumn);
		}

		/// <summary>Sets the TypedList field KpsArsivTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKpsArsivTarihNull() 
		{
			this[_parent.KpsArsivTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KpsArsivTcNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KpsArsiv.KpsArsivTcNo</remarks>
		public System.Int64 KpsArsivTcNo 
		{
			get { return IsKpsArsivTcNoNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.KpsArsivTcNoColumn]; }
			set { this[_parent.KpsArsivTcNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KpsArsivTcNo is NULL, false otherwise.</summary>
		public bool IsKpsArsivTcNoNull() 
		{
			return IsNull(_parent.KpsArsivTcNoColumn);
		}

		/// <summary>Sets the TypedList field KpsArsivTcNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKpsArsivTcNoNull() 
		{
			this[_parent.KpsArsivTcNoColumn] = System.Convert.DBNull;
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
