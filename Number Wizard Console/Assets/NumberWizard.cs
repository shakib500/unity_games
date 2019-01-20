using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update

    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a Number, Don't tell anyone");
        Debug.Log("The highest number you can pick is "+max);
        Debug.Log("The lowest number you can pick is "+min);
        Debug.Log("Tell me if your number is higher or lower than "+guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            Debug.Log(guess);

        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            Debug.Log(max);
            
        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))  
        {
                Debug.Log("Return key was pressed.");
        }
    }
}
