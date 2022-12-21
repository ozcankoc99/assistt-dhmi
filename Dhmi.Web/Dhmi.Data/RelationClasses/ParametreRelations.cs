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
	/// <summary>Implements the relations factory for the entity: Parametre. </summary>
	public partial class ParametreRelations
	{
		/// <summary>CTor</summary>
		public ParametreRelations()
		{
		}

		/// <summary>Gets all relations of the ParametreEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ParametreGenelArsivEntityUsingFkParametreId);
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.ParametreTurEntityUsingFkParametreTurId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ParametreEntity and ParametreGenelArsivEntity over the 1:n relation they have, using the relation between the fields:
		/// Parametre.ParametreId - ParametreGenelArsiv.FkParametreId
		/// </summary>
		public virtual IEntityRelation ParametreGenelArsivEntityUsingFkParametreId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ParametreGenelArsivs" , true);
				relation.AddEntityFieldPair(ParametreFields.ParametreId, ParametreGenelArsivFields.FkParametreId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreGenelArsivEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ParametreEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// Parametre.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, ParametreFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ParametreEntity and ParametreTurEntity over the m:1 relation they have, using the relation between the fields:
		/// Parametre.FkParametreTurId - ParametreTur.ParametreTurId
		/// </summary>
		public virtual IEntityRelation ParametreTurEntityUsingFkParametreTurId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ParametreTur", false);
				relation.AddEntityFieldPair(ParametreTurFields.ParametreTurId, ParametreFields.FkParametreTurId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreTurEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreEntity", true);
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
	internal static class StaticParametreRelations
	{
		internal static readonly IEntityRelation ParametreGenelArsivEntityUsingFkParametreIdStatic = new ParametreRelations().ParametreGenelArsivEntityUsingFkParametreId;
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new ParametreRelations().KullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation ParametreTurEntityUsingFkParametreTurIdStatic = new ParametreRelations().ParametreTurEntityUsingFkParametreTurId;

		/// <summary>CTor</summary>
		static StaticParametreRelations()
		{
		}
	}
}
