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

public class Ran_pick : MonoBehaviour
{ 
    public Text Message;
    public Button Start;

    int gold1;
    int emerald1;
    int ruby1;

    
    
    public void BoxOpen()
    {
        for (int box = 1; box < 101; box++)
        {
            int randValue;
            randValue = Random.Range(0, 3);

            int BoxNum;
            BoxNum = Random.Range(1, 101);
           
            if (randValue == 0)
            {
                gold1 += BoxNum; }
          
            else if (randValue == 1)
                        {
                ruby1 += BoxNum; }
            
            else if (randValue==2)
            {
                emerald1 += BoxNum;
            }
           
        }
        Message.text = "��尡" + gold1.ToString() + "��"+
        "���޶��尡" + ruby1.ToString() + "��"+
        "���" + emerald1.ToString() + "��";
    }
        }
       
    



    

    