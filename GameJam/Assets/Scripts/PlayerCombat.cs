using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    // Update is called once per frame
    

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            
            PerformAttack();
            
        }

    }

    public void PerformAttack()
    {
        //play attack animation
        //Detect enemies in range
        //Damage enemies

        RapierFunction myRapierFunction = GetComponent<RapierFunction>();


    }
}
