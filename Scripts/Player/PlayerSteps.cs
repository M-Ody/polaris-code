﻿// Polaris - Project VII 2018
// 08/03/18 -> 02/07/18
// Compiled in Unity 2017.2.0f3
// Writed by Mathias Ody (M-Ody)
// mathiasluizody@hotmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PolarisCore;

public class PlayerSteps : MonoBehaviour 
{
    private int _playStepsKey;

    private void Start()
    {
        _playStepsKey = Pool.Instance.GetSharedPoolKey("PlayerSteps");
    }

    public void _Play()
    {
        SoundManager.Play(_playStepsKey, transform);
    }
}
