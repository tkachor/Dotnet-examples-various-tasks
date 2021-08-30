using System;
using Classes.Readonly;

namespace Classes
{
    // Properties

    class Auto
    {
        // Variant_1
        private string brandCar = null;

        public void SetBrandCar(string value)
        {
            brandCar = value;
        }

        public string GetBrand()
        {
            return brandCar;
        }

        // Variant_2
        private string modelCar = null;

        public string ModelCar
        {
            set
            {
                modelCar = value;
            }

            get
            {
                return modelCar;
            }
        }

        // Variant_3
        private int numberOfDoorsInCar = 0;

        public int NumberOfDoorsInCar
        {
            set
            {
                if(2 > numberOfDoorsInCar || numberOfDoorsInCar > 5)
                    Console.WriteLine("You entered an incorrect value");
                else
                    numberOfDoorsInCar = value;
            }

            get
            {                               
                    return numberOfDoorsInCar;
            }
        }

        // Variant_4
        public int YearOfManufacture { get; set; }

        // Variant_5
        private int numberOfWheels = 4;

        public int NumberOfWheels
        {
            get
            {
                return numberOfWheels;
            }
        }

        // Variant_6
        private string fuel = "";

        public string Fuel
        {
            set
            {
                fuel = value;
            }
        }
        

        //Constructors
        public Auto(){}

        public Auto(string brandCar, string modelCar, int numberOfDoorsInCar)
        {
            this.brandCar = brandCar;
            this.modelCar = modelCar;
            this.numberOfDoorsInCar = numberOfDoorsInCar;
        }

        public Auto(int YearOfManufacture)
            : this("Renault", "Clio", 5)
        {
            this.YearOfManufacture = YearOfManufacture;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
           
        }
    }
}
