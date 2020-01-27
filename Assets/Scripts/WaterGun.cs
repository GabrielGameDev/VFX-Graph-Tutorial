using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class WaterGun : MonoBehaviour
{

    public VisualEffect vfx;
    public float inputForce = 1;

    private float multiplier;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            multiplier += Time.deltaTime * inputForce;
        }
        else
        {
            multiplier -= Time.deltaTime * inputForce;
        }

        multiplier = Mathf.Clamp(multiplier, 0, 1);

        vfx.SetFloat("Multiplier", multiplier);
    }
}
