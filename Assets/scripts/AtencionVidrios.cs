using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AtencionVidrios : MonoBehaviour
{
    public TextMeshProUGUI Texto;

    void Start()
    {
        print(Texto.text);
        if (Texto.text.Contains("¡Felicidades!"))
        {
            Texto.text = "- Cuidado con las ventanas";
        }
        else
        {
            if(!Texto.text.Contains("Cuidado con las ventanas"))
            {
                Texto.text += "\n- Cuidado con las ventanas";
            }

        }

    }
}
