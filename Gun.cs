using UnityEngine;

public abstract class Gun : MonoBehaviour
{
  private int currentAmmo = 10;
  private int maxAmmo = 10;

  public abstract void Fire();
}
