using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        //ForeachLoop();
        //WhileLoop();
        //DoWhileLoop();
        Question01();
        Question02();
    }

    void Question02()
    {
        int distance = 10;

        do
        {
            // distanceが0以上の場合
            if (distance > 0)
            {
                // distanceから1減らす
                distance--;

                // distanceの値をDebug.Logで出力
                Debug.Log(distance);
            }
        } while (distance > 0);

        // distanceが0になったときの処理
        if (distance == 0)
        {
            // “目的地に到着しました!”というメッセージをDebug.Logで出力
            Debug.Log("目的地に到着しました!");
        }

    }
    
    void Question01() 
    {
        int n = 20;

        // whileループ
        while (n != 0)
        {
            // nが偶数の場合
            if (n % 2 == 0)
            {
                n /= 2;
            }
            // nが奇数の場合
            else
            {
                n -= 1;
            }

            // nの値をDebug.Logで出力
            Debug.Log(n);
        }

    }

    void DoWhileLoop()
    {
        /* do{}while(条件);: 最初に一度必ず処理を行う。その後、条件がtrueである場合、処理を繰り返す*/
        int counter = 200; 
        Debug.Log("do whileループで1～100まで数えます"); 
        do { 
            Debug.Log(counter); 
            counter += 1; 
        } while (counter <= 100); 
        Debug.Log("do whileループを終了します");
    }

    void WhileLoop()
    {
        /* while(条件): 条件がtrueである場合、処理を繰り返す*/
        Debug.Log("whileループで1～100まで数えます"); 

        int counter = 1; 
        while (counter <= 100) { 
            Debug.Log(counter); 
            
            counter += 1; 
        }
        Debug.Log("whileループを終了します");
    }

    void ForeachLoop() 
    {
        int[] scores = { 50, 80, 60, 80, 90 };
        foreach (var score in scores)
        {
            Debug.Log(score);// 50,80,60,80,90 }
        }
    }
    void ForLoop()
    {
        /* for(初期化(Initialize);条件(Condition);
         * 更新(Update)) * 初期化: forループのループを管理するための変数などを初期化する
         * * 条件: ここに書かれている条件がtrueの場合、for以下のコードを実行する
         * * 更新: 処理が1セット終わった後に、ループを管理するための変数などを更新する
         */

        Debug.Log("1～100まで数えます"); 
        for (int counter = 1; counter <= 100; counter++) 
        { 
            Debug.Log(counter); 
        }
        Debug.Log("forループを終了します");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
