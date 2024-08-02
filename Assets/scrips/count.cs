using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class count : MonoBehaviour
{
    private CircleCollider2D hitbox;
    public TextMeshProUGUI scoreCount;
    public GameObject GameOverDisplay;
    public float COINSPEED;
    float score = 0;

    private void Start()
    {
        hitbox = GetComponent<CircleCollider2D>();
        scoreCount.SetText("Score : " + score.ToString());
        GameOverDisplay.SetActive(false);
    }

    void Update()
    {
        transform.position = transform.position - new Vector3(COINSPEED, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yo");
        if (collision.gameObject.tag == "border")
        {
            COINSPEED = 0;
            GameOverDisplay.SetActive(true);
        }
        if (collision.gameObject.tag == "Player")
        {
            transform.position = new Vector3(8, 0, 0);
            score+=0.017f;
            scoreCount.SetText("Score : " + score.ToString());
        }
    }

}