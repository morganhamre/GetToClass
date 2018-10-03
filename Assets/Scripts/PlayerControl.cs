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
    public int hp;
    public int maxHP = 3;

    public Sprite spriteLeftA;
    public Sprite spriteLeftB;
    public Sprite spriteRightA;
    public Sprite spriteRightB;
    public Sprite forwardL;
    public Sprite forwardR;
    public Sprite stand;
    private SpriteRenderer sprRend;

    public int maxLevel = 5;


    // Use this for initialization
    void Start()
    {
        hpanel = GameObject.FindObjectOfType<UIHealthPanel>();
        hp = maxHP;
        hpanel.SetLives(maxHP, hp);
        rigidbod = GetComponent<Rigidbody2D>();
        sprRend = GetComponent<SpriteRenderer>();
        sprRend.sprite = stand;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = rigidbod.position;
        Vector2 normalizedDir = rigidbod.velocity.normalized;
        transform.up = normalizedDir;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pos.y += step;
            if (sprRend.sprite == forwardL)
            {
                sprRend.sprite = forwardR;
            }
            else
            {
                sprRend.sprite = forwardL;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            pos.x -= step;
            if(sprRend.sprite == spriteLeftA){
                sprRend.sprite = spriteLeftB;
            } else{
                sprRend.sprite = spriteLeftA;
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            pos.x += step;
            if (sprRend.sprite == spriteRightA)
            {
                sprRend.sprite = spriteRightB;
            }
            else
            {
                sprRend.sprite = spriteRightA;
            }
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            pos.y -= step;
        }

        rigidbod.position = pos;
    }

    void Hurt(){
        Vector2 pos = rigidbod.position;
        pos.y = (float) -4.5;
        pos.x = (float) -3.5;
        rigidbod.position = pos;
        hp--;
        hpanel.SetLives(maxHP, hp);
        if (hp <= 0){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
        SceneManager.LoadScene("Level1");
        //Maybe load main menu? Text saying game over, play again?
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Vehicle") || col.gameObject.CompareTag("Water"))
        {
            Hurt();
        }

    }
}
