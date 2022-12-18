using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string shapeName;
    public float redValue;
    public float greenValue;
    public float blueValue;
    [SerializeField] private Material myMaterial;
    [SerializeField] private Color color;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        SetShapeColor(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateName()
    {       
        gameManager.UpdateText(shapeName);
        //SetShapeColor(.3f, .1f, .1f);
    }

    public void SetShapeColor()
    {
        color.r = redValue;
        color.g = greenValue;
        color.b = blueValue;
        color.a = 1f;
        myMaterial.color = color;
    }

    public void SetShapeColor(float red, float green, float blue)
    {
        if (red > 1 || green > 1 || blue > 1)
        {
            red = green = blue = 0;
        }
        color.r = red;
        color.g = green;
        color.b = blue;
        color.a = 1f;
        myMaterial.color = color;

    }
}
