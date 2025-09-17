using UnityEngine;

public class PowerupAI : MonoBehaviour
{
    [SerializeField] private RocketSpawner scriptRef;
    [SerializeField] private Transform Player;
    [SerializeField] private float colDist;
    private float playerDist;

    void Update()
    {
        if (Player != null)
        {
            playerDist = Mathf.Sqrt(Mathf.Pow(Player.transform.position.x - this.transform.position.x, 2)
                + Mathf.Pow(Player.transform.position.y - this.transform.position.y, 2));
            var vectorDist = Vector3.Distance(Player.transform.position, this.transform.position);
            Debug.Log($"Distance {playerDist:F2}, Vector (vectorDist)");
        }

        if (playerDist <= colDist)
        {
            scriptRef.rocketCount++;
            Destroy(gameObject);
        }
    }
}
