//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private LayerMask groundLayer;
    [SerializeField]private LayerMask blockLayer;
    private BoxCollider2D boxCollider;
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpBoost;
  

    private void Start(){


    }
    private void Awake(){
      
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update(){

       if(isBlockedLeft()||isBlockedRight()){
        transform.position = new Vector2(-1*transform.position.x/1.04f,transform.position.y);
       }
        body.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,body.velocity.y);

       
        if(Input.GetKey(KeyCode.Space)&&isGrounded()){
                Jump();
            
        }
    }
    private void Jump(){

        body.velocity = new Vector2(body.velocity.x,speed+jumpBoost);

    }

    private void onCollisionEnter2D(Collision2D collision){

        
    }
    private bool isGrounded(){

        RaycastHit2D raycastHitGround = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,Vector2.down,0.1f,groundLayer);
        return raycastHitGround.collider != null;
    }
        private bool isBlockedLeft(){

        RaycastHit2D raycastHitGround = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,Vector2.left,0.1f,blockLayer);
        
        return raycastHitGround.collider != null;
    }
    private bool isBlockedRight(){
        RaycastHit2D raycastHitGround = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0,Vector2.right,0.1f,blockLayer);
        
         return raycastHitGround.collider != null;
        }

    private void OnTriggerEnter2D(Collider2D collision){

    if(collision.tag=="Coin"){
      

        Destroy(collision.gameObject);
    }
}
}
