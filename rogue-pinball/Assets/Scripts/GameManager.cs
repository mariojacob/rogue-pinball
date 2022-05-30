using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LevelData levelData;
    public TextMeshPro scoreTMP;
    public TextMeshPro highscoreTMP;
    public Transform ballParent;
    public GameObject ball;
    [Header("Buttons")]
    public GameObject startButton;
    public GameObject restartButton;
    [Header("Audio")]
    public AudioClip gameStart;

    private AudioSource _sound;
    private bool _isPlaying = false;
    private int _highscore;

    void Start()
    {
        _sound = GetComponent<AudioSource>();

        startButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(false);
    }

    void Update()
    {
        scoreTMP.text = levelData.runtimeScore.ToString();

        _highscore = PlayerPrefs.GetInt("highscore", 0);
        if (levelData.runtimeScore > _highscore)
            PlayerPrefs.SetInt("highscore", levelData.runtimeScore);

        _highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreTMP.text = _highscore.ToString();

        if (_isPlaying && Input.GetKeyDown(KeyCode.Space))
            RestartGame();
        else if (!_isPlaying && Input.GetKeyDown(KeyCode.Space))
            StartGame();

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public void StartGame()
    {
        _isPlaying = true;
        _sound.clip = gameStart;
        if (_sound != null)
            _sound.Play();

        InitializeGame();
        startButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        levelData.ResetRuntimeValues();
        SceneManager.LoadScene(levelData.sceneName);
    }

    public void InitializeGame()
    {
        int randomNumber = Random.Range(-7, 3);
        Debug.Log(randomNumber);
        Instantiate(ball, new Vector3(randomNumber, 3, 0), Quaternion.identity, ballParent);
    }
}
