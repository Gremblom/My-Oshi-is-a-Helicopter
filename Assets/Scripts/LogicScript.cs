using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public GameObject gameReadyText;

    private float timer = 0;

    private float waitTime = 10;

    public bool gameStarted = false;

    [ContextMenu("Increase Score")]

    public void addSCore(int scoreToAdd){
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void gameReadyScreen(){
        if(timer < waitTime && !gameReadyText.activeSelf){
            timer += Time.deltaTime;
        } else if(!gameStarted){
            gameReadyText.SetActive(true);
        }
    }

    public void unsetGameReadyScreen(){
        gameReadyText.SetActive(false);
    }
}
