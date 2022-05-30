using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int spawnChance = 1;

    void Start()
    {
        int randomNum = Random.Range(1, spawnChance);

        if (randomNum != 1)
            gameObject.SetActive(false);
    }
}
