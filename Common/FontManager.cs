﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FontManager
    {
        public Font ChordFont { get; private set; }
        public Font NoteFont { get; private set; }
        public Font DefaultFont { get; private set; }
        public static FontManager Instance;
        static FontManager()
        {
            INIReader iniReader = new INIReader("Font.ini");
            Instance = new FontManager();
            Instance.ChordFont = new Font(iniReader.Data["ChordFontFamily"], float.Parse(iniReader.Data["ChordFontSize"]));
            Instance.NoteFont = new Font(iniReader.Data["NoteFontFamily"], float.Parse(iniReader.Data["NoteFontSize"]));
            // Instance.DefaultFont = new Font(iniReader.Data["DefaultFontFamily"], float.Parse(iniReader.Data["DefaultFontSize"]));
        }
    }
}
