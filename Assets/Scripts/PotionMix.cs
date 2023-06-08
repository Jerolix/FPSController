using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionMix : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ingredient")
            Debug.Log("Ingredient " + other.name + " detected. ");
        
            

        if (other.gameObject.name == "GoblinToe")
        {
           

            GameObject.Find("GoblinToe").transform.position = new Vector3(4, 4, -17);

        }
    }
}
