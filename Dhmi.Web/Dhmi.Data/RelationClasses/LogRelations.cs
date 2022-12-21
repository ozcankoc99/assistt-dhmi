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
	/// <summary>Implements the relations factory for the entity: Log. </summary>
	public partial class LogRelations
	{
		/// <summary>CTor</summary>
		public LogRelations()
		{
		}

		/// <summary>Gets all relations of the LogEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.LogIslemEntityUsingFkLogIslemId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between LogEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// Log.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, LogFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LogEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between LogEntity and LogIslemEntity over the m:1 relation they have, using the relation between the fields:
		/// Log.FkLogIslemId - LogIslem.LogIslemId
		/// </summary>
		public virtual IEntityRelation LogIslemEntityUsingFkLogIslemId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "LogIslem", false);
				relation.AddEntityFieldPair(LogIslemFields.LogIslemId, LogFields.FkLogIslemId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LogIslemEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LogEntity", true);
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
	internal static class StaticLogRelations
	{
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new LogRelations().KullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation LogIslemEntityUsingFkLogIslemIdStatic = new LogRelations().LogIslemEntityUsingFkLogIslemId;

		/// <summary>CTor</summary>
		static StaticLogRelations()
		{
		}
	}
}
