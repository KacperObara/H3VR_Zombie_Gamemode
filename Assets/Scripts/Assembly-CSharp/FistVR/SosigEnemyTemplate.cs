using UnityEngine;
using System.Collections.Generic;

namespace FistVR
{    [CreateAssetMenu(fileName = "NewEnemyTemplate", menuName = "Sosig/SosigEnemyTemplate", order = 0)]
    public class SosigEnemyTemplate : ScriptableObject
	{
		public string DisplayName;
		public SosigEnemyCategory SosigEnemyCategory;
		public SosigEnemyID SosigEnemyID;
		public List<FVRObject> SosigPrefabs;
		public List<SosigConfigTemplate> ConfigTemplates;
		public List<SosigConfigTemplate> ConfigTemplates_Easy;
		public List<SosigOutfitConfig> OutfitConfig;
		public List<FVRObject> WeaponOptions;
		public List<FVRObject> WeaponOptions_Secondary;
		public float SecondaryChance;
		public List<FVRObject> WeaponOptions_Tertiary;
		public float TertiaryChance;

	}

    public class SosigEnemyCategory{}
}
