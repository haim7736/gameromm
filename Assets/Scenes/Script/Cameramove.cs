using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
public class Cameramove : MonoBehaviour
{
    public Camera cam;
    public Text a;
    public int check;
    
    // Start is called before the first frame update
    void Start()
    {
        check = 0;
        a.text = "입원실";
       
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (check)
        {
            case 0:
                cam.transform.position = new Vector3(0, 0, -10);
                a.text = "입원실";
                break;
            case 1:
                cam.transform.position = new Vector3(22.03f, 0, -10);
                a.text = "로비";
                break;
            case 2:
                cam.transform.position = new Vector3(43.83f, 0, -10);
                a.text = "계단";
                break;
            case 3:
                cam.transform.position = new Vector3(65.58f, 0, -10);
                a.text = "복도";
                break;
            case 4:
                cam.transform.position = new Vector3(0, -12, -10);
                a.text = "조제실";
                break;
            case 5:
                cam.transform.position = new Vector3(22.03f, -12, -10);
                a.text = "창고";
                break;
            case 6:
                cam.transform.position = new Vector3(43.83f, -12, -10);
                a.text = "야외 주차장";
                break;
            case 7:
                cam.transform.position = new Vector3(65.58f, -12, -10);
                a.text = "정문";
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
        if(check >=7)
        {
            check = 7;
        }
    }
}
