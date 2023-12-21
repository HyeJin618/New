using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        //왼쪽 화살표키 혹은 방향키를 눌렀을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); //왼쪽으로 3만큼 이동한다. x,y,z
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); //오른쪽으로 3만큼 이동한다.
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
