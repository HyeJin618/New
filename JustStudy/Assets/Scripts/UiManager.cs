using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    // ��ƴ� ���� ���� ���ϸ� �۷ι�(�ƹ������� ����)�̿��� ����?
    // ���� ����(local) ���� ����������
    [HideInInspector]    
    public int TestValue = 1;

    public Image bg;

    [SerializeField]
    Color _color;

    bool isChanged;

    Sprite test_01; //�⺻���� �Ǿ� �ִ� �̹���

    [SerializeField]
    Sprite test_02; //���� ��ų ��

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
