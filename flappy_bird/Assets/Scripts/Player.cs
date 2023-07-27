using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float velocity;
    Rigidbody2D rb;
    public GameObject gameover;
    public int score;
    public Text score_text;
  
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "addScore")
        {
            score++;
            score_text.text = score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameover.SetActive(true);
        Time.timeScale = 0.0f;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    
}
