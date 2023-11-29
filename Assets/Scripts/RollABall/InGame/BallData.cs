using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData 
{

    private int hitPoint; 
    public int GetHitPoint { 
        get { return hitPoint; 
        } 
    }
    public int SetHitPoint { 
        set { hitPoint = value; 
        } 
    } 
    // BallDataのコンストラクタ
    public BallData(int hitPoint) {
        this.hitPoint= hitPoint; 
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
