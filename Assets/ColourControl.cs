using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourControl : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.OnVictory += ColourFunction;
    }

    void ColourFunction()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

