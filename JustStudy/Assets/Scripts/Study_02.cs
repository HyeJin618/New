using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

 public string DamageResult(long money)
    {
        string returnValue = null;
        float _money;
        if (money > 100000000)
        {
            _money = (float)(money / 100000000);
            returnValue = _money + "B";
        }
        else if (money >1000000)
        {
            _money = (float)(money / 1000000);
            returnValue = _money + "M";
        }

        return returnValue;
    }


}
