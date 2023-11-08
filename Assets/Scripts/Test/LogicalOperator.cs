using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour


{
    bool condition1 = true;
    bool condition2 = false;

    //questionA
    int a = 12;
    int b = 4;

    //questionB
    bool isRaining = false;
    bool hasUmbrella = true;

    // Start is called before the first frame update
    void Start()
    {
        CheckCondition();
        QuestionA();
        QuestionB();



    }
    void CheckCondition()
    {
        // &&:論理積（AND）
        Debug.Log(condition1 && condition2);
        // ||:論理和（OR）
        Debug.Log(condition1 || condition2);
        // !:否定（NOT）
        Debug.Log(!condition1);
        // ^:排他的論理和（XOR）
        Debug.Log(condition1 ^ condition2);
    }
    void QuestionA()
    {
        
        bool condition = a > 10 && b <= 5 && a != 15;

        if (condition)
        {
            Debug.Log("条件に合致しました");
        }
        else
        {
            Debug.Log("条件に合致しませんでした");
        }
    }
    void QuestionB()
    {
        bool goOut = !isRaining || hasUmbrella;

        if (goOut)
        {
            Debug.Log("家を出ます");
        }
        else
        {
            Debug.Log("家を出ません");
        }
    }
}
