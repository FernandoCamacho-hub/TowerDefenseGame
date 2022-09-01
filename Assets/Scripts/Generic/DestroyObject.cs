using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float _destroyDelay;
    [SerializeField] private UnityEvent OnDestroy;
    
    public void DestroyWithDelay()
    {
        OnDestroy?.Invoke();
        Destroy(gameObject, _destroyDelay);
    }
}
