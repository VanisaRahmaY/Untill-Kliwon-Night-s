using UnityEngine;

public class PlayerDeathOnCollision : MonoBehaviour
{
    public GameObject gameOverPanel;
    private void Start()
    {

        gameOverPanel.SetActive(false); 
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            Destroy(hit.gameObject);
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player mati. Game over.");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
