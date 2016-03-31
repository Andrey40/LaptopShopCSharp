using System;

    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private decimal price;
        Battery battery;
        private string p1;
        private string p2;
        private string p3;
        private int p4;
        private string p5;
        private string p6;
        private string p7;
        private string p8;
        private double p9;
        private decimal p10;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, string manufacturer, string processor, int ram,
         string graphicCard, string hdd, string screen, decimal price, string batteryName,
         double batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicCard = graphicCard;
            this.HDD = hdd;
            this.Model = model;
            this.Price = price;
            this.battery = new Battery(batteryName, batteryLife);
        }

        public Laptop(string p1, string p2, string p3, int p4, string p5, string p6, string p7, string p8, double p9, decimal p10)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
            this.p7 = p7;
            this.p8 = p8;
            this.p9 = p9;
            this.p10 = p10;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.Empty==value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.processor = value;
            }
        }
        public int RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("This value must be positive!");
                }
                this.ram = value;
            }
        }
        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.graphicCard = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.HDD;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.HDD = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.Empty == value)
                {
                    throw new Exception("This value cannot be empty!");
                }
                this.screen = value;
            }
        }
       
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<=0)
                {
                    throw new Exception("This value must be positive!");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        static void Main(string[] args)
        {
            Laptop firstLaptop = new Laptop("Lenovo", "Yoga 2 Pro Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8,
"Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
"Li-Ion, 4-cells, 2550 mAh", 4.5d, 2259.00m);
            Console.WriteLine(firstLaptop.model);
        }
    }
