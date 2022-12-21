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
	/// <summary>Implements the relations factory for the entity: MenuOlustur. </summary>
	public partial class MenuOlusturRelations
	{
		/// <summary>CTor</summary>
		public MenuOlusturRelations()
		{
		}

		/// <summary>Gets all relations of the MenuOlusturEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AltAltMenuEntityUsingFkAltAltMenuId);
			toReturn.Add(this.AltMenuEntityUsingFkAltMenuId);
			toReturn.Add(this.MenuEntityUsingFkMenuId);
			toReturn.Add(this.YetkiEntityUsingFkYetkiId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between MenuOlusturEntity and AltAltMenuEntity over the m:1 relation they have, using the relation between the fields:
		/// MenuOlustur.FkAltAltMenuId - AltAltMenu.AltAltMenuId
		/// </summary>
		public virtual IEntityRelation AltAltMenuEntityUsingFkAltAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltAltMenu", false);
				relation.AddEntityFieldPair(AltAltMenuFields.AltAltMenuId, MenuOlusturFields.FkAltAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between MenuOlusturEntity and AltMenuEntity over the m:1 relation they have, using the relation between the fields:
		/// MenuOlustur.FkAltMenuId - AltMenu.AltMenuId
		/// </summary>
		public virtual IEntityRelation AltMenuEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltMenu", false);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, MenuOlusturFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between MenuOlusturEntity and MenuEntity over the m:1 relation they have, using the relation between the fields:
		/// MenuOlustur.FkMenuId - Menu.MenuId
		/// </summary>
		public virtual IEntityRelation MenuEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Menu", false);
				relation.AddEntityFieldPair(MenuFields.MenuId, MenuOlusturFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between MenuOlusturEntity and YetkiEntity over the m:1 relation they have, using the relation between the fields:
		/// MenuOlustur.FkYetkiId - Yetki.YetkiId
		/// </summary>
		public virtual IEntityRelation YetkiEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Yetki", false);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, MenuOlusturFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuOlusturEntity", true);
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
	internal static class StaticMenuOlusturRelations
	{
		internal static readonly IEntityRelation AltAltMenuEntityUsingFkAltAltMenuIdStatic = new MenuOlusturRelations().AltAltMenuEntityUsingFkAltAltMenuId;
		internal static readonly IEntityRelation AltMenuEntityUsingFkAltMenuIdStatic = new MenuOlusturRelations().AltMenuEntityUsingFkAltMenuId;
		internal static readonly IEntityRelation MenuEntityUsingFkMenuIdStatic = new MenuOlusturRelations().MenuEntityUsingFkMenuId;
		internal static readonly IEntityRelation YetkiEntityUsingFkYetkiIdStatic = new MenuOlusturRelations().YetkiEntityUsingFkYetkiId;

		/// <summary>CTor</summary>
		static StaticMenuOlusturRelations()
		{
		}
	}
}
