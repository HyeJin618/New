using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0;  // ȸ�� �ӵ�   

    void Start()
    {
        // �����ӷ���Ʈ�� 60���� �����Ѵ�
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ� //�̰� Ȱ��ȭ �Ǿ� ������ ���콺�� �����ִ��� Ȯ���ϴ� ��
        if (Input.GetMouseButtonDown(0)) //���콺�� "������ ��" ����
        {
            this.rotSpeed = 10;
        }


        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��, rotSpeed�� ȸ�� �ӵ�, this ���� ��
        transform.Rotate(0, 0, this.rotSpeed);

        //�귿�� ���ӽ�Ų��
        //rotSpeed *= 0.96f;
        
        //���� �ӵ��� 0.11���� �۾����� ���������� �ӵ��� 0���� ����
        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
            //�귿�� ���ҽ�Ų��
            rotSpeed *=  0.96f;
        }
    }
}
