using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Cat_02_Arrow : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.Find("player"); //player(고양이)를 이름으로 찾아와라!
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0); //프레임마다 -0.1f씩 낙하시킨다
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject); //화면 밖으로 나온 
        }

        //충돌판정

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
       
    }
}

