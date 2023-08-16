using UnityEngine;

namespace Sailor
{
    public class Ocean : MonoBehaviour
    {
        [SerializeField] private Material material;
        [SerializeField] private Transform target;
        [Space]
        [SerializeField] private MeshFilter meshFilter;
        [SerializeField] private float radius = 10;

        private Vector3 center;
        private Mesh mesh;

        private void Start()
        {
            UpdateMesh();
        }

        private void Update()
        {
            Vector3 newCenter = new Vector3(Mathf.RoundToInt(target.position.x), 0, Mathf.RoundToInt(target.position.z));

            if (newCenter != center)
            {
                center = newCenter;
                UpdateMesh();
            }
        }

        private void OnValidate()
        {
            UpdateMesh();
        }

        private void UpdateMesh()
        {
            if (mesh == null)
                mesh = new Mesh();

            mesh.vertices = new Vector3[]
            {
                new Vector3(- radius, 0, -radius) + center,
                new Vector3(- radius, 0, radius) + center,
                new Vector3(radius, 0, radius) + center,
                new Vector3(radius, 0, -radius) + center
            };

            mesh.triangles = new int[]
            {
                0, 1, 3,
                1, 2, 3,
            };

            Vector2 offset = new Vector2(center.x, center.z) / (radius * 2);
            mesh.uv = new Vector2[]
            {
                new Vector2(0, 0) + offset,
                new Vector2(0, 1) + offset,
                new Vector2(1, 1) + offset,
                new Vector2(1, 0) + offset
            };

            meshFilter.mesh = mesh;
        }
    }
}