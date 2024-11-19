using System.Collections;
using UnityEngine;

namespace Assets.Scripts.State_or_Behavior_Pattern
{
    public class PlayerBehaviourAggressive : IPlayerBehaviour
    {
        public void Enter()
        {
            Debug.Log("PlayerBehaviorAggressive Enter");
        }

        public void Exit()
        {
            Debug.Log("PlayerBehaviorAggressive Exit");
        }

        public void Update()
        {
            Debug.Log("PlayerBehaviorAggressive Update");
        }
    }
}