using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsador : MonoBehaviour
{
    private int contador = 12;
    private GameObject[] barriles;

    private void Start()
    {
        barriles = GameObject.FindGameObjectsWithTag("Pulsador");
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Detecta");
    //    if (collision.gameObject.tag == "Pulsador")
    //    {
    //        Debug.Log("Colision con barril");
    //        Destroy(collision.gameObject);
    //        contador--;
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Salta trigger");
        if (other.gameObject.tag == "Pulsador")
        {
            Debug.Log("Colision con barril");
            Destroy(other.gameObject);
            contador--;
        }
    }

    public void QuitarBarriles()
    {
        foreach (GameObject barril in barriles)
        {
            Destroy (barril);
        }
    }
}
