using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, launchVelocity));
        }
    }
}
