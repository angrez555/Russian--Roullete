using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
   public  class gun
    {
        public int lodedgunspin;
        public int shotawayBullete = 0;
        public int shot = 0;
        public int chance = 2;
        public int shotsremain = 6;

        public int bulletechange(int changebul)
        {
            if (changebul == 6)
            {
                changebul = 1;
            }
            else
            {
                changebul++;
            }
            return changebul;
        }
        public int Shootaway()
        {

            if (lodedgunspin == 1 && chance == 2 && shotsremain > 0)
            {

                shotawayBullete = 10;


            }
            if (lodedgunspin == 1 && chance == 1 && shotsremain > 0)
            {

                shotawayBullete = 5;

            }

            else if (shotsremain > 0 && lodedgunspin != 1)
            {
                shotawayBullete = 0;
                shotsremain = shotsremain - 1;
                lodedgunspin = bulletechange(lodedgunspin);



            }
            return shotawayBullete;
        }
    

        public int Shootbullete()
        {
            if (shotsremain > 0 && lodedgunspin == 1)
            {

                shot = 1;




            }
            else if (shotsremain > 0 && lodedgunspin != 1)
            {
                shot = 2;

            }
            return shot;
        }
    }
}
