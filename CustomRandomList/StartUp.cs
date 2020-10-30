using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList vs = new RandomList();
            vs.Add("ceco");
            vs.Add("didi");
            vs.Add("kalin");
            vs.Add("veronika");
            vs.Add("pesho");
            //vs.Add("ivan");
            //vs.Add("dragan");
            //vs.Add("mirko");
            //vs.Add("canko");
            //vs.Add("stoiko");
            //vs.Add("boiko");
            //vs.Add("petkan");
            //vs.Add("stoyan");

            vs.RandomString();
            Console.WriteLine(string.Join(", ", vs));
        }
    }
}
