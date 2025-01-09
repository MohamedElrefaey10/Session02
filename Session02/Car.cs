using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    internal class Car
    {

        public int Id { get; set; }

        public string Model { get; set; }

        public double Speed { get; set; }

        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("Constr_01");
        }

        public Car(int id, string model):this(id, model,390)
        {
            //Id = id;
            //Model = model;
            //Speed = 290;
            Console.WriteLine("Constr_02");
        }

        public Car(int id):this(id,"AUDI",350)
        {
            //Id = id;
            //Model = "AUDI";
            //Speed = 350;
            Console.WriteLine("Constr_03");
        }

        public override string ToString()
        {
            return $"Id :: {Id}\nModel :: {Model}\nSpeed :: {Speed}";
        }



    }
}
