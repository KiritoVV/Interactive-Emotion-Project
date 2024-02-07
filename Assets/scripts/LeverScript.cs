using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeverScript : MonoBehaviour
{
    public GameObject interaction_text;
    public GameObject crosshair;
    public Transform lever;
    private bool isPulled;

    // Start is called before the first frame update
    void Start()
    {
        interaction_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            interaction_text.SetActive(true) ;

            if (isPulled == false && Input.GetKeyDown(KeyCode.E))
            {
                isPulled = true;

                lever.Rotate(Time.deltaTime * 0, -60, 0);

                interaction_text.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            if(isPulled == false)
            {
                interaction_text.SetActive(false);
            }
        }
    }

}
