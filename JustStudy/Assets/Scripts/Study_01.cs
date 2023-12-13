using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Study_01 : MonoBehaviour
{
    int test;

    void Awake()      {
        UnityEngine.Debug.LogError("Awake");
    }

    void Start()        {
        UnityEngine.Debug.Log("Start");
    }

   void OnDestroy()
    {
        UnityEngine.Debug.Log("À¸¾Ç! ¹üÀÎÀº ¹Ú¹Î¼ö,...");
    }
    void Update()
    {//Debug.Log("Update");
    }
}