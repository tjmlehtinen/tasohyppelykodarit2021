using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // määritellään nopeus
    public float moveSpeed = 5.0f;

    // muuttuja pelaajan kehoa varten
    public Rigidbody2D myRigidbody;

    // muuttuja liikkeen määrää varten
    private float horizontalMovement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        Debug.Write(horizontalMovement);
    }
}
