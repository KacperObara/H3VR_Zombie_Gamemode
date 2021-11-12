using UnityEngine;

using System.Collections.Generic;
using UnityEngine.AI;

namespace FistVR
{
	public class SosigWeapon : MonoBehaviour
	{
		public enum SosigWeaponType
		{
			Gun = 0,
			Melee = 1,
			Grenade = 2,
			Ammo = 3,
			Healing = 4,
			Shield = 5,
		}

		public enum SosiggunAmmoType
		{
			None = 0,
			PistolLight = 1,
			PistolStrong = 2,
			PistolExotic = 3,
			RifleLight = 4,
			RifleStrong = 5,
			RifleSniper = 6,
			Machinegun = 7,
			Shotgun = 8,
			Grenade = 9,
			Rocket = 10,
			Zosig = 11,
		}

		public enum SosigWeaponMechaState
		{
			ReadyToFire = 0,
			CyclingBack = 1,
			CyclingForward = 2,
		}

		public enum Axis
		{
			X = 0,
			Y = 1,
			Z = 2,
		}

		public enum InterpStyle
		{
			Translate = 0,
			Rotation = 1,
		}

		public enum SosigMeleeWeaponType
		{
			Bladed = 0,
			Blunt = 1,
			Stabbing = 2,
			Shield = 3,
		}

		public enum SosigMeleeState
		{
			Ready = 0,
			Attacking = 1,
			Recovery = 2,
		}

		public enum SosigWeaponUsageState
		{
			Firing = 0,
			Reloading = 1,
		}

		public enum SosigWeaponLayerState
		{
			Agent = 0,
			Player = 1,
		}

		public int Quality;
		public SosigWeaponType Type;
		public bool IsShakeReloadable;
		public bool UsesFakeType;
		public SosigWeaponType FakeType;
		public bool IsAlsoThrowable;
		public bool PrimesOnFirstSwing;
		public bool IsDroppedOnStrongHit;
		public SosiggunAmmoType AmmoType;
		public float ShotLoudness;
		public Sosig SosigHoldingThis;
		public SosigHand HandHoldingThis;
		public Sosig SosigWithInventory;
		public SosigInventory.Slot InventorySlotWithThis;
		public FVRPhysicalObject O;
		public AIEntity E;
		public int SourceIFF;
		public bool IsHeldByBot;
		public bool IsInBotInventory;
		public Transform RecoilHolder;
		public AudioImpactController ImpactController;
		public float Hipfire_HorizontalLimit;
		public float Hipfire_VerticalLimit;
		public float Aim_HorizontalLimit;
		public float Aim_VerticalLimit;
		public float MaxAngularFireRange;
		public AnimationCurve AngularFiringLimitByRange;
		public Vector2 RangeMinMax;
		public Vector2 PreferredRange;
		public SosigWeaponMechaState MechaState;
		public bool UsesSustainedSound;
		public AudioEvent AudEvent_SustainedEmit;
		public AudioEvent AudEvent_SustainedTerminate;
		public AudioSource AudSource_SustainedLoop;
		public float SustainEnergyPerShot;
		public Transform Muzzle;
		public Transform CyclingPart;
		public bool HasCyclingPart;
		public Axis CycleAxis;
		public InterpStyle CycleInterpStyle;
		public Vector2 CycleForwardBackValues;
		public float CycleSpeedForward;
		public float CycleSpeedBackward;
		public int ShotsPerCycle;
		public bool HasMuzzleOffsetSet;
		public List<Vector3> MuzzleOffsetSets;
		public int ShotsPerLoad;
		public Vector2 AmmoClampRange;
		public float FlightVelocityMultiplier;
		public GameObject Projectile;
		public int ProjectilesPerShot;
		public float ProjectileSpread;
		public bool isFullAuto;
		public Vector4 RecoilPerShot;
		public Vector3 RecoilRecoveryMults;
		public SosigMeleeWeaponType MeleeType;
		public List<SosigWeapon.SosigMeleeWeaponType> MeleeTypeCycleList;
		public bool DoesMeleeTypeCycle;
		public bool DoesHeightAdjust;
		public SosigMeleeState MeleeState;
		public Vector3 MeleeStateSpeeds;
		public Vector2 CloseAttackRange;
		public Vector2 DistantAttackRange;
		public List<SosigMeleeAnimationSet> AvailableIdleAnims;
		public List<SosigMeleeAnimationSet> AvailableReadyAnims;
		public List<SosigMeleeAnimationSet> AvailableAttackAnims;
		public bool DoesCastForPlayerHitBox;
		public LayerMask LM_Thrown;
		public Transform ThrownCastPos1;
		public Transform ThrownCastPos2;
		public List<GameObject> SpawnOnExplode;
		public float GrenadeFuseTime;
		public SosigGrenadePin Pin;
		public NavMeshObstacle Obstacle;
		public bool UsesFusePulse;
		public AudioEvent AudEvent_FusePulse;
		public ParticleSystem FusePSystem;
		public SosigWeaponUsageState UsageState;
		public float ReloadTime;
		public Vector2 Usage_RefireRange;
		public bool UsesBurstLimit;
		public int BurstLimit;
		public int BurstLimitRange;
		public Vector2 BurstDelayRange;
		public LayerMask LM_IFFCheck;
		public LayerMask LM_EnvCheck;
		public bool UsesMuzzleFire;
		public bool DoesFlashOnFire;
		public Color FlashOnFireColor;
		public ParticleSystem[] PSystemsMuzzle;
		public int MuzzlePAmount;
		public GameObject Laser;
		public wwBotWurstGunSoundConfig GunShotProfile;
		public float MinHandlingDistance;
		public bool UsesCyclingSounds;
		public bool UsesReloadingSounds;
		public bool IsDestructible;
		public List<GameObject> ShardPrefabs;
		public List<Transform> ShardPositions;
		public Vector2 CollisionLife;
		public AudioEvent AudEvent_Shatter;
		public bool TakesDamage;
		public float Life;
		public bool UsesDestructionStageRenderers;
		public Renderer[] DestructionRenderers;
		public Vector3 ResistMultBCP;
		public SosigWeaponLayerState LayerState;
	}

	public class SosigInventory
	{
		public class Slot
		{
		}
	}

	public class wwBotWurstGunSoundConfig
	{
	}

	public class SosigGrenadePin
	{
	}

	public class SosigHand
	{
	}
}
