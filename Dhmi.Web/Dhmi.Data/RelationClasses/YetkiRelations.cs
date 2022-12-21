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
	/// <summary>Implements the relations factory for the entity: Yetki. </summary>
	public partial class YetkiRelations
	{
		/// <summary>CTor</summary>
		public YetkiRelations()
		{
		}

		/// <summary>Gets all relations of the YetkiEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.IslemOlusturEntityUsingFkYetkiId);
			toReturn.Add(this.KullaniciEntityUsingFkYetkiId);
			toReturn.Add(this.MenuOlusturEntityUsingFkYetkiId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between YetkiEntity and IslemOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// Yetki.YetkiId - IslemOlustur.FkYetkiId
		/// </summary>
		public virtual IEntityRelation IslemOlusturEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "IslemOlusturs" , true);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, IslemOlusturFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IslemOlusturEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between YetkiEntity and KullaniciEntity over the 1:n relation they have, using the relation between the fields:
		/// Yetki.YetkiId - Kullanici.FkYetkiId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kullanicis" , true);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, KullaniciFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between YetkiEntity and MenuOlusturEntity over the 1:n relation they have, using the relation between the fields:
		/// Yetki.YetkiId - MenuOlustur.FkYetkiId
		/// </summary>
		public virtual IEntityRelation MenuOlusturEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "MenuOlusturs" , true);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, MenuOlusturFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", true);
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
	internal static class StaticYetkiRelations
	{
		internal static readonly IEntityRelation IslemOlusturEntityUsingFkYetkiIdStatic = new YetkiRelations().IslemOlusturEntityUsingFkYetkiId;
		internal static readonly IEntityRelation KullaniciEntityUsingFkYetkiIdStatic = new YetkiRelations().KullaniciEntityUsingFkYetkiId;
		internal static readonly IEntityRelation MenuOlusturEntityUsingFkYetkiIdStatic = new YetkiRelations().MenuOlusturEntityUsingFkYetkiId;

		/// <summary>CTor</summary>
		static StaticYetkiRelations()
		{
		}
	}
}
