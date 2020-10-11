using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerEnd : MonoBehaviour
{
    public GameObject textDisplay;
    public int second = 30;
    public bool takingAway = false;

    public Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + second;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingAway ==false && second>0)
        {
            StartCoroutine(TimeTake());
        }

        if(second ==0)
        {
            Defeat();
        }
    }

    IEnumerator TimeTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        second -= 1;
        textDisplay.GetComponent<Text>().text = "00:" + second;
        takingAway = false;
        

    }

    void Defeat()
    {
       // Debug.Log("looseer");
        SceneManager.LoadScene("End");
    }
}
