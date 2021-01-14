using UnityEngine;

namespace Game.Scripts
{
    public class TimeSystem : MonoBehaviour
    {
        [SerializeField] private float slowFactor = 0.05f;
        [SerializeField] private float slowLenght = 2f;

        private void Update() => Normalise(slowLenght);

        public void SlowMotion()
        {
            Time.timeScale = slowFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
        }

        private void Normalise(float slowOfLenght)
        {
            Time.timeScale += (1f / slowOfLenght) * Time.unscaledDeltaTime;
            Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        }
    }
}
