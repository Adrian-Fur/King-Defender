using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPatch());
    }

    IEnumerator FollowPatch()
    {
        foreach(Waypoint waipoint in path)
        {
            transform.position = waipoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
