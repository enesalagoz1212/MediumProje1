using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser11 : MonoBehaviour
{
	[SerializeField] float _laserSpeed = 8f;
	void Start()
	{

	}


	void Update()
	{
		transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);

		if (transform.position.y >= 8f)
		{
			Destroy(this.gameObject);
		}
	}
}
