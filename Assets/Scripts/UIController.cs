using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text txtScore;
    public Image[] imageLifes;
    public GameObject panelGame, panelPause;

    void Start()
    {
        panelGame.gameObject.SetActive(true);
        panelGame.gameObject.SetActive(false);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void ButtonPause()
    {
        Time.timeScale = 0f;
        panelGame.gameObject.SetActive(false);
        panelPause.gameObject.SetActive(true);
    }
    public void ButtonResume()
    {
        Time.timeScale = 1f;
        panelGame.gameObject.SetActive(true);
        panelPause.gameObject.SetActive(false);
    }
    public void ButtonBackMainMenu()
    {
        Time.timeScale = 1f;
        panelGame.gameObject.SetActive(false);
        panelPause.gameObject.SetActive(false);
    }

    public void ButtonRestart()
    {
        Time.timeScale = 1f;
        panelGame.gameObject.SetActive(true);
        panelPause.gameObject.SetActive(false);
    }
}
