using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioConfig audioConfig;
    public AudioSource audioSource;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        audioSource.volume = audioConfig.volumen;
    }

    public void ReproducirPuerta()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }

    public void CambiarVolumen(float nuevoVolumen)
    {
        audioConfig.volumen = nuevoVolumen;
        audioSource.volume = nuevoVolumen;
    }
}