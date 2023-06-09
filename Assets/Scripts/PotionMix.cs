using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PotionMix : MonoBehaviour
{
    public GameObject objectSpawner;

    private int ingredientsAdded = -1; // How many things have been added since failed or succeeded potion
    
    private int[] currentMix = new int[3];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // THIS PART IS GOOD FOR DETECTING WHEN SOMETHING IS DROPPED ON - BUT NOTHING BEYOND THAT.
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Debug.Log("Ingredient " + other.name + " detected. ");
            ObjectGrabbable OG = other.gameObject.GetComponent<ObjectGrabbable>();
            int numberOfDroppedItem = OG.itemTypeNumber;
            ingredientsAdded++; // This ups a tally

            if (other.name == "0-GoblinToe(Clone)")
            {
                objectSpawner.GetComponent<ObjectSpawner>().Prefab1Exists = false;
                Destroy(other.gameObject);
            }

            else if (other.name == "1-Bloodberry(Clone)")
            {
                objectSpawner.GetComponent<ObjectSpawner>().Prefab2Exists = false;
                Destroy(other.gameObject);
            }

            else if (other.name == "2-Newt's Eye(Clone)")
            {
                objectSpawner.GetComponent<ObjectSpawner>().Prefab3Exists = false;
                Destroy(other.gameObject);
            }
        }

        
    }
}
