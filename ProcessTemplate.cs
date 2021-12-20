
namespace TemplateMethodPattern;

public abstract class ProcessTemplate
{
    public void ComplicatedProcess()
    {
        SimpleSetup();
        Step1();
        Step1Done();
        Step2();
        Step2Done();
        FinalStep();
        FinalStepDone();
        Breakdown();
    }
    
    // static parts of the algorithm
    private void SimpleSetup()
    {
        Console.WriteLine("Setting everything up...");
    }

    private void Breakdown()
    {
        Console.WriteLine("The complicated process is finished - time for some clean-up!");
    }

    // optional hooks
    public virtual void Step1Done() { }
    public virtual void Step2Done(){ }
    public virtual void FinalStepDone(){ }
    
    // mandatory parts each subclass has to implement
    public abstract void Step1();
    public abstract void Step2();
    public abstract void FinalStep();
}