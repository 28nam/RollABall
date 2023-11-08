using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotNet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowTime();
    }
    void ShowTime()
    {
        DateTime now = DateTime.Now; 
        // 今の時間を取得する
        Debug.Log(now);

        // 現在の日付を取得
        DateTime today = DateTime.Now;

        //問題１
        // ゲームに今日の日付を表示
        Debug.Log("今日の日付は" + today.ToString());

        //問題２
        // 7日後の日付を取得
        DateTime oneWeekLater = today.AddDays(7);

        // ゲームに7日後の日付を表示
        Debug.Log("7日後の日付は" + oneWeekLater.ToString());
    }
}
