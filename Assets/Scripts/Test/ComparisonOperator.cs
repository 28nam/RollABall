using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*��r���Z�q
         * True: �^
         * False: �U
         */
        /**
        int x = 5;
        int y = 8;
        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // tru

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("x��y�͓������ł�"); // false�̂��ߕ\������Ȃ�
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("x��y�͓������Ȃ��ł�"); // true�̂��ߕ\�������
        }
        */

        //question1
        int x = 10;
        int y = 20;

        if (x > y)
        {
            Debug.Log("x��y���傫��");
        }

        //question2
        string name1 = "�R�c���Y";
        string name2 = "�R�c���Y";

        if (name1 == name2)
        {
            Debug.Log("��̖��O�͓����ł�");
        }

 
        //question3
        int age = 21;

        if (age >= 20)
        {
            Debug.Log("���l�ł�");
        }
        else
        {
            Debug.Log("�����N�ł�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
