using UnityEngine;

public class Quit : MonoBehaviour
{//Delay
    [SerializeField]
    private float delayBeforeLoading = 5f;
    private float timeElapsed;

    // Update is called once per frame
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            Application.Quit();
        }
    }
}
