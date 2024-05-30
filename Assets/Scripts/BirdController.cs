using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower = 5;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        //flyPower = 100;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Flyyyy");
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
        Debug.Log("End game roi con ga nay muahahaa");
    }    
}
