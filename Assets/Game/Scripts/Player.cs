using UnityEngine;

namespace Game.Scripts
{
    public class Player : MonoBehaviour
    {
        private Transform _transform;
        public TimeSystem timeSystem;

        [Header("Options")] [SerializeField] private float speed;

        private void Start() => _transform = GetComponent<Transform>();

        private void Update()
        {
            Move();
            OnTimeControl();
        }

        private void Move()
        {
            _transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }

        private void OnTimeControl()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                timeSystem.SlowMotion();
            }
        }
    }
}