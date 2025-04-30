//Enemy is idle, player approaches, walks to player and attacks
// https://youtu.be/gXpi1czz5NA - Unity 5 tutorials that still works
// A more advanced version of this tutorial is available on Unity Learn
// https://learn.unity.com/tutorial/chasing-the-player

using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform player;// Inspector field to add FirstPersonPlayer
    static Animator anim;// Variable to hold the AnimationController
    //public float distanceFromPlayer;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();//Assign anim variable the AnimatorController
    }

    // Update is called once per frame
    void Update()
    {
        // Establish a variable based on the xyz position of the player
        Vector3 direction = player.position - this.transform.position;

        // Rotate to player
        float angle = Vector3.Angle(direction, this.transform.forward);

        // Distance between NPC and player, if less than 10 rotate NPC to FPC
        // And narrow the sight of vision to 40 degrees
        if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 40)
        {
            
            direction.y = 0;// keep it from tipping over

            // Slerp rotates slowly to player
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false); // Boolians are either true or false
            // Have the NPC go from turning to player at 12 to following player at 3
            if (direction.magnitude > 5)// If length between NPC and player is greater than five move the NPC forward (z)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            // Attack if distance is less than 2.5
            else if(direction.magnitude < 2.5)
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
            }
        }
        else //if player entirely out of range reset to Idle
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isWalking", false);
        }
    }
}
