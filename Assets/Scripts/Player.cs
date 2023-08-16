using UnityEngine;

namespace Sailor
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody rb;
        [SerializeField] private Input input;
        [Space]
        [SerializeField] private float speed;
        [SerializeField] private float turnSpeed;
        [SerializeField] private float yRange = .5f;

        private float yRot;

        private Vector3 Forward => transform.forward;

        private void Update()
        {
            Vector3 input = Forward * Input.Movement.y;
            rb.velocity = Vector3.Lerp(rb.velocity, input * speed, Time.deltaTime * 5);

            yRot = Mathf.Lerp(yRot, Input.Movement.x * Input.Movement.y, Time.deltaTime * 2);
            transform.Rotate(0, yRot * turnSpeed * Time.deltaTime, 0);
        }
    }
}