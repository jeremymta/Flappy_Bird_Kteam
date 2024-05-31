using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour
{
    public float moveSpeed;
    //public float minY;
    //public float maxY;


    private float oldPosition;
    private GameObject obj;

    // Use this for initialization
    void Start()
    {
        obj = gameObject;
        oldPosition = 10;
        moveSpeed = 2;
        //minY = -1;
        //maxY = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate (new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Dung Trung Walllll");
        if (other.gameObject.tag.Equals("ResetWall"))
<<<<<<< HEAD
            obj.transform.position = new Vector3(oldPosition, transform.position.y, 0);
=======
        {
            //float newY = transform.position.y;
            //obj.transform.position = new Vector3(oldPosition, newY, 0);

            obj.transform.position = new Vector3(oldPosition, transform.position.y, 0);
        }
>>>>>>> 0eb8179834b14fcfd841f8755a33be414928d50d

    }

}
