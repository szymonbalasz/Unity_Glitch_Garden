using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultsLoader : MonoBehaviour
{
    [SerializeField] float defaultVolume = 0.5f;
    [SerializeField] float defaultDifficulty = 1f;

    void Start()
    {
        PlayerPrefsController.SetMasterVolume(defaultVolume);
        PlayerPrefsController.SetMasterDifficulty(defaultDifficulty);
    }

}
