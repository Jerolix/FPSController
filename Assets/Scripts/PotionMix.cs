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
    public int failedPots = 0;

    List<int> currentMix = new List<int>();
    List<int> recipe1 = new List<int>() { 0, 1, 2 };
    List<int> recipe2 = new List<int>() { 0, 0, 2 };
    List<int> recipe3 = new List<int>() { 0, 1, 1 };
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FailedPots();

    }

    public void FailedPots() 
    {
        if (failedPots > 2)
        {
            currentMix.Clear();
            failedPots = 0;
            Debug.Log("Pot Cleared ");
        }
    }

    public bool CheckMatch1()
    {
        if (currentMix.Count != recipe1.Count)
        {
            return false;
        }
        currentMix.Sort();
        for (int a = 0; a < currentMix.Count; a++)
        {
            if (currentMix[a] != recipe1[a])
            {
                failedPots++;
                return false;
            }

        }
        currentMix.Clear();
        return true;
    }

    public bool CheckMatch2()
    {
        if (currentMix.Count != recipe2.Count)
        {
            return false;
        }
        currentMix.Sort();
        for (int b = 0; b < currentMix.Count; b++)
        {
            if (currentMix[b] != recipe2[b])
            {
                failedPots++;
                return false;
            }

        }
        currentMix.Clear();
        return true;
    }

    public bool CheckMatch3()
    {
        if (currentMix.Count != recipe3.Count)
        {
            return false;
        }
        currentMix.Sort();
        for (int c = 0; c < currentMix.Count; c++)
        {
            if (currentMix[c] != recipe3[c])
            {
                failedPots++;
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
