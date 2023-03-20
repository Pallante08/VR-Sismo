using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class temblor : MonoBehaviour
{
    public GameObject GameObjectToShake;
    public float shakeD;
    public float decreP = 1f;
    private float cont = 0;
    private int seg = 1;

    [SerializeField] UnityEvent Evento;
    bool flag = true;
    bool flagText = true;

    public TextMeshProUGUI Texto;


    private void FixedUpdate()
    {
        if (flag)
        {
            if(decreP < shakeD) {
                StartCoroutine(shakeGameObjectCOR(GameObjectToShake, shakeD, decreP, false));
            decreP = decreP + 1 * Time.deltaTime;
                if (flagText)
                {
                    if (decreP >= 30)
                    {
                        if (Texto.text.Contains("¡Felicidades!"))
                        {
                            Texto.text = "- Intente resguardarse lo antes posible";
                            flagText = false;
                        }
                        else
                        {
                            Texto.text += "\n- Intente resguardarse lo antes posible";
                            flagText = false;
                        }
                    }
                }
            }
            else
            {
                cont += Time.deltaTime * seg;
                if (cont >= 1)
                {
                llamar();
                flag = false;
                }
            }
        }

    }


    IEnumerator shakeGameObjectCOR(GameObject objectToShake, float totalShakeDuration, float decreasePoint, bool objectIs2D = false)
    {
        Transform objTransform = objectToShake.transform;
        Vector3 defaultPos = objTransform.position;
        Quaternion defaultRot = objTransform.rotation;

        float counter = 0f;

        const float speed = 0.01f;


        const float angleRot = 0.1f;


        while (counter < 1)
        {
            counter += Time.deltaTime;
            float decreaseSpeed = speed;


           if(Time.timeScale == 1)
            {
                objTransform.position = defaultPos + UnityEngine.Random.insideUnitSphere * decreaseSpeed;
                objTransform.rotation = defaultRot * Quaternion.AngleAxis(UnityEngine.Random.Range(-angleRot, angleRot), new Vector3(1f, 1f, 1f));
            }

            yield return null;


        }
    }

    public void llamar()
    {
        Evento.Invoke();
    }
}
