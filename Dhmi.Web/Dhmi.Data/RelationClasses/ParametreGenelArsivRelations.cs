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
	/// <summary>Implements the relations factory for the entity: ParametreGenelArsiv. </summary>
	public partial class ParametreGenelArsivRelations
	{
		/// <summary>CTor</summary>
		public ParametreGenelArsivRelations()
		{
		}

		/// <summary>Gets all relations of the ParametreGenelArsivEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.ParametreEntityUsingFkParametreId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ParametreGenelArsivEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// ParametreGenelArsiv.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, ParametreGenelArsivFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreGenelArsivEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ParametreGenelArsivEntity and ParametreEntity over the m:1 relation they have, using the relation between the fields:
		/// ParametreGenelArsiv.FkParametreId - Parametre.ParametreId
		/// </summary>
		public virtual IEntityRelation ParametreEntityUsingFkParametreId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Parametre", false);
				relation.AddEntityFieldPair(ParametreFields.ParametreId, ParametreGenelArsivFields.FkParametreId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreGenelArsivEntity", true);
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
	internal static class StaticParametreGenelArsivRelations
	{
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new ParametreGenelArsivRelations().KullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation ParametreEntityUsingFkParametreIdStatic = new ParametreGenelArsivRelations().ParametreEntityUsingFkParametreId;

		/// <summary>CTor</summary>
		static StaticParametreGenelArsivRelations()
		{
		}
	}
}
