using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMainCam : MonoBehaviour
{
    private GameObject camObject;
    // Start is called before the first frame update
    void Start()
    {
        camObject = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = camObject.transform.position;
        this.transform.rotation = camObject.transform.rotation;

    }
}
