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
	/// <summary>Implements the relations factory for the entity: KaraListe. </summary>
	public partial class KaraListeRelations
	{
		/// <summary>CTor</summary>
		public KaraListeRelations()
		{
		}

		/// <summary>Gets all relations of the KaraListeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.VatandaEntityUsingFkVatandasId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between KaraListeEntity and VatandaEntity over the m:1 relation they have, using the relation between the fields:
		/// KaraListe.FkVatandasId - Vatanda.VatandasId
		/// </summary>
		public virtual IEntityRelation VatandaEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vatanda", false);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, KaraListeFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KaraListeEntity", true);
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
	internal static class StaticKaraListeRelations
	{
		internal static readonly IEntityRelation VatandaEntityUsingFkVatandasIdStatic = new KaraListeRelations().VatandaEntityUsingFkVatandasId;

		/// <summary>CTor</summary>
		static StaticKaraListeRelations()
		{
		}
	}
}
