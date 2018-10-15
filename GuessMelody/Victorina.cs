﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public bool allDirectories = false;
        static public string lastFolder = "";
        static public string answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3",
                    allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(musicFiles);
            } catch
            {

            }
        }

        static string regKeyName = @"Software\Zerohout\GuessMelody";

        static public void WriteParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        static public void ReadParams()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart",false));
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories",false));
                }
            }
            finally
            {

                if (rk != null) rk.Close();
            }
        }

    }
}
