using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Numeros : MonoBehaviour
{

    public TextMeshProUGUI titulo;
    public GameObject pared;
    public GameObject paredInicio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespuestaMal()
    {
        titulo.text = "No eres muy listo ¿no?";
        Debug.Log("respuesta mala");
        StartCoroutine(vueltaEmpezar());
    }

    public void RespuestaBien()
    {
        titulo.text = "Brillante. Un genio. Top. Puedes pasar.";
        Destroy(pared,1);
        Debug.Log("Respuesta biern");
    }

    IEnumerator vueltaEmpezar()
    {
        yield return new WaitForSeconds(2);
        titulo.text = "¿Cuánto es 2 x 4?";
    }
}
