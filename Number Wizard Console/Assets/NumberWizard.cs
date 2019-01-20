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
        Debug.Log("Pick a Number as guess.");
        Debug.Log("The highest number you can pick is "+max);
        Debug.Log("The lowest number you can pick is "+min);
        Debug.Log("Press a button acoordingly to your guess number "+guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {

        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("Is it higher or lower than " + guess);
        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("Is it higher or lower than " + guess);

        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))  
        {
                Debug.Log("Return key was pressed.");
        }
    }
}
