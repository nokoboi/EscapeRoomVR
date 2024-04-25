using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class LanzamientoBolas : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject repisa, pared;
    public static int contador = 4;
    public AudioSource audio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barril"))
        {
            contador--;
            audio.Play();
            Destroy(collision.gameObject,0.5f);

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
