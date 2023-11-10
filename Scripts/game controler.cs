using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamecontroler : MonoBehaviour
{

    public int whosturn; //0 = x, 1 = O
    public int turncounter; // count the no. of turns played
    public GameObject[] turnIcons; // displays whos turn it is;
    public Sprite[] playerIcons; 
    public Button[] tictactoespaces;
    public int[] markedspaces;

    public TextMeshProUGUI winnertext;

    public GameObject[] winningline;
    public GameObject winnerpanel;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    public void GameSetup(){
        whosturn = 0;
        turncounter = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
        for(int i = 0; i < tictactoespaces.Length; i++){
            tictactoespaces[i].interactable = true;
            tictactoespaces[i].GetComponent<Image>().sprite = null;        }

        for(int i = 0; i < markedspaces.Length; i++){
            markedspaces[i] = -100;
        }
    }

        

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void tictactoebutton(int whichnumber){
        tictactoespaces[whichnumber].image.sprite = playerIcons[whosturn];
        tictactoespaces[whichnumber].interactable = false;
        markedspaces[whichnumber] = whosturn+1;
        // nextmainbox(whichmainbox);

        // turncounter++;
        // if(turncounter > 4){
        //     winnercheck();
        // }
//D:\unity\My project\Assets\Scripts\game controler.cs


        if(whosturn == 0){
            whosturn = 1;
            turnIcons[0].SetActive(false);
            turnIcons[1].SetActive(true);
        }
        else{
            whosturn = 0;
            turnIcons[0].SetActive(true);
            turnIcons[1].SetActive(false);
        }
    }

    // void nextmainbox(int mainbox){

    // }

    // void winnercheck(){
    //     int s1 = markedspaces[0] + markedspaces[1] + markedspaces[2];
    //     int s2 = markedspaces[3] + markedspaces[4] + markedspaces[5];
    //     int s3 = markedspaces[6] + markedspaces[7] + markedspaces[8];
    //     int s4 = markedspaces[0] + markedspaces[3] + markedspaces[6];
    //     int s5 = markedspaces[1] + markedspaces[4] + markedspaces[7];
    //     int s6 = markedspaces[2] + markedspaces[5] + markedspaces[8];
    //     int s7 = markedspaces[0] + markedspaces[4] + markedspaces[8];
    //     int s8 = markedspaces[2] + markedspaces[4] + markedspaces[6];

    //     var solution = new int[] {s1,s2,s3,s4,s5,s6,s7,s8};
    //     for(int i = 0; i < solution.Length; i++){
    //         if(solution[i] == 3*(whosturn+1)){
    //             winnerdisplay(i);
    //             return;
    //         }
    //     }
    // }

    // void winnerdisplay(int index){
    //     winnerpanel.gameObject.SetActive(true);
    //     if(whosturn == 0){
    //         winnertext.text = "Player X Wins!";
    //     }

    //     else if(whosturn == 1){
    //         winnertext.text = "Player O wins!";
    //     }

    //     winningline[index].SetActive(true);
        
    // }
}
