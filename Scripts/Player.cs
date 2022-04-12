using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private float _secondsBetweenShoot;

    private float _lastShootTime;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_lastShootTime <= 0)
        {
            _animator.Play("Shoot");
            _weapon.Shoot();
            _lastShootTime = _secondsBetweenShoot;
        }

        _lastShootTime -= Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}