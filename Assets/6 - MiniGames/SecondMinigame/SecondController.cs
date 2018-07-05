using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondController : MonoBehaviour {

    SecondModel _secondModel;
    SecondView _secondView;

    private void Awake()
    {
        _secondModel = GetComponent<SecondModel>();
        _secondView = GetComponent<SecondView>();
    }

    void Start()
    {
        _secondModel.guppuFace.SetActive(false);
    }
    void Update()
    {

        _secondModel.timer = _secondModel.timer - 10 * Time.deltaTime;
        if (_secondModel.timer > 0)
        {
            if (_secondModel.WinSecond == true)
            {
                _secondView.YouWonText();
            }
            else if (_secondModel.WinSecond == false && _secondModel.mouseBeenUp == false)
            {
                _secondModel.timeWon = _secondModel.timer;
                _secondView.ShowTime();
            }

        }
        else
        {
            if (_secondModel.WinSecond == false)
            {
                _secondView.TimesUpText();
                if (_secondModel.timer <= -10)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
        if (_secondModel.WinSecond == true && _secondModel.timer <= _secondModel.timeWon - 20)
        {
            SceneManager.LoadScene(4);
        }
        else if (_secondModel.WinSecond == false && _secondModel.timer <= _secondModel.timeWon - 10)
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_secondModel.mouseBeenUp == false)
            {
                _secondView.DrawLine();
                _secondModel.lineInScene = GameObject.Find("Line(Clone)");
            }
        }


        if (_secondModel.activeLine != null)
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _secondModel.activeLine.UpdateLine(mousePos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _secondModel._lineRenderer = _secondModel.lineInScene.GetComponent<LineRenderer>();
            _secondModel.activeLine = null;
            _secondView.SetLineColor();
            _secondView.YouLose();
            _secondModel.mouseBeenUp = true;
        }


    }
}
