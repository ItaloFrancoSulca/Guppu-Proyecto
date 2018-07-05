using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SecondModel : MonoBehaviour {

	public GameObject linePrefab;

    public line activeLine;

    public GameObject lineInScene;

    public GameObject guppuFace;

    public float timer;
    public float timeWon;

    public Text textTime;

    public bool WinSecond = false;
    public bool mouseBeenUp = false;

    public LineRenderer _lineRenderer;

}
