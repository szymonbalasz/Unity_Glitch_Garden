using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("How long the level will last in seconds.")]
    [SerializeField] float levelTime = 10f;

    Slider slider = default;
    bool levelFinished = false;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (levelFinished) { return; }
        slider.value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);

        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            levelFinished = true;
        }
    }
}
