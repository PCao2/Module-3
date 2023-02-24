using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadCode : MonoBehaviour
{
    public string code = "0000";
    public string current = "";
    public Material[] keypadMaterials;
    public GameObject keypadScreen;

    public DoorController door;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void nextDigit(string nextDigit)
    {
        current = current + nextDigit;

        keypadScreen.GetComponent<Renderer>().material = keypadMaterials[current.Length-1];

        if (current.Length >= 4) {
            bool isCorrect = code == current;
            door.isOpened = isCorrect;
            if (!isCorrect) {
                keypadScreen.GetComponent<Renderer>().material = keypadMaterials[0];
                current = "";
            }
   
        }
    }
}
