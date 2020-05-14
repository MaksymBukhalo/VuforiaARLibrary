using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
	public Ball BallPrefab;
	public GameObject Floor;
	public GameObject Parent;
	public int BallCount;
	public float Power;
	public static List<GameObject> AllBalls = new List<GameObject>();

	public void SpawnBalls()
	{
		for (int i = 0; i < BallCount; i++)
		{
			GameObject NewBall = Instantiate(BallPrefab.gameObject, Floor.transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity);
			NewBall.transform.parent = Parent.transform;
			Vector3 BallVelocity = new Vector3(Power, 0, Power);
			Vector3 BallForceVector = Floor.transform.rotation * BallVelocity;
			NewBall.GetComponent<Rigidbody>().AddForce(BallForceVector, ForceMode.Acceleration);
			NewBall.name = "Ball " + (i + 1).ToString();
			AllBalls.Add(NewBall);
		}
	}

	public void DeleteBalls()
	{
		for (int i = 0; i < AllBalls.Count; i++)
		{
			Destroy(AllBalls[i]);
		}
		AllBalls = new List<GameObject>();
	}
}
