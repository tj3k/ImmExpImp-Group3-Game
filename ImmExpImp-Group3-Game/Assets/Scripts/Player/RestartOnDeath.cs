using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class RestartOnDeath : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            // Restarts On Water Collision from Bathroom Scene
            if (other.gameObject.CompareTag("Player"))
            { 
                Invoke(nameof(restartCheckpoint), 1f);
            }
        }

        private void restartCheckpoint()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
