using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Scripts
{
    public class Obstacle : MonoBehaviour
    {
        [Header("Options")]
        [SerializeField] private GameObject firstCar;
        [SerializeField] private GameObject secondCar;
        [SerializeField] private float timeOfSpawns;
        [SerializeField] private Transform startPositionRight;
        [SerializeField] private Transform startPositionLeft;
        
        private float _nextSpawnTime;

        private void Update()
        {
            _nextSpawnTime += Time.deltaTime;

            if (!(timeOfSpawns < _nextSpawnTime)) return;
            Spawn(firstCar.gameObject, secondCar, startPositionRight, startPositionLeft);
            _nextSpawnTime = 0;
        }

        private void Spawn(GameObject obstacle, GameObject secondObstacle, Transform position, Transform secondPosition)
        {
            var firstPointPosition = position.position;
            var secondPointPosition = secondPosition.position;
            
            //Code smell :c 
            Instantiate(obstacle, new Vector3(firstPointPosition.x,
                    firstPointPosition.y,
                    firstPointPosition.z),
                Quaternion.identity);

            Instantiate(secondObstacle, new Vector3(secondPointPosition.x,
                    secondPointPosition.y,
                    secondPointPosition.z),
                Quaternion.identity);
        }
    }
}