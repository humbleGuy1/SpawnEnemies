using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Vector3 _position1;
    [SerializeField] private Vector3 _position2;
    [SerializeField] private Vector3 _position3;
    
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Instantiate(_enemyPrefab, _position1, _enemyPrefab.transform.rotation);

            yield return new WaitForSeconds(2);

            Instantiate(_enemyPrefab, _position2, _enemyPrefab.transform.rotation);

            yield return new WaitForSeconds(2);

            Instantiate(_enemyPrefab, _position3, _enemyPrefab.transform.rotation);

            yield return new WaitForSeconds(2);
        }
    }
}
