using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private RocketController rocketPrefab;

    private void Awake()
    {
        
    }

    private void Start()
    {
        SpawnPlayer(rocketPrefab);
    }


    private void SpawnPlayer(RocketController rocketController)
    {

        var _instancePlayer = Instantiate(rocketPrefab, transform.position, Quaternion.identity);

    }
}
