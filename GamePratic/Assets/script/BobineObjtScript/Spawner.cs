using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /* public Transform[] spawnPoints;
     public GameObject[] prefabs;
     public float minTime, maxTime;
     public int numberOfSpawns = 4;

     private float timer = 0f;
     private int lastSpawnPointIndex = -1;
     private void Update()
     {
         if (timer <= 0f)
         {
             SpawnItems();
             ResetTimer();
         }
         timer -= Time.deltaTime;
     }

     private void SpawnItems()
     {
         for (int i = 0; i < numberOfSpawns; i++)
         {
             Transform spawnPoint = GetNextSpawnPoint();
             GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
             Instantiate(prefab, spawnPoint);
         }
     }

     private Transform GetNextSpawnPoint()
     {
         // We want a random index from the error, but not the same as last time.
         // So we at least more one index further and stop one index before the last.
         // The % operator loops back to the beginning of zero, if the index overshoots the array length.
         int index = (lastSpawnPointIndex + Random.Range(1, spawnPoints.Length - 1)) % spawnPoints.Length;
         lastSpawnPointIndex = index;
         return spawnPoints[index];
     }

     private void ResetTimer()
     {
         timer = Random.Range(minTime, maxTime);
     }*/
    /*  public Transform spawnPointsVert, spawnPointsBleu, spawnPointsViolet, spawnPointsRouge;
      public GameObject prefabVert, prefabBleu, prefabViolet, prefabRouge;

      //spawn prefab on per 2 sec
      public float spawnRate = 2f;

      //variable  to set new spawn time
      private float nextSpawn = 0;

      //variable the containt random value
      private int whatToSpawn;

      public bool passer = false;

      private void Update()
      {
          //if time has came
          if(Time.time >nextSpawn)
          {
              //define random value between 1 and 5 (5 exclu)
              whatToSpawn = Random.Range(1, 5);
              //display its value in consool
              Debug.Log(whatToSpawn);
              passer = true;
              //instanciate a prefab depending on random value
              switch(whatToSpawn)
              {
                  case 1:
                      Instantiate(prefabVert, spawnPointsVert.transform.position, Quaternion.identity);                
                      break;
                  case 2:
                      Instantiate(prefabBleu, spawnPointsBleu.transform.position, Quaternion.identity);
                      break;
                  case 3:
                      Instantiate(prefabViolet, spawnPointsViolet.transform.position, Quaternion.identity);
                      break;
                  case 4:
                      Instantiate(prefabRouge, spawnPointsRouge.transform.position, Quaternion.identity);
                      break;


              }
              passer = false;
              //set next spawn time
              nextSpawn = Time.time + spawnRate;
          }
      }*/

    public Transform[] spawnPoints;
    public GameObject[] prefabs;
    public GameObject[] receptacles;

    public Transform player;
    public Transform posBobine;
  

    private int lastSpawnPointIndex;


    private void Start()
    {
        lastSpawnPointIndex = -1;
        SpawnItems();
    }
    void Spawn(Transform spawnPoint, GameObject prefab)
    {
       GameObject go= Instantiate(prefab, spawnPoint.position, Quaternion.identity);

        //assignation de pickObject vers les prefab pour spawn
        go.GetComponent<PickObject>().player = player;
        go.GetComponent<PickObject>().posBobine = posBobine;
        go.GetComponent<PickObject>().receptacle = receptacles[lastSpawnPointIndex];
    }

    public void SpawnItems()
    {
        
            Transform spawnPoint = GetNextSpawnPoint();
            GameObject prefab = prefabs[lastSpawnPointIndex];
        //permet de pas faire apparaitre a chaque collision avec table
        if(spawnPoint != null)
        {
            Spawn(spawnPoint, prefab);
        }

       
    }

    private Transform GetNextSpawnPoint()
    {
       
        int index = (lastSpawnPointIndex + 1);
       

        if(index >= spawnPoints.Length)
        {

            return null;
        }
        else
        {
            lastSpawnPointIndex = index;
        }
        
    
        return spawnPoints[index];
    }

    //public void Victory()
    //{
    //    if(lastSpawnPointIndex == receptacles.Length)
    //    {
    //        Debug.Log("win!!!");
    //    }
    //}
}


