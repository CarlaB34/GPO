using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectionToPut : MonoBehaviour
{

    //public List<PickObject> pickObjects = new List<PickObject>();
    
    public PickObject pickObject;
    public Spawner spawner;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "table"  && pickObject!=null)
        {
         
            pickObject.receptacle.gameObject.SetActive(true);
            spawner.SpawnItems();
            
            //detrui le game object sur lequel y'a le script pickobjcect
            Destroy(pickObject.gameObject);
           
        }
        
    }
}