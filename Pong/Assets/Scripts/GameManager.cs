using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    private int playerScore;
    private int computerScore;
    public TMP_Text player;
    public TMP_Text computer;

    public void PlayerScores()
    {
        playerScore++;
        player.text = playerScore.ToString();
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        computerScore++;
        computer.text = computerScore.ToString();
        this.ball.ResetPosition();
    }
}
