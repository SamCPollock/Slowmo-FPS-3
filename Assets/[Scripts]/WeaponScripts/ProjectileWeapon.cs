using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : WeaponComponent
{

    protected override void FireWeapon()
    {
        if (weaponStats.bulletsInClip > 0 && !isReloading && !weaponHolder.playerController.isRunning)
        {
            base.FireWeapon();
            if (firingEffect)
            {
                firingEffect.Play();
            }



            print("BulletInClip Count: " + weaponStats.bulletsInClip);
        }

        else if (weaponStats.bulletsInClip <= 0)
        {
            weaponHolder.StartReloading();
            Debug.Log("AUTORELOADING");
        }

    }

}
