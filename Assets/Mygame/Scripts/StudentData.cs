using UnityEngine;

[CreateAssetMenu(fileName = "StudentData", menuName = "Sitzplan/Student", order = 1)]

public class StudentData : ScriptableObject 
{
    public string studentName;
    public Color eyeColor;
    public Sprite studentImage;
    public AudioClip studentClip;



}
