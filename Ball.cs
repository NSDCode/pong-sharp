using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    public class Ball
    {
        public int width { get; } = 20;
        public int height { get; } = 20;
        public int speedX { get; set; } = 2;
        public int speedY { get; set; } = 2;
        public int pos_x { get; set; }
        public int pos_y { get; set; }

    }
}
