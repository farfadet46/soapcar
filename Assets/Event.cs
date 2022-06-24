using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            //quitter le jeu
        {
            print("echap key was pressed");
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
            //redemarrer le jeu
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
}
