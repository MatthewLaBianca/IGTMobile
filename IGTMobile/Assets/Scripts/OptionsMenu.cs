using UnityEngine;
using System.Collections;

public class OptionsMenu : MonoBehaviour {
    public Animation options;
    public AnimationClip open;
    public AnimationClip close;
    // Use this for initialization
    private bool optionsOpen;
    void Awake()
    {
        open.legacy = true;
        close.legacy = true;
    }
	void Start () {
        optionsOpen = false;
        options.AddClip(open, "open");
        options.AddClip(close, "close");
        options.Stop("open");
        options.Stop("close");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleOpen()
    {
        if (!optionsOpen)
        {
            options.Play("open");
            optionsOpen = true;
        }else if(optionsOpen)
        {
            options.Play("close");
            optionsOpen = false;
        }
    }
}
