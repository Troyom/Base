﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Start()
    {   //Pega componente NavMesh
        agent = this.GetComponent<NavMeshAgent>();
    }
}
