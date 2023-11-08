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
            // distance��0�ȏ�̏ꍇ
            if (distance > 0)
            {
                // distance����1���炷
                distance--;

                // distance�̒l��Debug.Log�ŏo��
                Debug.Log(distance);
            }
        } while (distance > 0);

        // distance��0�ɂȂ����Ƃ��̏���
        if (distance == 0)
        {
            // �g�ړI�n�ɓ������܂���!�h�Ƃ������b�Z�[�W��Debug.Log�ŏo��
            Debug.Log("�ړI�n�ɓ������܂���!");
        }

    }
    
    void Question01() 
    {
        int n = 20;

        // while���[�v
        while (n != 0)
        {
            // n�������̏ꍇ
            if (n % 2 == 0)
            {
                n /= 2;
            }
            // n����̏ꍇ
            else
            {
                n -= 1;
            }

            // n�̒l��Debug.Log�ŏo��
            Debug.Log(n);
        }

    }

    void DoWhileLoop()
    {
        /* do{}while(����);: �ŏ��Ɉ�x�K���������s���B���̌�A������true�ł���ꍇ�A�������J��Ԃ�*/
        int counter = 200; 
        Debug.Log("do while���[�v��1�`100�܂Ő����܂�"); 
        do { 
            Debug.Log(counter); 
            counter += 1; 
        } while (counter <= 100); 
        Debug.Log("do while���[�v���I�����܂�");
    }

    void WhileLoop()
    {
        /* while(����): ������true�ł���ꍇ�A�������J��Ԃ�*/
        Debug.Log("while���[�v��1�`100�܂Ő����܂�"); 

        int counter = 1; 
        while (counter <= 100) { 
            Debug.Log(counter); 
            
            counter += 1; 
        }
        Debug.Log("while���[�v���I�����܂�");
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
        /* for(������(Initialize);����(Condition);
         * �X�V(Update)) * ������: for���[�v�̃��[�v���Ǘ����邽�߂̕ϐ��Ȃǂ�����������
         * * ����: �����ɏ�����Ă��������true�̏ꍇ�Afor�ȉ��̃R�[�h�����s����
         * * �X�V: ������1�Z�b�g�I�������ɁA���[�v���Ǘ����邽�߂̕ϐ��Ȃǂ��X�V����
         */

        Debug.Log("1�`100�܂Ő����܂�"); 
        for (int counter = 1; counter <= 100; counter++) 
        { 
            Debug.Log(counter); 
        }
        Debug.Log("for���[�v���I�����܂�");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
