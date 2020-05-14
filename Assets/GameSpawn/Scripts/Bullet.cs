using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ball")
		{
			BallManager.AllBalls.Remove(other.gameObject);
			Destroy(gameObject);
			Destroy(other.gameObject);
		}
	}
}
