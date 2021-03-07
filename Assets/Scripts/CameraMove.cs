using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public int mode;
    public GameObject choose_pos;
    public GameObject choose_rot;
    public GameObject fight_pos, attack_pos;
    public Camera cam;
    public float FOV = 60f;


    //stablizer
    private Transform target_P;
    private Transform target_R;
    private Vector3 pos;
    //public GameObject colider;
    //public GameObject front;
    public float speed = 5;

    void Start()
    {
        mode = 1;
        target_P = choose_pos.transform;
       // target_R = choose_rot.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            target_P = choose_pos.transform;
            FOV = 60f;
           // target_R = choose_rot.transform;
            
        }else if (mode == 2)
        {
            target_P = fight_pos.transform;
            FOV = 10f;

        }else if (mode == 3)
        {
            target_P = attack_pos.transform;
            FOV = 60f;
        }
        cam.fieldOfView = FOV;
        this.transform.rotation = target_P.rotation;
        pos = target_P.position;
        this.transform.position = Vector3.Lerp(this.transform.position, pos, speed * Time.deltaTime);
    }
}
