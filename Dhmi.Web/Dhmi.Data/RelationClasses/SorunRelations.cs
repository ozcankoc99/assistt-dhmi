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
	/// <summary>Implements the relations factory for the entity: Sorun. </summary>
	public partial class SorunRelations
	{
		/// <summary>CTor</summary>
		public SorunRelations()
		{
		}

		/// <summary>Gets all relations of the SorunEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.SorunTuruEntityUsingFkSorunTuruId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SorunEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// Sorun.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, SorunFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SorunEntity and SorunTuruEntity over the m:1 relation they have, using the relation between the fields:
		/// Sorun.FkSorunTuruId - SorunTuru.SorunTuruId
		/// </summary>
		public virtual IEntityRelation SorunTuruEntityUsingFkSorunTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SorunTuru", false);
				relation.AddEntityFieldPair(SorunTuruFields.SorunTuruId, SorunFields.FkSorunTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunTuruEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunEntity", true);
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
	internal static class StaticSorunRelations
	{
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new SorunRelations().KullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation SorunTuruEntityUsingFkSorunTuruIdStatic = new SorunRelations().SorunTuruEntityUsingFkSorunTuruId;

		/// <summary>CTor</summary>
		static StaticSorunRelations()
		{
		}
	}
}
