using UnityEngine;

public class MultiplierGate : Gate
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Apply(other.GetComponent<Player>());
        }
    }

    public override void Apply(Player player)
    {
        player.AplicarOperador(valor, operador);
        Debug.Log("Poder actual: " + player.poder);
    }

    public void ActualizarTexto()
    {
        if (textoGate != null)
            textoGate.text = GetLabel();
    }

    public override string GetLabel()
    {
        switch (operador)
        {
            case OperatorType.MULTIPLY: return "x" + valor;
            case OperatorType.DIVIDE: return "/" + valor;
            case OperatorType.ADD: return "+" + valor;
            case OperatorType.SUBTRACT: return "-" + valor;
            default: return "";
        }
    }
}