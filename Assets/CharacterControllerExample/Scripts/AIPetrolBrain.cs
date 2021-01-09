using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace CharacterControllerExample
{
    public class AIPetrolBrain : CharacterBrainBase
    {
        private NavMeshAgent navMeshAgent;
        public NavMeshAgent NavMeshAgent { get { return (navMeshAgent == null) ? navMeshAgent = GetComponent<NavMeshAgent>() : navMeshAgent; } }

        public List<Transform> PetrolPoints;
        private int currentPetrolPoint;

        private void Start()
        {
            Intialize();
        }

        public override void Intialize()
        {
            base.Intialize();
            NavMeshAgent.updatePosition = false;
            NavMeshAgent.updateRotation = false;
            NavMeshAgent.SetDestination(PetrolPoints[currentPetrolPoint].position);
        }


        public override void Logic()
        {
            IsDestinationReached();

           

            float distanceToAgent = Vector3.Distance(transform.position, NavMeshAgent.nextPosition);


            if (distanceToAgent > 0.5f)
            {
                NavMeshAgent.isStopped = true;
                //if (CharacterController.GetCurrentSpeed() < 0.05f)
                //    NavMeshAgent.Warp(transform.position);
            }
            else NavMeshAgent.isStopped = false;

            Vector3 direction = NavMeshAgent.nextPosition - transform.position;

            if(distanceToAgent > 0.2f)
                CharacterController.Move(direction);
        }


        private bool IsDestinationReached()
        {
            float distanceToPoint = Vector3.Distance(NavMeshAgent.nextPosition, PetrolPoints[currentPetrolPoint].position);

            if(distanceToPoint < 0.2f)
            {
                currentPetrolPoint++;

                if (currentPetrolPoint > PetrolPoints.Count - 1)
                    currentPetrolPoint = 0;

                NavMeshAgent.SetDestination(PetrolPoints[currentPetrolPoint].position);
                return true;
            }

            return false;
        }
    }
}

