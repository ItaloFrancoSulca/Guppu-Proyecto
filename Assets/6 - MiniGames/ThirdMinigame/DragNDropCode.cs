using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DragNDropCode : MonoBehaviour
{
    private bool dragging = false;
    private float distance;
    
    static public int itemsLeft = 6;
    
    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag==this.gameObject.tag){
            itemsLeft = itemsLeft - 1;
            Destroy(this.gameObject);
            Destroy(other.gameObject);

        }

    }

    
    

}