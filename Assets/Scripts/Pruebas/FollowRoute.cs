using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRoute : MonoBehaviour
{
    [SerializeField] private float speed = 30;

    //Puntos a seguir
    [SerializeField] private Transform[] points;
    private int totalPoints;
    private int nextPoint;

    void Start()
    {
        transform.position = points[0].position;
        totalPoints = points.Length;
        nextPoint = 1;
        // transform.LookAt(points[nextPoint].position);
    }

    public void Update()
    {
        if (Vector3.Distance(transform.position, points[nextPoint].position) < 0.1f)
        {
            nextPoint++;
            if (nextPoint == totalPoints)
            {
                nextPoint = 0;
            }
            // transform.LookAt(points[nextPoint].position);
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPoint].position, speed * Time.deltaTime);
    }
}