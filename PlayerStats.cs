using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 5f;
    [SerializeField] float PlayerHealth = 100;
    [SerializeField] float PlayerMaxHealth = 100;
    [SerializeField] float PlayerMinHealth = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public float ReturnPlayerStats()
    {
        return PlayerSpeed;
    }
}


