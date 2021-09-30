using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FistVR
{
 public class FVRInteractiveObject : MonoBehaviour
  {
    [NonSerialized]
    public GameObject GameObject;
    [NonSerialized]
    public Transform Transform;
    [NonSerialized] public int m_index;
    public static List<FVRInteractiveObject> All;
    [Header("Interactive Object Config")]
    public FVRInteractionControlType ControlType;
    public bool IsSimpleInteract;
    public HandlingGrabType HandlingGrabSound;
    public HandlingReleaseType HandlingReleaseSound;
    public Transform PoseOverride;
    public Transform QBPoseOverride;
    public Transform PoseOverride_Touch;
    public bool UseGrabPointChild;
    public bool UseGripRotInterp;
    public float PositionInterpSpeed;
    public float RotationInterpSpeed;
    [NonSerialized]
    public Transform m_grabPointTransform;
    [NonSerialized]
    public float m_pos_interp_tick;
    [NonSerialized]
    public float m_rot_interp_tick;
    public bool EndInteractionIfDistant;
    public float EndInteractionDistance;
    [HideInInspector]
    public bool m_hasTriggeredUpSinceBegin;
    [NonSerialized]
    public float triggerCooldown;
    public FVRViveHand m_hand;
    public GameObject UXGeo_Hover;
    public GameObject UXGeo_Held;
    public bool UseFilteredHandTransform;
    public bool UseFilteredHandPosition;
    public bool UseFilteredHandRotation;
    public bool UseSecondStepRotationFiltering;
    [NonSerialized]
    public Quaternion SecondStepFilteredRotation;
    [NonSerialized]
    public bool m_isHovered;
    [NonSerialized]
    public bool m_isHeld;
    [NonSerialized]
    public Collider[] m_colliders;

    public Transform GrabPointTransform
    {
      get { return null; }
      set
      {
      }
    }

    [HideInInspector] public Vector3 m_handPos
    {
      get { return Vector3.zero; }
    }

    [HideInInspector]
    public Quaternion m_handRot
    {
      get { return Quaternion.identity; }
    }

    [HideInInspector]
    public Vector3 m_palmPos
    {
      get { return Vector3.zero; }
    }

    [HideInInspector]
    public Quaternion m_palmRot
    {
      get { return Quaternion.identity; }
    }

    public bool IsHovered
    {

      get { return false; }

      set
      {
      }
    }

    public bool IsHeld
    {
      get { return false; }
      set
      {
      }
    }

    public virtual bool IsSelectionRestricted()
    {
      return false;
    }

    public virtual bool IsInteractable()    {
      return false;
    }

    public virtual bool IsDistantGrabbable()    {
      return false;
    }

    public virtual void OnHoverStart()
    {
    }

    public virtual void OnHoverEnd()
    {
    }

    public virtual void OnHoverStay()
    {
    }

    public virtual void SetUXHoverGeoViz(bool b)
    {
    }

    public virtual void SetUXHeldGeoViz(bool b)
    {
    }

    public void UpdateGrabPointTransform()
    {
    }

    public virtual void PlayGrabSound(bool isHard, FVRViveHand hand)
    {
    }

    public virtual void PlayReleaseSound(FVRViveHand hand)
    {
    }

    public virtual void BeginInteraction(FVRViveHand hand)
    {
    }

    public virtual void UpdateInteraction(FVRViveHand hand)
    {
    }

    public virtual void EndInteraction(FVRViveHand hand)
    {
    }

    public virtual void SimpleInteraction(FVRViveHand hand)
    {
    }

    public virtual void Poke(FVRViveHand hand)
    {
    }

    public virtual void ForceBreakInteraction()
    {
    }

    public virtual void Awake()
    {
    }

    public virtual void Start()
    {
    }

    public static void GlobalUpdate()
    {
    }

    public virtual void FVRUpdate()
    {
    }

    public static void GlobalFixedUpdate()
    {
    }

    public virtual void FVRFixedUpdate()
    {
    }

    public virtual void OnDestroy()
    {
    }

    public virtual void TestHandDistance()
    {
    }

    public void SetCollidersToLayer(List<Collider> cols, bool triggersToo, string layerName)
    {
      // ISSUE: unable to decompile the method.
    }

    public void SetAllCollidersToLayer(bool triggersToo, string layerName)
    {
    }

    public Vector3 GetClosestValidPoint(Vector3 vA, Vector3 vB, Vector3 vPoint)
    {
      return Vector3.zero;
    }

    public enum HandFilterMode
    {
      Unfiltered,
      FilterMode_A,
      FilterMode_B,
    }
  }


 public enum HandlingGrabType
 {
   None = 0,
   Generic = 1,
   Cloth = 2,
   HardSmoothLight = 3,
   HardSmoothStandard = 4,
   HardSmoothDeep = 5,
   Pistol = 10, // 0x0000000A
   RiflePlastic = 11, // 0x0000000B
   RifleWood = 12, // 0x0000000C
   MagazinePistol = 20, // 0x00000014
   MagazineRifleMetal = 21, // 0x00000015
   MagazineRiflePlastic = 22, // 0x00000016
   MagazineFullPower = 23, // 0x00000017
   MagazineDrum = 24, // 0x00000018
   FlagGrenade = 30, // 0x0000001E
   Flashbang = 31, // 0x0000001F
   SmokeGrenade = 32, // 0x00000020
   BeltSegment = 39, // 0x00000027
   CasePistolLarge = 40, // 0x00000028
   CasePistolSmall = 41, // 0x00000029
   CaseRifleLarge = 42, // 0x0000002A
   CaseRifleSmall = 43, // 0x0000002B
   CaseShotgun = 44, // 0x0000002C
   CaseGrenade = 45, // 0x0000002D
 }

 public enum HandlingReleaseType
 {
   None = 0,
   Rattle = 1,
   Cloth = 2,
   HardSmooth = 3,
   TinyMetal = 4,
   Magazine = 10, // 0x0000000A
   MagazineDrum = 11, // 0x0000000B
 }

 public enum FVRInteractionControlType
 {
   GrabHold,
   GrabToggle,
 }
}