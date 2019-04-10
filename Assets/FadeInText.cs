using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInText : MonoBehaviour
{
    public float timeToFadeIn;
    public float increment;
    private float target;
    private Text img;
    private float timer;
    public GameObject enabler;
    private FadeInOut fade;

    private void Start()
    {
        img = GetComponent<Text>();
        target = 255f;
        fade = GetComponent<FadeInOut>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToFadeIn)
        {
            if (img.color.a <= target)
            {
                float a = img.color.a;
                Color color = new Color(img.color.r, img.color.g, img.color.b, img.color.a + increment);
                img.color = color;
                fade.enabled = true;
                enabled = false;
                if (enabler)
                {
                    enabler.SetActive(true);
                }
            }
        }
    }
}
