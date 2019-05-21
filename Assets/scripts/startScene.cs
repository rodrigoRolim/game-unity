using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour
{
   public void changemenuscene (string name) {

       Application.LoadLevel(name);
   }
   public void exitscene () {
       Debug.Log("has quit game");
      Application.Quit();
   }
}
