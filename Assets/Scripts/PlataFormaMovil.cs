using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataFormaMovil : MonoBehaviour
{

    public GameObject ObjetoMover;

    public Transform StartPoint;

    public Transform MiddlePoint;

    public Transform EndPoint;

    public float Velocidad;

    private Vector3 MoverHacia;
    // Start is called before the first frame update
    void Start()
    {
        MoverHacia = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoMover.transform.position = Vector3.MoveTowards(ObjetoMover.transform.position, MoverHacia, Velocidad * Time.deltaTime);


        if(ObjetoMover.transform.position == EndPoint.position)
        {
            MoverHacia = StartPoint.position;
        }
        if (ObjetoMover.transform.position == StartPoint.position)
        {
            MoverHacia = MiddlePoint.position;
        }
        if (ObjetoMover.transform.position == MiddlePoint.position) 
        {
            MoverHacia = EndPoint.position;
        }
      
    }
}
