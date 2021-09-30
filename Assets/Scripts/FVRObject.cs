using System;
using System.Collections.Generic;
using UnityEngine;
using WurstMod.Shared;

namespace FistVR
{
  [CreateAssetMenu(fileName = "FVRObject")]
  public class FVRObject : AnvilAsset
  {
    public string ItemID;
    public string DisplayName;
    public FVRObject.ObjectCategory Category;
    public string SpawnedFromId;
    [Header("Values")]
    public float Mass;
    public int MagazineCapacity;
    public bool RequiresPicatinnySight;
    [Header("Tags")]
    public FVRObject.OTagEra TagEra;
    public FVRObject.OTagSet TagSet;
    public FVRObject.OTagFirearmSize TagFirearmSize;
    public FVRObject.OTagFirearmAction TagFirearmAction;
    public FVRObject.OTagFirearmRoundPower TagFirearmRoundPower;
    [SearchableEnum]
    public FVRObject.OTagFirearmCountryOfOrigin TagFirearmCountryOfOrigin;
    public int TagFirearmFirstYear;
    public List<FVRObject.OTagFirearmFiringMode> TagFirearmFiringModes;
    public List<FVRObject.OTagFirearmFeedOption> TagFirearmFeedOption;
    public List<FVRObject.OTagFirearmMount> TagFirearmMounts;
    public FVRObject.OTagFirearmMount TagAttachmentMount;
    public FVRObject.OTagAttachmentFeature TagAttachmentFeature;
    public FVRObject.OTagMeleeStyle TagMeleeStyle;
    public FVRObject.OTagMeleeHandedness TagMeleeHandedness;
    public FVRObject.OTagPowerupType TagPowerupType;
    public FVRObject.OTagThrownType TagThrownType;
    public FVRObject.OTagThrownDamageType TagThrownDamageType;
    [Header("RelatedAssets")]
    public List<FVRObject> CompatibleMagazines;
    public List<FVRObject> CompatibleClips;
    public List<FVRObject> CompatibleSpeedLoaders;
    public List<FVRObject> CompatibleSingleRounds;
    public List<FVRObject> BespokeAttachments;
    public List<FVRObject> RequiredSecondaryPieces;
    public int MinCapacityRelated;
    public int MaxCapacityRelated;
    [Header("EcoSystemStuff")]
    public int CreditCost;
    public bool OSple;

    [ContextMenu("PrintBespoke")]
    public void PrintBespoke()
    {
    }

    public FVRObject GetMagazineWithinCapacity(int cap)
    {
      return null;
    }

    public FVRObject GetRandomAmmoObject(
      FVRObject o,
      List<FVRObject.OTagEra> eras = null,
      int Min = -1,
      int Max = -1,
      List<FVRObject.OTagSet> sets = null)
    {
      return (FVRObject) null;
    }

    [ContextMenu("GenerateItemIDFromDisplayName")]
    public void GenerateItemIDFromDisplayName()
    {
    }

    [ContextMenu("SetNamesFromFileName")]
    public void SetNamesFromFileName()
    {
    }

    [ContextMenu("PopulateMinMaxCapacity")]
    public void PopulateMinMaxCapacity()
    {
    }

    [ContextMenu("PopulateAttachments")]
    public void PopulateAttachments()
    {
    }

    [ContextMenu("PopulateRoundPower")]
    public void PopulateRoundPower()
    {
    }

    [ContextMenu("MigrateFirearmDataToMagazine")]
    public void MigrateFirearmDataToMagazine()
    {
    }

    [ContextMenu("Calc Credit Cost")]
    public void CalcCreditCost()
    {
    }

    public enum ObjectCategory
    {
      Uncategorized = 0,
      Firearm = 1,
      Magazine = 2,
      Clip = 3,
      Cartridge = 4,
      Attachment = 5,
      SpeedLoader = 6,
      Thrown = 7,
      MeleeWeapon = 10, // 0x0000000A
      Explosive = 20, // 0x00000014
      Powerup = 25, // 0x00000019
      Target = 30, // 0x0000001E
      Tool = 40, // 0x00000028
      Toy = 41, // 0x00000029
      Firework = 42, // 0x0000002A
      Ornament = 43, // 0x0000002B
      Loot = 50, // 0x00000032
      VFX = 51, // 0x00000033
    }

    public enum OTagSet
    {
      Real,
      GroundedFictional,
      SciFiFictional,
      Meme,
      MF,
      Holiday,
      TNH,
    }

    public enum OTagEra
    {
      None,
      Colonial,
      WildWest,
      TurnOfTheCentury,
      WW1,
      WW2,
      PostWar,
      Modern,
      Futuristic,
      Medieval,
    }

    public enum OTagFirearmSize
    {
      None,
      Pocket,
      Pistol,
      Compact,
      Carbine,
      FullSize,
      Bulky,
      Oversize,
    }

    public enum OTagFirearmAction
    {
      None,
      BreakAction,
      BoltAction,
      Revolver,
      PumpAction,
      LeverAction,
      Automatic,
      RollingBlock,
      OpenBreach,
      Preloaded,
      SingleActionRevolver,
    }

    public enum OTagFirearmFiringMode
    {
      None,
      SemiAuto,
      Burst,
      FullAuto,
      SingleFire,
    }

    public enum OTagFirearmFeedOption
    {
      None,
      BreachLoad,
      InternalMag,
      BoxMag,
      StripperClip,
      EnblocClip,
    }

    public enum OTagFirearmRoundPower
    {
      None,
      Tiny,
      Pistol,
      Shotgun,
      Intermediate,
      FullPower,
      AntiMaterial,
      Ordnance,
      Exotic,
      Fire,
    }

    public enum OTagFirearmMount
    {
      None,
      Picatinny,
      Russian,
      Muzzle,
      Stock,
      Bespoke,
    }

    public enum OTagFirearmCountryOfOrigin
    {
      None = 0,
      Fictional = 1,
      UnitedStatesOfAmerica = 10, // 0x0000000A
      MuricanRemnants = 11, // 0x0000000B
      BritishEmpire = 20, // 0x00000014
      UnitedKingdom = 21, // 0x00000015
      KingdomOfFrance = 30, // 0x0000001E
      FrenchSecondRepublic = 31, // 0x0000001F
      SecondFrenchEmpire = 32, // 0x00000020
      FrenchThirdRepublic = 33, // 0x00000021
      VichyFrance = 34, // 0x00000022
      FrenchFourthRepublic = 35, // 0x00000023
      FrenchRepublic = 36, // 0x00000024
      GermanEmpire = 40, // 0x00000028
      WeimarRepublic = 41, // 0x00000029
      GermanReich = 42, // 0x0000002A
      WestGermany = 43, // 0x0000002B
      GermanDemocraticRepublic = 44, // 0x0000002C
      FederalRepublicOfGermany = 45, // 0x0000002D
      TsardomOfRussia = 50, // 0x00000032
      RussianEmpire = 51, // 0x00000033
      UnionOfSovietSocialistRepublics = 52, // 0x00000034
      RussianFederation = 53, // 0x00000035
      KingdomOfBelgium = 60, // 0x0000003C
      KingdomOfItaly = 70, // 0x00000046
      ItalianRepublic = 71, // 0x00000047
      SwedishEmpire = 90, // 0x0000005A
      UnitedKingdomsOfSwedenAndNorway = 91, // 0x0000005B
      KingdomOfSweden = 92, // 0x0000005C
      KingdomOfNorway = 100, // 0x00000064
      KingdomOfFinland = 110, // 0x0000006E
      RepublicOfFinland = 111, // 0x0000006F
      Czechoslovakia = 120, // 0x00000078
      CzechRepublic = 121, // 0x00000079
      Ukraine = 130, // 0x00000082
      SwissConfederation = 140, // 0x0000008C
      FirstSpanishRepublic = 150, // 0x00000096
      SecondSpanishRepublic = 151, // 0x00000097
      SpanishState = 152, // 0x00000098
      KingdomOfSpain = 153, // 0x00000099
      AustrianEmpire = 160, // 0x000000A0
      AustroHungarianEmpire = 161, // 0x000000A1
      RepublicOfAustria = 162, // 0x000000A2
      FirstHungarianRepublic = 170, // 0x000000AA
      HungarianRepublic = 171, // 0x000000AB
      KingdomOfHungary = 172, // 0x000000AC
      HungarianPeoplesRepublic = 173, // 0x000000AD
      RepublicOfCroatia = 190, // 0x000000BE
      RepublicOfKorea = 200, // 0x000000C8
      DemocraticRepublicOfVietnam = 210, // 0x000000D2
      StateOfIsrael = 220, // 0x000000DC
      FederativeRepublicOfBrazil = 230, // 0x000000E6
      EmpireOfJapan = 240, // 0x000000F0
      RepublicOfSouthAfrica = 250, // 0x000000FA
      GovernmentOfTheRepublicOfPolandInExile = 262, // 0x00000106
      RepublicOfPoland = 263, // 0x00000107
      PeoplesRepublicOfChina = 270, // 0x0000010E
      FormerYugoslavicRepublicOfMacedonia = 280, // 0x00000118
    }

    public enum OTagAttachmentFeature
    {
      None,
      IronSight,
      Magnification,
      Reflex,
      Suppression,
      Stock,
      Laser,
      Illumination,
      Grip,
      Decoration,
      RecoilMitigation,
      BarrelExtension,
      Adapter,
      Bayonet,
      ProjectileWeapon,
      Bipod,
    }

    public enum OTagMeleeStyle
    {
      None,
      Tactical,
      Tool,
      Improvised,
      Medieval,
      Shield,
      PowerTool,
    }

    public enum OTagMeleeHandedness
    {
      None,
      OneHanded,
      TwoHanded,
    }

    public enum OTagPowerupType
    {
      None = -1, // 0xFFFFFFFF
      Health = 0,
      QuadDamage = 1,
      InfiniteAmmo = 2,
      Invincibility = 3,
      GhostMode = 4,
      FarOutMeat = 5,
      MuscleMeat = 6,
      HomeTown = 7,
      SnakeEye = 8,
      Blort = 9,
      Regen = 10, // 0x0000000A
      Cyclops = 11, // 0x0000000B
      WheredIGo = 12, // 0x0000000C
      ChillOut = 13, // 0x0000000D
    }

    public enum OTagThrownType
    {
      None,
      ManualFuse,
      Pinned,
      Strange,
    }

    public enum OTagThrownDamageType
    {
      None,
      Kinetic,
      Explosive,
      Fire,
      Utility,
    }
  }

  [AttributeUsage(AttributeTargets.Field)]
  public class SearchableEnumAttribute : PropertyAttribute
  {
  }

  public abstract class AnvilAsset : ScriptableObject
  {
    [SerializeField]
    public AssetID m_anvilPrefab;
    [SerializeField]
    public bool m_export;
    [NonSerialized]
    public AnvilCallback<GameObject> m_loadingState;

    public string Guid     {
      get
      {
        return null;
      }
    }

    public GameObject GetGameObject() {
      return null;
    }

    public void RefreshCache()
    {
    }

    public AnvilCallback<GameObject> GetGameObjectAsync(){
      return null;
    }

    public void UpgradeFrom(GameObject go)
    {
    }
  }

  [Serializable]
  public struct AssetID : IEquatable<AssetID>
  {
    public string Guid;
    public string Bundle;
    public string AssetName;

    public bool Equals(AssetID other)    {
      return false;
    }

    public override bool Equals(object obj)     {
      return false;
    }

    public override int GetHashCode()
    {
      return 0;
    }
  }

  public class AnvilCallback<TCall> : AnvilCallbackBase where TCall : UnityEngine.Object
  {
    [NonSerialized]
    public AnvilCallback<AssetBundle> m_dependancy;
    [NonSerialized]
    public List<Action<TCall>> m_completed;
    [NonSerialized]
    public TCall m_result;

    public AnvilCallback(AsyncOperation request, AnvilCallback<AssetBundle> bundle)
    {
    }

    public AsyncOperation Request
    {
      get
      {
        return null;
      }
      set
      {
      }
    }

    public override float Progress    {
      get { return 0f; }
    }

    public TCall Result    {
      get { return null; }
    }

    public override bool keepWaiting
    {
      get { return false; }
    }

    public override bool Pump()
    {
      return false;
    }

    public void AddCallback(Action<TCall> completed)
    {
    }

    public override void CompleteNow()
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public abstract class AnvilCallbackBase : CustomYieldInstruction
  {
    public bool IsCompleted
    {
      get
      {
        return false;
      }
      set
      {
      }
    }

    public abstract float Progress { get; }

    public abstract bool Pump();

    public abstract void CompleteNow();
  }

}