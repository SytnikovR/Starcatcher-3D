using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Bomber3D
{
    public class EnemyControl : MonoBehaviour
    {
        private NavMeshAgent agent;
        public Transform target;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            agent.SetDestination(target.transform.position);
        }

    }
}


