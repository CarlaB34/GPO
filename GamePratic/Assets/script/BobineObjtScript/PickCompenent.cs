using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCompenent : MonoBehaviour
{/*

    public GameObject pickableObject;
    public GameObject posBobine;
    public bool take = false;
    private bool hasPlayer = false;
    private GameObject player;

    // private bool beingCarried = false;
    private void Update()
    {
        GetOnReceptacle();
        GetPick();
    }

    //choisir l'objet
    public void GetPick()
    {
        //check distance entre objet et joueur
        float dist = Vector3.Distance(pickableObject.transform.position, player.transform.position);

        //si - ou = 2 unité de distance = on peut ramasser
        if (dist <= 1f)
        {
            hasPlayer = true;


        }
        else
        {
            hasPlayer = true;

        }

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (!take)
            {
                if (hit.transform.GetComponent<PickComponent>())
                {
                    hit.transform.GetComponent<PickComponent>().GetPicked();
                    take = true;
                }
            }
        }
    }
}
    void GetOnReceptacle()
    {

        if (take)
        {
            if (transform.GetComponent<Receptacle>())
            {
                bool success = transform.GetComponent<Receptacle>().GetAttached(posBobine.transform.GetComponentInChildren<PickObject>().gameObject);
                // transform.parent = null;

                if (success == true)
                {
                    take = false;
                }
            }
        }


    }*/
}
