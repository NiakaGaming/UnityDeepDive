using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Transform ball;
    public GameObject myPrefab;
    public GameObject myObj;
    [SerializeField]
    public ParticleSystem paricule;
    bool spawn = false;


    void Start()
    {
        myObj = Instantiate(myPrefab, new Vector3(80, 1, 109), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true)
        {
            myPrefab.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            spawn = false;
        }
        
    }

    public void RespawnBall()
    {
        myPrefab.transform.position = new Vector3(80, 0.8f, 109);
        // myPrefab.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        // myPrefab.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        // spawn = true;
        Destroy(myObj);
        myObj = Instantiate(myPrefab, new Vector3(80, 1, 109), Quaternion.identity);
        paricule.Play();
    }
}
