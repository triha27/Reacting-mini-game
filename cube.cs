using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cu;
    private bool toStop;
    void Start()
    {
        StartCoroutine("colourChange");
        toStop = true;
    }

    // Update is called once per frame
    void Update()
    {
       // ColourChange cb = new ColourChange();
       // cb.change(cu);
       if(Input.GetKeyDown(KeyCode.Space))
        {
            if(toStop)
            StopCoroutine("colourChange");
            else
            {
                StartCoroutine("colourChange");
            }
            toStop = !toStop;
        }
    }
    IEnumerator colourChange()
    {
        ColourChange cb = new ColourChange();
        while(true)
        {
            cb.change(cu);
            yield return new WaitForSeconds(.45F);
        }
    }
}
