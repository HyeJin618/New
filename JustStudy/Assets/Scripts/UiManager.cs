using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    // 루아는 따로 정의 안하면 글로벌(아무데서나 접근)이였음 ㅇㅇ?
    // 지역 변수(local) 따로 해줬을거임
    [HideInInspector]    
    public int TestValue = 1;

    public Image bg;

    [SerializeField]
    Color _color;

    bool isChanged;

    Sprite test_01; //기본으로 되어 있는 이미지

    [SerializeField]
    Sprite test_02; //변경 시킬 것

    [SerializeField]
    TextMeshProUGUI _text;

    int descid

    void Start()
    {
        test_01 = bg.sprite;
    }

 
 
      //  Debug.Log(TestValue);
    public void ChangeColor()
    {
       if (!isChanged)
        {
            bg.sprite = test_02;
            _text.text = "wwwwwwww";
            isChanged = true;
        }
       else
        {
            bg.sprite = test_01;
            _text.text = "wow";
            isChanged = false;  
        }
        
    }
}
