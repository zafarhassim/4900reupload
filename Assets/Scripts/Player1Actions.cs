using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Actions : MonoBehaviour
{
    public float jumpMag = 0.01f;
    public GameObject Player1;
    public Animator animator;
    public static bool Contact = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("KickOne");
            Contact = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("KickTwo");
            Contact = false;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("PunchOne");
            Contact = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("PunchTwo");
            Contact = false;
        }
    }

    public void JumpUp()
    {
        Player1.transform.Translate(0, jumpMag, 0);
    }


}
