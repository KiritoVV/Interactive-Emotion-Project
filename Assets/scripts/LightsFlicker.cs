using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsFlicker : MonoBehaviour
{
    public Light light08;

    public AudioSource lightSound;

    public float minTime;
    public float maxTime;
    public float timer;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
;   }

    void Update()
    {
        LightsFlickering();
    }

    void LightsFlickering()
    {
        if(timer > 0)
                timer -= Time.deltaTime;

        if(timer <= 0)
        {
            light08.enabled = !light08.enabled;
            timer = Random.Range(minTime, maxTime);
            lightSound.Play();
        }
    }
}
