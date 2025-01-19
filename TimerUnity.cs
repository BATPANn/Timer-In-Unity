using UnityEngine;
using UnityEngine.UI;

public class TimerUnity : MonoBehaviour
{

    public Text TimerText; // the actual text
    public float RemainingTime = 60; // The remaining time, Can be changed from everywhere
    public bool TimerIsRunning = false; // Check if timer can be run or not

    // freezing 

    public bool FreezeTime = false; // give ability to freeze time

    // freezing 





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

        if(TimerIsRunning == true)
        {


            if(FreezeTime == false)
            {


                if(RemainingTime > 0)
                {


                    TimerText.color = Color.white; // make the text white

                    RemainingTime -= Time.deltaTime; // decrease by one each second

                    DisplayTime(RemainingTime); // call our function

                    // make it red if less than an amount


                    if(RemainingTime <= 30 && FreezeTime == false)
                    {


                        TimerText.color = Color.red; // change the text to red if lower than 30 secs and time not frozen


                    }



                    // make it red if less than an amount






                }
                else
                {


                    


                    Debug.Log("Time has Run Out");
                    RemainingTime = 0;
                    TimerIsRunning = false;

                    DisplayTime(RemainingTime);



                }







            }
            else if(FreezeTime == true)
            {



                TimerText.color = Color.blue; // make it blue if time is frozen

                DisplayTime(RemainingTime);




            }





        }




        
    }


    void DisplayTime(float timeToDisplay)
    {


        float minutes = Mathf.FloorToInt(RemainingTime / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);


        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }


}
