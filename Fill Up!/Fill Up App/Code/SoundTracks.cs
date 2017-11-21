using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace Fill_Up_App.Code
{
    class SoundTracks
    {
        public static void SoundTrack()
        {
            //var play = new MediaPlayer();
            MediaPlayer player = new MediaPlayer();
            string path = @"C:\Users\Rūta\source\repos\Social-Tap\Fill Up!\Fill Up App\FlyMe .mp3";
            player.SetDataSource(path);
            player.Start();

        }
    }
}