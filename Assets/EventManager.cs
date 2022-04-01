using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void VictoryAction();
    public static event VictoryAction OnVictory;

    void AnnounceVictory()
    {
        OnVictory();
    }
    // could be OnDoor DoorAction

    void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            AnnounceVictory();
        }
    }
    
}
