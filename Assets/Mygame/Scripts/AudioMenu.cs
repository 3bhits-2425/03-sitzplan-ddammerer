using System;
using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudiosource;
    [SerializeField] private GameObject ToggleAudioButton;
    private TMP_Text playPauseButtonText;

    void Awake()
    {
        myAudiosource = GetComponent<AudioSource>();
        ToggleAudioButton = GameObject.Find("ToggleButton");
        playPauseButtonText = ToggleAudioButton.GetComponentInChildren<TMP_Text>();

    }

    public void Update()
    {
        //if (myAudiosource.isPlaying)
        //{
        //    playPauseButtonText.text = "Stop";
        //}
        //else
        //{
        //    playPauseButtonText.text = "Play";
        //}
    }


    public void PlayAudio() {
        myAudiosource.Play();
    }

    public void PauseAudio() {
        myAudiosource.Pause();
    }

    public void ResetAudio() {
        myAudiosource.Stop();
    }

    public void ToggleAudio()
    {
        if (myAudiosource.isPlaying)
        {
            myAudiosource.Pause();
            playPauseButtonText.text = "Start";

        }
        else
        {
            myAudiosource.Play();
            playPauseButtonText.text = "Stop";

        }
    }
}
