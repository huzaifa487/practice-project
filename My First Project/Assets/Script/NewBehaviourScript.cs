using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //DATA TYPES

      // VARIABLE DECLARATION (declare krna , memory me jga dena)
      // PATTERN :   

  // Data type  variable name
    int          myInteger;         // whole number store krne k lie            0,  89
    string       myString;      // text store krne k lie variable           "dhsjhgsjfhghg"
    float        myFloat;        // points me number save krne k lie         0.34 , 9.67


    //VARIABLE INITIALIZATION AT THE TIME OF DECLARATION

    int integer = 8;

    // VARIABLE INITIALIZATION    (hr variable ko value dena)

    private void Start()
    {
        myInteger = 0;
        myString = "huzaifa000000";
        myFloat = 8.8f;

        Debug.Log(myString + " ye string varible ki value h");
        Debug.Log(myInteger + " ye integer type k varible ki value h");
        Debug.Log(myFloat + " ye float type k variable ki value h");
    }


}
