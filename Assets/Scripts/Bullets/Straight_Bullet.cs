using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightBullet : MonoBehaviour
{
    public float speed = 2f;
    [HideInInspector]
    public Vector3 direction;
    [Tooltip("Time to live")]
    [SerializeField] private float ttl = 3f;

    private void Start()
    {
        Destroy(gameObject, ttl);
    }
    private void Update()
    {
        //Debug.Log("Bullet in");

        transform.position += direction * Time.deltaTime * speed;
    }

    public void setPlayerTarget(Vector3 playerPos)
    {
        //Debug.Log("Direction set");
        direction = Vector3.Normalize(playerPos - transform.position);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
