using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_03_ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f; //ȭ�� ���� �ֱ�
    float delta = 0; //���� �ֱ� Ȯ��
    
    void Update()
    {
        delta += Time.deltaTime; //��Ÿ�� ��ٸ��� �ð�. 
        if (delta > span) 
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6,7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
