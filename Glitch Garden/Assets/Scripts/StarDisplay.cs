using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;

    Text starText = default;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateStars();
    }

    private void UpdateStars()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
    }

    public void SpendStars(int amount)
    {
        if (stars > amount)
        {
            stars -= amount;
        }        
    }

}
