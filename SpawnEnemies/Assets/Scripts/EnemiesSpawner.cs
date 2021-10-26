using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private List<Vector3> _positions;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            foreach(var position in _positions)
            {
                Instantiate(_enemyPrefab, position, _enemyPrefab.transform.rotation);

                yield return new WaitForSeconds(2);
            }
        }
    }
}
