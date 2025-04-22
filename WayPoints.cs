using UnityEngine;

//This project has two WayPoint example scripts
//WaypointController.cs has tutorial links, but does not work as well as
//WayPoints.cs from Unity Learn
//Waypoints.cs is best option
public class WayPoints : MonoBehaviour
{
    //https://learn.unity.com/tutorial/waypoints#
    public GameObject[] waypoints;
    int currentWP = 0;

    public float speed = 5.0f;
    //public float rotSpeed = 5.0f; //speed of rotation

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
            currentWP++;

        if (currentWP >= waypoints.Length)
            currentWP = 0;

       //immediate turn without rotation, no need for rotSpeed variable
       this.transform.LookAt(waypoints[currentWP].transform);
       //Quaternion stores a rotation
       //Quaternion lookatWP = Quaternion.LookRotation(waypoints[currentWP].transform.position - this.transform.position);

       //this.transform.rotation = Quaternion.Slerp(transform.rotation, lookatWP, rotSpeed * Time.deltaTime);

       this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
