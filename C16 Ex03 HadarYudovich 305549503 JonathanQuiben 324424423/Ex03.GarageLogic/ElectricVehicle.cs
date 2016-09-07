using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class ElectricVehicle : Vehicle
    {

        public ElectricVehicle(string i_PlateNum) : base(i_PlateNum)
        { }

        public void ChargeBattery(float i_HoursToAdd)
        {
            float PercentageOfEnergyToAdd = (i_HoursToAdd / m_ResourceMaxTime) * 100f;
            if (PercentageOfEnergyToAdd + m_PercentageOfLeftResource <= 100)
            {
                m_ResourceRemainTime += i_HoursToAdd;
                updatePercentageOfLeftEnergy();
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }

        protected sealed override void updatePercentageOfLeftEnergy()
        {
            m_PercentageOfLeftResource = (m_ResourceRemainTime / m_ResourceRemainTime) * 100f;
        }
    }
}