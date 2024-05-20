﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH02_MusicApp.UserControls.MusicPage;

namespace TH02_MusicApp.Shared_Preferences
{
    public class MusicPlayerManager
    {
        private static MusicPlayerManager _instance;
        private IWavePlayer _waveOut;
        private AudioFileReader _audioFileReader;
        public string _currentSongPath;
        public MusicInfoItem _lastPlayedMusic = null;

        private MusicPlayerManager()
        {
            _waveOut = new WaveOutEvent();
        }

        public static MusicPlayerManager Instance => _instance ?? (_instance = new MusicPlayerManager());

        public void UpdateLastPlayedMusic(MusicInfoItem newMusicInfoBar)
        {
            // if there is a song playing,
            // update the icon of the last played MusicInfoBar
            if (_lastPlayedMusic != null)
            {
                _lastPlayedMusic.UpdatePlayButtonImage();
            }

            // if there is no song playing 
            newMusicInfoBar.UpdatePlayButtonImage();
            _lastPlayedMusic = newMusicInfoBar;
        }

        // method to play or pause a song using NAudio
        public void PlayOrPause(string songPath)
        {
            // case 1: click play on the song is playing
            if (_currentSongPath == songPath)
            {
                if (_waveOut.PlaybackState == PlaybackState.Playing)
                {
                    _waveOut.Pause();
                }
                else
                {
                    _waveOut.Play();
                }
            }
            // case 2: click play on another song or play the first time
            else
            {
                _waveOut.Stop(); // Stop the current playback before initializing a new one
                _audioFileReader?.Dispose(); // Dispose of the old AudioFileReader if it exists

                _currentSongPath = songPath;
                _audioFileReader?.Dispose();
                _audioFileReader = new AudioFileReader(songPath);
                _waveOut.Init(_audioFileReader);
                _waveOut.Play();
            }
        }

        public void Stop()
        {
            _waveOut.Stop();
            _currentSongPath = null;
            _audioFileReader?.Dispose();
            _audioFileReader = null;
        }

        public bool IsPlaying(string songPath)
        {
            return _currentSongPath == songPath && _waveOut.PlaybackState == PlaybackState.Playing;
        }
    }
}
