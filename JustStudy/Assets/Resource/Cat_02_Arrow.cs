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
        player = GameObject.Find("player"); //player(�����)�� �̸����� ã�ƿͶ�!
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0); //�����Ӹ��� -0.1f�� ���Ͻ�Ų��
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject); //ȭ�� ������ ���� 
        }

        //�浹����

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
       
    }
}

