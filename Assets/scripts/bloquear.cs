using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bloquear : MonoBehaviour
{
    [SerializeField] UnityEvent OnBloq;
    [SerializeField] UnityEvent OffBloq;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("entro");
            bloqueo();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("salio");
            desbloqueo();
        }
    }

    public void bloqueo()
    {
        OnBloq.Invoke();
    }

    public void desbloqueo()
    {
        OffBloq.Invoke();
    }

}
