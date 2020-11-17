using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outdoorimage : MonoBehaviour
{
    public GameObject ODI;
    
    void Start()
    {
        ODI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ODI.SetActive(true);
    }
}
