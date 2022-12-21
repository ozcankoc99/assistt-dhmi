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
	/// <summary>Typed datatable for the list 'ListMesaj'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListMesajTypedList : TypedListBase<ListMesajRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnMesajTarih;
		private DataColumn _columnMesajId;
		private DataColumn _columnMesajIcerik;
		private DataColumn _columnMesajHangiKullanici;
		private DataColumn _columnMesajBaslik;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnKullaniciAdSoyad;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 8;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListMesajTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListMesajTypedList():base("ListMesaj")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListMesajTypedList(bool obeyWeakRelations):base("ListMesaj")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListMesajTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListMesajTypedList cloneToReturn = ((ListMesajTypedList)(base.Clone()));
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
			return new ListMesajRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(MesajEntity.Relations.KullaniciEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(MesajFields.MesajTarih, 0, "MesajTarih", "", AggregateFunction.None);
			toReturn.DefineField(MesajFields.MesajId, 1, "MesajId", "", AggregateFunction.None);
			toReturn.DefineField(MesajFields.MesajIcerik, 2, "MesajIcerik", "", AggregateFunction.None);
			toReturn.DefineField(MesajFields.MesajHangiKullanici, 3, "MesajHangiKullanici", "", AggregateFunction.None);
			toReturn.DefineField(MesajFields.MesajBaslik, 4, "MesajBaslik", "", AggregateFunction.None);
			toReturn.DefineField(MesajFields.FkKullaniciId, 5, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 6, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 7, "KullaniciAdSoyad", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("MesajTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MesajId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MesajIcerik", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MesajHangiKullanici", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MesajBaslik", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnMesajTarih = GeneralUtils.CreateTypedDataTableColumn("MesajTarih", @"MesajTarih", typeof(System.DateTime), this.Columns);
			_columnMesajId = GeneralUtils.CreateTypedDataTableColumn("MesajId", @"MesajId", typeof(System.Int64), this.Columns);
			_columnMesajIcerik = GeneralUtils.CreateTypedDataTableColumn("MesajIcerik", @"MesajIcerik", typeof(System.String), this.Columns);
			_columnMesajHangiKullanici = GeneralUtils.CreateTypedDataTableColumn("MesajHangiKullanici", @"MesajHangiKullanici", typeof(System.String), this.Columns);
			_columnMesajBaslik = GeneralUtils.CreateTypedDataTableColumn("MesajBaslik", @"MesajBaslik", typeof(System.String), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnMesajTarih = this.Columns["MesajTarih"];
			_columnMesajId = this.Columns["MesajId"];
			_columnMesajIcerik = this.Columns["MesajIcerik"];
			_columnMesajHangiKullanici = this.Columns["MesajHangiKullanici"];
			_columnMesajBaslik = this.Columns["MesajBaslik"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListMesajTypedList();
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
			get { return ListMesajTypedList.CustomProperties;}
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
			get { return ListMesajTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field MesajTarih</summary>
		internal DataColumn MesajTarihColumn 
		{
			get { return _columnMesajTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MesajId</summary>
		internal DataColumn MesajIdColumn 
		{
			get { return _columnMesajId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MesajIcerik</summary>
		internal DataColumn MesajIcerikColumn 
		{
			get { return _columnMesajIcerik; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MesajHangiKullanici</summary>
		internal DataColumn MesajHangiKullaniciColumn 
		{
			get { return _columnMesajHangiKullanici; }
		}

		/// <summary>Returns the column object belonging to the TypedList field MesajBaslik</summary>
		internal DataColumn MesajBaslikColumn 
		{
			get { return _columnMesajBaslik; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciId</summary>
		internal DataColumn KullaniciIdColumn 
		{
			get { return _columnKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KullaniciAdSoyad</summary>
		internal DataColumn KullaniciAdSoyadColumn 
		{
			get { return _columnKullaniciAdSoyad; }
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

	/// <summary>Typed datarow for the typed datatable ListMesaj</summary>
	public partial class ListMesajRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListMesajTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListMesajRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListMesajTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field MesajTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.MesajTarih</remarks>
		public System.DateTime MesajTarih 
		{
			get { return IsMesajTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.MesajTarihColumn]; }
			set { this[_parent.MesajTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MesajTarih is NULL, false otherwise.</summary>
		public bool IsMesajTarihNull() 
		{
			return IsNull(_parent.MesajTarihColumn);
		}

		/// <summary>Sets the TypedList field MesajTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMesajTarihNull() 
		{
			this[_parent.MesajTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MesajId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.MesajId</remarks>
		public System.Int64 MesajId 
		{
			get { return IsMesajIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.MesajIdColumn]; }
			set { this[_parent.MesajIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MesajId is NULL, false otherwise.</summary>
		public bool IsMesajIdNull() 
		{
			return IsNull(_parent.MesajIdColumn);
		}

		/// <summary>Sets the TypedList field MesajId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMesajIdNull() 
		{
			this[_parent.MesajIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MesajIcerik<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.MesajIcerik</remarks>
		public System.String MesajIcerik 
		{
			get { return IsMesajIcerikNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MesajIcerikColumn]; }
			set { this[_parent.MesajIcerikColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MesajIcerik is NULL, false otherwise.</summary>
		public bool IsMesajIcerikNull() 
		{
			return IsNull(_parent.MesajIcerikColumn);
		}

		/// <summary>Sets the TypedList field MesajIcerik to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMesajIcerikNull() 
		{
			this[_parent.MesajIcerikColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MesajHangiKullanici<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.MesajHangiKullanici</remarks>
		public System.String MesajHangiKullanici 
		{
			get { return IsMesajHangiKullaniciNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MesajHangiKullaniciColumn]; }
			set { this[_parent.MesajHangiKullaniciColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MesajHangiKullanici is NULL, false otherwise.</summary>
		public bool IsMesajHangiKullaniciNull() 
		{
			return IsNull(_parent.MesajHangiKullaniciColumn);
		}

		/// <summary>Sets the TypedList field MesajHangiKullanici to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMesajHangiKullaniciNull() 
		{
			this[_parent.MesajHangiKullaniciColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field MesajBaslik<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.MesajBaslik</remarks>
		public System.String MesajBaslik 
		{
			get { return IsMesajBaslikNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MesajBaslikColumn]; }
			set { this[_parent.MesajBaslikColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field MesajBaslik is NULL, false otherwise.</summary>
		public bool IsMesajBaslikNull() 
		{
			return IsNull(_parent.MesajBaslikColumn);
		}

		/// <summary>Sets the TypedList field MesajBaslik to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMesajBaslikNull() 
		{
			this[_parent.MesajBaslikColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: Mesaj.FkKullaniciId</remarks>
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
		#endregion

		#region Custom Typed List Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedListRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
