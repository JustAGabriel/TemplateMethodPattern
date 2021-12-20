using System.Threading.Channels;

namespace TemplateMethodPattern;

public class Housework : ProcessTemplate
{
    public override void Step1()
    {
        Console.WriteLine("Cutting the gras in the backyard...");
    }

    public override void Step1Done()
    {
        Console.WriteLine("I am so done already! And there are two more tasks!");
    }

    public override void Step2()
    {
        Console.WriteLine("I hate bringing out the garbage...");
    }

    public override void Step2Done()
    {
        Console.WriteLine("Why do trash can's have to stink like that?!");
    }

    public override void FinalStep()
    {
        Console.WriteLine("Ahhh, finally. Walking with my dog. Love it.");
    }

    public override void FinalStepDone()
    {
        Console.WriteLine("Fuzzy has been such a good girl today. I will give her some treats!");
    }
}