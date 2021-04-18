using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour
{
    [SerializeField] private HealthController myHealthController;
    [SerializeField] private int damage;
    [SerializeField] private int heal;


    [SerializeField] private bool damageBool;
    [SerializeField] private bool healBool;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (damageBool)
            {
                myHealthController.playerHealth -= damage;
                myHealthController.UpdateHealth();
            } else if (healBool)
            {
                myHealthController.playerHealth += heal;
                myHealthController.UpdateHealth();
            }
        }
    }

}
