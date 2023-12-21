using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_03_ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f; //화살 생성 주기
    float delta = 0; //생성 주기 확인
    
    void Update()
    {
        delta += Time.deltaTime; //델타는 기다리는 시간. 
        if (delta > span) 
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6,7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
