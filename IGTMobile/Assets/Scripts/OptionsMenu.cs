using UnityEngine;
using System.Collections;

public class OptionsMenu : MonoBehaviour {
    public Animation options;
    public AnimationClip open;
    public AnimationClip close;
    // Use this for initialization
    void Awake()
    {
        open.legacy = true;
        close.legacy = true;
    }
	void Start () {
        options.AddClip(open, "open");
        options.Stop("open");
        options.Stop("close");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleOpen()
    {
        options.Play("open");
    }
}
