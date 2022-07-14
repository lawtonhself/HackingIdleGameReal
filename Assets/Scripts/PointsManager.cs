using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Numerics;

public class PointsManager : MonoBehaviour
{
    //the points for the whole game
    public double points = 0;
    //the points for the whole game, but rounded for easier displaying
    public double roundedPoints = 0;
    //the text variable that displays the points in the Text object
    public Text pointsDisplay;
    //string that will be added to show if its millions, billions, trillians, ext
    public string numbersAsWords = "";

    int i;

    public Button countingButton;
    public Button countingButton2;

    public String t1 = "";
    public String t2 = "";
    public String t3 = "";

    // Start is called before the first frame update
    void Start()
    {
        pointsDisplay.text = points.ToString();
        countingButton.onClick.AddListener(bruteForceAttack);
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

    //This method writes out the words for numbers ex 4.5 "hundred", or 4.5 "million"
    public string writingNumbers(double i)
    {
        if (i < 1000000)
        {
            numbersAsWords = "";
        }

        else if (i >= 1000000 && i < 1000000000)
        {
            numbersAsWords = "Million";
        }

        return numbersAsWords;

    }

    //The game requires variables that are too big for the number data types, so we will use strings.
    //This method will add those strings since we cant add numbers 
    public String addingStrings(String t1, String t2)
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

    //This is for increasing the amount of a button cost after you use a button
    public void changingValuetoButtons(int buttoneNumber, int addOrSub)
    {
        if (buttoneNumber == 1 && addOrSub == 0)
        {
            
        }
        if (buttoneNumber == 1 && addOrSub == 1)
        {

        }


    }
}
