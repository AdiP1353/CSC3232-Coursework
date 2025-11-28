using UnityEngine;

public class Shotgun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject _bulletSpawnPoint;
    [SerializeField] private float _bulletSpeed = 600;
    
    
    private PlayerLocomotionInput _playerLocomotionInput; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerLocomotionInput = transform.root.GetComponent<PlayerLocomotionInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerLocomotionInput.AttackPressed)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, _bulletSpawnPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * _bulletSpeed);
        Destroy(bullet, 1f);
    }
}
