using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zone_fin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);

        //if (other.tag == "Player")
        if (other.transform.parent != null && other.transform.parent.tag == "Player")
        {
            Debug.Log("Bravo c'est la fin de la course ! ");
        }
        else
        {
//            Debug.Log("NOPE !");
        }
    }
}
