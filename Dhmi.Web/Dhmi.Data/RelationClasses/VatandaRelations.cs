///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:35
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using dhmi;
using dhmi.FactoryClasses;
using dhmi.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Vatanda. </summary>
	public partial class VatandaRelations
	{
		/// <summary>CTor</summary>
		public VatandaRelations()
		{
		}

		/// <summary>Gets all relations of the VatandaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimEntityUsingFkVatandasId);
			toReturn.Add(this.KaraListeEntityUsingFkVatandasId);
			toReturn.Add(this.VatandasArsivEntityUsingFkVatandasId);
			toReturn.Add(this.VipListeEntityUsingFkVatandasId);
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between VatandaEntity and BildirimEntity over the 1:n relation they have, using the relation between the fields:
		/// Vatanda.VatandasId - Bildirim.FkVatandasId
		/// </summary>
		public virtual IEntityRelation BildirimEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Bildirims" , true);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, BildirimFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VatandaEntity and KaraListeEntity over the 1:n relation they have, using the relation between the fields:
		/// Vatanda.VatandasId - KaraListe.FkVatandasId
		/// </summary>
		public virtual IEntityRelation KaraListeEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "KaraListes" , true);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, KaraListeFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KaraListeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VatandaEntity and VatandasArsivEntity over the 1:n relation they have, using the relation between the fields:
		/// Vatanda.VatandasId - VatandasArsiv.FkVatandasId
		/// </summary>
		public virtual IEntityRelation VatandasArsivEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VatandasArsivs" , true);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, VatandasArsivFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandasArsivEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VatandaEntity and VipListeEntity over the 1:n relation they have, using the relation between the fields:
		/// Vatanda.VatandasId - VipListe.FkVatandasId
		/// </summary>
		public virtual IEntityRelation VipListeEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VipListes" , true);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, VipListeFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VipListeEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between VatandaEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// Vatanda.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, VatandaFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticVatandaRelations
	{
		internal static readonly IEntityRelation BildirimEntityUsingFkVatandasIdStatic = new VatandaRelations().BildirimEntityUsingFkVatandasId;
		internal static readonly IEntityRelation KaraListeEntityUsingFkVatandasIdStatic = new VatandaRelations().KaraListeEntityUsingFkVatandasId;
		internal static readonly IEntityRelation VatandasArsivEntityUsingFkVatandasIdStatic = new VatandaRelations().VatandasArsivEntityUsingFkVatandasId;
		internal static readonly IEntityRelation VipListeEntityUsingFkVatandasIdStatic = new VatandaRelations().VipListeEntityUsingFkVatandasId;
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new VatandaRelations().KullaniciEntityUsingFkKullaniciId;

		/// <summary>CTor</summary>
		static StaticVatandaRelations()
		{
		}
	}
}
