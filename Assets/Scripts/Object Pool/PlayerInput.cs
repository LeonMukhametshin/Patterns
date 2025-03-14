using System.Collections;
using UnityEngine;

namespace CustomPool
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private ObjectForPool _prefab;
        private CustomPool<ObjectForPool> _customPool;

        private void Awake()
        {
            _customPool = new CustomPool<ObjectForPool>(_prefab, 3);
        }

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                LeftMouseClick();
            }
        }

        private void LeftMouseClick()
        {
            ObjectForPool obj = _customPool.Get();

            obj.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - (Vector3.back * 10));
            StartCoroutine(OnCircleCoroutine(obj));
        }

        private IEnumerator OnCircleCoroutine(ObjectForPool obj)
        {
            yield return new WaitForSeconds(obj.timeToDestroy);
            _customPool.Release(obj);
        }
    }
}