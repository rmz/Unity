using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
      //Destroy specific game objects based on the game objects tag
	  //tags can be assigned in the game object's inspector
      if (other.tag == "AI")
      {
        Destroy(other.gameObject);
      }
    }
  }