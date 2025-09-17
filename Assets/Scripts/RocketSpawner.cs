using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    [SerializeField] private GameObject rocketPrefab;    
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float fireRate;
    [SerializeField] public int rocketCount = 4;
    private float intTimer;

    void Update()
    {
        intTimer += Time.deltaTime;
        if (intTimer >= fireRate)
        {
            LaunchRockets();
            intTimer = 0f;
            Debug.Log("Rockets fired!");
        }
    }

    private void LaunchRockets()
    {
        float shootAngle = 360f / rocketCount;

        for(int i = 0; i < rocketCount; i++)
        {
            float shootDirection = i * shootAngle;
            float radDirection = shootDirection * Mathf.Deg2Rad;

            Vector2 direction = new Vector2(Mathf.Cos(radDirection), Mathf.Sin(radDirection));

            float radAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Instantiate(rocketPrefab, shootPoint.position, Quaternion.Euler(0, 0, radAngle));
        }
    }
}
