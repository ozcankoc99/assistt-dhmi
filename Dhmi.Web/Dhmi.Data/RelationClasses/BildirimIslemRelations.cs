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
	/// <summary>Implements the relations factory for the entity: BildirimIslem. </summary>
	public partial class BildirimIslemRelations
	{
		/// <summary>CTor</summary>
		public BildirimIslemRelations()
		{
		}

		/// <summary>Gets all relations of the BildirimIslemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimHistoryEntityUsingFkBildirimIslemId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BildirimIslemEntity and BildirimHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// BildirimIslem.BildirimIslemId - BildirimHistory.FkBildirimIslemId
		/// </summary>
		public virtual IEntityRelation BildirimHistoryEntityUsingFkBildirimIslemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimHistories" , true);
				relation.AddEntityFieldPair(BildirimIslemFields.BildirimIslemId, BildirimHistoryFields.FkBildirimIslemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimIslemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimHistoryEntity", false);
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
	internal static class StaticBildirimIslemRelations
	{
		internal static readonly IEntityRelation BildirimHistoryEntityUsingFkBildirimIslemIdStatic = new BildirimIslemRelations().BildirimHistoryEntityUsingFkBildirimIslemId;

		/// <summary>CTor</summary>
		static StaticBildirimIslemRelations()
		{
		}
	}
}
