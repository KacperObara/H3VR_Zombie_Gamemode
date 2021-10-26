using UnityEngine;

public class AICoverPoint : MonoBehaviour
{
	public bool DoCalc;
	public bool DoTestDist;
	public int GroupIndex;
	public bool IsActive;
	public float[] MaxVis;
	public LayerMask VisMask;
	public bool[] DoDebug;
	public float[] Heights;
	public Vector3[] HitPoints;
	public Vector3 Pos;
	public Transform TestCube;
	public float Scratch;
	public bool IsClaimed;
}
