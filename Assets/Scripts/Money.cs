using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    public Text txt;
    public static double money;
    private float moneyDisplay = (float)money;
    private void Update(){
        if(RandomSpawner.shopPoint==false){
    money=money+0.011;
        }
    moneyDisplay = (float)money;
    txt.text = "$"+Mathf.Round(moneyDisplay).ToString();
    }
}
