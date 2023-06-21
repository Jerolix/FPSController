using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject myPrefab1;
    public GameObject myPrefab2;
    public GameObject myPrefab3;
    public GameObject myPrefab4;
    public GameObject myPrefab5;
    public GameObject myPrefab6;
    public GameObject Cauldron;
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
        if (Cauldron.GetComponent<PotionMix>().CheckMatch1() == true)
        {
            Instantiate(myPrefab4, new Vector3(4, 4, -17), Quaternion.identity);
        }
        if (Cauldron.GetComponent<PotionMix>().CheckMatch2() == true)
        {
            Instantiate(myPrefab5, new Vector3(4, 4, -17), Quaternion.identity);
        }
        if (Cauldron.GetComponent<PotionMix>().CheckMatch3() == true)
        {
            Instantiate(myPrefab6, new Vector3(6, 4, -17), Quaternion.identity);
        }
    }

    
}
