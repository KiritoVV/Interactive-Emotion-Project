using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillBlock : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    public RawImage Jumpscare;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(Teleporter());
        }
    }
    IEnumerator Teleporter()
    {
        Jumpscare.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}
