using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuEvent : MonoBehaviour
{
    [SerializeField] UnityEvent OnMenu;
    [SerializeField] UnityEvent Onreanud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Time.timeScale == 1f)
        {
            pausar();
            Time.timeScale = 0f;
           
        }
        else if (Time.timeScale == 0f)
        {
            if (Input.GetButtonDown("Fire2"))
            {
            reanudar();
            Time.timeScale = 1f;
            }
            if (Input.GetButtonDown("Fire3"))
            {
                Time.timeScale = 1f;
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }

        }
    }

    public void pausar()
    {
        OnMenu.Invoke();
    }

    public void reanudar()
    {
        Onreanud.Invoke();
    }
}
