using System;

namespace Patern_State
{
    // Iterface of states
    abstract class State
    {
        public abstract void warm_up(Context context);
        public abstract void cool(Context context);

    }
    class Liquid_state : State
    {
        public Liquid_state(Context context)
        {
            context.state_name = "Liquid state";
        }
        public override void warm_up(Context context)
        {
            context.state = new Gaseous_state(context);
        }
        public override void cool(Context context)
        {
            context.state = new Solid_state(context);
        }
    }
    class Solid_state : State
    {
        public Solid_state(Context context)
        {
            context.state_name = "Solid state";
        }
        public override void warm_up(Context context)
        {
            context.state = new Liquid_state(context);
        }
        public override void cool(Context context) { }
    }
    class Gaseous_state : State
    {
        public Gaseous_state(Context context)
        {
            context.state_name = "Gaseous state";
        }
        public override void warm_up(Context context) { }
        public override void cool(Context context)
        {
            context.state = new Solid_state(context);
        }
    }

    // Context water
    class Context
    {
        public string state_name;
        public State state { get; set; }
        public Context()
        {
            this.state = new Liquid_state(this);
        }
        public void Warm_up()
        {
            this.state.warm_up(this);
        }
        public void Cool()
        {
            this.state.cool(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string choice="";
            Context context = new Context();
            while (choice != "0")
            {
                Console.WriteLine("Your action : \n" +
                     "1. warm up\n" +
                     "2. cool\n" +
                     "0. exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    context.Warm_up();
                    Console.WriteLine(context.state_name);
                }
                else if (choice == "2")
                {
                    context.Cool();
                    Console.WriteLine(context.state_name);
                }
            }
        }
    }
}
