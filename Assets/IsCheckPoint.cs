using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCheckPoint : MonoBehaviour
{
    //public bool Is_passed = false;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.transform.parent != null && other.transform.parent.tag == "Player")
        if (other.tag == "Player_Collider" ) //&& !Is_passed)
        {
        //    Is_passed = true;

            CheckPoint checkpoint = this.GetComponentInParent<CheckPoint>();
            checkpoint.NombreCheckPoint--;

            Debug.Log("hop, un checkpoint de passé !");
            Debug.Log(checkpoint.NombreCheckPoint);
            Debug.Log(this.name + " vs " + other.name);
            if (checkpoint.NombreCheckPoint<1)
            {
                Debug.Log("Il ne reste plus de checkpoint, direction la ligne d'arrivée !");
            }
        }
    }
}