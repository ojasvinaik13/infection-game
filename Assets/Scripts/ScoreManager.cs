using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    private int antidotes;
    [SerializeField] private TMP_Text scoreText;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        antidotes = 0;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    /*void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ("Score: " + ((int)score).ToString());
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Antidote"))
        {
            Destroy(collision.gameObject);
            antidotes++;
            scoreText.text = "Antidotes: " + antidotes;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (antidotes > 0)
            {
                antidotes--;
                scoreText.text = "Antidotes: " + antidotes;
            }
            else
            {
                Destroy(player.gameObject);
            }
        }
    }
}
