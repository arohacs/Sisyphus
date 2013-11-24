using UnityEngine;
using System.Collections;

public enum GameState
{
	UNDEFINED,
	START,
	PLAYING,
	PAUSED,
	GAMEOVER,
}

public class GameController : MonoBehaviour {
	
	private GameState _gameState = GameState.UNDEFINED;
	private AudioSource _audioSource;
	
	private ScoreLabel _score;
	private GutterController _gutterController;
	private CameraController _cameraController;
	
	void Start () 
	{
		_audioSource = GetComponent<AudioSource>();
		_gutterController = GameObject.Find("GutterController").GetComponent<GutterController>();
		_cameraController = Camera.main.GetComponent<CameraController>();
		//_cameraController = GameObject.Find("MainCamera").GetComponent<CameraController>();
		_score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreLabel>();
		
		GameState = GameState.PLAYING;
	}
	
	public GameState GameState
	{
	
		get {
			return _gameState;
		}
		set {
			
			_gameState = value;
			
			switch(_gameState) {
				
			case GameState.START:
				
				break;
				
			case GameState.PLAYING:
				_audioSource.Play();
				_gutterController.Play();
				break;
				
			case GameState.PAUSED:
				_audioSource.Pause();
				_gutterController.Pause();
				break;
				
			case GameState.GAMEOVER:
				_audioSource.Stop();
				_gutterController.Pause ();
				break;
				
			default:
				break;
			}
		}
	}
	
	public void Miss()
	{
		Debug.Log("Miss");
	}
	
	public void Hit()
	{
		Debug.Log("Hit");
		_score.IncrementScore(10);
		_cameraController.IncrementIncline(10.0f);
	}
	
}
