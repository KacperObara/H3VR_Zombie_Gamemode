using UnityEngine;
using System.Collections.Generic;

namespace FistVR
{    [CreateAssetMenu(fileName = "NewOutfitConfig", menuName = "Sosig/SosigOutfitConfig", order = 0)]
    public class SosigOutfitConfig : ScriptableObject
	{
		public List<FVRObject> Headwear;
		public float Chance_Headwear;
		public List<FVRObject> Eyewear;
		public float Chance_Eyewear;
		public List<FVRObject> Facewear;
		public float Chance_Facewear;
		public List<FVRObject> Torsowear;
		public float Chance_Torsowear;
		public List<FVRObject> Pantswear;
		public float Chance_Pantswear;
		public List<FVRObject> Pantswear_Lower;
		public float Chance_Pantswear_Lower;
		public List<FVRObject> Backpacks;
		public float Chance_Backpacks;
		public List<FVRObject> TorosDecoration;
		public float Chance_TorosDecoration;
		public List<FVRObject> Belt;
		public float Chance_Belt;
	}
}
