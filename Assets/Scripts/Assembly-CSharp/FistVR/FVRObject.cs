using System.Collections.Generic;
using UnityEngine;

namespace FistVR
{
    [CreateAssetMenu(fileName = "New Definition", menuName = "FVRObjectID/FVRObjectID", order = 0)]

    public class FVRObject : AnvilAsset
    {

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
            MeleeWeapon = 10,
            Explosive = 20,
            Powerup = 25,
            Target = 30,
            Tool = 40,
            Toy = 41,
            Firework = 42,
            Ornament = 43,
            Loot = 50,
            VFX = 51,
            Armor = 1984,
            Helmet = 1985,
            Belt = 1986,
        }

        public enum OTagEra
        {
            None = 0,
            Colonial = 1,
            WildWest = 2,
            TurnOfTheCentury = 3,
            WW1 = 4,
            WW2 = 5,
            PostWar = 6,
            Modern = 7,
            Futuristic = 8,
            Medieval = 9,
        }

        public enum OTagSet
        {
            Real = 0,
            GroundedFictional = 1,
            SciFiFictional = 2,
            Meme = 3,
            MF = 4,
            Holiday = 5,
            TNH = 6,
            NonCombat = 7,
        }

        public enum OTagFirearmSize
        {
            None = 0,
            Pocket = 1,
            Pistol = 2,
            Compact = 3,
            Carbine = 4,
            FullSize = 5,
            Bulky = 6,
            Oversize = 7,
        }

        public enum OTagFirearmAction
        {
            None = 0,
            BreakAction = 1,
            BoltAction = 2,
            Revolver = 3,
            PumpAction = 4,
            LeverAction = 5,
            Automatic = 6,
            RollingBlock = 7,
            OpenBreach = 8,
            Preloaded = 9,
            SingleActionRevolver = 10,
        }

        public enum OTagFirearmRoundPower
        {
            None = 0,
            Tiny = 1,
            Pistol = 2,
            Shotgun = 3,
            Intermediate = 4,
            FullPower = 5,
            AntiMaterial = 6,
            Ordnance = 7,
            Exotic = 8,
            Fire = 9,
        }

        public enum OTagFirearmCountryOfOrigin
        {
            None = 0,
            Fictional = 1,
            UnitedStatesOfAmerica = 10,
            MuricanRemnants = 11,
            BritishEmpire = 20,
            UnitedKingdom = 21,
            KingdomOfFrance = 30,
            FrenchSecondRepublic = 31,
            SecondFrenchEmpire = 32,
            FrenchThirdRepublic = 33,
            VichyFrance = 34,
            FrenchFourthRepublic = 35,
            FrenchRepublic = 36,
            GermanEmpire = 40,
            WeimarRepublic = 41,
            GermanReich = 42,
            WestGermany = 43,
            GermanDemocraticRepublic = 44,
            FederalRepublicOfGermany = 45,
            TsardomOfRussia = 50,
            RussianEmpire = 51,
            UnionOfSovietSocialistRepublics = 52,
            RussianFederation = 53,
            KingdomOfBelgium = 60,
            KingdomOfItaly = 70,
            ItalianRepublic = 71,
            SwedishEmpire = 90,
            UnitedKingdomsOfSwedenAndNorway = 91,
            KingdomOfSweden = 92,
            KingdomOfNorway = 100,
            KingdomOfFinland = 110,
            RepublicOfFinland = 111,
            Czechoslovakia = 120,
            CzechRepublic = 121,
            Ukraine = 130,
            SwissConfederation = 140,
            FirstSpanishRepublic = 150,
            SecondSpanishRepublic = 151,
            SpanishState = 152,
            KingdomOfSpain = 153,
            AustrianEmpire = 160,
            AustroHungarianEmpire = 161,
            RepublicOfAustria = 162,
            FirstHungarianRepublic = 170,
            HungarianRepublic = 171,
            KingdomOfHungary = 172,
            HungarianPeoplesRepublic = 173,
            RepublicOfCroatia = 190,
            RepublicOfKorea = 200,
            DemocraticRepublicOfVietnam = 210,
            StateOfIsrael = 220,
            FederativeRepublicOfBrazil = 230,
            EmpireOfJapan = 240,
            RepublicOfSouthAfrica = 250,
            GovernmentOfTheRepublicOfPolandInExile = 262,
            RepublicOfPoland = 263,
            PeoplesRepublicOfChina = 270,
            FormerYugoslavicRepublicOfMacedonia = 280,
        }

        public enum OTagFirearmFiringMode
        {
            None = 0,
            SemiAuto = 1,
            Burst = 2,
            FullAuto = 3,
            SingleFire = 4,
        }

        public enum OTagFirearmFeedOption
        {
            None = 0,
            BreachLoad = 1,
            InternalMag = 2,
            BoxMag = 3,
            StripperClip = 4,
            EnblocClip = 5,
        }

        public enum OTagFirearmMount
        {
            None = 0,
            Picatinny = 1,
            Russian = 2,
            Muzzle = 3,
            Stock = 4,
            Bespoke = 5,
        }

        public enum OTagAttachmentFeature
        {
            None = 0,
            IronSight = 1,
            Magnification = 2,
            Reflex = 3,
            Suppression = 4,
            Stock = 5,
            Laser = 6,
            Illumination = 7,
            Grip = 8,
            Decoration = 9,
            RecoilMitigation = 10,
            BarrelExtension = 11,
            Adapter = 12,
            Bayonet = 13,
            ProjectileWeapon = 14,
            Bipod = 15,
        }

        public enum OTagMeleeStyle
        {
            None = 0,
            Tactical = 1,
            Tool = 2,
            Improvised = 3,
            Medieval = 4,
            Shield = 5,
            PowerTool = 6,
        }

        public enum OTagMeleeHandedness
        {
            None = 0,
            OneHanded = 1,
            TwoHanded = 2,
        }

        public enum OTagPowerupType
        {
            None = -1,
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
            Regen = 10,
            Cyclops = 11,
            WheredIGo = 12,
            ChillOut = 13,
        }

        public enum OTagThrownType
        {
            None = 0,
            ManualFuse = 1,
            Pinned = 2,
            Strange = 3,
        }

        public enum OTagThrownDamageType
        {
            None = 0,
            Kinetic = 1,
            Explosive = 2,
            Fire = 3,
            Utility = 4,
        }

        public string ItemID;
        public string DisplayName;
        public ObjectCategory Category;
        public string SpawnedFromId;
        public float Mass;
        public int MagazineCapacity;
        public bool RequiresPicatinnySight;
        public OTagEra TagEra;
        public OTagSet TagSet;
        public OTagFirearmSize TagFirearmSize;
        public OTagFirearmAction TagFirearmAction;
        public OTagFirearmRoundPower TagFirearmRoundPower;
        public OTagFirearmCountryOfOrigin TagFirearmCountryOfOrigin;
        public int TagFirearmFirstYear;
        public List<FVRObject.OTagFirearmFiringMode> TagFirearmFiringModes;
        public List<FVRObject.OTagFirearmFeedOption> TagFirearmFeedOption;
        public List<FVRObject.OTagFirearmMount> TagFirearmMounts;
        public OTagFirearmMount TagAttachmentMount;
        public OTagAttachmentFeature TagAttachmentFeature;
        public OTagMeleeStyle TagMeleeStyle;
        public OTagMeleeHandedness TagMeleeHandedness;
        public OTagPowerupType TagPowerupType;
        public OTagThrownType TagThrownType;
        public OTagThrownDamageType TagThrownDamageType;
        public FireArmMagazineType MagazineType;
        public List<FVRObject> CompatibleMagazines;
        public List<FVRObject> CompatibleClips;
        public List<FVRObject> CompatibleSpeedLoaders;
        public List<FVRObject> CompatibleSingleRounds;
        public List<FVRObject> BespokeAttachments;
        public List<FVRObject> RequiredSecondaryPieces;
        public int MinCapacityRelated;
        public int MaxCapacityRelated;
        public int CreditCost;
        public bool OSple;
    }

    public class FireArmMagazineType
    {
    }
}
