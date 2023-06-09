using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject myPrefab1;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    public bool Prefab1Exists = false;
    public bool Prefab2Exists = false;
    public bool Prefab3Exists = false;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(myPrefab1, new Vector3(2, 4, -17), Quaternion.identity);
        //Instantiate(myPrefab2, new Vector3(0, 4, -17), Quaternion.identity);
        //Instantiate(myPrefab3, new Vector3(-2, 4, -17), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnFunction();
    }
    public void SpawnFunction()
    {
        if (Prefab1Exists == false)
        {
            Prefab1Exists = true;
            Instantiate(myPrefab1, new Vector3(2, 4, -17), Quaternion.identity);
        }
        if (Prefab2Exists == false)
        {
            Prefab2Exists = true;
            Instantiate(myPrefab2, new Vector3(0, 4, -17), Quaternion.identity);
        }
        if (Prefab3Exists == false)
        {
            Prefab3Exists = true;
            Instantiate(myPrefab3, new Vector3(-2, 4, -17), Quaternion.identity);
        }
    }

    
}
