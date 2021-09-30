using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FistVR
{
    public class FVRLever : FVRInteractiveObject
    {
        public Transform LeverTransform;
        public Transform Base;
        [NonSerialized] public bool m_isForward;
        [NonSerialized] public float m_curRot;
        public float minValue;
        public float maxValue;
        [NonSerialized] public FVRLever.LeverState curState;
        [NonSerialized] public FVRLever.LeverState lastState;
        [NonSerialized] public AudioSource aud;

        public override void Awake()
        {
        }

        public override void UpdateInteraction(FVRViveHand hand)
        {
        }

        public float GetLeverValue()
        {
            return 0f;
        }

        public override void FVRUpdate()
        {
        }

        public enum LeverState
        {
            Off,
            Mid,
            On,
        }
    }
}