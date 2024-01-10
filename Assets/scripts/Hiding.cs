using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    public GameObject hideText, stopHideText;
    public GameObject normalPlayer, hidingPlayer;
    public EnemyAi monsterScript;
    public Transform monsterTransform;
    bool interactable, hiding;
    public float loseDistance;

    void Start()
    {
        interactable = false;
        hiding = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(true);
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hideText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
       if(interactable == true)
       {
            if (Input.GetKeyDown(KeyCode.V))
            {
                hideText.SetActive(false);
                hidingPlayer.SetActive(true);
                float distance = Vector3.Distance(monsterTransform, normalPlayer.transform.position);
                {
                    if(monsterScript.chasing == true)
                    {
                        monsterScript.stopChase();
                    }
                }
            }

       }
    }
}
