using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Checks for left/right keys for the player
        float horizontal = Input.GetAxis("Horizontal");
        // Check for up/down keys OR W/S keys
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        // Moves the player on the x-axis
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        // Moves the player on the y-axis
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
