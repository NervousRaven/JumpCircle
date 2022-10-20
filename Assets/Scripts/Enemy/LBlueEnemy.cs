using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBlueEnemy : MonoBehaviour
{
[SerializeField]private float damage;
[SerializeField]private float fallSpeed;

private void OnTriggerEnter2D(Collider2D collision){

    if(collision.tag=="Player"){
        collision.GetComponent<Health>().TakeDamage(damage);
    }

}
private void Update(){
    if(transform.position.y>= -4.9f){
transform.position =  new Vector2(transform.position.x,transform.position.y-fallSpeed);
    }
    else{

transform.position =  new Vector2(transform.position.x-fallSpeed,transform.position.y);
        
    }
}
}
