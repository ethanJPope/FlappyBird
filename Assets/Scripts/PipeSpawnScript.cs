using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 10;
    void Start(){
        SpawnPipe();

    }

    // Update is called once per frame
    void Update(){
        if(timer < spawnRate) {
            timer = timer + Time.deltaTime;
        }
        else {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
