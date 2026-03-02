using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform player;
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
