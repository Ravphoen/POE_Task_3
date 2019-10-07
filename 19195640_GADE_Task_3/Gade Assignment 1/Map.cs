using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Gade_Assignment_1//task 3
{
    class Map
    {
        public string[,] map1;

        public List<Unit> units = new List<Unit>();
        public List<RangedUnit> rangedUnits;
        public List<MeleeUnit> meleeUnits;
        public List<WizardUnit> wizardUnits;

        public List<Building> buildings = new List<Building>();
        public List<FactoryBuilding> factory_buildings;
        public List<ResourceBuilding> resource_buildings;
        
        

        BattleForm bf = new BattleForm();

        public Random r = new Random();
        

        public Map()
        {
            //numberofunits and numberofbuildings are declared in game engine
            int mapsize = bf.mapsize;          
            map1 = new string[mapsize, mapsize];
            //Ranged Units (Team 1)
            rangedUnits = new List<RangedUnit>();
            ranged_unit_amount = bf.numberofunits / 3;

            //Melee Units (Team 2)
            meleeUnits = new List<MeleeUnit>();
            melee_unit_amount = bf.numberofunits / 3;

            //Wizard Units (Team 3)
            wizardUnits = new List<WizardUnit>();
            wizard_unit_amount = bf.numberofunits / 3;
            
            factory_buildings = new List<FactoryBuilding>();
            T1_factory_building_amount  = bf.numberofbuildings / 6;
            T2_factory_building_amount  = bf.numberofbuildings / 6;
            T3_factory_building_amount  = bf.numberofbuildings / 6;


            resource_buildings = new List<ResourceBuilding>();
            T1_resource_building_amount = bf.numberofbuildings / 6;
            T2_resource_building_amount = bf.numberofbuildings / 6;
            T3_resource_building_amount = bf.numberofbuildings / 6;
            
        }
        public enum Direction
        {
            North,
            South,
            East,
            West
        }

        //variables storing how many units to spawn. Assigned in constructor using form values.
        int ranged_unit_amount;
        int melee_unit_amount;
        int wizard_unit_amount;

        //variables storing how many buildings to spawn per team. Assigned in constructor using form values.
        int T1_resource_building_amount;
        int T2_resource_building_amount;
        int T3_resource_building_amount;

        int T1_factory_building_amount;
        int T2_factory_building_amount;
        int T3_factory_building_amount;


        public void UnitGeneration()
        {
            int randomXposition;
            int randomYposition;
            //generating melee units (Team 1)
            for (int i = 0; i < melee_unit_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
               
                MeleeUnit M = new MeleeUnit(randomXposition, randomYposition, 50, 10, 1, 1, "oP", false,"Warrior");
                meleeUnits.Add(M);
                units.Add(M);
            }
            //generating ranged units (Team 2)
            for (int i = 0; i < ranged_unit_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
                RangedUnit R = new RangedUnit(randomXposition, randomYposition, 50, 10, 5, 1, "o|}", false,"Archer");
                rangedUnits.Add(R);
                units.Add(R);
            }
            //generating wizard units (Team 3)
            for (int i = 0; i < wizard_unit_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
                WizardUnit W = new WizardUnit(randomXposition, randomYposition, 50, 10, 4, 3, "o/*", false, "Wizard");
                wizardUnits.Add(W);
                units.Add(W);
            }
        }
        public void BuildingGeneration()
        {
            int randomXposition;
            int randomYposition;
      
            //generating team 1 resource buildings          
            for (int i = 0; i < T1_resource_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
               
                ResourceBuilding RB = new ResourceBuilding(randomXposition, randomYposition, 100, 1, "[*]", 1);
                resource_buildings.Add(RB);
                buildings.Add(RB);
            }
            //gennerating team 2 resource buildings
            for (int i = 0; i < T2_resource_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
               
                ResourceBuilding RB = new ResourceBuilding(randomXposition, randomYposition, 100, 2, "[+]",1);
                resource_buildings.Add(RB);
                buildings.Add(RB);
            }
            //generating team 3 resource buildings
            for (int i = 0; i < T2_resource_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);

                ResourceBuilding RB = new ResourceBuilding(randomXposition, randomYposition, 100, 3, "[+]",1);
                resource_buildings.Add(RB);
                buildings.Add(RB);
            }
            //generating team 1 factory buildings
            for (int i = 0; i < T1_factory_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
               
                FactoryBuilding FB = new FactoryBuilding(randomXposition, randomYposition, 100,1,"[+]", 3);
                factory_buildings.Add(FB);
                buildings.Add(FB);
            }
            //generating team 2 factory buldngs
            for (int i = 0; i < T2_factory_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
               
                FactoryBuilding FB = new FactoryBuilding(randomXposition, randomYposition, 100, 2, "[+]",3);
                factory_buildings.Add(FB);
                buildings.Add(FB);
            }
            //generating team 3 factory buldngs
            for (int i = 0; i < T3_factory_building_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);

                FactoryBuilding FB = new FactoryBuilding(randomXposition, randomYposition, 100, 3, "[+]", 5);
                factory_buildings.Add(FB);
                buildings.Add(FB);
            }

        }
        public string DisplayMap()
        {
            string text = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map1[i, j] = " ";
                }                
            }

            foreach (RangedUnit R in rangedUnits)
            {
                map1[R.XPos, R.YPos] = R.Symbol;
            }
            foreach (MeleeUnit M in meleeUnits)
            {
                map1[M.XPos, M.YPos] = M.Symbol;
            }
            foreach (WizardUnit W in wizardUnits)
            {
                map1[W.XPos, W.YPos] = W.Symbol;
            }

            //check

            foreach (ResourceBuilding RB in resource_buildings)
            {
                map1[RB.XPos, RB.YPos] = RB.Symbol;
            }
            foreach (FactoryBuilding FB in factory_buildings)
            {
                map1[FB.XPos, FB.YPos] = FB.Symbol;
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    text += map1[i, j];
                }
                text += Environment.NewLine;
            }
            return text;

        }
        public string get_ranged_unit_info()
        {
            string text = "";
            //ranged unit info
            foreach (RangedUnit R in rangedUnits)
            {
                text += R.ToString();
                text += Environment.NewLine;
            }
            return text;
        }
        public string get_melee_unit_info()
        {
            string text = "";
            //melee unit info
            foreach (MeleeUnit M in meleeUnits)
            {
                text += M.ToString();
                text += Environment.NewLine;
            }
            return text;
        }
        public string get_wizard_info()
        {
            string text = "";
            foreach (WizardUnit W in wizardUnits)
            {
                text += W.ToString();
                text += Environment.NewLine;
            }
            return text;
        }
        public string get_resource_building_info()
        {
            string text = "";
            //resource buildiing info
            foreach (ResourceBuilding RB in resource_buildings)
            {
                text += RB.ToString();
                text += Environment.NewLine;
            }
            return text;
        }
        public string get_factory_building_info()
        {
            string text = "";
            //factory building info
            foreach (FactoryBuilding FB in factory_buildings)
            {
                text += FB.ToString();
                text += Environment.NewLine;
            }
            return text;
        }
        public void Unit_Click(object sender, EventArgs e)
        {
            //int x, y;
            //Button b = (Button)sender;
            //x = b.Location.X / 20;
            //y = b.Location.Y / 20;
            //foreach (RangedUnit R in units)
            //{
            //    RangedUnit ru = (RangedUnit)R;
            //    if (ru.XPos == x && ru.YPos == y)
            //    {
            //        textDisplayBox.Text = ru.ToString();
            //    }

            //}
            //foreach (MeleeUnit M in units)
            //{

            //}

        }
      
    }
}
