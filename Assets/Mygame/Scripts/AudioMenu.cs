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
        //myAudiosource.Play();
        FindAnyObjectByType<AudioManager>().managerPlay("test");
    }

    public void PauseAudio() {
        //myAudiosource.Pause();
        FindAnyObjectByType<AudioManager>().managerPause("test");

    }

    public void ResetAudio() {
        //myAudiosource.Stop();
        FindAnyObjectByType<AudioManager>().managerStop("test");
    }

    public void ToggleAudio() {
        if (myAudiosource.isPlaying) {
            FindAnyObjectByType<AudioManager>().managerPause("test");
            playPauseButtonText.text = "Start";
        } else {
            FindAnyObjectByType<AudioManager>().managerPlay("test");
            playPauseButtonText.text = "Stop";

        }
    }
}
