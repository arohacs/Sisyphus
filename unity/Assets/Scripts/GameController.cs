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
	
	void Start () 
	{
		_audioSource = GetComponent<AudioSource>();
		
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
				break;
				
			case GameState.PAUSED:
				_audioSource.Pause();
				break;
				
			case GameState.GAMEOVER:
				_audioSource.Stop();
				break;
				
			default:
				break;
			}
		}
	}
	
}
