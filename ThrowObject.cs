// https://youtu.be/Xv-c3-IOnM0
//https://answers.unity.com/questions/1434709/how-to-have-pickups-not-spawn-on-top-of-the-player.html
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;//parent pick up to player camera
    public float throwForce = 10;//parent to rigidbody
    bool hasPlayer = false;//to check distance btwn object and player
    bool beingCarried = false;//checks whether object is being carried or not
    private bool touched = false;//in case object hits anything, it is dropped
    public Vector3 objectScale;//can scale object up when picked up - for effect

    // Update is called once per frame
    void Update()
    {
        //checks distance between player and pick up to establish whether or not it can be picked up
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            hasPlayer = true;
            
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            transform.localScale = objectScale;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
            }
            else if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }

    //Pickup has two colliders, so it has physics, but is also a trigger
    private void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
