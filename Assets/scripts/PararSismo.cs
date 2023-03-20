using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PararSismo : MonoBehaviour
{
    [SerializeField] UnityEvent OffEvent;
    [SerializeField] UnityEvent Offsismo;
    private float cont = 0;
    private int seg = 1;



    private void OnTriggerStay(Collider other)
    {
        cont += Time.deltaTime * seg;
        print(cont);
        if (cont >= 10)
        {
            Detsismo();
            if(cont >= 11)
            {
            parar();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(cont < 10)
        {
            cont = 0;
        }
    }

    public void parar()
    {
        OffEvent.Invoke();
    }

    public void Detsismo()
    {
        Offsismo.Invoke();
    }

}
