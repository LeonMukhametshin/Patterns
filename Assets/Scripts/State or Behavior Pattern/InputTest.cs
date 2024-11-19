using UnityEngine;

namespace Assets.Scripts.State_or_Behavior_Pattern
{
    public class InputTest : MonoBehaviour
    {
        public Player player;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                player.SetBehaviourActive();
            if (Input.GetKeyDown(KeyCode.I))
                player.SetBehaviourIdle();
            if (Input.GetKeyDown(KeyCode.C))
                player.SetBehaviourActive();
        }
    }
}
