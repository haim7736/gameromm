using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect : MonoBehaviour
{

    //Showing UI text
    public Text DialogText;
    //Main Text;
    string originText;
    //SubString Variable
    string subText;

    // Start is called before the first frame update
    void Start()
    {
        originText = "Hi ~WELOCOME TO Development Unity Typing !";
        StartCoroutine("TypingAction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TypingAction()
    {
        for(int i= 0;i<originText.Length; i++)
        {
            yield return new WaitForSeconds(0.1f);

            subText += originText.Substring(0, i);
            DialogText.text = subText;
            subText = "";
        }
        
    }
}
