using System;
using System.Media;
using System.IO;

namespace Ascension
{
    public static class AudioManager
    {
        private static SoundPlayer backgroundPlayer;
        private static SoundPlayer effectPlayer;

        // Plays a looping background sound.

        public static void PlayBackgroundSound(string audioPath)
        {
            try
            {
                if (File.Exists(audioPath))
                {
                    StopBackgroundSound(); // Stop any previously playing background sound
                    backgroundPlayer = new SoundPlayer(audioPath);
                    backgroundPlayer.PlayLooping();
                }
                else
                {
                    throw new FileNotFoundException($"Audio file not found: {audioPath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to play background sound: {ex.Message}");
            }
        }

      
        // Stops the currently playing background sound.

        public static void StopBackgroundSound()
        {
            backgroundPlayer?.Stop();
            backgroundPlayer = null;
        }

        // Plays a one-time sound effect.

        public static void PlayEffectSound(string audioPath)
        {
            try
            {
                if (File.Exists(audioPath))
                {
                    effectPlayer = new SoundPlayer(audioPath);
                    effectPlayer.Play();
                }
                else
                {
                    throw new FileNotFoundException($"Audio file not found: {audioPath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to play effect sound: {ex.Message}");
            }
        }
    }
}
