using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public GameObject door;

    public Cameramove cameramove;

    public

    bool istrue = false;
    void Start()
    {
        if (door != null)
        {
            door.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (door != null)
        {
            if (cameramove.check == 1)
            {
                door.SetActive(true);

            }
            if (cameramove.check != 1)
            {
                door.SetActive(false);
            }
        }
    }
    
    public void ObjDe()
    {
        Destroy(door);
    }
}
