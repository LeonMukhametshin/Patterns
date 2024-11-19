using UnityEngine;

namespace Assets.Scripts.State_or_Behavior_Pattern
{
    public class PlayerBehaviourActive : IPlayerBehaviour
    {
        public void Enter()
        {
            Debug.Log("PlayerBehaviorActive Enter");
        }

        public void Exit()
        {
            Debug.Log("PlayerBehaviorActive Exit");
        }

        public void Update()
        {
            Debug.Log("PlayerBehaviorActive Update");
        }
    }
}