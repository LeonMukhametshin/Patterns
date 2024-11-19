using System.Collections;
using UnityEngine;

namespace Assets.Scripts.State_or_Behavior_Pattern
{
    public class PlayerBehaviourIdle : IPlayerBehaviour
    {

        public void Enter()
        {
            Debug.Log("PlayerBehaviorIdle Enter");
        }

        public void Exit()
        {
            Debug.Log("PlayerBehaviorIdle Exit");
        }

        public void Update()
        {
            Debug.Log("PlayerBehaviorIdle Update");
        }
    }
}