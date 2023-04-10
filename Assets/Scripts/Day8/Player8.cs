using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Burada objemiz sabit hareketi i�in private olarak bir de�er belirledik nesnemizin pozisyonunu (0,0,0) konumunda ba�lat�p sabit h�zla sa�a do�ru hareketini sa�lad�k Time.deltaTime ile ger�ek zamanl� olarak hareketi sa�lad�k
public class Player8 : MonoBehaviour
{
    // public float speed = 3.5f;
   [SerializeField] private float _speed = 3.5f;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    // Lambda expression 
    // Lambda ifadesi bir metodu k�sa bir �ekilde ifade etmemize olanak tan�r.  sol taraf metodun imzas�n� belirtir ,sa� taraf ise bu metoda ait kod blo�unu ifade eder.
    /*  
    void Update() => transform.Translate(Vector3.right * speed * Time.deltaTime);
    */

    public void Update()
	{
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
	}
}
