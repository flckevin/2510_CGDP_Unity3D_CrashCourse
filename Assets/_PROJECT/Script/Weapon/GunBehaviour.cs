using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    public int ammo;
    public float bulletSpeed;
    public Transform gunBarrel;
    public Rigidbody bulletPrefab;

    private int _defaultAmmo;

    // Start is called before the first frame update
    void Start()
    {
        GunInitializer();
    }

    // Update is called once per frame
    void Update()
    {
        GunInput();
    }
    
    private void GunInitializer()
    {
        _defaultAmmo = ammo;
    }

    private void GunInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(ammo > 0)
            {
                Rigidbody _spawnedBullet = Instantiate(bulletPrefab,gunBarrel.transform.position,Quaternion.identity);
                _spawnedBullet.AddRelativeForce(gunBarrel.forward*bulletSpeed);
                ammo--;
            }
            
        }
    }
}
