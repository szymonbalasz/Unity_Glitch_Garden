using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDamage : MonoBehaviour
{
    [SerializeField] float destroyTime = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<LivesDisplay>().DeductALife();
        Destroy(collision.gameObject, destroyTime);
    }
}
