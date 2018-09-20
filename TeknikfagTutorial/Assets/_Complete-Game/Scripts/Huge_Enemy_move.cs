using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huge_Enemy_move : MonoBehaviour {

    // The target marker.
    private Vector3 target;
    private Vector3 spawntarget;

    // Speed in units per sec.
    public float speed;

    public bool fireMode = true;

    public GameObject Laser;

    private void Start()
    {
        Laser.SetActive(false);
        target = new Vector3(Random.Range(-6, 6), 0, 35);
        spawntarget = transform.position;
    }

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.

        if (fireMode)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, spawntarget, step);
        }

        if (transform.position == target)
        {
            StartCoroutine(FireWeapon());
        }
    }

    IEnumerator FireWeapon()
    {
        yield return new WaitForSeconds(2);
        Laser.SetActive(true);
        yield return new WaitForSeconds(2);
        Laser.SetActive(false);
        fireMode = false;
    }
}
