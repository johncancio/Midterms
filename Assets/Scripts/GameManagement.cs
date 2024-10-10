using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [SerializeField] private ScoreBoard scoreBoard;

    public void UpdateScore()
    {
        if (scoreBoard != null)
        {
            scoreBoard.ScoreCount();
        }
    }
}
