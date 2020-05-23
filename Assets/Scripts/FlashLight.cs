using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    private bool isOn = true;
    private Light emergencyLight;
    private AudioSource switchSFX;

    void Start()
    {
        emergencyLight = GetComponent<Light>();
        switchSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (emergencyLight && Input.GetMouseButtonDown(0))
        {
            isOn = !isOn;
            emergencyLight.enabled = isOn; 
            if (switchSFX) switchSFX.Play();
        }
    }
}
