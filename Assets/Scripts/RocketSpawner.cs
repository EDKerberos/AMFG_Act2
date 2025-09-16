using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    [SerializeField] private float fireRate;
    [SerializeField] private float rocketCount;
    //[SerializeField] private float spawnDistance;
    private GameObject rocketPrefab;
    [SerializeField] private float timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            launchRockets();
            timer = 0f;
            Debug.Log("Rockets fired!");
        }
    }

    private void launchRockets()
    {

    }
}
