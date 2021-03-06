namespace KBEngine
{
  	using UnityEngine; 
	using System; 
	using System.Collections; 
	using System.Collections.Generic;
	
    public class Monster : KBEngine.GameObject  
    {
        public int configID_B;
        public int level;
        public int shoot;
        public int defend;
        public int passBall;
        public int trick;
        public int reel;
        public int steal;
        public int controll;
        public int tech;
        public int keep;
        public int health;
        public int pos;

        public int levelSteal;
        public int levelPass;
        public int coordinate;

        public void set_configID_B(object val)
        {
            object v = getDefinedProperty("configID_B");

            this.configID_B = int.Parse(v.ToString());
        }

        public void set_level(object val)
        {
            object v = getDefinedProperty("level");

            this.level = int.Parse(v.ToString());
        }

        public void set_shoot(object val)
        {
            object v = getDefinedProperty("shoot");

            this.shoot = int.Parse(v.ToString());
        }

        public void set_defend(object val)
        {
            object v = getDefinedProperty("defend");

            this.defend = int.Parse(v.ToString());
        }
        public void set_passBall(object val)
        {
            object v = getDefinedProperty("passBall");

            this.passBall = int.Parse(v.ToString());
        }
        public void set_trick(object val)
        {
            object v = getDefinedProperty("trick");

            this.trick = int.Parse(v.ToString());
        }
        public void set_reel(object val)
        {
            object v = getDefinedProperty("reel");

            this.reel = int.Parse(v.ToString());
        }
        public void set_steal(object val)
        {
            object v = getDefinedProperty("steal");

            this.steal = int.Parse(v.ToString());
        }
        public void set_controll(object val)
        {
            object v = getDefinedProperty("controll");

            this.controll = int.Parse(v.ToString());
        }
        public void set_keep(object val)
        {
            object v = getDefinedProperty("keep");

            this.keep = int.Parse(v.ToString());
        }
        public void set_tech(object val)
        {
            object v = getDefinedProperty("tech");

            this.tech = int.Parse(v.ToString());
        }
        public void set_health(object val)
        {
            object v = getDefinedProperty("health");

            this.health = int.Parse(v.ToString());
        }
        public void set_pos(object val)
        {
            object v = getDefinedProperty("pos");

            this.pos = int.Parse(v.ToString());
        }

         public void set_levelSteal(object val)
        {
            object v = getDefinedProperty("levelSteal");

            this.levelSteal = int.Parse(v.ToString());
        }
        public void set_levelPass(object val)
        {
            object v = getDefinedProperty("levelPass");

            this.levelPass = int.Parse(v.ToString());
        }
        public void set_coordinate(object val)
        {
            object v = getDefinedProperty("coordinate");

            this.coordinate = int.Parse(v.ToString());
        }
    }
} 
