using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 3.0f;

    public float rotationspeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // movement
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // verticalInput = Input.GetAxis("Vertical");
        // transform.Translate(Vector3.up* verticalInput * Time.deltaTime * speed);
        ////rotation
         if (Input.GetKey(KeyCode.R))
         {
            transform.Rotate(Vector3.forward * speed *  Time.deltaTime);
         }
         if (Input.GetKeyDown(KeyCode.X))
         {
            transform.Rotate(Vector3.down, rotationspeed * Time.deltaTime);
         }

        // Scale
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(4, 4, 4);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(Random.Range(0.2f,5.0f), 1, Random.Range(0.2f,5.0f));
        }




    }


}
