using UnityEngine;
using System;
using System.Collections;


public class TestText1 : MonoBehaviour {

    void OnEnable()
    {
        //MessageDispatcher.Instance().RegisterMessageHandler((uint)EUIMessage.UITest0, ChangePlay0);
		MyMessageDispatcher.Instance ().RegisterMessageHandler ((uint)EUIMessage.UITest0, ChangePlay0);
    }

    void OnDisable()
    {
        //MessageDispatcher.Instance().UnRegisterMessageHandler((uint)EUIMessage.UITest0, ChangePlay0);
		MyMessageDispatcher.Instance ().UnRegisterMessageHandler ((uint)EUIMessage.UITest0, ChangePlay0);
    }

    public void ChangePlay0(uint iMessageType, object kParam)
    {
        string txt = (string) kParam;
        GUIText text = GetComponent<GUIText>();
        text.text = txt ;
    }
}
