using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    GameController gameController;
    UIController uiController;
    public GameObject GameOver;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        uiController = FindObjectOfType<UIController>();
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Enemy"))
        {
            gameController.enemyCount++;

            if (gameController.enemyCount < 5)
            {
                uiController.imageLifes[gameController.enemyCount - 1].gameObject.SetActive(false);
            }
            else
            {
                uiController.imageLifes[gameController.enemyCount - 1].gameObject.SetActive(false);
                Time.timeScale = 0f;
                GameOver.gameObject.SetActive(true);
            }

            Destroy(target.gameObject);
        }
    }
}
