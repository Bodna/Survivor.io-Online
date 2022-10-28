using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootsAi : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    [SerializeField] private float minDistance = 0f;
    private float range;
    public GameObject bullet;
    [SerializeField] private float coolDown = 2f;
    private float nextFire = 0;
    void Update()
    {
        
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        Attack();
    }
    private void Attack()
    {
        nextFire += Time.deltaTime;
        if (nextFire >= coolDown)
        {
            nextFire = 0;
            Debug.Log("Shoot");
            GameObject proj = Instantiate(bullet, transform.position, transform.rotation);
            proj.GetComponent<StraightBullet>().setPlayerTarget(target.position);
        }
    }
}
