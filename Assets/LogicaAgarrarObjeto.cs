using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaAgarrarObjeto : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.tag);

        if (other.tag == "Objeto" && other.GetComponent<LogicaObjeto>().destruirAutomatico == true)
        {
            other.GetComponent<LogicaObjeto>().Efecto();
            Destroy(other.gameObject);
        }
        
    }
}
