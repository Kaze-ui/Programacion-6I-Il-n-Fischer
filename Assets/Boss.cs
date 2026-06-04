using UnityEngine;

public class Boss : MonoBehaviour
{
    public float poderRequerido = 50f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();

            if (player.poder >= poderRequerido)
            {
                Debug.Log("Ganaste! Poder: " + player.poder);
                GameManager.Instance.GanarJuego();
            }
            else
            {
                Debug.Log("Perdiste! Poder: " + player.poder);
                GameManager.Instance.PerderJuego();
            }
        }
    }
}