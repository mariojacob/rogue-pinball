using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    public GameManager gameManager;

    private void OnMouseDown()
    {
        gameManager.StartGame();
    }
}
