﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: BildirimAtamaGrup. </summary>
	public partial class BildirimAtamaGrupRelations
	{
		/// <summary>CTor</summary>
		public BildirimAtamaGrupRelations()
		{
		}

		/// <summary>Gets all relations of the BildirimAtamaGrupEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimEntityUsingFkBildirimId);
			toReturn.Add(this.GrupEntityUsingFkGrupId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BildirimAtamaGrupEntity and BildirimEntity over the m:1 relation they have, using the relation between the fields:
		/// BildirimAtamaGrup.FkBildirimId - Bildirim.BildirimId
		/// </summary>
		public virtual IEntityRelation BildirimEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Bildirim", false);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, BildirimAtamaGrupFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaGrupEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimAtamaGrupEntity and GrupEntity over the m:1 relation they have, using the relation between the fields:
		/// BildirimAtamaGrup.FkGrupId - Grup.GrupId
		/// </summary>
		public virtual IEntityRelation GrupEntityUsingFkGrupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Grup", false);
				relation.AddEntityFieldPair(GrupFields.GrupId, BildirimAtamaGrupFields.FkGrupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GrupEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaGrupEntity", true);
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
	internal static class StaticBildirimAtamaGrupRelations
	{
		internal static readonly IEntityRelation BildirimEntityUsingFkBildirimIdStatic = new BildirimAtamaGrupRelations().BildirimEntityUsingFkBildirimId;
		internal static readonly IEntityRelation GrupEntityUsingFkGrupIdStatic = new BildirimAtamaGrupRelations().GrupEntityUsingFkGrupId;

		/// <summary>CTor</summary>
		static StaticBildirimAtamaGrupRelations()
		{
		}
	}
}
