using UnityEngine;

namespace Sailor
{
    public class Input : MonoBehaviour
    {
        public static Vector2 Movement;

        private void Update()
        {
            Movement = new Vector2(UnityEngine.Input.GetAxisRaw("Horizontal"), UnityEngine.Input.GetAxisRaw("Vertical"));
        }
    }
}