using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBot : MonoBehaviour
{
    float moveSpeed = 0.005f;
    float rotateSpeed = 10.0f;
    //float force = 1;
    public GameObject[] pathParts;

    private int i;

    //Start is called before the first frame update
    void Start()
    {
        //rotation to target sphere
        Vector3 targetDirection = pathParts[2].transform.position - transform.position;
        float singleStep = rotateSpeed * Time.deltaTime;
        Vector3 newdirection = Vector3.RotateTowards(transform.forward, new Vector3(targetDirection.x, targetDirection.y, targetDirection.z), singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(new Vector3(newdirection.x, 0, newdirection.z));
        //var q = Quaternion.LookRotation(pathParts[0].transform.position - transform.position);
        //gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 10 * Time.deltaTime);

        //GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        //GetComponent<Rigidbody>().velocity = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject)
        {
            Vector3 targetDirection = pathParts[i].transform.position - transform.position;
            float singleStep = rotateSpeed * Time.deltaTime;
            Vector3 newdirection = Vector3.RotateTowards(transform.forward, new Vector3(targetDirection.x, targetDirection.y, targetDirection.z), singleStep, 0.0f);
            transform.rotation = Quaternion.LookRotation(new Vector3(newdirection.x, 0, newdirection.z));

            if (Vector3.Distance(transform.position, pathParts[i].transform.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, pathParts[i].transform.position, moveSpeed);
            }
            else
            {
                if (++i == pathParts.Length) Destroy(gameObject);
            }
        }
    }
}
