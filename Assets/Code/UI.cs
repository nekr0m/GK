using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] SomeScript SS;
    void Start()
    {
        scoreText.text = "" + SS.score;
    }
    public void AddScore(int value)
    {
        SS.score += value;
        scoreText.text = "" + SS.score;
    }
}
