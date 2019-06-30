using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 5;
    [SerializeField] int damage = 1;
    Text livesText = default;
    
    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }
    
    public void DeductALife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            
            //FindObjectOfType<LevelLoader>().LoadLoseScreen();
        }
    }
}
