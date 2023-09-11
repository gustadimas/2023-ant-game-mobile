using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public int totalScore;
    [HideInInspector] public int enemyCount;
    public AudioClip[] audioEnemies;

    void Start()
    {
        totalScore = 0;
        enemyCount = 0;
    }
}
