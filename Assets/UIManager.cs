using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Pantallas")]
    public GameObject pantallaMenu;
    public GameObject pantallaGameOver;
    public GameObject pantallaYouWon;
    public GameObject hud;

    [Header("HUD")]
    public Slider sliderPower;
    public TMP_Text textoPower;

    void Awake() { Instance = this; }

    void MostrarSolo(GameObject pantalla)
    {
        pantallaMenu.SetActive(pantalla == pantallaMenu);
        pantallaGameOver.SetActive(pantalla == pantallaGameOver);
        pantallaYouWon.SetActive(pantalla == pantallaYouWon);
        hud.SetActive(pantalla == hud);
    }

    void Start()
    {
        string resultado = PlayerPrefs.GetString("resultado", "ninguno");
        if (resultado == "win") { PlayerPrefs.DeleteKey("resultado"); MostrarSolo(pantallaYouWon); }
        else if (resultado == "lose") { PlayerPrefs.DeleteKey("resultado"); MostrarSolo(pantallaGameOver); }
        else MostrarSolo(pantallaMenu);
    }

    public void BotonPlay() 
    { 
        Debug.Log("Boton Play apretado");
        SceneManager.LoadScene("Game"); 
    }
    public void BotonReintentar() { SceneManager.LoadScene("Game"); }
    public void BotonGiveUp() { MostrarSolo(pantallaMenu); }
    public void BotonTooEasy() { MostrarSolo(pantallaMenu); }

    public void ActualizarPower(float valorActual, float valorMaximo)
    {
        sliderPower.maxValue = valorMaximo;
        sliderPower.value = valorActual;
        textoPower.text = "Power: " + valorActual;
    }
}