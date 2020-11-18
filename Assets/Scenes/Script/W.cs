using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class W : MonoBehaviour
{
    public GameObject w;

    public Cameramove cameramove;

    public

    bool istrue = false;
    void Start()
    {
        if (w != null)
        {
            w.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (w != null)
        {
            if (cameramove.check == 5)
            {
                w.SetActive(true);

            }
            if (cameramove.check != 5)
            {
                w.SetActive(false);
            }
        }
    }
    
    public void ObjDe()
    {
        Destroy(w);
    }
}
