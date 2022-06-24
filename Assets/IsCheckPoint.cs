using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent != null && other.transform.parent.tag == "Player")
        {
            CheckPoint checkpoint = this.GetComponentInParent<CheckPoint>();
            checkpoint.NombreCheckPoint--;

            Debug.Log("hop, un checkpoint de passé !");
            Debug.Log(checkpoint.NombreCheckPoint);

        }
    }
}