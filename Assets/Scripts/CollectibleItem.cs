using UnityEngine;
using System.Collections;

public class CollectibleItem : MonoBehaviour {
    public AudioClip CollectionSound;
    public int ScoreBonus;
    public int TimeBonusInSeconds;

    private AudioSource source;
    private bool AlreadyTriggered;
	
	void Start () {
        source = gameObject.AddComponent<AudioSource>();
        AlreadyTriggered = false;
	}

    void OnTriggerEnter(Collider collider)
    {
        if (!AlreadyTriggered)
        {
            source.PlayOneShot(CollectionSound);
            // TODO :: Add score and time to GameManager
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Invoke("RemoveCollectible", 1.0f);
        }
    }

    void RemoveCollectible()
    {
        Destroy(gameObject);
    }
}
