using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("right"))
            transform.Translate(0.3f, 0, 0);

        if (Input.GetKey ("left"))
            transform.Translate(-0.3f, 0, 0);

        if (Input.GetKey ("down"))
            transform.Translate(0, 0, -0.3f);

        if (Input.GetKey ("up"))
            transform.Translate(0, 0, 0.3f);

        if(Input.GetKey("space"))
            transform.Translate(0, 0.3f, 0);

        if(Input.GetKey("s"))
            transform.Translate(0, -0.3f, 0);
            





    }
}
