using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player7 : MonoBehaviour
{
	// Day:7 Simple Player Movement in Unity
	void Start()
	{

	}


	void Update()
	{
		transform.Translate(Vector3.right * 5 * Time.deltaTime);
		// transform.Translate(Vector3.left*5*Time.deltaTime);
		// transform.Translate(Vector3.down*5*Time.deltaTime);
		// transform.Translate(Vector3.up*5*Time.deltaTime);
	}
}
