using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float speed;
    private Rigidbody2D Player_Body1;
    private Vector3 Player_Change;
    private Animator Game_Animator;
    private bool InteractionHappening;

    // Start is called before the first frame update
    void Start()
    {
        Game_Animator = GetComponent<Animator>();
        Player_Body1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Player_Change = Vector3.zero;
        Player_Change.x = Input.GetAxisRaw("Horizontal");
        Player_Change.y = 0;

        if(Player_Change != Vector3.zero && !InteractionHappening)
        {
            MovePlayer();
            //Animation
            Game_Animator.SetFloat("moveX", Player_Change.x);
            Game_Animator.SetFloat("moveY", 0);
            //Am I moving?
            Game_Animator.SetBool("Moving", true);
        }
        //The player has stopping walking
        else { Game_Animator.SetBool("Moving", false); }
    }

    void MovePlayer()
    {
        Player_Body1.MovePosition(transform.position + Player_Change * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!(collision.gameObject.name.Contains("Coin") || collision.gameObject.name.Contains("Note")))
        {
            InteractionHappening = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        InteractionHappening = false;
    }
}
