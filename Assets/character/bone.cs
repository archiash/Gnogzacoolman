using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bone : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("jump", true);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetBool("jump", false);
        }
    }
}