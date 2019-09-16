using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowsPlayer : MonoBehaviour
{

    public Transform target;
    public float movementSpeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(target.position, transform.position);
        if(distance > 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
        }
    }
}
