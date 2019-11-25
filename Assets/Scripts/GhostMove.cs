using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class GhostMove : MonoBehaviour
{

    public GameObject waypoints_ref;
    int cur = 1;

    public float speed = 0.3f;

    private Transform[] waypoints;

    private void Start()
    {
        waypoints = waypoints_ref.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                                   waypoints[cur].position,
                                                   speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        else cur = ((cur + 1) % (waypoints.Length) );

        if (cur == 0) cur = 1;

        Vector2 dir = waypoints[cur].position - transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "PacMan")
            Destroy(co.gameObject);
    }

}


