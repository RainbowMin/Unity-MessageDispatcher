﻿using UnityEngine;
using System;
using System.Collections;


public class TestText : MonoBehaviour {

    void OnEnable()
    {
		MyMessageDispatcher.Instance ().RegisterMessageHandler ((uint)EUIMessage.UITest0, ChangePlay0);
    }

    void OnDisable()
    {
		MyMessageDispatcher.Instance ().UnRegisterMessageHandler ((uint)EUIMessage.UITest0, ChangePlay0);
    }

    public void ChangePlay0(uint iMessageType, object kParam)
    {
        string txt = (string) kParam;
        GUIText text = GetComponent<GUIText>();
        text.text = txt ;
    }
}
