using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Header("Movement")]
    float currentSpeed = 0f;

    [Header("Effects")]
    [SerializeField] GameObject deathVFX = default;
    [SerializeField] float deathVFXTime = 1f;
    

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void DeathVFX()
    {
        GameObject VFX = Instantiate(deathVFX, transform.position, Quaternion.identity) as GameObject;
        Destroy(VFX, deathVFXTime);
    }
}
