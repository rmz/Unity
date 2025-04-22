using UnityEngine;
//requires Video namespace
using UnityEngine.Video;

public class PlayPauseVideo : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    //toggle between play and pause buttons
    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer screenRenderer;//game object with a material

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        screenRenderer.material = pauseButtonMaterial;
    }

    //public void PlayPauseVid()
    void OnMouseDown()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            screenRenderer.material = playButtonMaterial;
        } else
        {
            videoPlayer.Play();
            screenRenderer.material = pauseButtonMaterial;//transparent material
        }
    }
}

