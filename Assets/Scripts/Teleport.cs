using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject TeleportTo;

    private GameObject[] AllTeleporters;

    private List<Collider> TriggerList = new List<Collider>();
    //The list of colliders currently inside the trigger
    // Start is called before the first frame update
    void Start()
    {
        AllTeleporters = GameObject.FindGameObjectsWithTag("Teleporter");
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject GetCurrentTeleportLocation()
    {
        foreach (GameObject teleporter in AllTeleporters)
        {
            if (teleporter == TeleportTo)
            {
                return teleporter;
            }
        }
        return null;
    }

    public void teleport()
    {
        GameObject teleporter = GetCurrentTeleportLocation();
        if (teleporter != null)
        {
            Vector3 distance = teleporter.transform.position - transform.position;
            // TODO: May need to adjust to detect player
            foreach (Collider other in TriggerList)
            {
                Vector3 originalPosition = other.transform.position;
                other.transform.position = new Vector3(originalPosition.x + distance.x, originalPosition.y + distance.y + 0.01f, originalPosition.z + distance.z);
            }
        }
        
    }

    //called when something enters the trigger
    void OnTriggerEnter(Collider other)
    {
        //if the object is not already in the list
        if (!TriggerList.Contains(other))
        {
            //add the object to the list
            TriggerList.Add(other);
        }
    }

    //called when something exits the trigger
    void OnTriggerExit(Collider other)
    {
        //if the object is in the list
        if (TriggerList.Contains(other))
        {
            //remove it from the list
            TriggerList.Remove(other);
        }
    }
}
