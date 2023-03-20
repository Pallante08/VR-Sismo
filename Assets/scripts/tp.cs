using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public GameObject player;
    public Transform Target;

    public void Teleport()
    {
        player.transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y + 3f, Target.transform.position.z);
        //player.transform.position = Target.transform.position;
    }
}
