using System;
using UnityEngine;

public class Singleton<T> where T : class, new()
{
    private static T _instance;

    public static T Instance()
    {
        if (Singleton<T>._instance == null)
        {
            Singleton<T>._instance = Activator.CreateInstance<T>();
            if (Singleton<T>._instance == null)
            {
                Debug.LogError("Failed to create the instance of " + typeof(T) + " as singleton!");
            }
        }
        return Singleton<T>._instance;
    }

    public static void Release()
    {
        if (Singleton<T>._instance != null)
        {
            Singleton<T>._instance = null;
        }
    }
}
