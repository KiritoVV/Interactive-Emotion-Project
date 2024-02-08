using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public RawImage fade;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;


            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
