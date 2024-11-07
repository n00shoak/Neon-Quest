using UnityEngine;
using UnityEngine.Events;

public class FOE_General_Update : MonoBehaviour
{
    public UnityEvent toUpdate;

    public void CallUpdate()
    {
        toUpdate.Invoke();
    }
}
