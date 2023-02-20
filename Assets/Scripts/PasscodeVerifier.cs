using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    public string currentInput;
    public string passcode;
    public Material displayMat;
    public DoorController door;

    //TODO: PUT IN DISPLAY MATERIAL NAMES
    private string[] displayMaterialNames = new string[4];
    private Material[] displayMaterials;

    // Start is called before the first frame update
    void Start()
    {
        currentInput = "";
        displayMaterials = new Material[displayMaterialNames.Length];
        for (int i = 0; i < 4; i++)
        {
            Material newMat = Resources.Load(displayMaterialNames[i], typeof(Material)) as Material;
            displayMaterials[i] = newMat;
        }
    }

    public void checkCode()
    {
        displayMat = displayMaterials[currentInput.Length];
        if (currentInput.Length == 4)
        {
            door.isOpened = (currentInput == passcode);
            if (currentInput == passcode)
            {
                // set unlocked material
            } else
            {
                // set invalid material
            }
        }
    }


}
