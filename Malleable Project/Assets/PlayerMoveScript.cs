using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    private bool moving = false;
    private bool air = false;
    [SerializeField] private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            moving = true;
            Vector3 moveVec = new Vector3(1, 0, 0) * -speed * Time.deltaTime;

            this.GetComponent<SpriteRenderer>().flipX = true;

            transform.Translate(moveVec);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moving = true;
            Vector3 moveVec = new Vector3(1, 0, 0) * speed * Time.deltaTime;

            this.GetComponent<SpriteRenderer>().flipX = false;

            transform.Translate(moveVec);
        }
        else
        {
            moving = false;
        }

        Animator animator = this.GetComponent<Animator>();
        animator.SetBool("Moving", moving);
        animator.SetBool("Air", air);
    }
}
