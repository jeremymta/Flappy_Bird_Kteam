using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower = 5;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;
    private Animator anim;

    GameObject obj;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        //flyPower = 100;

        audioSource = obj.GetComponent<AudioSource>();  
        audioSource.clip = flyClip;
        anim = obj.GetComponent<Animator>();
        anim.SetFloat("flyPower", 0);
        anim.SetBool("isDead", false);
        
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Flyyyy");
            if (!gameController.GetComponent<GameController>().isEndGame)
            {
                audioSource.Play();
            }

            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower), ForceMode2D.Impulse);
        }
        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    Vector2 touchPosition = touch.position;

        //    if (touchPosition.y > obj.transform.position.y)
        //    {
        //        Debug.Log("Flyyyy");
        //        if (!gameController.GetComponent<GameController>().isEndGame)
        //        {
        //            audioSource.Play();
        //        }

        //        obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        //    }
        //}
        anim.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Collided with (in ra ten dt da va cham) "+ other.gameObject.name);
        EndGame();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("test point");
        gameController.GetComponent<GameController>().GetPoint();
    }

    void EndGame()
    {
        anim.SetBool("isDead", true);
        audioSource.clip = gameOverClip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
    }    
}
