using UnityEngine;
using System.Collections;

public class TestButton : MonoBehaviour {

    void OnGUI()
    {
        if(GUI.Button(new Rect(100, 100, 100, 50), "Play 0"))
        {
            MessageDispatcher.Instance().SendMessage((uint)EUIMessage.UITest0, 1);
        }
    }
}
