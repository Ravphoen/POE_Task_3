using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Gade_Assignment_1
{
    class GameEngine
    {
        public GameEngine()
        {
            roundscompleted = 0;
            map = new Map(15, 12);//declaring number of units and buildings for map class
            map.UnitGeneration();
            map.BuildingGeneration();
        }
        public Map map;

        private int roundscompleted;

        public int RoundsCompleted
        {
            get { return roundscompleted; }
        }

        private int resources;

        public int Resources
        {
            get { return resources; }
        }

        public void startround()
        {
            //combat for ranged units
            foreach (RangedUnit R in map.rangedUnits)
            {
                Unit enemy = checkforenemies(R);
                if (enemy != null)
                {
                    if (R.Health >= 25 / 100 * R.MaxHealth)
                    {
                        //movecloser
                        R.Move(Movecloser());
                        if (enemy is RangedUnit)
                        {
                            R.Move(RunAway());//won't attack team mate
                        }
                        if (enemy is MeleeUnit)
                        {
                            MeleeUnit Enemy = enemy as MeleeUnit;
                            if (R.Can_AttackM(Enemy))
                            {
                                R.CombatM(Enemy);
                            }
                        }
                        if (enemy is WizardUnit)
                        {
                            WizardUnit Enemy = enemy as WizardUnit;
                            if (R.Can_AttackW(Enemy))
                            {
                                R.CombatW(Enemy);
                            }
                        }
                    }
                    else
                    {
                        R.Move(RunAway());
                        //run away 
                    }
                }
                else
                {
                    //do nothing
                }
            }
            //combat for melee units
            foreach (MeleeUnit M in map.meleeUnits)
            {
                Unit enemy = checkforenemies(M);
                if (enemy != null)
                {
                    if (M.Health >= 25 / 100 * M.MaxHealth)
                    {
                        //movecloser
                        M.Move(Movecloser());
                        if (enemy is RangedUnit)
                        {
                            RangedUnit Enemy = enemy as RangedUnit;
                            if (M.Can_AttackR(Enemy))
                            {
                                M.CombatR(Enemy);
                            }
                        }
                        if (enemy is MeleeUnit)
                        {
                            M.Move(RunAway());//won't attack team mate
                        }
                        if (enemy is WizardUnit)
                        {
                            WizardUnit Enemy = enemy as WizardUnit;
                            if (M.Can_AttackW(Enemy))
                            {
                                M.CombatW(Enemy);
                            }
                        }
                    }
                    else
                    {
                        M.Move(RunAway());

                        //run away 
                    }
                }
                else
                {
                    //do nothing
                }
            }
            //combat for wizard units(aoe not implemented)
            foreach (WizardUnit W in map.wizardUnits)
            {
                Unit enemy = checkforenemies(W);
                if (enemy != null)
                {
                    if (W.Health >= 50 / 100 * W.MaxHealth)//if health is above 50%
                    {
                        //movecloser
                        W.Move(Movecloser());
                        //wizards attack everything 
                        if (enemy is RangedUnit)
                        {
                            RangedUnit Enemy = enemy as RangedUnit;
                            if (W.Can_AttackR(Enemy))
                            {
                                W.CombatR(Enemy);
                            }
                        }
                        if (enemy is MeleeUnit)
                        {
                            MeleeUnit Enemy = enemy as MeleeUnit;
                            if (W.Can_AttackM(Enemy))
                            {
                                W.CombatM(Enemy);
                            }
                        }
                        if (enemy is WizardUnit)
                        {
                            WizardUnit Enemy = enemy as WizardUnit;
                            if (W.Can_AttackW(Enemy))
                            {
                                W.CombatW(Enemy);
                            }
                        }
                    }
                    else//runaway
                    {
                        W.Move(RunAway());

                    }
                }
                else
                {
                    //do nothing
                }
            }
            roundscompleted++;
        }
        public void MapUpdate()
        {


        }
        public string Updateunit()
        {
            string info =
                map.get_melee_unit_info()
                + map.get_ranged_unit_info();
            return info;

        }
        public string Updatebuilding()
        {
            string info =
                map.get_factory_building_info()
                + map.get_resource_building_info();
            return info;

        }
        public string Updatedisplay()
        {
            return map.DisplayMap();
        }
        public Unit checkforenemies(Unit lookingforenemies)
        {
            if (lookingforenemies is RangedUnit)
            {
                RangedUnit enemy = lookingforenemies as RangedUnit;
                enemy = lookingforenemies.Closest_Other_EnemyR(map.rangedUnits);
                return enemy;
            }
            else if (lookingforenemies is MeleeUnit)
            {
                MeleeUnit enemy = lookingforenemies as MeleeUnit;
                enemy = lookingforenemies.Closest_Other_EnemyM(map.meleeUnits);
                return enemy;
            }
            //task 3 wizard added
            else if (lookingforenemies is WizardUnit)
            {
                WizardUnit enemy = lookingforenemies as WizardUnit;
                enemy = lookingforenemies.Closest_Other_EnemyW(map.wizardUnits);
                return enemy;
            }

            else
            {
                return null;
            }

        }        
        public Map.Direction RunAway()
        {
            return Map.Direction.North;
        }
        public Map.Direction Movecloser()
        {
            return Map.Direction.West;
        }
        public void Save()
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream("MapInfo.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (FS)
                {
                    BF.Serialize(FS, map);
                    MessageBox.Show("File Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("MapInfo.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fileStream)
                {
                    map = (Map)formatter.Deserialize(fileStream);

                    MessageBox.Show("Game Loaded");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
