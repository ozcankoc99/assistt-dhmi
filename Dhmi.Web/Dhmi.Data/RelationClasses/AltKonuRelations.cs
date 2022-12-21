///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:33
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
	/// <summary>Implements the relations factory for the entity: AltKonu. </summary>
	public partial class AltKonuRelations
	{
		/// <summary>CTor</summary>
		public AltKonuRelations()
		{
		}

		/// <summary>Gets all relations of the AltKonuEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimEntityUsingFkAltKonuId);
			toReturn.Add(this.KonuEntityUsingFkKonuId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AltKonuEntity and BildirimEntity over the 1:n relation they have, using the relation between the fields:
		/// AltKonu.AltKonuId - Bildirim.FkAltKonuId
		/// </summary>
		public virtual IEntityRelation BildirimEntityUsingFkAltKonuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Bildirims" , true);
				relation.AddEntityFieldPair(AltKonuFields.AltKonuId, BildirimFields.FkAltKonuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltKonuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AltKonuEntity and KonuEntity over the m:1 relation they have, using the relation between the fields:
		/// AltKonu.FkKonuId - Konu.KonuId
		/// </summary>
		public virtual IEntityRelation KonuEntityUsingFkKonuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Konu", false);
				relation.AddEntityFieldPair(KonuFields.KonuId, AltKonuFields.FkKonuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KonuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltKonuEntity", true);
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
	internal static class StaticAltKonuRelations
	{
		internal static readonly IEntityRelation BildirimEntityUsingFkAltKonuIdStatic = new AltKonuRelations().BildirimEntityUsingFkAltKonuId;
		internal static readonly IEntityRelation KonuEntityUsingFkKonuIdStatic = new AltKonuRelations().KonuEntityUsingFkKonuId;

		/// <summary>CTor</summary>
		static StaticAltKonuRelations()
		{
		}
	}
}
