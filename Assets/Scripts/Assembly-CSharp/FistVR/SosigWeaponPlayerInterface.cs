using UnityEngine;

namespace FistVR
{
	public class SosigWeaponPlayerInterface : FVRPhysicalObject
	{
		public SosigWeapon W;
		public FVRAlternateGrip Foregrip;
		public bool HasActiveShoulderStock;
		public Transform StockPos;
		public bool UsesHoloSight;
		public GameObject HoloSight;
		public AudioEvent AudEvent_Rattle;
		public AudioEvent AudEvent_Ding;
		public float RattleRadius;
		public float RattleHeight;
	}
}
