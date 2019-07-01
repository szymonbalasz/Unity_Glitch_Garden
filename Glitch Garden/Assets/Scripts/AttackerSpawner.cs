//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float spawnDelay = 5f;

    [SerializeField] float spawnTimerMin = default, spawnTimerMax = default;
    [SerializeField] Attacker[] attackerArray = default;
    
    void Start()
    {
        spawnTimerMin = spawnTimerMin / PlayerPrefsController.GetDifficulty();
        spawnTimerMax = spawnTimerMax / PlayerPrefsController.GetDifficulty();

        Invoke("DelayAndStart", spawnDelay);
    }

    private void DelayAndStart()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(spawnTimerMin, spawnTimerMax));
            spawnAttacker();
        }
    }

    private void spawnAttacker()
    {
        Spawn(attackerArray[Random.Range(0, attackerArray.Length)]);
    }

    private void Spawn(Attacker attackerPrefab)
    {
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity) as Attacker;
        newAttacker.transform.parent = transform;
    }

    public void StopSpawning()
    {
        spawn = false;
    }
}
