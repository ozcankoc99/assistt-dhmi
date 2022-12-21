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
	/// <summary>Implements the relations factory for the entity: AltMenu. </summary>
	public partial class AltMenuRelations
	{
		/// <summary>CTor</summary>
		public AltMenuRelations()
		{
		}

		/// <summary>Gets all relations of the AltMenuEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AltAltMenuEntityUsingFkAltMenuId);
			toReturn.Add(this.IslemEntityUsingFkAltMenuId);
			toReturn.Add(this.MenuOlusturEntityUsingFkAltMenuId);
			toReturn.Add(this.MenuEntityUsingFkMenuId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AltMenuEntity and AltAltMenuEntity over the 1:n relation they have, using the relation between the fields:
		/// AltMenu.AltMenuId - AltAltMenu.FkAltMenuId
		/// </summary>
		public virtual IEntityRelation AltAltMenuEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AltAltMenus" , true);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, AltAltMenuFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AltMenuEntity and IslemEntity over the 1:n relation they have, using the relation between the fields:
		/// AltMenu.AltMenuId - Islem.FkAltMenuId
		/// </summary>
		public virtual IEntityRelation IslemEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Islems" , true);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, IslemFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AltMenuEntity and MenuOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// AltMenu.AltMenuId - MenuOlustur.FkAltMenuId
		/// </summary>
		public virtual IEntityRelation MenuOlusturEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "MenuOlusturs" , true);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, MenuOlusturFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AltMenuEntity and MenuEntity over the m:1 relation they have, using the relation between the fields:
		/// AltMenu.FkMenuId - Menu.MenuId
		/// </summary>
		public virtual IEntityRelation MenuEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Menu", false);
				relation.AddEntityFieldPair(MenuFields.MenuId, AltMenuFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", true);
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
	internal static class StaticAltMenuRelations
	{
		internal static readonly IEntityRelation AltAltMenuEntityUsingFkAltMenuIdStatic = new AltMenuRelations().AltAltMenuEntityUsingFkAltMenuId;
		internal static readonly IEntityRelation IslemEntityUsingFkAltMenuIdStatic = new AltMenuRelations().IslemEntityUsingFkAltMenuId;
		internal static readonly IEntityRelation MenuOlusturEntityUsingFkAltMenuIdStatic = new AltMenuRelations().MenuOlusturEntityUsingFkAltMenuId;
		internal static readonly IEntityRelation MenuEntityUsingFkMenuIdStatic = new AltMenuRelations().MenuEntityUsingFkMenuId;

		/// <summary>CTor</summary>
		static StaticAltMenuRelations()
		{
		}
	}
}
