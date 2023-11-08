using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(1 + 2); // 3
        Debug.Log(30 - 29); // 1
        Debug.Log(9 * 9); // 81
        Debug.Log(120 / 5); // 24
        Debug.Log(120 / 7); // 17 (120/7 = 17...1)
        Debug.Log(120 % 7); // 1 (120/7 = 17...1)

        int sum = 5 + 13; // 計算結果は変数に代入することもできます
        Debug.Log(sum); // 18
        sum = sum + 1;
        Debug.Log(sum); // 19

        sum = sum + 1;
        Debug.Log(sum); // 20

        // Khai báo các biến
        int number = 23; // 0 đến 51
        string[] suits = { "H", "D", "C", "S" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        // Tính toán giá trị của lá bài
        string suit = suits[number / 13];
        string rank = ranks[number % 13];

        // Hiển thị giá trị của lá bài
        Debug.Log($"{suit}の{rank}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
