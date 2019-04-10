using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public float timeToFadeIn;
    public float increment;
    private float target;
    private Light light;
    private float timer;
    public GameObject enabler;

    private void Start()
    {
        light = GetComponent<Light>();
        target = light.intensity;
        light.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeToFadeIn)
        {
            if(light.intensity <= target)
            {
                light.intensity += increment;
                if(enabler)
                {
                    enabler.SetActive(true);
                }
            }
        }
    }
}
