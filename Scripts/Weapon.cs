using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bulletTemplate;

    public void Shoot()
    {
        Instantiate(_bulletTemplate, _shootPoint.position, transform.rotation);
    }
}