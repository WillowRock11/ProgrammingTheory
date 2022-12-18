using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    

    private void OnMouseDown()
    {
        //gameManager.UpdateText(shapeName);
        UpdateName();
        SetShapeColor(.3f, .1f, .5f);
    }
}
