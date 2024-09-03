using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int velocidadeGiro = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag "Player")
        {
            
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (velocidadeGiro * Time.deltaTime), Space.World);
    }
}  