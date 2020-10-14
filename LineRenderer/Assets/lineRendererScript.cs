using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
//Şükrü Çay 
public class lineRendererScript : MonoBehaviour
{
    public  LineRenderer lineRD;
    public EdgeCollider2D edgeCollider;

    List<Vector2> points;

    public void drawLine(Vector2 mousePosition)
    {
        // Eğer iki nokta arası yok ise vector2 değeri x=0,y=0 döndürüyor. 
        // Daha sonra newPoint methoduna yönlendiriliyor.
        if(points==null)
        {
            points = new List<Vector2>();
            newPoint(mousePosition);
            return;
        }
        //Point1 ve Point2 arasındaki mesafe .1f 'den büyük ise pointleri al ve newPoint methoduna point değerini parametre olarak gönderiyoruz.
        if(Vector2.Distance(points.Last(),mousePosition)>.1f)
        {
            newPoint(mousePosition);
        }
    }
    void newPoint(Vector2 point)
    {
        points.Add(point);
       // lineRD.positionCount = points.Count;
        lineRD.numPositions = points.Count;
        lineRD.SetPosition(points.Count - 1, point);
        if(points.Count>1)
        {
            edgeCollider.points = points.ToArray();
        }
        
    }
}
