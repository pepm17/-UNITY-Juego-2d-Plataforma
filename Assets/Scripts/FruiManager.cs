using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruiManager : MonoBehaviour
{
    public void Update()
    {
        this.AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("Ganaste, no hay frutas");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
