using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agachar : MonoBehaviour
{
    [Range(0, 1.0f)]
    [SerializeField] private float velAgacharse = 0.3f;
    [SerializeField] private float alturaDePie = 3f;
    [SerializeField] private float AlturaAgachado = 0.1f;
    public CharacterController controller;

    private bool agachado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!agachado)
            {
                agachado = true;
            }
            else
            {
                agachado = false;
            }
        }
    }

    private void FixedUpdate()
    {
        var desiredHeight = agachado ? AlturaAgachado : alturaDePie;

        if (controller.height != desiredHeight)
        {
            ajustarAltura(desiredHeight);
        }
    }

    private void ajustarAltura(float height)
    {
        // float cam = height / 2;
        controller.height = Mathf.Lerp(controller.height, height, velAgacharse);
        //controller.center = Vector3.Lerp(controller.center, new Vector3(0, cam, 0), velAgacharse);
    }
}
