using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdController : MonoBehaviour {

    ThirdModel thirdModelScript;
    ThirdView thirdViewScript;

    private void Awake()
    {
        thirdModelScript = GetComponent<ThirdModel>();
        thirdViewScript = GetComponent<ThirdView>();
    }

    private void Update()
    {
        thirdModelScript.timer = thirdModelScript.timer - 10 * Time.deltaTime;
        if (thirdModelScript.timer > 0)
        {
            if (thirdModelScript.ThirdWin == true)
            {
                thirdModelScript.textTime.fontSize = 150;
                thirdModelScript.textTime.text = "You\nWon!";
            }
            else
            {
                thirdModelScript.timeWon = thirdModelScript.timer;
                thirdModelScript.textTime.text = (Mathf.Abs(thirdModelScript.timer / 10)).ToString("0");
            }

        }
        else
        {
            if (thirdModelScript.ThirdWin == false)
            {

                thirdModelScript.textTime.fontSize = 150;
                thirdModelScript.textTime.text = "Time's\nUp!";
                if (thirdModelScript.timer <= -10)
                {
                    SceneManager.LoadScene(1);
                }

            }
        }
        if (thirdModelScript.ThirdWin == true && thirdModelScript.timer <= thirdModelScript.timeWon - 20)
        {
            SceneManager.LoadScene(0);
        }

        if (DragNDropCode.itemsLeft == 0)
        {
            thirdModelScript.ThirdWin = true;
        }
    }

    void Start () {
        RandomizeNumber();
        thirdViewScript.InstantiateFirst();
        thirdModelScript.firstNumber = thirdModelScript.randomNumber;

        RandomizeNumber();
        thirdViewScript.InstantiateSecond();
        thirdModelScript.secondNumber = thirdModelScript.randomNumber;

        RandomizeNumber();
        thirdViewScript.InstantiateThird();
    }

    void RandomizeNumber()
    {
        do
        {
            thirdModelScript.randomNumber = Random.Range(1, 4);
        } while (thirdModelScript.randomNumber == thirdModelScript.firstNumber || thirdModelScript.randomNumber == thirdModelScript.secondNumber);
        switch (thirdModelScript.randomNumber)
        {
            case 1:
                thirdModelScript.randomPosition = 3.2f;
                break;
            case 2:
                thirdModelScript.randomPosition = 0f;
                break;
            case 3:
                thirdModelScript.randomPosition = -3.2f;
                break;
        }

    }
}
