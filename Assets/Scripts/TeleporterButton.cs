using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterButton : MonoBehaviour
{
    public Teleport Teleporter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonPress()
    {
        Teleporter.teleport();
    }
}
