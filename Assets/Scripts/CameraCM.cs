using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraCM : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera cm;

    private void Start() {
        cm = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (tPlayer == null)
        {
            tPlayer = GameObject.FindWithTag("Player");
        }
        tFollowTarget = tPlayer.transform;
        cm.LookAt = tFollowTarget;
        cm.Follow = tFollowTarget;
    }
}
