using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ControlColour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject circle, plane; 
    public int score;
    public Color c1;
    public Color c2;
    ColourChange obj = new ColourChange();
    private float r1, b1, g1,r2,b2,g2;
    void Start()
    {
        score = 0;
        obj.change(circle);
        c1 = circle.GetComponent<MeshRenderer>().material.color;
        r1 = c1.r;
        b1 = c1.b;
        g1 = c1.g;
    }

    // Update is called once per frame
    void Update()
    {
         c2 = plane.GetComponent<MeshRenderer>().material.color;
        r2 = c2.r;
        b2 = c2.b;
        g2 = c2.g;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Math.Abs(r1-r2) <= 0.001 && Math.Abs(b1-b2)<= 0.001 && Math.Abs(g1-g2)<=0.001)
            {
                obj.change(circle);
                c1 = circle.GetComponent<MeshRenderer>().material.color;
                r1 = c1.r;
                b1 = c1.b;
                g1 = c1.g;
                score += 10;
            }
        }
    }
}
