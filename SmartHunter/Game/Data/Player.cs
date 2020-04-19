using System;
using System.Collections.Generic;
using SmartHunter.Core.Data;

namespace SmartHunter.Game.Data
{
    public class Player : Bindable, IComparable<Player>
    {
        int m_Index;

        public int Index
        {
            get { return m_Index; }
            set { SetProperty(ref m_Index, value); }
        }

        string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { SetProperty(ref m_Name, value); }
        }

        ushort m_HR;
        public ushort HR
        {
            get { return m_HR; }
            set { SetProperty(ref m_HR, value); }
        }

        ushort m_MR;
        public ushort MR
        {
            get { return m_MR; }
            set { SetProperty(ref m_MR, value); }
        }

        int m_Damage;
        public int Damage
        {
            get { return m_Damage; }
            set { SetProperty(ref m_Damage, value); }
        }

        float m_DamageFraction;
        public float DamageFraction
        {
            get { return m_DamageFraction; }
            set { SetProperty(ref m_DamageFraction, value); }
        }

        float m_BarFraction;
        public float BarFraction
        {
            get { return m_BarFraction; }
            set { SetProperty(ref m_BarFraction, value); }
        }

        readonly Queue<(DateTime, int)> m_damageHistory = new Queue<(DateTime, int)>();
        public Queue<(DateTime, int)> DamageHistory => m_damageHistory;

        DateTime m_CombatStart;
        public DateTime CombatStart
        {
            get { return m_CombatStart; }
            set { SetProperty(ref m_CombatStart, value); }
        }

        double m_CurrentDPS;
        public double CurrentDPS
        {
            get { return m_CurrentDPS; }
            set { SetProperty(ref m_CurrentDPS, value); }
        }

        double m_DamagePerSecond;

        public double DamagePerSecond
        {
            get { return m_DamagePerSecond; }
            set { SetProperty(ref m_DamagePerSecond, value); }
	}

        public int CompareTo(Player other)
        {
            if (this.Damage == 0 && other.Damage == 0)
                return -1;
            return this.DamageFraction > other.DamageFraction ? 0 : 1;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}%", this.Name, this.Damage, (this.DamageFraction * 100).ToString("0.##"));
        }
    }
}
