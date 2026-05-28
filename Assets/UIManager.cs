using UnityEngine;
using UnityEngine.UI;
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

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        MostrarMenu();
    }

    public void MostrarMenu()
    {
        pantallaMenu.SetActive(true);
        pantallaGameOver.SetActive(false);
        pantallaYouWon.SetActive(false);
        hud.SetActive(false);
    }

    public void BotonPlay()
    {
        pantallaMenu.SetActive(false);
        hud.SetActive(true);
    }

    public void BotonReintentar()
    {
        pantallaGameOver.SetActive(false);
        pantallaYouWon.SetActive(false);
        hud.SetActive(true);
    }

    public void BotonGiveUp()
    {
        MostrarMenu();
    }

    public void BotonTooEasy()
    {
        MostrarMenu();
    }

    public void ActualizarPower(float valorActual, float valorMaximo)
    {
        sliderPower.maxValue = valorMaximo;
        sliderPower.value = valorActual;
        textoPower.text = "Power: " + valorActual;
    }
}