using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Escalada : MonoBehaviour
{
    public Rigidbody rb;
    private RigidbodyConstraints originalConstraints;

    private void Start()
    {
        originalConstraints = rb.constraints;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Escalar"))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rb.constraints = originalConstraints;
    }
}
