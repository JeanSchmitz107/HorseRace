using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform trPlayer;
    [SerializeField] private TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = "Score : " + trPlayer.position.z.ToString("0");
    }
}
