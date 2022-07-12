using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public double points = 0;
    public Text pointsDisplay;

    int i;
    int j;
    int k;
    int l;

    public Button countingButton;
    public Button countingButton2;

    void Start()
    {
        pointsDisplay.text = points.ToString();
        countingButton.onClick.AddListener(counting);
        countingButton2.onClick.AddListener(counting2);
    }

    // Update is called once per frame
    void Update()
    {

        timerMethod(5, 1);
        //timerMethod(10, 1, 2);

        pointsDisplay.text = points.ToString() + " Points!";

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

    //this is another timer method.k is the amount of points you wanted added every j seconds with a modifier of l  
    public int timerMethod(int j, int k, int l)
    {
        if (Time.time > i)
        {
            i += (j*(1/l));
            points += k;
        }

        return i;
    }

    public void counting()
    {
        points += 1;
    }

    public void counting2()
    {
        points += 10;
    }


}
