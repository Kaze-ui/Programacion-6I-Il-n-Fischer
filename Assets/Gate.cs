using UnityEngine;
using TMPro;

public abstract class Gate : MonoBehaviour
{
    public float valor;
    public OperatorType operador;
    public TMP_Text textoGate;

    void Start()
    {
        if (textoGate != null)
            textoGate.text = GetLabel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Apply(other.GetComponent<Player>());
        }
    }

    public abstract void Apply(Player player);
    public abstract string GetLabel();
}