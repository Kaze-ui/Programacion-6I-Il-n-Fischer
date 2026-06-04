using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float velocidadLateral = 5f;
    public float poder = 10f;
    public float limiteX = 2f;
    public TMP_Text textoPoder;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * input * velocidadLateral * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limiteX, limiteX);
        transform.position = pos;

        if (textoPoder != null)
            textoPoder.text = "" + Mathf.RoundToInt(poder);
    }

    public void AplicarOperador(float valor, OperatorType op)
    {
        switch (op)
        {
            case OperatorType.MULTIPLY: poder *= valor; break;
            case OperatorType.DIVIDE: poder /= valor; break;
            case OperatorType.ADD: poder += valor; break;
            case OperatorType.SUBTRACT: poder -= valor; break;
        }
    }
}

public enum OperatorType { MULTIPLY, DIVIDE, ADD, SUBTRACT }