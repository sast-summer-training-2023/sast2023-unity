using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;

	public Wave[] waves;

	// TODO: Connect to instances on scene.
	public Transform spawnPoint;
	
	private int waveIndex = 0;

	void Update ()
	{
	}

	//SpawnControl is call every time when SpawnTrigger Button is clicked
	public void SpawnControl()
	{
		if (waveIndex >= waves.Length)
			return;


		Wave wave = waves[waveIndex];

		EnemiesAlive = wave.count;

		for (int i = 0; i < wave.count; i++)
		{
			SpawnEnemy(wave.enemy);
		}

		waveIndex++;
	}
	void SpawnEnemy (GameObject enemy)	
	{
		// TODO: Task 2: Implement enemy spawning logic
	}

}
