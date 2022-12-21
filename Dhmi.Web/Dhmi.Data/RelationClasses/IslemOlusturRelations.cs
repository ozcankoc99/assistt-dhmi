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
	/// <summary>Implements the relations factory for the entity: IslemOlustur. </summary>
	public partial class IslemOlusturRelations
	{
		/// <summary>CTor</summary>
		public IslemOlusturRelations()
		{
		}

		/// <summary>Gets all relations of the IslemOlusturEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.IslemEntityUsingFkIslemId);
			toReturn.Add(this.YetkiEntityUsingFkYetkiId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between IslemOlusturEntity and IslemEntity over the m:1 relation they have, using the relation between the fields:
		/// IslemOlustur.FkIslemId - Islem.IslemId
		/// </summary>
		public virtual IEntityRelation IslemEntityUsingFkIslemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Islem", false);
				relation.AddEntityFieldPair(IslemFields.IslemId, IslemOlusturFields.FkIslemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemOlusturEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between IslemOlusturEntity and YetkiEntity over the m:1 relation they have, using the relation between the fields:
		/// IslemOlustur.FkYetkiId - Yetki.YetkiId
		/// </summary>
		public virtual IEntityRelation YetkiEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Yetki", false);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, IslemOlusturFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemOlusturEntity", true);
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
	internal static class StaticIslemOlusturRelations
	{
		internal static readonly IEntityRelation IslemEntityUsingFkIslemIdStatic = new IslemOlusturRelations().IslemEntityUsingFkIslemId;
		internal static readonly IEntityRelation YetkiEntityUsingFkYetkiIdStatic = new IslemOlusturRelations().YetkiEntityUsingFkYetkiId;

		/// <summary>CTor</summary>
		static StaticIslemOlusturRelations()
		{
		}
	}
}
