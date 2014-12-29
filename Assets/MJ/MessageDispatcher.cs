using System.Collections;
using System.Collections.Generic;

public delegate void MessageHandler (uint iMessageType, object arg);

//public class MyMessageDispatcher : Singleton<MyMessageDispatcher>
//{
//	Dictionary<uint, List<MessageHandler>> m_HandlerMap;
//
//	public MyMessageDispatcher()
//	{
//		m_HandlerMap = new Dictionary<uint, List<MessageHandler>> ();
//	}
//
//	public void RegisterMessageHandler(uint iMessageType, MessageHandler handler)
//	{
//		if (handler == null)
//			return;
//		
//
//		if (!m_HandlerMap.ContainsKey (iMessageType)) 
//		{
//			List<MessageHandler> HandlerList = new List<MessageHandler>();
//			HandlerList.Add(handler);
//			m_HandlerMap.Add (iMessageType, HandlerList);
//		} 
//		else 
//		{
//			if(!m_HandlerMap[iMessageType].Contains(handler))
//			{
//				m_HandlerMap[iMessageType].Add(handler);
//			}
//		}
//	}
//
//	public void UnRegisterMessageHandler(uint iMessageType,  MessageHandler handler)
//	{
//		if (handler == null)
//			return;
//
//		if(m_HandlerMap.ContainsKey (iMessageType))
//		{
//			if(m_HandlerMap[iMessageType].Contains(handler))
//			{
//				m_HandlerMap[iMessageType].Remove(handler);
//			}
//		}
//	}
//
//	public void SendMessage(uint iMessageType, object arg)
//	{
//		if(m_HandlerMap.ContainsKey (iMessageType))
//		{
//			foreach(MessageHandler handler in m_HandlerMap[iMessageType])
//			{
//				if(handler != null)
//				{
//					handler.Invoke(iMessageType, arg);//同步调用 
//					//handler.BeginInvoke(iMessageType, arg, ...., ...);//异步调用
//				}
//			}
//		}
//	}
//}

public class MyMessageDispatcher : Singleton<MyMessageDispatcher>
{
	Dictionary<uint, MessageHandler> m_HandlerMap;
	
	public MyMessageDispatcher()
	{
		m_HandlerMap = new Dictionary<uint, MessageHandler> ();
	}
	
	public void RegisterMessageHandler(uint iMessageType, MessageHandler handler)
	{
		if (handler == null)
			return;
		
		
		if (!m_HandlerMap.ContainsKey (iMessageType)) 
		{
			MessageHandler Handlers = handler;
			m_HandlerMap.Add (iMessageType, Handlers);
		} 
		else 
		{
			m_HandlerMap[iMessageType] += handler;
		}
	}
	
	public void UnRegisterMessageHandler(uint iMessageType,  MessageHandler handler)
	{
		if (handler == null)
			return;
		
		if(m_HandlerMap.ContainsKey (iMessageType))
		{
			m_HandlerMap[iMessageType] -= handler;
		}
	}
	
	public void SendMessage(uint iMessageType, object arg)
	{
		if(m_HandlerMap.ContainsKey (iMessageType))
		{
			if(m_HandlerMap[iMessageType] != null)
			{
				m_HandlerMap[iMessageType].Invoke(iMessageType, arg);
			}
		}
	}
}
