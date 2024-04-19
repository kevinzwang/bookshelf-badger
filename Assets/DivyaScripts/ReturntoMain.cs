using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturntoMain : MonoBehaviour
{
    public void MovetoScene(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }
}
