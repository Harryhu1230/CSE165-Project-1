using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDummy : MonoBehaviour
{

    public GameObject dummyPrefab;

    public float respawnTime = 1f;

    private float respawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(dummyWave());
    }

    private void spawnDummy()
    {
        GameObject a = Instantiate(dummyPrefab) as GameObject;

        respawnLocation = Random.Range(0, 2);

        if (respawnLocation == 0)
        {
            a.transform.position = new Vector3(-2f, 3f, 12f);
        }
        else
        {
            a.transform.position = new Vector3(2f, 3f, 12f);
        }

        respawnTime = Random.Range(3, 7);
    }

    IEnumerator dummyWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnDummy();
        }
    }
}
