using System;

public class Assignment
{
    //Here we declare all the attributes that are specific to this class
    private string _studentName = "";
    private string _topic = "";

//We can create a generic or default constructor like this
    public  Assignment(){
        _studentName = "Anonymous";
        _topic = "Unknown";
    }
    //This constructor passes all the attributes in this class and sets them to variables
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    //If we want to be able to use any of the attributes in this class in any other class we must
    // use a getter method as seen below.
    public string GetStudentName(){
        return _studentName;
    }
    public string GetTopic(){
        return _topic;

    }
    //Here we create a method to show how we want the attributes displayed
    public string GetSummary(){
         return $"{_studentName} - {_topic}";
    }
     
}