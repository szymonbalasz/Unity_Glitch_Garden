using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Header("Movement")]
    float currentSpeed = 0f;
    

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
