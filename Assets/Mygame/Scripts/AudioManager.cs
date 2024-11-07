using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Array of Sounds, which holds the sound data
    [SerializeField] private Sounds[] sounds;

    private void Awake()
    {
        foreach (Sounds oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();

            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;
        }
    }
}
