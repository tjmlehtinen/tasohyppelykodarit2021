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
        // haetaan näppäimistöltä sivusuunnan liikkeen input
        horizontalMovement = Input.GetAxis("Horizontal");
        // Debug.Log(horizontalMovement);
        // käännetään pelaaja menosuuntaan
        float facing = Input.GetAxisRaw("Horizontal");
        if (facing != 0)
        {
            transform.localScale = new Vector2(facing, transform.localScale.y);
        }
    }

    // FixedUpdate kutsutaan tietyin väliajoin
    private void FixedUpdate()
    {
        // haetaan mikä on oikea liikemäärä sivusuunnassa
        float xMovement = horizontalMovement * moveSpeed;
        // pystysuunnan liikkeeseen otetaan nykyinen liike
        float yMovement = myRigidbody.velocity.y;
        // tehdään näistä vektori
        Vector2 movementVector = new Vector2(xMovement, yMovement);
        // asetetaan tämä rigidbodyn liikevektoriksi
        myRigidbody.velocity = movementVector;
    } 
}
