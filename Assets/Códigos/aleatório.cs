using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public GameObject myPrefab;
    public Transform[] spawnPosition;
    private GameObject[] spawnZones;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Instancia um novo objeto apenas se uma condição específica for atendida
        // Exemplo: a cada 2 segundos
        if (Time.frameCount % 90 == 0) // Aproximadamente a cada 2 segundos
        {
            int i = Random.Range(0, spawnPosition.Length);
            Instantiate(myPrefab, spawnPosition[i].position, spawnPosition[i].rotation);
            spawnZones = GameObject.FindGameObjectsWithTag("AsteroidSpawn");
        }
    }
}