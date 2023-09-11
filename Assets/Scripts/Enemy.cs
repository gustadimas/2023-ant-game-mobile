using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int score;
    UIController uiController;
    Animator anim;
    GameController gameController;
    [SerializeField] GameObject[] sprites;

    void Start()
    {
        anim = GetComponent<Animator>();
        gameController = FindObjectOfType<GameController>();
        uiController = FindObjectOfType<UIController>();
        sprites[0] = transform.GetChild(0).gameObject;
        sprites[1] = transform.GetChild(1).gameObject;
    }

    void Update()
    {
        Movement();
        AnimSpeed();
    }

    void Movement() 
    {
        transform.Translate(Vector2.up * (speed * Time.deltaTime));
    }

    void AnimSpeed()
    {
        anim.SetFloat("Speed", speed);
    }

    public void Dead()
    {
        speed = 0f;
        gameController.totalScore += score + 1;
        uiController.UpdateScore(gameController.totalScore);
        sprites[0].gameObject.SetActive(false);
        sprites[1].gameObject.SetActive(true);
        Destroy(gameObject, Random.Range(2.5f, 5f));
    }

    public void PlayAudio(bool isDead)
    {
        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = gameController.audioEnemies[Random.Range(0, gameController.audioEnemies.Length)];
        audioSource.Play();
    }
}
