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
        Color color = fade.color;
        color.a = 0;
        fade.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Color color = fade.color;
            if (color.a <= 1f)
            {
                fade.gameObject.SetActive(true);
                color.a += 1f * Time.deltaTime;
                fade.color = color;
                Cursor.lockState = CursorLockMode.None;


                if (color.a <= 0f)
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
                }
            }
        }
        Debug.Log("Tester");
    }
}
