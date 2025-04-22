//https://youtu.be/_xMhkK6GTXA (2018)
//DOES NOT MOVE WITH PLAYER - PICK UP AND THROW ONLY
//Use ThrowObject script to pick up and throw
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float throwForce = 600;//how far thrown compared to its rigid body mass
    Vector3 objectPos;//track the position of the object
    float distance; //to determine how far the player can be to pick it up

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    void Update()
    {
        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        if(distance >= 1f)
        {
            isHolding = false;
        }
        //check if isHolding
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if(Input.GetMouseButton(1))
            {
                //throw
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    void OnMouseDown()//can't be private need to access these values
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions = true;
    }

    void OnMouseUp()
    {
        isHolding = false;
    }
}
