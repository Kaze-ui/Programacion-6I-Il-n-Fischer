using UnityEngine;

[CreateAssetMenu(fileName = "AudioConfig", menuName = "Audio/AudioConfig")]
public class AudioConfig : ScriptableObject
{
    [Range(0f, 1f)]
    public float volumen = 1f;
}