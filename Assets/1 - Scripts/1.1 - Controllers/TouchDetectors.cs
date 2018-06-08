using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetectors : MonoBehaviour {

    static public bool upButtomTouched;
    static public bool downButtomTouched;
    static public bool rightButtomTouched;
    static public bool leftButtomTouched;
	

    //Touched
    public void IsUpTouched()
    {
        upButtomTouched = true;
    }

    public void IsDownTouched()
    {
        downButtomTouched = true;
    }

    public void IsRightTouched()
    {
        rightButtomTouched = true;
    }

    public void IsLeftTouched()
    {
        leftButtomTouched = true;
    }

    //Untouched
    public void IsUpUntouched()
    {
        upButtomTouched = false;
    }

    public void IsDownUntouched()
    {
        downButtomTouched = false;
    }

    public void IsRightUntouched()
    {
        rightButtomTouched = false;
    }

    public void IsLeftUntouched()
    {
        leftButtomTouched = false;
    }
}
