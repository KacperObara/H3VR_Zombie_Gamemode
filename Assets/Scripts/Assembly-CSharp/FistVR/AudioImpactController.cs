using UnityEngine;
using System;
using System.Collections.Generic;

namespace FistVR
{
	public class AudioImpactController : MonoBehaviour
	{
		[Serializable]
		public class AltImpactType
		{
			public ImpactType Type;
			public List<Collider> Cols;
		}

		public ImpactType ImpactType;
		public bool SoundOnRB;
		public bool SoundOnNonRb;
		public float DelayLengthMult;
		public float DistLimit;
		public FVRPooledAudioType PoolToUse;
		public float HitThreshold_High;
		public float HitThreshold_Medium;
		public float HitThreshold_Ignore;
		public List<Rigidbody> IgnoreRBs;
		public bool CausesSonicEventOnSoundPlay;
		public float BaseLoudness;
		public float LoudnessVelocityMult;
		public float MaxLoudness;
		public bool UsesAltTypes;
		public List<AudioImpactController.AltImpactType> Alts;
	}
}
