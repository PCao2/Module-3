using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    // Number of collectibles needed to unlock door
    public int collectGoal = 1;

    public GameObject paper;

    private int objectsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected + 1;
        }

        paper.SetActive(objectsCollected == collectGoal);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            objectsCollected = objectsCollected - 1;
        }

        paper.SetActive(objectsCollected == collectGoal);


    }
}
