using System;
using System.Collections.Generic;
using UnityEngine;

//TODO except for FVRPhysicalObject and enums I don't need bodies of most classes here
namespace FistVR
{
  public class FVRPhysicalObject : FVRInteractiveObject
  {
    [Header("Physical Object Config")]
    public FVRObject ObjectWrapper;
    public bool SpawnLockable;
    public bool Harnessable;
    public HandlingReleaseIntoSlotType HandlingReleaseIntoSlotSound;
    [HideInInspector]
    public bool m_isSpawnLock;
    [HideInInspector]
    public bool m_isHardnessed;
    public FVRPhysicalObject.FVRPhysicalObjectSize Size;
    public FVRQuickBeltSlot.QuickbeltSlotType QBSlotType;
    public bool DoesReleaseOverrideVelocity;
    public bool DoesReleaseAddVelocity;
    public float ThrowVelMultiplier;
    public float ThrowAngMultiplier;
    public float MoveIntensity;
    public float RotIntensity;
    [NonSerialized]
    public float AttachedRotationMultiplier;
    [NonSerialized]
    public float AttachedPositionMultiplier;
    [NonSerialized]
    public float AttachedRotationFudge;
    [NonSerialized]
    public float AttachedPositionFudge;
    public bool UsesGravity;
    public Rigidbody[] DependantRBs;
    [NonSerialized]
    public FVRPhysicalObject.RigidbodyStoredParams StoredRBParams;
    public bool DistantGrabbable;
    public bool IsDebug;
    public bool IsAltHeld;
    public bool IsKinematicLocked;
    public bool DoesQuickbeltSlotFollowHead;
    public bool IsInWater;
    [NonSerialized]
    public Vector3 m_storedCOMLocal;
    public List<FVRFireArmAttachmentMount> AttachmentMounts;
    [NonSerialized]
    public List<FVRFireArmAttachment> AttachmentsList;
    [NonSerialized]
    public HashSet<FVRFireArmAttachment> AttachmentsHash;
    [NonSerialized]
    public FVRQuickBeltSlot m_quickbeltSlot;
    [NonSerialized]
    public float m_timeSinceInQuickbelt;
    [NonSerialized]
    public FVRAlternateGrip m_altGrip;
    [NonSerialized]
    public FVRAlternateGrip savedGrip;
    public bool IsAltToAltTransfer;
    [NonSerialized]
    public FVRFireArmBipod m_bipod;
    [NonSerialized]
    public bool m_isPivotLocked;
    [NonSerialized]
    public Vector3 m_pivotLockedPos;
    [NonSerialized]
    public Quaternion m_pivotLockedRot;
    public FVRPhysicalObject.FVRPhysicalSoundParams CollisionSound;
    [NonSerialized]
    public ItemSpawnerID m_IDSpawnedFrom;
    public bool IsPickUpLocked;
    [NonSerialized]
    public bool m_doesDirectParent;
    public FVRPhysicalObject.ObjectToHandOverrideMode OverridesObjectToHand;
    [NonSerialized]
    public AudioImpactController audioImpactController;
    [NonSerialized]
    public bool m_hasImpactController;
    [Header("Melee Stuff")]
    public FVRPhysicalObject.MeleeParams MP;
    [NonSerialized]
    public float CheckDestroyTick;
    [NonSerialized]
    public Vector3 fakeHandPosWorld;
    [NonSerialized]
    public Vector3 fakeHandVelWorld;
    [NonSerialized]
    public float m_timeSinceFakeVelWorldTransfered;

    [HideInInspector]
    public Rigidbody RootRigidbody
    {
      get
      {
        return null;
      }
      set
      {
      }
    }

    public List<FVRFireArmAttachment> Attachments {get
    {
      return null;
    }}

    public float TimeSinceInQuickbelt {get
    {
      return 0f;
    }}

    [HideInInspector]
    public FVRQuickBeltSlot QuickbeltSlot {get
    {
      return null;
    }}

    public virtual void SetQuickBeltSlot(FVRQuickBeltSlot slot)
    {
    }

    [HideInInspector]
    public FVRAlternateGrip AltGrip
    {
      get     {
        return null;
      }
      set
      {
      }
    }

    [HideInInspector]
    public FVRFireArmBipod Bipod
    {
      get     {
        return null;
      }
      set
      {
      }
    }

    public bool IsPivotLocked
    {
      get    {
        return false;
      }
      set
      {
      }
    }

    public Vector3 PivotLockPos
    {
      set
      {
      }
    }

    public Quaternion PivotLockRot
    {
      set
      {
      }
    }

    public ItemSpawnerID IDSpawnedFrom
    {
      get    {
        return null;
      }
      set
      {
      }
    }

    public bool DoesDirectParent
    {
      get { return false; }
    }

    public AudioImpactController AudioImpactController     {
      get { return null; }
    }

    public bool HasImpactController     {
      get { return false; }
    }

    public void SetIFF(int iff)
    {
    }

    public override void Awake()
    {
    }

    public void UpdatePosesBasedOnCMode(FVRViveHand hand)
    {
    }

    public virtual int GetTutorialState()
    {
      return 0;
    }

    public override bool IsInteractable()    {
      return false;
    }

    public override bool IsSelectionRestricted() {
      return false;
    }

    public override bool IsDistantGrabbable() {
      return false;
    }

    public void ToggleKinematicLocked()
    {
    }

    public void SetIsKinematicLocked(bool b)
    {
    }

    public virtual void BipodActivated()
    {
    }

    public virtual void BipodDeactivated()
    {
    }

    public void ResetClampCOM()
    {
    }

    public void RegisterAttachment(FVRFireArmAttachment attachment)
    {
    }

    public void DeRegisterAttachment(FVRFireArmAttachment attachment)
    {
    }

    public virtual Vector3 GetGrabPos() {
      return new Vector3();
    }

    public virtual Quaternion GetGrabRot() {
      return new Quaternion();
    }

    public virtual Vector3 GetPosTarget() {
      return new Vector3();
    }

    public virtual Quaternion GetRotTarget(){
      return new Quaternion();
    }

    public virtual bool HasStockPos(){
      return false;
    }

    public virtual Transform GetStockPos() {
      return null;
    }

    public virtual float GetRecoilZ() {
      return 0f;
    }

    public override void FVRUpdate()
    {
    }

    public virtual bool DoesFlipUpVector() {
      return false;
    }

    public override void FVRFixedUpdate()
    {
    }

    public void FU()
    {
    }

    public void SetFakeHand(Vector3 v, Vector3 p)
    {
    }

    public float GettimeSinceFakeVelWorldTransfered() {
      return 0f;
    }

    public Vector3 GetHandPosWorld() {
      return new Vector3();
    }

    public Vector3 GetHandVelWorld() {
      return new Vector3();
    }

    public virtual GameObject DuplicateFromSpawnLock(FVRViveHand hand) {
      return null;
    }

    public virtual void BeginInteractionThroughAltGrip(FVRViveHand hand, FVRAlternateGrip grip)
    {
    }

    public override void BeginInteraction(FVRViveHand hand)
    {
    }

    public override void UpdateInteraction(FVRViveHand hand)
    {
    }

    public override void EndInteraction(FVRViveHand hand)
    {
    }

    public virtual void ForceObjectIntoInventorySlot(FVRQuickBeltSlot slot)
    {
    }

    public virtual void EndInteractionIntoInventorySlot(FVRViveHand hand, FVRQuickBeltSlot slot)
    {
    }

    public override void ForceBreakInteraction()
    {
    }

    public virtual void ClearQuickbeltState()
    {
    }

    public virtual void ToggleQuickbeltState()
    {
    }

    public virtual void OnCollisionEnter(Collision col)
    {
    }

    public void StoreAndDestroyRigidbody()
    {
    }

    public void RecoverRigidbody()
    {
    }

    public void RecoverDrag()
    {
    }

    public void SetParentage(Transform t)
    {
    }

    public virtual void ConfigureFromFlagDic(Dictionary<string, string> f)
    {
    }

    public virtual Dictionary<string, string> GetFlagDic() {
      return null;
    }

    public override void TestHandDistance()
    {
    }

    [ContextMenu("TestCollidersNegative")]
    public void TestCollidersNegative()
    {
    }

    public void SetAnimatedComponent(
      Transform t,
      float val,
      FVRPhysicalObject.InterpStyle interp,
      FVRPhysicalObject.Axis axis)
    {
    }

    public struct RigidbodyStoredParams
    {
      public float Mass;
      public float Drag;
      public float AngularDrag;
      public RigidbodyInterpolation Interpolation;
      public CollisionDetectionMode ColDetectMode;
    }

    public enum FVRPhysicalObjectSize
    {
      Small = 0,
      Medium = 1,
      Large = 2,
      Massive = 3,
      CantCarryBig = 5,
    }

    [Serializable]
    public class FVRPhysicalSoundParams
    {
      public AudioClip[] Clips;
      public float ColSoundCooldown;
      public float ColSoundVolume;
      [HideInInspector]
      public bool m_hasCollisionSound;
      [HideInInspector]
      public AudioSource m_audioCollision;
      [HideInInspector]
      public float m_colSoundTick;
    }

    public enum ObjectToHandOverrideMode
    {
      None,
      Direct,
      Floating,
    }

    public enum InterpStyle
    {
      Translate,
      Rotation,
    }

    public enum Axis
    {
      X,
      Y,
      Z,
    }

    [Serializable]
    public class MeleeParams
    {
      [NonSerialized]
      public FVRPhysicalObject m_obj;
      public bool IsMeleeWeapon;
      public List<Rigidbody> IgnoreRBs;
      [Header("Transforms")]
      public Transform HandPoint;
      public Transform EndPoint;
      [Header("Damage Params")]
      public Vector3 BaseDamageBCP;
      public Vector3 HighDamageBCP;
      public Vector3 StabDamageBCP;
      public Vector3 TearDamageBCP;
      public List<Collider> HighDamageColliders;
      public List<Transform> HighDamageVectors;
      [Header("Pose Params")]
      public bool DoesCyclePosePoints;
      public Transform[] PosePoints;
      [NonSerialized]
      public int m_poseIndex;
      [Header("Thrown Params")]
      public bool IsThrownDisposable;
      [NonSerialized]
      public bool m_isCountingDownToDispose;
      public bool m_isThrownAutoAim;
      [NonSerialized]
      public float m_countDownToDestroy;
      public LayerMask ThrownDetectMask;
      public bool StartThrownDisposalTickdownOnSpawn;
      public bool IsLongThrowable;
      public bool IsThrowableDirInverted;
      [Header("Stabbing Params")]
      public bool CanNewStab;
      public bool ForceStab;
      public float BladeLength;
      public float MassWhileStabbed;
      public Transform StabDirection;
      public float StabAngularThreshold;
      public List<Collider> StabColliders;
      public float StabVelocityRequirement;
      public bool CanTearOut;
      public float TearOutVelThreshold;
      [NonSerialized]
      public bool m_isJointedToObject;
      [NonSerialized]
      public FixedJoint m_stabJoint;
      [NonSerialized]
      public Rigidbody m_stabTargetRB;
      [NonSerialized]
      public Vector3 m_initialStabPointWorld;
      [NonSerialized]
      public Vector3 m_initialStabPointLocal;
      [NonSerialized]
      public Vector3 m_relativeStabDir;
      [NonSerialized]
      public SosigLink m_stabbedLink;
      [NonSerialized]
      public Vector3 m_initialPosOfStabbedThingLocal;
      [Header("Lodging Params")]
      public bool CanNewLodge;
      public float LodgeDepth;
      public float MassWhileLodged;
      public Transform[] LodgeDirections;
      public List<Collider> LodgeColliders;
      public float LodgeVelocityRequirement;
      public float DeLodgeVelocityRequirement;
      [NonSerialized]
      public bool m_isLodgedToObject;
      [NonSerialized]
      public FixedJoint m_lodgeJoint;
      [NonSerialized]
      public Rigidbody m_lodgeTargetRB;
      [NonSerialized]
      public Vector3 m_initialLodgeNormal;
      [Header("Sweep Damage")]
      public bool UsesSweepTesting;
      public bool UsesSweepDebug;
      public List<Transform> TestCols;
      public Transform SweepTransformStart;
      public Transform SweepTransformEnd;
      public LayerMask LM_DamageTest;
      [NonSerialized]
      public bool m_isReadyToAim;
      [NonSerialized]
      public Vector3 m_lastHandPoint;
      [NonSerialized]
      public Vector3 m_lastEndPoint;
      [NonSerialized]
      public Vector3 handPointVelocity;
      [NonSerialized]
      public Vector3 endPointVelocity;
      [NonSerialized]
      public float m_pointDistance;
      [NonSerialized]
      public float m_lastangFlick;
      [NonSerialized]
      public float m_lastangFlickLinear;
      [NonSerialized]
      public Vector3 m_SweepPointStart;
      [NonSerialized]
      public Vector3 m_SweepPointEnd;
      [NonSerialized]
      public Vector3 m_lastSweepPointStart;
      [NonSerialized]
      public Vector3 m_lastSweepPointEnd;
      [NonSerialized]
      public RaycastHit m_dhit;
      [NonSerialized]
      public float m_timeSinceLastDamageDone;
      [NonSerialized]
      public float timeSinceStateChange;
      [NonSerialized]
      public Vector3 stabDistantPoint;
      [NonSerialized]
      public Vector3 stabInsidePoint;
      [NonSerialized]
      public float m_initialMass;
      [NonSerialized]
      public bool m_initRot;

      public int PoseIndex{
        get { return 0; }
      }

      public bool IsCountingDownToDispose
      {
        get
        {
          return false;
        }
        set
        {
        }
      }

      public bool IsJointedToObject
      {
        get { return false; }
      }

      public bool IsLodgedToObject       {
        get { return false; }
      }

      public void SetReadyToAim(bool b)
      {
      }

      public bool GetReadyToAim()
      {
        return false;
      }

      public void InitMeleeParams(FVRPhysicalObject o)
      {
      }

      public void SetPose(int i)
      {
      }

      public void UpdateTick(float t)
      {
      }

      public void MeleeUpdateInteraction(FVRViveHand hand)
      {
      }

      public void MeleeEndInteraction(FVRViveHand hand)
      {
      }

      public void FixedUpdate(float t)
      {
      }

      public void DeJoint()
      {
      }

      public bool GetInside(Collider col)      {
        return false;
      }

      public bool GetIsLodgeCollider(Collider col)      {
        return false;
      }

      public Vector3 GetIntertiaFromPoint(Vector3 point)      {
        return new Vector3();
      }

      public float GetMultiplierForStrikeDir(Vector3 dir, Transform[] dirsToUse)       {
        return 0f;
      }

      public float GetMultiplierForStrikeDir(Vector3 dir, List<Transform> dirsToUse){
        return 0f;
      }

      public float GetMultiplierForStrikeDir(Vector3 dir, Transform dirToUse) {
        return 0f;
      }

      public void DoTearOutDamage(float mag, Vector3 point, Vector3 dir)
      {
      }

      public virtual bool CanStateChange(){
        return false;
      }

      public bool GetIsStabCollider(Collider col) {
        return false;
      }

      public void DoStabDamage(float mag, Collision col)
      {
      }

      public void JointMeObjectForStab(Rigidbody targetRB)
      {
      }

      public void JointToObjectForLodge(Rigidbody targetRB, Vector3 anchorPoint)
      {
      }

      public void OnCollisionEnter(Collision col)
      {
      }
    }
  }

  public class ItemSpawnerID
  {
  }

  public enum HandlingReleaseIntoSlotType
  {
    None,
    Generic,
    Pistol,
    SMG,
  }

    public class FVRAlternateGrip : FVRInteractiveObject
  {
    [Header("Alternate Grip Config")]
    public FVRPhysicalObject PrimaryObject;
    public bool FunctionalityEnabled;
    [NonSerialized]
    public Vector3 m_origPoseOverridePos;
    [NonSerialized]
    public bool m_wasGrabbedFromAttachableForegrip;
    [NonSerialized]
    public AttachableForegrip m_lastGrabbedInGrip;
    [NonSerialized]
    public bool m_hasSavedPalmPoint;
    [NonSerialized]
    public Vector3 m_savedRigPalmPos;
    public bool DoesBracing;
    [NonSerialized]
    public bool tempFlag;

    public AttachableForegrip LastGrabbedInGrip
    {
      get { return null; }
    }

    public override void Awake()
    {
    }

    public void SetSavedRigLocalPos()
    {
    }

    public void ClearSavedPalmPoint()
    {
    }

    public void AttemptToGenerateSavedPalmPoint()
    {
    }

    public Vector3 GetPalmPos(bool isDirectParent)      {
      return new Vector3();
    }

    public bool HasLastGrabbedGrip()      {
      return false;
    }

    public AttachableForegrip GetLastGrabbedGrip()      {
      return null;
    }

    public override bool IsInteractable()      {
      return false;
    }

    public override void PlayGrabSound(bool isHard, FVRViveHand hand)
    {
    }

    public void BeginInteractionFromAttachedGrip(AttachableForegrip aGrip, FVRViveHand hand)
    {
    }

    public override void BeginInteraction(FVRViveHand hand)
    {
    }

    public override void UpdateInteraction(FVRViveHand hand)
    {
    }

    public virtual void PassHandInput(FVRViveHand hand, FVRInteractiveObject o)
    {
    }

    public override void EndInteraction(FVRViveHand hand)
    {
    }

    public override void TestHandDistance()
    {
    }
  }

    public class AttachableForegrip : FVRFireArmAttachmentInterface
    {
      public Transform ForePosePoint;
      //public FVRFireArm OverrideFirearm;
      public bool DoesBracing;

      public override void BeginInteraction(FVRViveHand hand)
      {
      }

      public virtual void PassHandInput(FVRViveHand hand, FVRInteractiveObject o)
      {
      }
    }

    public class FVRFireArmAttachmentInterface : FVRInteractiveObject
    {
      //public FVRFireArmAttachment Attachment;
      public bool IsLocked;
      public bool ForceInteractable;
      //public FVRFireArmAttachmentMount[] SubMounts;
      [NonSerialized]
      public Collider m_col;
      [NonSerialized]
      public bool m_hasCollider;

      public override void Awake()
      {
      }

      public void SetTriggerState(bool b)
      {
      }

      public override bool IsInteractable()      {
        return false;
      }

      public override bool IsDistantGrabbable()      {
        return false;
      }

      public virtual void OnAttach()
      {
      }

      public virtual void OnDetach()
      {
      }

      public override void UpdateInteraction(FVRViveHand hand)
      {
      }

      public void DetachRoutine(FVRViveHand hand)
      {
      }

      public bool HasAttachmentsOnIt()
      {
        return false;
      }
    }


    public enum ImpactType
  {
    MagSmallMetal = 0,
    MagLargeMetal = 1,
    MagDrum = 2,
    MagSmallPlastic = 3,
    MagLargePlastic = 4,
    MagGarandEnblocEmpty = 5,
    GunSmall = 10, // 0x0000000A
    GunTiny = 11, // 0x0000000B
    GunLargeMetal = 12, // 0x0000000C
    GunLargePlastic = 13, // 0x0000000D
    GunLargeWood = 14, // 0x0000000E
    MeatChunk = 20, // 0x00000014
    MeatChunkLight = 21, // 0x00000015
    MeatChunkLighter = 22, // 0x00000016
    Generic = 30, // 0x0000001E
    WoodGenericMedium = 40, // 0x00000028
    WoodGenericSmall = 41, // 0x00000029
    WoodGenericLarge = 42, // 0x0000002A
    WoodGenericHuge = 43, // 0x0000002B
    PlasticGenericMedium = 50, // 0x00000032
    PlasticGenericSmall = 51, // 0x00000033
    PlasticGenericLarge = 52, // 0x00000034
    MetalObjectMedium = 60, // 0x0000003C
    MetalObjectSmall = 61, // 0x0000003D
    MetalObjectLarge = 62, // 0x0000003E
    MetalObjectHuge = 63, // 0x0000003F
    MetalObjectTiny = 64, // 0x00000040
    CeramicPlateMedium = 70, // 0x00000046
    CeramicPlateSmall = 71, // 0x00000047
    CeramicPlateLarge = 72, // 0x00000048
    CeramicPlateHuge = 73, // 0x00000049
    PillowMedium = 80, // 0x00000050
    PillowSmall = 81, // 0x00000051
    PillowLarge = 82, // 0x00000052
    PillowHuge = 83, // 0x00000053
    CasePistolSmall = 90, // 0x0000005A
    CasePistolLarge = 91, // 0x0000005B
    CaseRifleSmall = 92, // 0x0000005C
    CaseRifleLarge = 93, // 0x0000005D
    CaseAntiMateriel = 94, // 0x0000005E
    CaseShotgun = 95, // 0x0000005F
    CaseLauncher = 96, // 0x00000060
    CaseRifleTiny = 97, // 0x00000061
    CasePistolTiny = 98, // 0x00000062
    CasePistolMeme = 99, // 0x00000063
    BulletSmall = 110, // 0x0000006E
    BulletLarge = 111, // 0x0000006F
    BulletShotgun = 112, // 0x00000070
    BulletVeryLarge = 113, // 0x00000071
    BulletHuge = 114, // 0x00000072
    BulletTiny = 115, // 0x00000073
    GrenadeSphere = 120, // 0x00000078
    GrenadeCan = 121, // 0x00000079
    GrenadeFlashbang = 122, // 0x0000007A
    Knife = 130, // 0x00000082
    Sword = 131, // 0x00000083
    Axe = 132, // 0x00000084
    Bat = 133, // 0x00000085
    Mace = 134, // 0x00000086
    Haft = 135, // 0x00000087
    GunshotImpact = 199, // 0x000000C7
    TF2_Axe = 200, // 0x000000C8
    TF2_Bat = 201, // 0x000000C9
    TF2_Bonesaw = 202, // 0x000000CA
    TF2_Bottle = 203, // 0x000000CB
    TF2_KGB = 204, // 0x000000CC
    TF2_Knife = 205, // 0x000000CD
    TF2_Kukri = 206, // 0x000000CE
    TF2_Shovel = 207, // 0x000000CF
    TF2_Wrench = 208, // 0x000000D0
  }

    public enum FVRPooledAudioType
    {
      Generic = 0,
      GunShot = 1,
      GunTail = 2,
      GunMech = 3,
      GunHand = 4,
      Explosion = 5,
      ExplosionTail = 6,
      GenericClose = 10, // 0x0000000A
      GenericLongRange = 11, // 0x0000000B
      GenericVeryLongRange = 12, // 0x0000000C
      UIChirp = 20, // 0x00000014
      NPCShotNear = 30, // 0x0000001E
      NPCShotFarDistant = 31, // 0x0000001F
      NPCHandling = 32, // 0x00000020
      NPCBarks = 33, // 0x00000021
      Casings = 40, // 0x00000028
      Impacts = 41, // 0x00000029
    }

    public class FVRFireArmAttachment : FVRPhysicalObject
  {

  }

    public class FVRFireArmAttachmentMount : MonoBehaviour
    {
    }

    public class FVRFireArmBipod : MonoBehaviour
    {
    }

}