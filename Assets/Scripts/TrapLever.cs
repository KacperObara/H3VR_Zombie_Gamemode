using System;
using System.Collections;
using System.Collections.Generic;
using FistVR;
using UnityEngine;

namespace FistVR
{
    public class TrapLever : FVRInteractiveObject
    {
        public float MaxRot;
        public Transform RefVector;
        public float ValvePos;
        public List<GameObject> MessageTargets;
        public AudioEvent AudEvent_Release;
        public Transform Lever;

        public override void Awake()
        {
        }

        public override void UpdateInteraction(FVRViveHand hand)
        {
        }

        public override void EndInteraction(FVRViveHand hand)
        {
        }
    }

    [Serializable]
    public class AudioEvent
    {
        public List<AudioClip> Clips;
        public Vector2 VolumeRange;
        public Vector2 PitchRange;
        public Vector2 ClipLengthRange;

        public void SetLengthRange()
        {
        }
    }
}
