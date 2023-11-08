using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    
    int integerNumber; 
    float floatNumber; 
    double doubleNumber; 
    long integerNumber2;
    char character;
    string stringData;

    float number1 = 12.34f;
    int number2;
 



    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 8; 
        floatNumber = 1.5f; 
        doubleNumber = 1.234567890123;
        character = 'u';
        stringData = "unity";

        Debug.Log(integerNumber) ; 
        Debug.Log(floatNumber) ;
        Debug.Log(doubleNumber) ;

        integerNumber2 = 10000000000;
        Debug.Log(integerNumber2);

        Debug.Log(character) ;

        Debug.Log(stringData);

        Debug.Log("Åh C:Users\\Username\\DocumentsÅh");

        number2 = (int)number1;
        Debug.Log(number2) ;




    }
}
