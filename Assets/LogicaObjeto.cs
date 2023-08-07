using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{
    
    public bool destruirAutomatico;
    public PlayerMovement logicaPersonaje1;

    public int tipo;
    //1 = Mas Velocidad
    //2 = Salto mas alto
    void Start()
    {
        logicaPersonaje1 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

   
    void Update()
    {
        
    }
    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                logicaPersonaje1.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                break;
                case 2:
                logicaPersonaje1.jumpForce += 3.5f;
                break;

                default:
                Debug.Log("sin efecto");
                break;

        }
    }
}
