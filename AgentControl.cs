using UnityEngine;
using UnityEngine.AI; //necessary library to use NavMesh

public class AgentControl : MonoBehaviour
{
    public Transform home;//the target
    NavMeshAgent agent;//use the nav mesh component

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }

}
