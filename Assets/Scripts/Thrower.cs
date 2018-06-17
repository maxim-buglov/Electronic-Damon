using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour {

    public GameObject GameObject;
    public int WaitSeconds;

	// Use this for initialization
    IEnumerator Start()
    {
        do
        {
            yield return new WaitForSeconds(WaitSeconds);
            Instantiate(GameObject, transform.position, transform.rotation);
        } while (true);
    }
}
