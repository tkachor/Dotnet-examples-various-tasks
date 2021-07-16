using System;

namespace Classes
{
    // Properties

    class Auto
    {
        // variant_1
        private string brandCar = null;

        public void SetBrandCar(string value)
        {
            brandCar = value;
        }

        public string GetBrand()
        {
            return brandCar;
        }

        // variant_2
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

        // variant_3
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

        // variant_4
        public int YearOfManufacture { get; set; }

    }





    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
