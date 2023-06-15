using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PotionMix : MonoBehaviour
{
    public GameObject objectSpawner;

    //private int ingredientsAdded = -1; How many things have been added since failed or succeeded potion

    //private int[] currentMix = new int[3];

    List<int> currentMix = new List<int>();
    List<int> recipe = new List<int>() { 0, 1, 2 };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foreach (int item in currentMix)
        //{
                //Debug.Log(item.ToString());
        //}

        //string result = "List contents: ";
        //foreach (int item in currentMix)
        //{
            //result += item.ToString() + ", ";
        //}
        //Debug.Log(result);

    }

    public bool CheckMatch()
    {
        if (currentMix.Count != recipe.Count)
        {
            return false;
        }
        currentMix.Sort();
        for (int i = 0; i < currentMix.Count; i++)
        {
            if (currentMix[i] != recipe[i])
            {
                currentMix.Clear();
                return false;
            }

        }
        currentMix.Clear();
        return true;
    }
    
    public void OnTriggerEnter(Collider other) // THIS PART IS GOOD FOR DETECTING WHEN SOMETHING IS DROPPED ON - BUT NOTHING BEYOND THAT.
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Debug.Log("Ingredient " + other.name + " detected. ");
            ObjectGrabbable OG = other.gameObject.GetComponent<ObjectGrabbable>();
            int numberOfDroppedItem = OG.itemTypeNumber;
            //Debug.Log(OG.itemTypeNumber);
            //ingredientsAdded++; This ups a tally

            if (other.name == "0-GoblinToe(Clone)")
            {
                currentMix.Add(0);
                objectSpawner.GetComponent<ObjectSpawner>().Prefab1Exists = false;
                Destroy(other.gameObject);
            }

            else if (other.name == "1-Bloodberry(Clone)")
            {
                currentMix.Add(1);
                objectSpawner.GetComponent<ObjectSpawner>().Prefab2Exists = false;
                Destroy(other.gameObject);
            }

            else if (other.name == "2-Newt's Eye(Clone)")
            {
                currentMix.Add(2);
                objectSpawner.GetComponent<ObjectSpawner>().Prefab3Exists = false;
                Destroy(other.gameObject);
            }

        }



        
    }
}
