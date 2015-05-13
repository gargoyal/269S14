using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Pacman
{
  class Pacman : Sprite
  {
    public Image pacmanUp = Image.FromFile("../../images/pacmanUp.gif");
    public Image pacmanDown = Image.FromFile("../../images/pacmanDown.gif");
    public Image pacmanRight = Image.FromFile("../../images/pacmanRight.gif");
    public Image pacmanLeft = Image.FromFile("../../images/pacmanLeft.gif");

    //public Image pacUclose = Image.FromFile("../../images/pacUclose.gif");
    //public Image pacDclose = Image.FromFile("../../images/pacDclose.gif");
    //public Image pacRclose = Image.FromFile("../../images/pacRclose.gif");
    //public Image pacLclose = Image.FromFile("../../images/pacLclose.gif");
  }
}
