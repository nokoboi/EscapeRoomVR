using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivarLineas : MonoBehaviour
{
   public XRRayInteractor linea;
    public XRInteractorLineVisual lineVisual;
    public LineRenderer lineRenderer;

    private void Awake()
    {
        linea.enabled = true;
        lineVisual.enabled = false;
        lineRenderer.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            linea.enabled = true;
            lineVisual.enabled = true;
            lineRenderer.enabled = true;
        }
    }
}
