using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class BattNiCa : Battery
    {
        public const int MAXLIFE_NICA = 200;
        private int _currentLife;
        private int _maxLife;


        /// <summary>
        /// Reports the battery's maximum life.
        /// </summary>
        public int MaxLife
        {
            get { return MAXLIFE_NICA; }

        }

        /// <summary>
        /// Reports and Modifies the state of the battery's current life.
        /// </summary>
        public override int CurrentLife
        {
            get { return _currentLife; }
            set
            {
                if (_currentLife > MAXLIFE_NICA)
                {
                    throw new ArgumentOutOfRangeException("_currentLife", "This value cannot be greater than the maximum battery life.");
                }
                if (_currentLife < 0)
                {
                    throw new ArgumentOutOfRangeException("_currentLife", "This value cannot be less than 0.");
                }
                _currentLife = value;
            }
        }

        public BattNiCa(BatteryType battType, int currentLife, int maxLife)
            : base(BatteryType.NickelCadium)
        {
            if (currentLife > MAXLIFE_NICA)
            {
                throw new ArgumentOutOfRangeException("currentLife", "This value cannot be greater tha the max life");
            }
            if (currentLife < 0)
            {
                throw new ArgumentOutOfRangeException("currentLife", "This value cannot be less than zero");
            }
            if (maxLife != 200)
            {
                throw new ArgumentOutOfRangeException("maxLife", "This value must equal 100.");
            }
            _currentLife = MAXLIFE_NICA;
            _maxLife = maxLife;
        }

        public override void ChargeBattery()
        {
            this.CurrentLife += 30;
        }
    }
}
