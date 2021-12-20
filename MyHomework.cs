namespace TemplateMethodPattern;

public class MyHomework : ProcessTemplate
{
    public override void Step1()
    {
        Console.WriteLine("Doing some math now...");
    }

    public override void Step1Done()
    {
        Console.WriteLine("Meth after math!");
    }

    public override void Step2()
    {
        Console.WriteLine("Doing some physics now...");
    }

    public override void Step2Done()
    {
        Console.WriteLine("Let's go grab some coffee. I earned it.");
    }

    public override void FinalStep()
    {
        Console.WriteLine("Finishing some biology homework...");
    }

    public override void FinalStepDone()
    {
        Console.WriteLine("F**k yeah! I love learning - being challenged in general.");
    }
}