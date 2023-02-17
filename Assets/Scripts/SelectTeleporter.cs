using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTeleporter : MonoBehaviour
{
    public Teleport parentTeleporter;
    public GameObject teleporterSelection;


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            parentTeleporter.TeleportTo = teleporterSelection;
        }
    }
}
