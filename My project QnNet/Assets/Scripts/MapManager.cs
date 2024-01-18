using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public float minSpawnRate = 0.1f;
    public float maxSpawnRate = 1.0f;
    public EnemySpawnController enemySpawnController;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BattleArea"))
        {
            TryTriggerEncounter();
        }
    }

    void TryTriggerEncounter()
    {
        float randomSpawnRate = Random.Range(minSpawnRate, maxSpawnRate);
        if (Random.value < randomSpawnRate & enemySpawnController != null)
        {
            enemySpawnController.TriggerRandomBattle();
        }
    }
}
