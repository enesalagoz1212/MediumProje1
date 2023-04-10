using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player11 : MonoBehaviour
{

    [SerializeField] private float _speed = 3.5f;
    [SerializeField] GameObject _lazerPrefab;

    [SerializeField] float _fireRate = 0.5f;
    float _canFire = 0f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

  
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space) && Time.time>_canFire)
        {
            _canFire = Time.time + _fireRate;
            Instantiate(_lazerPrefab, transform.position+new Vector3(0,0.5f,0), Quaternion.identity);
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
