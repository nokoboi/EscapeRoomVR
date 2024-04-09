using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class LanzamientoBolas : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject repisa, pared;
    public static int contador = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barril"))
        {
            contador--;
            Destroy(collision.gameObject);

            Debug.Log(contador);

            if(contador == 0)
            {
                Destroy(pared);
                Destroy(repisa);

                foreach(GameObject ball in balls)
                {
                    Destroy(ball);
                }

            }



        }
    }
}
