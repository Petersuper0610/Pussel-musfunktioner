using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QUIT : MonoBehaviour
{

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }


  
}