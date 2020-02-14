using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 1;
    public float explosionForce = 10;
    public float explosionRadius = 2;


    // Start is called before the first frame update
    void Start()
    {
        Explode();
    }
    void Explode()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        
        foreach (Collider hit in hitColliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, 3.0F);
        }
    }
}
