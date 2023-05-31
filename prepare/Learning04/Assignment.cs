public class Assignment
{
    private string _studentName;
    private  string _topic;

    public  Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }

    /* After completing the assignment I viewed the sample exercise.  I see that it uses
       getter and setter methods to make the attributes here accessible to outside code.
       I believe I understand how that works and why it would be useful in many cases.  
       Since I was able to complete the assignment with proper output without using those 
       methods, I have decided not to update my code to be more like the example. */
}