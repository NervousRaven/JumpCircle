using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteEnemy : MonoBehaviour
{
[SerializeField]private float damage;
[SerializeField]private float fallSpeed;
private float velocity = 0.002f;
public GameObject whiteBlock;

private void Start(){
transform.position = new Vector2(transform.position.x,transform.position.y-0.5f);
}

private void OnTriggerEnter2D(Collider2D collision){

    if(collision.tag=="Player"){
        collision.GetComponent<Health>().TakeDamage(damage);
    }
}

private void Update(){
    
    if(transform.position.y>=-100){

    velocity += velocity/5;
    transform.position =  new Vector2(transform.position.x,transform.position.y-fallSpeed-velocity);

    }

}




}
