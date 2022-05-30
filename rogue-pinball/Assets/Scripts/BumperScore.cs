using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BumperScore : MonoBehaviour
{
    public LevelData levelData;
    public int getScore = 0;
    public TextMeshPro scoreTMP;

    private int _newScore;

    void Start()
    {
        scoreTMP.text = getScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
            UpdateScore();
    }

    void UpdateScore()
    {
        _newScore = levelData.runtimeScore + getScore;
        levelData.runtimeScore = _newScore;
    }
}
