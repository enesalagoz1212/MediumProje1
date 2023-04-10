using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player10 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.5f;
    [SerializeField] GameObject _lazerPrefab;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

  
    void Update()
    {
        Movement();

		if (Input.GetKeyDown(KeyCode.Space))
		{
            Instantiate(_lazerPrefab, transform.position, Quaternion.identity);
		}
    }

    private void Movement()
	{
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);
	}
}
