using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Camera cam;
    int check;
    // Start is called before the first frame update
    void Start()
    {
        check = 4;
    }

    // Update is called once per frame
    void Update()
    {

        switch (check)
        {
            case 0:
                cam.transform.position = new Vector3(-0.01f, -0.09f, -10);
                break;
            case 1:
                cam.transform.position = new Vector3(21.79f, -0.09f, -10);
                break;
            case 2:
                cam.transform.position = new Vector3(-0.03f, -11.39f, -10);
                break;
            case 3:
                cam.transform.position = new Vector3(21.67f, -11.39f, -10);
                break;
        }
    }

    public void onLeft()
    {
        check--;
        if(check <= 0)
        {
            check = 0;
        }
    }
    public void onRight()
    {
        check++;
        if(check >=3)
        {
            check = 3;
        }
    }
}
