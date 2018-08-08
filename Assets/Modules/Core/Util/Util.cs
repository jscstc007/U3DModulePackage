using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Util {

	public static void Log (string format,params object[] objs)
    {
        if (Setting.ShowDebug)
        {
            string data = string.Format(format, objs);
            Debug.Log(data);
        }
    }

    public static void LogWarning(string format, params object[] objs)
    {
        if (Setting.ShowDebug)
        {
            string data = string.Format(format, objs);
            Debug.LogWarning(data);
        }
    }

    public static void LogError(string format, params object[] objs)
    {
        if (Setting.ShowDebug)
        {
            string data = string.Format(format, objs);
            Debug.LogError(data);
        }
    }

    public static void LogException(Exception e)
    {
        if (Setting.ShowDebug)
        {
            Debug.LogException(e);
        }
    }
}
