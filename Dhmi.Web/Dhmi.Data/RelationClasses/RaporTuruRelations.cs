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
	/// <summary>Implements the relations factory for the entity: RaporTuru. </summary>
	public partial class RaporTuruRelations
	{
		/// <summary>CTor</summary>
		public RaporTuruRelations()
		{
		}

		/// <summary>Gets all relations of the RaporTuruEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RaporIcerikEntityUsingFkRaporTuruId);
			toReturn.Add(this.RaporYetkiEntityUsingFkRaporTuruId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RaporTuruEntity and RaporIcerikEntity over the 1:n relation they have, using the relation between the fields:
		/// RaporTuru.RaporTuruId - RaporIcerik.FkRaporTuruId
		/// </summary>
		public virtual IEntityRelation RaporIcerikEntityUsingFkRaporTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RaporIceriks" , true);
				relation.AddEntityFieldPair(RaporTuruFields.RaporTuruId, RaporIcerikFields.FkRaporTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporTuruEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporIcerikEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between RaporTuruEntity and RaporYetkiEntity over the 1:n relation they have, using the relation between the fields:
		/// RaporTuru.RaporTuruId - RaporYetki.FkRaporTuruId
		/// </summary>
		public virtual IEntityRelation RaporYetkiEntityUsingFkRaporTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RaporYetkis" , true);
				relation.AddEntityFieldPair(RaporTuruFields.RaporTuruId, RaporYetkiFields.FkRaporTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporTuruEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporYetkiEntity", false);
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
	internal static class StaticRaporTuruRelations
	{
		internal static readonly IEntityRelation RaporIcerikEntityUsingFkRaporTuruIdStatic = new RaporTuruRelations().RaporIcerikEntityUsingFkRaporTuruId;
		internal static readonly IEntityRelation RaporYetkiEntityUsingFkRaporTuruIdStatic = new RaporTuruRelations().RaporYetkiEntityUsingFkRaporTuruId;

		/// <summary>CTor</summary>
		static StaticRaporTuruRelations()
		{
		}
	}
}
