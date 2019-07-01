using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] int starCost = 100;
    [SerializeField] int starGeneration = 0;

    [Header("VFX")]
    [SerializeField] GameObject deathVFX = default;
    [SerializeField] float deathVFXTime = 1f;


    private void Start()
    {
        starGeneration = starGeneration / (int) PlayerPrefsController.GetDifficulty();
    }

    public void AddStars()
    {
        FindObjectOfType<StarDisplay>().AddStars(starGeneration);
    }

    public int GetStarCost()
    {
        return starCost;
    }

    public void DeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject VFX = Instantiate(deathVFX, transform.position, Quaternion.identity) as GameObject;
        Destroy(VFX, deathVFXTime);
    }
}
