using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public float timeToFadeIn;
    public float increment;
    private float target;
    private Text img;
    private float timer;
    private bool fadingIn = false;

    private void Start()
    {
        img = GetComponent<Text>();
        target = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fadingIn)
        {
            img.CrossFadeAlpha(5f, 3.0f, true);
        }
        else
        {
        img.CrossFadeAlpha(0f, 3.0f, true);
        }

        timer += Time.deltaTime;
        if (timer > timeToFadeIn)
        {
            fadingIn = !fadingIn;
            timer = 0f;
        }
    }



}
