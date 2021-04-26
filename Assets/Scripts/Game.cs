using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Player player;
    [SerializeField]
    GameObject scoreCounter;
    GameObject enemy;
    float depthScore;
    float highScore;
    int generateAmnt = 0;

    EnemyGenerate generate;

    void Start()
    {
        scoreCounter.GetComponent<TextMeshPro>().text = "Score: " + depthScore.ToString();
        generate = GetComponent<EnemyGenerate>();
        depthScore = 0.00f;
        generateAmnt = Random.Range(0 , 15);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Alive)
        {
            depthScore += 1;
            scoreCounter.GetComponent<TextMeshPro>().text = "Score: " + depthScore.ToString();
        }
        else
        {
            scoreCounter.GetComponent<TextMeshPro>().text = "DEAD";
            if (highScore < depthScore)
            {
                highScore = depthScore;
            }
        }
        if (depthScore % generateAmnt == 0)
        {
            // Generate Enemy objects at this amount
            for (int i = 0; i < generateAmnt; i++)
            {
                generate.Generate();
            }
        }
    }
}
