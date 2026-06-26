using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider sliderVolumen;
    public AudioConfig audioConfig;

    void Start()
    {
        sliderVolumen.value = audioConfig.volumen;
        sliderVolumen.onValueChanged.AddListener(CambiarVolumen);
    }

    public void CambiarVolumen(float nuevoVolumen)
    {
        audioConfig.volumen = nuevoVolumen;
    }
}