using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;
    [SerializeField] int starGeneration = 0;

    public void AddStars()
    {
        FindObjectOfType<StarDisplay>().AddStars(starGeneration);
        Debug.Log("stars added");
    }

    public int GetStarCost()
    {
        return starCost;
    }
}
