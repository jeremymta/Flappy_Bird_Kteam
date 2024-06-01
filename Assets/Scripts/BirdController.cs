using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower = 7;

    public AudioClip flyClip;
    public AudioClip gameOverClip;

    private AudioSource audioSource;

    GameObject obj;
    GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        //flyPower = 100;

        audioSource = obj.GetComponent<AudioSource>();  
        audioSource.clip = flyClip;
        
        if (gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("Flyyyy");

            audioSource.Play();
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Collided with (in ra ten dt da va cham) "+ other.gameObject.name);
        EndGame();
    }    
    void EndGame()
    {
        audioSource.clip = gameOverClip;
        audioSource.Play();
        gameController.GetComponent<GameController>().EndGame();
    }    
}
