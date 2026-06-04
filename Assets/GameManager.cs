using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState { IDLE, RUNNING, BOSS_FIGHT, WIN, LOSE }
    public GameState estadoActual;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        estadoActual = GameState.RUNNING;
    }

    public void GanarJuego()
    {
        estadoActual = GameState.WIN;
        PlayerPrefs.SetString("resultado", "win");
        SceneManager.LoadScene("Inicio");
    }

    public void PerderJuego()
    {
        estadoActual = GameState.LOSE;
        PlayerPrefs.SetString("resultado", "lose");
        SceneManager.LoadScene("Inicio");
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("Game");
    }
}