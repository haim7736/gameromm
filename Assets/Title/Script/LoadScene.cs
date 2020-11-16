using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LOingame()
    {
        SceneManager.LoadScene("Ingame");
    }

    public void Qugame()
    {
        Debug.Log("종료");
        Application.Quit();
    }
}
