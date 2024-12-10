using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void Shoot(Vector3 dir)
        {
            GetComponent<Rigidbody>().AddForce(dir);
        }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play(); 
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }
}
