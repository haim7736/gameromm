using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Ingame");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("종료");
            Application.Quit();
        }
    }
}
