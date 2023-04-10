using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	
	void Start()
	{

	}


	void Update()
	{
		
		if (transform.position.y < -5f)
		{
			Debug.Log("Calisti");
			transform.position += new Vector3(Random.Range(-3, 3), 11, 0);
			
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(this.gameObject);
		}
		if (other.tag == "Laser")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
	}
}
