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
	/// <summary>Typed datatable for the list 'ListIp'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class ListIpTypedList : TypedListBase<ListIpRow>
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesList
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnFkKullaniciId;
		private DataColumn _columnIpBanksAciklama;
		private DataColumn _columnIpBanksAd;
		private DataColumn _columnIpBanksId;
		private DataColumn _columnKullaniciAdSoyad;
		private DataColumn _columnKullaniciId;
		private DataColumn _columnIpBanksDurum;
		private DataColumn _columnIpBanksTarih;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		private const int AmountOfFields = 8;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static ListIpTypedList()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary>CTor</summary>
		public ListIpTypedList():base("ListIp")
		{
			InitClass(false);
		}
		
		/// <summary>CTor</summary>
		/// <param name="obeyWeakRelations">The flag to signal the typed list what kind of join statements to generate in the query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order. When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.</param>
		public ListIpTypedList(bool obeyWeakRelations):base("ListIp")
		{
			InitClass(obeyWeakRelations);
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ListIpTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif		

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			ListIpTypedList cloneToReturn = ((ListIpTypedList)(base.Clone()));
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
			return new ListIpRow(rowBuilder);
		}

		/// <summary>Builds the relation set for this typed list.</summary>
		/// <returns>ready to use relation set</returns>
		protected override IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = this.ObeyWeakRelations;
			toReturn.Add(KullaniciEntity.Relations.IpBankEntityUsingFkKullaniciId, "", "", JoinHint.Inner);
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
			toReturn.DefineField(IpBankFields.FkKullaniciId, 0, "FkKullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(IpBankFields.IpBanksAciklama, 1, "IpBanksAciklama", "", AggregateFunction.None);
			toReturn.DefineField(IpBankFields.IpBanksAd, 2, "IpBanksAd", "", AggregateFunction.None);
			toReturn.DefineField(IpBankFields.IpBanksId, 3, "IpBanksId", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciAdSoyad, 4, "KullaniciAdSoyad", "", AggregateFunction.None);
			toReturn.DefineField(KullaniciFields.KullaniciId, 5, "KullaniciId", "", AggregateFunction.None);
			toReturn.DefineField(IpBankFields.IpBanksDurum, 6, "IpBanksDurum", "", AggregateFunction.None);
			toReturn.DefineField(IpBankFields.IpBanksTarih, 7, "IpBanksTarih", "", AggregateFunction.None);
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
			_fieldsCustomProperties.Add("FkKullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IpBanksAciklama", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IpBanksAd", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IpBanksId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciAdSoyad", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("KullaniciId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IpBanksDurum", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("IpBanksTarih", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		protected override void InitClass(bool obeyWeakRelations)
		{
			_columnFkKullaniciId = GeneralUtils.CreateTypedDataTableColumn("FkKullaniciId", @"FkKullaniciId", typeof(System.Int16), this.Columns);
			_columnIpBanksAciklama = GeneralUtils.CreateTypedDataTableColumn("IpBanksAciklama", @"IpBanksAciklama", typeof(System.String), this.Columns);
			_columnIpBanksAd = GeneralUtils.CreateTypedDataTableColumn("IpBanksAd", @"IpBanksAd", typeof(System.String), this.Columns);
			_columnIpBanksId = GeneralUtils.CreateTypedDataTableColumn("IpBanksId", @"IpBanksId", typeof(System.Int64), this.Columns);
			_columnKullaniciAdSoyad = GeneralUtils.CreateTypedDataTableColumn("KullaniciAdSoyad", @"KullaniciAdSoyad", typeof(System.String), this.Columns);
			_columnKullaniciId = GeneralUtils.CreateTypedDataTableColumn("KullaniciId", @"KullaniciId", typeof(System.Int16), this.Columns);
			_columnIpBanksDurum = GeneralUtils.CreateTypedDataTableColumn("IpBanksDurum", @"IpBanksDurum", typeof(System.Boolean), this.Columns);
			_columnIpBanksTarih = GeneralUtils.CreateTypedDataTableColumn("IpBanksTarih", @"IpBanksTarih", typeof(System.DateTime), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			this.ObeyWeakRelations = obeyWeakRelations;
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnFkKullaniciId = this.Columns["FkKullaniciId"];
			_columnIpBanksAciklama = this.Columns["IpBanksAciklama"];
			_columnIpBanksAd = this.Columns["IpBanksAd"];
			_columnIpBanksId = this.Columns["IpBanksId"];
			_columnKullaniciAdSoyad = this.Columns["KullaniciAdSoyad"];
			_columnKullaniciId = this.Columns["KullaniciId"];
			_columnIpBanksDurum = this.Columns["IpBanksDurum"];
			_columnIpBanksTarih = this.Columns["IpBanksTarih"];

			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new ListIpTypedList();
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
			get { return ListIpTypedList.CustomProperties;}
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
			get { return ListIpTypedList.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedList field FkKullaniciId</summary>
		internal DataColumn FkKullaniciIdColumn 
		{
			get { return _columnFkKullaniciId; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IpBanksAciklama</summary>
		internal DataColumn IpBanksAciklamaColumn 
		{
			get { return _columnIpBanksAciklama; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IpBanksAd</summary>
		internal DataColumn IpBanksAdColumn 
		{
			get { return _columnIpBanksAd; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IpBanksId</summary>
		internal DataColumn IpBanksIdColumn 
		{
			get { return _columnIpBanksId; }
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

		/// <summary>Returns the column object belonging to the TypedList field IpBanksDurum</summary>
		internal DataColumn IpBanksDurumColumn 
		{
			get { return _columnIpBanksDurum; }
		}

		/// <summary>Returns the column object belonging to the TypedList field IpBanksTarih</summary>
		internal DataColumn IpBanksTarihColumn 
		{
			get { return _columnIpBanksTarih; }
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

	/// <summary>Typed datarow for the typed datatable ListIp</summary>
	public partial class ListIpRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private ListIpTypedList	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal ListIpRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((ListIpTypedList)(this.Table));
		}

		#region Class Property Declarations
		/// <summary>Gets / sets the value of the TypedList field FkKullaniciId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.FkKullaniciId</remarks>
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
		/// <summary>Gets / sets the value of the TypedList field IpBanksAciklama<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.IpBanksAciklama</remarks>
		public System.String IpBanksAciklama 
		{
			get { return IsIpBanksAciklamaNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.IpBanksAciklamaColumn]; }
			set { this[_parent.IpBanksAciklamaColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IpBanksAciklama is NULL, false otherwise.</summary>
		public bool IsIpBanksAciklamaNull() 
		{
			return IsNull(_parent.IpBanksAciklamaColumn);
		}

		/// <summary>Sets the TypedList field IpBanksAciklama to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIpBanksAciklamaNull() 
		{
			this[_parent.IpBanksAciklamaColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IpBanksAd<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.IpBanksAd</remarks>
		public System.String IpBanksAd 
		{
			get { return IsIpBanksAdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.IpBanksAdColumn]; }
			set { this[_parent.IpBanksAdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IpBanksAd is NULL, false otherwise.</summary>
		public bool IsIpBanksAdNull() 
		{
			return IsNull(_parent.IpBanksAdColumn);
		}

		/// <summary>Sets the TypedList field IpBanksAd to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIpBanksAdNull() 
		{
			this[_parent.IpBanksAdColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IpBanksId<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.IpBanksId</remarks>
		public System.Int64 IpBanksId 
		{
			get { return IsIpBanksIdNull() ? (System.Int64)TypeDefaultValue.GetDefaultValue(typeof(System.Int64)) : (System.Int64)this[_parent.IpBanksIdColumn]; }
			set { this[_parent.IpBanksIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IpBanksId is NULL, false otherwise.</summary>
		public bool IsIpBanksIdNull() 
		{
			return IsNull(_parent.IpBanksIdColumn);
		}

		/// <summary>Sets the TypedList field IpBanksId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIpBanksIdNull() 
		{
			this[_parent.IpBanksIdColumn] = System.Convert.DBNull;
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
		/// <summary>Gets / sets the value of the TypedList field IpBanksDurum<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.IpBanksDurum</remarks>
		public System.Boolean IpBanksDurum 
		{
			get { return IsIpBanksDurumNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.IpBanksDurumColumn]; }
			set { this[_parent.IpBanksDurumColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IpBanksDurum is NULL, false otherwise.</summary>
		public bool IsIpBanksDurumNull() 
		{
			return IsNull(_parent.IpBanksDurumColumn);
		}

		/// <summary>Sets the TypedList field IpBanksDurum to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIpBanksDurumNull() 
		{
			this[_parent.IpBanksDurumColumn] = System.Convert.DBNull;
		}
		/// <summary>Gets / sets the value of the TypedList field IpBanksTarih<br/><br/>
		/// </summary>
		/// <remarks>Mapped on: IpBank.IpBanksTarih</remarks>
		public System.DateTime IpBanksTarih 
		{
			get { return IsIpBanksTarihNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.IpBanksTarihColumn]; }
			set { this[_parent.IpBanksTarihColumn] = value; }
		}

		/// <summary>Returns true if the TypedList field IpBanksTarih is NULL, false otherwise.</summary>
		public bool IsIpBanksTarihNull() 
		{
			return IsNull(_parent.IpBanksTarihColumn);
		}

		/// <summary>Sets the TypedList field IpBanksTarih to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetIpBanksTarihNull() 
		{
			this[_parent.IpBanksTarihColumn] = System.Convert.DBNull;
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
