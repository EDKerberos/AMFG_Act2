using UnityEngine;

public class RocketAI : MonoBehaviour
{
    [SerializeField] private float travelSpeed;
    [SerializeField] private float lifeSpan;
    private float  lifeTimer;

    void Update()
    {
        this.transform.position += transform.up * travelSpeed * Time.deltaTime;

        lifeTimer += Time.deltaTime;
        if (lifeTimer >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
