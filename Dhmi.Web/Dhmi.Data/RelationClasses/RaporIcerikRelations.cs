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
	/// <summary>Implements the relations factory for the entity: RaporIcerik. </summary>
	public partial class RaporIcerikRelations
	{
		/// <summary>CTor</summary>
		public RaporIcerikRelations()
		{
		}

		/// <summary>Gets all relations of the RaporIcerikEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RaporTuruEntityUsingFkRaporTuruId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between RaporIcerikEntity and RaporTuruEntity over the m:1 relation they have, using the relation between the fields:
		/// RaporIcerik.FkRaporTuruId - RaporTuru.RaporTuruId
		/// </summary>
		public virtual IEntityRelation RaporTuruEntityUsingFkRaporTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RaporTuru", false);
				relation.AddEntityFieldPair(RaporTuruFields.RaporTuruId, RaporIcerikFields.FkRaporTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporTuruEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporIcerikEntity", true);
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
	internal static class StaticRaporIcerikRelations
	{
		internal static readonly IEntityRelation RaporTuruEntityUsingFkRaporTuruIdStatic = new RaporIcerikRelations().RaporTuruEntityUsingFkRaporTuruId;

		/// <summary>CTor</summary>
		static StaticRaporIcerikRelations()
		{
		}
	}
}
