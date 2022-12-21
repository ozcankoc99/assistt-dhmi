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
	/// <summary>Implements the relations factory for the entity: Bildirim. </summary>
	public partial class BildirimRelations
	{
		/// <summary>CTor</summary>
		public BildirimRelations()
		{
		}

		/// <summary>Gets all relations of the BildirimEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimAtamaGrupEntityUsingFkBildirimId);
			toReturn.Add(this.BildirimAtamaKullaniciEntityUsingFkBildirimId);
			toReturn.Add(this.BildirimHistoryEntityUsingFkBildirimId);
			toReturn.Add(this.EkSureEntityUsingFkBildirimId);
			toReturn.Add(this.GecenSureEntityUsingFkBildirimId);
			toReturn.Add(this.SureTakipEntityUsingFkBildirimId);
			toReturn.Add(this.AltKonuEntityUsingFkAltKonuId);
			toReturn.Add(this.BildirimGeriDonuEntityUsingFkBildirimGeriDonusId);
			toReturn.Add(this.BildirimSonucEntityUsingFkBildirimSonucId);
			toReturn.Add(this.BildirimTuruEntityUsingFkBildirimTuruId);
			toReturn.Add(this.CagriTipiEntityUsingFkCagriTipiId);
			toReturn.Add(this.KullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.VatandaEntityUsingFkVatandasId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimAtamaGrupEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - BildirimAtamaGrup.FkBildirimId
		/// </summary>
		public virtual IEntityRelation BildirimAtamaGrupEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimAtamaGrups" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, BildirimAtamaGrupFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaGrupEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimAtamaKullaniciEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - BildirimAtamaKullanici.FkBildirimId
		/// </summary>
		public virtual IEntityRelation BildirimAtamaKullaniciEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimAtamaKullanicis" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, BildirimAtamaKullaniciFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaKullaniciEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - BildirimHistory.FkBildirimId
		/// </summary>
		public virtual IEntityRelation BildirimHistoryEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimHistories" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, BildirimHistoryFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and EkSureEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - EkSure.FkBildirimId
		/// </summary>
		public virtual IEntityRelation EkSureEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EkSures" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, EkSureFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EkSureEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and GecenSureEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - GecenSure.FkBildirimId
		/// </summary>
		public virtual IEntityRelation GecenSureEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GecenSures" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, GecenSureFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GecenSureEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and SureTakipEntity over the 1:n relation they have, using the relation between the fields:
		/// Bildirim.BildirimId - SureTakip.FkBildirimId
		/// </summary>
		public virtual IEntityRelation SureTakipEntityUsingFkBildirimId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SureTakips" , true);
				relation.AddEntityFieldPair(BildirimFields.BildirimId, SureTakipFields.FkBildirimId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SureTakipEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and AltKonuEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkAltKonuId - AltKonu.AltKonuId
		/// </summary>
		public virtual IEntityRelation AltKonuEntityUsingFkAltKonuId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AltKonu", false);
				relation.AddEntityFieldPair(AltKonuFields.AltKonuId, BildirimFields.FkAltKonuId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AltKonuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimGeriDonuEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkBildirimGeriDonusId - BildirimGeriDonu.BildirimGeriDonusId
		/// </summary>
		public virtual IEntityRelation BildirimGeriDonuEntityUsingFkBildirimGeriDonusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BildirimGeriDonu", false);
				relation.AddEntityFieldPair(BildirimGeriDonuFields.BildirimGeriDonusId, BildirimFields.FkBildirimGeriDonusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimGeriDonuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimSonucEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkBildirimSonucId - BildirimSonuc.BildirimSonucId
		/// </summary>
		public virtual IEntityRelation BildirimSonucEntityUsingFkBildirimSonucId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BildirimSonuc", false);
				relation.AddEntityFieldPair(BildirimSonucFields.BildirimSonucId, BildirimFields.FkBildirimSonucId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimSonucEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and BildirimTuruEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkBildirimTuruId - BildirimTuru.BildirimTuruId
		/// </summary>
		public virtual IEntityRelation BildirimTuruEntityUsingFkBildirimTuruId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BildirimTuru", false);
				relation.AddEntityFieldPair(BildirimTuruFields.BildirimTuruId, BildirimFields.FkBildirimTuruId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimTuruEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and CagriTipiEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkCagriTipiId - CagriTipi.CagriTipiId
		/// </summary>
		public virtual IEntityRelation CagriTipiEntityUsingFkCagriTipiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CagriTipi", false);
				relation.AddEntityFieldPair(CagriTipiFields.CagriTipiId, BildirimFields.FkCagriTipiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CagriTipiEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and KullaniciEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkKullaniciId - Kullanici.KullaniciId
		/// </summary>
		public virtual IEntityRelation KullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Kullanici", false);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, BildirimFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BildirimEntity and VatandaEntity over the m:1 relation they have, using the relation between the fields:
		/// Bildirim.FkVatandasId - Vatanda.VatandasId
		/// </summary>
		public virtual IEntityRelation VatandaEntityUsingFkVatandasId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vatanda", false);
				relation.AddEntityFieldPair(VatandaFields.VatandasId, BildirimFields.FkVatandasId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", true);
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
	internal static class StaticBildirimRelations
	{
		internal static readonly IEntityRelation BildirimAtamaGrupEntityUsingFkBildirimIdStatic = new BildirimRelations().BildirimAtamaGrupEntityUsingFkBildirimId;
		internal static readonly IEntityRelation BildirimAtamaKullaniciEntityUsingFkBildirimIdStatic = new BildirimRelations().BildirimAtamaKullaniciEntityUsingFkBildirimId;
		internal static readonly IEntityRelation BildirimHistoryEntityUsingFkBildirimIdStatic = new BildirimRelations().BildirimHistoryEntityUsingFkBildirimId;
		internal static readonly IEntityRelation EkSureEntityUsingFkBildirimIdStatic = new BildirimRelations().EkSureEntityUsingFkBildirimId;
		internal static readonly IEntityRelation GecenSureEntityUsingFkBildirimIdStatic = new BildirimRelations().GecenSureEntityUsingFkBildirimId;
		internal static readonly IEntityRelation SureTakipEntityUsingFkBildirimIdStatic = new BildirimRelations().SureTakipEntityUsingFkBildirimId;
		internal static readonly IEntityRelation AltKonuEntityUsingFkAltKonuIdStatic = new BildirimRelations().AltKonuEntityUsingFkAltKonuId;
		internal static readonly IEntityRelation BildirimGeriDonuEntityUsingFkBildirimGeriDonusIdStatic = new BildirimRelations().BildirimGeriDonuEntityUsingFkBildirimGeriDonusId;
		internal static readonly IEntityRelation BildirimSonucEntityUsingFkBildirimSonucIdStatic = new BildirimRelations().BildirimSonucEntityUsingFkBildirimSonucId;
		internal static readonly IEntityRelation BildirimTuruEntityUsingFkBildirimTuruIdStatic = new BildirimRelations().BildirimTuruEntityUsingFkBildirimTuruId;
		internal static readonly IEntityRelation CagriTipiEntityUsingFkCagriTipiIdStatic = new BildirimRelations().CagriTipiEntityUsingFkCagriTipiId;
		internal static readonly IEntityRelation KullaniciEntityUsingFkKullaniciIdStatic = new BildirimRelations().KullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation VatandaEntityUsingFkVatandasIdStatic = new BildirimRelations().VatandaEntityUsingFkVatandasId;

		/// <summary>CTor</summary>
		static StaticBildirimRelations()
		{
		}
	}
}
