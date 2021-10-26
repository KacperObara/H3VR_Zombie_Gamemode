using UnityEngine;
using System.Collections.Generic;

namespace FistVR
{    [CreateAssetMenu(fileName = "NewSpeechSet", menuName = "Sosig/SosigSpeechSet", order = 0)]
    public class SosigSpeechSet : ScriptableObject
	{
		public float BasePitch;
		public float BaseVolume;
		public bool ForceDeathSpeech;
		public bool UseAltDeathOnHeadExplode;
		public bool LessTalkativeSkirmish;
		public List<AudioClip> OnJointBreak;
		public List<AudioClip> OnJointSlice;
		public List<AudioClip> OnJointSever;
		public List<AudioClip> OnDeath;
		public List<AudioClip> OnBackBreak;
		public List<AudioClip> OnNeckBreak;
		public List<AudioClip> OnPain;
		public List<AudioClip> OnConfusion;
		public List<AudioClip> OnDeathAlt;
		public List<AudioClip> OnWander;
		public List<AudioClip> OnSkirmish;
		public List<AudioClip> OnInvestigate;
		public List<AudioClip> OnSearchingForGuns;
		public List<AudioClip> OnTakingCover;
		public List<AudioClip> OnBeingAimedAt;
		public List<AudioClip> OnAssault;
		public List<AudioClip> OnReloading;
		public List<AudioClip> OnMedic;
		public List<AudioClip> OnCall_Skirmish;
		public List<AudioClip> OnRespond_Skirmish;
		public List<AudioClip> OnCall_Assistance;
		public List<AudioClip> OnRespond_Assistance;
		public List<AudioClip> Test;
	}
}
