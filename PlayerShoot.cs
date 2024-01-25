using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
  [SerializeField]
  private Gun gun;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gun.Fire();
        }
    }
  
}
