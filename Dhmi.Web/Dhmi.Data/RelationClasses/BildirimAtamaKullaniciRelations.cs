///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:34
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
	/// <summary>Implements the relations factory for the entity: BildirimAtamaKullanici. </summary>
	public partial class BildirimAtamaKullaniciRelations
	{
		/// <summary>CTor</summary>
		public BildirimAtamaKullaniciRelations()
		{
		}

		/// <summary>Gets all relations of the BildirimAtamaKullaniciEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimEntityUsingFkBildirimId);
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BildirimAtamaKullaniciEntity and BildirimEntity over the m:1 relation they have, using the relation between the fields:
		/// BildirimAtamaKullanici.FkBildirimId - Bildirim.BildirimId
		/// </summary>
		public virtual IEntityRelation BildirimEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Bildirim", false);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, BildirimAtamaKullaniciFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaKullaniciEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimAtamaKullaniciEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// BildirimAtamaKullanici.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, BildirimAtamaKullaniciFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaKullaniciEntity", true);
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
	internal static class StaticBildirimAtamaKullaniciRelations
	{
		internal static readonly IEntityRelation BildirimEntityUsingFkBildirimIdStatic = new BildirimAtamaKullaniciRelations().BildirimEntityUsingFkBildirimId;
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new BildirimAtamaKullaniciRelations().KullaniciEntityUsingFkKullaniciId;

		/// <summary>CTor</summary>
		static StaticBildirimAtamaKullaniciRelations()
		{
		}
	}
}
