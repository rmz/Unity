using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float RotateSpeed = 1.5f;//f for float

    // Update is called once per frame
    void Update()
    {
      //https://docs.unity3d.com/ScriptReference/RenderSettings.html
      /*
      It is usually used as a prefix for private variable names as a visual indication that the scope of the variable is private to the class in which it is declared. It thereby increases readability.
      */
      RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
