using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaLuciaFakeController : CasaLuciaController
{
    override protected void LoadData(){
        score = 100;
        int[] range = {1,2};
        alive = new List<int>(range);
        int[] range2 = {3,4};
        waiting = new LinkedList<int>(range2);
        chosenPath = Path.Abbatoggia;
    }

    override protected void SaveData(){}
}
