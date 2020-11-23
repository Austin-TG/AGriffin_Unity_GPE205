using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Create variables for points from enemies, and score total
    public int enemyPoints;
    public int scoreTotal = 0;
    
    // Create function to add points to score
    public void AddToScore(int scoreAdd)
    {
        scoreTotal += scoreAdd;

        // debugging log
        Debug.Log("Score = " + scoreTotal);
    }

    // Create function to subtract points from score
    public void SubToScore(int scoreSub)
    {
        scoreTotal -= scoreSub;
    }
}
