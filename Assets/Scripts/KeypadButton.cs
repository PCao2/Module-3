using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadButton : MonoBehaviour
{
    public string buttonNumber;
    public KeypadCode keypad;
    public void enterDigit()
    {
        keypad.nextDigit(buttonNumber);
    }
}
