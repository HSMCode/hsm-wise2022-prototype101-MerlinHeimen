using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateDecoys : MonoBehaviour
{
    
    public GameObject Decoy;

    public float spawnPositionX = 10f;
    public float spawnPositionZ = 10f;
    public int SpawnAmount = 4;


    void Start()
    {
        //InvokeRepeating("SpawningDecoy", startDelay, spawnInterval);
        Debug.Log("Press <b>p</b> to spawn Decoys.");
    }

    // Update is called once per frame

    void Update()
    {

        //Instantiate Decoys
        if (Input.GetKeyDown("p"))
        {

            SpawnDecoysParameter(SpawnAmount);


        }

        /*void SpawnDecoys()
        {

                for (int i = 0; i < spawnAmount; i++)
                {
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), 0, Random.Range(-spawnPositionZ, spawnPositionZ));
                    Debug.Log(spawnPosition);

                    //Instantiate(Decoy, spawnPosition, transform.rotation);
                    Instantiate(Decoy, spawnPosition, transform.rotation);
                }

        }*/

        void SpawnDecoysParameter(int SpawnAmount)
        {
            for (int i = 0; i < SpawnAmount; i++)
            {

                //int decoysIndex = Random.Range(0, decoysIndex.Length);

                //generate random spawn position
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), 0, Random.Range(-spawnPositionZ, spawnPositionZ));
                Debug.Log(spawnPosition);

                //instantiate Decoy
                Instantiate(Decoy, spawnPosition, transform.rotation);
            }
        }
    }
}

