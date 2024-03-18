using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpawnDressColour : MonoBehaviour
{
    public GameObject PinkDress;
    public GameObject BlueDress;
    public GameObject BlackDress;
    public GameObject yellowDress;
    public Button ButtonPink;
    public Button ButtonBlue;
    public Button ButtonBlack;
    public Button ButtonYellow;

    private GameObject spawnedObject;
    public void ButtonPressed()
    {
         
    }

    // Start is called before the first frame update
    void Start()
    {
        ButtonPink.onClick.AddListener(SpawnPink);
        ButtonBlue.onClick.AddListener(SpawnBlue);
        ButtonBlack.onClick.AddListener(SpawnBlack);
        ButtonYellow.onClick.AddListener(SpawnYellow);
    }
    void SpawnYellow()
    {
        if (spawnedObject != null)
            Destroy(spawnedObject);

        spawnedObject = Instantiate(yellowDress, transform.position, Quaternion.identity);
    }
    void SpawnPink()
    {
        if (spawnedObject != null)
            Destroy(spawnedObject);

        spawnedObject = Instantiate(PinkDress, transform.position, Quaternion.identity);
    }

    void SpawnBlue()
    {
        if (spawnedObject != null)
            Destroy(spawnedObject);

        spawnedObject = Instantiate(BlueDress, transform.position, Quaternion.identity);
    }

    void SpawnBlack()
    {
        if (spawnedObject != null)
            Destroy(spawnedObject);

        spawnedObject = Instantiate(BlackDress, transform.position, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
