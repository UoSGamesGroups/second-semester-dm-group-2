using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInFadeOut : MonoBehaviour {

		
		[SerializeField] bool isFadeIn;
		[SerializeField]public string SceneName{get;set;}
		[SerializeField] float fadeSpeed;
		Image image;


		void Awake()
		{
			image = GetComponent<Image>();
		}

		void Update()
		{
			if(isFadeIn)
			{
				FadeIn();
			}
			else
			{
				FadeOut();
			}
		}


		void FadeIn()
		{
			if(image.color.a < 1)
			{
				image.color += new Color(0,0,0,1) * Time.deltaTime * fadeSpeed;
			}
			else
			{
				SceneManager.LoadScene(SceneName);
			}
		}

		void FadeOut()
		{
			if(image.color.a >0)
			{
				image.color -= new Color(0,0,0,1) * Time.deltaTime * fadeSpeed;
			}
		}
	}
