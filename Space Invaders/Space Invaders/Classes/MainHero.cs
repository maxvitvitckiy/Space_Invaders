using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Classes
{
    class MainHero
    {
        int speed;
        int vectorX;
        int lifeCount;
        Point location;
        Bitmap image;
        Rectangle area;

        public MainHero()
        {
            speed = 4;
            vectorX = 0;
            lifeCount = 3;
            location = new Point(10, 10);
            //image
            area = new Rectangle(location, image.Size);
        }
        
        public void Move()
        {
            if(location.X + speed*vectorX <  0 && location.X > ) // check form size
            location.X += speed * vectorX;
        }

    }
}
