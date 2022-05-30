using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.Quit();
    }
}
