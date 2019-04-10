using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInSprite : MonoBehaviour
{
    public float timeToFadeIn;
    public float increment;
    private float target;
    private Image img;
    private float timer;
    public GameObject enabler;

    private void Start()
    {
        img = GetComponent<Image>();
        target = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToFadeIn)
        {
            if (img.color.a <= target)
            {
                float a = img.color.a + increment;
                Color mcolor = new Color(img.color.r, img.color.g, img.color.b, a);
                img.color = mcolor;
                if (enabler)
                {
                    enabler.SetActive(true);
                }
            }
        }
    }
}
