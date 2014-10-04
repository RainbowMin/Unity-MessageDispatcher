using UnityEngine;
using System;
using System.Collections;


public class TestText : MonoBehaviour {

    void OnEnable()
    {
        MessageDispatcher.Instance().RegisterMessageHandler((uint)EUIMessage.UITest0, ChangePlay0);
    }

    void OnDisable()
    {
        MessageDispatcher.Instance().UnRegisterMessageHandler((uint)EUIMessage.UITest0, ChangePlay0);
    }

    public void ChangePlay0(uint iMessageType, object kParam)
    {
        int i = (int) kParam;
        GUIText text = GetComponent<GUIText>();
        text.text = "Play" + i ;
    }
}
