using UnityEngine;
using System.Collections;

public class TestButton : MonoBehaviour {

    void OnGUI()
    {
		string text;
		text = GUI.TextField (new Rect (0, 100, 100, 50), "Please Press text");

        if(GUI.Button(new Rect(100, 100, 100, 50), "Show"))
        {
            //MessageDispatcher.Instance().SendMessage((uint)EUIMessage.UITest0, 1);
			MyMessageDispatcher.Instance().SendMessage(0, text);
        }
    }
}
