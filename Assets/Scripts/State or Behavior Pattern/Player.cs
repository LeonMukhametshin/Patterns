using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

namespace Assets.Scripts.State_or_Behavior_Pattern
{
    public class Player : MonoBehaviour
    {
        private Dictionary<Type, IPlayerBehaviour> behaviourMap;
        private IPlayerBehaviour behaviourCurrent;

        private void Start()
        {
            InitBehavoiurs();
            SetBehavoiurByDefault();
        }

        private void InitBehavoiurs()
        {
            behaviourMap = new Dictionary<Type, IPlayerBehaviour>();

            behaviourMap[typeof(PlayerBehaviourActive)] = new PlayerBehaviourActive();
            behaviourMap[typeof(PlayerBehaviourAggressive)] = new PlayerBehaviourAggressive();
            behaviourMap[typeof(PlayerBehaviourIdle)] = new PlayerBehaviourIdle();
        }

        private IPlayerBehaviour GetBehaviour<T>() where T : IPlayerBehaviour
        {
            var type = typeof(T);
            return behaviourMap[type];
        }

        private void Update()
        {
            if (behaviourCurrent != null)
                behaviourCurrent.Update();
        }

        private void SetBehavoiur(IPlayerBehaviour newBehaviour)
        {
            if (behaviourCurrent != null)
                behaviourCurrent.Exit();

            behaviourCurrent = newBehaviour;
            behaviourCurrent.Enter();
        }

        private void SetBehavoiurByDefault()
        {
            SetBehaviourIdle();
        }

        public void SetBehaviourIdle()
        {
            var behaviour = GetBehaviour<PlayerBehaviourIdle>();
            SetBehavoiur(behaviour);
        }

        public void SetBehaviourAggressive()
        {
            var behaviour = GetBehaviour<PlayerBehaviourAggressive>();
            SetBehavoiur(behaviour);
        }

        public void SetBehaviourActive()
        {
            var behaviour = GetBehaviour<PlayerBehaviourActive>();
            SetBehavoiur(behaviour);
        }
    }
}