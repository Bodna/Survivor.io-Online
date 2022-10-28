using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private float coolDown = 1;
    private float nextFire = 0;
    private void Update()
    {
        nextFire += Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GetComponent<PlayerController>().life -= 2;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy") && (nextFire >= coolDown))
        {
            nextFire = 0;
            GetComponent<PlayerController>().life -= 2;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            GetComponent<PlayerController>().life -= 5;
        }
    }
}
