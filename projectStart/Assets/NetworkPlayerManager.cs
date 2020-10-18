using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerManager : MonoBehaviourPun
{
    // Start is called before the first frame update
    public GameObject rhand;
    public GameObject lhand;

    public SkinnedMeshRenderer rmesh;
    public SkinnedMeshRenderer lmesh;
    GameObject rpos;
    GameObject lpos;

    void Start()
    {
        rpos = GameObject.FindGameObjectWithTag("righthand");
        lpos = GameObject.FindGameObjectWithTag("lefthand");
        if (photonView.IsMine)
        {
            rmesh.enabled = false;
            lmesh.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine == false && PhotonNetwork.IsConnected == true)
        {
            return;
        }

        rhand.transform.position = rpos.transform.position;
        lhand.transform.position = lpos.transform.position;

        rhand.transform.rotation = rpos.transform.rotation;
        lhand.transform.rotation = lpos.transform.rotation;
    }
}
