class BreathingAct : Activity
{
    private string message_1= "Breath in...";

    private string message_2= "Breath out...";
    private string _description= "this activity is designed to help you relax and focus on your breathing";
    public BreathingAct(string nameparam, int durationparam) : base(nameparam, durationparam)
    {

    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
    public void breating(int seconds){
        Console.WriteLine();
        int timer=0;
        while(timer<seconds){
            Console.WriteLine();
            for(int i=4; i>0;i--){
                Console.WriteLine($"{message_1} {i}");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                timer+=1;

            }
            Console.WriteLine($"{message_1}");
            for(int i=5; i>0;i--){
                Console.WriteLine($"{message_2} {i}");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                timer+=1;
            }
            Console.WriteLine($"{message_2}");

        }
    }

    
}