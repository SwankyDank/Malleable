using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseScript : MonoBehaviour
{
    private bool pauseActive = false;
    private GameObject rootObject = null;

    // Start is called before the first frame update
    void Start()
    {
        rootObject = GameObject.Find("Game");
    }

    public void setPauseValue(bool value)
    {
        if (value == true)
        {
            rootObject.transform.Find("PauseMenu").gameObject.SetActive(true);
            rootObject.transform.Find("GameScreen").gameObject.SetActive(false);
        }
        else
        {
            rootObject.transform.Find("PauseMenu").gameObject.SetActive(false);
            rootObject.transform.Find("GameScreen").gameObject.SetActive(true);
        }
        pauseActive = value;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            setPauseValue(!pauseActive);
        }
    }
}
