//using UnityEngine;
//using System.Collections;

public class Singleton<T> where T : new()
{
	private static T _instance;
	private static object _lock = new object();

	protected Singleton() {}
	public static T Instance()
	{
		if(_instance == null)
		{
			lock(_lock)
			{
				if(_instance == null)
				{
					_instance = new T();
				}
			}
		}
		return _instance;
	}
}

