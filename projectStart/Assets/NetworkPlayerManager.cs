using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerManager : MonoBehaviourPun
{
    // Start is called before the first frame update
    public GameObject rhand;
    public GameObject lhand;
    public GameObject head;
    public GameObject body;


    public SkinnedMeshRenderer rmesh;
    public SkinnedMeshRenderer lmesh;
    public MeshRenderer hmesh;
    public MeshRenderer bmesh;
    GameObject rpos;
    GameObject lpos;
    GameObject hpos;

    void Start()
    {
        rpos = GameObject.FindGameObjectWithTag("righthand");
        lpos = GameObject.FindGameObjectWithTag("lefthand");
        hpos = GameObject.FindGameObjectWithTag("head");
        if (photonView.IsMine)
        {
            rmesh.enabled = false;
            lmesh.enabled = false;
            hmesh.enabled = false;
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

        head.transform.position = hpos.transform.position;
        head.transform.rotation = hpos.transform.rotation * Quaternion.Euler(0f, 180f, 0f);

        body.transform.position = head.transform.position - new Vector3(0, .5f, 0);
    }
}
