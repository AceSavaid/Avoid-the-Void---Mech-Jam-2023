using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    public float distanceFromCenter = 2.4f;
    public float speed = 10;
    public float xOffSet = -2;
    public float yOffSet = -0.5f;


    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, this.gameObject.transform.position) > distanceFromCenter)
        {

            float xmovement = Mathf.Lerp(transform.position.x, player.transform.position.x + xOffSet, Time.deltaTime * speed);
            float ymovement = Mathf.Lerp(transform.position.y, player.transform.position.y + yOffSet, Time.deltaTime * speed);
            transform.position = new Vector3(xmovement, ymovement, transform.position.z);
        }
    }
}
