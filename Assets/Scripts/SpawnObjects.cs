using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject SpawnIce;
    public GameObject SpawnBarrel;
    public GameObject SpawnTire;
    public GameObject SpawnWalrus;

    float PositionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        int random = Random.Range(1, 5);

        PositionX = Random.Range(3, -3f);
        transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);

        if (random == 1)
        {
            Instantiate(SpawnIce, transform.position, transform.rotation);
        }
        else if (random == 2)
        {
            Instantiate(SpawnBarrel, transform.position, transform.rotation);
        }
        else if (random == 3)
        {
            Instantiate(SpawnTire, transform.position, transform.rotation);
        }
        else if(random == 4)
        {
            Instantiate(SpawnWalrus, transform.position, transform.rotation);
        }
    }
}
