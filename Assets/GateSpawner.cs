using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public GameObject gatePrefab;
    public float distanciaEntreGates = 20f;
    public float zSpawn = 20f;
    private float proximoSpawn;

    void Start()
    {
        proximoSpawn = zSpawn;
        SpawnGate();
    }

    void Update()
    {
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
            puerta.operador = (OperatorType)Random.Range(0, 4);
            puerta.valor = Random.Range(2, 10);
        }
    }
}