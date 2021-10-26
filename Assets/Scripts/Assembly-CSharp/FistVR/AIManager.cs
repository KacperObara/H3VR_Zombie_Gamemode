using UnityEngine;

namespace FistVR
{
    public class AIManager : MonoBehaviour
    {
        public LayerMask LM_Entity;
        public AnimationCurve LoudnessFalloff;
        public AnimationCurve SonicThresholdDecayCurve;
        public int NumEntitiesToCheckPerFrame;
        public float SpeakRang_Chat;
        public float SpeakRang_Pain;
        public float SpeakRang_Death;
        public AICoverPointManager CPM;
        public bool HasInit;
    }
}