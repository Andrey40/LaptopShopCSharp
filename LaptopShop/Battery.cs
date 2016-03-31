using System;

    class Battery
    {
        private string batteryName;
        private double batteryLife;

        public string BatteryName
        {
            get
            {
                return this.batteryName;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.batteryName = value;
            }
        }
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("This value cannot be negative!");
                }
                this.batteryLife = value;
            }
        }
        public Battery(string batteryName,double batteryLife)
        {
            this.BatteryName = batteryName;
            this.BatteryLife = batteryLife;
        }
    }

