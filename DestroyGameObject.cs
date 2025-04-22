using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{

	void OnTriggerEnter(Collider other)
	{
		//Destroy(other.gameObject);

		//Destroy any game object but the player
		if (other.tag == "Player")
        {
			other.transform.position = new Vector3(0, 2, 0);//reset the player position
        }
		else
		{ 
		Destroy(other.gameObject);
		}

		//Destroy specific game objects based on the game objects tag
		//tags can be assigned in the game object's inspector
		/*if (other.tag == "Enemy") {
			Destroy (other.gameObject);//flushed from game memory
		}*/
	}
}
