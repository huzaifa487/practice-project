using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    int mycode = 5;
    float myname = (1.2f);
    string mymom = ("my momname is ");
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mycode + myname + mymom
        );

    }

    // Update is calle;d once per frame
    void Update()
    {
        Debug.Log(mycode + mymom + mymom);

    }
}
