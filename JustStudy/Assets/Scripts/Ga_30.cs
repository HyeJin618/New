using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;
using UnityEditor.VersionControl;
using JetBrains.Annotations;

public class Ga_30 : MonoBehaviour
{
    public Text grade1;
    public Text grade2;
    public Text grade3;
    public Text grade4;
    public Text grade5;
    public Button start;

    int _grade1;
    int _grade2;
    int _grade3;    
    int _grade4;
    int _grade5;

    public void Gacha()
    {
        for (int i = 0; i < 31; i++) 
        {
            int randValue;
            randValue = Random.Range(1, 101);

            if (randValue <= 20)
            {
                int Num;
                Num = Random.Range(20, 31);
                _grade1 += Num;
            }
           else if (randValue <= 50)
            {
                int Num;
                Num = Random.Range(15, 26);
                _grade2 += Num;
            }
            else if (randValue <= 90)
            {
                int Num;
                Num = Random.Range(10, 21);
                _grade3 += Num;
            }
            else if (randValue <= 98)
            {
                int Num;
                Num = Random.Range(5, 11);
                _grade4 += Num;
            }
            else if (randValue <= 101)
            {
                int Num;
                Num = Random.Range(1, 6);
                _grade5 += Num;
            }

        }
        if(_grade5 == 0)
        {
            _grade5++;
        }
        grade1.text = "1���" + _grade1.ToString() + "��";
        grade2.text = "2���" + _grade2.ToString() + "��";
        grade3.text = "3���" + _grade3.ToString() + "��";
        grade4.text = "4���" + _grade4.ToString() + "��";
        grade5.text = "5���" + _grade5.ToString() + "��";
    }


}
