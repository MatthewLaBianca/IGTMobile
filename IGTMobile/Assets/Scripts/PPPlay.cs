using UnityEngine;
using System.Collections;

public class PPPlay : MonoBehaviour {

    public Animation menu;
    public AnimationClip slideOffScreen;

    void Awake()
    {
        slideOffScreen.legacy = true;
    }
	// Use this for initialization
	void Start () {
        menu.AddClip(slideOffScreen, "slideOffScreen");
        menu.Stop("slideOffScreen");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayGame()
    {
        menu.Play("slideOffScreen");
    }
}
