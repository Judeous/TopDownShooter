﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerBehavior : MonoBehaviour
{
    [SerializeField] private static bool _gameOver = false;
    [SerializeField] private HealthBehaviour _playerHealth;
    [SerializeField] private GameObject _gameOverScreen;

    public delegate void GameEvent();

    public static GameEvent onGameOver;

    public static bool GameOver
    {
        get { return _gameOver; }
        set { _gameOver = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        _gameOver = _playerHealth.Health <= 0;

        _gameOverScreen.SetActive(GameOver);
    }
}
