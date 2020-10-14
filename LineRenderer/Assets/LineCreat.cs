using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreat : MonoBehaviour
{
    public GameObject prefabLine;
    lineRendererScript lineScript;
    Vector2 mousePos;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject lineActive = Instantiate(prefabLine);
            lineScript = lineActive.GetComponent<lineRendererScript>();
        }
        if(Input.GetMouseButtonUp(0))
        {
            lineScript = null;
        }       
        if(lineScript != null)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            lineScript.drawLine(mousePos);
        }
    }
}
