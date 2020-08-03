using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class congDiem : MonoBehaviour
{
    
    public Text diem;
    int score = 0;
    public void tangDiem()
    {
        score++;
        diem.text = "Score : " + score;
    }
}
