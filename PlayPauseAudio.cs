using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayPauseAudio : MonoBehaviour
{
    public AudioClip interviewAudio;
    public AudioSource interviewClip;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            //stops all sounds
            AudioListener.pause = true;
            //allows one sound to play
            interviewClip.ignoreListenerPause = true;
            interviewClip.Play();
        }

    }
    void OnTriggerExit(Collider collider)
    {
        interviewClip.Pause();//Pause or Stop() can be used
        //switches all sounds back on
        AudioListener.pause = false;
    }
}