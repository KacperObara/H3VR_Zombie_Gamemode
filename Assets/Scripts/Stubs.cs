using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Old Unity forces its DLLs to be called Assembly-CSharp
// WurstMod references Assembly-CSharp, H3VR's assembly
// Unity implicitly creates an Assembly-CSharp for every project
// Therefore, Unity thinks it should be able to load H3 classes from Assembly-CSharp...
// Stub out everything we use to silence errors.

namespace FistVR
{
    public class TNH_HoldPoint { }
    public class NavMeshLinkExtension { }
    public class TNH_Manager { }
    public class MainMenuScenePointable { }
    public class FVRViveHand { }
    public class TNH_PointSequence { }
    public class TNH_SafePositionMatrix { }
    public class TNH_SupplyPoint { }
    public class Sosig { }

    public class FVRSceneSettings
    {
        public delegate void SosigKill(Sosig s);

        public event FVRSceneSettings.SosigKill SosigKillEvent;
    }

    public class SosigLink { }

    public class GM
    {
        public static FVRPlayerBody CurrentPlayerBody { get; set; }
        public static FVRSceneSettings CurrentSceneSettings { get; set; }
    }
    public class FVRPlayerBody : MonoBehaviour
    {
        public void SetHealthThreshold(float t) {}
        public void ResetHealth() {}
        public void HealPercent(float p) {}
    }

    public class Damage{}
    public interface IFVRDamageable
    {
        void Damage(Damage dam);
    }
}

namespace On.FistVR
{
    //public static class Sosig {}
    // public delegate void orig_ProcessDamage_Damage_SosigLink(FistVR.Sosig self, FistVR.Damage d, FistVR.SosigLink link);
    // public delegate void hook_ProcessDamage_Damage_SosigLink(
    //     Sosig.orig_ProcessDamage_Damage_SosigLink orig,
    //     FistVR.Sosig self,
    //     FistVR.Damage d,
    //     FistVR.SosigLink link);
    // public static event Sosig.hook_ProcessDamage_Damage_SosigLink ProcessDamage_Damage_SosigLink;
}
