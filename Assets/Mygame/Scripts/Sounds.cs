using UnityEngine.Audio;
using UnityEngine;

//Klasse Sound muss Serialisierbar sein (auﬂerhalb runtime)

[System.Serializable]
public class Sounds {
    //instancevariable
    public string name;
    public AudioClip clip;
    [Range(0f,1f)]public float volume;          //mir Range bereich der Zahlenw‰rte festlegen
    [Range(0.1f, 3f)]public float pitch;
    [HideInInspector] public AudioSource audioSource;
}
