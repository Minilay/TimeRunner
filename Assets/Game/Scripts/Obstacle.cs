using UnityEngine;

namespace Game.Scripts
{
    public class Obstacle : MonoBehaviour
    {
        [Header("Options")] [SerializeField] private Transform startPositionRight;
        [SerializeField] private Transform startPositionLeft;
        [SerializeField] private GameObject car;
        [SerializeField] private float timer;
        private float _nextSpawnTime;

        private void Update()
        {
            _nextSpawnTime += Time.deltaTime;

            if (!(timer < _nextSpawnTime)) return;
            Spawn(car, startPositionRight, startPositionLeft);
            _nextSpawnTime = 0;
        }

        //Bug when more than one car (so one by one)
        private void Spawn(GameObject obstacle, Transform position, Transform secondPosition)
        {
            if (Car.IsRight)
            {
                var obstaclePosition = position.position;
                Instantiate(obstacle, new Vector3(obstaclePosition.x,
                        obstaclePosition.y,
                        obstaclePosition.z),
                    Quaternion.identity);

                Car.IsRight = false;
            }
            else
            {
                var obstaclePosition = secondPosition.position;
                Instantiate(obstacle, new Vector3(obstaclePosition.x,
                        obstaclePosition.y,
                        obstaclePosition.z),
                    Quaternion.identity);

                Car.IsRight = true;
            }
        }
    }
}