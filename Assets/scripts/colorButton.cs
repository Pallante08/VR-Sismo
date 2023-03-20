using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorButton : MonoBehaviour
{
    public GameObject botoncito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        botoncito.GetComponent<Image>().color = Color.green;
    }

    public void OriginalColor()
    {
        botoncito.GetComponent<Image>().color = Color.white;
    }

}
