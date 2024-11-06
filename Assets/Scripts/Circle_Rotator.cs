using UnityEngine;

public class Circle_Rotator : MonoBehaviour
{
    public float rotate_Speed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotate_Speed * Time.deltaTime);
    }
}
