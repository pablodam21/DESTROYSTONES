﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuzEventos : MonoBehaviour
{
	public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		    
    }
	public void CambiarBrillo(){
		RenderSettings.ambientIntensity = slider.value;    
	}
}
