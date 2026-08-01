public class Program
{

    // Mobile
    // Mobiles:- SamsungKeypad , Android , Iphone
    // common functionality:- SamsungKeypad , Android , Iphone :- Calling , Msg  
    // APIe: - Abstraction :- show only nececery things and hide complexity 
    // Polymorphism :- it's behave at runtime and there is two types of ploymorphsim
           // compile time polymorphism :- it is desided while compiling the application 
           // runtime polymorphism:- 

    // check mobile balance

    // encapsulation :- protected methods and properties from internal classes or methods they dont have rigths to
    // interfare in methods 

    public abstract class Mobile //partial parent class
    {
    //    public string? mobile { get; set; }
        
        public abstract void Calling(string mobile);
        public abstract void Msg(string msg, string DND,string mobile);
        public abstract decimal CheckBalance(string mobile);

        

        protected bool validateMobileNumber(string Mobile)
        {

            if (string.IsNullOrEmpty(Mobile))
            {

                Console.WriteLine("Enter Number");
                return false;
            }
            else {
                return true;
            }
        
        }
    
    }
   

       

    public class SamsungKeypad : Mobile
    {

        public override void Calling(string mobile) // lkanvkvbh-=00_+(+(m ;oJDD][\'/
        {

            if (validateMobileNumber(mobile))
            {
                Console.WriteLine($"calling to {mobile} started from SamsunKeypad");
            }
           
        
        }

        public override void Msg(string msg,string DND,string mobile) // lkanvkvbh-=00_+(+(m ;oJDD][\'/
        {

            if (validateMobileNumber(mobile))
            {
                Console.WriteLine($"msg to {mobile} started from SamsunKeypad");
            }


        }
        public override decimal CheckBalance(string mobile)
        {

            Console.WriteLine("Check balance");
            return 1000;
        }


    }
    public class Android : Mobile
    {
        public override void Calling(string mobile)
        {
            Console.WriteLine($"calling to {mobile} started from Android");

        }
        public override void Msg(string msg, string DND,string mobile) // lkanvkvbh-=00_+(+(m ;oJDD][\'/
        {

            if (validateMobileNumber(mobile))
            {
                Console.WriteLine($"msg to {mobile} started from android");
            }


        }
        public override decimal CheckBalance(string mobile)
        {

            Console.WriteLine("Check balance");
            return 1000;
        }
    }
    public class Iphone : Mobile
    {
        public override void Calling(string mobile)
        {
            Console.WriteLine($"calling to {mobile} started from iphone");

        }
        public override void Msg(string msg, string DND,string mobile) // lkanvkvbh-=00_+(+(m ;oJDD][\'/
        {

            if (validateMobileNumber(mobile))
            {
                Console.WriteLine($"msg to {mobile} started from iphone"); ///////////////////
            }


        }
        public void Calling(string mobile, string fromchild)
        {
            Console.WriteLine("calling from child");
        }

        public override decimal CheckBalance(string mobile)
        {

            Console.WriteLine("Check balance");
            return 1000;
        }

    }


    public static void Main(string[] args)
    {

        Mobile mob;
        mob = new SamsungKeypad();
        mob.Calling("+919673178777");
        mob.Msg("hi","Y", "+919673178777");



        mob = new Android();
        mob.Calling("+919028578777");
        mob.Msg( "hi", "Y","+919673178777");

        mob = new Iphone();
        
        mob.Calling("+1234");

        
        mob.Msg("hi", "Y", "+919673178777");


        Iphone i = (Iphone)mob;
        i.Calling("+919673178777", "");




    }


}