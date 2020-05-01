using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour   
{
    public double currentTime = 0;
    public double startingTime = 900; 

    [SerializeField] GameObject canvas1;
    [SerializeField] GameObject canvas2;
    [SerializeField] GameObject canvas3;
    [SerializeField] public GameObject gameover;
    [SerializeField] public GameObject win;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; 
      
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
        
        if((899 < currentTime) && (currentTime < 900))
        {
            canvas1.gameObject.SetActive(false);
            canvas2.gameObject.SetActive(false);
            canvas3.gameObject.SetActive(false);
            gameover.gameObject.SetActive(false);
            win.gameObject.SetActive(false);
        }
        //10 minutes left 600
        else if ((595 < currentTime)&&(currentTime < 600))
        {
            canvas1.gameObject.SetActive(true);
        }
        else if((590 < currentTime) && (currentTime < 594))
        {
            canvas1.gameObject.SetActive(false);
        }
        //5minutes left 300
        else if ((295 < currentTime) && (currentTime < 300))
        {
            canvas2.gameObject.SetActive(true);
        }
        else if ((290 < currentTime) && (currentTime < 294))
        {
            canvas2.gameObject.SetActive(false);
        }
        //1 minute left 60
        else if ((55 < currentTime) && (currentTime < 60))
        {
            canvas3.gameObject.SetActive(true);
        }
        else if ((50 < currentTime) && (currentTime < 54))
        {
            canvas3.gameObject.SetActive(false);
        }
        //gameover 1
        else if (currentTime < 1)
        {
            gameover.gameObject.SetActive(true);
        }
       

    }
}
