using System;


public interface IPerson
{
	public void Talk(string message);
}
public class Person
{
	private int age;
	private string fName;
	private string lName;
	private float height;
	private float weight;


	public int Age
	{
		get
		{
			return age;
		}
		set
		{
            
            if (value <= 0)
			{
				throw new ArgumentException("You are only allowed to enter an age above 0");
			}
			else
			{
                age = value;
            }
            
        }
	}

	public string FName 
	{
		get
		{
			return fName;

		}
		set
		{
		
			if (value.Length < 2)
			{
				throw new ArgumentException("First Name cannot be shorter than 2 letters");
			}
            else if (value.Length > 10)
            {
                throw new ArgumentException("First Name cannot be longer than 10 letters");
            }
			else
			{
                fName = value;
            }
        }
	}

	public string LName
	{
        get
        {
            return lName;

        }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last Name cannot be shorter than 3 letters");
            }
            else if (value.Length > 15)
            {
                throw new ArgumentException("Last Name cannot be longer than 15 letters");
            }
			else
			{
                lName = value;
            }
        }
    }
	
	public float Height 
	{ 
		get 
		{
			return height;
		} 
		set 
		{ 
			height = value; 
		} 
	}

    public float Weight
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
        }
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Person(string fName, string lName)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
		FName = fName;


		LName = lName;
	}

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Person(int age, string fName, string lName, float height, float weight)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
		Age = age;
        FName = fName;
        LName = lName;
		Height = height;
		Weight = weight;
    }


}
