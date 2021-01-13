using UnityEngine;

namespace Game.Scripts
{
    public class Player : MonoBehaviour
    {
        private Transform _transform;

        [Header("Options")] [SerializeField] private float speed;

        void Start() => _transform = GetComponent<Transform>();

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            _transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
    }
}