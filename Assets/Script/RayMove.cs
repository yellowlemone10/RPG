﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RayMove : MonoBehaviour {

    public GameObject movePoint;
    public GameObject attackPoint;

    NavMeshAgent agent;

   void Awake()
    {
        movePoint.SetActive(false);
        attackPoint.SetActive(false);
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if ( Physics.Raycast(ray, out hitInfo, 100.0f))
            {
                Debug.Log(hitInfo.point);
                movePoint.transform.position = hitInfo.point;
                movePoint.SetActive(true);
                agent.SetDestination(movePoint.transform.position);
            }
        }
    }
}
