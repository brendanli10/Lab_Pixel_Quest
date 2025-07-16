using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
public GameObject preFab;
public GameObject Bullet_2;
public Transform bulletTrash;
public Transform bulletSpawn;

private bool _canShoot= true;
private const float Timer=0.5f;
private float _currentTime=0.5f;

private void Update()
{   TimerMethod();
    Shoot();
    Bullet2();

    }


private void TimerMethod()
{
    if (!_canShoot)
    {
        _currentTime -= Time.deltaTime;
    if (_currentTime<0)
    {
        _canShoot=true;
        _currentTime=Timer;
    }
    }
    }
private void Shoot()
 {if(Input.GetKeyDown(KeyCode.Mouse0)&& _canShoot)
    {
        GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);
        bullet.transform.SetParent(bulletTrash);
        _canShoot= false;
    }
 }
private void Bullet2()

 {if(Input.GetKeyDown(KeyCode.Mouse1)&& _canShoot)
    {
        GameObject bullet = Instantiate(Bullet_2, bulletSpawn.position, Quaternion.identity);
        bullet.transform.SetParent(bulletTrash);
        _canShoot= false;
    }
}
}






