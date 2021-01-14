using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Scripts
{
    public sealed class Car : MonoBehaviour
    {
        
        private Transform _transform;
        
        [Header("Options")] [SerializeField] private float speed;
        public bool isRight = true;

        private void Start() => _transform = GetComponent<Transform>();


        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (isRight)
                _transform.Translate(Vector3.left * (speed * Time.deltaTime));
            else
                _transform.Translate(Vector3.right * (speed * Time.deltaTime));
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }
    }
}