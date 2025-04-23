using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    // Update is called once per frame
    private void Update()
    {
        //load next scene in background - load immediately
        //AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Environment");
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
                //SceneManager.LoadScene(int 1);
                SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
