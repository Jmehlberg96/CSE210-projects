using System;

public class WritingAssignment : Assignment
{
    //Here we declare the WritingAssignment attributes
    private string _title = "";


    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {

        //Here we set the variables that are specific to the WritingAssignment class
        _title = title;
    }

    //Here you see that we were able to use the attribute from the Assignment class because we created
    //a getter method for the attribute StudentName. Otherwise the Assignment class would have blocked us 
    //from retrieving that information due to it being private. We could have changed private to protected and 
    // we would not have had to make the GetStudentName() but then the attribute would not have been as secure.
    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}