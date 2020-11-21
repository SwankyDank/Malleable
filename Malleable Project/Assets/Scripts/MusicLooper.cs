using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLooper : MonoBehaviour
{
    // Start is called before the first frame update
    public float startLoop = 0f;
    public float endLoop = 0f;

    public bool loops = false;
    public bool hasIntro = false;

    public int loopTimes = -1;
    private int timesLooped = 0;

    private AudioSource k;
    void Start()
    {
        k = GetComponent<AudioSource>();
        Debug.Log(k);
    }

    // Update is called once per frame
    void Update()
    {
        if (loops)
        {
            if (!hasIntro)
            {
                if (k.time < startLoop)
                {
                    k.time = startLoop;
                }
            }

            if (k.time >= endLoop)
            {
                if (timesLooped != loopTimes)
                {
                    k.time = startLoop;

                    if (loopTimes < 0)
                        timesLooped++;
                }

            }
        }
    }
}
