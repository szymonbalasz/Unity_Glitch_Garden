using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float rotationSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.World);
    }
}
