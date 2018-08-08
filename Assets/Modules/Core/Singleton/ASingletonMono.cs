using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASingletonMono<T> : MonoBehaviour where T : Component {

    private static T instance;
    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                instance = FindObjectOfType<T>();
            }
            return instance;
        }
    }

    private Transform cacheTransform;
    public Transform CacheTransform
    {
        get
        {
            if (null == cacheTransform)
            {
                cacheTransform = GetComponent<Transform>();
            }
            return cacheTransform;
        }
    }

    private GameObject cacheGO;
    public GameObject CacheGO
    {
        get
        {
            if (null == cacheGO)
            {
                cacheGO = GetComponent<GameObject>();
            }
            return cacheGO;
        }
    }
}
