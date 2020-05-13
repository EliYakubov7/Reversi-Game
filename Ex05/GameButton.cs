﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ex05
{
    // $G$ CSS-999 (-3) class name should start with Button
    public class GameButton : Button
    {
        private int m_ButtonX;
        private int m_ButtonY;

        public int X
        {
            get { return m_ButtonX; }
            set { m_ButtonX = value; }
        }

        public int Y
        {
            get { return m_ButtonY; }
            set { m_ButtonY = value; }
        }
    }
}
