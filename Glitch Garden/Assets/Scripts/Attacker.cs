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

    [Header("Attack")]
    GameObject currentTarget = default;
    [SerializeField] float damage = 100f;


    private void Awake()
    {
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    private void OnDestroy()
    {
        LevelController controller = FindObjectOfType<LevelController>();
        if (controller != null)
        {
            controller.AttackerDestroyed();
        }
    }

    void Update()
    {
        MoveLeft();
        UpdateAnimationState();
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    public void DeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject VFX = Instantiate(deathVFX, transform.position, Quaternion.identity) as GameObject;
        Destroy(VFX, deathVFXTime);
    }

    public void Attack(GameObject target)
    {
        currentTarget = target;
        GetComponent<Animator>().SetBool("isAttacking", true);
    }

    public void DamageTarget()
    {
        if (!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }

    void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }
}
