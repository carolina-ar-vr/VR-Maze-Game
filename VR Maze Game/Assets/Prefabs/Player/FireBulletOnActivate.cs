using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public GameObject muzzleFlash;
    public Transform spawnPoint;

    public float fireSpeed = 10;
    public float recoilForce = 15;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg) 
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.transform.rotation = transform.rotation * Quaternion.Euler(90, 0, 0);
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);

        GameObject spawnedMuzzleFlash = Instantiate(muzzleFlash, spawnPoint.position + (new Vector3(0.05f, 0, 0)), spawnPoint.rotation) as GameObject;
        spawnedMuzzleFlash.transform.rotation = transform.rotation * Quaternion.Euler(0, -90, 0);
        Destroy(spawnedMuzzleFlash, 0.1f);

        ApplyRecoil();
    }

    void ApplyRecoil()
    {
        Rigidbody gunRigidbody = GetComponent<Rigidbody>();
        if (gunRigidbody != null)
        {
            gunRigidbody.AddForce(-transform.forward * recoilForce, ForceMode.Impulse);
        }
    }
}
