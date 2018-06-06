﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour
{
    public FloatData HealthLevel;
    public Image HealthImage;

	// Use this for initialization
	void Start ()
    {
        HealthImage = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        HealthImage.fillAmount = HealthLevel.Value;
	}
}
