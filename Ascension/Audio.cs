using NAudio.Wave;
using System;

public static class AudioManager
{
    private static bool isMusicEnabled = true;
    private static bool isSoundEnabled = true;
    private static IWavePlayer backgroundPlayer;
    private static AudioFileReader backgroundReader;
    private static string currentBackgroundMusicPath;

    public static bool IsMusicEnabled
    {
        get => isMusicEnabled;
        set => isMusicEnabled = value;
    }

    public static bool IsSoundEnabled
    {
        get => isSoundEnabled;
        set => isSoundEnabled = value;
    }

    public static void PlayBackgroundSound(string audioPath)
    {
        if (!IsMusicEnabled || string.IsNullOrEmpty(audioPath)) return;

        try
        {
            if (currentBackgroundMusicPath == audioPath && backgroundPlayer != null)
                return; // Prevent restarting the same music

            StopBackgroundSound(); // Stop any currently playing track

            backgroundReader = new AudioFileReader(audioPath);
            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(backgroundReader);

            backgroundPlayer.PlaybackStopped += (s, e) =>
            {
                if (backgroundPlayer != null && backgroundReader != null)
                {
                    backgroundReader.Position = 0; // Loop playback
                    backgroundPlayer.Play();
                }
            };

            backgroundPlayer.Play();
            currentBackgroundMusicPath = audioPath;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing background sound: {ex.Message}");
        }
    }

    public static void StopBackgroundSound()
    {
        if (backgroundPlayer != null)
        {
            backgroundPlayer.Stop();
            backgroundPlayer.Dispose();
            backgroundPlayer = null;
        }

        if (backgroundReader != null)
        {
            backgroundReader.Dispose();
            backgroundReader = null;
        }

        currentBackgroundMusicPath = null;
    }

    public static void PlayEffectSound(string audioPath)
    {
        if (!IsSoundEnabled || string.IsNullOrEmpty(audioPath)) return;

        try
        {
            var effectPlayer = new WaveOutEvent();
            var effectReader = new AudioFileReader(audioPath);

            effectPlayer.Init(effectReader);
            effectPlayer.Play();

            effectPlayer.PlaybackStopped += (s, e) =>
            {
                effectPlayer.Dispose();
                effectReader.Dispose();
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing effect sound: {ex.Message}");
        }
    }
}
