using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public float MinSpeed = 4f;

	private void Update()
	{
		SpeedUpBallIfNeedIt();
	}
	private void SpeedUpBallIfNeedIt()
	{
		if (gameObject.GetComponent<Rigidbody>().velocity.magnitude < MinSpeed)
		{
			gameObject.GetComponent<Rigidbody>().AddForce(gameObject.GetComponent<Rigidbody>().velocity.normalized, ForceMode.Acceleration);
		}
	}
}
