using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScene : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(Scene2)
    }
}
