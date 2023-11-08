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
        // &&:�_���ρiAND�j
        Debug.Log(condition1 && condition2);
        // ||:�_���a�iOR�j
        Debug.Log(condition1 || condition2);
        // !:�ے�iNOT�j
        Debug.Log(!condition1);
        // ^:�r���I�_���a�iXOR�j
        Debug.Log(condition1 ^ condition2);
    }
    void QuestionA()
    {
        
        bool condition = a > 10 && b <= 5 && a != 15;

        if (condition)
        {
            Debug.Log("�����ɍ��v���܂���");
        }
        else
        {
            Debug.Log("�����ɍ��v���܂���ł���");
        }
    }
    void QuestionB()
    {
        bool goOut = !isRaining || hasUmbrella;

        if (goOut)
        {
            Debug.Log("�Ƃ��o�܂�");
        }
        else
        {
            Debug.Log("�Ƃ��o�܂���");
        }
    }
}
