using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBlock : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(Teleporter());
        }
    }
    IEnumerator Teleporter()
    {
        yield return new WaitForSeconds(10f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}
