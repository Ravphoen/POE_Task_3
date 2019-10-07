using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gade_Assignment_1
{
    class ResourceBuilding : Building
    {
        public bool destroyed { get; set; }
        public Map m;
        BattleForm bf = new BattleForm();
        
        public ResourceBuilding(int xxpos, int yypos, int hhealth, int tteam, string ssymbol, int resources)
        {
            this.b_xpos = xxpos;
            this.b_ypos = yypos;
            this.b_health = hhealth;
            this.b_max_health= hhealth;
            this.b_team = tteam;
            this.b_symbol = ssymbol;
            remaning_resources = resources;
        }
        //properties
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
        
        //new resource building fields
        string resource_type;
        public int resources_generated { get; set; }
        int resources_per_round = 1;//will generate 1 per round
        int remaning_resources;
        

        public int ResourceGeneration()
        {
            int resourcetemp = resources_generated;
            if (destroyed==false)//if building is not destroyed
            {
                if (remaning_resources >= resources_per_round)
                {
                    resources_generated += resources_per_round;
                    remaning_resources -= resources_per_round;
                }
                else if (remaning_resources > 0)
                {
                    resources_generated += remaning_resources;
                    remaning_resources = 0;
                }
            }
            resourcetemp = resources_generated - resourcetemp; // shows the resources
            return resourcetemp;
        }

        //implementing and overriding building's abstract methods
        public override void Death(List<Building>buildings)
        {

            foreach (Building RB in buildings)
            {
                if (RB == this)
                {
                    buildings.Remove(RB);
                    return;
                }
            }
        }
        public override string ToString()
        {
            //overriding the ToString method.
            string info = "";
            info += "BuildingInfo:";
            if (b_team == 1)
            {
                info += "Produces Melee Units";
            }
            if(b_team == 2)
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
            info+= ".\nBuilding Symbol:" + b_symbol;
                        
            
            info += (destroyed ? "Building Status: Destroyed" : "Building Status: Operational");
            return info;
            ;
        }
        //public override void Save()
        //{
        //    StreamWriter savestream;
        //    savestream = File.CreateText("c:ResourceBuildingInfo.txt");
        //    savestream.WriteLine(bf.Text = m.get_resource_building_info());
        //    savestream.Close();
        //    bf.Text = ("Created File!");
        //}
    }
}
