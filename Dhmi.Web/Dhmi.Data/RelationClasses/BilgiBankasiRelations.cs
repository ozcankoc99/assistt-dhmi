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
	/// <summary>Implements the relations factory for the entity: BilgiBankasi. </summary>
	public partial class BilgiBankasiRelations
	{
		/// <summary>CTor</summary>
		public BilgiBankasiRelations()
		{
		}

		/// <summary>Gets all relations of the BilgiBankasiEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BilgiBankasiTurEntityUsingFkBilgiBankasiTurId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BilgiBankasiEntity and BilgiBankasiTurEntity over the m:1 relation they have, using the relation between the fields:
		/// BilgiBankasi.FkBilgiBankasiTurId - BilgiBankasiTur.BilgiBankasiTurId
		/// </summary>
		public virtual IEntityRelation BilgiBankasiTurEntityUsingFkBilgiBankasiTurId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BilgiBankasiTur", false);
				relation.AddEntityFieldPair(BilgiBankasiTurFields.BilgiBankasiTurId, BilgiBankasiFields.FkBilgiBankasiTurId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BilgiBankasiTurEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BilgiBankasiEntity", true);
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
	internal static class StaticBilgiBankasiRelations
	{
		internal static readonly IEntityRelation BilgiBankasiTurEntityUsingFkBilgiBankasiTurIdStatic = new BilgiBankasiRelations().BilgiBankasiTurEntityUsingFkBilgiBankasiTurId;

		/// <summary>CTor</summary>
		static StaticBilgiBankasiRelations()
		{
		}
	}
}
