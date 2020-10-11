using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//bonne place
public class TargetObject : MonoBehaviour
{
    /*[SerializeField]
    private Transform[] targetBobines;

   
    public bool isPicked = false;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist1 = Vector3.Distance(targetBobines[0].transform.position, player.position);
       
        if(dist1 <= 1f)
        {
            Debug.Log("halut");
            isPicked = true;
        }
        //else
        //{
        //    isPicked = false;
        //}
        
        float dist2 = Vector3.Distance(targetBobines[1].transform.position, player.position);
        if (dist2 <= 1f)
        {
            isPicked = true;
        }
        //else
        //{
        //    isPicked = false;
        //}
        float dist3 = Vector3.Distance(targetBobines[2].transform.position, player.position);
        if (dist3 <= 1f)
        {
            isPicked = true;
        }
        //else
        //{
        //    isPicked = false;
        //}
        float dist4 = Vector3.Distance(targetBobines[3].transform.position, player.position);
        if (dist4 <= 1f)
        {
            isPicked = true;
        }
        //else
        //{
        //    isPicked = false;
        //}
    }*/

    public int nbrOBject = 4;
    private int activatedObject = 0;
   // public UnityEvent onPuzzleSolved = new UnityEvent();
    public void OnGoodPlacement()
    {
        activatedObject += 1;


        //if (nbrOBject == activatedObject)
        //{
        //    onPuzzleSolved.Invoke();
        //}
    }
}
