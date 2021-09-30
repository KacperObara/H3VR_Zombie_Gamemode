using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FistVR
{
    //TODO Not in use, just a stub, move it to some other file with the rest of the stubs
    public class FVRQuickBeltSlot : MonoBehaviour
    {
        public Transform QuickbeltRoot;
        public Transform PoseOverride;
        public FVRPhysicalObject.FVRPhysicalObjectSize SizeLimit;
        public FVRQuickBeltSlot.QuickbeltSlotShape Shape;
        public FVRQuickBeltSlot.QuickbeltSlotType Type;
        public GameObject HoverGeo;
        [NonSerialized] public Renderer m_hoverGeoRend;
        public Transform RectBounds;
        public FVRPhysicalObject CurObject;
        public bool IsSelectable;
        public bool IsPlayer;
        public bool UseStraightAxisAlignment;
        [NonSerialized] public bool m_isKeepingTrackWithHead;
        [NonSerialized] public bool m_isHovered;
        [HideInInspector] public FVRInteractiveObject HeldObject;

        public bool IsKeepingTrackWithHead
        {
            get { return false; }
            set { }
        }

        public bool IsHovered
        {
            get { return false; }
            set { }
        }

        public void Awake()
        {
        }

        public bool IsPointInsideMe(Vector3 v)
        {
            return false;
        }

        public bool IsPointInsideSphereGeo(Vector3 p)
        {
            return false;
        }

        public bool IsPointInsideRectBound(Vector3 p)
        {
            return false;
        }

        public void Update()
        {
        }

        public void FixedUpdate()
        {
        }

        public void MoveContents(Vector3 dir)
        {
        }

        public void MoveContentsInstant(Vector3 dir)
        {
        }

        public void MoveContentsCheap(Vector3 dir)
        {
        }

        public enum QuickbeltSlotShape
        {
            Sphere,
            Rectalinear,
        }

        public enum QuickbeltSlotType
        {
            Standard,
            Backpack,
            None,
        }
    }
}