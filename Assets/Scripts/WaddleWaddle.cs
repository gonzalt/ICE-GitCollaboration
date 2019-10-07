using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaddleWaddle : MonoBehaviour
{
	private Vector3 pos1 = new Vector3(-3, 0, -5);
	private Vector3 pos2 = new Vector3(4, 0, -5);
	public float speed = 1.0f;

	private Vector3 rot1 = new Vector3(0, -235, 0);
	private Vector3 rot2 = new Vector3(0, 235, 0);
	public float rotSpeed = 1.0f;


	void Update()
	{


		transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);


	}


}
