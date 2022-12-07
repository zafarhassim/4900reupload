using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public Animator animator;
    public float walkMag = 0.01f;
    public bool isJumping = false;
    public AnimatorStateInfo Player1Layer0;
    public GameObject Player1;
    public GameObject Opponent;
    public Vector3 OppPosition;
    public bool FacingLeft = true;
    public bool FacingRight = false;
    //public Player1HeathSystem player1HeathSystem;
    public int health = 100;
    public int currentHealth;

    void Awake()
    {
        currentHealth = health;

    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Player1Layer0 = animator.GetCurrentAnimatorStateInfo(0);

        
        //Flip Character
        OppPosition = Opponent.transform.position;

        if(Input.GetKeyDown(KeyCode.Z))
        {
            RotateByDegrees();
        }


        //Horizontal Walking
        if (Player1Layer0.IsTag("Motion"))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                animator.SetBool("Forward", true);
                transform.Translate(0, 0, walkMag);
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                animator.SetBool("Backward", true);
                transform.Translate(0, 0, -walkMag);

            }
            if (Input.GetAxis("Horizontal") == 0)
            {
                animator.SetBool("Backward", false);
                animator.SetBool("Forward", false);
            }

            //Jumping and crouching
            if (Input.GetAxis("Vertical") > 0)
            {
                if (Input.GetAxis("Vertical") > 0)
                {
                    isJumping = true;
                    animator.SetTrigger("Jump");
                    StartCoroutine(JumpPause());
                }
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                animator.SetBool("Crouch", true);
            }
            if (Input.GetAxis("Vertical") == 0)
            {
                animator.SetBool("Crouch", false);
            }
        }
    }

    IEnumerator JumpPause()
    {
        yield return new WaitForSeconds(1.0f);
        isJumping = false;

    }

    void RotateByDegrees()
    {
        Vector3 rotationToAdd = new Vector3(0, 180, 0);
        transform.Rotate(rotationToAdd);
    }

    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Hit");
        currentHealth = health -10;
       // player1HeathSystem.takeDamage(damage);
    }

}