using System;

public class MathAssignment:Assignment{

    //Here we declare the MathAssignment attributes
    private string _textbookSection = "";
    private string _problems = "";

//creating a constructor that has the parent or base constructor attached to it looks like this
//both would return the default information.
    public MathAssignment():base(){
    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
        
        //Here we set the MathAssignment attributes to variables that are specific to this class
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //Here we create a method to show how we want the attributes displayed
    public string GetHomeworkList(){
        return $"Section: {_textbookSection} Problems: {_problems}";
    }

}