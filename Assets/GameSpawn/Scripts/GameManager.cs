using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Camera Parent;
	public GameObject BulletPrefab;
	public float BulletSpeed = 1000;

	private void Update()
	{
		SpawnBulletWhenTapOnScreen();
	}
	private void SpawnBulletWhenTapOnScreen()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject NewBullet = Instantiate(BulletPrefab, Parent.transform.position, Quaternion.identity);
			Ray BulletRay = Parent.ScreenPointToRay(Input.mousePosition);
			NewBullet.GetComponent<Rigidbody>().AddForce(BulletRay.direction * BulletSpeed, ForceMode.Acceleration);
		}
	}
}
