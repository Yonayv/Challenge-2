using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer;
    private float timeLimit = 1.0f;
    private float cooldown = 1;

    // Update is called once per frame
    void Update()
    {
        // creates timer
        timer += Time.deltaTime;
        // On spacebar press, send dog and timer is greater than time limit
        if (Input.GetKeyDown(KeyCode.Space)&& timer > timeLimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //reset timer
            timer = 0;
            cooldown = 1;
        }
        if (cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
    }
}
