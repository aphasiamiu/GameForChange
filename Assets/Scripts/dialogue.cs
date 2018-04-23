using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogue : MonoBehaviour {
    float t;
    public GameObject finger;
    public GameObject talk;
    public List<string> dialog;
    public List<string> tags;
    private Dictionary<string, string> _dialogDic;
    public List<bool> _flags;
    public bool flag = false;
    // Use this for initialization
    void Start () {
        t = Time.time;
        _flags = new List<bool>();
        for(int i=0;i<4;i++)
        {
            _flags.Add(false);
        }
        if (dialog.Count==tags.Count)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                _dialogDic.Add(tags[i], dialog[i]);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        flag = false;
        if (Time.time - t > 5)
        {
            t = Time.time;
            for (int i = 0; i < ReadSelectedUser.Instance.hashtags.Count; i = i + 1)
            {
                tags[i] = ReadSelectedUser.Instance.hashtags[i];
                if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap)
                {
                    flag = true;
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#LOL"))
                    {
                        talk.GetComponent<Text>().text = "I love how kids talk nowadays, ROFL!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#USA"))
                    {
                        talk.GetComponent<Text>().text = "Greatest country on the planet, aren’t I right, ladies and gentlemen?";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#ThePeopleLoveMe"))
                    {
                        talk.GetComponent<Text>().text = "Not surprising, considering my extremely SMART brain!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Winning"))
                    {
                        talk.GetComponent<Text>().text = "A lot of people said I couldn’t do it, but they were WRONG, and they’ll keep on being WRONG";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#DrillBabyDrill"))
                    {
                        talk.GetComponent<Text>().text = "Couldn’t agree more! We’ve got to get back into that bedrock and create more jobs!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Sad"))
                    {
                        talk.GetComponent<Text>().text = "TOO TRUE, this country is in a sorry state!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#TheGreatest"))
                    {
                        talk.GetComponent<Text>().text = "Everyone knows it! I’ve got the greatest words, the best words.";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#PhonyPress"))
                    {
                        talk.GetComponent<Text>().text = "Right! They keep focusing on me, but they can’t handle the TRUTH.";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Cute"))
                    {
                        talk.GetComponent<Text>().text = "This would look good on my Pinterest board!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#PhonyPress"))
                    {
                        talk.GetComponent<Text>().text = "Right! They keep focusing on me, but they can’t handle the TRUTH.";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Scandal"))
                    {
                        talk.GetComponent<Text>().text = "Oh look, it’s the DISHONEST media at it again.";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#WinnersOnly"))
                    {
                        talk.GetComponent<Text>().text = "So true! No room for LOSERS in this country!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Lolcats"))
                    {
                        talk.GetComponent<Text>().text = "Everyone knows I’m the best with cats, haven’t got scratched once, not even once!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Money"))
                    {
                        talk.GetComponent<Text>().text = "Now that I’m in charge, you’re going to start seeing a lot more of that around here!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#BackInBlack"))
                    {
                        talk.GetComponent<Text>().text = "We need more jobs, and we need them right here in AMERICA";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "inPOTUSweTRUST"))
                    {
                        talk.GetComponent<Text>().text = "Right! I won BIG, the American people are behind me!";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#Jobs"))
                    {
                        talk.GetComponent<Text>().text = "We need more jobs, and we need them right here in AMERICA.";
                    }
                    if (ReadSelectedUser.Instance.hashpoints[i] > hand.Instance.cap && string.Equals(ReadSelectedUser.Instance.hashtags[i], "#DontBeFooled"))
                    {
                        talk.GetComponent<Text>().text = "Dishonest crooks still hiding in our government and media, don’t listen to them!!";
                    }
                }
            }
            
            if (flag == false)
            {
                int i = Random.Range(0, 4);
                if (i==0)
                talk.GetComponent<Text>().text = "Don't worry people, we're gonna take care of this.";
                if (i==1)
                    talk.GetComponent<Text>().text = "I'm gonna protect this country and everything we love about it!";
                if (i==2)
                    talk.GetComponent<Text>().text = "All of our enemies? BAM! Right off the map. Wouldn't that be nice?";
                if (i==3)
                    talk.GetComponent<Text>().text = "So get ready folks, this thing is gonna be HUGE!";
            }
           
        }
        
    }
    private void setFalseExcept(int index)
    {
        for (int i = 0; i < 4; i++)
        {
            if(i== index)
            {
                continue;
            }
            _flags[i]=false;
        }
    }
   
}
