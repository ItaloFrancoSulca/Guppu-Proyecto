using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class line : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgCollider;

    List<Vector2> points;

    GameObject groupPoints;

    GameObject[] pointsToJoin = new GameObject[13];

    
    public int collidedWith = 0;

    private SecondModel _secondModel;

    private void Awake()
    {
        _secondModel= GameObject.FindGameObjectWithTag("MiniGame Controller").GetComponent<SecondModel>();
        groupPoints = GameObject.Find("PointsToJoin");
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "points")
        {
            print("true");
            Destroy(other);
            if (collidedWith < 12)
            {
                collidedWith += 1;
                pointsToJoin[collidedWith] = other.gameObject;
                


            }

            if (collidedWith == 12)
            {
                Destroy(this.gameObject);
                _secondModel.guppuFace.SetActive(true);
                groupPoints.SetActive(false);
                _secondModel.WinSecond = true;
            }
        }
    }
    


    public void UpdateLine(Vector2 mousePos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(mousePos);
            return;
        }

        if (Vector2.Distance(points.Last(), mousePos) > 0.1f)
            SetPoint(mousePos);

        
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);

        if (points.Count > 1)
            edgCollider.points = points.ToArray();
    }

    

    
}
