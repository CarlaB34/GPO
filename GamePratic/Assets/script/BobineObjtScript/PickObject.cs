using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{



    public Transform player;
    //position ou va la bobine sur le player
    public Transform posBobine;
    public GameObject receptacle;
    public float pickDistance = .2f;


    // private TargetObject tO;

    [SerializeField]
    private bool hasPlayer = false;
    private bool beingCarried = false;

    private float pickUPRangeToRecpt = 3f;

    private void Start()
    {

        Cursor.visible = false;
        receptacle.SetActive(false);
       

    }
    public void Update()
    {
        //check distance entre objet et joueur
        float dist = Vector3.Distance(transform.position, player.transform.position);

        //si - ou = 2 unité de distance = on peut ramasser
        if (dist <= pickDistance)
        {
            hasPlayer = true;

        }
        else
        {
            hasPlayer = false;

        }

        InputController();
    }

    public void InputController()
    {
        //si on peut ramasser et qu'on appuie sur E = on portera l'objet
        if (hasPlayer && Input.GetKeyDown(KeyCode.E) && beingCarried == false && player.GetComponent<DetectionToPut>().pickObject == null)
        {
            Debug.Log("alut");
            //this = moi meme objet
            player.GetComponent<DetectionToPut>().pickObject = this;



            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = new Vector3(posBobine.position.x, posBobine.position.y, posBobine.position.z);
            transform.parent = player;
            beingCarried = true;

        }

    }
}


