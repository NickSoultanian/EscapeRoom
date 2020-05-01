using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        SceneManager.LoadScene("Map_v1");
        //GameObject canvasGroup = GameObject.Find("CanvasGroup");
        //Timer timer = canvasGroup.GetComponent<Timer>();
        //timer.gameover.gameObject.SetActive(true);
        //canvasGroup.GetComponent<Timer>().enabled = false; //toggle this script to re-invoke it
        //canvasGroup.GetComponent<Timer>().enabled = true;
    }
}
 