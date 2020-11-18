using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public void OnClick()
    {
        SoundManager.instance.PlaySE("feel");
    }
}
