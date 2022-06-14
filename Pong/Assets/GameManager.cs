using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    private int playerScore;
    private int computerScore;
    
    public void PlayerScores()
    {
        playerScore++;
        Debug.Log(playerScore);
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        computerScore++;
        Debug.Log(computerScore);
        this.ball.ResetPosition();
    }
}
