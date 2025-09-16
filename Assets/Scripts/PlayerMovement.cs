using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpd;

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        transform.Translate(hIn put * moveSpd * Time.deltaTime, 0, 0);

        transform.Translate(0, vInput * moveSpd * Time.deltaTime, 0);
    }
}