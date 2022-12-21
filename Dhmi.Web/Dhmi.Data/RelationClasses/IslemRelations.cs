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
	/// <summary>Implements the relations factory for the entity: Islem. </summary>
	public partial class IslemRelations
	{
		/// <summary>CTor</summary>
		public IslemRelations()
		{
		}

		/// <summary>Gets all relations of the IslemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.IslemOlusturEntityUsingFkIslemId);
			toReturn.Add(this.AltAltMenuEntityUsingFkAltAltMenuId);
			toReturn.Add(this.AltMenuEntityUsingFkAltMenuId);
			toReturn.Add(this.IslemTuruEntityUsingFkIslemTuruId);
			toReturn.Add(this.MenuEntityUsingFkMenuId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between IslemEntity and IslemOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// Islem.IslemId - IslemOlustur.FkIslemId
		/// </summary>
		public virtual IEntityRelation IslemOlusturEntityUsingFkIslemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "IslemOlusturs" , true);
				relation.AddEntityFieldPair(IslemFields.IslemId, IslemOlusturFields.FkIslemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemOlusturEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between IslemEntity and AltAltMenuEntity over the m:1 relation they have, using the relation between the fields:
		/// Islem.FkAltAltMenuId - AltAltMenu.AltAltMenuId
		/// </summary>
		public virtual IEntityRelation AltAltMenuEntityUsingFkAltAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltAltMenu", false);
				relation.AddEntityFieldPair(AltAltMenuFields.AltAltMenuId, IslemFields.FkAltAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltAltMenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between IslemEntity and AltMenuEntity over the m:1 relation they have, using the relation between the fields:
		/// Islem.FkAltMenuId - AltMenu.AltMenuId
		/// </summary>
		public virtual IEntityRelation AltMenuEntityUsingFkAltMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltMenu", false);
				relation.AddEntityFieldPair(AltMenuFields.AltMenuId, IslemFields.FkAltMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltMenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between IslemEntity and IslemTuruEntity over the m:1 relation they have, using the relation between the fields:
		/// Islem.FkIslemTuruId - IslemTuru.IslemTuruId
		/// </summary>
		public virtual IEntityRelation IslemTuruEntityUsingFkIslemTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "IslemTuru", false);
				relation.AddEntityFieldPair(IslemTuruFields.IslemTuruId, IslemFields.FkIslemTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemTuruEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between IslemEntity and MenuEntity over the m:1 relation they have, using the relation between the fields:
		/// Islem.FkMenuId - Menu.MenuId
		/// </summary>
		public virtual IEntityRelation MenuEntityUsingFkMenuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Menu", false);
				relation.AddEntityFieldPair(MenuFields.MenuId, IslemFields.FkMenuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MenuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemEntity", true);
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
	internal static class StaticIslemRelations
	{
		internal static readonly IEntityRelation IslemOlusturEntityUsingFkIslemIdStatic = new IslemRelations().IslemOlusturEntityUsingFkIslemId;
		internal static readonly IEntityRelation AltAltMenuEntityUsingFkAltAltMenuIdStatic = new IslemRelations().AltAltMenuEntityUsingFkAltAltMenuId;
		internal static readonly IEntityRelation AltMenuEntityUsingFkAltMenuIdStatic = new IslemRelations().AltMenuEntityUsingFkAltMenuId;
		internal static readonly IEntityRelation IslemTuruEntityUsingFkIslemTuruIdStatic = new IslemRelations().IslemTuruEntityUsingFkIslemTuruId;
		internal static readonly IEntityRelation MenuEntityUsingFkMenuIdStatic = new IslemRelations().MenuEntityUsingFkMenuId;

		/// <summary>CTor</summary>
		static StaticIslemRelations()
		{
		}
	}
}
