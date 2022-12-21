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
	/// <summary>Implements the relations factory for the entity: Kullanici. </summary>
	public partial class KullaniciRelations
	{
		/// <summary>CTor</summary>
		public KullaniciRelations()
		{
		}

		/// <summary>Gets all relations of the KullaniciEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BildirimEntityUsingFkKullaniciId);
			toReturn.Add(this.BildirimAtamaKullaniciEntityUsingFkKullaniciId);
			toReturn.Add(this.BildirimHistoryEntityUsingFkKullaniciId);
			toReturn.Add(this.DuyuruEntityUsingFkKullaniciId);
			toReturn.Add(this.EkSureEntityUsingFkKullaniciId);
			toReturn.Add(this.GecenSureEntityUsingFkKullaniciId);
			toReturn.Add(this.GrupAtamaEntityUsingFkKullaniciId);
			toReturn.Add(this.IpBankEntityUsingFkKullaniciId);
			toReturn.Add(this.IstatistikEntityUsingFkKullaniciId);
			toReturn.Add(this.KopukCagriEntityUsingFkKullaniciId);
			toReturn.Add(this.KpsArsivEntityUsingFkKullaniciId);
			toReturn.Add(this.LogEntityUsingFkKullaniciId);
			toReturn.Add(this.MesajEntityUsingFkKullaniciId);
			toReturn.Add(this.ParametreEntityUsingFkKullaniciId);
			toReturn.Add(this.ParametreGenelArsivEntityUsingFkKullaniciId);
			toReturn.Add(this.RaporYetkiEntityUsingFkKullaniciId);
			toReturn.Add(this.SorunEntityUsingFkKullaniciId);
			toReturn.Add(this.VatandaEntityUsingFkKullaniciId);
			toReturn.Add(this.GorevEntityUsingFkGorevId);
			toReturn.Add(this.HiyerarsiTurEntityUsingFkHiyerarsiTurId);
			toReturn.Add(this.YetkiEntityUsingFkYetkiId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and BildirimEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Bildirim.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation BildirimEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Bildirims" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, BildirimFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and BildirimAtamaKullaniciEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - BildirimAtamaKullanici.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation BildirimAtamaKullaniciEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimAtamaKullanicis" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, BildirimAtamaKullaniciFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimAtamaKullaniciEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and BildirimHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - BildirimHistory.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation BildirimHistoryEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BildirimHistories" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, BildirimHistoryFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BildirimHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and DuyuruEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Duyuru.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation DuyuruEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Duyurus" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, DuyuruFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DuyuruEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and EkSureEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - EkSure.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation EkSureEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EkSures" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, EkSureFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EkSureEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and GecenSureEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - GecenSure.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation GecenSureEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GecenSures" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, GecenSureFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GecenSureEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and GrupAtamaEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - GrupAtama.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation GrupAtamaEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "GrupAtamas" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, GrupAtamaFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GrupAtamaEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and IpBankEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - IpBank.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation IpBankEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "IpBanks" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, IpBankFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IpBankEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and IstatistikEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Istatistik.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation IstatistikEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Istatistiks" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, IstatistikFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IstatistikEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and KopukCagriEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - KopukCagri.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation KopukCagriEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "KopukCagris" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, KopukCagriFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KopukCagriEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and KpsArsivEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - KpsArsiv.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation KpsArsivEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "KpsArsivs" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, KpsArsivFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KpsArsivEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and LogEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Log.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation LogEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Logs" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, LogFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LogEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and MesajEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Mesaj.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation MesajEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Mesajs" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, MesajFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MesajEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and ParametreEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Parametre.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation ParametreEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Parametres" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, ParametreFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and ParametreGenelArsivEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - ParametreGenelArsiv.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation ParametreGenelArsivEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ParametreGenelArsivs" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, ParametreGenelArsivFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ParametreGenelArsivEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and RaporYetkiEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - RaporYetki.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation RaporYetkiEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RaporYetkis" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, RaporYetkiFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RaporYetkiEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and SorunEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Sorun.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation SorunEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Soruns" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, SorunFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SorunEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and VatandaEntity over the 1:n relation they have, using the relation between the fields:
		/// Kullanici.KullaniciId - Vatanda.FkKullaniciId
		/// </summary>
		public virtual IEntityRelation VatandaEntityUsingFkKullaniciId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Vatandas" , true);
				relation.AddEntityFieldPair(KullaniciFields.KullaniciId, VatandaFields.FkKullaniciId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VatandaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and GorevEntity over the m:1 relation they have, using the relation between the fields:
		/// Kullanici.FkGorevId - Gorev.GorevId
		/// </summary>
		public virtual IEntityRelation GorevEntityUsingFkGorevId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Gorev", false);
				relation.AddEntityFieldPair(GorevFields.GorevId, KullaniciFields.FkGorevId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GorevEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and HiyerarsiTurEntity over the m:1 relation they have, using the relation between the fields:
		/// Kullanici.FkHiyerarsiTurId - HiyerarsiTur.HiyerarsiTurId
		/// </summary>
		public virtual IEntityRelation HiyerarsiTurEntityUsingFkHiyerarsiTurId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "HiyerarsiTur", false);
				relation.AddEntityFieldPair(HiyerarsiTurFields.HiyerarsiTurId, KullaniciFields.FkHiyerarsiTurId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("HiyerarsiTurEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between KullaniciEntity and YetkiEntity over the m:1 relation they have, using the relation between the fields:
		/// Kullanici.FkYetkiId - Yetki.YetkiId
		/// </summary>
		public virtual IEntityRelation YetkiEntityUsingFkYetkiId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Yetki", false);
				relation.AddEntityFieldPair(YetkiFields.YetkiId, KullaniciFields.FkYetkiId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("YetkiEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KullaniciEntity", true);
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
	internal static class StaticKullaniciRelations
	{
		internal static readonly IEntityRelation BildirimEntityUsingFkKullaniciIdStatic = new KullaniciRelations().BildirimEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation BildirimAtamaKullaniciEntityUsingFkKullaniciIdStatic = new KullaniciRelations().BildirimAtamaKullaniciEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation BildirimHistoryEntityUsingFkKullaniciIdStatic = new KullaniciRelations().BildirimHistoryEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation DuyuruEntityUsingFkKullaniciIdStatic = new KullaniciRelations().DuyuruEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation EkSureEntityUsingFkKullaniciIdStatic = new KullaniciRelations().EkSureEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation GecenSureEntityUsingFkKullaniciIdStatic = new KullaniciRelations().GecenSureEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation GrupAtamaEntityUsingFkKullaniciIdStatic = new KullaniciRelations().GrupAtamaEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation IpBankEntityUsingFkKullaniciIdStatic = new KullaniciRelations().IpBankEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation IstatistikEntityUsingFkKullaniciIdStatic = new KullaniciRelations().IstatistikEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation KopukCagriEntityUsingFkKullaniciIdStatic = new KullaniciRelations().KopukCagriEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation KpsArsivEntityUsingFkKullaniciIdStatic = new KullaniciRelations().KpsArsivEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation LogEntityUsingFkKullaniciIdStatic = new KullaniciRelations().LogEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation MesajEntityUsingFkKullaniciIdStatic = new KullaniciRelations().MesajEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation ParametreEntityUsingFkKullaniciIdStatic = new KullaniciRelations().ParametreEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation ParametreGenelArsivEntityUsingFkKullaniciIdStatic = new KullaniciRelations().ParametreGenelArsivEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation RaporYetkiEntityUsingFkKullaniciIdStatic = new KullaniciRelations().RaporYetkiEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation SorunEntityUsingFkKullaniciIdStatic = new KullaniciRelations().SorunEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation VatandaEntityUsingFkKullaniciIdStatic = new KullaniciRelations().VatandaEntityUsingFkKullaniciId;
		internal static readonly IEntityRelation GorevEntityUsingFkGorevIdStatic = new KullaniciRelations().GorevEntityUsingFkGorevId;
		internal static readonly IEntityRelation HiyerarsiTurEntityUsingFkHiyerarsiTurIdStatic = new KullaniciRelations().HiyerarsiTurEntityUsingFkHiyerarsiTurId;
		internal static readonly IEntityRelation YetkiEntityUsingFkYetkiIdStatic = new KullaniciRelations().YetkiEntityUsingFkYetkiId;

		/// <summary>CTor</summary>
		static StaticKullaniciRelations()
		{
		}
	}
}
