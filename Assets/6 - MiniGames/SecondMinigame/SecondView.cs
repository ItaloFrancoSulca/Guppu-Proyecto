using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondView : MonoBehaviour {

    SecondModel _secondModel;

    private void Awake()
    {
        _secondModel = GetComponent<SecondModel>();
    }

    public void ShowTime()
    {
        _secondModel.textTime.text = (Mathf.Abs(_secondModel.timer / 10)).ToString("0");
    }

    public void YouWonText()
    {
        _secondModel.textTime.fontSize = 50;
        _secondModel.textTime.text = "You\nWon!";
    }

    public void TimesUpText()
    {
        _secondModel.textTime.fontSize = 50;
        _secondModel.textTime.text = "Time's\nUp!";
    }

    public void YouLose()
    {
        _secondModel.textTime.fontSize = 50;
        _secondModel.textTime.text = "YOU LOSE!";
    }

    public void DrawLine()
    {
        _secondModel.activeLine = Instantiate(_secondModel.linePrefab).GetComponent<line>();
    }

    public void SetLineColor()
    {
        _secondModel._lineRenderer.startColor = Color.red;
        _secondModel._lineRenderer.endColor = Color.red;
    }
}
