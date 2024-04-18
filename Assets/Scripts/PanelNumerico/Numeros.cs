using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Numeros : MonoBehaviour
{

    public TextMeshProUGUI titulo;
    public GameObject pared;
    //public GameObject paredInicio;

    //public AudioClip audio;
    public AudioSource auSour;
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
        // SceneManager.LoadScene("Modular Dungeon");
        StartCoroutine(vueltaEmpezar());
    }

    public void RespuestaBien()
    {
        titulo.text = "Brillante. Un genio. Top. Puedes pasar.";
        Destroy(pared,1);
        auSour.Play();
        Debug.Log("Respuesta biern");
    }

    IEnumerator vueltaEmpezar()
    {
        yield return new WaitForSeconds(2);
        titulo.text = "Si Juan tiene 10 manzanas y le quitamos 3, calcula la densidad del sol.";
    }

}
