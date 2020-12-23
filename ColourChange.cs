using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange 
{
   public void change(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
