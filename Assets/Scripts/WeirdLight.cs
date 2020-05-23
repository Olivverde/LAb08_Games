using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeirdLight : MonoBehaviour
{
    private Light emergencyLight;
    private int intensity = 8;
    private int frecuency = 4;

    void Start()
    {
        emergencyLight = GetComponent<Light>();
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (emergencyLight)
            emergencyLight.intensity = intensity * Mathf.Sin(frecuency * Time.time);
    }


    private void OnTriggerExit(Collider other)
    {
        if (emergencyLight)
            emergencyLight.intensity = 0;
    }
}
