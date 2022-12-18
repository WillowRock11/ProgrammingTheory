using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{


    private void OnMouseDown()
    {
        //gameManager.UpdateText(shapeName);
        UpdateName();
        SetShapeColor(.3f, .5f, .1f);
    }


}
