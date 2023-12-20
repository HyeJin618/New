using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GD : MonoBehaviour
{
    GameObject car; //"car"��� "GameObject"�� ���� ����
    GameObject flag;
    GameObject distance;

    void Start()
    {
       //GameObject.Find ("���̾��Ű�� "���� �ִ�" ������Ʈ �̸�")
       //������Ʈ�� �� �̸����� ã�� ���
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
       // start()���� flag.car�� ã����
            //GameObject.transform.position) 
          //  �� �����פĤ�Ʈ�� ����ġ����(��ǥ��)�� �޾ƿ�

        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}

