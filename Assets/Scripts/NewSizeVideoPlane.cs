using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSizeVideoPlane : MonoBehaviour
{
	[SerializeField] private GameObject canvas;

	private void Update()
	{
		NewSizeVideo();
	}

	private void NewSizeVideo()
	{
		float CanvasWidth = canvas.GetComponent<RectTransform>().rect.width;
		float CanvasHeight = canvas.GetComponent<RectTransform>().rect.height;
		if (canvas.GetComponent<RectTransform>().sizeDelta != transform.GetComponent<RectTransform>().sizeDelta)
		{
			transform.GetComponent<RectTransform>().sizeDelta = new Vector2(CanvasWidth, CanvasHeight);
		}
	}

}
