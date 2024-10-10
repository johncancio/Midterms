using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private ScoreUIManager scoreUIManager;
    private int score = 0;
    [SerializeField] private int totalOrbs = 10;

    public void ScoreCount()
    {
        score++;
        scoreUIManager.UpdateScoreUI(score);

        if (score >= totalOrbs)
        {
            scoreUIManager.ShowWinMessage();
        }
    }
}
