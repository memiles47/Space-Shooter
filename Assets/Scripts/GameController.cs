using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    // Declaration of public variables
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GameObject hazard;
    public Vector3 spawnValues;

    // Start is called just before any of the Update methods is called the first time (Since v1.0)
    public void Start()
    {
        StartCoroutine (SpawnWaves());
    }
    
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                // Declaration of function variables
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}