using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -0.03f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, this.dropSpeed, 0);
        if (transform.position.y < -0.7f)
        {
            Destroy(gameObject);
        }
    }
}
