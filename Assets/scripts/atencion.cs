using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class atencion : MonoBehaviour
{
    public TextMeshProUGUI Texto;

    void Start()
    {
        print(Texto.text);
        if(Texto.text.Contains("¡Felicidades!"))
        {
            Texto.text = "- Cuidado con las luces";
        }
        else
        {
        Texto.text += "\n- Cuidado con las luces";
        }

    }

}
