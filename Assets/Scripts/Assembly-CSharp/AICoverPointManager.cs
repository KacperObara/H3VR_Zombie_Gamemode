using UnityEngine;
using System.Collections.Generic;

public class AICoverPointManager : MonoBehaviour
{
	public float OctreeSize;
	public float DefaultSearchRange;
	public float SearchRangeStepSize;
	public List<AICoverPoint> MyCoverPoints;
	public float CellSize;
	public bool PopulateAtInit;
}
