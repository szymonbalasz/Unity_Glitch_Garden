//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;

    [SerializeField] float spawnTimerMin = default, spawnTimerMax = default;
    [SerializeField] Attacker attackerPrefab = default;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(spawnTimerMin, spawnTimerMax));
            spawnAttacker();
        }
    }

    private void spawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
