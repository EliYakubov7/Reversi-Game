using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ex05
{
    // $G$ DSN-999 (-3) Better use a struct here
    public class Player
    {
        private readonly Color m_color;
        private bool m_IsComputerPlaying = false;
        private List<ValidMove> m_PlayerValidMoveList;

        public Player(Color i_Color)
        {
            m_color = i_Color;
        }

        public Color Color
        {
            get
            {
                return m_color;
            }
        }

        public bool IsComputerPlaying
        {
            get { return m_IsComputerPlaying; }
            set { m_IsComputerPlaying = value; }
        }

        public List<ValidMove> PlayerValidMoveList
        {
            get { return m_PlayerValidMoveList; }
            set { m_PlayerValidMoveList = value; }
        }
    }
}
