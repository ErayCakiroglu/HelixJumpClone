using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    [SerializeField] GameObject lastRing;
    [SerializeField] Text scoreText, lastRingText;
    int score;

    /*Oyun içinde puan değişiminin gerçekleşmesini sağlayan methot.*/
    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    /*Oyunun baştan başlatılmasını sağlayan methot.*/
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /*Oyun kazanıldığı zaman ekrana yazılacakları gerçekleştiren methot.*/
    public void LastRingText()
    {
        lastRing.SetActive(true);
        lastRingText.text = "Tebrikler oyunu kazandınız";
    }
}
