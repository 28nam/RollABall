using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 試験の点数を保存するための5つ容量のある配列を宣言

    int[] numbers = { 5, 8, 12, 7, 3 };
    string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
    int[] scores = { 78, 85, 90, 72, 88, 60 };

    void Start()
    {

        int sum = 0;
        int max = numbers[0];

        //list
        List<int> testNum = new List<int>();

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Debug.Log(max);

        Debug.Log(fruits[2]);

        foreach (int score in scores)
        {
            sum += score;
        }

        Debug.Log(+sum);

        //list
        testNum.Add(1);
        testNum.Add(2);
        testNum.Add(3);

        Debug.Log(testNum[0]);
        testNum.Remove(2);
        Debug.Log(testNum.Count);

        //list1
        List<int> listNumbers = new List<int>();
        listNumbers.Add(1);
        listNumbers.Add(2);
        listNumbers.Add(3);
        listNumbers.Add(4);
        listNumbers.Add(5);

        // listNumbersの内容をforeachループを使ってDebug.Logで表示
        foreach (int number in listNumbers)
        {
            Debug.Log(number);
        }

        //list2
        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Blue");
        colors.Add("Green");
        colors.Add("Yellow");
        colors.Add("Purple");

        // "Green"を削除
        colors.Remove("Green");

        // colorsの内容をforループを使ってDebug.Logで表示
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        //list3
        List<string> listFruits = new List<string>();
        listFruits.Add("Apple");
        listFruits.Add("Banana");
        listFruits.Add("Cherry");
        listFruits.Add("Date");
        listFruits.Add("Fig");

        // listFruitsの中に"Cherry"が含まれているかどうかを確認し、結果をDebug.Logで表示
        bool isCherryInList = listFruits.Contains("Cherry");
        Debug.Log(isCherryInList);

        //list4


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
