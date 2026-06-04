using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public GameObject gatePrefab;
    public float distanciaEntreGates = 20f;
    public float zSpawn = 20f;
    private float proximoSpawn;
    private float tiempoTranscurrido = 0f;

    void Start()
    {
        proximoSpawn = zSpawn;
        SpawnGate();
    }

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (transform.position.z <= proximoSpawn)
        {
            SpawnGate();
            proximoSpawn -= distanciaEntreGates;
        }
    }

    void SpawnGate()
    {
        GameObject gate = Instantiate(gatePrefab, new Vector3(0, 0, proximoSpawn), Quaternion.identity);
        MultiplierGate[] puertas = gate.GetComponentsInChildren<MultiplierGate>();

        foreach (MultiplierGate puerta in puertas)
        {
            // 80% sumas y restas, 20% multiplicaciones y divisiones
            if (Random.value < 0.8f)
            {
                puerta.operador = Random.value < 0.5f ? OperatorType.ADD : OperatorType.SUBTRACT;
                puerta.valor = tiempoTranscurrido > 30f
                    ? Random.Range(100, 999)
                    : Random.Range(10, 99);
            }
            else
            {
                puerta.operador = Random.value < 0.5f ? OperatorType.MULTIPLY : OperatorType.DIVIDE;
                int[] numerosRaros = { 3, 6, 7, 8, 11, 12, 13, 17, 19 };
                puerta.valor = numerosRaros[Random.Range(0, numerosRaros.Length)];
            }

            puerta.ActualizarTexto();
        }
    }
}