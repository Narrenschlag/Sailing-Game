using UnityEngine;

namespace Sailor
{
    public class Cinema : MonoBehaviour
    {
        public static Vector3 Forward, Right;

        [SerializeField] private Transform target;
        [SerializeField] private float speed;

        private void FixedUpdate()
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.fixedDeltaTime * speed);
        }

        private void Update()
        {
            Forward = transform.forward;
            Forward.y = 0;

            Right = transform.right;
        }
    }
}