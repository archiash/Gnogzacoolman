using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class coin : MonoBehaviour
{
    private CircleCollider2D hitbox;
    public float COINSPEED;

    private void Start()
    {
        hitbox = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        transform.position = transform.position - new Vector3(COINSPEED, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ontrigger");
        if (collision.gameObject.tag == "border")
        {
            transform.position = new Vector3(928, 221, 0);
            Debug.Log("Hit border");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollision");
    }
}
