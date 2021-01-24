using UnityEngine;
using System.Collections;

public class FlyTest : MonoBehaviour
{
    public GameObject box;

    private Transform Head;
    private Transform LeftAirfoil;
    private Transform RightArifoil;
    private Transform LeftTailAirfoil;
    private Transform RightTailAirfoil;


    //private float speed = 250.0f;

    private Rigidbody rb;

    void Start()
    {
        box = GameObject.Find("Plane1");

       // Head = transform.Find("Head");
        //LeftAirfoil = transform.Find("LeftAirfoil");
       // RightArifoil = transform.Find("RightAirfoil");
        LeftTailAirfoil = transform.Find("LeftTailAirfoil");
        RightTailAirfoil = transform.Find("RightTailAirfoil");

        rb = GetComponent<Rigidbody>();//私有变量，必须获取主键
    }

    void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime);
        //俯冲
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForceAtPosition(transform.up * 5.0f, LeftTailAirfoil.position);

            rb.AddForceAtPosition(transform.up * 5.0f, RightTailAirfoil.position);
        }
        //爬升
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForceAtPosition(transform.up * -5.0f, LeftTailAirfoil.position);

            rb.AddForceAtPosition(transform.up * -5.0f, RightTailAirfoil.position);
        }
        //左翻滚
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForceAtPosition(transform.up * -5.0f, LeftTailAirfoil.position);

            rb.AddForceAtPosition(transform.up * 5.0f, RightTailAirfoil.position);
        }
        //右翻滚
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForceAtPosition(transform.up * 5.0f, LeftTailAirfoil.position);

            rb.AddForceAtPosition(transform.up * -5.0f, RightTailAirfoil.position);
        }
        //右 移动
        else if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.right * 500.0f * -1 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.R))
        {
            Vector3 cube = GameObject.Find("Plane1").transform.position;
            Transform cube1 = GameObject.Find("Plane1").transform;
            cube1.Rotate(new Vector3(0, 30.0f / 60.0f, 0));
        }
    }
}