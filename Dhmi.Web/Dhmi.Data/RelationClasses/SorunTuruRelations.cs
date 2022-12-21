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
	/// <summary>Implements the relations factory for the entity: SorunTuru. </summary>
	public partial class SorunTuruRelations
	{
		/// <summary>CTor</summary>
		public SorunTuruRelations()
		{
		}

		/// <summary>Gets all relations of the SorunTuruEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SorunEntityUsingFkSorunTuruId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SorunTuruEntity and SorunEntity over the 1:n relation they have, using the relation between the fields:
		/// SorunTuru.SorunTuruId - Sorun.FkSorunTuruId
		/// </summary>
		public virtual IEntityRelation SorunEntityUsingFkSorunTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Soruns" , true);
				relation.AddEntityFieldPair(SorunTuruFields.SorunTuruId, SorunFields.FkSorunTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunTuruEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunEntity", false);
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
	internal static class StaticSorunTuruRelations
	{
		internal static readonly IEntityRelation SorunEntityUsingFkSorunTuruIdStatic = new SorunTuruRelations().SorunEntityUsingFkSorunTuruId;

		/// <summary>CTor</summary>
		static StaticSorunTuruRelations()
		{
		}
	}
}
