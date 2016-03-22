using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelContoller : MonoBehaviour {

	public Canvas CMain;
	public Canvas CLevelSelect;

	public CanvasRenderer[] CMainChildren;
	public CanvasRenderer[] ClevelSelectChildren;

	public int[] Scenes;

	private float T;
	public float animspeed;
	private int anima;

	void Start() {
		ClevelSelectChildren = CLevelSelect.GetComponentsInChildren<CanvasRenderer>();
		CMainChildren = CMain.GetComponentsInChildren<CanvasRenderer>();
	}

	void Update() {
		T = T + Time.deltaTime * animspeed;


		if (anima == 2 || anima == 3 || anima == 4) {
			if (T >= 1) {
				anima = anima + 100;
			} else {
				foreach (CanvasRenderer Child2 in CMainChildren) {
					Child2.SetAlpha (1-T);
				}
			}
		}
		if (anima == 102) {
			anima = anima + 100;
			foreach (CanvasRenderer Child in ClevelSelectChildren) {
				Child.SetAlpha (0.001f);
			}
			CMain.enabled = false;
			CLevelSelect.enabled = true;
			T = 0;
		}
		if (anima == 202) {
			if (T >= 1) {
				anima = 0;
			} else {
				foreach (CanvasRenderer Child in ClevelSelectChildren) {
					Child.SetAlpha (T);
				}
			}
		}



		if (anima == 5) {
			if (T >= 1) {
				anima = anima + 100;
			} else {
				foreach (CanvasRenderer Child in ClevelSelectChildren) {
					Child.SetAlpha (1-T);
				}
			}
		}
		if (anima == 105) {
			anima = anima + 100;
			foreach (CanvasRenderer Child2 in CMainChildren) {
				Child2.SetAlpha (0.001f);
			}
			CMain.enabled = true;
			CLevelSelect.enabled = false;
			T = 0;
		}
		if (anima == 205) {
			if (T >= 1) {
				anima = 0;
			} else {
				foreach (CanvasRenderer Child2 in CMainChildren) {
					Child2.SetAlpha (T);
				}
			}
		}

	}

	void LevelSelect() {
		anima = 2;
		T = 0;
	}

	void MainMenu() {
		anima = 5;
		T = 0;
	}

	void LoadLevel1() {
		SceneManager.LoadScene(Scenes[1]);
	}
	void LoadLevel2() {
		SceneManager.LoadScene(Scenes[2]);
	}
	void LoadLevel3() {
		SceneManager.LoadScene(Scenes[3]);
	}
	void LoadLevel4() {
		SceneManager.LoadScene(Scenes[4]);
	}
	void LoadLevel5() {
		SceneManager.LoadScene(Scenes[5]);
	}
	void LoadLevel6() {
		SceneManager.LoadScene(Scenes[6]);
	}
	void LoadLevel7() {
		SceneManager.LoadScene(Scenes[7]);
	}
	void LoadLevel8() {
		SceneManager.LoadScene(Scenes[8]);
	}
	void LoadLevel9() {
		SceneManager.LoadScene(Scenes[9]);
	}

	
	// Update is called once per frame
}
