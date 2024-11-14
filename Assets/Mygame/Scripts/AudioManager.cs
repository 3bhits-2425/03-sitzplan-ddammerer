using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Array of Sounds, which holds the sound data
    [SerializeField] private Sounds[] sounds;

    // speichere eine Referenz zum Singelton
    private AudioManager singelton;

    private void Awake()
    {
        //sicherstellen, dass nur ein Element vom Typ Audiomanager erstellt wird
        if (singelton == null)
        {
            singelton = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sounds oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();

            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;
        }
    }

    public AudioSource FindAudio(string name)
    {
        foreach (Sounds oneSound in sounds)
        {
            if (oneSound.name == name)
            {
                return oneSound.audioSource;
            }
        }
        return null;

    }

    public void managerPlay(string name)
    {
        FindAudio(name).Play();
    }

    public void managerPause(string name)
    {
        FindAudio(name).Pause();
    }

    public void managerStop(string name)
    {
        FindAudio(name).Stop();
    }

}
