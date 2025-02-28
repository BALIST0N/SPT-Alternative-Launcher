﻿namespace SPT_Alt_Launcher
{
    public class ProfileExtended
    {
        public Info info;
        public Skills skills;
        public Hideout hideout;
        public Dictionary<string, Trader> TradersInfo;

        public class Info
        {
            public string nickname;
            public string side;
            public int experience;
            public string gameVersion;
        }

        public class Skills
        {
            public List<Skill> common;
            public List<Mastering> mastering;
            public class Skill
            {
                public string id;
                public decimal progress;
                public decimal pointsEarnedDuringSession;
                public int lastAcces;
            }
            public class Mastering
            {
                public string id;
                public decimal progress;
            }
        }

        public int GetSkillValue(string skill)
        {
            int i = Convert.ToInt32(this.skills.common.Find(x => x.id.Equals(skill))?.progress);
            if(i > 5100){ i = 5100; }
            return i;
        }

        public void SetSkillValue(string skill, decimal newval)
        {
            try
            {
                this.skills.common.Find(x => x.id.Equals(skill)).progress = newval;
            }
            catch(NullReferenceException e)
            {
                MessageBox.Show("unable to modify the skill " + skill + ", maybe it doesn't exist in the profile ? " );
            }
        }

        public class Hideout
        {
            public List<Area> areas;
            public partial class Area
            {
                public int type;
                public int level;
                public bool active;
                public bool passiveBonusesEnabled;
				public int completeTime;
				public bool constructing;
				public object[] slots;
            }
        }

        public class Trader
        {
            public int loyaltyLevel;
            public int salesSum;
            public decimal standing;
            public int nextResupply;
            public bool unlocked;

        }
    }
}
