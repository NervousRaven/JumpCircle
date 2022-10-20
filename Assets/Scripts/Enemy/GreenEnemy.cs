using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemy : MonoBehaviour
{
[SerializeField]private float damage;
[SerializeField]private float fallSpeed;
private float heightCap = -4.9f;
private bool hitGround = false;
private bool left = false;


private void OnTriggerEnter2D(Collider2D collision){

    if(collision.tag=="Player"){
        collision.GetComponent<Health>().TakeDamage(damage);
    }
}
private void Awake(){

    if(Random.Range(0f,1f) >= 0.5f){
        left=true;
    }
}
private void Update(){
    if(hitGround==false){
    if(transform.position.y>= heightCap){
transform.position =  new Vector2(transform.position.x,transform.position.y-fallSpeed);
    }
    else{
       heightCap = 0.5f;
       hitGround=true;
    }
    }
    else{
if(transform.position.y>= heightCap){
        heightCap = -4.9f;
        if(left==false){
transform.position =  new Vector2(transform.position.x+fallSpeed*fallSpeed*4f,transform.position.y-fallSpeed*fallSpeed*9f); 
        }
        else{
transform.position =  new Vector2(transform.position.x-fallSpeed*fallSpeed*4f,transform.position.y-fallSpeed*fallSpeed*9f); 
        }
}
    else{
       heightCap = 0.5f;
       if(left==false){
        Invoke("rightUp", 0.5f);
    }
    else{
        Invoke("leftUp", 0.5f);
    }
    }
}
}
private void rightUp(){

transform.position =  new Vector2(transform.position.x+fallSpeed*fallSpeed*4f,transform.position.y+fallSpeed*fallSpeed*9f);

}
private void leftUp(){

transform.position =  new Vector2(transform.position.x-fallSpeed*fallSpeed*4f,transform.position.y+fallSpeed*fallSpeed*9f);

}
}
