using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereExplode : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.OnVictory += SphereDelete;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SphereDelete()
    {
        Destroy(this.gameObject);
    }
}
