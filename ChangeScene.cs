using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void btn_change_scene(string scene_name)
    {
        // Debug log to check if the scene name is correct
        Debug.Log("Attempting to load scene: " + scene_name);

        // Try to load the scene
        SceneManager.LoadScene(scene_name);
    }
}
