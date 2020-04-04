using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obst;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public float startWait;
    int randomEnenmy;
    public float leftedge=-9.5f;
    public float rightedge=10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSpawner());   
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        InvokeRepeating("mOve",0,1);
        

    }
    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            randomEnenmy = Random.Range(0, 5);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),1, Random.Range(-spawnValues.z, spawnValues.z));

            if (spawnPosition.x < leftedge)
            {
                transform.position = new Vector3(leftedge, transform.position.y, transform.position.z);
            }
            if (spawnPosition.x > rightedge)
            {
                transform.position = new Vector3(rightedge, transform.position.y, transform.position.z);
            }

            Instantiate(obst[randomEnenmy],spawnPosition + transform.TransformPoint(0,0,0),transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
    void mOve()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
    }
}
