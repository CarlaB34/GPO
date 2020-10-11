using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Receptacle : MonoBehaviour
{

    public Transform emplacementObject;
    public GameObject objectpick;
    public UnityEvent onObjectPlaced = new UnityEvent();
   
     public bool GetAttached(GameObject obj)
    {
        if (obj == objectpick)
        {
            objectpick.transform.position = emplacementObject.transform.position;
            objectpick.transform.parent = null;

           
           // onObjectPlaced.Invoke();
            //GameObject.Destroy(obj.GetComponent<PickObject>());

            return true;
        }

        return false;
    }
   
}
