using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position, this.transform.position) < 10)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 01f);
            if(direction.magnitude > 5)
            {
                this.transform.Translate(0,0,0.5f);
            }
        }
    }
}
