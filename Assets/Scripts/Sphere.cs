using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    
   

    private void OnMouseDown()
    {
        redValue = blueValue = greenValue = .5f;
        //gameManager.UpdateText(shapeName);
        UpdateName();
        SetShapeColor();
    }
}
