using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Burada objemiz sabit hareketi için private olarak bir deðer belirledik nesnemizin pozisyonunu (0,0,0) konumunda baþlatýp sabit hýzla saða doðru hareketini saðladýk Time.deltaTime ile gerçek zamanlý olarak hareketi saðladýk
public class Player8 : MonoBehaviour
{
    // public float speed = 3.5f;
   [SerializeField] private float _speed = 3.5f;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    // Lambda expression 
    // Lambda ifadesi bir metodu kýsa bir þekilde ifade etmemize olanak tanýr.  sol taraf metodun imzasýný belirtir ,sað taraf ise bu metoda ait kod bloðunu ifade eder.
    /*  
    void Update() => transform.Translate(Vector3.right * speed * Time.deltaTime);
    */

    public void Update()
	{
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
	}
}
