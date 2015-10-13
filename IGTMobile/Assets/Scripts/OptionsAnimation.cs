using UnityEngine;
using System.Collections;

public class OptionsAnimation : MonoBehaviour {

    public Animation slider;
    public AnimationClip open;
    public AnimationClip close;
    private bool isOpen;

	// Use this for initialization
    void Awake()
    {
        open.legacy = true;
        close.legacy = true;
    }
    void Start () {
        isOpen = false;
        slider.AddClip(open, "open");
        slider.AddClip(close, "close");
        slider.Stop("close");
        slider.Stop("open");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleOptions()
    {
        if (!isOpen)
        {
            slider.Stop("close");
            slider.Play("open");
            isOpen = true;
        }else
        {
            slider.Stop("open");
            slider.Play("close");
            isOpen = false;
        }
    }
}
