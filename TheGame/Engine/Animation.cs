using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Engine
{
    internal class Animation
    {
        private string aName;
        private Rectangle aframeSize;
        private int aframeCount;
        private int 



























        //private string _name;
        //private int _frameCount;
        //private int _frameWidth;
        //private int _frameHeight;
        //private int _sheetColumns;
        //private int _sheetRows;
        //private int _currentFrame;
        //private float _frameDuration;
        //private float _elapsedTime;
        //private bool _isLooping;
        //private bool _isPlaying;

        //public Animation(
        //    string name,
        //    int frameCount,
        //    int frameWidth,
        //    int frameHeight,
        //    int sheetColumns,
        //    int sheetRows,
        //    float frameDuration,
        //    bool isLooping = true)
        //{
        //    _name = name;
        //    _frameCount = frameCount;
        //    _frameWidth = frameWidth;
        //    _frameHeight = frameHeight;
        //    _sheetColumns = sheetColumns;
        //    _sheetRows = sheetRows;
        //    _frameDuration = frameDuration;
        //    _isLooping = isLooping;
        //    _currentFrame = 0;
        //    _elapsedTime = 0f;
        //    _isPlaying = false;
        //}

        //public int CurrentFrame => _currentFrame;
        //public bool IsPlaying => _isPlaying;
        //public bool IsLooping => _isLooping;
        //public float FrameDuration => _frameDuration;
        //public int FrameCount => _frameCount;

        //public void Play()
        //{
        //    _isPlaying = true;
        //    _currentFrame = 0;
        //    _elapsedTime = 0f;
        //}

        //public void Stop()
        //{
        //    _isPlaying = false;
        //    _currentFrame = 0;
        //    _elapsedTime = 0f;
        //}

        //public void Pause()
        //{
        //    _isPlaying = false;
        //}

        //public void Resume()
        //{
        //    _isPlaying = true;
        //}

        //public void Update(float deltaTime)
        //{
        //    if (!_isPlaying) return;

        //    _elapsedTime += deltaTime;
        //    while (_elapsedTime >= _frameDuration)
        //    {
        //        _elapsedTime -= _frameDuration;
        //        _currentFrame++;
        //        if (_currentFrame >= _frameCount)
        //        {
        //            if (_isLooping)
        //            {
        //                _currentFrame = 0;
        //            }
        //            else
        //            {
        //                _currentFrame = _frameCount - 1;
        //                _isPlaying = false;
        //                break;
        //            }
        //        }
        //    }
        //}

        //public Rectangle GetSourceRectangle()
        //{
        //    int col = _currentFrame % _sheetColumns;
        //    int row = _currentFrame / _sheetColumns;
        //    return new Rectangle(
        //        col * _frameWidth,
        //        row * _frameHeight,
        //        _frameWidth,
        //        _frameHeight
        //    );
        //}
    }
}
