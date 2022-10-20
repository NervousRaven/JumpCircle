using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeepMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandomSpawner.shopPoint==true){
            if(transform.position.x <= -6){
            transform.position = new Vector2(transform.position.x+0.1f,transform.position.y);
            }
        }
    }
}
