using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    Slider control;
    void Start()
    {
        control = GetComponent<Slider>();   
    }

    public void ChangeVolume()
    {
        AudioManager.Instance.VolumeMusic(control.value);
    }
}
