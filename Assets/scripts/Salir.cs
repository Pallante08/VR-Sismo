using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        print("Salio");
    }
}
