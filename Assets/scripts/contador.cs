using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class contador : MonoBehaviour
{
    public int tiempoInicial;
    private float segundos = -1;

    private TextMeshProUGUI Tiempo;
    private float tiempoDelFrame = 0f;
    private float mostrar = 0f;

    [SerializeField] UnityEvent OnInicio;
    [SerializeField] UnityEvent OnBorrar;

    void Start()
    {
        Tiempo = GetComponent<TextMeshProUGUI>();
        mostrar = tiempoInicial;

        ActualizarReloj(tiempoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDelFrame = Time.deltaTime * segundos;
        mostrar += tiempoDelFrame;
        ActualizarReloj(mostrar);
    }

    public void ActualizarReloj(float tiempo)
    {
        int seg = 0;
        string MostrarTexto;
        
        if(tiempo < 0.8)
        {
            Inicio();
        }
        if(tiempo >= 1)
        {
        seg = (int)tiempo;

        MostrarTexto = seg.ToString("0");

        Tiempo.text = MostrarTexto;


        }

        if(tiempo < 3)
        {
            Borrar();
        }

    }

    public void Inicio()
    {
        OnInicio.Invoke();
    }

    public void Borrar()
    {
        OnBorrar.Invoke();
    }
}
