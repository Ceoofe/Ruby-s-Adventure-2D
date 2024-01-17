using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem particles;
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.health  < controller.maxHealth)
            {
                particles.Play();
                controller.ChangeHealth(1);
                Destroy(gameObject, 0.3f);
            }
        }
    }
}
