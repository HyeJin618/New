using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0;  // 회전 속도   

    void Start()
    {
        // 프레임레이트를 60으로 고정한다
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정한다 //이게 활성화 되어 있으면 마우스가 눌려있는지 확인하는 것
        if (Input.GetMouseButtonDown(0)) //마우스를 "눌렀을 때" 실행
        {
            this.rotSpeed = 10;
        }


        // 회전 속도만큼 룰렛을 회전시킨다, rotSpeed가 회전 속도, this 빼도 됨
        transform.Rotate(0, 0, this.rotSpeed);

        //룰렛을 감속시킨다
        //rotSpeed *= 0.96f;
        
        //도는 속도가 0.11보다 작아지면 강제적으로 속도를 0으로 맞춤
        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
            //룰렛을 감소시킨다
            rotSpeed *=  0.96f;
        }
    }
}
