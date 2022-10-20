using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEnemy : MonoBehaviour
{
[SerializeField]public static float coin = 0.11f;
public static bool coinTouched = false;

[SerializeField]private float fallSpeed;

private void OnTriggerEnter2D(Collider2D collision){

    if(collision.tag=="Player"){
      
        coinTouched=true;

    }
}
private void Update(){
    if(coinTouched==true){
Money.money+=CoinEnemy.coin;




    }
transform.position =  new Vector2(transform.position.x,transform.position.y-fallSpeed);
}
}
