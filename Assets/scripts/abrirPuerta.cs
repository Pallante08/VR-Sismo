using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirPuerta : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void Activar()
    {
        animator.SetTrigger("Activar");
    }
}
