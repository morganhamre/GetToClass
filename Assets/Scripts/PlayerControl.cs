using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbod;
    public float step;
    private UIHealthPanel hpanel;
    private int hp;
    public int maxHP = 3;

    // Use this for initialization
    void Start()
    {
        hpanel = GameObject.FindObjectOfType<UIHealthPanel>();
        hp = maxHP;
        hpanel.SetLives(maxHP, hp);
        rigidbod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rigidbod.position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.y += step;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            pos.x -= step;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            pos.x += step;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            pos.y -= step;
        }

        rigidbod.position = pos;
    }

    void Hurt(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        hp--;
        hpanel.SetLives(maxHP, hp);
        if (hp <= 0){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
        SceneManager.LoadScene("Level1");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Car"))
        {
            Hurt();
        }
    }
}
