using UnityEngine;
using TMPro;

public class ScoreUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCountText;
    [SerializeField] private TextMeshProUGUI winText;

    public void UpdateScoreUI(int score)
    {
        scoreCountText.text = $"Score: {score}";
    }

    public void ShowWinMessage()
    {
        winText.text = "You Win!";
    }
}
