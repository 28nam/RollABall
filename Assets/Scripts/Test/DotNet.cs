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
        // ���̎��Ԃ��擾����
        Debug.Log(now);

        // ���݂̓��t���擾
        DateTime today = DateTime.Now;

        //���P
        // �Q�[���ɍ����̓��t��\��
        Debug.Log("�����̓��t��" + today.ToString());

        //���Q
        // 7����̓��t���擾
        DateTime oneWeekLater = today.AddDays(7);

        // �Q�[����7����̓��t��\��
        Debug.Log("7����̓��t��" + oneWeekLater.ToString());
    }
}
