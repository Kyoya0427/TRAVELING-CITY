using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    //[SerializeField]
    //corContllor playerObj;

    //private Transform lookAt;
    //private Vector3 startOffset;
    //private int count;
    //private bool state;
    //private float speed = 8.0f;

    //private float transition = 0.0f;
    //private float animationDuration = 2.0f;
    //private Vector3 animationOffset = new Vector3(0, 5, 5);


    // Use this for initialization
    void Start()
    {

        //lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        //startOffset = transform.position - lookAt.position;

        //this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        //    count++;

        //    if (count> 2.0f)
        //    { 
        //        state = true;
        //    }
        //    if (state)
        //    {
        //        Vector3 new_pos = transform.position;
        //        new_pos.x = lookAt.transform.position.x + startOffset.x;
        //        new_pos.y = 8;
        //        new_pos.z = lookAt.transform.position.z + startOffset.z;

        //        transform.position = Vector3.Lerp(transform.position, new_pos, speed * Time.deltaTime);
        //    }
    }
}
    //moveVector = lookAt.position + startOffset;

    //moveVector.x = 0;

    //moveVector.y = Mathf.Clamp(moveVector.y, 3, 5);

    //if (transition> 1.0f)
    //{
    //    transform.position += new Vector3(0, 0, playerObj.GetNowSpeed() * Time.deltaTime);//moveVector;
    //}
    //else
    //{
    //    //ゲームが始まるまでのアニメーション
    //    transform.position = Vector3.Lerp(moveVector + animationOffset,moveVector,transition);
    //    transition += Time.deltaTime * 1 / animationDuration;
    //    transform.LookAt(lookAt.position + Vector3.up);
    //}

