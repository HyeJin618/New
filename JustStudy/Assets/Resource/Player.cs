using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        //���� ȭ��ǥŰ Ȥ�� ����Ű�� ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); //�������� 3��ŭ �̵��Ѵ�. x,y,z
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); //���������� 3��ŭ �̵��Ѵ�.
                }
    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown() 
    {
        transform.Translate(3, 0, 0);
    }
}
