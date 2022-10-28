using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0,0,-1);

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
