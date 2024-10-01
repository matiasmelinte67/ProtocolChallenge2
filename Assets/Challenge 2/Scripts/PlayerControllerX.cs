using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireRate = 1.0f; // Allowing this to be set via the inspector
    private float nextFire = 0; // Tracks the time when the player can fire again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has elapsed since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // Reset nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
