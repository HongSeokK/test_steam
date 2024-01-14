using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class testSteam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SteamManager.Initialized)
        {
            Debug.Log("Init!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
