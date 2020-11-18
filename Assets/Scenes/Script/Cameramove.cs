using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
public class Cameramove : MonoBehaviour
{
    public Camera cam;
    public Text a;
    public int check;
    public GameObject upbutton;
    public GameObject Downbutton;
    bool building;

    // Start is called before the first frame update
    void Start()
    {
        check = 0;
        a.text = "입원실";
        upbutton.SetActive(false);
        Downbutton.SetActive(false);
        building = true;


    }

    // Update is called once per frame
    void Update()
    {
        
        if(check == 2)
        {
            upbutton.SetActive(true);
        }
        else
        {
            upbutton.SetActive(false);
        }

        if (check == 8)
        {
            Downbutton.SetActive(true);
        }
        else
        {
            Downbutton.SetActive(false);
        }

        switch (check)
        {
            case 0:
                cam.transform.position = new Vector3(0, 0, -10);
                a.text = "101호 입원실";
                break;
            case 1:
                cam.transform.position = new Vector3(22.03f, 0, -10);
                a.text = "2동 로비";
                break;
            case 2:
                cam.transform.position = new Vector3(43.83f, 0, -10);
                a.text = "2동 계단";
                break;
            case 3:
                cam.transform.position = new Vector3(65.58f, 0, -10);
                a.text = "2동 지하1층 복도";
                break;
            case 4:
                cam.transform.position = new Vector3(0, -12, -10);
                a.text = "2동 조제실";
                break;
            case 5:
                cam.transform.position = new Vector3(22.03f, -12, -10);
                a.text = "2동 창고";
                break;
            case 6:
                cam.transform.position = new Vector3(43.83f, -12, -10);
                a.text = "야외 주차장";
                break;
            case 7:
                cam.transform.position = new Vector3(65.58f, -12, -10);
                a.text = "정문";
                break;
            case 8:
                cam.transform.position = new Vector3(22.03f, 12, -10);
                a.text = "1동 가는길";
                break;
            case 9:
                cam.transform.position = new Vector3(43.83f, 12, -10);
                a.text = "1동 계단";
                break;
            case 10:
                cam.transform.position = new Vector3(65.58f, 12, -10);
                a.text = "1동 로비";
                break;
        }
    }

    public void onLeft()
    {
        if (building)
        {
            check--;
            if (check <= 0)
            {
                check = 0;
            }
        }
        else
        {
            check--;
            if (check <= 8)
            {
                check = 8;
            }
        }
    }
    public void onRight()
    {
        if (building)
        {
            check++;
            if (check >= 7)
            {
                check = 7;
            }
        }else
        {
            check++;
            if (check >= 10)
            {
                check = 10;
            }
        }
    }
    public void onUP()
    {
        building = false;
        check = 8;
    }

    public void onDown()
    {
        Debug.Log("C");
        building = true;
        check = 2;
    }
}
