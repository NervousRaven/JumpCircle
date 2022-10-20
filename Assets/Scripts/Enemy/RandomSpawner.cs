using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public float time;
    public float redEnemySpawnChance = 100f;
    public float blueEnemySpawnChance = 130f;
    public float yellowEnemySpawnChance = 180f;
    public float whiteEnemySpawnChance = 180f;
    public float greenEnemySpawnChance = 300f;
    private bool breakPoint = false;
    public static bool shopPoint = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        time=time+1;

        if(breakPoint==false){
        if(time % redEnemySpawnChance == 0){
            
            int randEnemy= Random.Range(0,enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            GameObject RedClone =Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position,transform.rotation);
            Destroy(RedClone, 2f);
        }
        if(time >= 1000){
            redEnemySpawnChance = 70f;
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            if(time % blueEnemySpawnChance == 0){
                if(Random.Range(0f,1f)>=0.5f){
                GameObject BlueClone = Instantiate(enemyPrefabs[1], spawnPoints[randSpawnPoint].position,transform.rotation);
               Destroy(BlueClone, 4f);
                }
                else{
                GameObject BlueClone = Instantiate(enemyPrefabs[2], spawnPoints[randSpawnPoint].position,transform.rotation);
                 Destroy(BlueClone, 4f);
                }
            }

           
        }

        if(time >= 1700){

            blueEnemySpawnChance = 90f;
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            if(time % yellowEnemySpawnChance == 0){
            
            


                GameObject YellowClone = Instantiate(enemyPrefabs[3], spawnPoints[randSpawnPoint].position,transform.rotation);
            if(CoinEnemy.coinTouched==true){

                CoinEnemy.coinTouched=false;
            }


            Destroy(YellowClone,3f);
            }

        }
        if(time >= 2400){


            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            if(time % greenEnemySpawnChance == 0){
            
            


                GameObject GreenClone = Instantiate(enemyPrefabs[4], spawnPoints[randSpawnPoint].position,transform.rotation);



            Destroy(GreenClone,13f);
            }

        }
            if(time >= 3600){


            int randSpawnPoint = Random.Range(0, spawnPoints.Length);
            if(time % whiteEnemySpawnChance == 0){
            
            


                GameObject WhiteClone = Instantiate(enemyPrefabs[5], spawnPoints[randSpawnPoint].position,transform.rotation);



            Destroy(WhiteClone,1f);
            }

        }
        if(time>= 5000){
            shopPoint=true;
            breakPoint=true;
    }
    }
}
}
