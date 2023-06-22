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

    }

    // Update is called once per frame
    void Update()
    {
        SpawnFunction();
    }
    public void SpawnFunction()
    {
        if (Prefab1Exists == false) // If object does not exist...
        {
            Prefab1Exists = true; // It now exists and...
            Instantiate(myPrefab1, new Vector3(2, 4, -17), Quaternion.identity); // The object is instantiated.
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
        if (Cauldron.GetComponent<PotionMix>().CheckMatch1() == true) // If current mix matches with this recipe...
        {
            Instantiate(myPrefab4, new Vector3(4, 4, -17), Quaternion.identity); // Spawn the corresponding potion.
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
