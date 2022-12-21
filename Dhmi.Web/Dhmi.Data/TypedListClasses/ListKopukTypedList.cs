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
	/// <summary>Typed datatable for the list 'ListKopuk'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListKopukTypedList : TypedListBase<ListKopukRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnFkKopukCagriTuruId;
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnKopukCagriAciklama;
		private DataColumn _columnKopukCagriId;
		private DataColumn _columnKopukCagriTarih;
		private DataColumn _columnKopukCagriTelNo;
		private DataColumn _columnKopukCagriTuruAd;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 9;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListKopukTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListKopukTypedList():base("ListKopuk")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListKopukTypedList(bool obeyWeakRelations):base("ListKopuk")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListKopukTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListKopukTypedList cloneToReturn = ((ListKopukTypedList)(base.Clone()));
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
			return new ListKopukRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KopukCagriTuruEntity.Relations.KopukCagriEntityUsingFkKopukCagriTuruId, "", "", JoinHint.Inner);
			toReturn.Add(KullaniciEntity.Relations.KopukCagriEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 0, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 1, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.FkKopukCagriTuruId, 2, "FkKopukCagriTuruId", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.FkKullaniciId, 3, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.KopukCagriAciklama, 4, "KopukCagriAciklama", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.KopukCagriId, 5, "KopukCagriId", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.KopukCagriTarih, 6, "KopukCagriTarih", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriFields.KopukCagriTelNo, 7, "KopukCagriTelNo", "", AggregateFunction.None);
			toReturn.DefineField(KopukCagriTuruFields.KopukCagriTuruAd, 8, "KopukCagriTuruAd", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKopukCagriTuruId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KopukCagriAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KopukCagriId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KopukCagriTarih", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KopukCagriTelNo", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KopukCagriTuruAd", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnFkKopukCagriTuruId = GeneralUtils.CreateTypedDataTableColumn("FkKopukCagriTuruId", @"FkKopukCagriTuruId", typeof(System.Int16), this.Columns);
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnKopukCagriAciklama = GeneralUtils.CreateTypedDataTableColumn("KopukCagriAciklama", @"KopukCagriAciklama", typeof(System.String), this.Columns);
			_columnKopukCagriId = GeneralUtils.CreateTypedDataTableColumn("KopukCagriId", @"KopukCagriId", typeof(System.Int64), this.Columns);
			_columnKopukCagriTarih = GeneralUtils.CreateTypedDataTableColumn("KopukCagriTarih", @"KopukCagriTarih", typeof(System.DateTime), this.Columns);
			_columnKopukCagriTelNo = GeneralUtils.CreateTypedDataTableColumn("KopukCagriTelNo", @"KopukCagriTelNo", typeof(System.String), this.Columns);
			_columnKopukCagriTuruAd = GeneralUtils.CreateTypedDataTableColumn("KopukCagriTuruAd", @"KopukCagriTuruAd", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnFkKopukCagriTuruId = this.Columns["FkKopukCagriTuruId"];
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnKopukCagriAciklama = this.Columns["KopukCagriAciklama"];
			_columnKopukCagriId = this.Columns["KopukCagriId"];
			_columnKopukCagriTarih = this.Columns["KopukCagriTarih"];
			_columnKopukCagriTelNo = this.Columns["KopukCagriTelNo"];
			_columnKopukCagriTuruAd = this.Columns["KopukCagriTuruAd"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListKopukTypedList();
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
			get { return ListKopukTypedList.CustomProperties;}
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
			get { return ListKopukTypedList.FieldsCustomProperties;}
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

		/// <summary>Returns the column object belonging to the TypedList field FkKopukCagriTuruId</summary>
		internal DataColumn FkKopukCagriTuruIdColumn 
		{
			get { return _columnFkKopukCagriTuruId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KopukCagriAciklama</summary>
		internal DataColumn KopukCagriAciklamaColumn 
		{
			get { return _columnKopukCagriAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KopukCagriId</summary>
		internal DataColumn KopukCagriIdColumn 
		{
			get { return _columnKopukCagriId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KopukCagriTarih</summary>
		internal DataColumn KopukCagriTarihColumn 
		{
			get { return _columnKopukCagriTarih; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KopukCagriTelNo</summary>
		internal DataColumn KopukCagriTelNoColumn 
		{
			get { return _columnKopukCagriTelNo; }
		}

		/// <summary>Returns the column object belonging to the TypedList field KopukCagriTuruAd</summary>
		internal DataColumn KopukCagriTuruAdColumn 
		{
			get { return _columnKopukCagriTuruAd; }
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

	/// <summary>Typed datarow for the typed datatable ListKopuk</summary>
	public partial class ListKopukRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListKopukTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListKopukRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListKopukTypedList)(this.Table));
		}

		#region Class Property Declarations
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
		/// <summary>Gets / sets the value of the TypedList field FkKopukCagriTuruId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.FkKopukCagriTuruId</remarks>
		public System.Int16 FkKopukCagriTuruId 
		{
			get { return IsFkKopukCagriTuruIdNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.FkKopukCagriTuruIdColumn]; }
			set { this[_parent.FkKopukCagriTuruIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field FkKopukCagriTuruId is NULL, false otherwise.</summary>
		public bool IsFkKopukCagriTuruIdNull() 
		{
			return IsNull(_parent.FkKopukCagriTuruIdColumn);
		}

		/// <summary>Sets the TypedList field FkKopukCagriTuruId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetFkKopukCagriTuruIdNull() 
		{
			this[_parent.FkKopukCagriTuruIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field KopukCagriAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.KopukCagriAciklama</remarks>
		public System.String KopukCagriAciklama 
		{
			get { return IsKopukCagriAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KopukCagriAciklamaColumn]; }
			set { this[_parent.KopukCagriAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KopukCagriAciklama is NULL, false otherwise.</summary>
		public bool IsKopukCagriAciklamaNull() 
		{
			return IsNull(_parent.KopukCagriAciklamaColumn);
		}

		/// <summary>Sets the TypedList field KopukCagriAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKopukCagriAciklamaNull() 
		{
			this[_parent.KopukCagriAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KopukCagriId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.KopukCagriId</remarks>
		public System.Int64 KopukCagriId 
		{
			get { return IsKopukCagriIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.KopukCagriIdColumn]; }
			set { this[_parent.KopukCagriIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KopukCagriId is NULL, false otherwise.</summary>
		public bool IsKopukCagriIdNull() 
		{
			return IsNull(_parent.KopukCagriIdColumn);
		}

		/// <summary>Sets the TypedList field KopukCagriId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKopukCagriIdNull() 
		{
			this[_parent.KopukCagriIdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KopukCagriTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.KopukCagriTarih</remarks>
		public System.DateTime KopukCagriTarih 
		{
			get { return IsKopukCagriTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.KopukCagriTarihColumn]; }
			set { this[_parent.KopukCagriTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KopukCagriTarih is NULL, false otherwise.</summary>
		public bool IsKopukCagriTarihNull() 
		{
			return IsNull(_parent.KopukCagriTarihColumn);
		}

		/// <summary>Sets the TypedList field KopukCagriTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKopukCagriTarihNull() 
		{
			this[_parent.KopukCagriTarihColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KopukCagriTelNo<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagri.KopukCagriTelNo</remarks>
		public System.String KopukCagriTelNo 
		{
			get { return IsKopukCagriTelNoNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KopukCagriTelNoColumn]; }
			set { this[_parent.KopukCagriTelNoColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KopukCagriTelNo is NULL, false otherwise.</summary>
		public bool IsKopukCagriTelNoNull() 
		{
			return IsNull(_parent.KopukCagriTelNoColumn);
		}

		/// <summary>Sets the TypedList field KopukCagriTelNo to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKopukCagriTelNoNull() 
		{
			this[_parent.KopukCagriTelNoColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field KopukCagriTuruAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: KopukCagriTuru.KopukCagriTuruAd</remarks>
		public System.String KopukCagriTuruAd 
		{
			get { return IsKopukCagriTuruAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.KopukCagriTuruAdColumn]; }
			set { this[_parent.KopukCagriTuruAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field KopukCagriTuruAd is NULL, false otherwise.</summary>
		public bool IsKopukCagriTuruAdNull() 
		{
			return IsNull(_parent.KopukCagriTuruAdColumn);
		}

		/// <summary>Sets the TypedList field KopukCagriTuruAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetKopukCagriTuruAdNull() 
		{
			this[_parent.KopukCagriTuruAdColumn] = System.Convert.DBNull;
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
