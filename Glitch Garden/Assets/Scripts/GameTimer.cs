using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("How long the level will last in seconds.")]
    [SerializeField] float levelTime = 10f;

    Slider slider = default;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        if (timerFinished)
        {
            Debug.Log("level timer expired");
        }
    }
}
