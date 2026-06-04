using UnityEngine;

public class LevelScroller : MonoBehaviour
{
    public float velocidad = 5f;
    public float aceleracion = 0.5f;
    public float velocidadMaxima = 20f;

    void Update()
    {
        velocidad = Mathf.Min(velocidad + aceleracion * Time.deltaTime, velocidadMaxima);
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);
    }
}