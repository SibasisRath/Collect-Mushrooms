using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] TextMeshProUGUI scoreText;

    public int Score { get => score; set => score = value; }

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "MushRooms: " + Score;
    }
}
