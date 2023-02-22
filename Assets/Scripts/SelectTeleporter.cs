using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTeleporter : MonoBehaviour
{
    public Teleport parentTeleporter;
    public GameObject teleporterSelection;


    public void SetTeleporter()
    {
            parentTeleporter.TeleportTo = teleporterSelection;
    }
}
