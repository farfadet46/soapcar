using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int NombreCheckPoint = 0;

    private void Start()
    {
        // Automatize the list of child
        // each child of this item is a CheckPoint
        NombreCheckPoint = 0; //RAZ

        List<Transform> children = new List<Transform>();
        foreach (Transform tr in transform)
        {
            children.Add(tr);
            NombreCheckPoint++; //mettre à jour le nombre de chckpoint
            tr.gameObject.AddComponent<IsCheckPoint>(); //ajouer un script pour la gestion du checkpoint
            
        }
        Debug.Log("tous les checkpoints ont été mis a jour ! " + NombreCheckPoint); //debug
    }
}
