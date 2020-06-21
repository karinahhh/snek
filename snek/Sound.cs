using System;
using System.IO;

public class Sound
{
	WindowsMediaPlayer player = new WindowsMediaPlayer();
	private string pathToMedia;


	public Sounds(string pathToResources)
	{
		pathToMedia = pathToResources;
	}

	public void Play()
    {
		player.URL = pathToMedia + "mus.wav";
		player.settings.volume = 30;
		player.controls.play();
		player.settings.setMode("loop", true);
    }



	public void Eat()
    {
		player.URL = pathToMedia + "eating.mp3";
    }
}
