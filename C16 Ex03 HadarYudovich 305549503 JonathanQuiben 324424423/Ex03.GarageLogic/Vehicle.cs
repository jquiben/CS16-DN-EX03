using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected readonly string r_PlateNum;
        protected readonly Wheel[] m_VehicleWheels;
        protected string m_ModelName;
        protected float m_PercentageOfLeftResource;
        protected float m_ResourceRemainTime;
        protected float m_ResourceMaxTime;



        public Vehicle(string i_PlateNum)
        {
            r_PlateNum = i_PlateNum;
        }

        public sealed override int GetHashCode()
        {
            return r_PlateNum.GetHashCode();
        }

        public abstract override string ToString();
        public void InflateTires(float i_AmmountToInflate)
        {
            foreach (Wheel WheelToInflate in m_VehicleWheels)
            {
                WheelToInflate.InflateTire(i_AmmountToInflate);
            }
        }

        protected abstract void updatePercentageOfLeftEnergy();
    }
}
