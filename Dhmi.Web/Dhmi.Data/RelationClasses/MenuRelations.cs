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
	/// <summary>Implements the relations factory for the entity: Menu. </summary>
	public partial class MenuRelations
	{
		/// <summary>CTor</summary>
		public MenuRelations()
		{
		}

		/// <summary>Gets all relations of the MenuEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AltMenuEntityUsingFkMenuId);
			toReturn.Add(this.IslemEntityUsingFkMenuId);
			toReturn.Add(this.MenuOlusturEntityUsingFkMenuId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between MenuEntity and AltMenuEntity over the 1:n relation they have, using the relation between the fields:
		/// Menu.MenuId - AltMenu.FkMenuId
		/// </summary>
		public virtual IEntityRelation AltMenuEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "AltMenus" , true);
				relation.AddEntityFieldPair(MenuFields.MenuId, AltMenuFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between MenuEntity and IslemEntity over the 1:n relation they have, using the relation between the fields:
		/// Menu.MenuId - Islem.FkMenuId
		/// </summary>
		public virtual IEntityRelation IslemEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Islems" , true);
				relation.AddEntityFieldPair(MenuFields.MenuId, IslemFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between MenuEntity and MenuOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// Menu.MenuId - MenuOlustur.FkMenuId
		/// </summary>
		public virtual IEntityRelation MenuOlusturEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "MenuOlusturs" , true);
				relation.AddEntityFieldPair(MenuFields.MenuId, MenuOlusturFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", false);
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
	internal static class StaticMenuRelations
	{
		internal static readonly IEntityRelation AltMenuEntityUsingFkMenuIdStatic = new MenuRelations().AltMenuEntityUsingFkMenuId;
		internal static readonly IEntityRelation IslemEntityUsingFkMenuIdStatic = new MenuRelations().IslemEntityUsingFkMenuId;
		internal static readonly IEntityRelation MenuOlusturEntityUsingFkMenuIdStatic = new MenuRelations().MenuOlusturEntityUsingFkMenuId;

		/// <summary>CTor</summary>
		static StaticMenuRelations()
		{
		}
	}
}
