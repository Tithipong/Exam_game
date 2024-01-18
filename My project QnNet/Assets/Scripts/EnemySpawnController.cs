using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawnController : MonoBehaviour
{
    public static EnemySpawnController Instance;
    //private GameObject selectedEnemy;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TriggerRandomBattle()
    {
        // Select an enemy
        GameObject[] enemyTypes = GameObject.FindGameObjectsWithTag("Enemy");
        int enemyID = Random.Range(0, enemyTypes.Length);
        //selectedEnemy  = enemyTypes[enemyID];

        SceneManager.LoadScene("BattleScene");
    }
}
