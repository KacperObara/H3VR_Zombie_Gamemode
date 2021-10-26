using UnityEngine;
using System.Collections.Generic;

namespace FistVR
{   [CreateAssetMenu(fileName = "NewSosigConfigTemplate", menuName = "Sosig/SosigConfigTemplate", order = 0)]
	public class SosigConfigTemplate : ScriptableObject
	{
		public float ViewDistance;
		public float HearingDistance;
		public float MaxFOV;
		public bool DoesAggroOnFriendlyFire;
		public bool HasABrain;
		public float SearchExtentsModifier;
		public bool DoesDropWeaponsOnBallistic;
		public bool CanPickup_Ranged;
		public bool CanPickup_Melee;
		public bool CanPickup_Other;
		public int TargetCapacity;
		public float TargetTrackingTime;
		public float NoFreshTargetTime;
		public float AssaultPointOverridesSkirmishPointWhenFurtherThan;
		public float RunSpeed;
		public float WalkSpeed;
		public float SneakSpeed;
		public float CrawlSpeed;
		public float TurnSpeed;
		public float MaxJointLimit;
		public float MovementRotMagnitude;
		public bool AppliesDamageResistToIntegrityLoss;
		public float TotalMustard;
		public float BleedDamageMult;
		public float BleedRateMultiplier;
		public float BleedVFXIntensity;
		public float DamMult_Projectile;
		public float DamMult_Explosive;
		public float DamMult_Melee;
		public float DamMult_Piercing;
		public float DamMult_Blunt;
		public float DamMult_Cutting;
		public float DamMult_Thermal;
		public float DamMult_Chilling;
		public float DamMult_EMP;
		public List<float> LinkDamageMultipliers;
		public List<float> LinkStaggerMultipliers;
		public List<Vector2> StartingLinkIntegrity;
		public List<float> StartingChanceBrokenJoint;
		public float ShudderThreshold;
		public float ConfusionThreshold;
		public float ConfusionMultiplier;
		public float ConfusionTimeMax;
		public float StunThreshold;
		public float StunMultiplier;
		public float StunTimeMax;
		public bool CanBeGrabbed;
		public bool CanBeSevered;
		public bool CanBeStabbed;
		public bool CanBeSurpressed;
		public float SuppressionMult;
		public bool DoesJointBreakKill_Head;
		public bool DoesJointBreakKill_Upper;
		public bool DoesJointBreakKill_Lower;
		public bool DoesSeverKill_Head;
		public bool DoesSeverKill_Upper;
		public bool DoesSeverKill_Lower;
		public bool DoesExplodeKill_Head;
		public bool DoesExplodeKill_Upper;
		public bool DoesExplodeKill_Lower;
		public bool UsesLinkSpawns;
		public List<FVRObject> LinkSpawns;
		public List<float> LinkSpawnChance;
		public bool OverrideSpeech;
		public SosigSpeechSet OverrideSpeechSet;

	}
}
