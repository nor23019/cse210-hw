public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>          //List of prompts
        {
            "What was the best part of your day today? Describe it in detail.",
            "What is something new you learned today, and how did it change your perspective?",
            "What is one thing you could have done better today? How will you address it tomorrow?",
            "What is a small win that you achieved today? Why does it matter to you?",
            "Write about a conversation you had today that made an impact on you. What did you take away from it?",
            "If today had a theme, what would it be and why?",
            "What emotions did you experience most strongly today? What do you think triggered them?",
            "What are three things you are grateful for today, and what makes them meaningful to you?",
            "What did you do today to bring you closer to your goals?",
            "Describe a challenge you faced today. What did you learn from it, and how will it shape your actions moving forward?"
        };
    }   

     public string GetRandomPrompt()            //Method to obtaina  random prompt
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
