using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextBlink : MonoBehaviour
{
    public Text flashingText;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "Press to Start";
            yield return new WaitForSeconds(.5f);
        }
    }
}
