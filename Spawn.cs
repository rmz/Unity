using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject nagent;//nav agent
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnAgent", 1);//1 seconds
    }

    // Update is called once per frame
    void SpawnAgent()
    {
        GameObject na = (GameObject)Instantiate(nagent, this.transform.position, Quaternion.identity);
        //nagent.GetComponent<NavWalk>().target = targetObject.transform;
        Invoke("SpawnAgent", Random.Range(2, 5));//next agent will spawn btwn 2-5sec
    }
}