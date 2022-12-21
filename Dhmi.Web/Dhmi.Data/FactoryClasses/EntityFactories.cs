///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 14 Mart 2016 Pazartesi 16:37:38
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using dhmi.HelperClasses;

using dhmi.EntityClasses;
using dhmi.RelationClasses;
using dhmi.DaoClasses;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace dhmi.FactoryClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private readonly dhmi.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, dhmi.EntityType typeOfEntity) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((dhmi.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			return (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(ForEntityName, fieldValues, entityFieldStartIndexesPerEntity) ?? this;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
	}
	
	/// <summary>Factory to create new, empty AcikBildirimEntity objects.</summary>
	[Serializable]
	public partial class AcikBildirimEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AcikBildirimEntityFactory() : base("AcikBildirimEntity", dhmi.EntityType.AcikBildirimEntity) { }

		/// <summary>Creates a new, empty AcikBildirimEntity object.</summary>
		/// <returns>A new, empty AcikBildirimEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AcikBildirimEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAcikBildirim
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AcikBildirimAyrintiEntity objects.</summary>
	[Serializable]
	public partial class AcikBildirimAyrintiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AcikBildirimAyrintiEntityFactory() : base("AcikBildirimAyrintiEntity", dhmi.EntityType.AcikBildirimAyrintiEntity) { }

		/// <summary>Creates a new, empty AcikBildirimAyrintiEntity object.</summary>
		/// <returns>A new, empty AcikBildirimAyrintiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AcikBildirimAyrintiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAcikBildirimAyrinti
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AltAltMenuEntity objects.</summary>
	[Serializable]
	public partial class AltAltMenuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AltAltMenuEntityFactory() : base("AltAltMenuEntity", dhmi.EntityType.AltAltMenuEntity) { }

		/// <summary>Creates a new, empty AltAltMenuEntity object.</summary>
		/// <returns>A new, empty AltAltMenuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AltAltMenuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAltAltMenu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AltKarakterEntity objects.</summary>
	[Serializable]
	public partial class AltKarakterEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AltKarakterEntityFactory() : base("AltKarakterEntity", dhmi.EntityType.AltKarakterEntity) { }

		/// <summary>Creates a new, empty AltKarakterEntity object.</summary>
		/// <returns>A new, empty AltKarakterEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AltKarakterEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAltKarakter
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AltKonuEntity objects.</summary>
	[Serializable]
	public partial class AltKonuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AltKonuEntityFactory() : base("AltKonuEntity", dhmi.EntityType.AltKonuEntity) { }

		/// <summary>Creates a new, empty AltKonuEntity object.</summary>
		/// <returns>A new, empty AltKonuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AltKonuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAltKonu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty AltMenuEntity objects.</summary>
	[Serializable]
	public partial class AltMenuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public AltMenuEntityFactory() : base("AltMenuEntity", dhmi.EntityType.AltMenuEntity) { }

		/// <summary>Creates a new, empty AltMenuEntity object.</summary>
		/// <returns>A new, empty AltMenuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new AltMenuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAltMenu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BaskanlikEntity objects.</summary>
	[Serializable]
	public partial class BaskanlikEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BaskanlikEntityFactory() : base("BaskanlikEntity", dhmi.EntityType.BaskanlikEntity) { }

		/// <summary>Creates a new, empty BaskanlikEntity object.</summary>
		/// <returns>A new, empty BaskanlikEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BaskanlikEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBaskanlik
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimEntity objects.</summary>
	[Serializable]
	public partial class BildirimEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimEntityFactory() : base("BildirimEntity", dhmi.EntityType.BildirimEntity) { }

		/// <summary>Creates a new, empty BildirimEntity object.</summary>
		/// <returns>A new, empty BildirimEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirim
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimAtamaGrupEntity objects.</summary>
	[Serializable]
	public partial class BildirimAtamaGrupEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimAtamaGrupEntityFactory() : base("BildirimAtamaGrupEntity", dhmi.EntityType.BildirimAtamaGrupEntity) { }

		/// <summary>Creates a new, empty BildirimAtamaGrupEntity object.</summary>
		/// <returns>A new, empty BildirimAtamaGrupEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimAtamaGrupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimAtamaGrup
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimAtamaKullaniciEntity objects.</summary>
	[Serializable]
	public partial class BildirimAtamaKullaniciEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimAtamaKullaniciEntityFactory() : base("BildirimAtamaKullaniciEntity", dhmi.EntityType.BildirimAtamaKullaniciEntity) { }

		/// <summary>Creates a new, empty BildirimAtamaKullaniciEntity object.</summary>
		/// <returns>A new, empty BildirimAtamaKullaniciEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimAtamaKullaniciEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimAtamaKullanici
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimGeriDonuEntity objects.</summary>
	[Serializable]
	public partial class BildirimGeriDonuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimGeriDonuEntityFactory() : base("BildirimGeriDonuEntity", dhmi.EntityType.BildirimGeriDonuEntity) { }

		/// <summary>Creates a new, empty BildirimGeriDonuEntity object.</summary>
		/// <returns>A new, empty BildirimGeriDonuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimGeriDonuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimGeriDonu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimHistoryEntity objects.</summary>
	[Serializable]
	public partial class BildirimHistoryEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimHistoryEntityFactory() : base("BildirimHistoryEntity", dhmi.EntityType.BildirimHistoryEntity) { }

		/// <summary>Creates a new, empty BildirimHistoryEntity object.</summary>
		/// <returns>A new, empty BildirimHistoryEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimHistoryEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimHistory
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimIslemEntity objects.</summary>
	[Serializable]
	public partial class BildirimIslemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimIslemEntityFactory() : base("BildirimIslemEntity", dhmi.EntityType.BildirimIslemEntity) { }

		/// <summary>Creates a new, empty BildirimIslemEntity object.</summary>
		/// <returns>A new, empty BildirimIslemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimIslemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimIslem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimSonucEntity objects.</summary>
	[Serializable]
	public partial class BildirimSonucEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimSonucEntityFactory() : base("BildirimSonucEntity", dhmi.EntityType.BildirimSonucEntity) { }

		/// <summary>Creates a new, empty BildirimSonucEntity object.</summary>
		/// <returns>A new, empty BildirimSonucEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimSonucEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimSonuc
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BildirimTuruEntity objects.</summary>
	[Serializable]
	public partial class BildirimTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BildirimTuruEntityFactory() : base("BildirimTuruEntity", dhmi.EntityType.BildirimTuruEntity) { }

		/// <summary>Creates a new, empty BildirimTuruEntity object.</summary>
		/// <returns>A new, empty BildirimTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BildirimTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBildirimTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BilgiBankasiEntity objects.</summary>
	[Serializable]
	public partial class BilgiBankasiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BilgiBankasiEntityFactory() : base("BilgiBankasiEntity", dhmi.EntityType.BilgiBankasiEntity) { }

		/// <summary>Creates a new, empty BilgiBankasiEntity object.</summary>
		/// <returns>A new, empty BilgiBankasiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BilgiBankasiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBilgiBankasi
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BilgiBankasiTurEntity objects.</summary>
	[Serializable]
	public partial class BilgiBankasiTurEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BilgiBankasiTurEntityFactory() : base("BilgiBankasiTurEntity", dhmi.EntityType.BilgiBankasiTurEntity) { }

		/// <summary>Creates a new, empty BilgiBankasiTurEntity object.</summary>
		/// <returns>A new, empty BilgiBankasiTurEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BilgiBankasiTurEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBilgiBankasiTur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty BilgilendirmeEntity objects.</summary>
	[Serializable]
	public partial class BilgilendirmeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public BilgilendirmeEntityFactory() : base("BilgilendirmeEntity", dhmi.EntityType.BilgilendirmeEntity) { }

		/// <summary>Creates a new, empty BilgilendirmeEntity object.</summary>
		/// <returns>A new, empty BilgilendirmeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new BilgilendirmeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBilgilendirme
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CagriMerkezEntity objects.</summary>
	[Serializable]
	public partial class CagriMerkezEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CagriMerkezEntityFactory() : base("CagriMerkezEntity", dhmi.EntityType.CagriMerkezEntity) { }

		/// <summary>Creates a new, empty CagriMerkezEntity object.</summary>
		/// <returns>A new, empty CagriMerkezEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CagriMerkezEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCagriMerkez
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty CagriTipiEntity objects.</summary>
	[Serializable]
	public partial class CagriTipiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public CagriTipiEntityFactory() : base("CagriTipiEntity", dhmi.EntityType.CagriTipiEntity) { }

		/// <summary>Creates a new, empty CagriTipiEntity object.</summary>
		/// <returns>A new, empty CagriTipiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new CagriTipiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCagriTipi
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DigerBirimlerEntity objects.</summary>
	[Serializable]
	public partial class DigerBirimlerEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DigerBirimlerEntityFactory() : base("DigerBirimlerEntity", dhmi.EntityType.DigerBirimlerEntity) { }

		/// <summary>Creates a new, empty DigerBirimlerEntity object.</summary>
		/// <returns>A new, empty DigerBirimlerEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DigerBirimlerEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDigerBirimler
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DigerBirimlerAyrintiEntity objects.</summary>
	[Serializable]
	public partial class DigerBirimlerAyrintiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DigerBirimlerAyrintiEntityFactory() : base("DigerBirimlerAyrintiEntity", dhmi.EntityType.DigerBirimlerAyrintiEntity) { }

		/// <summary>Creates a new, empty DigerBirimlerAyrintiEntity object.</summary>
		/// <returns>A new, empty DigerBirimlerAyrintiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DigerBirimlerAyrintiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDigerBirimlerAyrinti
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DosyaEntity objects.</summary>
	[Serializable]
	public partial class DosyaEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DosyaEntityFactory() : base("DosyaEntity", dhmi.EntityType.DosyaEntity) { }

		/// <summary>Creates a new, empty DosyaEntity object.</summary>
		/// <returns>A new, empty DosyaEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DosyaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDosya
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty DuyuruEntity objects.</summary>
	[Serializable]
	public partial class DuyuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public DuyuruEntityFactory() : base("DuyuruEntity", dhmi.EntityType.DuyuruEntity) { }

		/// <summary>Creates a new, empty DuyuruEntity object.</summary>
		/// <returns>A new, empty DuyuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new DuyuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDuyuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty EkSureEntity objects.</summary>
	[Serializable]
	public partial class EkSureEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public EkSureEntityFactory() : base("EkSureEntity", dhmi.EntityType.EkSureEntity) { }

		/// <summary>Creates a new, empty EkSureEntity object.</summary>
		/// <returns>A new, empty EkSureEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new EkSureEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEkSure
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GecenSureEntity objects.</summary>
	[Serializable]
	public partial class GecenSureEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GecenSureEntityFactory() : base("GecenSureEntity", dhmi.EntityType.GecenSureEntity) { }

		/// <summary>Creates a new, empty GecenSureEntity object.</summary>
		/// <returns>A new, empty GecenSureEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GecenSureEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGecenSure
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GizliSoruTuruEntity objects.</summary>
	[Serializable]
	public partial class GizliSoruTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GizliSoruTuruEntityFactory() : base("GizliSoruTuruEntity", dhmi.EntityType.GizliSoruTuruEntity) { }

		/// <summary>Creates a new, empty GizliSoruTuruEntity object.</summary>
		/// <returns>A new, empty GizliSoruTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GizliSoruTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGizliSoruTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GorevEntity objects.</summary>
	[Serializable]
	public partial class GorevEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GorevEntityFactory() : base("GorevEntity", dhmi.EntityType.GorevEntity) { }

		/// <summary>Creates a new, empty GorevEntity object.</summary>
		/// <returns>A new, empty GorevEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GorevEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGorev
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GrupEntity objects.</summary>
	[Serializable]
	public partial class GrupEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GrupEntityFactory() : base("GrupEntity", dhmi.EntityType.GrupEntity) { }

		/// <summary>Creates a new, empty GrupEntity object.</summary>
		/// <returns>A new, empty GrupEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GrupEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGrup
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty GrupAtamaEntity objects.</summary>
	[Serializable]
	public partial class GrupAtamaEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public GrupAtamaEntityFactory() : base("GrupAtamaEntity", dhmi.EntityType.GrupAtamaEntity) { }

		/// <summary>Creates a new, empty GrupAtamaEntity object.</summary>
		/// <returns>A new, empty GrupAtamaEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new GrupAtamaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewGrupAtama
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty HavalimaniEntity objects.</summary>
	[Serializable]
	public partial class HavalimaniEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public HavalimaniEntityFactory() : base("HavalimaniEntity", dhmi.EntityType.HavalimaniEntity) { }

		/// <summary>Creates a new, empty HavalimaniEntity object.</summary>
		/// <returns>A new, empty HavalimaniEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new HavalimaniEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHavalimani
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty HiyerarsiTurEntity objects.</summary>
	[Serializable]
	public partial class HiyerarsiTurEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public HiyerarsiTurEntityFactory() : base("HiyerarsiTurEntity", dhmi.EntityType.HiyerarsiTurEntity) { }

		/// <summary>Creates a new, empty HiyerarsiTurEntity object.</summary>
		/// <returns>A new, empty HiyerarsiTurEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new HiyerarsiTurEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewHiyerarsiTur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IlEntity objects.</summary>
	[Serializable]
	public partial class IlEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IlEntityFactory() : base("IlEntity", dhmi.EntityType.IlEntity) { }

		/// <summary>Creates a new, empty IlEntity object.</summary>
		/// <returns>A new, empty IlEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IlEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIl
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IpBankEntity objects.</summary>
	[Serializable]
	public partial class IpBankEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IpBankEntityFactory() : base("IpBankEntity", dhmi.EntityType.IpBankEntity) { }

		/// <summary>Creates a new, empty IpBankEntity object.</summary>
		/// <returns>A new, empty IpBankEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IpBankEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIpBank
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IslemEntity objects.</summary>
	[Serializable]
	public partial class IslemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IslemEntityFactory() : base("IslemEntity", dhmi.EntityType.IslemEntity) { }

		/// <summary>Creates a new, empty IslemEntity object.</summary>
		/// <returns>A new, empty IslemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IslemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIslem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IslemOlusturEntity objects.</summary>
	[Serializable]
	public partial class IslemOlusturEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IslemOlusturEntityFactory() : base("IslemOlusturEntity", dhmi.EntityType.IslemOlusturEntity) { }

		/// <summary>Creates a new, empty IslemOlusturEntity object.</summary>
		/// <returns>A new, empty IslemOlusturEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IslemOlusturEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIslemOlustur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IslemTuruEntity objects.</summary>
	[Serializable]
	public partial class IslemTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IslemTuruEntityFactory() : base("IslemTuruEntity", dhmi.EntityType.IslemTuruEntity) { }

		/// <summary>Creates a new, empty IslemTuruEntity object.</summary>
		/// <returns>A new, empty IslemTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IslemTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIslemTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty IstatistikEntity objects.</summary>
	[Serializable]
	public partial class IstatistikEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public IstatistikEntityFactory() : base("IstatistikEntity", dhmi.EntityType.IstatistikEntity) { }

		/// <summary>Creates a new, empty IstatistikEntity object.</summary>
		/// <returns>A new, empty IstatistikEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new IstatistikEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIstatistik
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KapatmaTurEntity objects.</summary>
	[Serializable]
	public partial class KapatmaTurEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KapatmaTurEntityFactory() : base("KapatmaTurEntity", dhmi.EntityType.KapatmaTurEntity) { }

		/// <summary>Creates a new, empty KapatmaTurEntity object.</summary>
		/// <returns>A new, empty KapatmaTurEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KapatmaTurEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKapatmaTur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KarakterEntity objects.</summary>
	[Serializable]
	public partial class KarakterEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KarakterEntityFactory() : base("KarakterEntity", dhmi.EntityType.KarakterEntity) { }

		/// <summary>Creates a new, empty KarakterEntity object.</summary>
		/// <returns>A new, empty KarakterEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KarakterEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKarakter
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KaraListeEntity objects.</summary>
	[Serializable]
	public partial class KaraListeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KaraListeEntityFactory() : base("KaraListeEntity", dhmi.EntityType.KaraListeEntity) { }

		/// <summary>Creates a new, empty KaraListeEntity object.</summary>
		/// <returns>A new, empty KaraListeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KaraListeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKaraListe
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KonuEntity objects.</summary>
	[Serializable]
	public partial class KonuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KonuEntityFactory() : base("KonuEntity", dhmi.EntityType.KonuEntity) { }

		/// <summary>Creates a new, empty KonuEntity object.</summary>
		/// <returns>A new, empty KonuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KonuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKonu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KonusalDagilimEntity objects.</summary>
	[Serializable]
	public partial class KonusalDagilimEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KonusalDagilimEntityFactory() : base("KonusalDagilimEntity", dhmi.EntityType.KonusalDagilimEntity) { }

		/// <summary>Creates a new, empty KonusalDagilimEntity object.</summary>
		/// <returns>A new, empty KonusalDagilimEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KonusalDagilimEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKonusalDagilim
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KopukCagriEntity objects.</summary>
	[Serializable]
	public partial class KopukCagriEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KopukCagriEntityFactory() : base("KopukCagriEntity", dhmi.EntityType.KopukCagriEntity) { }

		/// <summary>Creates a new, empty KopukCagriEntity object.</summary>
		/// <returns>A new, empty KopukCagriEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KopukCagriEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKopukCagri
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KopukCagriTuruEntity objects.</summary>
	[Serializable]
	public partial class KopukCagriTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KopukCagriTuruEntityFactory() : base("KopukCagriTuruEntity", dhmi.EntityType.KopukCagriTuruEntity) { }

		/// <summary>Creates a new, empty KopukCagriTuruEntity object.</summary>
		/// <returns>A new, empty KopukCagriTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KopukCagriTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKopukCagriTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KpsArsivEntity objects.</summary>
	[Serializable]
	public partial class KpsArsivEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KpsArsivEntityFactory() : base("KpsArsivEntity", dhmi.EntityType.KpsArsivEntity) { }

		/// <summary>Creates a new, empty KpsArsivEntity object.</summary>
		/// <returns>A new, empty KpsArsivEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KpsArsivEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKpsArsiv
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KpsBilgiEntity objects.</summary>
	[Serializable]
	public partial class KpsBilgiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KpsBilgiEntityFactory() : base("KpsBilgiEntity", dhmi.EntityType.KpsBilgiEntity) { }

		/// <summary>Creates a new, empty KpsBilgiEntity object.</summary>
		/// <returns>A new, empty KpsBilgiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KpsBilgiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKpsBilgi
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KullaniciEntity objects.</summary>
	[Serializable]
	public partial class KullaniciEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KullaniciEntityFactory() : base("KullaniciEntity", dhmi.EntityType.KullaniciEntity) { }

		/// <summary>Creates a new, empty KullaniciEntity object.</summary>
		/// <returns>A new, empty KullaniciEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KullaniciEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKullanici
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty KulTcNoEntity objects.</summary>
	[Serializable]
	public partial class KulTcNoEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public KulTcNoEntityFactory() : base("KulTcNoEntity", dhmi.EntityType.KulTcNoEntity) { }

		/// <summary>Creates a new, empty KulTcNoEntity object.</summary>
		/// <returns>A new, empty KulTcNoEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new KulTcNoEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKulTcNo
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LogEntity objects.</summary>
	[Serializable]
	public partial class LogEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LogEntityFactory() : base("LogEntity", dhmi.EntityType.LogEntity) { }

		/// <summary>Creates a new, empty LogEntity object.</summary>
		/// <returns>A new, empty LogEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LogEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLog
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LogEmailEntity objects.</summary>
	[Serializable]
	public partial class LogEmailEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LogEmailEntityFactory() : base("LogEmailEntity", dhmi.EntityType.LogEmailEntity) { }

		/// <summary>Creates a new, empty LogEmailEntity object.</summary>
		/// <returns>A new, empty LogEmailEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LogEmailEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogEmail
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LogHataEntity objects.</summary>
	[Serializable]
	public partial class LogHataEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LogHataEntityFactory() : base("LogHataEntity", dhmi.EntityType.LogHataEntity) { }

		/// <summary>Creates a new, empty LogHataEntity object.</summary>
		/// <returns>A new, empty LogHataEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LogHataEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogHata
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LogIslemEntity objects.</summary>
	[Serializable]
	public partial class LogIslemEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LogIslemEntityFactory() : base("LogIslemEntity", dhmi.EntityType.LogIslemEntity) { }

		/// <summary>Creates a new, empty LogIslemEntity object.</summary>
		/// <returns>A new, empty LogIslemEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LogIslemEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogIslem
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty LogSmEntity objects.</summary>
	[Serializable]
	public partial class LogSmEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public LogSmEntityFactory() : base("LogSmEntity", dhmi.EntityType.LogSmEntity) { }

		/// <summary>Creates a new, empty LogSmEntity object.</summary>
		/// <returns>A new, empty LogSmEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new LogSmEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLogSm
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MailBankEntity objects.</summary>
	[Serializable]
	public partial class MailBankEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MailBankEntityFactory() : base("MailBankEntity", dhmi.EntityType.MailBankEntity) { }

		/// <summary>Creates a new, empty MailBankEntity object.</summary>
		/// <returns>A new, empty MailBankEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MailBankEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMailBank
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MenuEntity objects.</summary>
	[Serializable]
	public partial class MenuEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MenuEntityFactory() : base("MenuEntity", dhmi.EntityType.MenuEntity) { }

		/// <summary>Creates a new, empty MenuEntity object.</summary>
		/// <returns>A new, empty MenuEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MenuEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenu
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MenuOlusturEntity objects.</summary>
	[Serializable]
	public partial class MenuOlusturEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MenuOlusturEntityFactory() : base("MenuOlusturEntity", dhmi.EntityType.MenuOlusturEntity) { }

		/// <summary>Creates a new, empty MenuOlusturEntity object.</summary>
		/// <returns>A new, empty MenuOlusturEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MenuOlusturEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMenuOlustur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MesajEntity objects.</summary>
	[Serializable]
	public partial class MesajEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MesajEntityFactory() : base("MesajEntity", dhmi.EntityType.MesajEntity) { }

		/// <summary>Creates a new, empty MesajEntity object.</summary>
		/// <returns>A new, empty MesajEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MesajEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMesaj
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParametreEntity objects.</summary>
	[Serializable]
	public partial class ParametreEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ParametreEntityFactory() : base("ParametreEntity", dhmi.EntityType.ParametreEntity) { }

		/// <summary>Creates a new, empty ParametreEntity object.</summary>
		/// <returns>A new, empty ParametreEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ParametreEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParametre
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParametreGenelArsivEntity objects.</summary>
	[Serializable]
	public partial class ParametreGenelArsivEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ParametreGenelArsivEntityFactory() : base("ParametreGenelArsivEntity", dhmi.EntityType.ParametreGenelArsivEntity) { }

		/// <summary>Creates a new, empty ParametreGenelArsivEntity object.</summary>
		/// <returns>A new, empty ParametreGenelArsivEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ParametreGenelArsivEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParametreGenelArsiv
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ParametreTurEntity objects.</summary>
	[Serializable]
	public partial class ParametreTurEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ParametreTurEntityFactory() : base("ParametreTurEntity", dhmi.EntityType.ParametreTurEntity) { }

		/// <summary>Creates a new, empty ParametreTurEntity object.</summary>
		/// <returns>A new, empty ParametreTurEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ParametreTurEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewParametreTur
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RaporIcerikEntity objects.</summary>
	[Serializable]
	public partial class RaporIcerikEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RaporIcerikEntityFactory() : base("RaporIcerikEntity", dhmi.EntityType.RaporIcerikEntity) { }

		/// <summary>Creates a new, empty RaporIcerikEntity object.</summary>
		/// <returns>A new, empty RaporIcerikEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RaporIcerikEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRaporIcerik
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RaporTuruEntity objects.</summary>
	[Serializable]
	public partial class RaporTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RaporTuruEntityFactory() : base("RaporTuruEntity", dhmi.EntityType.RaporTuruEntity) { }

		/// <summary>Creates a new, empty RaporTuruEntity object.</summary>
		/// <returns>A new, empty RaporTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RaporTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRaporTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty RaporYetkiEntity objects.</summary>
	[Serializable]
	public partial class RaporYetkiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public RaporYetkiEntityFactory() : base("RaporYetkiEntity", dhmi.EntityType.RaporYetkiEntity) { }

		/// <summary>Creates a new, empty RaporYetkiEntity object.</summary>
		/// <returns>A new, empty RaporYetkiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new RaporYetkiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRaporYetki
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SorunEntity objects.</summary>
	[Serializable]
	public partial class SorunEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SorunEntityFactory() : base("SorunEntity", dhmi.EntityType.SorunEntity) { }

		/// <summary>Creates a new, empty SorunEntity object.</summary>
		/// <returns>A new, empty SorunEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SorunEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSorun
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SorunTuruEntity objects.</summary>
	[Serializable]
	public partial class SorunTuruEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SorunTuruEntityFactory() : base("SorunTuruEntity", dhmi.EntityType.SorunTuruEntity) { }

		/// <summary>Creates a new, empty SorunTuruEntity object.</summary>
		/// <returns>A new, empty SorunTuruEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SorunTuruEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSorunTuru
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty SureTakipEntity objects.</summary>
	[Serializable]
	public partial class SureTakipEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public SureTakipEntityFactory() : base("SureTakipEntity", dhmi.EntityType.SureTakipEntity) { }

		/// <summary>Creates a new, empty SureTakipEntity object.</summary>
		/// <returns>A new, empty SureTakipEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new SureTakipEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSureTakip
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TurBankEntity objects.</summary>
	[Serializable]
	public partial class TurBankEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public TurBankEntityFactory() : base("TurBankEntity", dhmi.EntityType.TurBankEntity) { }

		/// <summary>Creates a new, empty TurBankEntity object.</summary>
		/// <returns>A new, empty TurBankEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new TurBankEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTurBank
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VatandaEntity objects.</summary>
	[Serializable]
	public partial class VatandaEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VatandaEntityFactory() : base("VatandaEntity", dhmi.EntityType.VatandaEntity) { }

		/// <summary>Creates a new, empty VatandaEntity object.</summary>
		/// <returns>A new, empty VatandaEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VatandaEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVatanda
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VatandasArsivEntity objects.</summary>
	[Serializable]
	public partial class VatandasArsivEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VatandasArsivEntityFactory() : base("VatandasArsivEntity", dhmi.EntityType.VatandasArsivEntity) { }

		/// <summary>Creates a new, empty VatandasArsivEntity object.</summary>
		/// <returns>A new, empty VatandasArsivEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VatandasArsivEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVatandasArsiv
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty VipListeEntity objects.</summary>
	[Serializable]
	public partial class VipListeEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public VipListeEntityFactory() : base("VipListeEntity", dhmi.EntityType.VipListeEntity) { }

		/// <summary>Creates a new, empty VipListeEntity object.</summary>
		/// <returns>A new, empty VipListeEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new VipListeEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVipListe
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty WebServiEntity objects.</summary>
	[Serializable]
	public partial class WebServiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public WebServiEntityFactory() : base("WebServiEntity", dhmi.EntityType.WebServiEntity) { }

		/// <summary>Creates a new, empty WebServiEntity object.</summary>
		/// <returns>A new, empty WebServiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new WebServiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWebServi
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty YetkiEntity objects.</summary>
	[Serializable]
	public partial class YetkiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public YetkiEntityFactory() : base("YetkiEntity", dhmi.EntityType.YetkiEntity) { }

		/// <summary>Creates a new, empty YetkiEntity object.</summary>
		/// <returns>A new, empty YetkiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new YetkiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewYetki
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty ZamanEntity objects.</summary>
	[Serializable]
	public partial class ZamanEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public ZamanEntityFactory() : base("ZamanEntity", dhmi.EntityType.ZamanEntity) { }

		/// <summary>Creates a new, empty ZamanEntity object.</summary>
		/// <returns>A new, empty ZamanEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new ZamanEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewZaman
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}


		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(dhmi.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case dhmi.EntityType.AcikBildirimEntity:
					return new AcikBildirimCollection();
				case dhmi.EntityType.AcikBildirimAyrintiEntity:
					return new AcikBildirimAyrintiCollection();
				case dhmi.EntityType.AltAltMenuEntity:
					return new AltAltMenuCollection();
				case dhmi.EntityType.AltKarakterEntity:
					return new AltKarakterCollection();
				case dhmi.EntityType.AltKonuEntity:
					return new AltKonuCollection();
				case dhmi.EntityType.AltMenuEntity:
					return new AltMenuCollection();
				case dhmi.EntityType.BaskanlikEntity:
					return new BaskanlikCollection();
				case dhmi.EntityType.BildirimEntity:
					return new BildirimCollection();
				case dhmi.EntityType.BildirimAtamaGrupEntity:
					return new BildirimAtamaGrupCollection();
				case dhmi.EntityType.BildirimAtamaKullaniciEntity:
					return new BildirimAtamaKullaniciCollection();
				case dhmi.EntityType.BildirimGeriDonuEntity:
					return new BildirimGeriDonuCollection();
				case dhmi.EntityType.BildirimHistoryEntity:
					return new BildirimHistoryCollection();
				case dhmi.EntityType.BildirimIslemEntity:
					return new BildirimIslemCollection();
				case dhmi.EntityType.BildirimSonucEntity:
					return new BildirimSonucCollection();
				case dhmi.EntityType.BildirimTuruEntity:
					return new BildirimTuruCollection();
				case dhmi.EntityType.BilgiBankasiEntity:
					return new BilgiBankasiCollection();
				case dhmi.EntityType.BilgiBankasiTurEntity:
					return new BilgiBankasiTurCollection();
				case dhmi.EntityType.BilgilendirmeEntity:
					return new BilgilendirmeCollection();
				case dhmi.EntityType.CagriMerkezEntity:
					return new CagriMerkezCollection();
				case dhmi.EntityType.CagriTipiEntity:
					return new CagriTipiCollection();
				case dhmi.EntityType.DigerBirimlerEntity:
					return new DigerBirimlerCollection();
				case dhmi.EntityType.DigerBirimlerAyrintiEntity:
					return new DigerBirimlerAyrintiCollection();
				case dhmi.EntityType.DosyaEntity:
					return new DosyaCollection();
				case dhmi.EntityType.DuyuruEntity:
					return new DuyuruCollection();
				case dhmi.EntityType.EkSureEntity:
					return new EkSureCollection();
				case dhmi.EntityType.GecenSureEntity:
					return new GecenSureCollection();
				case dhmi.EntityType.GizliSoruTuruEntity:
					return new GizliSoruTuruCollection();
				case dhmi.EntityType.GorevEntity:
					return new GorevCollection();
				case dhmi.EntityType.GrupEntity:
					return new GrupCollection();
				case dhmi.EntityType.GrupAtamaEntity:
					return new GrupAtamaCollection();
				case dhmi.EntityType.HavalimaniEntity:
					return new HavalimaniCollection();
				case dhmi.EntityType.HiyerarsiTurEntity:
					return new HiyerarsiTurCollection();
				case dhmi.EntityType.IlEntity:
					return new IlCollection();
				case dhmi.EntityType.IpBankEntity:
					return new IpBankCollection();
				case dhmi.EntityType.IslemEntity:
					return new IslemCollection();
				case dhmi.EntityType.IslemOlusturEntity:
					return new IslemOlusturCollection();
				case dhmi.EntityType.IslemTuruEntity:
					return new IslemTuruCollection();
				case dhmi.EntityType.IstatistikEntity:
					return new IstatistikCollection();
				case dhmi.EntityType.KapatmaTurEntity:
					return new KapatmaTurCollection();
				case dhmi.EntityType.KarakterEntity:
					return new KarakterCollection();
				case dhmi.EntityType.KaraListeEntity:
					return new KaraListeCollection();
				case dhmi.EntityType.KonuEntity:
					return new KonuCollection();
				case dhmi.EntityType.KonusalDagilimEntity:
					return new KonusalDagilimCollection();
				case dhmi.EntityType.KopukCagriEntity:
					return new KopukCagriCollection();
				case dhmi.EntityType.KopukCagriTuruEntity:
					return new KopukCagriTuruCollection();
				case dhmi.EntityType.KpsArsivEntity:
					return new KpsArsivCollection();
				case dhmi.EntityType.KpsBilgiEntity:
					return new KpsBilgiCollection();
				case dhmi.EntityType.KullaniciEntity:
					return new KullaniciCollection();
				case dhmi.EntityType.KulTcNoEntity:
					return new KulTcNoCollection();
				case dhmi.EntityType.LogEntity:
					return new LogCollection();
				case dhmi.EntityType.LogEmailEntity:
					return new LogEmailCollection();
				case dhmi.EntityType.LogHataEntity:
					return new LogHataCollection();
				case dhmi.EntityType.LogIslemEntity:
					return new LogIslemCollection();
				case dhmi.EntityType.LogSmEntity:
					return new LogSmCollection();
				case dhmi.EntityType.MailBankEntity:
					return new MailBankCollection();
				case dhmi.EntityType.MenuEntity:
					return new MenuCollection();
				case dhmi.EntityType.MenuOlusturEntity:
					return new MenuOlusturCollection();
				case dhmi.EntityType.MesajEntity:
					return new MesajCollection();
				case dhmi.EntityType.ParametreEntity:
					return new ParametreCollection();
				case dhmi.EntityType.ParametreGenelArsivEntity:
					return new ParametreGenelArsivCollection();
				case dhmi.EntityType.ParametreTurEntity:
					return new ParametreTurCollection();
				case dhmi.EntityType.RaporIcerikEntity:
					return new RaporIcerikCollection();
				case dhmi.EntityType.RaporTuruEntity:
					return new RaporTuruCollection();
				case dhmi.EntityType.RaporYetkiEntity:
					return new RaporYetkiCollection();
				case dhmi.EntityType.SorunEntity:
					return new SorunCollection();
				case dhmi.EntityType.SorunTuruEntity:
					return new SorunTuruCollection();
				case dhmi.EntityType.SureTakipEntity:
					return new SureTakipCollection();
				case dhmi.EntityType.TurBankEntity:
					return new TurBankCollection();
				case dhmi.EntityType.VatandaEntity:
					return new VatandaCollection();
				case dhmi.EntityType.VatandasArsivEntity:
					return new VatandasArsivCollection();
				case dhmi.EntityType.VipListeEntity:
					return new VipListeCollection();
				case dhmi.EntityType.WebServiEntity:
					return new WebServiCollection();
				case dhmi.EntityType.YetkiEntity:
					return new YetkiCollection();
				case dhmi.EntityType.ZamanEntity:
					return new ZamanCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(dhmi.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case dhmi.EntityType.AcikBildirimEntity:
					factoryToUse = new AcikBildirimEntityFactory();
					break;
				case dhmi.EntityType.AcikBildirimAyrintiEntity:
					factoryToUse = new AcikBildirimAyrintiEntityFactory();
					break;
				case dhmi.EntityType.AltAltMenuEntity:
					factoryToUse = new AltAltMenuEntityFactory();
					break;
				case dhmi.EntityType.AltKarakterEntity:
					factoryToUse = new AltKarakterEntityFactory();
					break;
				case dhmi.EntityType.AltKonuEntity:
					factoryToUse = new AltKonuEntityFactory();
					break;
				case dhmi.EntityType.AltMenuEntity:
					factoryToUse = new AltMenuEntityFactory();
					break;
				case dhmi.EntityType.BaskanlikEntity:
					factoryToUse = new BaskanlikEntityFactory();
					break;
				case dhmi.EntityType.BildirimEntity:
					factoryToUse = new BildirimEntityFactory();
					break;
				case dhmi.EntityType.BildirimAtamaGrupEntity:
					factoryToUse = new BildirimAtamaGrupEntityFactory();
					break;
				case dhmi.EntityType.BildirimAtamaKullaniciEntity:
					factoryToUse = new BildirimAtamaKullaniciEntityFactory();
					break;
				case dhmi.EntityType.BildirimGeriDonuEntity:
					factoryToUse = new BildirimGeriDonuEntityFactory();
					break;
				case dhmi.EntityType.BildirimHistoryEntity:
					factoryToUse = new BildirimHistoryEntityFactory();
					break;
				case dhmi.EntityType.BildirimIslemEntity:
					factoryToUse = new BildirimIslemEntityFactory();
					break;
				case dhmi.EntityType.BildirimSonucEntity:
					factoryToUse = new BildirimSonucEntityFactory();
					break;
				case dhmi.EntityType.BildirimTuruEntity:
					factoryToUse = new BildirimTuruEntityFactory();
					break;
				case dhmi.EntityType.BilgiBankasiEntity:
					factoryToUse = new BilgiBankasiEntityFactory();
					break;
				case dhmi.EntityType.BilgiBankasiTurEntity:
					factoryToUse = new BilgiBankasiTurEntityFactory();
					break;
				case dhmi.EntityType.BilgilendirmeEntity:
					factoryToUse = new BilgilendirmeEntityFactory();
					break;
				case dhmi.EntityType.CagriMerkezEntity:
					factoryToUse = new CagriMerkezEntityFactory();
					break;
				case dhmi.EntityType.CagriTipiEntity:
					factoryToUse = new CagriTipiEntityFactory();
					break;
				case dhmi.EntityType.DigerBirimlerEntity:
					factoryToUse = new DigerBirimlerEntityFactory();
					break;
				case dhmi.EntityType.DigerBirimlerAyrintiEntity:
					factoryToUse = new DigerBirimlerAyrintiEntityFactory();
					break;
				case dhmi.EntityType.DosyaEntity:
					factoryToUse = new DosyaEntityFactory();
					break;
				case dhmi.EntityType.DuyuruEntity:
					factoryToUse = new DuyuruEntityFactory();
					break;
				case dhmi.EntityType.EkSureEntity:
					factoryToUse = new EkSureEntityFactory();
					break;
				case dhmi.EntityType.GecenSureEntity:
					factoryToUse = new GecenSureEntityFactory();
					break;
				case dhmi.EntityType.GizliSoruTuruEntity:
					factoryToUse = new GizliSoruTuruEntityFactory();
					break;
				case dhmi.EntityType.GorevEntity:
					factoryToUse = new GorevEntityFactory();
					break;
				case dhmi.EntityType.GrupEntity:
					factoryToUse = new GrupEntityFactory();
					break;
				case dhmi.EntityType.GrupAtamaEntity:
					factoryToUse = new GrupAtamaEntityFactory();
					break;
				case dhmi.EntityType.HavalimaniEntity:
					factoryToUse = new HavalimaniEntityFactory();
					break;
				case dhmi.EntityType.HiyerarsiTurEntity:
					factoryToUse = new HiyerarsiTurEntityFactory();
					break;
				case dhmi.EntityType.IlEntity:
					factoryToUse = new IlEntityFactory();
					break;
				case dhmi.EntityType.IpBankEntity:
					factoryToUse = new IpBankEntityFactory();
					break;
				case dhmi.EntityType.IslemEntity:
					factoryToUse = new IslemEntityFactory();
					break;
				case dhmi.EntityType.IslemOlusturEntity:
					factoryToUse = new IslemOlusturEntityFactory();
					break;
				case dhmi.EntityType.IslemTuruEntity:
					factoryToUse = new IslemTuruEntityFactory();
					break;
				case dhmi.EntityType.IstatistikEntity:
					factoryToUse = new IstatistikEntityFactory();
					break;
				case dhmi.EntityType.KapatmaTurEntity:
					factoryToUse = new KapatmaTurEntityFactory();
					break;
				case dhmi.EntityType.KarakterEntity:
					factoryToUse = new KarakterEntityFactory();
					break;
				case dhmi.EntityType.KaraListeEntity:
					factoryToUse = new KaraListeEntityFactory();
					break;
				case dhmi.EntityType.KonuEntity:
					factoryToUse = new KonuEntityFactory();
					break;
				case dhmi.EntityType.KonusalDagilimEntity:
					factoryToUse = new KonusalDagilimEntityFactory();
					break;
				case dhmi.EntityType.KopukCagriEntity:
					factoryToUse = new KopukCagriEntityFactory();
					break;
				case dhmi.EntityType.KopukCagriTuruEntity:
					factoryToUse = new KopukCagriTuruEntityFactory();
					break;
				case dhmi.EntityType.KpsArsivEntity:
					factoryToUse = new KpsArsivEntityFactory();
					break;
				case dhmi.EntityType.KpsBilgiEntity:
					factoryToUse = new KpsBilgiEntityFactory();
					break;
				case dhmi.EntityType.KullaniciEntity:
					factoryToUse = new KullaniciEntityFactory();
					break;
				case dhmi.EntityType.KulTcNoEntity:
					factoryToUse = new KulTcNoEntityFactory();
					break;
				case dhmi.EntityType.LogEntity:
					factoryToUse = new LogEntityFactory();
					break;
				case dhmi.EntityType.LogEmailEntity:
					factoryToUse = new LogEmailEntityFactory();
					break;
				case dhmi.EntityType.LogHataEntity:
					factoryToUse = new LogHataEntityFactory();
					break;
				case dhmi.EntityType.LogIslemEntity:
					factoryToUse = new LogIslemEntityFactory();
					break;
				case dhmi.EntityType.LogSmEntity:
					factoryToUse = new LogSmEntityFactory();
					break;
				case dhmi.EntityType.MailBankEntity:
					factoryToUse = new MailBankEntityFactory();
					break;
				case dhmi.EntityType.MenuEntity:
					factoryToUse = new MenuEntityFactory();
					break;
				case dhmi.EntityType.MenuOlusturEntity:
					factoryToUse = new MenuOlusturEntityFactory();
					break;
				case dhmi.EntityType.MesajEntity:
					factoryToUse = new MesajEntityFactory();
					break;
				case dhmi.EntityType.ParametreEntity:
					factoryToUse = new ParametreEntityFactory();
					break;
				case dhmi.EntityType.ParametreGenelArsivEntity:
					factoryToUse = new ParametreGenelArsivEntityFactory();
					break;
				case dhmi.EntityType.ParametreTurEntity:
					factoryToUse = new ParametreTurEntityFactory();
					break;
				case dhmi.EntityType.RaporIcerikEntity:
					factoryToUse = new RaporIcerikEntityFactory();
					break;
				case dhmi.EntityType.RaporTuruEntity:
					factoryToUse = new RaporTuruEntityFactory();
					break;
				case dhmi.EntityType.RaporYetkiEntity:
					factoryToUse = new RaporYetkiEntityFactory();
					break;
				case dhmi.EntityType.SorunEntity:
					factoryToUse = new SorunEntityFactory();
					break;
				case dhmi.EntityType.SorunTuruEntity:
					factoryToUse = new SorunTuruEntityFactory();
					break;
				case dhmi.EntityType.SureTakipEntity:
					factoryToUse = new SureTakipEntityFactory();
					break;
				case dhmi.EntityType.TurBankEntity:
					factoryToUse = new TurBankEntityFactory();
					break;
				case dhmi.EntityType.VatandaEntity:
					factoryToUse = new VatandaEntityFactory();
					break;
				case dhmi.EntityType.VatandasArsivEntity:
					factoryToUse = new VatandasArsivEntityFactory();
					break;
				case dhmi.EntityType.VipListeEntity:
					factoryToUse = new VipListeEntityFactory();
					break;
				case dhmi.EntityType.WebServiEntity:
					factoryToUse = new WebServiEntityFactory();
					break;
				case dhmi.EntityType.YetkiEntity:
					factoryToUse = new YetkiEntityFactory();
					break;
				case dhmi.EntityType.ZamanEntity:
					factoryToUse = new ZamanEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the dhmi.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(dhmi.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static readonly Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(dhmi.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((dhmi.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the dhmi.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(dhmi.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the dhmi.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (dhmi.EntityType)Enum.Parse(typeof(dhmi.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((dhmi.EntityType)Enum.Parse(typeof(dhmi.EntityType), leftOperandEntityName, false), joinType, (dhmi.EntityType)Enum.Parse(typeof(dhmi.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
				
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the dhmi.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((dhmi.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
