using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruiManager : MonoBehaviour
{
    public Text levelCleared;

    public void Update()
    {
        this.AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("Ganaste, no hay frutas");
            this.levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
