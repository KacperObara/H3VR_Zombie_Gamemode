using UnityEngine;
using System.Collections.Generic;

namespace FistVR
{
	public class AIEntity : MonoBehaviour
	{
		public int IFFCode;
		public bool ReceivesEvent_Damage;
		public float ManagerCheckFrequency;
		public Transform FacingTransform;
		public Transform GroundTransform;
		public List<AIEntityIFFBeacon> Beacons;
		public bool UsesFakedPosition;
		public Vector3 FakePos;
		public bool ReceivesEvent_Visual;
		public float MaximumSightRange;
		public float MaximumSightFOV;
		public AnimationCurve SightDistanceByFOVMultiplier;
		public bool IsVisualCheckOmni;
		public Transform SensoryFrame;
		public LayerMask LM_VisualOcclusionCheck;
		public bool ReceivesEvent_Sonic;
		public float SonicThreshold;
		public float MaxHearingDistance;
		public float DangerMultiplier;
		public float VisibilityMultiplier;
		public float MaxDistanceVisibleFrom;
	}

	public class AIEntityIFFBeacon
	{
	}
}
