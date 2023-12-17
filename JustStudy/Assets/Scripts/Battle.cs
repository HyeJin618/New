using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;
using UnityEditor.VersionControl;
public class Battle : MonoBehaviour
{
    public Text MonHP;
    public Text ChrHP;
    public Button AttackBtn;
    public Text Message;
    public Text turn;

    int clickNum = 1;
    int monhp = 2000;
    int chrhp = 1000;
    int monattack = 200;
    int chrattack = 200;
    int criticalAttack = 250;

    System.Random critical = new System.Random();

    public void Attackclick()
    {
        if (clickNum % 2 == 1)
        {
            int A = critical.Next(1, 10);
            ChrHP.text = chrhp.ToString();

            if (chrhp < 500)
            {
                turn.text = clickNum.ToString() + "턴";
                chrhp = 750;
                ChrHP.text = chrhp.ToString();
                Message.text = "포션 사용";
            }
            else if (A >= 7)
            {
                turn.text = clickNum.ToString() + "턴";
                monhp -= chrattack;
                MonHP.text = monhp.ToString();
                Message.text = "몬스터가" + chrattack.ToString() + "의 데미지를 입었다.";
            }
            else if (A < 7)
            {
                turn.text = clickNum.ToString() + "턴";
                monhp -= criticalAttack;
                MonHP.text = monhp.ToString();
                Message.text = "몬스터에게" + criticalAttack.ToString() + "의 치명적인 데미지를 입혔다.";
            }

        }
        else if (clickNum % 2 == 0)
        {
            turn.text = clickNum.ToString() + "턴";
            chrhp -= monattack;
            ChrHP.text = chrhp.ToString();
            Message.text = "내가" + monattack.ToString() + "의 데미지를 입었다.";

        }
        if (monhp <= 0)
        {
            MonHP.text = "0";
            chrhp = 1000;
           Message.text = "몬스터를 처치했다!";
            clickNum = 0;
            turn.text = clickNum.ToString() + "턴";
            clickNum = 1;
            ChrHP.text = chrhp.ToString();
            monhp = 2000;

        }
        else
        {
            clickNum++;
        }
    }
}
