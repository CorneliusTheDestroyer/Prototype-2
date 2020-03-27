﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(mainCoroutine());
        }
    }

    IEnumerator mainCoroutine()
    {
        Debug.Log("Started at: " + Time.time);

        yield return new WaitForSeconds(5);

        Debug.Log("Finished at: " + Time.time);

        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
