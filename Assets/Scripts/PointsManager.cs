using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Numerics;

public class PointsManager : MonoBehaviour
{
    //the points for the whole game
    public string points = "0"; 
    //the text GameObject that displays the points in the scene
    public Text pointsDisplay;
    //string that will be added to show if its millions, billions, trillians, ext
    public string numbersAsWords = "";

    int i;

    public Button bruteForceButton;
    public Button countingButton2;

    // Start is called before the first frame update
    void Start()
    {
        pointsDisplay.text = points.ToString();
        bruteForceButton.onClick.AddListener(bruteForceAttack);
        countingButton2.onClick.AddListener(counting2);
    }

    // Update is called once per frame
    void Update()
    {
        timerMethod(10, 1);
        //timerMethod(10, 1, 2);

        roundedPoints = Math.Round(points, 4);
        pointsDisplay.text = roundedPoints.ToString() + " " + writingNumbers(points) + " Points! ";
    }

    //k is the amount of points you wanted added every j seconds
    public int timerMethod(int j, int k)
    {
        if (Time.time > i)
        {
            i += j;
            points += k;
        }

        return i;
    }

    //The game requires variables that are too big for the number data types, so we will use strings.
    //This method will add those strings since we cant add numbers 
    public string addingStrings(string t1, string t2)
    {

        string result = "";

        while (t1 != "" && t2 != "")
        {
            int num1 = char.Parse(t1.Remove(t1.Length - 1)) - '0';
            int num2 = char.Parse(t2.Remove(t2.Length - 1)) - '0';
            result = (num1 + num2 + '0') + result;
        }
        if (t1 != "")
        {
            result = t1 + result;
        }
        else if(t2 != "")
        {
            result = t2 + result;
        }

        return result;
    }

    //This method take in a string of numbers and rounds them
    public string roundPoints(string i)
    {
        return i;
    }

    //This method writes out the words for numbers ex 4.5 "hundred", or 4.5 "million"
    public string writingNumbers(string i)
    {
        if (i.Length < 7)
        {
            numbersAsWords = "";
        }

        else if (i.Length >= 7 && i.Length < 10)
        {
            numbersAsWords = "Million";
        }

        return numbersAsWords;
    }

    //This is where all the button methods will go

    //Game button: brute force attack
    public void bruteForceAttack()
    {
        points += 1;
    }

    public void counting2()
    {
        points += 10;
    }

    //This is for adding or subtracting the amount of a button cost after you use a button.
    //It takes in the button id whitch lets you know what button it is, and either a 0 or 1 for adding or subtracting
    public void changingValuetoButtons(int buttonID, int addOrSub)
    {
        if (buttonID == 1 && addOrSub == 0)
        {
            
        }
        if (buttonID == 1 && addOrSub == 1)
        {

        }


    }
}
