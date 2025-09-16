using UnityEngine;

public class SinCosEx : MonoBehaviour
{
    [SerializeField] private float timeValue;
    [SerializeField] private float speed;
    [SerializeField] private float radius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeValue += Time.deltaTime * speed;

        this.transform.position += new Vector3(Mathf.Cos(timeValue) * radius, Mathf.Sin(timeValue) * radius, 0);
    }
    // sin = y axis + cos = x axis + tan = z axis(?)
}
