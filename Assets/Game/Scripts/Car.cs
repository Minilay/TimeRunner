using UnityEngine;

namespace Game.Scripts
{
    public class Car : MonoBehaviour
    {
        private Transform _transform;

        [Header("Options")] [SerializeField] private float speed;
        public static bool IsRight = true;

        private void Start() => _transform = GetComponent<Transform>();

        private void Update()
        {
            Move();
        }

        //Bug when more than one car (so one by one) 
        private void Move()
        {
            if (IsRight)
                _transform.Translate(Vector3.right * (speed * Time.deltaTime));
            else
                _transform.Translate(Vector3.left * (speed * Time.deltaTime));
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(GameObject.FindGameObjectWithTag("Car"));
        }
    }
}