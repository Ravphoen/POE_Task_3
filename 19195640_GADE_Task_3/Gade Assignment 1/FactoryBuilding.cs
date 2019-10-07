using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Gade_Assignment_1
{
    class FactoryBuilding:Building
    {

        public FactoryBuilding(int xxpos, int yypos, int hhealth, int tteam, string ssymbol, int productionspeed)
        {
            this.b_xpos = xxpos;
            this.b_ypos = yypos;
            this.b_health = hhealth;
            this.b_max_health = hhealth;
            this.b_team = tteam;
            this.b_symbol = ssymbol;
        }

        //properties
        public bool destroyed { get; set; }
        public int XPos
        {
            get { return base.b_xpos; }
            set
            {

                if (value < 0)
                {
                    XPos = 0;
                }
                else if (value > 19)
                {
                    XPos = 20;
                }
                else
                {
                    XPos = value;
                }
            }
        }
        public int YPos
        {
            get { return base.b_ypos; }
            set
            {
                if (value < 0)
                {
                    YPos = 0;
                }
                else if (value > 19)
                {
                    YPos = 20;
                }
                else
                {
                    YPos = value;
                }

            }
        }
        public int Health
        {
            get { return base.b_health; }
            set { b_health = value; }
        }
        public int MaxHealth
        {
            get { return base.b_max_health; }
        }
        public int Team
        {
            get { return base.b_team; }
            set { b_team = value; }
        }
        public string Symbol
        {
            get { return base.b_symbol; }
            set { b_symbol = value; }
        }

        //new factory building fields.
        public int production_speed//
        {
            get { return production_speed; }
        }
        int spawn_point;
        public override void Death(List<Building>buildings)
        {
            foreach (Building FB in buildings)
            {
                if (FB == this)
                {
                    buildings.Remove(FB);
                    return;
                }
            }
        }
        public override string ToString()
        {
            string info = "";
            info += "BuildingInfo:";
            if (b_team == 1)
            {
                info += "Produces Melee Units";
            }
            if (b_team == 2)
            {
                info += "Produces Ranged Units";
            }
            else
            {
                info += "Produces Wizard Units";
            }
            info += "Building position :(" + b_xpos + "," + b_ypos + ")";
            info += "Building type: Resource Building";
            info += "\nBuilding Health: " + b_health;
            info += ".\nBuilding Max Health:" + b_max_health;
            info += ".\nBuilding team:" + b_team;
            info += ".\nBuilding Symbol:" + b_symbol;


            info += (destroyed ? "Building Status: Destroyed" : "Building Status: Operational");
            return info;
        }
        public BattleForm bf;
        public Map m;
                       
        public Map map;
        Random r = new Random();
        ResourceBuilding rb;

        public Unit UnitSpawner()
        {
            if (b_team == 1 && rb.Team ==1 && rb.resources_generated >1)//team 1 (Melee Units)
            {
                Unit unit;
                MeleeUnit m = new MeleeUnit(b_xpos, b_ypos + 1, 50, 7, 1 ,1 , "oP", false, "Warrior");
                unit = m;                
                return unit;
            }
            if (b_team ==2 && rb.Team == 2 && rb.resources_generated >1)//team 2 (Ranged Units)
            {
                Unit unit;
                RangedUnit ru = new RangedUnit(b_xpos,b_ypos + 1, 30, 10, 5, 2, "o|}", false, "Archer");
                unit = ru;
                return unit;
            }
            else if(b_team ==3 && rb.Team ==3 && rb.resources_generated >2) //team 3 (Wizard Units)
            {
                Unit unit;            
                WizardUnit w = new WizardUnit(b_xpos,b_ypos + 1, 40, 8, 1, 3, "o/*", false , "Wizard");
                unit = w;
                return unit;
            }
            
        }
    }
}
