using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleBackgroundMorph : MonoBehaviour
{

    [SerializeField]
    private Color StartColor;
    [SerializeField]
    private Color EndColor;
    [SerializeField]
    private float RepeatTime;

    private Image backImg;
    private float currTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        backImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        float blendVal = 0f;
        currTime += Time.deltaTime;

        if(currTime >= RepeatTime)
        {
            currTime = 0f;
        }

        if(currTime <= RepeatTime/2f)
        {
            blendVal = currTime / (RepeatTime / 2f);
        }
        else
        {
            blendVal = 1f - ((currTime - (RepeatTime/2f)) / (RepeatTime / 2f));
        }


        backImg.color = Color.Lerp(StartColor, EndColor, blendVal);
    }
}
