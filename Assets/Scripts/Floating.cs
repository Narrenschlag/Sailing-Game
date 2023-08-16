using UnityEngine;

namespace Sailor
{
    public class Floating : MonoBehaviour
    {
        [SerializeField] private float multiplier = 1;

        private void Update()
        {
            Vector3 position = transform.position;
            position.y = multiplier * Mathf.PerlinNoise(Time.time, 1);

            transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * 2);
        }
    }
}