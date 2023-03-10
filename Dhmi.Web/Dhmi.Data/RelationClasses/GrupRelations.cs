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
	/// <summary>Implements the relations factory for the entity: Grup. </summary>
	public partial class GrupRelations
	{
		/// <summary>CTor</summary>
		public GrupRelations()
		{
		}

		/// <summary>Gets all relations of the GrupEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimAtamaGrupEntityUsingFkGrupId);
			toReturn.Add(this.GrupAtamaEntityUsingFkGrupId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between GrupEntity and BildirimAtamaGrupEntity over the 1:n relation they have, using the relation between the fields:
		/// Grup.GrupId - BildirimAtamaGrup.FkGrupId
		/// </summary>
		public virtual IEntityRelation BildirimAtamaGrupEntityUsingFkGrupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimAtamaGrups" , true);
				relation.AddEntityFieldPair(GrupFields.GrupId, BildirimAtamaGrupFields.FkGrupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GrupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaGrupEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between GrupEntity and GrupAtamaEntity over the 1:n relation they have, using the relation between the fields:
		/// Grup.GrupId - GrupAtama.FkGrupId
		/// </summary>
		public virtual IEntityRelation GrupAtamaEntityUsingFkGrupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GrupAtamas" , true);
				relation.AddEntityFieldPair(GrupFields.GrupId, GrupAtamaFields.FkGrupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GrupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GrupAtamaEntity", false);
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
	internal static class StaticGrupRelations
	{
		internal static readonly IEntityRelation BildirimAtamaGrupEntityUsingFkGrupIdStatic = new GrupRelations().BildirimAtamaGrupEntityUsingFkGrupId;
		internal static readonly IEntityRelation GrupAtamaEntityUsingFkGrupIdStatic = new GrupRelations().GrupAtamaEntityUsingFkGrupId;

		/// <summary>CTor</summary>
		static StaticGrupRelations()
		{
		}
	}
}
