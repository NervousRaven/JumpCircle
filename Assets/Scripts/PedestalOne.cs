using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PedestalOne : MonoBehaviour
{
    public Text PedestalOnetxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandomSpawner.shopPoint==true){
        PedestalOnetxt.text = "Old Boots $50";
        }
        if(transform.position.y<=-500){
            Destroy(this);
        }
    }
}
