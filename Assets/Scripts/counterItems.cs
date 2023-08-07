using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterItems : MonoBehaviour
{
    public static int numberItem;
    private Text CounterT;
    
    void Start()
    {
        CounterT = GetComponent<Text>();
        numberItem = 0;
    }

   
    void Update()
    {
        CounterT.text = "Items: " + numberItem;
    }
}
