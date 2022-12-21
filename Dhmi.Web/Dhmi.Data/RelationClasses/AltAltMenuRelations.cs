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
	/// <summary>Implements the relations factory for the entity: AltAltMenu. </summary>
	public partial class AltAltMenuRelations
	{
		/// <summary>CTor</summary>
		public AltAltMenuRelations()
		{
		}

		/// <summary>Gets all relations of the AltAltMenuEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.IslemEntityUsingFkAltAltMenuId);
			toReturn.Add(this.MenuOlusturEntityUsingFkAltAltMenuId);
			toReturn.Add(this.AltMenuEntityUsingFkAltMenuId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AltAltMenuEntity and IslemEntity over the 1:n relation they have, using the relation between the fields:
		/// AltAltMenu.AltAltMenuId - Islem.FkAltAltMenuId
		/// </summary>
		public virtual IEntityRelation IslemEntityUsingFkAltAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Islems" , true);
				relation.AddEntityFieldPair(AltAltMenuFields.AltAltMenuId, IslemFields.FkAltAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AltAltMenuEntity and MenuOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// AltAltMenu.AltAltMenuId - MenuOlustur.FkAltAltMenuId
		/// </summary>
		public virtual IEntityRelation MenuOlusturEntityUsingFkAltAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "MenuOlusturs" , true);
				relation.AddEntityFieldPair(AltAltMenuFields.AltAltMenuId, MenuOlusturFields.FkAltAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AltAltMenuEntity and AltMenuEntity over the m:1 relation they have, using the relation between the fields:
		/// AltAltMenu.FkAltMenuId - AltMenu.AltMenuId
		/// </summary>
		public virtual IEntityRelation AltMenuEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltMenu", false);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, AltAltMenuFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", true);
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
	internal static class StaticAltAltMenuRelations
	{
		internal static readonly IEntityRelation IslemEntityUsingFkAltAltMenuIdStatic = new AltAltMenuRelations().IslemEntityUsingFkAltAltMenuId;
		internal static readonly IEntityRelation MenuOlusturEntityUsingFkAltAltMenuIdStatic = new AltAltMenuRelations().MenuOlusturEntityUsingFkAltAltMenuId;
		internal static readonly IEntityRelation AltMenuEntityUsingFkAltMenuIdStatic = new AltAltMenuRelations().AltMenuEntityUsingFkAltMenuId;

		/// <summary>CTor</summary>
		static StaticAltAltMenuRelations()
		{
		}
	}
}
