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
        stars = stars * (int) PlayerPrefsController.GetDifficulty();
        UpdateStars();
    }

    private void UpdateStars()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        if (stars < amount) { return false; }
        else { return true; }
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateStars();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateStars();
        }        
    }

}
