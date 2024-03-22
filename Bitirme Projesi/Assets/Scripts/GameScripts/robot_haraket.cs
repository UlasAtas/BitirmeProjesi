using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_haraket : MonoBehaviour
{
    public float robot_hizi = 3.0f;
    private Animator animator;
    public bool hareketEt;
    public AudioSource hareketSes;

    private void Start()
    {
        hareketEt = true;
        animator = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        //if (hareketEt)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-1.0f, 0f) * robot_hizi * Time.deltaTime);
                animator.SetBool("moving", true);
                hareketSes.Play();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector2(1.0f, 0f) * robot_hizi * Time.deltaTime);
                animator.SetBool("moving", true);
                hareketSes.Play();
            }
            else
            {
                animator.SetBool("moving", false);
                hareketSes.Pause();
            }

        }

    }
}

